﻿namespace DumbCharlie1
{
    partial class CallerRole
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.fNameLbl = new System.Windows.Forms.Label();
            this.lNameLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.extLbl = new System.Windows.Forms.Label();
            this.roleLbl = new System.Windows.Forms.Label();
            this.othLbl = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.Button();
            this.callerGbx = new System.Windows.Forms.GroupBox();
            this.callerGbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(97, 31);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(183, 20);
            this.txtLastName.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(97, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(233, 83);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(47, 20);
            this.textBox3.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(392, 29);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(183, 20);
            this.textBox4.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(392, 55);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(183, 20);
            this.textBox5.TabIndex = 0;
            // 
            // fNameLbl
            // 
            this.fNameLbl.Location = new System.Drawing.Point(17, 33);
            this.fNameLbl.Name = "fNameLbl";
            this.fNameLbl.Size = new System.Drawing.Size(74, 15);
            this.fNameLbl.TabIndex = 1;
            this.fNameLbl.Text = "First Name";
            this.fNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lNameLbl
            // 
            this.lNameLbl.Location = new System.Drawing.Point(17, 59);
            this.lNameLbl.Name = "lNameLbl";
            this.lNameLbl.Size = new System.Drawing.Size(74, 15);
            this.lNameLbl.TabIndex = 1;
            this.lNameLbl.Text = "Last Name";
            this.lNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // phoneLbl
            // 
            this.phoneLbl.Location = new System.Drawing.Point(17, 85);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(74, 15);
            this.phoneLbl.TabIndex = 1;
            this.phoneLbl.Text = "Phone";
            this.phoneLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // extLbl
            // 
            this.extLbl.Location = new System.Drawing.Point(197, 85);
            this.extLbl.Name = "extLbl";
            this.extLbl.Size = new System.Drawing.Size(30, 15);
            this.extLbl.TabIndex = 1;
            this.extLbl.Text = "Ext.";
            this.extLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // roleLbl
            // 
            this.roleLbl.Location = new System.Drawing.Point(286, 31);
            this.roleLbl.Name = "roleLbl";
            this.roleLbl.Size = new System.Drawing.Size(100, 15);
            this.roleLbl.TabIndex = 1;
            this.roleLbl.Text = "Caller Role";
            this.roleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // othLbl
            // 
            this.othLbl.Location = new System.Drawing.Point(286, 57);
            this.othLbl.Name = "othLbl";
            this.othLbl.Size = new System.Drawing.Size(100, 15);
            this.othLbl.TabIndex = 1;
            this.othLbl.Text = "Other Role";
            this.othLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(500, 85);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 2;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // callerGbx
            // 
            this.callerGbx.Controls.Add(this.textBox4);
            this.callerGbx.Controls.Add(this.nextBtn);
            this.callerGbx.Controls.Add(this.txtLastName);
            this.callerGbx.Controls.Add(this.othLbl);
            this.callerGbx.Controls.Add(this.textBox1);
            this.callerGbx.Controls.Add(this.roleLbl);
            this.callerGbx.Controls.Add(this.textBox2);
            this.callerGbx.Controls.Add(this.extLbl);
            this.callerGbx.Controls.Add(this.textBox3);
            this.callerGbx.Controls.Add(this.phoneLbl);
            this.callerGbx.Controls.Add(this.textBox5);
            this.callerGbx.Controls.Add(this.lNameLbl);
            this.callerGbx.Controls.Add(this.fNameLbl);
            this.callerGbx.Location = new System.Drawing.Point(44, 115);
            this.callerGbx.Name = "callerGbx";
            this.callerGbx.Size = new System.Drawing.Size(589, 133);
            this.callerGbx.TabIndex = 3;
            this.callerGbx.TabStop = false;
            // 
            // CallerRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.callerGbx);
            this.Name = "CallerRole";
            this.Size = new System.Drawing.Size(693, 412);
            this.callerGbx.ResumeLayout(false);
            this.callerGbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label fNameLbl;
        private System.Windows.Forms.Label lNameLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label extLbl;
        private System.Windows.Forms.Label roleLbl;
        private System.Windows.Forms.Label othLbl;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.GroupBox callerGbx;
    }
}
