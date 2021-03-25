
namespace MyPrj
{
    partial class From1
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
            this.Btn_BuidIndex = new System.Windows.Forms.Button();
            this.txt_Msg = new System.Windows.Forms.TextBox();
            this.btn_CheckDB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_checkDB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_BuidIndex
            // 
            this.Btn_BuidIndex.AccessibleDescription = "11111";
            this.Btn_BuidIndex.Location = new System.Drawing.Point(27, 38);
            this.Btn_BuidIndex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_BuidIndex.Name = "Btn_BuidIndex";
            this.Btn_BuidIndex.Size = new System.Drawing.Size(64, 25);
            this.Btn_BuidIndex.TabIndex = 5;
            this.Btn_BuidIndex.Text = "指标";
            this.Btn_BuidIndex.UseVisualStyleBackColor = true;
            this.Btn_BuidIndex.Click += new System.EventHandler(this.Btn_BuidIndex_Click);
            // 
            // txt_Msg
            // 
            this.txt_Msg.Location = new System.Drawing.Point(14, 86);
            this.txt_Msg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Msg.Multiline = true;
            this.txt_Msg.Name = "txt_Msg";
            this.txt_Msg.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_Msg.Size = new System.Drawing.Size(819, 309);
            this.txt_Msg.TabIndex = 6;
            // 
            // btn_CheckDB
            // 
            this.btn_CheckDB.Location = new System.Drawing.Point(14, 19);
            this.btn_CheckDB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_CheckDB.Name = "btn_CheckDB";
            this.btn_CheckDB.Size = new System.Drawing.Size(93, 35);
            this.btn_CheckDB.TabIndex = 7;
            this.btn_CheckDB.Text = "选择数据库";
            this.btn_CheckDB.UseVisualStyleBackColor = true;
            this.btn_CheckDB.Click += new System.EventHandler(this.btn_CheckDB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 11F);
            this.label1.Location = new System.Drawing.Point(112, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "链接字符串";
            // 
            // txt_checkDB
            // 
            this.txt_checkDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_checkDB.Location = new System.Drawing.Point(208, 28);
            this.txt_checkDB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_checkDB.Name = "txt_checkDB";
            this.txt_checkDB.ReadOnly = true;
            this.txt_checkDB.Size = new System.Drawing.Size(625, 23);
            this.txt_checkDB.TabIndex = 9;
            this.txt_checkDB.Text = "无";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_CheckDB);
            this.groupBox1.Controls.Add(this.txt_checkDB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(846, 70);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据库信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_BuidIndex);
            this.groupBox2.Controls.Add(this.txt_Msg);
            this.groupBox2.Location = new System.Drawing.Point(22, 106);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(846, 408);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "功能区";
            // 
            // From1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 523);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(100, 200);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "From1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "初始化数据";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_BuidIndex;
        private System.Windows.Forms.TextBox txt_Msg;
        private System.Windows.Forms.Button btn_CheckDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_checkDB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

