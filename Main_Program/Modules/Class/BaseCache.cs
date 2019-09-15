using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Modules
{
    public class BaseCache
    {
        public static string fGraphics = "Graphics";
        public static string fAnimations = @"Graphics\Animations";
        public static string fBackground = @"Graphics\Background";
        public static string fCharacter = @"Graphics\Character";
        public static string fWindows = @"Graphics\Windows";

        public static string fSound = "Sound";
        public static string fBGM = @"Sound\BGM";
        public static string fMusic = @"Sound\Music";

        public static string fSetting = "Setting";
        public static string txtSetting = @"Setting\setting.txt";

        public static string fSystem = "System";


        public static List<string> DefaultSetting()
        {
            List<string> df = new List<string>();
            df.Add("Graphic = 640x480");
            df.Add("Display_Mode = Window");
            df.Add("Music = 50");
            df.Add("Sound = 50");
            return df;
        }

        public static void CreateFolder(string path)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }

        public static void CreateFile(string path, string data)
        {
            File.WriteAllText(path, data);
        }

        public static void CreateFile(string path, List<string> data)
        {
            File.WriteAllLines(path, data);
        }

        public static void UpdateFile(string path, string data)
        {
            if (File.Exists(path))
            {
                using (StreamWriter wr = new StreamWriter(path))
                {
                    wr.WriteLine(data);
                    wr.Close();
                }
            }
            else
                CreateFile(path, DefaultSetting());
        }

        public static List<string> ReadAllLine(string path)
        {
            List<string> lines = new List<string>();
            if(File.Exists(path))
            {
                using (StreamReader rd = new StreamReader(path))
                {
                    while(!rd.EndOfStream)
                        lines.Add(rd.ReadLine());
                    rd.Close();                                                                  
                }
            }
            else
                lines = DefaultSetting();
            return lines;
        }
    }
}
