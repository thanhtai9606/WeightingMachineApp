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
using WeightingmachineApp.Helper;
using WeightingmachineApp.Model;

namespace WeightingmachineApp
{
    public partial class EGT : UserControl
    {
        Weight _weight = new Weight();
        OperationResult operationResult = new OperationResult();
        public delegate void SendMessage(object obj, EventArgs e);

        public event SendMessage OnSendMessage;

        public EGT()
        {
            InitializeComponent();
            this.Load += Main_Load;
            RegisterCommand();  
        }
       
        void Main_Load(object sender, EventArgs e)
        {           
            BtnShow4Truck();            
            try
            {
                if (!serialPort.IsOpen)
                    serialPort.Open();
              
                serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);               
            }
            catch (Exception ex)
            {
                MainMsg = "Serial failures : " + ex.Message + "|" + e.ToString();
            }
            Setting4Print = ConfigurationSettings.AppSettings["Setting4Print"].ToString();
            panel2.Controls.Add(_weight);
            RefreshGrid();     
            _weight.Show();
            _weight.Send += _weight_Send;
            
        }

        void RefreshGrid()
        {
            _weight.DTVehicle = ToDataTable<Truck>(_truckDAL.GetAllTrucks());             
        }

       
        //Delegate Command Send
        void _weight_Send()
        {
            SearchTruck();
        }
        public string Setting4Print { get; set; }
        string MainMsg
        {
            set
            {
                txtMsg.Text = value;
            }
        }

        public System.IO.Ports.SerialPort PORT//Serial Weighting
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
        void RegisterCommand()
        {
            btnSearchTruck.Click += new EventHandler(btnSearchTruck_Click);
            btnBackTruck.Click += new EventHandler(btnBackTruck_Click);
            btnWeightTruck.Click += new EventHandler(btnWeightTruck_Click);
            btnInTruck.Click += new EventHandler(btnInTruck_Click);
            btnOutTruck.Click += new EventHandler(btnOutTruck_Click);
            btnPrintTruck.Click += new EventHandler(btnPrintTruck_Click);
            btnUpWeightTruck.Click += new EventHandler(btnUpWeight_Click);           
          

        }     
       
        public DataTable ToDataTable<T>(List<T> data)
        {
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }
        #region Data Process
        public void SearchTruck()
        {

            TruckQueryPlan();

        }
        //Create for New Truck
        private void CreateTruck()
        {
            //Create new TruckInfo
            _truck = new Truck();
            _truck.VoucherID = Guid.NewGuid().ToString();
            _truck.VehicleNO = _weight.VehicleNO;
            _truck.Note = _weight.Note;
            _truck.FirstWeight = 0;
            _truck.SecondWeight = 0;
            _truck.Status = "C";
            operationResult = _truckDAL.CreateTruck(_truck);
            if (operationResult.Success)
            {
                MainMsg = "Đã tạo xe mới " + _truck.VehicleNO;
            }
            else { MainMsg = "Lỗi tạo xe " + _truck.VehicleNO + " " + operationResult.Message; }
            RefreshGrid();
          
        }
        //Check for TruckIn
        public void CheckIn4Truck()
        {
            _truck.Note = _weight.Note;
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
            _truck.Note = _weight.Note;
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
            SerialPort a = new SerialPort();

            //GetTrucks          
            if (_weight.VehicleNO == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập số xe.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                _truck = _truckDAL.FindTruckByVehicleNO(_weight.VehicleNO);
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
                    _weight.VehicleNO = _truck.VehicleNO.ToString();
                    _weight.FirstTime = _truck.FirstWeight == 0 ? string.Empty : _truck.FirstWeight.ToString();
                    _weight.SecondTime = _truck.SecondWeight == 0 ? string.Empty : _truck.SecondWeight.ToString();
                    _weight.Note = _truck.Note.ToString();
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
            RefreshGrid();
        }
        private void btnOutTruck_Click(object sender, EventArgs e)
        {
            CheckOut4Truck();
            RefreshGrid();
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
                _currentTruck.Note = _weight.Note;

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
                _currentTruck.Note = _weight.Note;
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
            RefreshGrid();
        }
        private void btnPrintTruck_Click(object sender, EventArgs e)
        {
            Print(_truck.VoucherID, true);
            RefreshGrid();

        }
        private void btnBackTruck_Click(object sender, EventArgs e)
        {
            BtnShow4Truck();
            RefreshGrid();
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
        private void Reset()
        {
            _weight.VehicleNO = string.Empty;
            _weight.FirstTime = string.Empty;
            _weight.SecondTime = string.Empty;
            _weight.Note = string.Empty;
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
    }
}
