using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SetSource
{
    public partial class SecondForm : Form
    {
        private new Form ParentForm { get; set; }
        private string TaskNumber { get; set; }

        public SecondForm(Form parent, string taskNumber)
        {
            InitializeComponent();
            ParentForm = parent;
            TaskNumber = taskNumber;
            this.Text = "Список артефактов по задаче " + taskNumber;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            if (ParentForm != null)
            {
                ParentForm.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (ParentForm != null)
            {
                ParentForm.Show();
            }
            this.Close();
        }
    }
}
