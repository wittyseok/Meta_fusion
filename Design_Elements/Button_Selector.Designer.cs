namespace Metafusion
{
    partial class Button_Selector
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
            panel_background = new RoundedPanel();
            text_display = new Label();
            icon_display = new PictureBox();
            panel_background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icon_display).BeginInit();
            SuspendLayout();
            // 
            // panel_background
            // 
            panel_background.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_background.BackColor = Color.FromArgb(76, 76, 103);
            panel_background.borderColor = Color.Red;
            panel_background.BorderWidth = 0;
            panel_background.Controls.Add(text_display);
            panel_background.Controls.Add(icon_display);
            panel_background.CornerRadius = 4;
            panel_background.Dock = DockStyle.Fill;
            panel_background.Name = "panel_background";
            panel_background.ScrollDisabled = false;
            panel_background.Size = new Size(344, 26);
            panel_background.TabIndex = 2;
            panel_background.Paint += panel_background_Paint;
            // 
            // text_display
            // 
            text_display.AutoSize = true;
            text_display.BackColor = Color.Transparent;
            text_display.Font = new Font("Pretendard Variable Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            text_display.ForeColor = Color.White;
            text_display.Name = "text_display";
            text_display.Size = new Size(0, 14);
            text_display.TabIndex = 0;
            // 
            // icon_display
            // 
            icon_display.BackColor = Color.Transparent;
            icon_display.BackgroundImageLayout = ImageLayout.Center;
            icon_display.Name = "icon_display";
            icon_display.Size = new Size(16, 16);
            icon_display.TabIndex = 1;
            icon_display.TabStop = false;
            // 
            // Button_Selector
            // 
            BackColor = Color.FromArgb(54, 54, 73);
            Controls.Add(panel_background);
            Size = new Size(344, 26);
            panel_background.ResumeLayout(false);
            panel_background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)icon_display).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RoundedPanel panel_background;
        private Label text_display;
        private PictureBox icon_display;
    }
}
