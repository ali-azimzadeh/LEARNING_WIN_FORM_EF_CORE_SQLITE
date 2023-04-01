using Domain;
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

namespace LEARNING_EF_CORE_WITH_SQLITE;

public partial class ProductForm : Form
{
    #region Constructors
    public ProductForm()
    {
        InitializeComponent();

        Product = new();
    }
    #endregion /Constructors

    #region Properties 
    public Domain.Product Product { get; set; }
    #endregion /Properties

    #region Events
    private void ProductNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == 13)
        {
            CategoryComboBox.Focus();
        }
    }

    private void AmountNumericUpDown_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == 13)
        {
            IsActiveComboBox.Focus();
        }
    }

    private void ExitButton_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void CategoryComboBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == 13)
        {
            AmountNumericUpDown.Focus();
        }
    }

      private async void AddButton_Click(object sender, EventArgs e)
    {
        Persistence.DatabaseContext? databaseContext = null;

        try
        {
            databaseContext =
                new Persistence.DatabaseContext();

            Product.ProductName =
                ProductNameTextBox.Text;

            Product.IsActive =
                (IsActiveComboBox.SelectedIndex == 0);

            Product.CategoryId =
                      Guid.Parse(input: CategoryComboBox.SelectedValue.ToString());

            Product.Amount = 
                (int) AmountNumericUpDown.Value;

            var entityIsValid =
                Infrastructure.ValidationHelper.IsValid(entity: Product);

            if (entityIsValid)
            {
                await
                    databaseContext
                    .AddAsync(entity: Product)
                    ;

                await
                     databaseContext
                     .SaveChangesAsync()
                     ;

                // MessageBox.Show("کاربر گرامی اطلاعات با موفقیت ثبت شد");
                string message = 
                    string.Format(Resources.Messages.SuccessesMessages.Created,
                    Resources.DataDictionary.ProductName);

                MessageBox.Show(message);

                RefreshForm();
            }
            else
            {
                var errors =
                    Infrastructure.ValidationHelper
                    .GetValidationResults(entity: Product);

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
  

    private async void ProductForm_Load(object sender, EventArgs e)
    {
        Persistence.DatabaseContext? databaseContext = null;

        try
        {
            databaseContext =
                new Persistence.DatabaseContext();

            var items = await
                databaseContext.Categories
                .ToListAsync()
                ;

            CategoryComboBox.DisplayMember = 
                nameof(Resources.DataDictionary.CategoryName);

            CategoryComboBox.ValueMember =
                nameof(Resources.DataDictionary.CategoryId);

            CategoryComboBox.DataSource = items;

            ProductIdTextBox.Text =
                Product.ProductId.ToString();

            ProductIdTextBox.Focus();

        }
        catch (Exception ex)
        {
            //log error
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
    #endregion /Events

    #region Methods
    private void RefreshForm()
    {
        Product = new();

        ProductIdTextBox.Text =
            Product.ProductId.ToString();

        ProductNameTextBox.ResetText();

        IsActiveComboBox.SelectedIndex = -1;

        CategoryComboBox.SelectedIndex = -1;

        ProductIdTextBox.Focus();

    }
    #endregion /Methods
}
