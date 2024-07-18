namespace Metafusion
{
    partial class PageLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageLogin));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new RoundedPanel();
            panel1 = new RoundedPanel();
            id = new TextBox();
            password = new TextBox();
            button1 = new RoundedButton();
            roundedPanel = new RoundedPanel();
            label3 = new Label();
            MenuBar = new MenuBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            roundedPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(142, 56);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 175);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Pretendard", 12F, FontStyle.Bold);
            label2.Location = new Point(56, 374);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 19);
            label2.TabIndex = 6;
            label2.Text = "패스워드";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Pretendard", 12F, FontStyle.Bold);
            label1.Location = new Point(56, 271);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 19);
            label1.TabIndex = 1;
            label1.Text = "아이디";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(240, 240, 244);
            panel2.borderColor = Color.FromArgb(255, 21, 0);
            panel2.BorderWidth = 0;
            panel2.CornerRadius = 20;
            panel2.Location = new Point(56, 404);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(328, 49);
            panel2.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(240, 240, 244);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.borderColor = Color.FromArgb(255, 21, 0);
            panel1.BorderWidth = 0;
            panel1.CornerRadius = 20;
            panel1.Location = new Point(56, 301);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(328, 49);
            panel1.TabIndex = 1;
            // 
            // id
            // 
            id.BackColor = Color.FromArgb(240, 240, 244);
            id.BorderStyle = BorderStyle.None;
            id.Font = new Font("Pretendard", 9F, FontStyle.Bold);
            id.Location = new Point(70, 319);
            id.Margin = new Padding(2);
            id.Name = "id";
            id.Size = new Size(300, 15);
            id.TabIndex = 1;
            id.Tag = "id";
            id.KeyDown += passwordTextBox_KeyDown;
            // 
            // password
            // 
            password.BackColor = Color.FromArgb(240, 240, 244);
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Pretendard", 9F, FontStyle.Bold);
            password.Location = new Point(70, 422);
            password.Margin = new Padding(2);
            password.Name = "password";
            password.Size = new Size(300, 15);
            password.TabIndex = 2;
            password.Tag = "password";
            password.KeyDown += passwordTextBox_KeyDown;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(123, 123, 157);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.CornerRadius = 4;
            button1.deactivatedColor = Color.FromArgb(182, 182, 201);
            button1.Enabled = false;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Pretendard", 12F, FontStyle.Bold);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(56, 493);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.normalColor = Color.FromArgb(123, 123, 157);
            button1.Size = new Size(328, 54);
            button1.TabIndex = 3;
            button1.Tag = "SignInButton";
            button1.Text = "로그인";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // roundedPanel
            // 
            roundedPanel.Anchor = AnchorStyles.None;
            roundedPanel.BackColor = Color.White;
            roundedPanel.borderColor = Color.Red;
            roundedPanel.BorderWidth = 0;
            roundedPanel.Controls.Add(button1);
            roundedPanel.Controls.Add(password);
            roundedPanel.Controls.Add(id);
            roundedPanel.Controls.Add(panel1);
            roundedPanel.Controls.Add(panel2);
            roundedPanel.Controls.Add(label1);
            roundedPanel.Controls.Add(label2);
            roundedPanel.Controls.Add(pictureBox1);
            roundedPanel.Controls.Add(label3);
            roundedPanel.CornerRadius = 4;
            roundedPanel.Font = new Font("Pretendard", 10.5F);
            roundedPanel.ForeColor = Color.Black;
            roundedPanel.Location = new Point(420, 59);
            roundedPanel.Margin = new Padding(2);
            roundedPanel.MinimumSize = new Size(440, 603);
            roundedPanel.Name = "roundedPanel";
            roundedPanel.Size = new Size(440, 603);
            roundedPanel.TabIndex = 0;
            roundedPanel.Paint += roundedPanel_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Pretendard", 10.5F);
            label3.ForeColor = Color.FromArgb(255, 21, 0);
            label3.Location = new Point(56, 464);
            label3.Name = "label3";
            label3.Size = new Size(243, 16);
            label3.TabIndex = 1;
            label3.Text = "아이디 또는 비밀번호가 일치하지 않습니다.";
            label3.Visible = false;
            // 
            // MenuBar
            // 
            MenuBar.BackColor = Color.Transparent;
            MenuBar.Dock = DockStyle.Top;
            MenuBar.Location = new Point(0, 0);
            MenuBar.Name = "MenuBar";
            MenuBar.Size = new Size(1280, 37);
            MenuBar.TabIndex = 1;
            MenuBar.Load += MenuBar_Load;
            // 
            // PageLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1280, 720);
            ControlBox = false;
            Controls.Add(MenuBar);
            Controls.Add(roundedPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "PageLogin";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Load += PageLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            roundedPanel.ResumeLayout(false);
            roundedPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private RoundedPanel panel2;
        private RoundedPanel panel1;
        private TextBox id;
        private TextBox password;
        private RoundedButton button1;
        private RoundedPanel roundedPanel;
        private Label label3;
        private MenuBar MenuBar;
    }
}
