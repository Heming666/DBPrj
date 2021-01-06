
namespace MyPrj
{
    partial class DataBaseForm
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
            this.lbl_Schema = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Schema = new System.Windows.Forms.TextBox();
            this.txt_Pwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_userId = new System.Windows.Forms.TextBox();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Test = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_DBName = new System.Windows.Forms.Label();
            this.cbx_Db = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Schema
            // 
            this.lbl_Schema.AutoSize = true;
            this.lbl_Schema.Location = new System.Drawing.Point(266, 232);
            this.lbl_Schema.Name = "lbl_Schema";
            this.lbl_Schema.Size = new System.Drawing.Size(67, 15);
            this.lbl_Schema.TabIndex = 12;
            this.lbl_Schema.Text = "服务名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "密码";
            // 
            // txt_Schema
            // 
            this.txt_Schema.Location = new System.Drawing.Point(339, 227);
            this.txt_Schema.Name = "txt_Schema";
            this.txt_Schema.Size = new System.Drawing.Size(178, 25);
            this.txt_Schema.TabIndex = 5;
            this.txt_Schema.Text = "ORCL";
            // 
            // txt_Pwd
            // 
            this.txt_Pwd.Location = new System.Drawing.Point(339, 184);
            this.txt_Pwd.Name = "txt_Pwd";
            this.txt_Pwd.Size = new System.Drawing.Size(178, 25);
            this.txt_Pwd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "用户名";
            // 
            // txt_userId
            // 
            this.txt_userId.Location = new System.Drawing.Point(339, 142);
            this.txt_userId.Name = "txt_userId";
            this.txt_userId.Size = new System.Drawing.Size(178, 25);
            this.txt_userId.TabIndex = 3;
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(339, 68);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(178, 25);
            this.txt_IP.TabIndex = 1;
            this.txt_IP.Text = "localhost";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(288, 71);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(23, 15);
            this.lblIP.TabIndex = 7;
            this.lblIP.Text = "IP";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mysql"});
            this.comboBox1.Location = new System.Drawing.Point(339, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "数据库";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "端口";
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(339, 106);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(178, 25);
            this.txt_Port.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(339, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "*Oralce数据库必填服务名";
            // 
            // btn_Test
            // 
            this.btn_Test.Location = new System.Drawing.Point(308, 371);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(226, 31);
            this.btn_Test.TabIndex = 7;
            this.btn_Test.Text = "测试并选择数据库";
            this.btn_Test.UseVisualStyleBackColor = true;
            this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "确定并回到功能选择页面";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_DBName
            // 
            this.txt_DBName.AutoSize = true;
            this.txt_DBName.Location = new System.Drawing.Point(278, 284);
            this.txt_DBName.Name = "txt_DBName";
            this.txt_DBName.Size = new System.Drawing.Size(52, 15);
            this.txt_DBName.TabIndex = 20;
            this.txt_DBName.Text = "数据库";
            // 
            // cbx_Db
            // 
            this.cbx_Db.FormattingEnabled = true;
            this.cbx_Db.Location = new System.Drawing.Point(339, 278);
            this.cbx_Db.Name = "cbx_Db";
            this.cbx_Db.Size = new System.Drawing.Size(178, 23);
            this.cbx_Db.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(281, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "*MySql数据库必须选择要操作的数据库";
            // 
            // DataBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.ControlBox = false;
            this.Controls.Add(this.cbx_Db);
            this.Controls.Add(this.txt_DBName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Test);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Schema);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Schema);
            this.Controls.Add(this.txt_Pwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_userId);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.txt_IP);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "DataBaseForm";
            this.Text = "DataBaseForm";
            this.Load += new System.EventHandler(this.DataBaseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Schema;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Schema;
        private System.Windows.Forms.TextBox txt_Pwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_userId;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Test;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txt_DBName;
        private System.Windows.Forms.ComboBox cbx_Db;
        private System.Windows.Forms.Label label6;
    }
}