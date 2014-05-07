using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DumbCharlie1
{
    public partial class CallerRole : UserControl
    {
        public CallerRole()
        {
            InitializeComponent();
        }
        //note to self, take data table out of function
        //that is all
        public void nextBtn_Click(object sender, EventArgs e)
        {
            LossDecription ldParent = this.ParentForm as LossDecription;
            DataRow row = ldParent.peopleDataTable.NewRow();
            row["FirstName"] = txtFirstName.Text;
            row["LastName"] = txtLastName.Text;
            row["PhoneNumber"] = txtPhoneNum.Text;
            row["Extension"] = txtExt.Text;
            row["CallerRole"] = txtCallerRole.Text;
            row["Other"] = txtOther.Text;
            ldParent.peopleDataTable.Rows.Add(row);
            this.Visible = false;

        }         
    }
}
