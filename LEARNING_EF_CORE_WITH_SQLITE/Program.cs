namespace LEARNING_EF_CORE_WITH_SQLITE
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
           

            //*************************************************
            // ایجاد پوشه ای برای ساخت دیتابیس
            //*************************************************

            var executePath = Application.StartupPath;

            var directory = new DirectoryInfo(path:executePath);

            if(Directory.Exists(path:$"{directory}/Database") == false)
            {
                Directory.CreateDirectory(path: $"{directory}/Database");
            }

            //*************************************************
            // تغییر کالچر برنامه به فارسی ایران
            //*************************************************
            var iranCulture =
                new System.Globalization.CultureInfo("fa-IR");

            Thread.CurrentThread.CurrentCulture = iranCulture;
            Thread.CurrentThread.CurrentUICulture = iranCulture;

            //Application.Run(new CategoryForm());
           // Application.Run(new ProductForm());

            // Application.Run(new ReportForm());
              Application.Run(new MainForm());
        }
    }
}