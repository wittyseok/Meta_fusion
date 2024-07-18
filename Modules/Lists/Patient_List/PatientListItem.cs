using Metafusion.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metafusion
{
    public partial class PatientListItem : UserControl
    {
        private Label titleLabel;
        private static Color color_inference = Color.FromArgb(138, 26, 15);
        private static Color color_ready = Color.FromArgb(15, 100, 138);
        private static Color color_stored = Color.FromArgb(15, 138, 57);
        private static Color color_none = Color.Black;

        private bool _is_checked = false;
        public bool is_checked
        {
            get { return _is_checked; }
            set
            {
                if (this.stage == "ready")
                    _is_checked = value;
                else
                    _is_checked = false;

                if (is_checked)
                {
                    checkbox_bg.BackColor = Color.FromArgb(31, 186, 255);
                }
                else
                {
                    checkbox_bg.BackColor = Color.FromArgb(240, 240, 244);
                }
            }
        }

        public string stage { get; set; } = "";
        public string text_id { get; set; } = "";
        public string text_name { get; set; } = "";
        public string text_storage { get; set; } = "";
        public string text_modality { get; set; } = "";
        public string text_series_description { get; set; } = "";
        public string text_series_date { get; set; } = "";
        public string text_series_time { get; set; } = "";
        public string text_study_description { get; set; } = "";
        public string text_study_date { get; set; } = "";



        public PatientListItem(string stage, string id, string name, string storage, string modality, string series_description, string series_date, string series_time, string study_description, string study_date)
        {
            InitializeComponent();
            InitializeItem(stage, id, name, storage, modality, series_description, series_date, series_time, study_description, study_date);
        }

        private void InitializeItem(string stage, string id, string name, string storage, string modality, string series_description, string series_date, string series_time, string study_description, string study_date)
        {
            this.is_checked = false;
            this.stage = stage;

            this.text_id = id;
            this.text_name = name;
            this.text_storage = storage;
            this.text_modality = modality;
            this.text_series_description = series_description;
            this.text_series_date = series_date;
            this.text_series_time = series_time;
            this.text_study_description = study_description;
            this.text_study_date = study_date;


            this.patient_id.Text = this.text_id;
            this.patient_name.Text = this.text_name;
            this.storage.Text = this.text_storage;
            this.modality.Text = this.text_modality;
            this.series_description.Text = this.text_series_description;
            this.series_date.Text = this.text_series_date;
            this.series_time.Text = this.text_series_time;
            this.study_description.Text = this.text_study_description;
            this.study_date.Text = this.text_study_date;

            switch (stage)
            {
                case "inference":
                    this.BackColor = color_inference;
                    break;
                case "ready":
                    this.BackColor = color_ready;
                    this.is_checked = true;
                    break;
                case "stored":
                    this.BackColor = color_stored;
                    break;
                default:
                    this.BackColor = color_none;
                    break;
            }
            if (is_checked)
            {
                checkbox_bg.BackColor = Color.FromArgb(31, 186, 255);
            }
            else
            {
                checkbox_bg.BackColor = Color.FromArgb(240, 240, 244);
            }
        }

        private void ROIListItem_Load(object sender, EventArgs e)
        {

        }

        private void icon_check_Click(object sender, EventArgs e)
        {
            is_checked = !is_checked;
        }

        private List<string> text_options = new List<string>();

        //TODO: set/get options
        public string options
        {
            get
            {
                return this._options();
            }
        }

        private string _options()
        {
            return "TO_BE_UPDATED\nTHIS_IS_DUMMY_TEXT\nWILL_BE_ADDED_LATER";
        }

        public event EventHandler<ItemClickedEventArgs> ItemClicked;
        private void item_Click(object sender, EventArgs e)
        {
            ItemClicked?.Invoke(this, new ItemClickedEventArgs(this));
        }

        public class ItemClickedEventArgs : EventArgs
        {
            public PatientListItem ClickedItem { get; }

            public ItemClickedEventArgs(PatientListItem item)
            {
                ClickedItem = item;
            }
        }
    }
}
