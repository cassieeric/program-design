using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 贺培超
{
    public partial class mail_setting : Form
    {
        public  string rt = "";
        public mail_setting()
        {
            InitializeComponent();
        }

        private void mail_setting_Load(object sender, EventArgs e)
        {
            richtbxMailContentReview.Text = rt;
        }
    }
}
