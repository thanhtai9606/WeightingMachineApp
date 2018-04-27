using FEPV.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeightingmachineApp.Contact;
using WeightingmachineApp.Helper;
using WeightingmachineApp.Implementation;
using WeightingmachineApp.Model;

namespace WeightingmachineApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
             this.Load += new EventHandler(EGATE_Load);
            RegisterCommand();
        }
         OperationResult operationResult = new OperationResult();

        ITruckDAL _truckDAL = new TruckDALService();
        ITruckInOut _truckInOut = new TruckInOutService();
        Truck _truck = new Truck();
        private string Gate { set; get; }
        List<string> ports = new List<string>();     
        public System.IO.Ports.SerialPort PORT//Serial Weighing
        {
            get
            {
                return serialPort;
            }
            set
            {
                serialPort = value;
            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            if (serialPort != null)
                serialPort.Dispose();
            base.OnClosed(e);
        }

        private void EGATE_Load(object sender, EventArgs e)
        {
            BtnShow4Truck();           

            this.Text = ConfigurationSettings.AppSettings["NAME"].ToString();
            Setting4Print = ConfigurationSettings.AppSettings["Setting4Print"].ToString();
            Gate = ConfigurationSettings.AppSettings["GATE"].ToString();
            switch (Gate)
            {
                case "B":
                    ports = new List<string>(new string[] { "Cổng Bắc Trước", "Cổng Bắc Sau" });              
                    break;
                case "N":
                    ports = new List<string>(new string[] { "Cổng Nam Trước", "Cổng Nam Phải" });                   
                    break;
                case "A":
                    ports = new List<string>(new string[] { "Cổng Bắc Trước", "Cổng Bắc Sau","Cổng Nam Trước", "Cổng Nam Phải" });                   
                    break;
                default:
                    break;
                    
            }
            foreach( var a in ports)
            {
                cmbWeight.Items.Add(a);
            }
            cmbWeight.SelectedIndex = 0;
        }
        private string ChoicePORT()
        {
            string result = string.Empty;           
            switch(cmbWeight.SelectedItem.ToString())
            {
                case "Cổng Nam Trước":
                    result = ConfigurationSettings.AppSettings["SOUTH_FRONT"].ToString();//GATE SOUNTH LEFT
                    break;
                case "Cổng Nam Phải":
                   result = ConfigurationSettings.AppSettings["SOUTH_RIGHT"].ToString();//GATE SOUNTH RIGHT
                    break;
                case "Cổng Bắc Trước":
                   result = ConfigurationSettings.AppSettings["NORTH_FRONT"].ToString();//GATE NORTH FONT
                    break;
                case "Cổng Bắc Sau":
                   result = ConfigurationSettings.AppSettings["NORTH_TAIL"].ToString();//GATE NORTH TAIL
                    break;
                default:
                     result = ConfigurationSettings.AppSettings["SOUTH_LEFT"].ToString();//GATE SOUNTH LEFT
                    break;
            }          
            return result;
        }
        string MainMsg
        {
            set
            {
                txtMsg.Text = value;                               
            }
        }
        string dataWeight = "";
        DataPackage dataPackage = new DataPackage { Weight = 0m, LastActive = DateTime.Now };
      
        string Data = string.Empty;
        /// <summary>
        /// serialPort Data Received
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Data += serialPort.ReadExisting();
            dataPackage.LastActive = DateTime.Now;

            //Add by Leo for new ToLeDo at FEPV 20170415  南门
            if (FEPVTOLEDO.DoTransfer(Data, out weight))
            {
                dataPackage.Weight = weight;
                //MainMsg = DateTime.Now.ToString() + "-TOLEDO-" + weight.ToString();
                Data = string.Empty;
                return;
            }
            //北们
            if (MarcusP5SD.DoTransfer(Data, out weight))
            {
                dataPackage.Weight = weight;
                //MainMsg = DateTime.Now.ToString() + "-TOLEDO-" + weight.ToString();
                Data = string.Empty;
                return;
            }
            //if (BeiChang.DoTransfer(Data, out weight))
            //{
            //    dataPackage.Weight = weight;
            //    //MainMsg = DateTime.Now.ToString() + "-BeiChang-" + weight.ToString();
            //    Data = string.Empty;
            //    return;
            //}
            //if (DongChang.DoTransfer(Data, out weight))
            //{
            //    dataPackage.Weight = weight;
            //    //MainMsg = DateTime.Now.ToString() + "-DongChang-" + weight.ToString();
            //    Data = string.Empty;
            //    return;
            //}
            //if (YaoHua.DoTransfer(Data, out weight))
            //{
            //    dataPackage.Weight = weight;
            //    //MainMsg = DateTime.Now.ToString() + "-YaoHua-" + weight.ToString();
            //    Data = string.Empty;
            //    return;
            //}
            if (Data.Length > 1000)
                Data = string.Empty;
        }

        private void txtVehicleNO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchTruck();
            }
        }
        private void Reset()
        {
            txtVehicleNO.Text = string.Empty;
            txtFirstWeight.Text = string.Empty;
            txtSecondWeight.Text = string.Empty;
            txtNote.Text = string.Empty;
        }
     
        /// <summary>
        /// Read the COMPORT and get value on each second
        /// </summary>
        /// <param input name="PORTNAME"></param>
        /// <output name="led1"></param>
        private void timer4ComMonitor_Tick(object sender, EventArgs e)
        {
            string ledComName = PORT.PortName.ToUpper().Trim().Replace("COM", "").PadLeft(3, '0');

            ledStationID.Text = ledComName;

            if ((dataPackage.LastValidated - DateTime.Now).Duration() > new TimeSpan(0, 0, 2))
            {
                led1.ForeColor = Color.Red;

            }
            else
            {
                if ((dataPackage.LastChanged - DateTime.Now).Duration() < new TimeSpan(0, 0, 2))
                {
                    led1.ForeColor = Color.Yellow;

                }
                else
                {
                    led1.ForeColor = Color.Blue;

                }

                dataWeight = dataPackage.Weight.ToString().PadLeft(8, ' ');
                led1.Text = dataWeight;

            }

            if ((dataPackage.LastActive - DateTime.Now).Duration() > new TimeSpan(0, 0, 5))
            {
                lc1.Visible = true;

            }
            else
            {
                lc1.Visible = false;

            }
        }       
        public string Setting4Print { get; set; }
        private void RegisterCommand()
        {
            btnSearchTruck.Click += new EventHandler(btnSearchTruck_Click);
            btnBackTruck.Click += new EventHandler(btnBackTruck_Click);
            btnWeightTruck.Click += new EventHandler(btnWeightTruck_Click);
            btnInTruck.Click += new EventHandler(btnInTruck_Click);
            btnOutTruck.Click += new EventHandler(btnOutTruck_Click);
            btnPrintTruck.Click += new EventHandler(btnPrintTruck_Click);
            btnUpWeightTruck.Click += new EventHandler(btnUpWeight_Click);
            cmbWeight.SelectedIndexChanged += new EventHandler(cmbWeight_SelectedIndexChanged);
            txtVehicleNO.KeyDown += txtVehicleNO_KeyDown;
          
        }

        #region Data Process        
        private void SearchTruck()
        {

            TruckQueryPlan();

        }
        //Create for New Truck
        private void CreateTruck()
        {
            //Create new TruckInfo
            _truck = new Truck();
            _truck.VoucherID = Guid.NewGuid().ToString();
            _truck.VehicleNO = txtVehicleNO.Text;
            _truck.Note = txtNote.Text;
            _truck.FirstWeight = 0;
            _truck.SecondWeight = 0;
            _truck.Status = "C";
            operationResult = _truckDAL.CreateTruck(_truck);
            if (operationResult.Success)
            {
                MainMsg = "Đã tạo xe mới " + _truck.VehicleNO;
            }
            else { MainMsg = "Lỗi tạo xe " + _truck.VehicleNO + " " + operationResult.Message; }
        }
        //Check for TruckIn
        public void CheckIn4Truck()
        {
            _truck.Note = txtNote.Text;
            operationResult = _truckInOut.CheckIn(_truck);
            if (operationResult.Success)
            {
                MainMsg = "Xe đã vào.";
            }
            else
            {
                MainMsg = "Lỗi xe vào " + operationResult.Message;
            }

            BtnShow4Truck();
        }
        //Check for TruckOut
        public void CheckOut4Truck()
        {
            _truck.Note = txtNote.Text;
            operationResult = _truckInOut.CheckOut(_truck);
            if (operationResult.Success)
            {
                MainMsg = "Xe đã ra khỏi công ty.";
            }
            else
            {
                MainMsg = "Lỗi xe ra. " + operationResult.Message;
            }
            operationResult = _truckDAL.Remove(_truck.VoucherID);
            BtnShow4Truck();
        }
        /// <summary>
        /// Search Truck
        /// </summary>
        /// <param name="vehicleNO"></param>
        /// <output name="Truck"></param>
        private void TruckQueryPlan()
        {

            //GetTrucks          
            if (txtVehicleNO.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập số xe.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                _truck = _truckDAL.FindTruckByVehicleNO(txtVehicleNO.Text);
                if (_truck == null)
                {
                    DialogResult dialogResult = MessageBox.Show("Chưa có xe này.\nBạn có muốn tạo mới?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        CreateTruck();// Auto Create New Truck if not exists on System
                        BtnShow4TruckIn();
                    }
                    else
                    {
                        BtnShow4Truck();
                    }
                }
                else
                {
                    txtVehicleNO.Text = _truck.VehicleNO.ToString();
                    txtFirstWeight.Text = _truck.FirstWeight == 0 ? string.Empty : _truck.FirstWeight.ToString();
                    txtSecondWeight.Text = _truck.SecondWeight == 0 ? string.Empty : _truck.SecondWeight.ToString();
                    txtNote.Text = _truck.Note.ToString();
                    switch (_truck.Status)
                    {
                        case "C":
                            BtnShow4TruckIn();
                            break;
                        case "I":
                            BtnShow4FirstWeight();                           
                            break;
                        case "D":
                            btnPrintTruck.Enabled = false;
                            BtnShow4SecondWeight();                           
                            break;
                        case "E":                         
                             BtnShow4Print();
                            break;
                        case "O":                          
                            BtnShow4TruckOut();
                            break;
                    }
                    btnWeightTruck.Enabled = true;
                    btnUpWeightTruck.Enabled = false;                   
                    MainMsg = "*_*";
                }               
            }
        }
       
        private void Weight()
        {
            if (led1.ForeColor != Color.Blue)
                return;
            Weighting(Convert.ToDecimal(led1.Text));// Call to Weighting Function

            btnUpWeightTruck.Enabled = true;//重量上传按钮
        }
        /// <summary>
        /// Weighting value. Get value from led1 save to database
        /// </summary>
        /// <param name="decimal weighting"></param>  
        private void Weighting(decimal weightTruck)
        {

            weight = 0m;
            if (weightTruck < 40m)
            {
                MessageBox.Show("Nhỏ hơn 40KG", "Information");
                return;
            }

            weight = weightTruck;
            var _currentTruck = _truckDAL.FindTruck(_truck.VoucherID);
            //check for In or Out to get Weight
            if (_currentTruck.Status == "I")
            {
                txtFirstWeight.Text = weight.ToString();
               
            }
            else
            {             
               
                txtSecondWeight.Text = weight.ToString();
            }
        }
        decimal weight = 0;// this variable to storage temple weighting value when Print
        private void Print(string VoucherID, bool isPaperPrint)
        {
            Print doc = new Print(VoucherID);
            doc.Setting = Setting4Print;
            doc.PrintBill(isPaperPrint);
            _truckInOut.PrintWeight(VoucherID);
            BtnShow4TruckOut();
        }
        #endregion
        #region ButtonClick
        private void btnSearchTruck_Click(object sender, EventArgs e)
        {
            SearchTruck();
        }       
        private void btnInTruck_Click(object sender, EventArgs e)
        {
            CheckIn4Truck();
        }
        private void btnOutTruck_Click(object sender, EventArgs e)
        {
            CheckOut4Truck();
        }
        private void btnWeightTruck_Click(object sender, EventArgs e)
        {
            Weight();
        }
        private void btnUpWeight_Click(object sender, EventArgs e)
        {
            var _currentTruck = _truckDAL.FindTruck(_truck.VoucherID);
            btnPrintTruck.Enabled = false;
            //check for In or Out to get Weight
            if (_currentTruck.Status == "I")
            {

                _currentTruck.FirstWeight = weight;
                _currentTruck.CheckInTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                _currentTruck.Note = txtNote.Text;

                operationResult = _truckInOut.FirstWeight(_currentTruck, weight);
                if (operationResult.Success)
                {
                    MainMsg = "Cân lần 1 thành công!";
                }
                else { MessageBox.Show(operationResult.Message, operationResult.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error); }
                BtnShow4Truck();
            }
            else
            {
                _currentTruck.SecondWeight = weight;
                _currentTruck.CheckOutTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                _currentTruck.Note = txtNote.Text;
                operationResult = _truckInOut.SecondWeight(_truck, weight);
                if (operationResult.Success)
                {
                    MainMsg = "Cân lần 2 thành công!";

                }
                else { MessageBox.Show(operationResult.Message, operationResult.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error); }
                btnPrintTruck.Enabled = true;
            }
            btnWeightTruck.Enabled = false;
            btnUpWeightTruck.Enabled = false;

            //BtnShow4Truck();
        }        
        private void btnPrintTruck_Click(object sender, EventArgs e)
        {
            Print(_truck.VoucherID, true);

        }
        private void btnBackTruck_Click(object sender, EventArgs e)
        {
            BtnShow4Truck();

        }
        #endregion
        #region Button Show
        //
        //Show Button Truck In Out, FirstWeight, SecondWeight,Print
        //
        private void BtnShow4Truck()
        {            
            btnSearchTruck.Visible = true;
            btnInTruck.Visible = false;
            btnOutTruck.Visible = false;
            btnWeightTruck.Visible = false;         
            btnPrintTruck.Visible = false;
            btnBackTruck.Visible = false;
            btnUpWeightTruck.Visible = false;
            barTruck.Refresh();           
            Reset();
        }    
        private void BtnShow4TruckIn()
        {
            btnSearchTruck.Visible = false;
            btnInTruck.Visible = true;
            btnOutTruck.Visible = false;
            btnWeightTruck.Visible = false;
            btnPrintTruck.Visible = false;
            btnBackTruck.Visible = true;
            btnUpWeightTruck.Visible = false;
            barTruck.Refresh();         
        }
        private void BtnShow4TruckOut()
        {
            btnSearchTruck.Visible = false;
            btnInTruck.Visible = false;
            btnOutTruck.Visible = true;
            btnWeightTruck.Visible = false;
            btnPrintTruck.Visible = false;
            btnBackTruck.Visible = true;
            btnUpWeightTruck.Visible = false;
            barTruck.Refresh();         
        }
        private void BtnShow4FirstWeight()
        {
            btnSearchTruck.Visible = false;
            btnInTruck.Visible = false;
            btnOutTruck.Visible = false;
            btnWeightTruck.Visible = true;
            btnUpWeightTruck.Visible = true;
            btnPrintTruck.Visible = false;
            btnBackTruck.Visible = true;
            barTruck.Refresh();         
        }
        private void BtnShow4SecondWeight()
        {
            btnSearchTruck.Visible = false;
            btnInTruck.Visible = false;
            btnOutTruck.Visible = false;
            btnWeightTruck.Visible = true;
            btnUpWeightTruck.Visible = true;
            btnPrintTruck.Visible = true;
            btnBackTruck.Visible = true;
           
            barTruck.Refresh();         
        }
        private void BtnShow4Print()
        {
            btnSearchTruck.Visible = false;
            btnInTruck.Visible = false;
            btnOutTruck.Visible = false;
            btnWeightTruck.Visible = false;
            btnPrintTruck.Visible = true;
            btnBackTruck.Visible = true;
            btnUpWeightTruck.Visible = false;
            barTruck.Refresh();         
        }
        #endregion
     
       // Choice where's the Weighting Machine used      
        private void cmbWeight_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainMsg = "*_*";
            if (serialPort != null)
            {
                serialPort.Dispose();
            }

            serialPort.PortName = ChoicePORT();
            try
            {
                serialPort.Open();
            }
            catch (Exception ex)
            {
                MainMsg = "Serial failures : " + ex.Message + "|" + e.ToString();
            }
            //DataReceived
            serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);

           
            
        }

    }
}
