using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FirstWindowService
{
    public partial class Service1 : ServiceBase
    {
        private System.Timers.Timer timer = null;

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 60000;
            timer.Elapsed += Timer_Elapsed;
            timer.Enabled = true;
            Utilities.WriteLogError("Test for the 1st window service!!");
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Utilities.WriteLogError("Timer tick for doing something!");
        }

        protected override void OnStop()
        {
            timer.Enabled = false;
            Utilities.WriteLogError("1st window service has been stop!!");
        }
    }
}
