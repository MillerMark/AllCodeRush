using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Expressions
{
    /* •———————————————————————————————————————————————————————•
     * Feature: Introduce Local (Replace All)
     * 
     * Use Case: Lets you create a new local variable 
     * initialized with the selected expression. 
     * Note: This operation replaces other instances of the 
     * expression with same local.
     *  
     * Available: When an expression is selected.
     * 
     * See also: Inline Local, Introduce Local
     * •———————————————————————————————————————————————————————• */

    public class IntroduceLocalReplaceAll
    {
        #region Example1
        public static double CalculateDistance(double y2, double y1, double x2, double x1)
        {
            return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
        }
        #endregion

        #region Example2
        public void DynamicCreate()
        {
            DataSet dataSet = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ID", Type.GetType("System.Int32")));
            dt.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));
            AddRow(dt, 1, "First Row");
            AddRow(dt, 2, "Second Row");
            dataSet.Tables.Add(dt);
            for (int i = 0; i <= dataSet.Tables[0].Rows.Count - 1; i++)
                Console.WriteLine(dataSet.Tables[0].Rows[i].ItemArray[0] + " -- " + dataSet.Tables[0].Rows[i].ItemArray[1]);
        }
        private static void AddRow(DataTable dt, int id, string name)
        {
            DataRow dr = dt.NewRow();
            dr["ID"] = id;
            dr["Name"] = name;
            dt.Rows.Add(dr);
        }
                #endregion
    }
}

