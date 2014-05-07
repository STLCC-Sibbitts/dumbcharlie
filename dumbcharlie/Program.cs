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

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LossDecription LDecription = new LossDecription();
            DataTable dumbCharlieDataTable = HoldDataMethod();
            LDecription.peopleDataTable = dumbCharlieDataTable;
            LDecription.ShowDialog();
            // DUMP data that is in dumbCharlieDataTable
        }
        public static DataTable HoldDataMethod()
        {
            DataTable peopleDataTable = new DataTable();
            DataColumn column;
            
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "FirstName";
            peopleDataTable.Columns.Add(column);
            //this vvv is the same as that ^^^
            peopleDataTable.Columns.Add(new DataColumn("LastName", System.Type.GetType("System.String")));
            peopleDataTable.Columns.Add(new DataColumn("PhoneNumber", System.Type.GetType("System.String")));
            peopleDataTable.Columns.Add(new DataColumn("Extension", System.Type.GetType("System.String")));
            peopleDataTable.Columns.Add(new DataColumn("CallerRole", System.Type.GetType("System.String")));
            peopleDataTable.Columns.Add(new DataColumn("Other", System.Type.GetType("System.String")));

            return peopleDataTable;
        }
        //public static DataTable WriteDataToTxt()
        //{
        //    using (System.IO.StreamWriter file = new System.IO.StreamWriter("../../DC" + DateTime.Now.ToString("[yyyy-MM-dd-HH-mm-ss]") + ".txt", true))
        //    {
        //        //LossDecription LossDecript = new LossDecription();
        //        //DataTable CharlieDataTable = HoldDataMethod();
        //        //LossDecript.peopleDataTable = CharlieDataTable;
        //        Program.HoldDataMethod();
        //        DataTable CharlieDataTable = HoldDataMethod;
        //        foreach (DataRow row in CharlieDataTable.Rows)
        //        {
        //            foreach (string col in row.ItemArray)
        //            {
        //                file.Write(col + "\t");
        //            }
        //            file.WriteLine();
        //        }
        //        return CharlieDataTable;
        //    }

            
        //}

        
    }
}
