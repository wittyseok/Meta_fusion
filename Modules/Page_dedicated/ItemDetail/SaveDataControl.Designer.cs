namespace Metafusion
{
    partial class SaveDataControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveDataControl));
            label1 = new Label();
            panel1 = new RoundedPanel();
            dropdown_storage = new FlatCombo_Normal();
            Selector_path = new Button_Selector();
            button1 = new RoundedButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Pretendard Variable Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "Save Data";
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.FromArgb(54, 54, 73);
            panel1.borderColor = Color.Red;
            panel1.BorderWidth = 0;
            panel1.Controls.Add(dropdown_storage);
            panel1.Controls.Add(Selector_path);
            panel1.Controls.Add(button1);
            panel1.CornerRadius = 4;
            panel1.Location = new Point(0, 29);
            panel1.Name = "panel1";
            panel1.ScrollDisabled = false;
            panel1.Size = new Size(400, 122);
            panel1.TabIndex = 2;
            // 
            // dropdown_storage
            // 
            dropdown_storage.BackColor = Color.FromArgb(76, 76, 103);
            dropdown_storage.BorderColor = Color.FromArgb(182, 182, 201);
            dropdown_storage.ButtonColor = Color.FromArgb(76, 76, 103);
            dropdown_storage.DrawMode = DrawMode.OwnerDrawVariable;
            dropdown_storage.DropDownStyle = ComboBoxStyle.DropDownList;
            dropdown_storage.Font = new Font("Pretendard Variable Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            dropdown_storage.ForeColor = Color.White;
            dropdown_storage.FormattingEnabled = true;
            dropdown_storage.ItemHeight = 20;
            dropdown_storage.Location = new Point(8, 8);
            dropdown_storage.Name = "dropdown_storage";
            dropdown_storage.Size = new Size(384, 26);
            dropdown_storage.TabIndex = 11;
            dropdown_storage.Text_default = "Select Storage";
            dropdown_storage.SelectedIndexChanged += dropdown_storage_SelectedIndexChanged;
            // 
            // Selector_path
            // 
            Selector_path.BackColor = Color.FromArgb(54, 54, 73);
            Selector_path.Location = new Point(8, 38);
            Selector_path.Name = "Selector_path";
            Selector_path.Size = new Size(384, 26);
            Selector_path.Selector_icon = (Image)resources.GetObject("Selector_path.Icon");
            Selector_path.TabIndex = 6;
            Selector_path.Text = "button_Selector1";
            Selector_path.Text_default = "Select Path";
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
            button1.Font = new Font("Pretendard", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(8, 80);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.normalColor = Color.FromArgb(123, 123, 157);
            button1.Size = new Size(384, 34);
            button1.TabIndex = 5;
            button1.Tag = "SignInButton";
            button1.Text = "SELECT";
            button1.UseVisualStyleBackColor = false;
            // 
            // SaveDataControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(33, 33, 44);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "SaveDataControl";
            Size = new Size(400, 151);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RoundedPanel panel1;
        private RoundedButton button1;
        private Button_Selector Selector_path;
        private FlatCombo_Normal dropdown_storage;
    }
}
