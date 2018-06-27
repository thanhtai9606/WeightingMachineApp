using FEPV.Views;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeightingmachineApp.Contact;
using WeightingmachineApp.Implementation;
using WeightingmachineApp.Model;

namespace WeightingmachineApp
{
    public partial class EGT
    {
        ITruckDAL _truckDAL = new TruckDALService();
        ITruckInOut _truckInOut = new TruckInOutService();
        Truck _truck = new Truck();     

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
            else 
            {
                weight = weightTruck;
                var _currentTruck = _truckDAL.FindTruck(_truck.VoucherID);
                //check for In or Out to get Weight
                if (_currentTruck.Status == "I")
                {
                    _weight.FirstTime = weight.ToString();

                }
                else
                {

                    _weight.SecondTime = weight.ToString();
                }
            }
          
        }
        decimal weight = 0;// this variable to storage temple weighting value when Print

        
    }
}
