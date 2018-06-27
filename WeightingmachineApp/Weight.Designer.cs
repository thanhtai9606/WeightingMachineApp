namespace WeightingmachineApp
{
    partial class Weight
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtSecondTime = new System.Windows.Forms.TextBox();
            this.txtVehicleNO = new System.Windows.Forms.TextBox();
            this.txtFirstTime = new System.Windows.Forms.TextBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colVehicleNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSecondWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCheckInTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCheckOutTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colVehicleNO,
            this.colFirstWeight,
            this.colCheckInTime,
            this.colSecondWeight,
            this.colCheckOutTime,
            this.colNote});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 287);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(959, 204);
            this.gridControl1.TabIndex = 44;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtNote);
            this.layoutControl1.Controls.Add(this.txtSecondTime);
            this.layoutControl1.Controls.Add(this.txtVehicleNO);
            this.layoutControl1.Controls.Add(this.txtFirstTime);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(959, 287);
            this.layoutControl1.TabIndex = 45;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNote.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.txtNote.Location = new System.Drawing.Point(106, 136);
            this.txtNote.MinimumSize = new System.Drawing.Size(600, 30);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(841, 139);
            this.txtNote.TabIndex = 46;
            // 
            // txtSecondTime
            // 
            this.txtSecondTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(195)))));
            this.txtSecondTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSecondTime.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.txtSecondTime.ForeColor = System.Drawing.Color.White;
            this.txtSecondTime.Location = new System.Drawing.Point(106, 97);
            this.txtSecondTime.MinimumSize = new System.Drawing.Size(600, 30);
            this.txtSecondTime.Name = "txtSecondTime";
            this.txtSecondTime.Size = new System.Drawing.Size(841, 35);
            this.txtSecondTime.TabIndex = 47;
            // 
            // txtVehicleNO
            // 
            this.txtVehicleNO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtVehicleNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVehicleNO.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.txtVehicleNO.Location = new System.Drawing.Point(106, 12);
            this.txtVehicleNO.MinimumSize = new System.Drawing.Size(600, 30);
            this.txtVehicleNO.Name = "txtVehicleNO";
            this.txtVehicleNO.Size = new System.Drawing.Size(841, 39);
            this.txtVehicleNO.TabIndex = 49;
            // 
            // txtFirstTime
            // 
            this.txtFirstTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(195)))));
            this.txtFirstTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstTime.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.txtFirstTime.ForeColor = System.Drawing.Color.White;
            this.txtFirstTime.Location = new System.Drawing.Point(106, 55);
            this.txtFirstTime.MinimumSize = new System.Drawing.Size(600, 30);
            this.txtFirstTime.Name = "txtFirstTime";
            this.txtFirstTime.Size = new System.Drawing.Size(841, 38);
            this.txtFirstTime.TabIndex = 48;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(959, 287);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.txtVehicleNO;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(939, 43);
            this.layoutControlItem2.Text = "Số xe:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(91, 23);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.txtFirstTime;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 43);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(939, 42);
            this.layoutControlItem3.Text = "Cân Lần 1:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(91, 23);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.txtSecondTime;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 85);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(939, 39);
            this.layoutControlItem4.Text = "Cân Lần 2";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(91, 23);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.Control = this.txtNote;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 124);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(939, 143);
            this.layoutControlItem5.Text = "Ghi Chú:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(91, 23);
            // 
            // colVehicleNO
            // 
            this.colVehicleNO.Caption = "Số xe";
            this.colVehicleNO.FieldName = "VehicleNO";
            this.colVehicleNO.Name = "colVehicleNO";
            this.colVehicleNO.Visible = true;
            this.colVehicleNO.VisibleIndex = 0;
            // 
            // colFirstWeight
            // 
            this.colFirstWeight.Caption = "Cân Lần 1";
            this.colFirstWeight.FieldName = "FirstWeight";
            this.colFirstWeight.Name = "colFirstWeight";
            this.colFirstWeight.Visible = true;
            this.colFirstWeight.VisibleIndex = 1;
            // 
            // colSecondWeight
            // 
            this.colSecondWeight.Caption = "Cân lần 2";
            this.colSecondWeight.FieldName = "SecondWeight";
            this.colSecondWeight.Name = "colSecondWeight";
            this.colSecondWeight.Visible = true;
            this.colSecondWeight.VisibleIndex = 3;
            // 
            // colCheckInTime
            // 
            this.colCheckInTime.Caption = "T/gian Vào";
            this.colCheckInTime.FieldName = "CheckInTime";
            this.colCheckInTime.Name = "colCheckInTime";
            this.colCheckInTime.Visible = true;
            this.colCheckInTime.VisibleIndex = 2;
            // 
            // colCheckOutTime
            // 
            this.colCheckOutTime.Caption = "T/gian xe ra";
            this.colCheckOutTime.FieldName = "CheckOutTime";
            this.colCheckOutTime.Name = "colCheckOutTime";
            this.colCheckOutTime.Visible = true;
            this.colCheckOutTime.VisibleIndex = 4;
            // 
            // colNote
            // 
            this.colNote.Caption = "Ghi chú";
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 5;
            // 
            // Weight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Weight";
            this.Size = new System.Drawing.Size(959, 491);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtSecondTime;
        private System.Windows.Forms.TextBox txtVehicleNO;
        private System.Windows.Forms.TextBox txtFirstTime;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.Columns.GridColumn colVehicleNO;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn colCheckOutTime;
        private DevExpress.XtraGrid.Columns.GridColumn colCheckInTime;
        private DevExpress.XtraGrid.Columns.GridColumn colSecondWeight;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstWeight;

    }
}
