namespace Metafusion
{
    partial class LeftToolbar
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
            button_transfer = new RoundedPanel();
            picture_transfer = new PictureBox();
            button_load = new RoundedPanel();
            picture_load = new PictureBox();
            button_center = new RoundedPanel();
            picture_center = new PictureBox();
            button_sub = new RoundedPanel();
            picture_sub = new PictureBox();
            button_add = new RoundedPanel();
            picture_add = new PictureBox();
            button_toggle = new RoundedPanel();
            picture_toggle = new PictureBox();
            button_transfer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_transfer).BeginInit();
            button_load.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_load).BeginInit();
            button_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_center).BeginInit();
            button_sub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_sub).BeginInit();
            button_add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_add).BeginInit();
            button_toggle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_toggle).BeginInit();
            SuspendLayout();
            // 
            // button_transfer
            // 
            button_transfer.BackColor = Color.FromArgb(76, 76, 103);
            button_transfer.borderColor = Color.FromArgb(98, 98, 132);
            button_transfer.BorderWidth = 1;
            button_transfer.Controls.Add(picture_transfer);
            button_transfer.CornerRadius = 4;
            button_transfer.Location = new Point(180, 0);
            button_transfer.Name = "button_transfer";
            button_transfer.Size = new Size(32, 32);
            button_transfer.TabIndex = 11;
            // 
            // picture_transfer
            // 
            picture_transfer.BackgroundImage = Properties.Resources.icon_transfer;
            picture_transfer.BackgroundImageLayout = ImageLayout.Center;
            picture_transfer.Location = new Point(6, 8);
            picture_transfer.Name = "picture_transfer";
            picture_transfer.Size = new Size(21, 17);
            picture_transfer.SizeMode = PictureBoxSizeMode.CenterImage;
            picture_transfer.TabIndex = 0;
            picture_transfer.TabStop = false;
            // 
            // button_load
            // 
            button_load.BackColor = Color.FromArgb(76, 76, 103);
            button_load.borderColor = Color.FromArgb(98, 98, 132);
            button_load.BorderWidth = 1;
            button_load.Controls.Add(picture_load);
            button_load.CornerRadius = 4;
            button_load.Location = new Point(142, 0);
            button_load.Name = "button_load";
            button_load.Size = new Size(32, 32);
            button_load.TabIndex = 10;
            // 
            // picture_load
            // 
            picture_load.BackgroundImage = Properties.Resources.icon_load;
            picture_load.BackgroundImageLayout = ImageLayout.Center;
            picture_load.Location = new Point(6, 8);
            picture_load.Name = "picture_load";
            picture_load.Size = new Size(21, 16);
            picture_load.SizeMode = PictureBoxSizeMode.CenterImage;
            picture_load.TabIndex = 0;
            picture_load.TabStop = false;
            // 
            // button_center
            // 
            button_center.BackColor = Color.FromArgb(76, 76, 103);
            button_center.borderColor = Color.FromArgb(98, 98, 132);
            button_center.BorderWidth = 1;
            button_center.Controls.Add(picture_center);
            button_center.CornerRadius = 4;
            button_center.Location = new Point(108, 0);
            button_center.Name = "button_center";
            button_center.Size = new Size(32, 32);
            button_center.TabIndex = 9;
            // 
            // picture_center
            // 
            picture_center.BackgroundImage = Properties.Resources.icon_center;
            picture_center.BackgroundImageLayout = ImageLayout.Center;
            picture_center.Location = new Point(6, 6);
            picture_center.Name = "picture_center";
            picture_center.Size = new Size(21, 21);
            picture_center.SizeMode = PictureBoxSizeMode.CenterImage;
            picture_center.TabIndex = 0;
            picture_center.TabStop = false;
            picture_center.Click += picture_center_Click;
            // 
            // button_sub
            // 
            button_sub.BackColor = Color.FromArgb(76, 76, 103);
            button_sub.borderColor = Color.FromArgb(98, 98, 132);
            button_sub.BorderWidth = 1;
            button_sub.Controls.Add(picture_sub);
            button_sub.CornerRadius = 4;
            button_sub.Location = new Point(72, 0);
            button_sub.Name = "button_sub";
            button_sub.Size = new Size(32, 32);
            button_sub.TabIndex = 8;
            // 
            // picture_sub
            // 
            picture_sub.BackgroundImage = Properties.Resources.icon_sub;
            picture_sub.BackgroundImageLayout = ImageLayout.Center;
            picture_sub.Location = new Point(6, 6);
            picture_sub.Name = "picture_sub";
            picture_sub.Size = new Size(21, 21);
            picture_sub.SizeMode = PictureBoxSizeMode.CenterImage;
            picture_sub.TabIndex = 0;
            picture_sub.TabStop = false;
            // 
            // button_add
            // 
            button_add.BackColor = Color.FromArgb(76, 76, 103);
            button_add.borderColor = Color.FromArgb(98, 98, 132);
            button_add.BorderWidth = 1;
            button_add.Controls.Add(picture_add);
            button_add.CornerRadius = 4;
            button_add.Location = new Point(36, 0);
            button_add.Name = "button_add";
            button_add.Size = new Size(32, 32);
            button_add.TabIndex = 7;
            // 
            // picture_add
            // 
            picture_add.BackgroundImage = Properties.Resources.icon_add;
            picture_add.BackgroundImageLayout = ImageLayout.Center;
            picture_add.Location = new Point(6, 6);
            picture_add.Name = "picture_add";
            picture_add.Size = new Size(21, 21);
            picture_add.SizeMode = PictureBoxSizeMode.CenterImage;
            picture_add.TabIndex = 0;
            picture_add.TabStop = false;
            // 
            // button_toggle
            // 
            button_toggle.BackColor = Color.FromArgb(76, 76, 103);
            button_toggle.borderColor = Color.FromArgb(98, 98, 132);
            button_toggle.BorderWidth = 1;
            button_toggle.Controls.Add(picture_toggle);
            button_toggle.CornerRadius = 4;
            button_toggle.Location = new Point(0, 0);
            button_toggle.Name = "button_toggle";
            button_toggle.Size = new Size(32, 32);
            button_toggle.TabIndex = 6;
            // 
            // picture_toggle
            // 
            picture_toggle.BackgroundImage = Properties.Resources.icon_toggle;
            picture_toggle.BackgroundImageLayout = ImageLayout.Stretch;
            picture_toggle.Location = new Point(4, 4);
            picture_toggle.Name = "picture_toggle";
            picture_toggle.Size = new Size(25, 25);
            picture_toggle.SizeMode = PictureBoxSizeMode.CenterImage;
            picture_toggle.TabIndex = 0;
            picture_toggle.TabStop = false;
            // 
            // LeftToolbar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 54, 73);
            Controls.Add(button_transfer);
            Controls.Add(button_load);
            Controls.Add(button_center);
            Controls.Add(button_sub);
            Controls.Add(button_add);
            Controls.Add(button_toggle);
            Name = "LeftToolbar";
            Size = new Size(212, 32);
            button_transfer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture_transfer).EndInit();
            button_load.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture_load).EndInit();
            button_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture_center).EndInit();
            button_sub.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture_sub).EndInit();
            button_add.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture_add).EndInit();
            button_toggle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture_toggle).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RoundedPanel button_transfer;
        private PictureBox picture_transfer;
        private RoundedPanel button_load;
        private PictureBox picture_load;
        private RoundedPanel button_center;
        private PictureBox picture_center;
        private RoundedPanel button_sub;
        private PictureBox picture_sub;
        private RoundedPanel button_add;
        private PictureBox picture_add;
        private RoundedPanel button_toggle;
        private PictureBox picture_toggle;
    }
}
