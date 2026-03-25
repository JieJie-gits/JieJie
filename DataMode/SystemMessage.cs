using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.DataMode
{
    public class SystemMessage
    {
        /// <summary>
        /// 系统当前时间
        /// </summary>
        public DateTime DateTime { get => DateTime.Now; }
        /// <summary>
        /// 当前登录用户名
        /// </summary>
        public string UsreName { get; set; }
        /// <summary>
        /// 产品名称
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// 版本号
        /// </summary>
        public string BuildNo { get; set; }

        public SystemMessage()
        {
            UsreName = "用户名：" + "Admin";
            ProductName = "产品名称：" + "";
            BuildNo = "版本号：V1.0";
        }
        public SystemMessage(string usrename, string productname, string buildno)
        {
            UsreName = usrename;
            ProductName = productname;
            BuildNo = buildno;
        }

    }
}
