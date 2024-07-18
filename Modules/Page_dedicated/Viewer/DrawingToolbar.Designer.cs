namespace Metafusion
{
    partial class DrawingToolbar
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
            label_drawing_tools = new Label();
            frame_drawing_tools = new Panel();
            button_rectangle = new RoundedPanel();
            picture_rect = new PictureBox();
            button_fill = new RoundedPanel();
            picture_fill = new PictureBox();
            button_contour = new RoundedPanel();
            picture_contour = new PictureBox();
            button_brush = new RoundedPanel();
            picture_brush = new PictureBox();
            frame_drawing_tools.SuspendLayout();
            button_rectangle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_rect).BeginInit();
            button_fill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_fill).BeginInit();
            button_contour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_contour).BeginInit();
            button_brush.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_brush).BeginInit();
            SuspendLayout();
            // 
            // label_drawing_tools
            // 
            label_drawing_tools.AutoSize = true;
            label_drawing_tools.Font = new Font("Pretendard Variable Medium", 10F, FontStyle.Bold);
            label_drawing_tools.ForeColor = Color.FromArgb(152, 152, 179);
            label_drawing_tools.Location = new Point(0, 8);
            label_drawing_tools.Name = "label_drawing_tools";
            label_drawing_tools.Size = new Size(94, 16);
            label_drawing_tools.TabIndex = 0;
            label_drawing_tools.Text = "Drawing tools";
            label_drawing_tools.Click += label_drawing_tools_Click;
            // 
            // frame_drawing_tools
            // 
            frame_drawing_tools.Controls.Add(button_rectangle);
            frame_drawing_tools.Controls.Add(button_fill);
            frame_drawing_tools.Controls.Add(button_contour);
            frame_drawing_tools.Controls.Add(button_brush);
            frame_drawing_tools.Controls.Add(label_drawing_tools);
            frame_drawing_tools.Location = new Point(0, 0);
            frame_drawing_tools.Name = "frame_drawing_tools";
            frame_drawing_tools.Size = new Size(235, 32);
            frame_drawing_tools.TabIndex = 5;
            // 
            // button_rectangle
            // 
            button_rectangle.BackColor = Color.FromArgb(76, 76, 103);
            button_rectangle.borderColor = Color.FromArgb(98, 98, 132);
            button_rectangle.BorderWidth = 1;
            button_rectangle.Controls.Add(picture_rect);
            button_rectangle.CornerRadius = 4;
            button_rectangle.Location = new Point(203, 0);
            button_rectangle.Name = "button_rectangle";
            button_rectangle.Size = new Size(32, 32);
            button_rectangle.TabIndex = 4;
            // 
            // picture_rect
            // 
            picture_rect.BackgroundImage = Properties.Resources.icon_rect;
            picture_rect.BackgroundImageLayout = ImageLayout.Center;
            picture_rect.Location = new Point(4, 4);
            picture_rect.Name = "picture_rect";
            picture_rect.Size = new Size(24, 24);
            picture_rect.SizeMode = PictureBoxSizeMode.CenterImage;
            picture_rect.TabIndex = 0;
            picture_rect.TabStop = false;
            // 
            // button_fill
            // 
            button_fill.BackColor = Color.FromArgb(76, 76, 103);
            button_fill.borderColor = Color.FromArgb(98, 98, 132);
            button_fill.BorderWidth = 1;
            button_fill.Controls.Add(picture_fill);
            button_fill.CornerRadius = 4;
            button_fill.Location = new Point(167, 0);
            button_fill.Name = "button_fill";
            button_fill.Size = new Size(32, 32);
            button_fill.TabIndex = 4;
            // 
            // picture_fill
            // 
            picture_fill.BackgroundImage = Properties.Resources.icon_fill;
            picture_fill.BackgroundImageLayout = ImageLayout.Center;
            picture_fill.Location = new Point(4, 4);
            picture_fill.Name = "picture_fill";
            picture_fill.Size = new Size(24, 24);
            picture_fill.SizeMode = PictureBoxSizeMode.CenterImage;
            picture_fill.TabIndex = 0;
            picture_fill.TabStop = false;
            // 
            // button_contour
            // 
            button_contour.BackColor = Color.FromArgb(76, 76, 103);
            button_contour.borderColor = Color.FromArgb(98, 98, 132);
            button_contour.BorderWidth = 1;
            button_contour.Controls.Add(picture_contour);
            button_contour.CornerRadius = 4;
            button_contour.Location = new Point(131, 0);
            button_contour.Name = "button_contour";
            button_contour.Size = new Size(32, 32);
            button_contour.TabIndex = 3;
            // 
            // picture_contour
            // 
            picture_contour.BackgroundImage = Properties.Resources.icon_contour;
            picture_contour.BackgroundImageLayout = ImageLayout.Center;
            picture_contour.Location = new Point(4, 4);
            picture_contour.Name = "picture_contour";
            picture_contour.Size = new Size(24, 24);
            picture_contour.SizeMode = PictureBoxSizeMode.CenterImage;
            picture_contour.TabIndex = 0;
            picture_contour.TabStop = false;
            // 
            // button_brush
            // 
            button_brush.BackColor = Color.FromArgb(76, 76, 103);
            button_brush.borderColor = Color.FromArgb(98, 98, 132);
            button_brush.BorderWidth = 1;
            button_brush.Controls.Add(picture_brush);
            button_brush.CornerRadius = 4;
            button_brush.Location = new Point(95, 0);
            button_brush.Name = "button_brush";
            button_brush.Size = new Size(32, 32);
            button_brush.TabIndex = 2;
            // 
            // picture_brush
            // 
            picture_brush.BackgroundImage = Properties.Resources.icon_brush;
            picture_brush.BackgroundImageLayout = ImageLayout.Center;
            picture_brush.Location = new Point(4, 4);
            picture_brush.Name = "picture_brush";
            picture_brush.Size = new Size(24, 24);
            picture_brush.SizeMode = PictureBoxSizeMode.CenterImage;
            picture_brush.TabIndex = 0;
            picture_brush.TabStop = false;
            // 
            // DrawingToolbar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 54, 73);
            Controls.Add(frame_drawing_tools);
            Name = "DrawingToolbar";
            Size = new Size(235, 32);
            frame_drawing_tools.ResumeLayout(false);
            frame_drawing_tools.PerformLayout();
            button_rectangle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture_rect).EndInit();
            button_fill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture_fill).EndInit();
            button_contour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture_contour).EndInit();
            button_brush.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture_brush).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label_drawing_tools;
        private Panel frame_drawing_tools;
        private RoundedPanel button_rectangle;
        private PictureBox picture_rect;
        private RoundedPanel button_fill;
        private PictureBox picture_fill;
        private RoundedPanel button_contour;
        private PictureBox picture_contour;
        private RoundedPanel button_brush;
        private PictureBox picture_brush;
    }
}
