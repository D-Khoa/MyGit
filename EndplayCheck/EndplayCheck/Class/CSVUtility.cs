﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.IO;

namespace EndplayCheck
{
    public static class CSVUtility
    {
        public static void ToCSV(this DataTable dt, string path)
        {
            StreamWriter sw = new StreamWriter(path, false);
            for(int i = 0; i < dt.Columns.Count; i++)
            {
                sw.Write(dt.Columns[i]);
                if(i < dt.Columns.Count - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);
            foreach( DataRow dr in dt.Rows)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    if(!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            sw.Write(value);
                        }
                        else
                        {
                            sw.Write(dr[i].ToString());
                        }
                    }
                    if (i < dt.Columns.Count - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }

        public static void ReadCSVtoList(this string path, ref List<string> itemlist)
        {
            StreamReader rd = new StreamReader(path, false);
            while(!rd.EndOfStream)
            {
                var line = rd.ReadLine();
                var value = line.Split(',');
                itemlist.Add(value[0]);
            }
            rd.Close();
        }

        public static void ReadCSVtoString(this string path, ref string itemlist, ref int numline)
        {
            StreamReader rd = new StreamReader(path, false);
            int i = 0;
            while (!rd.EndOfStream)
            {
                var line = rd.ReadLine();
                itemlist += "'" + line + "',";
                i++;
            }
            numline = i;
            rd.Close();
        }
    }
}
