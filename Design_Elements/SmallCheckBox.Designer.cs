namespace Metafusion
{
    partial class SmallCheckBox
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
            bg_select_all = new RoundedPanel();
            icon_select_all = new PictureBox();
            bg_select_all.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icon_select_all).BeginInit();
            SuspendLayout();
            // 
            // bg_select_all
            // 
            bg_select_all.BackColor = Color.FromArgb(240, 240, 244);
            bg_select_all.borderColor = Color.Red;
            bg_select_all.BorderWidth = 0;
            bg_select_all.Controls.Add(icon_select_all);
            bg_select_all.CornerRadius = 4;
            bg_select_all.Location = new Point(0, 0);
            bg_select_all.Name = "bg_select_all";
            bg_select_all.Size = new Size(16, 16);
            bg_select_all.TabIndex = 7;
            // 
            // icon_select_all
            // 
            icon_select_all.BackColor = Color.Transparent;
            icon_select_all.BackgroundImage = Properties.Resources.icon_check;
            icon_select_all.BackgroundImageLayout = ImageLayout.Stretch;
            icon_select_all.Location = new Point(1, 1);
            icon_select_all.Name = "icon_select_all";
            icon_select_all.Size = new Size(14, 14);
            icon_select_all.TabIndex = 4;
            icon_select_all.TabStop = false;
            icon_select_all.Click += icon_check_Click;
            // 
            // SmallCheckBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(bg_select_all);
            Name = "SmallCheckBox";
            Size = new Size(16, 16);
            bg_select_all.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icon_select_all).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RoundedPanel bg_select_all;
        private PictureBox icon_select_all;
    }
}
