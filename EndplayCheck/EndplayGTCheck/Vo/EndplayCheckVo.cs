using System;
using System.Data;

namespace EndplayGTCheck.Vo
{
    public class EndplayCheckVo
    {
        public struct Product
        {
            public string Model { get; set; }
            public string Site { get; set; }
            public string Factory { get; set; }
            public string Line { get; set; }
            public string Process { get; set; }
            public string Lot { get; set; }

            private string Serno { get; set; }
            private string Inspect { get; set; }
            private string InspectDate { get; set; }
            private string InspectTime { get; set; }
            private string InspectData { get; set; }
            private string Judge { get; set; }
            private string Status { get; set; }
            private string Remark { get; set; }

            public void InputData (string serno, string data, string judge)
            {
                Serno = serno;
                InspectData = data;
                Judge = judge;
                Inspect = "Inspect";
                InspectDate = DateTime.Now.ToString("yyyy-MM-dd");
                InspectTime = DateTime.Now.ToString("HH:mm:ss");
            }

            public DataTable GetTable()
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Serno");
                dt.Columns.Add("Lot");
                dt.Columns.Add("Model");
                dt.Columns.Add("Site");
                dt.Columns.Add("Factory");
                dt.Columns.Add("Line");
                dt.Columns.Add("Process");
                dt.Columns.Add("Inspect");
                dt.Columns.Add("Date");
                dt.Columns.Add("Time");
                dt.Columns.Add("Inspectdata");
                dt.Columns.Add("Judge");
                dt.Columns.Add("Status");
                dt.Columns.Add("Remark");
                return dt;
            }

            public void AddRow(ref DataTable dt)
            {
                dt.Rows.Add(Serno, Lot, Model, Site, Factory, Line, Process, Inspect, InspectDate, InspectTime, InspectData, Judge, Status, Remark);
            }
        }

        public string password { get; set; }
        public string SetFile { get; set; }
        public string PathFolder { get; set; }
        public string PathFile { get; set; }
        public string SendToFolder { get; set; }
        public string SendToFile { get; set; }
    }
}
