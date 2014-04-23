using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DumbCharlie1
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        public static void HoldData(Object fData, Object lData)
        {
            DataTable peopleDataTable = new DataTable();
            DataColumn column;
            DataRow row;
            // tring to make a method to put into "UserControll1 I.E. CallerRole to add data to DataTable
            // set objects to empty space, but would be unsuccessful due to having to over write information 

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "PersonOne";
            peopleDataTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "PersonTwo";
            peopleDataTable.Columns.Add(column);

            // maybe assign the rows out of the method to include text box input
            // or make text box information public?
            // pass arguments thorugh?? 

            row = peopleDataTable.NewRow();
            row["PersonOne"] = fData;
            row["PersonTwo"] = lData;
            peopleDataTable.Rows.Add(row);
        }
        static void Main()

        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Caller_Info());
            Application.Run(new LossDecription());
            //Caller_Info CI = new Caller_Info();
            //CI.Show();


        }
    }
}
