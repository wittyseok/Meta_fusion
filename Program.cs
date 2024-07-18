using System.Drawing.Text;

namespace Metafusion
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
            // 로그인 폼 실행
            using (PageLogin loginForm = new PageLogin())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // 로그인 성공 시 라이선스 리스트 로드
                    LicenseManager.LoadLicenses(loginForm.Licenses);

                    FormSwitchManager.AppendForm(new PageHome(), "home");
                    // 메인 폼 실행
                    Application.Run(FormSwitchManager.GetForm("home"));
                }
                else
                {
                    // 로그인 실패 시 프로그램 종료
                    Application.Exit();
                }
            }
        }
    }
}