namespace LEARNING_EF_CORE_WITH_SQLITE
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            topPanel = new Panel();
            startButton = new Azx.CircleButton();
            firstTimer = new System.Windows.Forms.Timer(components);
            secondTimer = new System.Windows.Forms.Timer(components);
            MenuPanel = new Panel();
            exitButton = new Button();
            productButton = new Button();
            categoryButton = new Button();
            reportButton = new Button();

            topPanel.SuspendLayout();
            MenuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.Controls.Add(startButton);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(800, 72);
            topPanel.TabIndex = 0;
            // 
            // startButton
            // 
            startButton.Cursor = Cursors.Hand;
            startButton.Dock = DockStyle.Right;
            startButton.FlatAppearance.BorderColor = Color.Red;
            startButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            startButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Location = new Point(725, 0);
            startButton.Name = "startButton";
            startButton.Size = new Size(75, 72);
            startButton.TabIndex = 1;
            startButton.Text = "شروع";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // firstTimer
            // 
            firstTimer.Interval = 1;
            firstTimer.Tick += firstTimer_Tick;
            // 
            // secondTimer
            // 
            secondTimer.Interval = 1;
            secondTimer.Tick += secondTimer_Tick;
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = SystemColors.ControlDark;
            MenuPanel.Controls.Add(exitButton);
            MenuPanel.Controls.Add(reportButton);
            MenuPanel.Controls.Add(productButton);
            MenuPanel.Controls.Add(categoryButton);
           
            MenuPanel.Dock = DockStyle.Right;
            MenuPanel.Location = new Point(800, 72);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(0, 595);
            MenuPanel.TabIndex = 1;
            // 
            // exitButton
            // 
            exitButton.Cursor = Cursors.Hand;
            exitButton.Dock = DockStyle.Top;
            exitButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Location = new Point(0, 110);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(0, 55);
            exitButton.TabIndex = 2;
            exitButton.Text = "خروج";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Visible = false;
            exitButton.Click += MenuButton_Click;
            // 
            // productButton
            // 
            productButton.Cursor = Cursors.Hand;
            productButton.Dock = DockStyle.Top;
            productButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            productButton.FlatStyle = FlatStyle.Flat;
            productButton.Location = new Point(0, 55);
            productButton.Name = "productButton";
            productButton.Size = new Size(0, 55);
            productButton.TabIndex = 1;
            productButton.Text = "ایجاد محصولات";
            productButton.UseVisualStyleBackColor = true;
            productButton.Visible = false;
            productButton.Click += MenuButton_Click;
            // 
            // categoryButton
            // 
            categoryButton.Cursor = Cursors.Hand;
            categoryButton.Dock = DockStyle.Top;
            categoryButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            categoryButton.FlatStyle = FlatStyle.Flat;
            categoryButton.Location = new Point(0, 0);
            categoryButton.Name = "categoryButton";
            categoryButton.Size = new Size(0, 55);
            categoryButton.TabIndex = 0;
            categoryButton.Text = "دسته بندی محصولات";
            categoryButton.UseVisualStyleBackColor = true;
            categoryButton.Visible = false;
            categoryButton.Click += MenuButton_Click;
            // 
            // reportButton
            // 
            reportButton.Cursor = Cursors.Hand;
            reportButton.Dock = DockStyle.Top;
            reportButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            reportButton.FlatStyle = FlatStyle.Flat;
            reportButton.Location = new Point(0, 165);
            reportButton.Name = "reportButton";
            reportButton.Size = new Size(0, 55);
            reportButton.TabIndex = 0;
            reportButton.Text = "گزارش فهرست دسته بندی";
            reportButton.UseVisualStyleBackColor = true;
            reportButton.Visible = false;
            reportButton.Click += MenuButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 667);
            Controls.Add(MenuPanel);
            Controls.Add(topPanel);
            Font = new Font("IRANSans(FaNum)", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "فرم اصلی سامانه";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            Click += MainForm_Click;
            Paint += MainForm_Paint;
            topPanel.ResumeLayout(false);
            MenuPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private System.Windows.Forms.Timer firstTimer;
        private System.Windows.Forms.Timer secondTimer;
        private Azx.CircleButton startButton;
        private Panel MenuPanel;
        private Button productButton;
        private Button categoryButton;
        private Button exitButton;
        private Button reportButton;
    }
}