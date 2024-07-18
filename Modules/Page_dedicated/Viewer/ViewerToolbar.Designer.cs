namespace Metafusion
{
    partial class ViewerToolbar
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
            button_viewer_cursor = new RoundedPanel();
            picture_viewer_cursor = new PictureBox();
            label_viewer_tools = new Label();
            frame_viewer_tools = new Panel();
            button_viewer_adj_contrast = new RoundedPanel();
            picture_viewer_adj_contrast = new PictureBox();
            button_viewer_zoom_in = new RoundedPanel();
            picture_viewer_zoom_in = new PictureBox();
            button_viewer_grab = new RoundedPanel();
            picture_viewer_grab = new PictureBox();
            button_viewer_cursor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_viewer_cursor).BeginInit();
            frame_viewer_tools.SuspendLayout();
            button_viewer_adj_contrast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_viewer_adj_contrast).BeginInit();
            button_viewer_zoom_in.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_viewer_zoom_in).BeginInit();
            button_viewer_grab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_viewer_grab).BeginInit();
            SuspendLayout();
            // 
            // button_viewer_cursor
            // 
            button_viewer_cursor.BackColor = Color.FromArgb(76, 76, 103);
            button_viewer_cursor.borderColor = Color.FromArgb(98, 98, 132);
            button_viewer_cursor.BorderWidth = 1;
            button_viewer_cursor.Controls.Add(picture_viewer_cursor);
            button_viewer_cursor.CornerRadius = 4;
            button_viewer_cursor.Location = new Point(87, 0);
            button_viewer_cursor.Name = "button_viewer_cursor";
            button_viewer_cursor.Size = new Size(32, 32);
            button_viewer_cursor.TabIndex = 2;
            // 
            // picture_viewer_cursor
            // 
            picture_viewer_cursor.BackgroundImageLayout = ImageLayout.Center;
            picture_viewer_cursor.Image = Properties.Resources.icon_cursor;
            picture_viewer_cursor.Location = new Point(4, 4);
            picture_viewer_cursor.Name = "picture_viewer_cursor";
            picture_viewer_cursor.Size = new Size(24, 24);
            picture_viewer_cursor.SizeMode = PictureBoxSizeMode.CenterImage;
            picture_viewer_cursor.TabIndex = 0;
            picture_viewer_cursor.TabStop = false;
            // 
            // label_viewer_tools
            // 
            label_viewer_tools.AutoSize = true;
            label_viewer_tools.Font = new Font("Pretendard Variable Medium", 10F, FontStyle.Bold);
            label_viewer_tools.ForeColor = Color.FromArgb(152, 152, 179);
            label_viewer_tools.Location = new Point(0, 8);
            label_viewer_tools.Name = "label_viewer_tools";
            label_viewer_tools.Size = new Size(86, 16);
            label_viewer_tools.TabIndex = 0;
            label_viewer_tools.Text = "Viewer tools";
            label_viewer_tools.Click += label_viewer_tools_Click;
            // 
            // frame_viewer_tools
            // 
            frame_viewer_tools.Controls.Add(button_viewer_adj_contrast);
            frame_viewer_tools.Controls.Add(button_viewer_zoom_in);
            frame_viewer_tools.Controls.Add(button_viewer_grab);
            frame_viewer_tools.Controls.Add(button_viewer_cursor);
            frame_viewer_tools.Controls.Add(label_viewer_tools);
            frame_viewer_tools.Location = new Point(0, 0);
            frame_viewer_tools.Name = "frame_viewer_tools";
            frame_viewer_tools.Size = new Size(227, 32);
            frame_viewer_tools.TabIndex = 4;
            frame_viewer_tools.Paint += frame_viewer_tools_Paint;
            // 
            // button_viewer_adj_contrast
            // 
            button_viewer_adj_contrast.BackColor = Color.FromArgb(76, 76, 103);
            button_viewer_adj_contrast.borderColor = Color.FromArgb(98, 98, 132);
            button_viewer_adj_contrast.BorderWidth = 1;
            button_viewer_adj_contrast.Controls.Add(picture_viewer_adj_contrast);
            button_viewer_adj_contrast.CornerRadius = 4;
            button_viewer_adj_contrast.Location = new Point(195, 0);
            button_viewer_adj_contrast.Name = "button_viewer_adj_contrast";
            button_viewer_adj_contrast.Size = new Size(32, 32);
            button_viewer_adj_contrast.TabIndex = 4;
            // 
            // picture_viewer_adj_contrast
            // 
            picture_viewer_adj_contrast.BackgroundImage = Properties.Resources.icon_contrast;
            picture_viewer_adj_contrast.BackgroundImageLayout = ImageLayout.Center;
            picture_viewer_adj_contrast.Location = new Point(4, 4);
            picture_viewer_adj_contrast.Name = "picture_viewer_adj_contrast";
            picture_viewer_adj_contrast.Size = new Size(24, 24);
            picture_viewer_adj_contrast.SizeMode = PictureBoxSizeMode.CenterImage;
            picture_viewer_adj_contrast.TabIndex = 0;
            picture_viewer_adj_contrast.TabStop = false;
            // 
            // button_viewer_zoom_in
            // 
            button_viewer_zoom_in.BackColor = Color.FromArgb(76, 76, 103);
            button_viewer_zoom_in.borderColor = Color.FromArgb(98, 98, 132);
            button_viewer_zoom_in.BorderWidth = 1;
            button_viewer_zoom_in.Controls.Add(picture_viewer_zoom_in);
            button_viewer_zoom_in.CornerRadius = 4;
            button_viewer_zoom_in.Location = new Point(159, 0);
            button_viewer_zoom_in.Name = "button_viewer_zoom_in";
            button_viewer_zoom_in.Size = new Size(32, 32);
            button_viewer_zoom_in.TabIndex = 4;
            // 
            // picture_viewer_zoom_in
            // 
            picture_viewer_zoom_in.BackgroundImage = Properties.Resources.icon_zoom_in;
            picture_viewer_zoom_in.BackgroundImageLayout = ImageLayout.Center;
            picture_viewer_zoom_in.Location = new Point(4, 4);
            picture_viewer_zoom_in.Name = "picture_viewer_zoom_in";
            picture_viewer_zoom_in.Size = new Size(24, 24);
            picture_viewer_zoom_in.SizeMode = PictureBoxSizeMode.CenterImage;
            picture_viewer_zoom_in.TabIndex = 0;
            picture_viewer_zoom_in.TabStop = false;
            // 
            // button_viewer_grab
            // 
            button_viewer_grab.BackColor = Color.FromArgb(76, 76, 103);
            button_viewer_grab.borderColor = Color.FromArgb(98, 98, 132);
            button_viewer_grab.BorderWidth = 1;
            button_viewer_grab.Controls.Add(picture_viewer_grab);
            button_viewer_grab.CornerRadius = 4;
            button_viewer_grab.Location = new Point(123, 0);
            button_viewer_grab.Name = "button_viewer_grab";
            button_viewer_grab.Size = new Size(32, 32);
            button_viewer_grab.TabIndex = 3;
            // 
            // picture_viewer_grab
            // 
            picture_viewer_grab.BackgroundImageLayout = ImageLayout.Center;
            picture_viewer_grab.Image = Properties.Resources.icon_grab;
            picture_viewer_grab.Location = new Point(4, 2);
            picture_viewer_grab.Name = "picture_viewer_grab";
            picture_viewer_grab.Size = new Size(24, 24);
            picture_viewer_grab.SizeMode = PictureBoxSizeMode.CenterImage;
            picture_viewer_grab.TabIndex = 0;
            picture_viewer_grab.TabStop = false;
            // 
            // ViewerToolbar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 54, 73);
            Controls.Add(frame_viewer_tools);
            Name = "ViewerToolbar";
            Size = new Size(227, 32);
            button_viewer_cursor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture_viewer_cursor).EndInit();
            frame_viewer_tools.ResumeLayout(false);
            frame_viewer_tools.PerformLayout();
            button_viewer_adj_contrast.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture_viewer_adj_contrast).EndInit();
            button_viewer_zoom_in.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture_viewer_zoom_in).EndInit();
            button_viewer_grab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture_viewer_grab).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RoundedPanel button_viewer_cursor;
        private PictureBox picture_viewer_cursor;
        private Label label_viewer_tools;
        private Panel frame_viewer_tools;
        private RoundedPanel button_viewer_adj_contrast;
        private PictureBox picture_viewer_adj_contrast;
        private RoundedPanel button_viewer_zoom_in;
        private PictureBox picture_viewer_zoom_in;
        private RoundedPanel button_viewer_grab;
        private PictureBox picture_viewer_grab;
    }
}
