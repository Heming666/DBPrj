
namespace MyPrj.FormArea.IndexDataSet
{
    partial class IndexDataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCheckData = new System.Windows.Forms.Button();
            this.btn_ReadData = new System.Windows.Forms.Button();
            this.pnl_DBInfo = new System.Windows.Forms.Panel();
            this.Btn_Begin = new System.Windows.Forms.Button();
            this.txt_ConStr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_read = new System.Windows.Forms.Button();
            this.pnl_DBInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCheckData
            // 
            this.BtnCheckData.Location = new System.Drawing.Point(84, 23);
            this.BtnCheckData.Name = "BtnCheckData";
            this.BtnCheckData.Size = new System.Drawing.Size(73, 43);
            this.BtnCheckData.TabIndex = 0;
            this.BtnCheckData.Text = "检验数据模板是否存在";
            this.BtnCheckData.UseVisualStyleBackColor = true;
            this.BtnCheckData.Click += new System.EventHandler(this.BtnCheckData_Click);
            // 
            // btn_ReadData
            // 
            this.btn_ReadData.Location = new System.Drawing.Point(340, 23);
            this.btn_ReadData.Name = "btn_ReadData";
            this.btn_ReadData.Size = new System.Drawing.Size(73, 43);
            this.btn_ReadData.TabIndex = 0;
            this.btn_ReadData.Text = "重新读取并存储数据";
            this.btn_ReadData.UseVisualStyleBackColor = true;
            this.btn_ReadData.Click += new System.EventHandler(this.btn_ReadData_Click);
            // 
            // pnl_DBInfo
            // 
            this.pnl_DBInfo.Controls.Add(this.btn_read);
            this.pnl_DBInfo.Controls.Add(this.label1);
            this.pnl_DBInfo.Controls.Add(this.txt_ConStr);
            this.pnl_DBInfo.Location = new System.Drawing.Point(64, 105);
            this.pnl_DBInfo.Name = "pnl_DBInfo";
            this.pnl_DBInfo.Size = new System.Drawing.Size(670, 282);
            this.pnl_DBInfo.TabIndex = 1;
            this.pnl_DBInfo.Visible = false;
            // 
            // Btn_Begin
            // 
            this.Btn_Begin.Location = new System.Drawing.Point(614, 23);
            this.Btn_Begin.Name = "Btn_Begin";
            this.Btn_Begin.Size = new System.Drawing.Size(73, 43);
            this.Btn_Begin.TabIndex = 0;
            this.Btn_Begin.Text = "开始初始化";
            this.Btn_Begin.UseVisualStyleBackColor = true;
            this.Btn_Begin.Click += new System.EventHandler(this.Btn_Begin_Click);
            // 
            // txt_ConStr
            // 
            this.txt_ConStr.Location = new System.Drawing.Point(51, 48);
            this.txt_ConStr.Multiline = true;
            this.txt_ConStr.Name = "txt_ConStr";
            this.txt_ConStr.Size = new System.Drawing.Size(572, 134);
            this.txt_ConStr.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "要读取数据的数据库链接字符串";
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(276, 217);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(75, 23);
            this.btn_read.TabIndex = 2;
            this.btn_read.Text = "确定并读取数据";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // IndexDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_DBInfo);
            this.Controls.Add(this.Btn_Begin);
            this.Controls.Add(this.btn_ReadData);
            this.Controls.Add(this.BtnCheckData);
            this.Name = "IndexDataForm";
            this.Text = "指标初始化";
            this.pnl_DBInfo.ResumeLayout(false);
            this.pnl_DBInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCheckData;
        private System.Windows.Forms.Button btn_ReadData;
        private System.Windows.Forms.Panel pnl_DBInfo;
        private System.Windows.Forms.Button Btn_Begin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ConStr;
        private System.Windows.Forms.Button btn_read;
    }
}