namespace AsyncSocketServer
{
    partial class Server
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
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.btnResetLogs = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGetStats = new System.Windows.Forms.Button();
            this.lblSessionTime = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblMissed = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblTotalTx = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblAvgConnect = new System.Windows.Forms.Label();
            this.lblAvgBoot = new System.Windows.Forms.Label();
            this.lblAvgHeartBeat = new System.Windows.Forms.Label();
            this.lblConnectedDevices = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.btnGetAvailableWifi = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(12, 374);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(785, 234);
            this.txtResponse.TabIndex = 0;
            this.txtResponse.TextChanged += new System.EventHandler(this.txtResponse_TextChanged);
            // 
            // btnResetLogs
            // 
            this.btnResetLogs.Location = new System.Drawing.Point(683, 167);
            this.btnResetLogs.Name = "btnResetLogs";
            this.btnResetLogs.Size = new System.Drawing.Size(108, 23);
            this.btnResetLogs.TabIndex = 1;
            this.btnResetLogs.Text = "Reset Logs";
            this.btnResetLogs.UseVisualStyleBackColor = true;
            this.btnResetLogs.Click += new System.EventHandler(this.btnResetLogs_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(683, 129);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGetStats);
            this.groupBox2.Controls.Add(this.lblSessionTime);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.lblMissed);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.lblTotalTx);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.lblAvgConnect);
            this.groupBox2.Controls.Add(this.lblAvgBoot);
            this.groupBox2.Controls.Add(this.lblAvgHeartBeat);
            this.groupBox2.Controls.Add(this.lblConnectedDevices);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 229);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stats";
            // 
            // btnGetStats
            // 
            this.btnGetStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetStats.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetStats.Location = new System.Drawing.Point(116, 200);
            this.btnGetStats.Name = "btnGetStats";
            this.btnGetStats.Size = new System.Drawing.Size(100, 23);
            this.btnGetStats.TabIndex = 35;
            this.btnGetStats.Text = "Get Stats";
            this.btnGetStats.UseVisualStyleBackColor = true;
            // 
            // lblSessionTime
            // 
            this.lblSessionTime.AutoSize = true;
            this.lblSessionTime.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessionTime.Location = new System.Drawing.Point(99, 148);
            this.lblSessionTime.Name = "lblSessionTime";
            this.lblSessionTime.Size = new System.Drawing.Size(50, 13);
            this.lblSessionTime.TabIndex = 37;
            this.lblSessionTime.Text = "unknown";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(31, 148);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(59, 13);
            this.label26.TabIndex = 36;
            this.label26.Text = "Session  :";
            // 
            // lblMissed
            // 
            this.lblMissed.AutoSize = true;
            this.lblMissed.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMissed.Location = new System.Drawing.Point(99, 127);
            this.lblMissed.Name = "lblMissed";
            this.lblMissed.Size = new System.Drawing.Size(50, 13);
            this.lblMissed.TabIndex = 35;
            this.lblMissed.Text = "unknown";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(38, 127);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(52, 13);
            this.label27.TabIndex = 34;
            this.label27.Text = "Missed :";
            // 
            // lblTotalTx
            // 
            this.lblTotalTx.AutoSize = true;
            this.lblTotalTx.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTx.Location = new System.Drawing.Point(99, 106);
            this.lblTotalTx.Name = "lblTotalTx";
            this.lblTotalTx.Size = new System.Drawing.Size(50, 13);
            this.lblTotalTx.TabIndex = 33;
            this.lblTotalTx.Text = "unknown";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(31, 106);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(59, 13);
            this.label25.TabIndex = 32;
            this.label25.Text = "Total Tx :";
            // 
            // lblAvgConnect
            // 
            this.lblAvgConnect.AutoSize = true;
            this.lblAvgConnect.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgConnect.Location = new System.Drawing.Point(99, 85);
            this.lblAvgConnect.Name = "lblAvgConnect";
            this.lblAvgConnect.Size = new System.Drawing.Size(50, 13);
            this.lblAvgConnect.TabIndex = 12;
            this.lblAvgConnect.Text = "unknown";
            // 
            // lblAvgBoot
            // 
            this.lblAvgBoot.AutoSize = true;
            this.lblAvgBoot.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgBoot.Location = new System.Drawing.Point(99, 64);
            this.lblAvgBoot.Name = "lblAvgBoot";
            this.lblAvgBoot.Size = new System.Drawing.Size(50, 13);
            this.lblAvgBoot.TabIndex = 11;
            this.lblAvgBoot.Text = "unknown";
            // 
            // lblAvgHeartBeat
            // 
            this.lblAvgHeartBeat.AutoSize = true;
            this.lblAvgHeartBeat.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgHeartBeat.Location = new System.Drawing.Point(99, 43);
            this.lblAvgHeartBeat.Name = "lblAvgHeartBeat";
            this.lblAvgHeartBeat.Size = new System.Drawing.Size(50, 13);
            this.lblAvgHeartBeat.TabIndex = 10;
            this.lblAvgHeartBeat.Text = "unknown";
            // 
            // lblConnectedDevices
            // 
            this.lblConnectedDevices.AutoSize = true;
            this.lblConnectedDevices.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectedDevices.Location = new System.Drawing.Point(99, 22);
            this.lblConnectedDevices.Name = "lblConnectedDevices";
            this.lblConnectedDevices.Size = new System.Drawing.Size(50, 13);
            this.lblConnectedDevices.TabIndex = 9;
            this.lblConnectedDevices.Text = "unknown";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 85);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(84, 13);
            this.label20.TabIndex = 8;
            this.label20.Text = "Avg Connect :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(26, 64);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(64, 13);
            this.label21.TabIndex = 6;
            this.label21.Text = "Avg Boot :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(37, 43);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "Avg HB :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(17, 22);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(73, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "Connected :";
            // 
            // btnGetAvailableWifi
            // 
            this.btnGetAvailableWifi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetAvailableWifi.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetAvailableWifi.Location = new System.Drawing.Point(354, 305);
            this.btnGetAvailableWifi.Name = "btnGetAvailableWifi";
            this.btnGetAvailableWifi.Size = new System.Drawing.Size(186, 23);
            this.btnGetAvailableWifi.TabIndex = 36;
            this.btnGetAvailableWifi.Text = "Get Available Wifi";
            this.btnGetAvailableWifi.UseVisualStyleBackColor = true;
            this.btnGetAvailableWifi.Click += new System.EventHandler(this.btnGetAvailableWifi_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 633);
            this.Controls.Add(this.btnGetAvailableWifi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnResetLogs);
            this.Controls.Add(this.txtResponse);
            this.Name = "Server";
            this.Text = "Async Socket Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Button btnResetLogs;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGetStats;
        private System.Windows.Forms.Label lblSessionTime;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblMissed;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblTotalTx;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblAvgConnect;
        private System.Windows.Forms.Label lblAvgBoot;
        private System.Windows.Forms.Label lblAvgHeartBeat;
        private System.Windows.Forms.Label lblConnectedDevices;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnGetAvailableWifi;
    }
}

