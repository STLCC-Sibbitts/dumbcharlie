using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DumbCharlie1
{
    public partial class LossDecription : Form
    {
        public DataTable peopleDataTable { get; set; }
        
        public LossDecription()
        {
            InitializeComponent();
        }
        string[] lossDecriptionData = new string[8];
        public Array HoldLossDecriptData()
        {
            lossDecriptionData[0] = txtDescription.Text;
            lossDecriptionData[1] = txtNumInvolved.Text;
            lossDecriptionData[2] = txtLossType.Text;
            lossDecriptionData[3] = txtLocation.Text;
            lossDecriptionData[4] = txtState.Text;
            lossDecriptionData[5] = txtCity.Text;
            lossDecriptionData[6] = comboPDFD.Text;
            lossDecriptionData[7] = comboWitness.Text;

            return lossDecriptionData;
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {

            string filename = "../../DC" + DateTime.Now.ToString("[yyyy-MM-dd] HH-mm") + ".txt";
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, true))
            {
                HoldLossDecriptData();
                LossDecription ldParent = this.ParentForm as LossDecription;
                foreach (DataRow row in peopleDataTable.Rows)
                {
                    foreach (string col in row.ItemArray)
                    {
                        file.Write(col + "\t");
                    }
                    file.WriteLine();
                }
                for (int x = 0; x < lossDecriptionData.Length ; x++)
                {
                    file.Write(lossDecriptionData[x] + "\r\n");
                }


            }
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void callerRole1_Load(object sender, EventArgs e)
        {

        }
    }
}
