using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeightingmachineApp.Helper;
using WeightingmachineApp.Model;

namespace WeightingmachineApp.Contact
{
    public interface ITruckInOut
    {
        OperationResult CheckIn(Truck truck);
        OperationResult CheckOut(Truck truck);
        OperationResult FirstWeight(Truck truck, decimal weight);
        OperationResult SecondWeight(Truck truck, decimal weight);
        OperationResult PrintWeight(string voucherid);
        bool CancelFirstWeight(string voucherid);
        bool CancelSecondWeight(string voucherid);
        bool CancelPrint(string vocuherid);
    }
}
