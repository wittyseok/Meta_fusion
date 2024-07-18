namespace Metafusion
{
    partial class MenuBar
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            frame_button = new Panel();
            icon_close = new PictureBox();
            icon_maximize = new PictureBox();
            icon_minimize = new PictureBox();
            logo = new PictureBox();
            frame_button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icon_close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icon_maximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icon_minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // frame_button
            // 
            frame_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            frame_button.Controls.Add(icon_close);
            frame_button.Controls.Add(icon_maximize);
            frame_button.Controls.Add(icon_minimize);
            frame_button.Location = new Point(1168, 9);
            frame_button.Name = "frame_button";
            frame_button.Size = new Size(96, 20);
            frame_button.TabIndex = 1;
            // 
            // icon_close
            // 
            icon_close.BackgroundImage = Properties.Resources.icon_close;
            icon_close.BackgroundImageLayout = ImageLayout.Center;
            icon_close.Location = new Point(64, 0);
            icon_close.Name = "icon_close";
            icon_close.Size = new Size(32, 20);
            icon_close.TabIndex = 3;
            icon_close.TabStop = false;
            icon_close.Click += icon_close_Click;
            // 
            // icon_maximize
            // 
            icon_maximize.BackgroundImage = Properties.Resources.icon_maximize;
            icon_maximize.BackgroundImageLayout = ImageLayout.Center;
            icon_maximize.Location = new Point(32, 0);
            icon_maximize.Name = "icon_maximize";
            icon_maximize.Size = new Size(32, 20);
            icon_maximize.TabIndex = 2;
            icon_maximize.TabStop = false;
            icon_maximize.Click += icon_maximize_Click;
            // 
            // icon_minimize
            // 
            icon_minimize.BackgroundImage = Properties.Resources.icon_minimize;
            icon_minimize.BackgroundImageLayout = ImageLayout.Center;
            icon_minimize.ErrorImage = null;
            icon_minimize.Location = new Point(0, 0);
            icon_minimize.Name = "icon_minimize";
            icon_minimize.Size = new Size(32, 20);
            icon_minimize.TabIndex = 1;
            icon_minimize.TabStop = false;
            icon_minimize.Click += icon_minimize_Click;
            // 
            // logo
            // 
            logo.BackgroundImage = Properties.Resources.logo_slicemind;
            logo.BackgroundImageLayout = ImageLayout.Zoom;
            logo.Location = new Point(16, 8);
            logo.Name = "logo";
            logo.Size = new Size(94, 22);
            logo.TabIndex = 2;
            logo.TabStop = false;
            // 
            // MenuBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(logo);
            Controls.Add(frame_button);
            Name = "MenuBar";
            Size = new Size(1280, 37);
            Load += MenuBar_Load;
            frame_button.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icon_close).EndInit();
            ((System.ComponentModel.ISupportInitialize)icon_maximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)icon_minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel frame_button;
        private PictureBox icon_close;
        private PictureBox icon_maximize;
        private PictureBox icon_minimize;
        private PictureBox logo;
    }
}
