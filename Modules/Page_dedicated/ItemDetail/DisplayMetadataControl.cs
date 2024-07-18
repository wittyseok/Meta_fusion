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
    public partial class DisplayMetadataControl : UserControl
    {
        public DisplayMetadataControl()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void set_Metadata(PatientListItem item)
        {
            this.text_date.Text = item.text_series_date;
            this.text_modality.Text = item.text_modality;
            this.text_time.Text = item.text_series_time;
            this.text_options.Text = item.options;
        }
    }
}
