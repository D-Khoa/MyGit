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
        Char[] charList = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'V', 'U', 'W', 'X', 'Y', 'Z' };

        char loadchar;
        string loadfile = @"..\..\..\..\..\Documents\HandwrittenData.csv";

        public LoadCharCSV(char inchar)
        {
            loadchar = inchar;
        }

        public List<string> getChar()
        {
            int i = Array.FindIndex(charList, c => c.Equals(loadchar));
            List<string> listc = (from line in File.ReadLines(loadfile)
                                  where (line[0] == loadchar || line[0].ToString() == i.ToString())
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
