using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEARNING_EF_CORE_WITH_SQLITE
{
    public partial class CategoryForm : Form
    {
        #region Constructors
        public CategoryForm()
        {
            InitializeComponent();

            Category = new();
        }
        #endregion /Constructors

        #region Properties
        public Domain.Category Category { get; set; }

        #endregion /Properties

        #region Methods
        private async Task RefreshFormAsync()
        {
            Category = new();

            CategoryIdTextBox.Text =
                Category.CategoryId.ToString();

            CategoryNameTextBox.ResetText();

            CategoryIsActiveComboBox.SelectedIndex = -1;

            CategoryNameTextBox.Focus();

            await FillDataGridAsync();
        }

        private async Task FillDataGridAsync()
        {
            Persistence.DatabaseContext? databaseContext = null;

            try
            {
                databaseContext =
                    new Persistence.DatabaseContext();

                var data = await
                    databaseContext.Categories
                    .ToListAsync()
                    ;

                CategoryDataGridView.DataSource = data;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (databaseContext != null)
                {
                    await
                        databaseContext
                        .DisposeAsync()
                        ;
                }
            }
        }
        #endregion /Methods

        #region Events
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void CategoryForm_Load(object sender, EventArgs e)
        {
            await FillDataGridAsync();

            CategoryIdTextBox.Text =
                Category.CategoryId.ToString();

            CategoryNameTextBox.Focus();
        }

        //Wrong usage! ... Dont use Task for events that define async
        //private async Task AddButton_ClickAsync(object sender, EventArgs e)
        private async void AddButton_ClickAsync(object sender, EventArgs e)
        {
            Persistence.DatabaseContext? databaseContext = null;

            try
            {
                databaseContext =
                    new Persistence.DatabaseContext();

                Category.CategoryName =
                    CategoryNameTextBox.Text;

                Category.IsActive =
                    (CategoryIsActiveComboBox.SelectedIndex == 0);

                var entityIsValid =
                    Infrastructure.ValidationHelper.IsValid(entity: Category);

                if (entityIsValid)
                {
                    await
                        databaseContext
                        .AddAsync(entity: Category)
                        ;

                    await
                         databaseContext
                         .SaveChangesAsync()
                         ;

                    string message =
                     string.Format(Resources.Messages.SuccessesMessages.Created,
                      Resources.DataDictionary.CategoryName);

                    MessageBox.Show(message);

                   await RefreshFormAsync();
                }
                else
                {
                    var errors =
                        Infrastructure.ValidationHelper
                        .GetValidationResults(entity: Category);

                    StringBuilder error = new();

                    foreach (var item in errors)
                    {
                        error.AppendLine(item.ErrorMessage);
                    }

                    MessageBox.Show(error.ToString());
                }


            }
            catch (Exception ex)
            {
                //log error!

                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (databaseContext != null)
                {
                    await
                        databaseContext
                        .DisposeAsync()
                        ;
                }
            }
        }

    }
    #endregion /Events
}
