using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.DataMode;
using test.Frm;

namespace test
{
    internal class GlobalMode
    {
        /// <summary>
        /// Window窗体
        /// </summary>
        internal class ClassFrm
        {
            public static FrmMain frmMain;
            public static FrmLogin frmLogin;
            public static FrmHome frmHome;
            public static FrmSetting frmSetting;
        }

        public static bool ShowFormInContainer(Control containerControl, Form formToShow, bool clearContainer = true)
        {
            try
            {
                if (containerControl == null)
                    throw new ArgumentNullException(nameof(containerControl), "容器控件不能为null");
                if (formToShow == null)
                    throw new ArgumentNullException(nameof(formToShow), "要显示的窗体不能为null");

                if (clearContainer)
                    CloseAllChiIdForms(containerControl, formToShow);

                //设置窗体属性
                formToShow.TopLevel = false;
                formToShow.FormBorderStyle = FormBorderStyle.None;
                formToShow.Dock = DockStyle.Fill;
                formToShow.Show();

                GlobalMode.ClassFrm.frmMain.panel1_home.Controls.Add(formToShow);

                return true;
            }
            catch (Exception ex)
            {
                ShowMessageBox($"窗体显示失败 {ex.Message + ex.StackTrace}");
                return false;
            }
        }
        /// <summary>
        /// 关闭所有窗体
        /// </summary>
        /// <param name="container"></param>
        public static void CloseAllChiIdForms(Control container, Form formToshow)
        {
            if (container.InvokeRequired)
            {
                container.Invoke(new Action<Control, Form>(CloseAllChiIdForms), container, formToshow);
                return;
            }

            var formsToClose = container.Controls.OfType<Form>().ToList();

            foreach (var form in formsToClose)
            {
                if (formToshow != form)
                {
                    form.Close();
                }
            }
        }
        /// <summary>
        /// 从容器中移除指定窗口
        /// </summary>
        /// <param name="container"></param>
        /// <param name="form"></param>
        private static void RemoveFormFromContanier(Control container, Form form)
        {
            if (container.InvokeRequired)
            {
                container.Invoke(new Action<Control, Form>(RemoveFormFromContanier), container, form);
                return;
            }

            if (container.Controls.Contains(form))
            {
                container.Controls.Remove(form);
                form.Dispose();
            }
        }

        /// <summary>
        /// 显示弹窗
        /// </summary>
        /// <param name="Message">消息</param>
        /// <param name="IsShow">是否显示-默认显示</param>
        public static void ShowMessageBox(string Message, bool IsShow = true)
        {
            if (!IsShow)
                MessageBox.Show(Message);
        }

        /// <summary>
        /// 获取系统信息
        /// </summary>
        /// <returns></returns>
        public static List<SystemMessage> GetSystemMsg()
        {
            var SystemMsgs = new List<SystemMessage>();

            var systemMessage = new SystemMessage();

            SystemMsgs.Add(systemMessage);
            return SystemMsgs;
        }

    }
}
