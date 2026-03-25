using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Policy;
using System.Windows.Forms;
using test.DataMode;
using ReaLTaiizor.Forms;

namespace test.Frm
{
    public partial class FrmMain : MaterialForm
    {
        public FrmMain()
        {
            InitializeComponent();

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (GlobalMode.ClassFrm.frmHome?.IsDisposed != false)
            {
                GlobalMode.ClassFrm.frmHome = new FrmHome();
            }
            GlobalMode.ShowFormInContainer(GlobalMode.ClassFrm.frmMain.panel1_home, GlobalMode.ClassFrm.frmHome, true);
            showSystemMsg.Enabled = true;
            showSystemMsg.Interval = 500;
            showSystemMsg.Start();
        }
        public virtual void btn_RunEvent(object sender, EventArgs e)
        {
            var Controltype = ((Control)sender).Name.Replace("btn_", "");
            switch (Controltype)
            {
                case "home":
                    if (GlobalMode.ClassFrm.frmHome?.IsDisposed != false)
                    {
                        GlobalMode.ClassFrm.frmHome = new FrmHome();
                    }
                    GlobalMode.ShowFormInContainer(GlobalMode.ClassFrm.frmMain.panel1_home, GlobalMode.ClassFrm.frmHome, true);
                    break;
                case "Initialization":

                    //btn_Initialization.Enabled = false;
                    break;
                case "setting":
                    if (GlobalMode.ClassFrm.frmSetting?.IsDisposed != false)
                    {
                        GlobalMode.ClassFrm.frmSetting = new FrmSetting();
                    }
                    GlobalMode.ShowFormInContainer(GlobalMode.ClassFrm.frmMain.panel1_home, GlobalMode.ClassFrm.frmSetting, true);
                    break;
                case "close":
                    GlobalMode.CloseAllChiIdForms(GlobalMode.ClassFrm.frmMain.panel1_home, GlobalMode.ClassFrm.frmMain);
                    Application.Exit();
                    break;
            }
        }

        public void SystemMessage()
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(() => SystemMessage()));
                return;
            }

            var msg = GlobalMode.GetSystemMsg();

            foreach (var item in msg)
            {
                label1.Text = item.BuildNo;
                label2.Text = item.ProductName;
                label3.Text = item.UsreName;
                label4.Text = item.DateTime.ToString();
            }

        }
        private void showSystemMsg_Tick(object sender, EventArgs e)
        {
            SystemMessage();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalMode.CloseAllChiIdForms(GlobalMode.ClassFrm.frmMain.panel1_home, GlobalMode.ClassFrm.frmMain);
            Application.Exit();
        }
    }
}
