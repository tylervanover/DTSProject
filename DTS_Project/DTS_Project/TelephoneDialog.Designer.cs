﻿namespace DTS_Project
{
    partial class TelephoneDialog
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
            this.tbAreaCode = new System.Windows.Forms.TextBox();
            this.tbExchange = new System.Windows.Forms.TextBox();
            this.tbSubscriber = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbAreaCode
            // 
            this.tbAreaCode.Location = new System.Drawing.Point(12, 21);
            this.tbAreaCode.Name = "tbAreaCode";
            this.tbAreaCode.Size = new System.Drawing.Size(44, 20);
            this.tbAreaCode.TabIndex = 0;
            // 
            // tbExchange
            // 
            this.tbExchange.Location = new System.Drawing.Point(62, 21);
            this.tbExchange.Name = "tbExchange";
            this.tbExchange.Size = new System.Drawing.Size(46, 20);
            this.tbExchange.TabIndex = 1;
            // 
            // tbSubscriber
            // 
            this.tbSubscriber.Location = new System.Drawing.Point(114, 21);
            this.tbSubscriber.Name = "tbSubscriber";
            this.tbSubscriber.Size = new System.Drawing.Size(70, 20);
            this.tbSubscriber.TabIndex = 2;
            // 
            // btnApply
            // 
            this.btnApply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(23, 65);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(109, 65);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // TelephoneDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 115);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.tbSubscriber);
            this.Controls.Add(this.tbExchange);
            this.Controls.Add(this.tbAreaCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TelephoneDialog";
            this.Text = "TelephoneDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAreaCode;
        private System.Windows.Forms.TextBox tbExchange;
        private System.Windows.Forms.TextBox tbSubscriber;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
    }
}