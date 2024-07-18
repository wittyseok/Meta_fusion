namespace Metafusion
{
    partial class PatientListItem
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
            panel_info = new Panel();
            study_date = new Label();
            study_description = new Label();
            series_time = new Label();
            series_date = new Label();
            series_description = new Label();
            modality = new Label();
            storage = new Label();
            patient_name = new Label();
            patient_id = new Label();
            checkbox_bg = new RoundedPanel();
            icon_check = new PictureBox();
            panel_design = new Panel();
            panel_info.SuspendLayout();
            checkbox_bg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icon_check).BeginInit();
            SuspendLayout();
            // 
            // panel_info
            // 
            panel_info.BackColor = Color.Transparent;
            panel_info.Controls.Add(study_date);
            panel_info.Controls.Add(study_description);
            panel_info.Controls.Add(series_time);
            panel_info.Controls.Add(series_date);
            panel_info.Controls.Add(series_description);
            panel_info.Controls.Add(modality);
            panel_info.Controls.Add(storage);
            panel_info.Controls.Add(patient_name);
            panel_info.Controls.Add(patient_id);
            panel_info.Location = new Point(38, 30);
            panel_info.Name = "panel_info";
            panel_info.Size = new Size(1372, 20);
            panel_info.TabIndex = 0;
            // 
            // study_date
            // 
            study_date.BackColor = Color.Transparent;
            study_date.Dock = DockStyle.Left;
            study_date.Font = new Font("Pretendard Variable Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            study_date.ForeColor = Color.FromArgb(240, 240, 244);
            study_date.ImeMode = ImeMode.NoControl;
            study_date.Location = new Point(1264, 0);
            study_date.Name = "study_date";
            study_date.Size = new Size(158, 20);
            study_date.TabIndex = 15;
            study_date.Text = "2024.07.11.";
            study_date.TextAlign = ContentAlignment.MiddleCenter;
            study_date.Click += item_Click;
            // 
            // study_description
            // 
            study_description.BackColor = Color.Transparent;
            study_description.Dock = DockStyle.Left;
            study_description.Font = new Font("Pretendard Variable Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            study_description.ForeColor = Color.FromArgb(240, 240, 244);
            study_description.ImeMode = ImeMode.NoControl;
            study_description.Location = new Point(1106, 0);
            study_description.Name = "study_description";
            study_description.Size = new Size(158, 20);
            study_description.TabIndex = 14;
            study_description.Text = "study_description";
            study_description.TextAlign = ContentAlignment.MiddleCenter;
            study_description.Click += item_Click;
            // 
            // series_time
            // 
            series_time.BackColor = Color.Transparent;
            series_time.Dock = DockStyle.Left;
            series_time.Font = new Font("Pretendard Variable Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            series_time.ForeColor = Color.FromArgb(240, 240, 244);
            series_time.ImeMode = ImeMode.NoControl;
            series_time.Location = new Point(948, 0);
            series_time.Name = "series_time";
            series_time.Size = new Size(158, 20);
            series_time.TabIndex = 13;
            series_time.Text = "12:49:04";
            series_time.TextAlign = ContentAlignment.MiddleCenter;
            series_time.Click += item_Click;
            // 
            // series_date
            // 
            series_date.BackColor = Color.Transparent;
            series_date.Dock = DockStyle.Left;
            series_date.Font = new Font("Pretendard Variable Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            series_date.ForeColor = Color.FromArgb(240, 240, 244);
            series_date.ImeMode = ImeMode.NoControl;
            series_date.Location = new Point(790, 0);
            series_date.Name = "series_date";
            series_date.Size = new Size(158, 20);
            series_date.TabIndex = 12;
            series_date.Text = "2024.07.11.";
            series_date.TextAlign = ContentAlignment.MiddleCenter;
            series_date.Click += item_Click;
            // 
            // series_description
            // 
            series_description.BackColor = Color.Transparent;
            series_description.Dock = DockStyle.Left;
            series_description.Font = new Font("Pretendard Variable Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            series_description.ForeColor = Color.FromArgb(240, 240, 244);
            series_description.ImeMode = ImeMode.NoControl;
            series_description.Location = new Point(632, 0);
            series_description.Name = "series_description";
            series_description.Size = new Size(158, 20);
            series_description.TabIndex = 11;
            series_description.Text = "series_description";
            series_description.TextAlign = ContentAlignment.MiddleCenter;
            series_description.Click += item_Click;
            // 
            // modality
            // 
            modality.BackColor = Color.Transparent;
            modality.Dock = DockStyle.Left;
            modality.Font = new Font("Pretendard Variable Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            modality.ForeColor = Color.FromArgb(240, 240, 244);
            modality.ImeMode = ImeMode.NoControl;
            modality.Location = new Point(474, 0);
            modality.Name = "modality";
            modality.Size = new Size(158, 20);
            modality.TabIndex = 8;
            modality.Text = "CT";
            modality.TextAlign = ContentAlignment.MiddleCenter;
            modality.Click += item_Click;
            // 
            // storage
            // 
            storage.BackColor = Color.Transparent;
            storage.Dock = DockStyle.Left;
            storage.Font = new Font("Pretendard Variable Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            storage.ForeColor = Color.FromArgb(240, 240, 244);
            storage.ImeMode = ImeMode.NoControl;
            storage.Location = new Point(316, 0);
            storage.Name = "storage";
            storage.Size = new Size(158, 20);
            storage.TabIndex = 5;
            storage.Text = "Local(C:\\)";
            storage.TextAlign = ContentAlignment.MiddleCenter;
            storage.Click += item_Click;
            // 
            // patient_name
            // 
            patient_name.BackColor = Color.Transparent;
            patient_name.Dock = DockStyle.Left;
            patient_name.Font = new Font("Pretendard Variable Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            patient_name.ForeColor = Color.FromArgb(240, 240, 244);
            patient_name.ImeMode = ImeMode.NoControl;
            patient_name.Location = new Point(158, 0);
            patient_name.Name = "patient_name";
            patient_name.Size = new Size(158, 20);
            patient_name.TabIndex = 1;
            patient_name.Text = "Patient_Name_0001";
            patient_name.TextAlign = ContentAlignment.MiddleCenter;
            patient_name.Click += item_Click;
            // 
            // patient_id
            // 
            patient_id.BackColor = Color.Transparent;
            patient_id.Dock = DockStyle.Left;
            patient_id.Font = new Font("Pretendard Variable Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            patient_id.ForeColor = Color.FromArgb(240, 240, 244);
            patient_id.ImeMode = ImeMode.NoControl;
            patient_id.Location = new Point(0, 0);
            patient_id.Name = "patient_id";
            patient_id.Size = new Size(158, 20);
            patient_id.TabIndex = 0;
            patient_id.Text = "Patient_ID_0001";
            patient_id.TextAlign = ContentAlignment.MiddleCenter;
            patient_id.Click += item_Click;
            // 
            // checkbox_bg
            // 
            checkbox_bg.BackColor = Color.FromArgb(31, 186, 255);
            checkbox_bg.borderColor = Color.Red;
            checkbox_bg.BorderWidth = 0;
            checkbox_bg.Controls.Add(icon_check);
            checkbox_bg.CornerRadius = 4;
            checkbox_bg.Location = new Point(12, 32);
            checkbox_bg.Name = "checkbox_bg";
            checkbox_bg.ScrollDisabled = false;
            checkbox_bg.Size = new Size(16, 16);
            checkbox_bg.TabIndex = 4;
            // 
            // icon_check
            // 
            icon_check.BackColor = Color.Transparent;
            icon_check.BackgroundImage = Properties.Resources.icon_check;
            icon_check.BackgroundImageLayout = ImageLayout.Stretch;
            icon_check.Location = new Point(1, 1);
            icon_check.Name = "icon_check";
            icon_check.Size = new Size(14, 14);
            icon_check.TabIndex = 4;
            icon_check.TabStop = false;
            icon_check.Click += icon_check_Click;
            // 
            // panel_design
            // 
            panel_design.BackColor = Color.FromArgb(54, 54, 73);
            panel_design.Location = new Point(0, 79);
            panel_design.Margin = new Padding(0);
            panel_design.Name = "panel_design";
            panel_design.Size = new Size(1459, 1);
            panel_design.TabIndex = 5;
            // 
            // PatientListItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(panel_info);
            Controls.Add(checkbox_bg);
            Controls.Add(panel_design);
            Margin = new Padding(0);
            Name = "PatientListItem";
            Size = new Size(1459, 80);
            Load += ROIListItem_Load;
            Click += item_Click;
            panel_info.ResumeLayout(false);
            checkbox_bg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icon_check).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_info;
        private Label patient_id;
        private RoundedPanel checkbox_bg;
        private PictureBox icon_check;
        private Label patient_name;
        private Label storage;
        private Panel panel_design;
        private Label modality;
        private Label study_description;
        private Label series_time;
        private Label series_date;
        private Label series_description;
        private Label study_date;
    }
}
