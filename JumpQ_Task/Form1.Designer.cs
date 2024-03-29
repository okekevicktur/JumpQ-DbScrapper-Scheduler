﻿namespace JumpQ_Task
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cboListOfDSN = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.BtnSynInventory = new System.Windows.Forms.Button();
            this.BtnSaveLogs = new System.Windows.Forms.Button();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.comTimer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChangeTime = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnMin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.ChkSync = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBkup = new System.Windows.Forms.Button();
            this.bkup = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "Select Data Source Name";
            // 
            // cboListOfDSN
            // 
            this.cboListOfDSN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboListOfDSN.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboListOfDSN.FormattingEnabled = true;
            this.cboListOfDSN.Location = new System.Drawing.Point(9, 65);
            this.cboListOfDSN.Name = "cboListOfDSN";
            this.cboListOfDSN.Size = new System.Drawing.Size(143, 21);
            this.cboListOfDSN.TabIndex = 80;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(40, 88);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 24);
            this.btnConnect.TabIndex = 82;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // BtnSynInventory
            // 
            this.BtnSynInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(154)))), ((int)(((byte)(184)))));
            this.BtnSynInventory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSynInventory.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSynInventory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSynInventory.Location = new System.Drawing.Point(23, 207);
            this.BtnSynInventory.Name = "BtnSynInventory";
            this.BtnSynInventory.Size = new System.Drawing.Size(150, 32);
            this.BtnSynInventory.TabIndex = 83;
            this.BtnSynInventory.Text = "Sync Inventory";
            this.BtnSynInventory.UseVisualStyleBackColor = false;
            this.BtnSynInventory.Click += new System.EventHandler(this.BtnSynInventory_Click);
            // 
            // BtnSaveLogs
            // 
            this.BtnSaveLogs.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveLogs.Location = new System.Drawing.Point(206, 117);
            this.BtnSaveLogs.Name = "BtnSaveLogs";
            this.BtnSaveLogs.Size = new System.Drawing.Size(93, 49);
            this.BtnSaveLogs.TabIndex = 84;
            this.BtnSaveLogs.Text = "Add login Auth";
            this.BtnSaveLogs.UseVisualStyleBackColor = true;
            this.BtnSaveLogs.Click += new System.EventHandler(this.BtnSaveLogs_Click);
            // 
            // TxtUsername
            // 
            this.TxtUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.Location = new System.Drawing.Point(66, 117);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(134, 22);
            this.TxtUsername.TabIndex = 85;
            this.TxtUsername.TextChanged += new System.EventHandler(this.TxtUsername_TextChanged);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(66, 144);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(134, 22);
            this.TxtPassword.TabIndex = 86;
            this.TxtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // comTimer
            // 
            this.comTimer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comTimer.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comTimer.FormattingEnabled = true;
            this.comTimer.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "10",
            "20",
            "30",
            "40"});
            this.comTimer.Location = new System.Drawing.Point(179, 64);
            this.comTimer.Name = "comTimer";
            this.comTimer.Size = new System.Drawing.Size(83, 21);
            this.comTimer.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 88;
            this.label2.Text = "hr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.label3.Location = new System.Drawing.Point(176, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 89;
            this.label3.Text = "Change interval";
            // 
            // btnChangeTime
            // 
            this.btnChangeTime.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeTime.Location = new System.Drawing.Point(179, 88);
            this.btnChangeTime.Name = "btnChangeTime";
            this.btnChangeTime.Size = new System.Drawing.Size(65, 23);
            this.btnChangeTime.TabIndex = 90;
            this.btnChangeTime.Text = "Change";
            this.btnChangeTime.UseVisualStyleBackColor = true;
            this.btnChangeTime.Click += new System.EventHandler(this.btnChangeTime_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "JumpQ Konnect is  running";
            this.notifyIcon1.BalloonTipTitle = "JumpQ Konnect";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "JumpQ Konnect Scheduler";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // btnMin
            // 
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(154)))), ((int)(((byte)(184)))));
            this.btnMin.Location = new System.Drawing.Point(308, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(31, 31);
            this.btnMin.TabIndex = 91;
            this.btnMin.Text = "x";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(154)))), ((int)(((byte)(184)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 31);
            this.panel1.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 19);
            this.label4.TabIndex = 92;
            this.label4.Text = "JumpQ Konnect AutoUpdater";
            // 
            // ChkSync
            // 
            this.ChkSync.AutoSize = true;
            this.ChkSync.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkSync.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.ChkSync.Location = new System.Drawing.Point(23, 174);
            this.ChkSync.Name = "ChkSync";
            this.ChkSync.Size = new System.Drawing.Size(200, 19);
            this.ChkSync.TabIndex = 93;
            this.ChkSync.Text = "Always sync inventory on startup";
            this.ChkSync.UseVisualStyleBackColor = true;
            this.ChkSync.CheckedChanged += new System.EventHandler(this.ChkSync_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.label5.Location = new System.Drawing.Point(6, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 94;
            this.label5.Text = "Username:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.label6.Location = new System.Drawing.Point(6, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 95;
            this.label6.Text = "Password:";
            // 
            // txtTimer
            // 
            this.txtTimer.AutoSize = true;
            this.txtTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.txtTimer.Location = new System.Drawing.Point(12, 34);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(33, 13);
            this.txtTimer.TabIndex = 96;
            this.txtTimer.Text = "Timer";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnBkup
            // 
            this.btnBkup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(154)))), ((int)(((byte)(184)))));
            this.btnBkup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBkup.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBkup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBkup.Location = new System.Drawing.Point(196, 207);
            this.btnBkup.Name = "btnBkup";
            this.btnBkup.Size = new System.Drawing.Size(133, 32);
            this.btnBkup.TabIndex = 97;
            this.btnBkup.Text = "Backup Inventory";
            this.btnBkup.UseVisualStyleBackColor = false;
            this.btnBkup.Click += new System.EventHandler(this.btnBkup_Click);
            // 
            // bkup
            // 
            this.bkup.AutoSize = true;
            this.bkup.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bkup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.bkup.Location = new System.Drawing.Point(197, 191);
            this.bkup.Name = "bkup";
            this.bkup.Size = new System.Drawing.Size(100, 13);
            this.bkup.TabIndex = 98;
            this.bkup.Text = "0 items backed up";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 251);
            this.ControlBox = false;
            this.Controls.Add(this.bkup);
            this.Controls.Add(this.btnBkup);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ChkSync);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnChangeTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comTimer);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.BtnSaveLogs);
            this.Controls.Add(this.BtnSynInventory);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboListOfDSN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JumpQ Task";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboListOfDSN;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button BtnSynInventory;
        private System.Windows.Forms.Button BtnSaveLogs;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.ComboBox comTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChangeTime;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ChkSync;
        private System.Windows.Forms.Label txtTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnBkup;
        private System.Windows.Forms.Label bkup;
    }
}

