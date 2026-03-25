using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Forms;

namespace test.Frm
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        #region 控件事件

        private void scannerSerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            System.Threading.Thread.Sleep(300);

            int i;
            var byteData = new byte[2049];
            string BarCode = "";

            var loopTo = scannerSerialPort.BytesToRead - 1;
            for (i = 0; i <= loopTo; i++)
            {
                byteData[i] = (byte)scannerSerialPort.ReadByte();
                BarCode = BarCode + Character(byteData[i]);
            }
            BarCode = BarCode.Trim(' ');


        }



        #endregion

        #region 方法
        /// <summary>
        /// 传入单个字符的ASCII码，得到ASCII码对应的字符（含双字节）
        /// </summary>
        /// <param name="asc">-13120</param>
        /// <returns></returns>
        private string Character(int asc)
        {
            Encoding asciiEncoding = Encoding.GetEncoding("GB18030");
            Byte[] chrByte = BitConverter.GetBytes((short)asc);
            string strCharacter = string.Empty;
            if (asc < 0 || asc > 255)
            {
                Byte[] chrByteStr = new byte[2];
                chrByteStr[0] = chrByte[1];
                chrByteStr[1] = chrByte[0];
                strCharacter = asciiEncoding.GetString(chrByteStr);
            }
            else
            {
                Byte[] chrByteStr = new byte[1];
                chrByteStr[0] = chrByte[0];
                strCharacter = asciiEncoding.GetString(chrByteStr);
            }
            return (strCharacter);
        }
        #endregion

    }
}
