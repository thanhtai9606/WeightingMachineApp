using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WeightingmachineApp.Contact;
using WeightingmachineApp.Helper;
using WeightingmachineApp.Model;

namespace WeightingmachineApp.Implementation
{
   public class TruckInOutService : ITruckInOut
    {
        ITruckDAL _truckDal = new TruckDALService();

        OperationResult operationResut = new OperationResult();
        Truck _currentTruck = new Truck();
        public OperationResult CheckIn(Truck truck)
        {
            _currentTruck = _truckDal.FindTruck(truck.VoucherID);

            _currentTruck.CheckInTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            _currentTruck.Status = "I";
            _currentTruck.Note = truck.Note;

            operationResut = _truckDal.UpdateTruck(_currentTruck);
            return operationResut;

        }
        public OperationResult CheckOut(Truck truck)
        {
            _currentTruck = _truckDal.FindTruck(truck.VoucherID);        
            _currentTruck.Status = "O";
            _currentTruck.Note = truck.Note;
            operationResut = _truckDal.UpdateTruck(_currentTruck);
            return operationResut;
        }
        public OperationResult FirstWeight(Truck truck, decimal weight)
        {
            _currentTruck = _truckDal.FindTruck(truck.VoucherID);
            _currentTruck.FirstWeight = weight;
            _currentTruck.Status = "D";
            _currentTruck.Note = truck.Note;
            operationResut = _truckDal.UpdateTruck(_currentTruck);
            return operationResut;
        }
        public OperationResult SecondWeight(Truck truck, decimal weight)
        {
            _currentTruck = _truckDal.FindTruck(truck.VoucherID);
            _currentTruck.SecondWeight = weight;
            _currentTruck.CheckOutTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            _currentTruck.Status = "E";
            _currentTruck.Note = truck.Note;
            operationResut = _truckDal.UpdateTruck(_currentTruck);
            return operationResut;
        }
        public OperationResult PrintWeight(string voucherid)
        {
            _currentTruck = _truckDal.FindTruck(voucherid);
            _currentTruck.Status = "O";
            operationResut = _truckDal.UpdateTruck(_currentTruck);
            return operationResut;           
        }       
       
        public bool CancelFirstWeight(string voucherid)
        {            
            return UpdateStatus(voucherid, "I", "C");            
        }

        public bool CancelSecondWeight(string voucherid)
        {
            return UpdateStatus(voucherid, "D", "I");      
        }

        public bool CancelPrint(string vocuherid)
        {
            throw new NotImplementedException();
        }
        private bool UpdateStatus(string voucherid, string currentStatus, string status)
        {
            bool rValue = false;

            _currentTruck = _truckDal.FindUpdateStatus(voucherid, currentStatus);
            if (_currentTruck != null)
            {
                _currentTruck.Status = status;
                _truckDal.UpdateTruck(_currentTruck);
                rValue = true;
            }
            return rValue;
        }
    }
}
