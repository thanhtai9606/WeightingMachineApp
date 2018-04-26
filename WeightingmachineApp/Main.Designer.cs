namespace WeightingmachineApp
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.timer4ComMonitor = new System.Windows.Forms.Timer(this.components);
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.barTruck = new System.Windows.Forms.ToolStrip();
            this.btnSearchTruck = new System.Windows.Forms.ToolStripButton();
            this.btnInTruck = new System.Windows.Forms.ToolStripButton();
            this.btnOutTruck = new System.Windows.Forms.ToolStripButton();
            this.btnWeightTruck = new System.Windows.Forms.ToolStripButton();
            this.btnUpWeightTruck = new System.Windows.Forms.ToolStripButton();
            this.btnPrintTruck = new System.Windows.Forms.ToolStripButton();
            this.btnBackTruck = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ledStationID = new UI.LxLedControl();
            this.led1 = new UI.LxLedControl();
            this.lc1 = new UI.Controls.LoadingCircle();
            this.txtVehicleNO = new System.Windows.Forms.TextBox();
            this.txtFirstWeight = new System.Windows.Forms.TextBox();
            this.txtSecondWeight = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbWeight = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.barTruck.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledStationID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.led1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer4ComMonitor
            // 
            this.timer4ComMonitor.Enabled = true;
            this.timer4ComMonitor.Interval = 500;
            this.timer4ComMonitor.Tick += new System.EventHandler(this.timer4ComMonitor_Tick);
            // 
            // serialPort
            // 
            this.serialPort.PortName = "COM4";
            // 
            // barTruck
            // 
            this.barTruck.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.barTruck.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSearchTruck,
            this.btnInTruck,
            this.btnOutTruck,
            this.btnWeightTruck,
            this.btnUpWeightTruck,
            this.btnPrintTruck,
            this.btnBackTruck});
            this.barTruck.Location = new System.Drawing.Point(0, 0);
            this.barTruck.Name = "barTruck";
            this.barTruck.Size = new System.Drawing.Size(993, 53);
            this.barTruck.TabIndex = 25;
            this.barTruck.Text = "toolStrip2";
            // 
            // btnSearchTruck
            // 
            this.btnSearchTruck.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchTruck.Image")));
            this.btnSearchTruck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearchTruck.Name = "btnSearchTruck";
            this.btnSearchTruck.Size = new System.Drawing.Size(195, 50);
            this.btnSearchTruck.Text = "Tìm kiếm";
            // 
            // btnInTruck
            // 
            this.btnInTruck.Image = ((System.Drawing.Image)(resources.GetObject("btnInTruck.Image")));
            this.btnInTruck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInTruck.Name = "btnInTruck";
            this.btnInTruck.Size = new System.Drawing.Size(152, 50);
            this.btnInTruck.Text = "Xe vào";
            // 
            // btnOutTruck
            // 
            this.btnOutTruck.Image = ((System.Drawing.Image)(resources.GetObject("btnOutTruck.Image")));
            this.btnOutTruck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutTruck.Name = "btnOutTruck";
            this.btnOutTruck.Size = new System.Drawing.Size(125, 50);
            this.btnOutTruck.Text = "Xe ra";
            // 
            // btnWeightTruck
            // 
            this.btnWeightTruck.Image = ((System.Drawing.Image)(resources.GetObject("btnWeightTruck.Image")));
            this.btnWeightTruck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnWeightTruck.Name = "btnWeightTruck";
            this.btnWeightTruck.Size = new System.Drawing.Size(224, 50);
            this.btnWeightTruck.Text = "Record WT";
            // 
            // btnUpWeightTruck
            // 
            this.btnUpWeightTruck.Image = ((System.Drawing.Image)(resources.GetObject("btnUpWeightTruck.Image")));
            this.btnUpWeightTruck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpWeightTruck.Name = "btnUpWeightTruck";
            this.btnUpWeightTruck.Size = new System.Drawing.Size(226, 50);
            this.btnUpWeightTruck.Text = "Upload WT";
            // 
            // btnPrintTruck
            // 
            this.btnPrintTruck.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintTruck.Image")));
            this.btnPrintTruck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrintTruck.Name = "btnPrintTruck";
            this.btnPrintTruck.Size = new System.Drawing.Size(72, 50);
            this.btnPrintTruck.Text = "In";
            // 
            // btnBackTruck
            // 
            this.btnBackTruck.Image = ((System.Drawing.Image)(resources.GetObject("btnBackTruck.Image")));
            this.btnBackTruck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBackTruck.Name = "btnBackTruck";
            this.btnBackTruck.Size = new System.Drawing.Size(145, 50);
            this.btnBackTruck.Text = "Trở về";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(195)))));
            this.panel1.Controls.Add(this.ledStationID);
            this.panel1.Controls.Add(this.led1);
            this.panel1.Controls.Add(this.lc1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 75);
            this.panel1.TabIndex = 27;
            // 
            // ledStationID
            // 
            this.ledStationID.BackColor = System.Drawing.Color.Transparent;
            this.ledStationID.BackColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(195)))));
            this.ledStationID.BackColor_2 = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(195)))));
            this.ledStationID.BevelRate = 0.5F;
            this.ledStationID.BorderColor = System.Drawing.Color.Transparent;
            this.ledStationID.Dock = System.Windows.Forms.DockStyle.Right;
            this.ledStationID.FadedColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(195)))));
            this.ledStationID.ForeColor = System.Drawing.Color.White;
            this.ledStationID.HighlightOpaque = ((byte)(50));
            this.ledStationID.Location = new System.Drawing.Point(861, 0);
            this.ledStationID.Name = "ledStationID";
            this.ledStationID.Size = new System.Drawing.Size(132, 75);
            this.ledStationID.TabIndex = 31;
            this.ledStationID.Text = "201";
            this.ledStationID.TotalCharCount = 3;
            // 
            // led1
            // 
            this.led1.BackColor = System.Drawing.Color.Transparent;
            this.led1.BackColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(195)))));
            this.led1.BackColor_2 = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(195)))));
            this.led1.BevelRate = 0.5F;
            this.led1.BorderColor = System.Drawing.Color.Transparent;
            this.led1.Dock = System.Windows.Forms.DockStyle.Left;
            this.led1.FadedColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(170)))), ((int)(((byte)(200)))));
            this.led1.ForeColor = System.Drawing.Color.Yellow;
            this.led1.HighlightOpaque = ((byte)(50));
            this.led1.Location = new System.Drawing.Point(0, 0);
            this.led1.Name = "led1";
            this.led1.Size = new System.Drawing.Size(314, 75);
            this.led1.TabIndex = 30;
            this.led1.Text = "     0.0";
            this.led1.TotalCharCount = 8;
            // 
            // lc1
            // 
            this.lc1.Active = true;
            this.lc1.Color = System.Drawing.Color.Red;
            this.lc1.InnerCircleRadius = 8;
            this.lc1.Location = new System.Drawing.Point(310, 3);
            this.lc1.Name = "lc1";
            this.lc1.NumberSpoke = 24;
            this.lc1.OuterCircleRadius = 9;
            this.lc1.RotationSpeed = 100;
            this.lc1.Size = new System.Drawing.Size(41, 69);
            this.lc1.SpokeThickness = 4;
            this.lc1.StylePreset = UI.Controls.LoadingCircle.StylePresets.IE7;
            this.lc1.TabIndex = 29;
            this.lc1.Text = "lcFirst";
            // 
            // txtVehicleNO
            // 
            this.txtVehicleNO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtVehicleNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVehicleNO.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.txtVehicleNO.Location = new System.Drawing.Point(212, 134);
            this.txtVehicleNO.MinimumSize = new System.Drawing.Size(713, 30);
            this.txtVehicleNO.Name = "txtVehicleNO";
            this.txtVehicleNO.Size = new System.Drawing.Size(713, 30);
            this.txtVehicleNO.TabIndex = 28;
            this.txtVehicleNO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVehicleNO_KeyDown);
            // 
            // txtFirstWeight
            // 
            this.txtFirstWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(195)))));
            this.txtFirstWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstWeight.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.txtFirstWeight.ForeColor = System.Drawing.Color.White;
            this.txtFirstWeight.Location = new System.Drawing.Point(212, 226);
            this.txtFirstWeight.MinimumSize = new System.Drawing.Size(713, 30);
            this.txtFirstWeight.Name = "txtFirstWeight";
            this.txtFirstWeight.Size = new System.Drawing.Size(713, 30);
            this.txtFirstWeight.TabIndex = 28;
            // 
            // txtSecondWeight
            // 
            this.txtSecondWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(195)))));
            this.txtSecondWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSecondWeight.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.txtSecondWeight.ForeColor = System.Drawing.Color.White;
            this.txtSecondWeight.Location = new System.Drawing.Point(212, 280);
            this.txtSecondWeight.MinimumSize = new System.Drawing.Size(713, 30);
            this.txtSecondWeight.Name = "txtSecondWeight";
            this.txtSecondWeight.Size = new System.Drawing.Size(713, 30);
            this.txtSecondWeight.TabIndex = 28;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtMsg});
            this.statusStrip1.Location = new System.Drawing.Point(0, 505);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(993, 22);
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtMsg
            // 
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(22, 17);
            this.txtMsg.Text = "*_*";
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNote.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.txtNote.Location = new System.Drawing.Point(212, 330);
            this.txtNote.MinimumSize = new System.Drawing.Size(713, 30);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(713, 124);
            this.txtNote.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 330);
            this.label4.MinimumSize = new System.Drawing.Size(117, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 38);
            this.label4.TabIndex = 30;
            this.label4.Text = "Ghi chú:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 280);
            this.label3.MinimumSize = new System.Drawing.Size(117, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 38);
            this.label3.TabIndex = 31;
            this.label3.Text = "Cân lần 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 226);
            this.label2.MinimumSize = new System.Drawing.Size(117, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 38);
            this.label2.TabIndex = 32;
            this.label2.Text = "Cân lần 1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 131);
            this.label1.MinimumSize = new System.Drawing.Size(117, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 38);
            this.label1.TabIndex = 33;
            this.label1.Text = "Số xe:";
            // 
            // cmbWeight
            // 
            this.cmbWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cmbWeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbWeight.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.cmbWeight.FormattingEnabled = true;
            this.cmbWeight.Location = new System.Drawing.Point(212, 181);
            this.cmbWeight.MinimumSize = new System.Drawing.Size(713, 0);
            this.cmbWeight.Name = "cmbWeight";
            this.cmbWeight.Size = new System.Drawing.Size(713, 31);
            this.cmbWeight.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 181);
            this.label5.MinimumSize = new System.Drawing.Size(117, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 38);
            this.label5.TabIndex = 33;
            this.label5.Text = "Chọn cân:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(993, 527);
            this.Controls.Add(this.cmbWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtSecondWeight);
            this.Controls.Add(this.txtFirstWeight);
            this.Controls.Add(this.txtVehicleNO);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barTruck);
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.barTruck.ResumeLayout(false);
            this.barTruck.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ledStationID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.led1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer4ComMonitor;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.ToolStrip barTruck;
        private System.Windows.Forms.ToolStripButton btnSearchTruck;
        private System.Windows.Forms.ToolStripButton btnInTruck;
        private System.Windows.Forms.ToolStripButton btnOutTruck;
        private System.Windows.Forms.ToolStripButton btnWeightTruck;
        private System.Windows.Forms.ToolStripButton btnUpWeightTruck;
        private System.Windows.Forms.ToolStripButton btnPrintTruck;
        private System.Windows.Forms.ToolStripButton btnBackTruck;
        private System.Windows.Forms.Panel panel1;
        private UI.LxLedControl ledStationID;
        private UI.LxLedControl led1;
        private UI.Controls.LoadingCircle lc1;
        private System.Windows.Forms.TextBox txtVehicleNO;
        private System.Windows.Forms.TextBox txtFirstWeight;
        private System.Windows.Forms.TextBox txtSecondWeight;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.ToolStripStatusLabel txtMsg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbWeight;
        private System.Windows.Forms.Label label5;
    }
}