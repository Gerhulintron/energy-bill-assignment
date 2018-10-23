namespace EnergyBill_KyleHinton
{
    partial class EnergyBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnergyBill));
            this.grpResEnergyBill = new System.Windows.Forms.GroupBox();
            this.btnResetRes = new System.Windows.Forms.Button();
            this.btnResExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResOutput = new System.Windows.Forms.Label();
            this.btnCalcRes = new System.Windows.Forms.Button();
            this.txtKWH_Res = new System.Windows.Forms.TextBox();
            this.lblResHours = new System.Windows.Forms.Label();
            this.grpCommEnergyBill = new System.Windows.Forms.GroupBox();
            this.btnResetComm = new System.Windows.Forms.Button();
            this.btnCommExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCommOuput = new System.Windows.Forms.Label();
            this.btnCalcComm = new System.Windows.Forms.Button();
            this.txtKWH_Comm = new System.Windows.Forms.TextBox();
            this.lblCommHours = new System.Windows.Forms.Label();
            this.grpIndustrialEnergyBill = new System.Windows.Forms.GroupBox();
            this.btnResetInd = new System.Windows.Forms.Button();
            this.btnIndExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOffPeakHours = new System.Windows.Forms.Label();
            this.txtOffPeakHours = new System.Windows.Forms.TextBox();
            this.lblIndustrialOutput = new System.Windows.Forms.Label();
            this.btnCalcIndustrial = new System.Windows.Forms.Button();
            this.txtPeakHours = new System.Windows.Forms.TextBox();
            this.lblPeakHours = new System.Windows.Forms.Label();
            this.grpEnergyContainer = new System.Windows.Forms.GroupBox();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.radIndustrialSelect = new System.Windows.Forms.RadioButton();
            this.radCommSelect = new System.Windows.Forms.RadioButton();
            this.radResSelect = new System.Windows.Forms.RadioButton();
            this.lblIndustrialCount = new System.Windows.Forms.Label();
            this.lblCommCount = new System.Windows.Forms.Label();
            this.lblResidentialCount = new System.Windows.Forms.Label();
            this.lblCustNum = new System.Windows.Forms.Label();
            this.lblCustomerTotal = new System.Windows.Forms.Label();
            this.lblIndTotal = new System.Windows.Forms.Label();
            this.lblCommTotal = new System.Windows.Forms.Label();
            this.lblResTotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.grpResEnergyBill.SuspendLayout();
            this.grpCommEnergyBill.SuspendLayout();
            this.grpIndustrialEnergyBill.SuspendLayout();
            this.grpEnergyContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpResEnergyBill
            // 
            this.grpResEnergyBill.BackColor = System.Drawing.Color.Transparent;
            this.grpResEnergyBill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpResEnergyBill.BackgroundImage")));
            this.grpResEnergyBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpResEnergyBill.Controls.Add(this.btnResetRes);
            this.grpResEnergyBill.Controls.Add(this.btnResExit);
            this.grpResEnergyBill.Controls.Add(this.label2);
            this.grpResEnergyBill.Controls.Add(this.lblResOutput);
            this.grpResEnergyBill.Controls.Add(this.btnCalcRes);
            this.grpResEnergyBill.Controls.Add(this.txtKWH_Res);
            this.grpResEnergyBill.Controls.Add(this.lblResHours);
            this.grpResEnergyBill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpResEnergyBill.Location = new System.Drawing.Point(26, 63);
            this.grpResEnergyBill.Name = "grpResEnergyBill";
            this.grpResEnergyBill.Size = new System.Drawing.Size(264, 287);
            this.grpResEnergyBill.TabIndex = 0;
            this.grpResEnergyBill.TabStop = false;
            this.grpResEnergyBill.Text = "Residential Energy Bill";
            // 
            // btnResetRes
            // 
            this.btnResetRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnResetRes.Location = new System.Drawing.Point(15, 236);
            this.btnResetRes.Name = "btnResetRes";
            this.btnResetRes.Size = new System.Drawing.Size(100, 23);
            this.btnResetRes.TabIndex = 9;
            this.btnResetRes.Text = "Reset";
            this.btnResetRes.UseVisualStyleBackColor = false;
            this.btnResetRes.Click += new System.EventHandler(this.btnResetRes_Click);
            // 
            // btnResExit
            // 
            this.btnResExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnResExit.Location = new System.Drawing.Point(121, 236);
            this.btnResExit.Name = "btnResExit";
            this.btnResExit.Size = new System.Drawing.Size(100, 23);
            this.btnResExit.TabIndex = 8;
            this.btnResExit.Text = "Exit";
            this.btnResExit.UseVisualStyleBackColor = false;
            this.btnResExit.Click += new System.EventHandler(this.btnResExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(7, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total Amount Due:";
            // 
            // lblResOutput
            // 
            this.lblResOutput.AutoSize = true;
            this.lblResOutput.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lblResOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResOutput.Location = new System.Drawing.Point(10, 125);
            this.lblResOutput.Name = "lblResOutput";
            this.lblResOutput.Size = new System.Drawing.Size(105, 17);
            this.lblResOutput.TabIndex = 3;
            this.lblResOutput.Text = "            ";
            // 
            // btnCalcRes
            // 
            this.btnCalcRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCalcRes.ForeColor = System.Drawing.Color.Transparent;
            this.btnCalcRes.Location = new System.Drawing.Point(10, 84);
            this.btnCalcRes.Name = "btnCalcRes";
            this.btnCalcRes.Size = new System.Drawing.Size(211, 23);
            this.btnCalcRes.TabIndex = 2;
            this.btnCalcRes.Text = "Calculate";
            this.btnCalcRes.UseVisualStyleBackColor = false;
            this.btnCalcRes.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtKWH_Res
            // 
            this.txtKWH_Res.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtKWH_Res.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtKWH_Res.Location = new System.Drawing.Point(10, 58);
            this.txtKWH_Res.Name = "txtKWH_Res";
            this.txtKWH_Res.Size = new System.Drawing.Size(100, 23);
            this.txtKWH_Res.TabIndex = 1;
            // 
            // lblResHours
            // 
            this.lblResHours.AutoSize = true;
            this.lblResHours.Location = new System.Drawing.Point(7, 40);
            this.lblResHours.Name = "lblResHours";
            this.lblResHours.Size = new System.Drawing.Size(191, 15);
            this.lblResHours.TabIndex = 0;
            this.lblResHours.Text = "Enter a number of KwH: ";
            // 
            // grpCommEnergyBill
            // 
            this.grpCommEnergyBill.BackColor = System.Drawing.Color.LightSkyBlue;
            this.grpCommEnergyBill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpCommEnergyBill.BackgroundImage")));
            this.grpCommEnergyBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpCommEnergyBill.Controls.Add(this.btnResetComm);
            this.grpCommEnergyBill.Controls.Add(this.btnCommExit);
            this.grpCommEnergyBill.Controls.Add(this.label3);
            this.grpCommEnergyBill.Controls.Add(this.lblCommOuput);
            this.grpCommEnergyBill.Controls.Add(this.btnCalcComm);
            this.grpCommEnergyBill.Controls.Add(this.txtKWH_Comm);
            this.grpCommEnergyBill.Controls.Add(this.lblCommHours);
            this.grpCommEnergyBill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpCommEnergyBill.Location = new System.Drawing.Point(296, 63);
            this.grpCommEnergyBill.Name = "grpCommEnergyBill";
            this.grpCommEnergyBill.Size = new System.Drawing.Size(251, 287);
            this.grpCommEnergyBill.TabIndex = 4;
            this.grpCommEnergyBill.TabStop = false;
            this.grpCommEnergyBill.Text = "Commercial Energy Bill";
            this.grpCommEnergyBill.Visible = false;
            // 
            // btnResetComm
            // 
            this.btnResetComm.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnResetComm.Location = new System.Drawing.Point(6, 236);
            this.btnResetComm.Name = "btnResetComm";
            this.btnResetComm.Size = new System.Drawing.Size(100, 23);
            this.btnResetComm.TabIndex = 10;
            this.btnResetComm.Text = "Reset";
            this.btnResetComm.UseVisualStyleBackColor = false;
            this.btnResetComm.Click += new System.EventHandler(this.btnResetComm_Click);
            // 
            // btnCommExit
            // 
            this.btnCommExit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCommExit.Location = new System.Drawing.Point(112, 236);
            this.btnCommExit.Name = "btnCommExit";
            this.btnCommExit.Size = new System.Drawing.Size(100, 23);
            this.btnCommExit.TabIndex = 9;
            this.btnCommExit.Text = "Exit";
            this.btnCommExit.UseVisualStyleBackColor = false;
            this.btnCommExit.Click += new System.EventHandler(this.btnCommExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(7, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total Amount Due:";
            // 
            // lblCommOuput
            // 
            this.lblCommOuput.AutoSize = true;
            this.lblCommOuput.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblCommOuput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCommOuput.Location = new System.Drawing.Point(10, 125);
            this.lblCommOuput.Name = "lblCommOuput";
            this.lblCommOuput.Size = new System.Drawing.Size(105, 17);
            this.lblCommOuput.TabIndex = 3;
            this.lblCommOuput.Text = "            ";
            // 
            // btnCalcComm
            // 
            this.btnCalcComm.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCalcComm.Location = new System.Drawing.Point(10, 84);
            this.btnCalcComm.Name = "btnCalcComm";
            this.btnCalcComm.Size = new System.Drawing.Size(202, 23);
            this.btnCalcComm.TabIndex = 2;
            this.btnCalcComm.Text = "Calculate";
            this.btnCalcComm.UseVisualStyleBackColor = false;
            this.btnCalcComm.Click += new System.EventHandler(this.btnCalcComm_Click);
            // 
            // txtKWH_Comm
            // 
            this.txtKWH_Comm.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtKWH_Comm.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtKWH_Comm.Location = new System.Drawing.Point(10, 58);
            this.txtKWH_Comm.Name = "txtKWH_Comm";
            this.txtKWH_Comm.Size = new System.Drawing.Size(100, 23);
            this.txtKWH_Comm.TabIndex = 1;
            // 
            // lblCommHours
            // 
            this.lblCommHours.AutoSize = true;
            this.lblCommHours.BackColor = System.Drawing.Color.Transparent;
            this.lblCommHours.Location = new System.Drawing.Point(7, 40);
            this.lblCommHours.Name = "lblCommHours";
            this.lblCommHours.Size = new System.Drawing.Size(191, 15);
            this.lblCommHours.TabIndex = 0;
            this.lblCommHours.Text = "Enter a number of KwH: ";
            // 
            // grpIndustrialEnergyBill
            // 
            this.grpIndustrialEnergyBill.BackColor = System.Drawing.Color.Orange;
            this.grpIndustrialEnergyBill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpIndustrialEnergyBill.BackgroundImage")));
            this.grpIndustrialEnergyBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpIndustrialEnergyBill.Controls.Add(this.btnResetInd);
            this.grpIndustrialEnergyBill.Controls.Add(this.btnIndExit);
            this.grpIndustrialEnergyBill.Controls.Add(this.label1);
            this.grpIndustrialEnergyBill.Controls.Add(this.lblOffPeakHours);
            this.grpIndustrialEnergyBill.Controls.Add(this.txtOffPeakHours);
            this.grpIndustrialEnergyBill.Controls.Add(this.lblIndustrialOutput);
            this.grpIndustrialEnergyBill.Controls.Add(this.btnCalcIndustrial);
            this.grpIndustrialEnergyBill.Controls.Add(this.txtPeakHours);
            this.grpIndustrialEnergyBill.Controls.Add(this.lblPeakHours);
            this.grpIndustrialEnergyBill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpIndustrialEnergyBill.Location = new System.Drawing.Point(554, 63);
            this.grpIndustrialEnergyBill.Name = "grpIndustrialEnergyBill";
            this.grpIndustrialEnergyBill.Size = new System.Drawing.Size(270, 287);
            this.grpIndustrialEnergyBill.TabIndex = 5;
            this.grpIndustrialEnergyBill.TabStop = false;
            this.grpIndustrialEnergyBill.Text = "Industrial Energy Bill";
            this.grpIndustrialEnergyBill.Visible = false;
            // 
            // btnResetInd
            // 
            this.btnResetInd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnResetInd.Location = new System.Drawing.Point(5, 236);
            this.btnResetInd.Name = "btnResetInd";
            this.btnResetInd.Size = new System.Drawing.Size(100, 23);
            this.btnResetInd.TabIndex = 8;
            this.btnResetInd.Text = "Reset";
            this.btnResetInd.UseVisualStyleBackColor = false;
            this.btnResetInd.Click += new System.EventHandler(this.btnResetInd_Click);
            // 
            // btnIndExit
            // 
            this.btnIndExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnIndExit.Location = new System.Drawing.Point(111, 236);
            this.btnIndExit.Name = "btnIndExit";
            this.btnIndExit.Size = new System.Drawing.Size(100, 23);
            this.btnIndExit.TabIndex = 7;
            this.btnIndExit.Text = "Exit";
            this.btnIndExit.UseVisualStyleBackColor = false;
            this.btnIndExit.Click += new System.EventHandler(this.btnIndExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Amount Due:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblOffPeakHours
            // 
            this.lblOffPeakHours.AutoSize = true;
            this.lblOffPeakHours.BackColor = System.Drawing.Color.Transparent;
            this.lblOffPeakHours.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOffPeakHours.Location = new System.Drawing.Point(6, 84);
            this.lblOffPeakHours.Name = "lblOffPeakHours";
            this.lblOffPeakHours.Size = new System.Drawing.Size(191, 30);
            this.lblOffPeakHours.TabIndex = 5;
            this.lblOffPeakHours.Text = "Enter a number of \r\nKwH for off-peak hours:\r\n";
            // 
            // txtOffPeakHours
            // 
            this.txtOffPeakHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtOffPeakHours.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtOffPeakHours.Location = new System.Drawing.Point(5, 113);
            this.txtOffPeakHours.Name = "txtOffPeakHours";
            this.txtOffPeakHours.Size = new System.Drawing.Size(100, 23);
            this.txtOffPeakHours.TabIndex = 4;
            // 
            // lblIndustrialOutput
            // 
            this.lblIndustrialOutput.AutoSize = true;
            this.lblIndustrialOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblIndustrialOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIndustrialOutput.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIndustrialOutput.Location = new System.Drawing.Point(5, 180);
            this.lblIndustrialOutput.Name = "lblIndustrialOutput";
            this.lblIndustrialOutput.Size = new System.Drawing.Size(105, 17);
            this.lblIndustrialOutput.TabIndex = 3;
            this.lblIndustrialOutput.Text = "            ";
            // 
            // btnCalcIndustrial
            // 
            this.btnCalcIndustrial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCalcIndustrial.Location = new System.Drawing.Point(5, 139);
            this.btnCalcIndustrial.Name = "btnCalcIndustrial";
            this.btnCalcIndustrial.Size = new System.Drawing.Size(206, 23);
            this.btnCalcIndustrial.TabIndex = 2;
            this.btnCalcIndustrial.Text = "Calculate";
            this.btnCalcIndustrial.UseVisualStyleBackColor = false;
            this.btnCalcIndustrial.Click += new System.EventHandler(this.btnCalcIndustrial_Click);
            // 
            // txtPeakHours
            // 
            this.txtPeakHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtPeakHours.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtPeakHours.Location = new System.Drawing.Point(6, 58);
            this.txtPeakHours.Name = "txtPeakHours";
            this.txtPeakHours.Size = new System.Drawing.Size(100, 23);
            this.txtPeakHours.TabIndex = 1;
            // 
            // lblPeakHours
            // 
            this.lblPeakHours.AutoSize = true;
            this.lblPeakHours.BackColor = System.Drawing.Color.Transparent;
            this.lblPeakHours.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPeakHours.Location = new System.Drawing.Point(3, 29);
            this.lblPeakHours.Name = "lblPeakHours";
            this.lblPeakHours.Size = new System.Drawing.Size(167, 30);
            this.lblPeakHours.TabIndex = 0;
            this.lblPeakHours.Text = "Enter a number of \r\nKwH for peak hours: ";
            // 
            // grpEnergyContainer
            // 
            this.grpEnergyContainer.BackColor = System.Drawing.Color.Transparent;
            this.grpEnergyContainer.Controls.Add(this.lstCustomers);
            this.grpEnergyContainer.Controls.Add(this.lblSelect);
            this.grpEnergyContainer.Controls.Add(this.grpResEnergyBill);
            this.grpEnergyContainer.Controls.Add(this.radIndustrialSelect);
            this.grpEnergyContainer.Controls.Add(this.grpCommEnergyBill);
            this.grpEnergyContainer.Controls.Add(this.radCommSelect);
            this.grpEnergyContainer.Controls.Add(this.grpIndustrialEnergyBill);
            this.grpEnergyContainer.Controls.Add(this.radResSelect);
            this.grpEnergyContainer.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEnergyContainer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpEnergyContainer.Location = new System.Drawing.Point(14, 165);
            this.grpEnergyContainer.Name = "grpEnergyContainer";
            this.grpEnergyContainer.Size = new System.Drawing.Size(1211, 385);
            this.grpEnergyContainer.TabIndex = 6;
            this.grpEnergyContainer.TabStop = false;
            this.grpEnergyContainer.Text = "Energy Bill";
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.ItemHeight = 15;
            this.lstCustomers.Location = new System.Drawing.Point(833, 63);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(352, 289);
            this.lstCustomers.TabIndex = 10;
            this.lstCustomers.SelectedIndexChanged += new System.EventHandler(this.lstCustomers_SelectedIndexChanged);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(96, 19);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(488, 18);
            this.lblSelect.TabIndex = 9;
            this.lblSelect.Text = "Select the type of bill you\'d like to calculate:";
            // 
            // radIndustrialSelect
            // 
            this.radIndustrialSelect.AutoSize = true;
            this.radIndustrialSelect.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radIndustrialSelect.Location = new System.Drawing.Point(418, 33);
            this.radIndustrialSelect.Name = "radIndustrialSelect";
            this.radIndustrialSelect.Size = new System.Drawing.Size(126, 22);
            this.radIndustrialSelect.TabIndex = 8;
            this.radIndustrialSelect.Text = "Industrial";
            this.radIndustrialSelect.UseVisualStyleBackColor = true;
            this.radIndustrialSelect.CheckedChanged += new System.EventHandler(this.radIndustrialSelect_CheckedChanged);
            // 
            // radCommSelect
            // 
            this.radCommSelect.AutoSize = true;
            this.radCommSelect.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCommSelect.Location = new System.Drawing.Point(286, 35);
            this.radCommSelect.Name = "radCommSelect";
            this.radCommSelect.Size = new System.Drawing.Size(126, 22);
            this.radCommSelect.TabIndex = 7;
            this.radCommSelect.Text = "Commercial";
            this.radCommSelect.UseVisualStyleBackColor = true;
            this.radCommSelect.CheckedChanged += new System.EventHandler(this.radCommSelect_CheckedChanged);
            // 
            // radResSelect
            // 
            this.radResSelect.AutoSize = true;
            this.radResSelect.Checked = true;
            this.radResSelect.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radResSelect.Location = new System.Drawing.Point(144, 35);
            this.radResSelect.Name = "radResSelect";
            this.radResSelect.Size = new System.Drawing.Size(136, 22);
            this.radResSelect.TabIndex = 6;
            this.radResSelect.TabStop = true;
            this.radResSelect.Text = "Residential";
            this.radResSelect.UseVisualStyleBackColor = true;
            this.radResSelect.CheckedChanged += new System.EventHandler(this.radResSelect_CheckedChanged);
            // 
            // lblIndustrialCount
            // 
            this.lblIndustrialCount.AutoSize = true;
            this.lblIndustrialCount.BackColor = System.Drawing.Color.Transparent;
            this.lblIndustrialCount.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndustrialCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIndustrialCount.Location = new System.Drawing.Point(883, 137);
            this.lblIndustrialCount.Name = "lblIndustrialCount";
            this.lblIndustrialCount.Size = new System.Drawing.Size(178, 16);
            this.lblIndustrialCount.TabIndex = 18;
            this.lblIndustrialCount.Text = "Industrial Count:";
            // 
            // lblCommCount
            // 
            this.lblCommCount.AutoSize = true;
            this.lblCommCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCommCount.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCommCount.Location = new System.Drawing.Point(883, 121);
            this.lblCommCount.Name = "lblCommCount";
            this.lblCommCount.Size = new System.Drawing.Size(178, 16);
            this.lblCommCount.TabIndex = 17;
            this.lblCommCount.Text = "Commercial Count:";
            // 
            // lblResidentialCount
            // 
            this.lblResidentialCount.AutoSize = true;
            this.lblResidentialCount.BackColor = System.Drawing.Color.Transparent;
            this.lblResidentialCount.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResidentialCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResidentialCount.Location = new System.Drawing.Point(883, 105);
            this.lblResidentialCount.Name = "lblResidentialCount";
            this.lblResidentialCount.Size = new System.Drawing.Size(188, 16);
            this.lblResidentialCount.TabIndex = 16;
            this.lblResidentialCount.Text = "Residential Count:";
            // 
            // lblCustNum
            // 
            this.lblCustNum.AutoSize = true;
            this.lblCustNum.BackColor = System.Drawing.Color.Transparent;
            this.lblCustNum.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustNum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCustNum.Location = new System.Drawing.Point(883, 153);
            this.lblCustNum.Name = "lblCustNum";
            this.lblCustNum.Size = new System.Drawing.Size(198, 16);
            this.lblCustNum.TabIndex = 15;
            this.lblCustNum.Text = "Number of Customer:";
            // 
            // lblCustomerTotal
            // 
            this.lblCustomerTotal.AutoSize = true;
            this.lblCustomerTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerTotal.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCustomerTotal.Location = new System.Drawing.Point(520, 150);
            this.lblCustomerTotal.Name = "lblCustomerTotal";
            this.lblCustomerTotal.Size = new System.Drawing.Size(168, 16);
            this.lblCustomerTotal.TabIndex = 14;
            this.lblCustomerTotal.Text = "Customer Total: ";
            // 
            // lblIndTotal
            // 
            this.lblIndTotal.AutoSize = true;
            this.lblIndTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblIndTotal.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIndTotal.Location = new System.Drawing.Point(520, 134);
            this.lblIndTotal.Name = "lblIndTotal";
            this.lblIndTotal.Size = new System.Drawing.Size(188, 16);
            this.lblIndTotal.TabIndex = 13;
            this.lblIndTotal.Text = "Industrial Total: ";
            // 
            // lblCommTotal
            // 
            this.lblCommTotal.AutoSize = true;
            this.lblCommTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblCommTotal.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCommTotal.Location = new System.Drawing.Point(520, 118);
            this.lblCommTotal.Name = "lblCommTotal";
            this.lblCommTotal.Size = new System.Drawing.Size(188, 16);
            this.lblCommTotal.TabIndex = 12;
            this.lblCommTotal.Text = "Commercial Total: ";
            // 
            // lblResTotal
            // 
            this.lblResTotal.AutoSize = true;
            this.lblResTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblResTotal.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResTotal.Location = new System.Drawing.Point(520, 102);
            this.lblResTotal.Name = "lblResTotal";
            this.lblResTotal.Size = new System.Drawing.Size(198, 16);
            this.lblResTotal.TabIndex = 11;
            this.lblResTotal.Text = "Residential Total: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(1071, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnResetAll
            // 
            this.btnResetAll.BackColor = System.Drawing.Color.DimGray;
            this.btnResetAll.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetAll.ForeColor = System.Drawing.SystemColors.Control;
            this.btnResetAll.Location = new System.Drawing.Point(937, 20);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(128, 35);
            this.btnResetAll.TabIndex = 11;
            this.btnResetAll.Text = "Reset All";
            this.btnResetAll.UseVisualStyleBackColor = false;
            this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblAccountNumber);
            this.groupBox1.Controls.Add(this.lblCustomerName);
            this.groupBox1.Controls.Add(this.txtAccountNumber);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 147);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.Location = new System.Drawing.Point(23, 93);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(248, 18);
            this.lblAccountNumber.TabIndex = 13;
            this.lblAccountNumber.Text = "Customer Account Number:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(75, 44);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(148, 18);
            this.lblCustomerName.TabIndex = 12;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAccountNumber.Location = new System.Drawing.Point(284, 93);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(166, 23);
            this.txtAccountNumber.TabIndex = 1;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCustomerName.Location = new System.Drawing.Point(284, 44);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(166, 23);
            this.txtCustomerName.TabIndex = 0;
            // 
            // EnergyBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1237, 556);
            this.Controls.Add(this.lblResidentialCount);
            this.Controls.Add(this.lblResTotal);
            this.Controls.Add(this.lblCommCount);
            this.Controls.Add(this.lblIndustrialCount);
            this.Controls.Add(this.lblCommTotal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblIndTotal);
            this.Controls.Add(this.lblCustomerTotal);
            this.Controls.Add(this.btnResetAll);
            this.Controls.Add(this.lblCustNum);
            this.Controls.Add(this.grpEnergyContainer);
            this.Name = "EnergyBill";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Energy Bill";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EnergyBill_FormClosing);
            this.Load += new System.EventHandler(this.EnergyBill_Load);
            this.grpResEnergyBill.ResumeLayout(false);
            this.grpResEnergyBill.PerformLayout();
            this.grpCommEnergyBill.ResumeLayout(false);
            this.grpCommEnergyBill.PerformLayout();
            this.grpIndustrialEnergyBill.ResumeLayout(false);
            this.grpIndustrialEnergyBill.PerformLayout();
            this.grpEnergyContainer.ResumeLayout(false);
            this.grpEnergyContainer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblResOutput;
        private System.Windows.Forms.Button btnCalcRes;
        private System.Windows.Forms.TextBox txtKWH_Res;
        private System.Windows.Forms.Label lblResHours;
        private System.Windows.Forms.GroupBox grpCommEnergyBill;
        private System.Windows.Forms.Label lblCommOuput;
        private System.Windows.Forms.Button btnCalcComm;
        private System.Windows.Forms.TextBox txtKWH_Comm;
        private System.Windows.Forms.Label lblCommHours;
        private System.Windows.Forms.GroupBox grpIndustrialEnergyBill;
        private System.Windows.Forms.Label lblOffPeakHours;
        private System.Windows.Forms.TextBox txtOffPeakHours;
        private System.Windows.Forms.Label lblIndustrialOutput;
        private System.Windows.Forms.Button btnCalcIndustrial;
        private System.Windows.Forms.TextBox txtPeakHours;
        private System.Windows.Forms.Label lblPeakHours;
        private System.Windows.Forms.GroupBox grpEnergyContainer;
        private System.Windows.Forms.RadioButton radIndustrialSelect;
        private System.Windows.Forms.RadioButton radCommSelect;
        private System.Windows.Forms.RadioButton radResSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpResEnergyBill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnResExit;
        private System.Windows.Forms.Button btnCommExit;
        private System.Windows.Forms.Button btnIndExit;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Button btnResetRes;
        private System.Windows.Forms.Button btnResetComm;
        private System.Windows.Forms.Button btnResetInd;
        private System.Windows.Forms.Button btnResetAll;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Label lblResTotal;
        private System.Windows.Forms.Label lblCustomerTotal;
        private System.Windows.Forms.Label lblIndTotal;
        private System.Windows.Forms.Label lblCommTotal;
        private System.Windows.Forms.Label lblCustNum;
        private System.Windows.Forms.Label lblResidentialCount;
        private System.Windows.Forms.Label lblCommCount;
        private System.Windows.Forms.Label lblIndustrialCount;
    }
}

