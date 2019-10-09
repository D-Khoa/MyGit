using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;

namespace DKMES.FormSys
{
    public partial class CameraTestForm : Form
    {
        public CameraTestForm()
        {
            InitializeComponent();
        }

        private void ListDevice()
        {
            var devicemng = new DeviceManager();
            for(int i = 1; i < devicemng.DeviceInfos.Count; i++)
            {
                //if(devicemng.DeviceInfos[i].Type != WiaDeviceType.VideoDeviceType)
                //{
                //    continue;
                //}
                cmbListDevice.Items.Add(devicemng.DeviceInfos[i].Properties["Name"].get_Value());
            }
        }

        private void CameraTestForm_Load(object sender, EventArgs e)
        {
            ListDevice();
        }
    }
}
