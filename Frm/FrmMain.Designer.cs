namespace test.Frm
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.showSystemMsg = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Initialization = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1_home = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1_home.SuspendLayout();
            this.SuspendLayout();
            // 
            // showSystemMsg
            // 
            this.showSystemMsg.Tick += new System.EventHandler(this.showSystemMsg_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 300;
            // 
            // btn_Initialization
            // 
            this.btn_Initialization.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Initialization.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Initialization.BackgroundImage")));
            this.btn_Initialization.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Initialization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Initialization.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Initialization.Location = new System.Drawing.Point(276, 0);
            this.btn_Initialization.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Initialization.Name = "btn_Initialization";
            this.btn_Initialization.Size = new System.Drawing.Size(92, 76);
            this.btn_Initialization.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btn_Initialization, "初始化系统");
            this.btn_Initialization.UseVisualStyleBackColor = false;
            this.btn_Initialization.Click += new System.EventHandler(this.btn_RunEvent);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_home.BackgroundImage")));
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_home.Location = new System.Drawing.Point(92, 0);
            this.btn_home.Margin = new System.Windows.Forms.Padding(0);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(92, 76);
            this.btn_home.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btn_home, "主页");
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_RunEvent);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close.BackgroundImage")));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_close.Location = new System.Drawing.Point(184, 0);
            this.btn_close.Margin = new System.Windows.Forms.Padding(0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(92, 76);
            this.btn_close.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btn_close, "退出系统");
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_RunEvent);
            // 
            // btn_setting
            // 
            this.btn_setting.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_setting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_setting.BackgroundImage")));
            this.btn_setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_setting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_setting.Location = new System.Drawing.Point(0, 0);
            this.btn_setting.Margin = new System.Windows.Forms.Padding(0);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(92, 76);
            this.btn_setting.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btn_setting, "系统参数 ");
            this.btn_setting.UseVisualStyleBackColor = false;
            this.btn_setting.Click += new System.EventHandler(this.btn_RunEvent);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 851);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1282, 47);
            this.panel3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(842, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 47);
            this.label4.TabIndex = 3;
            this.label4.Text = "时间：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(575, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 47);
            this.label3.TabIndex = 2;
            this.label3.Text = "用户名：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(302, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "产品名称：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "版本号：V1.0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1282, 76);
            this.panel2.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.215606F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.216345F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.216345F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.211639F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.67323F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.46684F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Initialization, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_setting, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_close, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_home, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1282, 76);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1_home
            // 
            this.panel1_home.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1_home.Controls.Add(this.button2);
            this.panel1_home.Controls.Add(this.button1);
            this.panel1_home.Controls.Add(this.label5);
            this.panel1_home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1_home.Location = new System.Drawing.Point(3, 100);
            this.panel1_home.Name = "panel1_home";
            this.panel1_home.Size = new System.Drawing.Size(1282, 751);
            this.panel1_home.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "label5";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(430, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(281, 109);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1288, 901);
            this.Controls.Add(this.panel1_home);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1_home.ResumeLayout(false);
            this.panel1_home.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Timer showSystemMsg;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btn_Initialization;
        public System.Windows.Forms.Button btn_home;
        public System.Windows.Forms.Button btn_close;
        public System.Windows.Forms.Button btn_setting;
        public System.Windows.Forms.Panel panel1_home;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

