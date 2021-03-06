﻿using System;
using System.Windows.Forms;
using System.Data;
using Ayala_Interface_dotNet.ClassCon;

namespace Ayala_Interface_dotNet
{
    public partial class frmReprocess : Form
    {
        classReprocess classReprocess = new classReprocess();
        
        public frmReprocess()
        {
            InitializeComponent();
        }

        private void btnReprocess_Click(object sender, EventArgs e)
        {
           /* DateTime mStart = Convert.ToDateTime(monthStart.SelectionRange.Start.ToShortDateString());
            DateTime mEnd = Convert.ToDateTime(monthEnd.SelectionStart.ToShortDateString());
            TimeSpan mDateDiff = mEnd.Subtract(mStart);
            pbProgress.Maximum = Convert.ToInt16(mDateDiff.TotalDays.ToString()); */
            classReprocess.dateStart = lblStart.Text;
            classReprocess.dateEnd = lblEnd.Text;
            classReprocess.FilterDate();
            MessageBox.Show("Process Complete!");
            
        }

        private void monthStart_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblStart.Text = monthStart.SelectionStart.ToShortDateString();
        }

        private void monthEnd_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblEnd.Text = monthEnd.SelectionStart.ToShortDateString();
        }

        private void lblStart_Click(object sender, EventArgs e)
        {

        }

        private void frmReprocess_Load(object sender, EventArgs e)
        {
            lblStart.Text = monthStart.SelectionStart.ToShortDateString();
            lblEnd.Text = monthEnd.SelectionStart.ToShortDateString();
        }
    }
}
