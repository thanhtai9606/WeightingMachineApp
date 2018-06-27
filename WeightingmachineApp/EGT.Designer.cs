namespace WeightingmachineApp
{
    partial class EGT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EGT));
            this.barTruck = new System.Windows.Forms.ToolStrip();
            this.btnSearchTruck = new System.Windows.Forms.ToolStripButton();
            this.btnInTruck = new System.Windows.Forms.ToolStripButton();
            this.btnOutTruck = new System.Windows.Forms.ToolStripButton();
            this.btnWeightTruck = new System.Windows.Forms.ToolStripButton();
            this.btnUpWeightTruck = new System.Windows.Forms.ToolStripButton();
            this.btnPrintTruck = new System.Windows.Forms.ToolStripButton();
            this.btnBackTruck = new System.Windows.Forms.ToolStripButton();
            this.ledStationID = new UI.LxLedControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.led1 = new UI.LxLedControl();
            this.lc1 = new UI.Controls.LoadingCircle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer4ComMonitor = new System.Windows.Forms.Timer(this.components);
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.barTruck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledStationID)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.led1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.barTruck.Size = new System.Drawing.Size(842, 53);
            this.barTruck.TabIndex = 27;
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
            this.ledStationID.Location = new System.Drawing.Point(710, 0);
            this.ledStationID.Name = "ledStationID";
            this.ledStationID.Size = new System.Drawing.Size(132, 75);
            this.ledStationID.TabIndex = 31;
            this.ledStationID.Text = "201";
            this.ledStationID.TotalCharCount = 3;
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
            this.panel1.Size = new System.Drawing.Size(842, 75);
            this.panel1.TabIndex = 29;
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
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtMsg});
            this.statusStrip1.Location = new System.Drawing.Point(0, 485);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(842, 22);
            this.statusStrip1.TabIndex = 31;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtMsg
            // 
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(22, 17);
            this.txtMsg.Text = "*_*";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(195)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(842, 379);
            this.panel2.TabIndex = 30;
            // 
            // EGT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 507);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barTruck);
            this.Name = "EGT";
            this.Text = "Parent";
            this.barTruck.ResumeLayout(false);
            this.barTruck.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledStationID)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.led1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip barTruck;
        private System.Windows.Forms.ToolStripButton btnSearchTruck;
        private System.Windows.Forms.ToolStripButton btnInTruck;
        private System.Windows.Forms.ToolStripButton btnOutTruck;
        private System.Windows.Forms.ToolStripButton btnWeightTruck;
        private System.Windows.Forms.ToolStripButton btnUpWeightTruck;
        private System.Windows.Forms.ToolStripButton btnPrintTruck;
        private System.Windows.Forms.ToolStripButton btnBackTruck;
        private UI.LxLedControl ledStationID;
        private System.Windows.Forms.Panel panel1;
        private UI.LxLedControl led1;
        private UI.Controls.LoadingCircle lc1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txtMsg;
        private System.Windows.Forms.Timer timer4ComMonitor;
        public System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Panel panel2;
    }
}