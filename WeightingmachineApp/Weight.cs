using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeightingmachineApp.Model;
using DevExpress.XtraGrid.Views.Grid;

namespace WeightingmachineApp
{
    public partial class Weight : UserControl
    {
        public delegate void SendCommand();
        public event SendCommand Send;
        public delegate void SendVehicle(string x);
        public event SendVehicle SendNO;       
        public Weight()
        {
            InitializeComponent();
            txtVehicleNO.KeyDown += txtVehicleNO_KeyDown;
            txtVehicleNO.TextChanged += txtVehicleNO_TextChanged;
            gridView1.RowClick += gridView1_RowClick;
        }

        void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            RowClick();
            Send();
        }

        void txtVehicleNO_TextChanged(object sender, EventArgs e)
        {
           
            gridView1.FindFilterText = txtVehicleNO.Text.ToUpper();

        }

        private void txtVehicleNO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {                
                Send();
            }
        }
        public DataTable DTVehicle
        {
            set 
            {                
                gridControl1.DataSource = value;
                gridView1.BestFitColumns();
            }           
        }
        public string VehicleNO
        {
            set { txtVehicleNO.Text = value; }
            get
            {
                return txtVehicleNO.Text.ToUpper();
            }
        }
        public string FirstTime 
        {
            set { txtFirstTime.Text = value; }
            get 
            {
                return txtFirstTime.Text;
            }
        }
        public string SecondTime
        {
            set { txtSecondTime.Text = value; }
            get
            {
                return txtSecondTime.Text;
            }
        }
        public string Note
        {
            set { txtNote.Text = value; }
            get
            {
                return txtNote.Text;
            }
        }

        void RowClick()
        {
            txtVehicleNO.Text = gridView1.GetFocusedRowCellValue("VehicleNO").ToString();
            txtFirstTime.Text = gridView1.GetFocusedRowCellValue("FirstWeight").ToString();
            txtSecondTime.Text = gridView1.GetFocusedRowCellValue("FirstWeight").ToString();
            txtNote.Text = gridView1.GetFocusedRowCellValue("Note").ToString();

            gridView1.FindFilterText = null;
        }
    }
}
