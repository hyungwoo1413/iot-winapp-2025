namespace Client
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            FrmLogin loginForm = new FrmLogin();
            DialogResult result = loginForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                // FrmLogin에서 Client, Stream, ID 정보를 전달받음
                FrmMain mainForm = new FrmMain(loginForm.Client, loginForm.Stream, loginForm.UserId);
                Application.Run(mainForm);  // 이제 FrmMain이 메인폼처럼 동작
            }
        }
    }
}