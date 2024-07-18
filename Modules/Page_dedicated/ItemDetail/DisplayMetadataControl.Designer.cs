namespace Metafusion
{
    partial class DisplayMetadataControl
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
            Label label8;
            panel1 = new RoundedPanel();
            frame_info = new Panel();
            roundedPanel2 = new RoundedPanel();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            roundedPanel1 = new RoundedPanel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel_info_1 = new RoundedPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            frame_data = new Panel();
            frame_lower = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            text_options = new Label();
            panel2 = new Panel();
            text_modality = new Label();
            label7 = new Label();
            data_time = new Panel();
            text_time = new Label();
            text_date = new Label();
            label4 = new Label();
            frame_upper = new Panel();
            label8 = new Label();
            panel1.SuspendLayout();
            frame_info.SuspendLayout();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel_info_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            frame_data.SuspendLayout();
            frame_lower.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            data_time.SuspendLayout();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Pretendard Variable", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label8.ForeColor = Color.FromArgb(182, 182, 201);
            label8.Location = new Point(8, 10);
            label8.Name = "label8";
            label8.Size = new Size(50, 14);
            label8.TabIndex = 0;
            label8.Text = "Options";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.FromArgb(54, 54, 73);
            panel1.borderColor = Color.Red;
            panel1.BorderWidth = 0;
            panel1.Controls.Add(frame_info);
            panel1.Controls.Add(frame_data);
            panel1.CornerRadius = 4;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 774);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // frame_info
            // 
            frame_info.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            frame_info.BackColor = Color.FromArgb(54, 54, 73);
            frame_info.Controls.Add(roundedPanel2);
            frame_info.Controls.Add(roundedPanel1);
            frame_info.Controls.Add(panel_info_1);
            frame_info.Location = new Point(8, 687);
            frame_info.Name = "frame_info";
            frame_info.Size = new Size(384, 79);
            frame_info.TabIndex = 1;
            // 
            // roundedPanel2
            // 
            roundedPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            roundedPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            roundedPanel2.BackColor = Color.FromArgb(211, 211, 222);
            roundedPanel2.borderColor = Color.Red;
            roundedPanel2.BorderWidth = 0;
            roundedPanel2.Controls.Add(pictureBox3);
            roundedPanel2.Controls.Add(label3);
            roundedPanel2.CornerRadius = 4;
            roundedPanel2.Location = new Point(261, 0);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(122, 79);
            roundedPanel2.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.icon_stored;
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Location = new Point(45, 39);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Pretendard Variable", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.Location = new Point(38, 8);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 0;
            label3.Text = "Stored";
            // 
            // roundedPanel1
            // 
            roundedPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            roundedPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            roundedPanel1.BackColor = Color.FromArgb(211, 211, 222);
            roundedPanel1.borderColor = Color.Red;
            roundedPanel1.BorderWidth = 0;
            roundedPanel1.Controls.Add(pictureBox2);
            roundedPanel1.Controls.Add(label2);
            roundedPanel1.CornerRadius = 4;
            roundedPanel1.Location = new Point(131, 0);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(122, 79);
            roundedPanel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.icon_ready;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(45, 39);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Pretendard Variable", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.Location = new Point(15, 8);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 0;
            label2.Text = "Ready to Store";
            // 
            // panel_info_1
            // 
            panel_info_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel_info_1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_info_1.BackColor = Color.FromArgb(211, 211, 222);
            panel_info_1.borderColor = Color.Red;
            panel_info_1.BorderWidth = 0;
            panel_info_1.Controls.Add(pictureBox1);
            panel_info_1.Controls.Add(label1);
            panel_info_1.CornerRadius = 4;
            panel_info_1.Location = new Point(0, 0);
            panel_info_1.Name = "panel_info_1";
            panel_info_1.Size = new Size(122, 79);
            panel_info_1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.icon_play;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(45, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Pretendard Variable", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Inference Stage";
            // 
            // frame_data
            // 
            frame_data.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            frame_data.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            frame_data.BackColor = Color.FromArgb(54, 54, 73);
            frame_data.Controls.Add(frame_lower);
            frame_data.Controls.Add(frame_upper);
            frame_data.Location = new Point(8, 8);
            frame_data.Name = "frame_data";
            frame_data.Size = new Size(384, 663);
            frame_data.TabIndex = 0;
            // 
            // frame_lower
            // 
            frame_lower.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            frame_lower.BackColor = Color.FromArgb(11, 11, 15);
            frame_lower.Controls.Add(panel5);
            frame_lower.Controls.Add(panel4);
            frame_lower.Controls.Add(panel3);
            frame_lower.Controls.Add(panel2);
            frame_lower.Controls.Add(data_time);
            frame_lower.Location = new Point(0, 507);
            frame_lower.Name = "frame_lower";
            frame_lower.Size = new Size(384, 156);
            frame_lower.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(33, 33, 44);
            panel5.Location = new Point(0, 121);
            panel5.Name = "panel5";
            panel5.Size = new Size(384, 1);
            panel5.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(33, 33, 44);
            panel4.Location = new Point(0, 35);
            panel4.Name = "panel4";
            panel4.Size = new Size(384, 1);
            panel4.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.BackColor = Color.FromArgb(11, 11, 15);
            panel3.Controls.Add(text_options);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(0, 35);
            panel3.Name = "panel3";
            panel3.Size = new Size(384, 86);
            panel3.TabIndex = 5;
            // 
            // text_options
            // 
            text_options.AutoSize = true;
            text_options.Font = new Font("Pretendard Variable", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            text_options.ForeColor = Color.FromArgb(182, 182, 201);
            text_options.Location = new Point(88, 10);
            text_options.Name = "text_options";
            text_options.Size = new Size(0, 14);
            text_options.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.FromArgb(11, 11, 15);
            panel2.Controls.Add(text_modality);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(0, 122);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 34);
            panel2.TabIndex = 4;
            // 
            // text_modality
            // 
            text_modality.AutoSize = true;
            text_modality.Font = new Font("Pretendard Variable", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            text_modality.ForeColor = Color.FromArgb(182, 182, 201);
            text_modality.Location = new Point(88, 10);
            text_modality.Name = "text_modality";
            text_modality.Size = new Size(0, 14);
            text_modality.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Pretendard Variable", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label7.ForeColor = Color.FromArgb(182, 182, 201);
            label7.Location = new Point(8, 10);
            label7.Name = "label7";
            label7.Size = new Size(53, 14);
            label7.TabIndex = 0;
            label7.Text = "Modality";
            // 
            // data_time
            // 
            data_time.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            data_time.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            data_time.BackColor = Color.FromArgb(11, 11, 15);
            data_time.Controls.Add(text_time);
            data_time.Controls.Add(text_date);
            data_time.Controls.Add(label4);
            data_time.Location = new Point(0, 0);
            data_time.Name = "data_time";
            data_time.Size = new Size(384, 34);
            data_time.TabIndex = 3;
            // 
            // text_time
            // 
            text_time.AutoSize = true;
            text_time.Font = new Font("Pretendard Variable", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            text_time.ForeColor = Color.FromArgb(182, 182, 201);
            text_time.Location = new Point(155, 10);
            text_time.Name = "text_time";
            text_time.Size = new Size(0, 14);
            text_time.TabIndex = 2;
            // 
            // text_date
            // 
            text_date.AutoSize = true;
            text_date.Font = new Font("Pretendard Variable", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            text_date.ForeColor = Color.FromArgb(182, 182, 201);
            text_date.Location = new Point(88, 10);
            text_date.Name = "text_date";
            text_date.Size = new Size(0, 14);
            text_date.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Pretendard Variable", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label4.ForeColor = Color.FromArgb(182, 182, 201);
            label4.Location = new Point(8, 10);
            label4.Name = "label4";
            label4.Size = new Size(34, 14);
            label4.TabIndex = 0;
            label4.Text = "Time";
            // 
            // frame_upper
            // 
            frame_upper.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            frame_upper.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            frame_upper.BackColor = Color.FromArgb(11, 11, 15);
            frame_upper.Location = new Point(0, 0);
            frame_upper.Name = "frame_upper";
            frame_upper.Size = new Size(384, 503);
            frame_upper.TabIndex = 1;
            // 
            // DisplayMetadataControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 44);
            Controls.Add(panel1);
            Name = "DisplayMetadataControl";
            Size = new Size(400, 774);
            panel1.ResumeLayout(false);
            frame_info.ResumeLayout(false);
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel_info_1.ResumeLayout(false);
            panel_info_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            frame_data.ResumeLayout(false);
            frame_lower.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            data_time.ResumeLayout(false);
            data_time.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RoundedPanel panel1;
        private Panel frame_data;
        private Panel frame_lower;
        private Panel frame_upper;
        private Panel frame_info;
        private RoundedPanel panel_info_1;
        private Label label1;
        private PictureBox pictureBox1;
        private RoundedPanel roundedPanel2;
        private PictureBox pictureBox3;
        private Label label3;
        private RoundedPanel roundedPanel1;
        private PictureBox pictureBox2;
        private Label label2;
        private Panel data_time;
        private Label label4;
        private Label text_date;
        private Label text_time;
        private Panel panel2;
        private Label text_modality;
        private Label label7;
        private Panel panel3;
        private Label text_options;
        private Panel panel4;
        private Panel panel5;
    }
}
