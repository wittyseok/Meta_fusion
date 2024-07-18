namespace Metafusion.Modules.Page_dedicated.Home
{
    partial class SetFilterControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetFilterControl));
            panel_bg = new RoundedPanel();
            flatCombo_Normal1 = new FlatCombo_Normal();
            button_search = new RoundedButton();
            selector_date = new Button_Selector();
            selector_patient_name = new Button_Selector();
            selector_patient_id = new Button_Selector();
            label2 = new Label();
            Selector_path = new Button_Selector();
            dropdown_storage = new FlatCombo_Normal();
            panel_bg.SuspendLayout();
            SuspendLayout();
            // 
            // panel_bg
            // 
            panel_bg.BackColor = Color.FromArgb(54, 54, 73);
            panel_bg.borderColor = Color.Red;
            panel_bg.BorderWidth = 0;
            panel_bg.Controls.Add(flatCombo_Normal1);
            panel_bg.Controls.Add(button_search);
            panel_bg.Controls.Add(selector_date);
            panel_bg.Controls.Add(selector_patient_name);
            panel_bg.Controls.Add(selector_patient_id);
            panel_bg.Controls.Add(label2);
            panel_bg.Controls.Add(Selector_path);
            panel_bg.Controls.Add(dropdown_storage);
            panel_bg.CornerRadius = 4;
            panel_bg.Location = new Point(0, 0);
            panel_bg.Name = "panel_bg";
            panel_bg.ScrollDisabled = false;
            panel_bg.Size = new Size(400, 237);
            panel_bg.TabIndex = 0;
            panel_bg.Paint += panel_bg_Paint;
            // 
            // flatCombo_Normal1
            // 
            flatCombo_Normal1.BackColor = Color.FromArgb(76, 76, 103);
            flatCombo_Normal1.BorderColor = Color.FromArgb(182, 182, 201);
            flatCombo_Normal1.ButtonColor = Color.FromArgb(76, 76, 103);
            flatCombo_Normal1.DrawMode = DrawMode.OwnerDrawVariable;
            flatCombo_Normal1.DropDownStyle = ComboBoxStyle.DropDownList;
            flatCombo_Normal1.Font = new Font("Pretendard Variable Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            flatCombo_Normal1.ForeColor = Color.White;
            flatCombo_Normal1.ItemHeight = 20;
            flatCombo_Normal1.Location = new Point(8, 161);
            flatCombo_Normal1.Name = "flatCombo_Normal1";
            flatCombo_Normal1.Size = new Size(190, 26);
            flatCombo_Normal1.TabIndex = 20;
            flatCombo_Normal1.Text_default = "Tag";
            // 
            // button_search
            // 
            button_search.BackColor = Color.FromArgb(0, 161, 233);
            button_search.CornerRadius = 4;
            button_search.deactivatedColor = Color.LightGray;
            button_search.FlatAppearance.BorderColor = Color.White;
            button_search.FlatAppearance.BorderSize = 0;
            button_search.FlatStyle = FlatStyle.Flat;
            button_search.Font = new Font("Pretendard Variable", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button_search.ForeColor = Color.White;
            button_search.Location = new Point(8, 195);
            button_search.Name = "button_search";
            button_search.normalColor = Color.FromArgb(0, 161, 233);
            button_search.Size = new Size(384, 34);
            button_search.TabIndex = 19;
            button_search.Text = "SEARCH";
            button_search.UseVisualStyleBackColor = false;
            // 
            // selector_date
            // 
            selector_date.BackColor = Color.FromArgb(54, 54, 73);
            selector_date.Location = new Point(202, 161);
            selector_date.Name = "selector_date";
            selector_date.Selector_icon = (Image)resources.GetObject("selector_date.Selector_icon");
            selector_date.Size = new Size(190, 26);
            selector_date.TabIndex = 18;
            selector_date.Text = "button_Selector1";
            selector_date.Text_default = "Date";
            // 
            // selector_patient_name
            // 
            selector_patient_name.BackColor = Color.FromArgb(54, 54, 73);
            selector_patient_name.Location = new Point(8, 131);
            selector_patient_name.Name = "selector_patient_name";
            selector_patient_name.Selector_icon = (Image)resources.GetObject("selector_patient_name.Selector_icon");
            selector_patient_name.Size = new Size(384, 26);
            selector_patient_name.TabIndex = 16;
            selector_patient_name.Text = "button_Selector1";
            selector_patient_name.Text_default = "";
            // 
            // selector_patient_id
            // 
            selector_patient_id.BackColor = Color.FromArgb(54, 54, 73);
            selector_patient_id.Location = new Point(8, 101);
            selector_patient_id.Name = "selector_patient_id";
            selector_patient_id.Selector_icon = (Image)resources.GetObject("selector_patient_id.Selector_icon");
            selector_patient_id.Size = new Size(384, 26);
            selector_patient_id.TabIndex = 15;
            selector_patient_id.Text = "button_Selector1";
            selector_patient_id.Text_default = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Pretendard Variable Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.ForeColor = Color.White;
            label2.Location = new Point(8, 76);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 14;
            label2.Text = "Search";
            // 
            // Selector_path
            // 
            Selector_path.BackColor = Color.FromArgb(54, 54, 73);
            Selector_path.Location = new Point(8, 42);
            Selector_path.Name = "Selector_path";
            Selector_path.Selector_icon = (Image)resources.GetObject("Selector_path.Selector_icon");
            Selector_path.Size = new Size(384, 26);
            Selector_path.TabIndex = 13;
            Selector_path.Text = "button_Selector1";
            Selector_path.Text_default = "Select Path";
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
            dropdown_storage.ItemHeight = 20;
            dropdown_storage.Location = new Point(8, 8);
            dropdown_storage.Name = "dropdown_storage";
            dropdown_storage.Size = new Size(384, 26);
            dropdown_storage.TabIndex = 12;
            dropdown_storage.Text_default = "Select Storage";
            // 
            // SetFilterControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 44);
            Controls.Add(panel_bg);
            DoubleBuffered = true;
            Name = "SetFilterControl";
            Size = new Size(400, 237);
            panel_bg.ResumeLayout(false);
            panel_bg.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RoundedPanel panel_bg;
        private Button_Selector Selector_path;
        private FlatCombo_Normal dropdown_storage;
        private Label label2;
        private Button_Selector selector_patient_name;
        private Button_Selector selector_patient_id;
        private Button_Selector selector_date;
        private RoundedButton button_search;
        private FlatCombo_Normal flatCombo_Normal1;
    }
}
