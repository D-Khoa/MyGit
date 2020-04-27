using System;
using System.Collections.Generic;
using System.IO;

namespace PC_QRCodeSystem.Model
{
    public class SettingItem
    {
        #region ALL FIELDS
        public static string outputFolder { get; set; }
        public static string premacFile { get; set; }
        public static string printerSName { get; set; }
        public string outputTempFolder { get; set; }
        public string premacFolder { get; set; }
        public string printerName { get; set; }
        public string settingFolder;
        public string settingPath;
        public SettingItem()
        {
            settingFolder = @"C:\Production Tracebility System";
            settingPath = settingFolder + @"\setting.ini";
            if (!Directory.Exists(settingFolder)) Directory.CreateDirectory(settingFolder);
            DefaultSetting();
        }
        #endregion

        #region QUERY
        /// <summary>
        /// Reset to default setting
        /// </summary>
        public void DefaultSetting()
        {
            premacFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\CPFXE049.txt";
            outputTempFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            printerName = "LUKHAN Label Printer";
            premacFile = premacFolder;
            printerSName = printerName;
        }

        /// <summary>
        /// Save setting into file
        /// </summary>
        public void SaveSetting()
        {
            //Check if file is not exist then create file
            if (!File.Exists(settingPath))
            {
                FileStream myFile = File.Create(settingPath);
                myFile.Close();
            }
            //Get all setting and write to file
            List<string> listSetting = new List<string>();
            listSetting.Add(nameof(outputTempFolder) + "=" + outputTempFolder);
            listSetting.Add(nameof(premacFolder) + "=" + premacFolder);
            listSetting.Add(nameof(printerName) + "=" + printerName);
            File.WriteAllLines(settingPath, listSetting);
            outputFolder = outputTempFolder;
            printerSName = printerName;
            premacFile = premacFolder;
        }

        /// <summary>
        /// Load setting from file
        /// </summary>
        public void LoadSetting()
        {
            //If file is not exist then use default setting
            if (!File.Exists(settingPath)) return;
            //Get all fields of setting file
            var propertyValue = GetType().GetProperties();
            //Read line in file
            foreach (string line in File.ReadLines(settingPath))
            {
                //If line start with setting field name then get value from line to setting field
                for (int i = 0; i < propertyValue.Length; i++)
                    if (line.StartsWith(propertyValue[i].Name)) propertyValue[i].SetValue(this, line.Split('=')[1]);
            }
            outputFolder = outputTempFolder;
            printerSName = printerName;
            premacFile = premacFolder;
        }
        #endregion
    }
}
