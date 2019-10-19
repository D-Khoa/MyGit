using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKMES.Common
{
    public class LoadCharCSV
    {
        char loadchar;
        string loadfile = @"D:\GIT\DangKhoa\Documents\HandwrittenData.csv";

        public LoadCharCSV(char inchar)
        {
            loadchar = inchar;
        }

        public List<string> getChar(char inchar)
        {
            List<string> listc = (from line in File.ReadLines(loadfile)
                                  where line[0] == inchar
                                  select line.Substring(2)).ToList();
            return listc;
        }

        public void saveChar(List<string> listChar)
        {
            string filesave = @"..\..\..\HandwrittenData_" + loadchar + ".csv";
            File.WriteAllLines(filesave, listChar);
        }
    }
}
