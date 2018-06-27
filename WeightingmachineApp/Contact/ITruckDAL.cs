using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WeightingmachineApp.Helper;
using WeightingmachineApp.Model;

namespace WeightingmachineApp.Contact
{
    public interface ITruckDAL
    {
        OperationResult CreateTruck(Truck truck);
        Truck FindTruckByVehicleNO(string vehicleNO);
        Truck FindTruck(string voucherid);
        Truck FindUpdateStatus(string voucherid, string status);
        OperationResult UpdateTruck(Truck truck);
        OperationResult Remove(string voucherid);   
        XDocument ReadFile(string filename);
        List<Truck> GetAllTrucks();
        void Save();
    }
}
