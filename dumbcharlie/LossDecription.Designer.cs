namespace DumbCharlie1
{
    partial class LossDecription
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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.descriptLbl = new System.Windows.Forms.Label();
            this.txtLossType = new System.Windows.Forms.TextBox();
            this.lossTypeLbl = new System.Windows.Forms.Label();
            this.numInvolvedLbl = new System.Windows.Forms.Label();
            this.txtNumInvolved = new System.Windows.Forms.TextBox();
            this.locLbl = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.stateLbl = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.cityLbl = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.PDFDrespondLbl = new System.Windows.Forms.Label();
            this.witnessLbl = new System.Windows.Forms.Label();
            this.comboPDFD = new System.Windows.Forms.ComboBox();
            this.comboWitness = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.callerRole1 = new DumbCharlie1.CallerRole();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(103, 79);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(588, 73);
            this.txtDescription.TabIndex = 0;
            // 
            // descriptLbl
            // 
            this.descriptLbl.AutoSize = true;
            this.descriptLbl.Location = new System.Drawing.Point(34, 82);
            this.descriptLbl.Name = "descriptLbl";
            this.descriptLbl.Size = new System.Drawing.Size(60, 13);
            this.descriptLbl.TabIndex = 1;
            this.descriptLbl.Text = "Description";
            // 
            // txtLossType
            // 
            this.txtLossType.Location = new System.Drawing.Point(100, 195);
            this.txtLossType.Name = "txtLossType";
            this.txtLossType.Size = new System.Drawing.Size(588, 20);
            this.txtLossType.TabIndex = 2;
            // 
            // lossTypeLbl
            // 
            this.lossTypeLbl.AutoSize = true;
            this.lossTypeLbl.Location = new System.Drawing.Point(34, 198);
            this.lossTypeLbl.Name = "lossTypeLbl";
            this.lossTypeLbl.Size = new System.Drawing.Size(56, 13);
            this.lossTypeLbl.TabIndex = 3;
            this.lossTypeLbl.Text = "Loss Type";
            // 
            // numInvolvedLbl
            // 
            this.numInvolvedLbl.AutoSize = true;
            this.numInvolvedLbl.Location = new System.Drawing.Point(24, 156);
            this.numInvolvedLbl.Name = "numInvolvedLbl";
            this.numInvolvedLbl.Size = new System.Drawing.Size(70, 13);
            this.numInvolvedLbl.TabIndex = 4;
            this.numInvolvedLbl.Text = "# of Involved";
            // 
            // txtNumInvolved
            // 
            this.txtNumInvolved.Location = new System.Drawing.Point(103, 156);
            this.txtNumInvolved.Name = "txtNumInvolved";
            this.txtNumInvolved.Size = new System.Drawing.Size(33, 20);
            this.txtNumInvolved.TabIndex = 1;
            // 
            // locLbl
            // 
            this.locLbl.AutoSize = true;
            this.locLbl.Location = new System.Drawing.Point(42, 237);
            this.locLbl.Name = "locLbl";
            this.locLbl.Size = new System.Drawing.Size(48, 13);
            this.locLbl.TabIndex = 6;
            this.locLbl.Text = "Location";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(100, 234);
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(588, 58);
            this.txtLocation.TabIndex = 3;
            // 
            // stateLbl
            // 
            this.stateLbl.AutoSize = true;
            this.stateLbl.Location = new System.Drawing.Point(58, 300);
            this.stateLbl.Name = "stateLbl";
            this.stateLbl.Size = new System.Drawing.Size(32, 13);
            this.stateLbl.TabIndex = 8;
            this.stateLbl.Text = "State";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(100, 298);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(38, 20);
            this.txtState.TabIndex = 9;
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.Location = new System.Drawing.Point(144, 300);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(24, 13);
            this.cityLbl.TabIndex = 10;
            this.cityLbl.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(170, 297);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(190, 20);
            this.txtCity.TabIndex = 4;
            // 
            // PDFDrespondLbl
            // 
            this.PDFDrespondLbl.AutoSize = true;
            this.PDFDrespondLbl.Location = new System.Drawing.Point(97, 340);
            this.PDFDrespondLbl.Name = "PDFDrespondLbl";
            this.PDFDrespondLbl.Size = new System.Drawing.Size(175, 13);
            this.PDFDrespondLbl.TabIndex = 12;
            this.PDFDrespondLbl.Text = "Police / Fire Department resopond?";
            // 
            // witnessLbl
            // 
            this.witnessLbl.AutoSize = true;
            this.witnessLbl.Location = new System.Drawing.Point(100, 364);
            this.witnessLbl.Name = "witnessLbl";
            this.witnessLbl.Size = new System.Drawing.Size(62, 13);
            this.witnessLbl.TabIndex = 12;
            this.witnessLbl.Text = "Witnesses?";
            // 
            // comboPDFD
            // 
            this.comboPDFD.FormattingEnabled = true;
            this.comboPDFD.Items.AddRange(new object[] {
            "",
            "Yes",
            "No",
            "Unknown"});
            this.comboPDFD.Location = new System.Drawing.Point(296, 337);
            this.comboPDFD.Name = "comboPDFD";
            this.comboPDFD.Size = new System.Drawing.Size(81, 21);
            this.comboPDFD.TabIndex = 5;
            // 
            // comboWitness
            // 
            this.comboWitness.FormattingEnabled = true;
            this.comboWitness.Items.AddRange(new object[] {
            "",
            "Yes",
            "No",
            "Unknown"});
            this.comboWitness.Location = new System.Drawing.Point(296, 364);
            this.comboWitness.Name = "comboWitness";
            this.comboWitness.Size = new System.Drawing.Size(81, 21);
            this.comboWitness.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(761, 509);
            this.tabControl1.TabIndex = 14;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.callerRole1);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.descriptLbl);
            this.tabPage1.Controls.Add(this.comboWitness);
            this.tabPage1.Controls.Add(this.txtDescription);
            this.tabPage1.Controls.Add(this.comboPDFD);
            this.tabPage1.Controls.Add(this.txtLossType);
            this.tabPage1.Controls.Add(this.witnessLbl);
            this.tabPage1.Controls.Add(this.lossTypeLbl);
            this.tabPage1.Controls.Add(this.PDFDrespondLbl);
            this.tabPage1.Controls.Add(this.numInvolvedLbl);
            this.tabPage1.Controls.Add(this.txtCity);
            this.tabPage1.Controls.Add(this.txtNumInvolved);
            this.tabPage1.Controls.Add(this.cityLbl);
            this.tabPage1.Controls.Add(this.locLbl);
            this.tabPage1.Controls.Add(this.txtState);
            this.tabPage1.Controls.Add(this.txtLocation);
            this.tabPage1.Controls.Add(this.stateLbl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(753, 483);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // callerRole1
            // 
            this.callerRole1.Location = new System.Drawing.Point(6, 16);
            this.callerRole1.Name = "callerRole1";
            this.callerRole1.Size = new System.Drawing.Size(737, 454);
            this.callerRole1.TabIndex = 5;
            this.callerRole1.Load += new System.EventHandler(this.callerRole1_Load);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(649, 431);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(753, 483);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LossDecription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 505);
            this.Controls.Add(this.tabControl1);
            this.Name = "LossDecription";
            this.Text = "Loss Description";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label descriptLbl;
        private System.Windows.Forms.TextBox txtLossType;
        private System.Windows.Forms.Label lossTypeLbl;
        private System.Windows.Forms.Label numInvolvedLbl;
        private System.Windows.Forms.TextBox txtNumInvolved;
        private System.Windows.Forms.Label locLbl;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label stateLbl;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label cityLbl;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label PDFDrespondLbl;
        private System.Windows.Forms.Label witnessLbl;
        private System.Windows.Forms.ComboBox comboPDFD;
        private System.Windows.Forms.ComboBox comboWitness;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private CallerRole callerRole1;
        private System.Windows.Forms.Button btnSave;

    }
}