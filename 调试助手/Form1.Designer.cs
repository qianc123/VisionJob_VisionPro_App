﻿namespace 代码植入
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txb_Code = new System.Windows.Forms.TextBox();
            this.txb_dllPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ViewPath = new System.Windows.Forms.Button();
            this.txb_ErrorInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(598, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "更新调试器";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txb_Code
            // 
            this.txb_Code.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_Code.ForeColor = System.Drawing.Color.SeaGreen;
            this.txb_Code.Location = new System.Drawing.Point(12, 86);
            this.txb_Code.Multiline = true;
            this.txb_Code.Name = "txb_Code";
            this.txb_Code.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txb_Code.Size = new System.Drawing.Size(688, 297);
            this.txb_Code.TabIndex = 1;
            this.txb_Code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_Code_KeyDown);
            // 
            // txb_dllPath
            // 
            this.txb_dllPath.Location = new System.Drawing.Point(105, 27);
            this.txb_dllPath.Name = "txb_dllPath";
            this.txb_dllPath.Size = new System.Drawing.Size(289, 21);
            this.txb_dllPath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "安装文件路径";
            // 
            // btn_ViewPath
            // 
            this.btn_ViewPath.Location = new System.Drawing.Point(411, 23);
            this.btn_ViewPath.Name = "btn_ViewPath";
            this.btn_ViewPath.Size = new System.Drawing.Size(43, 28);
            this.btn_ViewPath.TabIndex = 0;
            this.btn_ViewPath.Text = "...";
            this.btn_ViewPath.UseVisualStyleBackColor = true;
            this.btn_ViewPath.Click += new System.EventHandler(this.btn_ViewPath_Click);
            // 
            // txb_ErrorInfo
            // 
            this.txb_ErrorInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_ErrorInfo.ForeColor = System.Drawing.Color.Crimson;
            this.txb_ErrorInfo.Location = new System.Drawing.Point(12, 408);
            this.txb_ErrorInfo.Multiline = true;
            this.txb_ErrorInfo.Name = "txb_ErrorInfo";
            this.txb_ErrorInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txb_ErrorInfo.Size = new System.Drawing.Size(688, 107);
            this.txb_ErrorInfo.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 527);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_dllPath);
            this.Controls.Add(this.txb_ErrorInfo);
            this.Controls.Add(this.txb_Code);
            this.Controls.Add(this.btn_ViewPath);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txb_Code;
        private System.Windows.Forms.TextBox txb_dllPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ViewPath;
        private System.Windows.Forms.TextBox txb_ErrorInfo;
    }
}

