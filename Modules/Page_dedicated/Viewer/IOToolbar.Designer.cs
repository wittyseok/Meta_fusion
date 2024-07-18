namespace Metafusion
{
    partial class IOToolbar
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
            button_io_save = new RoundedPanel();
            picture_io_save = new PictureBox();
            label_io_tools = new Label();
            picture_io_export = new PictureBox();
            button_io_export = new RoundedPanel();
            frame_io_tools = new Panel();
            button_io_save.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_io_save).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture_io_export).BeginInit();
            button_io_export.SuspendLayout();
            frame_io_tools.SuspendLayout();
            SuspendLayout();
            // 
            // button_io_save
            // 
            button_io_save.BackColor = Color.FromArgb(76, 76, 103);
            button_io_save.borderColor = Color.FromArgb(98, 98, 132);
            button_io_save.BorderWidth = 1;
            button_io_save.Controls.Add(picture_io_save);
            button_io_save.CornerRadius = 4;
            button_io_save.Location = new Point(62, 0);
            button_io_save.Name = "button_io_save";
            button_io_save.Size = new Size(32, 32);
            button_io_save.TabIndex = 2;
            // 
            // picture_io_save
            // 
            picture_io_save.BackgroundImage = Properties.Resources.Viewer_Tool_Icons_save;
            picture_io_save.BackgroundImageLayout = ImageLayout.Center;
            picture_io_save.Location = new Point(4, 4);
            picture_io_save.Name = "picture_io_save";
            picture_io_save.Size = new Size(24, 24);
            picture_io_save.SizeMode = PictureBoxSizeMode.CenterImage;
            picture_io_save.TabIndex = 0;
            picture_io_save.TabStop = false;
            picture_io_save.Click += picture_io_save_Click;
            // 
            // label_io_tools
            // 
            label_io_tools.AutoSize = true;
            label_io_tools.Font = new Font("Pretendard Variable Medium", 10F, FontStyle.Bold);
            label_io_tools.ForeColor = Color.FromArgb(152, 152, 179);
            label_io_tools.Location = new Point(0, 8);
            label_io_tools.Name = "label_io_tools";
            label_io_tools.Size = new Size(60, 16);
            label_io_tools.TabIndex = 0;
            label_io_tools.Text = "I/O tools";
            label_io_tools.Click += label_io_tools_Click;
            // 
            // picture_io_export
            // 
            picture_io_export.BackgroundImage = Properties.Resources.Viewer_Tool_Icons_export;
            picture_io_export.BackgroundImageLayout = ImageLayout.Center;
            picture_io_export.Location = new Point(4, 4);
            picture_io_export.Name = "picture_io_export";
            picture_io_export.Size = new Size(24, 24);
            picture_io_export.SizeMode = PictureBoxSizeMode.CenterImage;
            picture_io_export.TabIndex = 0;
            picture_io_export.TabStop = false;
            // 
            // button_io_export
            // 
            button_io_export.BackColor = Color.FromArgb(76, 76, 103);
            button_io_export.borderColor = Color.FromArgb(98, 98, 132);
            button_io_export.BorderWidth = 1;
            button_io_export.Controls.Add(picture_io_export);
            button_io_export.CornerRadius = 4;
            button_io_export.Location = new Point(98, 0);
            button_io_export.Name = "button_io_export";
            button_io_export.Size = new Size(32, 32);
            button_io_export.TabIndex = 3;
            // 
            // frame_io_tools
            // 
            frame_io_tools.BackColor = Color.FromArgb(54, 54, 73);
            frame_io_tools.Controls.Add(button_io_export);
            frame_io_tools.Controls.Add(button_io_save);
            frame_io_tools.Controls.Add(label_io_tools);
            frame_io_tools.Location = new Point(0, 0);
            frame_io_tools.Name = "frame_io_tools";
            frame_io_tools.Size = new Size(130, 32);
            frame_io_tools.TabIndex = 1;
            frame_io_tools.Paint += frame_io_tools_Paint;
            // 
            // IOToolbar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(frame_io_tools);
            Name = "IOToolbar";
            Size = new Size(130, 32);
            button_io_save.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture_io_save).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture_io_export).EndInit();
            button_io_export.ResumeLayout(false);
            frame_io_tools.ResumeLayout(false);
            frame_io_tools.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RoundedPanel button_io_save;
        private PictureBox picture_io_save;
        private Label label_io_tools;
        private PictureBox picture_io_export;
        private RoundedPanel button_io_export;
        private Panel frame_io_tools;
    }
}
