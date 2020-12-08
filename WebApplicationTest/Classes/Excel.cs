using COL.NEA.FAS;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Web;
using Excel = Microsoft.Office.Interop.Excel;

namespace WebApplicationTest.Classes
{
    public class ExcelCreator
    {
        public ExcelCreator()
        {

        }

        public void CreateNewFile(Request request)
        {
            string fileName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + "ExcelReport_" + DateTime.Now.Ticks + ".xlsx";
            object misValue = System.Reflection.Missing.Value;
            var app = new Excel.Application();
            var workbook = app.Workbooks.Add(misValue);
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];
            int column = 1;
            foreach (PropertyInfo property in request.GetType().GetProperties())
            {
                worksheet.Cells[1, column] = property.Name;

                int columnForInnerProperty = 1;
                Debug.WriteLine(request.GetType().GetProperty(property.Name).GetType().Name);
                //if (request.GetType().GetProperty(property.Name).GetType().Length > 1)
                //{
                //    workbook.Sheets.Add(After: workbook.Sheets[workbook.Sheets.Count]);
                //    int lastWorksheet = workbook.Sheets.Count;
                //    Excel.Worksheet innerSheet = (Excel.Worksheet)workbook.Sheets[lastWorksheet];
                //    foreach (var innerProperty in property.GetType().GetProperties())
                //    {
                //        Debug.WriteLine(JsonConvert.SerializeObject(innerProperty));
                //        innerSheet.Cells[1, columnForInnerProperty] = innerProperty.Name;
                //        columnForInnerProperty++;
                //    }
                //}

                column++;
            }

            worksheet.Columns.AutoFit();
            //worksheet.Cells[1, 1] = "property";
            //worksheet.Cells[0, 0] = "property";

            workbook.SaveAs(fileName);
            workbook.Close();
        }
    }
}