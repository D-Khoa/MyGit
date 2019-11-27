using System;
using System.IO;
using System.Linq;
using System.Data;
using System.Collections.Generic;
using cExcel = Microsoft.Office.Interop.Excel;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Common
{
    public class ExcelClass2019
    {
        public string filename { get; set; }
        cExcel.Application app;
        cExcel.Workbook wb;
        cExcel.Worksheet ws;

        public ExcelClass2019(string inputfilename)
        {
            filename = inputfilename;
        }

        public void CreateWorkBook()
        {
            app = new cExcel.Application();
            wb = app.Workbooks.Add();
            ws = app.ActiveSheet;
        }

        public bool OpenWorkBook(string fileopen)
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
                throw new Exception("File not exist!");
            }
        }

        public void AddColumns(string[] cols)
        {
            //for (int i = 0; i < cols.Count(); i++)
            //{
            //    ws.Cells[1, i] = cols[i];
            //}
            cols.ToList().ForEach(s =>
            {
                ws.Cells[1, cols.ToList().IndexOf(s) + 1] = s;
            });
        }

        public void AddColumns(List<string> cols)
        {
            cols.ForEach(s =>
            {
                ws.Cells[1, cols.IndexOf(s) + 1] = s;
            });
        }

        public void AddRow(string[] row)
        {
            cExcel.Range rng = ws.UsedRange;
            int index = rng.EntireRow.Count + 1;
            for (int i = 0; i < row.Count(); i++)
            {
                ws.Cells[index, i + 1] = row[i];
            }
        }

        public void AddMultiRow(List<string[]> row)
        {
            cExcel.Range rng = ws.UsedRange;
            int index = rng.EntireRow.Count + 1;
            for (int i = 0; i < row.Count(); i++)
            {
                for (int j = 0; j < row[i].Count(); j++)
                    ws.Cells[index + i, j + 1] = row[i][j];
            }
        }

        public void AddDatatable(DataTable dt)
        {
            cExcel.Range rng = ws.UsedRange;
            int index = rng.EntireRow.Count + 1;
            List<string> query = (from col in dt.Columns.Cast<DataColumn>()
                                  select col.ColumnName).ToList();
            AddColumns(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    ws.Cells[index + i, j + 1] = dt.Rows[i][j];
                }
            }
        }

        public void SaveAndExit()
        {
            //app.Visible = true;
            if (File.Exists(filename))
                app.DisplayAlerts = false;
            wb.SaveAs(filename, cExcel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, false, false, cExcel.XlSaveAsAccessMode.xlNoChange, cExcel.XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
            wb.Close();
            app.Quit();
        }
    }
}
