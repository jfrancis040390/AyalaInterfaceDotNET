﻿namespace Ayala_Interface_dotNet
{
    partial class frmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgwDiplomat = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.browseAyala = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAyalaFolder = new System.Windows.Forms.TextBox();
            this.dgwLessVAT = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBrowsePrinter = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrinterPath = new System.Windows.Forms.TextBox();
            this.dgwDiscountNonVat = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.dgwTaxTable = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContractNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdminPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenantName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenantCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRMPath = new System.Windows.Forms.TextBox();
            this.btnBrowseRM = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.browseRM = new System.Windows.Forms.FolderBrowserDialog();
            this.dgwTerminal = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDiplomat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLessVAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDiscountNonVat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTaxTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTerminal)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgwTerminal);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.dgwDiplomat);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.browseAyala);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtAyalaFolder);
            this.groupBox1.Controls.Add(this.dgwLessVAT);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnBrowsePrinter);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtPrinterPath);
            this.groupBox1.Controls.Add(this.dgwDiscountNonVat);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dgwTaxTable);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtContractNumber);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUserPass);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAdminPass);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenantName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenantCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRMPath);
            this.groupBox1.Controls.Add(this.btnBrowseRM);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1042, 453);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgwDiplomat
            // 
            this.dgwDiplomat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDiplomat.Location = new System.Drawing.Point(796, 204);
            this.dgwDiplomat.Name = "dgwDiplomat";
            this.dgwDiplomat.Size = new System.Drawing.Size(235, 243);
            this.dgwDiplomat.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(793, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Diplomat Table";
            // 
            // browseAyala
            // 
            this.browseAyala.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.browseAyala.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.browseAyala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseAyala.Location = new System.Drawing.Point(388, 76);
            this.browseAyala.Name = "browseAyala";
            this.browseAyala.Size = new System.Drawing.Size(75, 25);
            this.browseAyala.TabIndex = 25;
            this.browseAyala.Text = "BROWSE";
            this.browseAyala.UseVisualStyleBackColor = true;
            this.browseAyala.Click += new System.EventHandler(this.browseDestination_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Ayala Folder:";
            // 
            // txtAyalaFolder
            // 
            this.txtAyalaFolder.Location = new System.Drawing.Point(109, 79);
            this.txtAyalaFolder.MaxLength = 100;
            this.txtAyalaFolder.Name = "txtAyalaFolder";
            this.txtAyalaFolder.Size = new System.Drawing.Size(273, 20);
            this.txtAyalaFolder.TabIndex = 23;
            // 
            // dgwLessVAT
            // 
            this.dgwLessVAT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLessVAT.Location = new System.Drawing.Point(555, 204);
            this.dgwLessVAT.Name = "dgwLessVAT";
            this.dgwLessVAT.Size = new System.Drawing.Size(235, 243);
            this.dgwLessVAT.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(552, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Less VAT";
            // 
            // btnBrowsePrinter
            // 
            this.btnBrowsePrinter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnBrowsePrinter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnBrowsePrinter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowsePrinter.Location = new System.Drawing.Point(388, 46);
            this.btnBrowsePrinter.Name = "btnBrowsePrinter";
            this.btnBrowsePrinter.Size = new System.Drawing.Size(75, 25);
            this.btnBrowsePrinter.TabIndex = 20;
            this.btnBrowsePrinter.Text = "BROWSE";
            this.btnBrowsePrinter.UseVisualStyleBackColor = true;
            this.btnBrowsePrinter.Click += new System.EventHandler(this.btnBrowsePrinter_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Printer Path:";
            // 
            // txtPrinterPath
            // 
            this.txtPrinterPath.Location = new System.Drawing.Point(109, 53);
            this.txtPrinterPath.MaxLength = 100;
            this.txtPrinterPath.Name = "txtPrinterPath";
            this.txtPrinterPath.Size = new System.Drawing.Size(273, 20);
            this.txtPrinterPath.TabIndex = 18;
            // 
            // dgwDiscountNonVat
            // 
            this.dgwDiscountNonVat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDiscountNonVat.Location = new System.Drawing.Point(314, 204);
            this.dgwDiscountNonVat.Name = "dgwDiscountNonVat";
            this.dgwDiscountNonVat.Size = new System.Drawing.Size(235, 243);
            this.dgwDiscountNonVat.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(311, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Senior Discounts";
            // 
            // dgwTaxTable
            // 
            this.dgwTaxTable.AllowUserToAddRows = false;
            this.dgwTaxTable.AllowUserToDeleteRows = false;
            this.dgwTaxTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTaxTable.Location = new System.Drawing.Point(23, 204);
            this.dgwTaxTable.Name = "dgwTaxTable";
            this.dgwTaxTable.Size = new System.Drawing.Size(285, 243);
            this.dgwTaxTable.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tax Tables";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Contract Number:";
            // 
            // txtContractNumber
            // 
            this.txtContractNumber.Location = new System.Drawing.Point(109, 156);
            this.txtContractNumber.MaxLength = 100;
            this.txtContractNumber.Name = "txtContractNumber";
            this.txtContractNumber.Size = new System.Drawing.Size(273, 20);
            this.txtContractNumber.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(531, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "User Password:";
            // 
            // txtUserPass
            // 
            this.txtUserPass.Location = new System.Drawing.Point(618, 41);
            this.txtUserPass.MaxLength = 4;
            this.txtUserPass.Name = "txtUserPass";
            this.txtUserPass.PasswordChar = '*';
            this.txtUserPass.Size = new System.Drawing.Size(124, 20);
            this.txtUserPass.TabIndex = 10;
            this.txtUserPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(524, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Admin Password:";
            // 
            // txtAdminPass
            // 
            this.txtAdminPass.Location = new System.Drawing.Point(618, 15);
            this.txtAdminPass.MaxLength = 4;
            this.txtAdminPass.Name = "txtAdminPass";
            this.txtAdminPass.PasswordChar = '*';
            this.txtAdminPass.Size = new System.Drawing.Size(124, 20);
            this.txtAdminPass.TabIndex = 8;
            this.txtAdminPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tenant Name:";
            // 
            // txtTenantName
            // 
            this.txtTenantName.Location = new System.Drawing.Point(109, 130);
            this.txtTenantName.MaxLength = 10;
            this.txtTenantName.Name = "txtTenantName";
            this.txtTenantName.Size = new System.Drawing.Size(273, 20);
            this.txtTenantName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tenant Code:";
            // 
            // txtTenantCode
            // 
            this.txtTenantCode.Location = new System.Drawing.Point(109, 105);
            this.txtTenantCode.MaxLength = 3;
            this.txtTenantCode.Name = "txtTenantCode";
            this.txtTenantCode.Size = new System.Drawing.Size(273, 20);
            this.txtTenantCode.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "RM Data Path:";
            // 
            // txtRMPath
            // 
            this.txtRMPath.Location = new System.Drawing.Point(109, 24);
            this.txtRMPath.MaxLength = 100;
            this.txtRMPath.Name = "txtRMPath";
            this.txtRMPath.Size = new System.Drawing.Size(273, 20);
            this.txtRMPath.TabIndex = 2;
            // 
            // btnBrowseRM
            // 
            this.btnBrowseRM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnBrowseRM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnBrowseRM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseRM.Location = new System.Drawing.Point(388, 19);
            this.btnBrowseRM.Name = "btnBrowseRM";
            this.btnBrowseRM.Size = new System.Drawing.Size(75, 25);
            this.btnBrowseRM.TabIndex = 1;
            this.btnBrowseRM.Text = "BROWSE";
            this.btnBrowseRM.UseVisualStyleBackColor = true;
            this.btnBrowseRM.Click += new System.EventHandler(this.btnBrowseRM_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(618, 84);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 47);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgwTerminal
            // 
            this.dgwTerminal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTerminal.Location = new System.Drawing.Point(796, 29);
            this.dgwTerminal.Name = "dgwTerminal";
            this.dgwTerminal.Size = new System.Drawing.Size(235, 151);
            this.dgwTerminal.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(793, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Terminal Number";
            // 
            // frmConfig
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 477);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfig";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interface Setup";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDiplomat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLessVAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDiscountNonVat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTaxTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTerminal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContractNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdminPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenantName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenantCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRMPath;
        private System.Windows.Forms.Button btnBrowseRM;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.FolderBrowserDialog browseRM;
        private System.Windows.Forms.DataGridView dgwDiscountNonVat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgwTaxTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBrowsePrinter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrinterPath;
        private System.Windows.Forms.DataGridView dgwLessVAT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button browseAyala;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAyalaFolder;
        private System.Windows.Forms.DataGridView dgwDiplomat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgwTerminal;
        private System.Windows.Forms.Label label13;
    }
}