namespace LEARNING_EF_CORE_WITH_SQLITE
{
    partial class CategoryForm
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
            ExitButton = new Button();
            DeleteButton = new Button();
            UpdateButton = new Button();
            AddButton = new Button();
            CategoryIsActiveComboBox = new ComboBox();
            IsActiveLabel = new Label();
            CategoryNameTextBox = new TextBox();
            ProductNameLabel = new Label();
            CategoryIdTextBox = new TextBox();
            categoryIdLabel = new Label();
            CategoryDataGroupBox = new GroupBox();
            CategoryDataGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            IsActive = new DataGridViewTextBoxColumn();
            IsDeleted = new DataGridViewTextBoxColumn();
            CategoryDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CategoryDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(22, 194);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(102, 43);
            ExitButton.TabIndex = 21;
            ExitButton.Text = "خروج";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Enabled = false;
            DeleteButton.Location = new Point(143, 194);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(102, 43);
            DeleteButton.TabIndex = 20;
            DeleteButton.Text = "حذف";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            UpdateButton.Enabled = false;
            UpdateButton.Location = new Point(264, 194);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(102, 43);
            UpdateButton.TabIndex = 19;
            UpdateButton.Text = "اصلاح";
            UpdateButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(385, 194);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(102, 43);
            AddButton.TabIndex = 18;
            AddButton.Text = "ذخیره";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_ClickAsync;
            // 
            // CategoryIsActiveComboBox
            // 
            CategoryIsActiveComboBox.FormattingEnabled = true;
            CategoryIsActiveComboBox.Items.AddRange(new object[] { "فعال", "غیر فعال" });
            CategoryIsActiveComboBox.Location = new Point(234, 126);
            CategoryIsActiveComboBox.Name = "CategoryIsActiveComboBox";
            CategoryIsActiveComboBox.Size = new Size(138, 41);
            CategoryIsActiveComboBox.TabIndex = 15;
            // 
            // IsActiveLabel
            // 
            IsActiveLabel.AutoSize = true;
            IsActiveLabel.Location = new Point(407, 134);
            IsActiveLabel.Name = "IsActiveLabel";
            IsActiveLabel.Size = new Size(75, 33);
            IsActiveLabel.TabIndex = 17;
            IsActiveLabel.Text = "وضعیت";
            // 
            // CategoryNameTextBox
            // 
            CategoryNameTextBox.Location = new Point(22, 73);
            CategoryNameTextBox.Name = "CategoryNameTextBox";
            CategoryNameTextBox.Size = new Size(350, 40);
            CategoryNameTextBox.TabIndex = 12;
            // 
            // ProductNameLabel
            // 
            ProductNameLabel.AutoSize = true;
            ProductNameLabel.Location = new Point(378, 76);
            ProductNameLabel.Name = "ProductNameLabel";
            ProductNameLabel.Size = new Size(142, 33);
            ProductNameLabel.TabIndex = 16;
            ProductNameLabel.Text = "عنوان دسته بندی";
            // 
            // CategoryIdTextBox
            // 
            CategoryIdTextBox.Location = new Point(22, 21);
            CategoryIdTextBox.Name = "CategoryIdTextBox";
            CategoryIdTextBox.ReadOnly = true;
            CategoryIdTextBox.Size = new Size(350, 40);
            CategoryIdTextBox.TabIndex = 14;
            // 
            // categoryIdLabel
            // 
            categoryIdLabel.AutoSize = true;
            categoryIdLabel.Location = new Point(378, 24);
            categoryIdLabel.Name = "categoryIdLabel";
            categoryIdLabel.Size = new Size(149, 33);
            categoryIdLabel.TabIndex = 13;
            categoryIdLabel.Text = "شناسه دسته بندی";
            // 
            // CategoryDataGroupBox
            // 
            CategoryDataGroupBox.Controls.Add(CategoryDataGridView);
            CategoryDataGroupBox.Dock = DockStyle.Bottom;
            CategoryDataGroupBox.Location = new Point(0, 243);
            CategoryDataGroupBox.Name = "CategoryDataGroupBox";
            CategoryDataGroupBox.Size = new Size(524, 306);
            CategoryDataGroupBox.TabIndex = 22;
            CategoryDataGroupBox.TabStop = false;
            CategoryDataGroupBox.Text = "انواع دسته بندی ثبت شده";
            // 
            // CategoryDataGridView
            // 
            CategoryDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoryDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, CategoryName, IsActive, IsDeleted });
            CategoryDataGridView.Dock = DockStyle.Fill;
            CategoryDataGridView.Location = new Point(3, 36);
            CategoryDataGridView.Name = "CategoryDataGridView";
            CategoryDataGridView.RowTemplate.Height = 33;
            CategoryDataGridView.Size = new Size(518, 267);
            CategoryDataGridView.TabIndex = 0;
            // 
            // Id
            // 
            Id.DataPropertyName = "CategoryId";
            Id.HeaderText = "شناسه";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // CategoryName
            // 
            CategoryName.DataPropertyName = "CategoryName";
            CategoryName.HeaderText = "عنوان";
            CategoryName.Name = "CategoryName";
            CategoryName.ReadOnly = true;
            // 
            // IsActive
            // 
            IsActive.DataPropertyName = "IsActive";
            IsActive.HeaderText = "وضعیت";
            IsActive.Name = "IsActive";
            IsActive.ReadOnly = true;
            // 
            // IsDeleted
            // 
            IsDeleted.DataPropertyName = "IsDeleted";
            IsDeleted.HeaderText = "حذف شده";
            IsDeleted.Name = "IsDeleted";
            IsDeleted.ReadOnly = true;
            IsDeleted.Width = 120;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(12F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 549);
            Controls.Add(CategoryDataGroupBox);
            Controls.Add(ExitButton);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(AddButton);
            Controls.Add(CategoryIsActiveComboBox);
            Controls.Add(IsActiveLabel);
            Controls.Add(CategoryNameTextBox);
            Controls.Add(ProductNameLabel);
            Controls.Add(CategoryIdTextBox);
            Controls.Add(categoryIdLabel);
            Font = new Font("IRANSans(FaNum)", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "CategoryForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "فرم ایجاد انواع دسته بندی";
            Load += CategoryForm_Load;
            CategoryDataGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CategoryDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExitButton;
        private Button DeleteButton;
        private Button UpdateButton;
        private Button AddButton;
        private ComboBox CategoryIsActiveComboBox;
        private Label IsActiveLabel;
        private TextBox CategoryNameTextBox;
        private Label ProductNameLabel;
        private TextBox CategoryIdTextBox;
        private Label categoryIdLabel;
        private GroupBox CategoryDataGroupBox;
        private DataGridView CategoryDataGridView;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn IsActive;
        private DataGridViewTextBoxColumn IsDeleted;
    }
}