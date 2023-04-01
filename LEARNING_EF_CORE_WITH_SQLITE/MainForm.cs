using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEARNING_EF_CORE_WITH_SQLITE
{
    public partial class MainForm : Form
    {
        #region Constructors
        public MainForm()
        {
            InitializeComponent();

            ShadowControls =
                new List<Control>();
        }
        #endregion /Constructors

        #region Properties
        public ICollection<Control> ShadowControls { get; set; }

        public Bitmap ShadowBitmap { get; set; }

        public bool MyFlag { get; set; }

        #endregion /Properties

        #region Events
        private void MainForm_Load(object sender, EventArgs e)
        {
            Azx.CircleButton circleButton = new Azx.CircleButton();
        }

        private void firstTimer_Tick(object sender, EventArgs e)
        {
            MenuPanel.Width += 5;
            if (MenuPanel.Width == 200)
            {
                firstTimer.Stop();

                foreach (var item in MenuPanel.Controls)
                {
                    var button = item as Button;
                    if (button != null)
                    {
                        button.Visible = true;
                    }
                }

                ShadowControls.Add(MenuPanel);
                this.Refresh();
            }
        }

        private void secondTimer_Tick(object sender, EventArgs e)
        {
            MenuPanel.Width -= 5;

            this.BackColor = SystemColors.Control;

            this.Refresh();

            if (MenuPanel.Width <= 0)
            {
                secondTimer.Stop();
                topPanel.Show();
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            MyFlag = true;
            topPanel.Hide();
            firstTimer.Start();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            if (MyFlag)
            {
                if (ShadowBitmap == null || ShadowBitmap.Size != this.Size)
                {
                    ShadowBitmap?.Dispose();
                    ShadowBitmap =
                        new Bitmap(this.Width, this.Height, PixelFormat.Format32bppArgb);
                }

                foreach (Control control in ShadowControls)
                {
                    using (GraphicsPath graphicsPath = new GraphicsPath())
                    {
                        graphicsPath.AddRectangle(
                            new Rectangle(
                                control.Location.X,
                                control.Location.Y,
                                control.Size.Width,
                                control.Size.Height));

                        Azx.DropShadow.DrawShadowSmooth(graphicsPath, 100, 60, ShadowBitmap);
                    }

                    e.Graphics.DrawImage(ShadowBitmap, new Point(0, 0));
                }
            }
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            MyFlag = false;
            secondTimer.Start();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;

            if (button != null)
            {
                if (button.Parent is not null)
                {
                    foreach (var item in button.Parent.Controls)
                    {
                        if (item is Button)
                        {
                            (item as Button).FlatAppearance.BorderColor = Color.Empty;
                        }
                    }
                }

                button.FlatAppearance.BorderColor = Color.Red;

                switch (button.Name)
                {
                    case "categoryButton":
                        {

                            var categoryForm = new CategoryForm();

                            categoryForm.Owner = this;

                            categoryForm.Show();

                            break;
                        }
                    case "productButton":
                        {
                            var productForm = new ProductForm();

                            productForm.Owner = this;

                            productForm.Show();

                            break;
                        }
                    case "reportButton":
                        {
                            var reportForm = new ReportForm();

                            reportForm.Owner = this;

                            reportForm.Show();

                            break;
                        }
                    case "exitButton":
                        {
                            this.Close();

                            break;
                        }
                }
            }

        }
        #endregion /Events

        //private void productButton_Click(object sender, EventArgs e)
        //{

        //}
    }
}
