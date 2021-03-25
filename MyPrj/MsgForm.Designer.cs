
namespace MyPrj
{
    partial class MsgForm
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
            this.txt_Msg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Msg
            // 
            this.txt_Msg.Location = new System.Drawing.Point(1, -2);
            this.txt_Msg.Multiline = true;
            this.txt_Msg.Name = "txt_Msg";
            this.txt_Msg.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_Msg.Size = new System.Drawing.Size(357, 549);
            this.txt_Msg.TabIndex = 0;
            // 
            // MsgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 548);
            this.Controls.Add(this.txt_Msg);
            this.Location = new System.Drawing.Point(1000, 200);
            this.Name = "MsgForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "消息窗口";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Msg;
    }
}