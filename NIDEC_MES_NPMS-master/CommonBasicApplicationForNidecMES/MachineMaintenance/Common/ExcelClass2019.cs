using System;
using System.IO;
using System.Linq;
using System.Data;
using System.Collections.Generic;
using cExcel = Microsoft.Office.Interop.Excel;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Common
{
    public static class ExcelClass2019
    {
        public static string FileName { get; set; }
        static cExcel.Application app;
        static cExcel.Workbook wb;
        static cExcel.Worksheet ws;

        public static void CreateExcelWorkBook(this string filename)
        {
            app = new cExcel.Application();
            wb = app.Workbooks.Add();
            ws = app.ActiveSheet;
        }

        public static bool OpenExcelWorkBook(this string fileopen)
        {
            if (File.Exists(fileopen))
            {
                app = new cExcel.Application();
                wb = app.Workbooks.Open(fileopen);
                ws = app.ActiveSheet;
                return true;
            }
            else
            {
                return false;
                throw new Exception("File not exist or isn't Excel Document!");
            }
        }

        public static void AddColumnsForExcel(string[] cols)
        {
            //cols.ToList().ForEach(s =>
            //{
            //    ws.Cells[1, cols.ToList().IndexOf(s) + 1] = s;
            //});
            cExcel.Range rang = ws.Range[ws.Cells[1,1], ws.Cells[2,cols.Count()]];
            rang.Value = cols;
        }

        public static void AddColumnsForExcel(this List<string> cols)
        {
            cols.ForEach(s =>
            {
                ws.Cells[1, cols.IndexOf(s) + 1] = s;
            });
        }

        public static void AddRowToExcel(string[] col)
        {
            cExcel.Range rng = ws.UsedRange;
            int index = rng.EntireRow.Count + 1;
            var startcell = ws.Cells[index, 1];
            var endcell = ws.Cells[index + 1, col.Count()];
            cExcel.Range rang = ws.Range[startcell, endcell];
            rang.Value = col;
        }

        public static void AddMultiRowToExcel(this List<string[]> row)
        {
            cExcel.Range rng = ws.UsedRange;
            int index = rng.EntireRow.Count + 1;
            for (int i = 0; i < row.Count(); i++)
            {
                for (int j = 0; j < row[i].Count(); j++)
                    ws.Cells[index + i, j + 1] = row[i][j];
            }
        }

        public static void DatatableToExcel(this DataTable dt)
        {
            //cExcel.Range rng = ws.UsedRange;
            //int index = rng.EntireRow.Count + 1;
            List<string> query = (from col in dt.Columns.Cast<DataColumn>()
                                  select col.ColumnName).ToList();
            query.AddColumnsForExcel();
            ////for (int i = 0; i < dt.Rows.Count; i++)
            ////{
            ////    //for (int j = 0; j < dt.Columns.Count; j++)
            ////    //{
            ////    //    ws.Cells[index + i, j + 1] = dt.Rows[i][j];
            ////    //}
            ////}
            foreach (DataRow dr in dt.Rows)
            {
                AddRowToExcel(dr.ItemArray.Select(s => s.ToString()).ToArray());
            }
        }

        public static void ImportExcelToTable(this DataTable table, bool header)
        {
            cExcel.Range rng = ws.UsedRange;
            int rowindex = rng.EntireRow.Count;
            int colindex = rng.EntireColumn.Count;
            int startRow = 1;
            for (int col = 1; col <= colindex; col++)
            {
                table.Columns.Add(ws.Cells[1, col]);
            }
            if (header) startRow = 2;
            for (int row = startRow; row <= rowindex; row++)
            {
                DataRow dr = table.NewRow();
                for (int col = 1; col <= colindex; col++)
                {
                    dr[col] = ws.Cells[row, col];
                }
                table.Rows.Add(dr);
            }
        }

        public static void SaveAndExit(this string filename, bool show)
        {
            if (File.Exists(filename))
                app.DisplayAlerts = false;
            wb.SaveAs(filename, cExcel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, false, false, cExcel.XlSaveAsAccessMode.xlNoChange, cExcel.XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
            app.Visible = show;
            if (!show)
            {
                wb.Close();
                app.Quit();
            }
        }
    }
}
