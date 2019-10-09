using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using WIA;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace DKMES.FormSys
{
    public partial class WebCam : Form
    {

        Device oDevice;
        string jpegGUID;
        Item oItem;
        string path { get; set; }
        public string GetSnapShotPath()
        {
            return path;
        }

        public WebCam()
        {
            InitializeComponent();
            try
            {
                //This lets the user select the correspondant device 
                oDevice = new CommonDialogClass().ShowSelectDevice(WiaDeviceType.UnspecifiedDeviceType, true, false);
                //As the image is of jpg format then you try to get the value of the representative GUID
                RegistryKey key = Registry.ClassesRoot.OpenSubKey(@"CLSID\{D2923B86-15F1-46FF-A19A-DE825F919576}\SupportedExtension\.jpg");
                jpegGUID = key.GetValue("FormatGUID").ToString();
            }
            catch (Exception caught)
            {
                //MessageBox.Show("SnapShot canceled or something wrong!!!");
                MessageBox.Show(caught.Message);
            }
        }
        //Via this method the snapshot method will be executed
        public void SnapShot()
        {
            try
            {
                oItem = oDevice.ExecuteCommand(CommandID.wiaCommandTakePicture);
                ImageFile imgFile = oItem.Transfer(jpegGUID) as WIA.ImageFile;
                SaveImageAs();
                imgFile.SaveFile(path);
                oItem = null;
            }
            catch (Exception caught)
            {
                MessageBox.Show("Put another image");
            }
        }

        //This methos lets the user set image path with a more familiar way 
        void SaveImageAs()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "(*.jpg)|*.jpg";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                path = dlg.FileName;
            }
        }

    }
}
