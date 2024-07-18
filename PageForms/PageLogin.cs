using System.ComponentModel;
using System.DirectoryServices;
using System.Runtime.InteropServices;

namespace Metafusion
{
    public partial class PageLogin : Form
    {
        //features for MenuBar
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        // AnimateWindow 플래그 상수
        private const int AW_HOR_POSITIVE = 0x00000001;
        private const int AW_HOR_NEGATIVE = 0x00000002;
        private const int AW_VER_POSITIVE = 0x00000004;
        private const int AW_VER_NEGATIVE = 0x00000008;
        private const int AW_CENTER = 0x00000010;
        private const int AW_HIDE = 0x00010000;
        private const int AW_ACTIVATE = 0x00020000;
        private const int AW_SLIDE = 0x00040000;
        private const int AW_BLEND = 0x00080000;
        //Win32 API
        // AnimateWindow 함수 선언
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool AnimateWindow(IntPtr hWnd, int dwTime, int dwFlags);

        private void CustomPopupForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void CustomPopupForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }
        private void CustomPopupForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void InitializeDragability()
        {
            MenuBar.MouseDown += CustomPopupForm_MouseDown;
            MenuBar.MouseMove += CustomPopupForm_MouseMove;
            MenuBar.MouseUp += CustomPopupForm_MouseUp;
        }
        private void InitializeMenuBar()
        {
            // 이벤트 구독
            MenuBar.MinimizeClicked += MenuBar_MinimizeClicked;
            MenuBar.MaximizeClicked += MenuBar_MaximizeClicked;
            MenuBar.CloseClicked += MenuBar_CloseClicked;
        }
        private void MenuBar_MinimizeClicked(object sender, EventArgs e)
        {
            // 폼 최소화 애니메이션
            AnimateWindow(this.Handle, 50, AW_BLEND | AW_HIDE);
            this.WindowState = FormWindowState.Minimized;

        }

        private void MenuBar_MaximizeClicked(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                // 폼 복원
                this.WindowState = FormWindowState.Normal;
                //AnimateWindow(this.Handle, 500, AW_SLIDE | AW_VER_NEGATIVE);
                //todo: 애니메이션 삽입(위 코드 안됨)
            }
            else
            {
                // 폼 최대화
                //AnimateWindow(this.Handle, 200, AW_CENTER | AW_ACTIVATE | AW_SLIDE | AW_HOR_POSITIVE);
                //todo: 애니메이션 삽입(위 코드 안됨)
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void MenuBar_CloseClicked(object sender, EventArgs e)
        {
            AnimateWindow(this.Handle, 50, AW_BLEND | AW_HIDE);
            this.Close();
        }
        //features for MenuBar

        private check_login loginChecker; // Add this line
        private bool id_valid = false;
        private bool password_valid = false;
        public List<string> Licenses { get; private set; }


        public PageLogin()
        {
            InitializeComponent();
            InitializePlaceholders();
            InitializeDragability();
            InitializeMenuBar();
            loginChecker = new check_login();
            DoubleBuffered = true;
            // 폼의 초기 크기 설정
            this.Size = new Size(1280, 720);
            //this.Select(); //avoid id text initially selected -> don't avoid. initially selected is better
        }


        private void InitializePlaceholders()
        {
            SetPlaceholderText(id, "아이디를 입력해 주세요");
            SetPlaceholderText(password, "패스워드를 입력해 주세요");

            id.Enter += RemovePlaceholderText;
            id.Leave += AddPlaceholderText;
            id.TextChanged += CheckButton;
            password.Enter += RemovePlaceholderText;
            password.Leave += AddPlaceholderText;
            password.TextChanged += CheckButton;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Do_Call_Login();
        }
        private void SetPlaceholderText(TextBox textBox, string placeholder)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void CheckButton(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                if (textBox == id)
                {
                    id_valid = !string.IsNullOrEmpty(textBox.Text) && textBox.Text != "아이디를 입력해 주세요";
                }
                else if (textBox == password)
                {
                    password_valid = !string.IsNullOrEmpty(textBox.Text) && textBox.Text != "패스워드를 입력해 주세요";
                }
            }
            button1.Enabled = id_valid && password_valid;
        }

        private void RemovePlaceholderText(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.ForeColor == System.Drawing.Color.Gray)
            {
                textBox.Text = "";
                textBox.ForeColor = System.Drawing.Color.Black;
                if (textBox == password)
                {
                    textBox.PasswordChar = '●';
                }
            }
        }

        private void AddPlaceholderText(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrEmpty(textBox.Text))
            {
                if (textBox == id)
                {
                    SetPlaceholderText(textBox, "아이디를 입력해 주세요");
                }
                else if (textBox == password)
                {
                    textBox.PasswordChar = default;
                    SetPlaceholderText(textBox, "패스워드를 입력해 주세요");
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Do_Call_Login()
        {
            string user_id = id.Text;
            string user_pw = password.Text;

            if (loginChecker.ValidateLogin(user_id, user_pw))
            {
                // 라이선스 리스트 받아오기
                Licenses = LicenseManager.GetLicenses();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                ShowLoginFailedUI();
            }
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && button1.Enabled)
            {
                Do_Call_Login();
            }
        }

        private void ShowLoginFailedUI()
        {
            panel1.BorderWidth = 1;
            panel2.BorderWidth = 1;
            label3.Visible = true;
            //MessageBox.Show("Login Failed");
        }

        private void roundedPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PageLogin_Load(object sender, EventArgs e)
        {
        }

        private void MenuBar_Load(object sender, EventArgs e)
        {

        }
    }
}
