using System;
using System.IO;
using System.Linq;
using System.Data;
using System.Collections.Generic;
using cExcel = Microsoft.Office.Interop.Excel;

namespace ShippingNSTVTool
{
    public class ExcelClass
    {
        public string filename { get; set; }
        cExcel.Application app;
        cExcel.Workbook wb;
        cExcel.Worksheet ws;

        public ExcelClass(string inputfilename)
        {
            filename = inputfilename;
        }

        public void CreateWorkBook()
        {
            app = new cExcel.Application();
            wb = app.Workbooks.Add();
            ws = app.ActiveSheet;
        }

        public void OpenWorkBook(string fileopen)
        {
            if (File.Exists(fileopen))
            {
                app = new cExcel.Application();
                wb = app.Workbooks.Open(fileopen);
                ws = app.ActiveSheet;
            }
            else
                throw new Exception("File not exist!");
        }

        public void AddColumns(string[] cols)
        {
            for (int i = 0; i < cols.Count(); i++)
            {
                ws.Cells[1, i] = cols[i];
            }
        }

        public void AddRow(string[] row)
        {
            int index = 1;
            cExcel.Range rng = ws.UsedRange;
            index = rng.EntireRow.Count + 1;
            for (int i = 0; i < row.Count(); i++)
            {
                ws.Cells[index, i + 1] = row[i];
            }
        }

        public void AddMultiRow(List<string[]> row)
        {
            int index = 1;
            cExcel.Range rng = ws.UsedRange;
            index = rng.EntireRow.Count + 1;
            for (int i = 0; i < row.Count(); i++)
            {
                for (int j = 0; j < row[i].Count(); j++)
                    ws.Cells[index + i, j + 1] = row[i][j];
            }
        }

        public void AddDatatable(DataTable dt)
        {
            int index = 1;
            cExcel.Range rng = ws.UsedRange;
            index = rng.EntireRow.Count + 1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                    ws.Cells[index + i, j + 1] = dt.Rows[i][j];
            }
        }

        public void SaveAndExit()
        {
            //app.Visible = true;
            if (File.Exists(filename))
                wb.Save();
            else
                wb.SaveAs(filename);
            app.Quit();
        }
    }
}
