﻿
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
            this.SuspendLayout();
            // 
            // BtnCheckData
            // 
            this.BtnCheckData.Location = new System.Drawing.Point(13, 13);
            this.BtnCheckData.Name = "BtnCheckData";
            this.BtnCheckData.Size = new System.Drawing.Size(73, 43);
            this.BtnCheckData.TabIndex = 0;
            this.BtnCheckData.Text = "检验数据模板是否存在";
            this.BtnCheckData.UseVisualStyleBackColor = true;
            this.BtnCheckData.Click += new System.EventHandler(this.BtnCheckData_Click);
            // 
            // IndexDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCheckData);
            this.Name = "IndexDataForm";
            this.Text = "指标初始化";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCheckData;
    }
}