namespace LEARNING_EF_CORE_WITH_SQLITE
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            productIdLabel = new Label();
            ProductIdTextBox = new TextBox();
            ProductNameTextBox = new TextBox();
            ProductNameLabel = new Label();
            label1 = new Label();
            AmountNumericUpDown = new NumericUpDown();
            IsActiveLabel = new Label();
            IsActiveComboBox = new ComboBox();
            AddButton = new Button();
            UpdateButton = new Button();
            DeleteButton = new Button();
            ExitButton = new Button();
            CategoryComboBox = new ComboBox();
            CategoryLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)AmountNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // productIdLabel
            // 
            productIdLabel.AutoSize = true;
            productIdLabel.Location = new Point(396, 39);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new Size(108, 27);
            productIdLabel.TabIndex = 0;
            productIdLabel.Text = "شناسه محصول";
            // 
            // ProductIdTextBox
            // 
            ProductIdTextBox.Location = new Point(27, 36);
            ProductIdTextBox.Name = "ProductIdTextBox";
            ProductIdTextBox.ReadOnly = true;
            ProductIdTextBox.Size = new Size(363, 35);
            ProductIdTextBox.TabIndex = 1;
            // 
            // ProductNameTextBox
            // 
            ProductNameTextBox.Location = new Point(27, 88);
            ProductNameTextBox.Name = "ProductNameTextBox";
            ProductNameTextBox.Size = new Size(363, 35);
            ProductNameTextBox.TabIndex = 0;
            ProductNameTextBox.KeyPress += ProductNameTextBox_KeyPress;
            // 
            // ProductNameLabel
            // 
            ProductNameLabel.AutoSize = true;
            ProductNameLabel.Location = new Point(409, 91);
            ProductNameLabel.Name = "ProductNameLabel";
            ProductNameLabel.Size = new Size(85, 27);
            ProductNameLabel.TabIndex = 2;
            ProductNameLabel.Text = "نام محصول";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(401, 184);
            label1.Name = "label1";
            label1.Size = new Size(103, 27);
            label1.TabIndex = 4;
            label1.Text = "قیمت محصول";
            // 
            // AmountNumericUpDown
            // 
            AmountNumericUpDown.InterceptArrowKeys = false;
            AmountNumericUpDown.Location = new Point(257, 182);
            AmountNumericUpDown.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            AmountNumericUpDown.Name = "AmountNumericUpDown";
            AmountNumericUpDown.Size = new Size(133, 35);
            AmountNumericUpDown.TabIndex = 1;
            AmountNumericUpDown.TextAlign = HorizontalAlignment.Center;
            AmountNumericUpDown.ThousandsSeparator = true;
            AmountNumericUpDown.KeyPress += AmountNumericUpDown_KeyPress;
            // 
            // IsActiveLabel
            // 
            IsActiveLabel.AutoSize = true;
            IsActiveLabel.Location = new Point(419, 235);
            IsActiveLabel.Name = "IsActiveLabel";
            IsActiveLabel.Size = new Size(63, 27);
            IsActiveLabel.TabIndex = 6;
            IsActiveLabel.Text = "وضعیت";
            // 
            // IsActiveComboBox
            // 
            IsActiveComboBox.FormattingEnabled = true;
            IsActiveComboBox.Items.AddRange(new object[] { "فعال", "غیر فعال" });
            IsActiveComboBox.Location = new Point(257, 232);
            IsActiveComboBox.Name = "IsActiveComboBox";
            IsActiveComboBox.Size = new Size(133, 35);
            IsActiveComboBox.TabIndex = 2;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(375, 307);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(115, 34);
            AddButton.TabIndex = 8;
            AddButton.Text = "ذخیره";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Enabled = false;
            UpdateButton.Location = new Point(254, 307);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(115, 34);
            UpdateButton.TabIndex = 9;
            UpdateButton.Text = "اصلاح";
            UpdateButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            DeleteButton.Enabled = false;
            DeleteButton.Location = new Point(133, 307);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(115, 34);
            DeleteButton.TabIndex = 10;
            DeleteButton.Text = "حذف";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(12, 307);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(115, 34);
            ExitButton.TabIndex = 11;
            ExitButton.Text = "خروج";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Items.AddRange(new object[] { "فعال", "غیر فعال" });
            CategoryComboBox.Location = new Point(27, 135);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(363, 35);
            CategoryComboBox.TabIndex = 12;
            CategoryComboBox.KeyPress += CategoryComboBox_KeyPress;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(413, 140);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(82, 27);
            CategoryLabel.TabIndex = 13;
            CategoryLabel.Text = "دسته بندی";
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 353);
            Controls.Add(CategoryComboBox);
            Controls.Add(CategoryLabel);
            Controls.Add(ExitButton);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(AddButton);
            Controls.Add(IsActiveComboBox);
            Controls.Add(IsActiveLabel);
            Controls.Add(AmountNumericUpDown);
            Controls.Add(label1);
            Controls.Add(ProductNameTextBox);
            Controls.Add(ProductNameLabel);
            Controls.Add(ProductIdTextBox);
            Controls.Add(productIdLabel);
            Font = new Font("IRANSans(FaNum)", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "ProductForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "فرم ایجاد محصولات";
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)AmountNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label productIdLabel;
        private TextBox ProductIdTextBox;
        private TextBox ProductNameTextBox;
        private Label ProductNameLabel;
        private Label label1;
        private NumericUpDown AmountNumericUpDown;
        private Label IsActiveLabel;
        private ComboBox IsActiveComboBox;
        private Button AddButton;
        private Button UpdateButton;
        private Button DeleteButton;
        private Button ExitButton;
        private ComboBox CategoryComboBox;
        private Label CategoryLabel;
    }
}