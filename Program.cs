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
            // �α��� �� ����
            using (PageLogin loginForm = new PageLogin())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // �α��� ���� �� ���̼��� ����Ʈ �ε�
                    LicenseManager.LoadLicenses(loginForm.Licenses);

                    FormSwitchManager.AppendForm(new PageHome(), "home");
                    // ���� �� ����
                    Application.Run(FormSwitchManager.GetForm("home"));
                }
                else
                {
                    // �α��� ���� �� ���α׷� ����
                    Application.Exit();
                }
            }
        }
    }
}