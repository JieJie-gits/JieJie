using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.DataMode;

namespace test.DataMode
{
    public class Product
    {
        /// <summary>
        /// 产品条码
        /// </summary>
        public string Barcode { get; set; }
        /// <summary>
        /// 产品名称
        /// </summary>
        public string  ProductName { get; set; }
        /// <summary>
        /// 扫描时间
        /// </summary>
        public DateTime ScanTime { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// 批次号
        /// </summary>
        public string BatchNumber { get; set; }
        /// <summary>
        /// 操作员
        /// </summary>
        public string  Operator { get; set; }

        public Product()
        {
            ScanTime = DateTime.Now;
        }
    }

}

