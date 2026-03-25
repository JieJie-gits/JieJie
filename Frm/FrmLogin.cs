using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test.Frm
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private async void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                await Task.Run(() => ProgressLogin());
                timer1.Enabled = true;
                timer1.Start();
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        public async Task ShowProgress(string str, int iprogress)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(async () => await ShowProgress(str, iprogress)));
                return;
            }

            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar1.IsAccessible = true;
            lbl_message.Text = str;
            progressBar1.Value = iprogress;
        }

        public async void ProgressLogin()
        {
            await ShowProgress("系统加载中，10%", 10);
            Thread.Sleep(150);
            await ShowProgress("系统加载中，30%", 30);
            Thread.Sleep(150);
            await ShowProgress("系统加载中，50%", 50);
            Thread.Sleep(150);
            await ShowProgress("系统加载中，70%", 70);
            Thread.Sleep(150);
            await ShowProgress("系统加载中，90%", 90);
            Thread.Sleep(150);
            await ShowProgress("系统加载中，100%", 100);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                if (GlobalMode.ClassFrm.frmMain == null)
                    GlobalMode.ClassFrm.frmMain = new FrmMain();
                GlobalMode.ClassFrm.frmMain.Show();
                this.Hide();
            }
        }
    }
}
