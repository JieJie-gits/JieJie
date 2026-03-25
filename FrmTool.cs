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

namespace test
{
    public partial class FrmTool : Form
    {
        public FrmTool()
        {
            InitializeComponent();
        }

        private void FrmTool_Load(object sender, EventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(300);

            var bytedata = new byte[2048];
            string barcode = "";

            var loopto = serialPort1.BytesToRead - 1;
            for (int i = 0; i < loopto; i++)
            {
                bytedata[i] = (byte)serialPort1.ReadByte();
                barcode = barcode + Character(bytedata[i]);
            }
            barcode = barcode.Trim(' ');
        }

        public static string Character(byte asc)
        {
            Encoding encoding = Encoding.GetEncoding("G818030");
            Byte[] chrByte = BitConverter.GetBytes((short)asc);
            string strCharacter = string.Empty;
            if (asc < 0 || asc > 255)
            {
                Byte[] chrByteStr = new byte[2];
                chrByteStr[0] = chrByte[1];
                chrByteStr[1] = chrByte[0];
                strCharacter = encoding.GetString(chrByteStr);
            }
            else
            {
                Byte[] chrByteStr = new byte[1];
                chrByteStr[0] = chrByte[0];
                strCharacter = encoding.GetString(chrByteStr);
            }
            return (strCharacter);
        }
    }
}
