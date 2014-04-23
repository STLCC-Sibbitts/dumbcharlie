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

        public void nextBtn_Click(object sender, EventArgs e)
        {
            Program newProgram = new Program();

            
            
            object fNameData = txtLastName.Text, lNameData = textBox1.Text;

            


            HoldData(fNameData, lNameData);































            //DataTable peopleDataTable = new DataTable();
            //DataColumn column;
            //DataRow row;

            //column = new DataColumn();
            //column.DataType = System.Type.GetType("System.String");
            //column.ColumnName = "PersonOne";
            //peopleDataTable.Columns.Add(column);

            //column = new DataColumn();
            //column.DataType = System.Type.GetType("System.String");
            //column.ColumnName = "PersonTwo";
            //peopleDataTable.Columns.Add(column);

            //row = peopleDataTable.NewRow();
            //row["PersonOne"] = fNameData;
            //row["PersonTwo"] = lNameData;
            //peopleDataTable.Rows.Add(row);

            

            this.Visible = false;
        }
         

    }
}
