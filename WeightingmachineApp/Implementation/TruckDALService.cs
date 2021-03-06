﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WeightingmachineApp.Contact;
using WeightingmachineApp.Helper;
using WeightingmachineApp.Model;

namespace WeightingmachineApp.Implementation
{
    public class TruckDALService : ITruckDAL
    {

        XDocument xDoc;
        OperationResult operationResult = new OperationResult();
        private Truck _truck = new Truck();
        string strFile = @"data.xml";

        public OperationResult CreateTruck(Truck truck)
        {
            xDoc = ReadFile(strFile);

            try
            {
                XElement truckElement = new XElement("Truck",
                 new XElement("VoucherID", truck.VoucherID),
                 new XElement("VehicleNO", truck.VehicleNO),
                 new XElement("CheckInTime", truck.CheckInTime),
                 new XElement("CheckOutTime", truck.CheckOutTime),
                 new XElement("FirstWeight", truck.FirstWeight),
                 new XElement("SecondWeight", truck.SecondWeight),                
                 new XElement("Note", truck.Note),
                 new XElement("Status", truck.Status));

                xDoc.Root.Add(truckElement);
                xDoc.Root.Elements("Truck").GroupBy(i => (string)i.Element("VoucherID"))
                     .SelectMany(g => g.Skip(1))
                      .Remove();
                Save();
                operationResult.Success = true;
                operationResult.Message = "Đã lưu thành công!";
                operationResult.Caption = "Success";
            }
            catch (Exception ex)
            {
                operationResult.Success = false; ;
                operationResult.Message = "Lỗi: " + ex.ToString();
            }

            return operationResult;
        }
        public Truck FindTruckByVehicleNO(string vehicleNO)
        {
            _truck = new Truck();
            xDoc = ReadFile(strFile);
            XElement currentTruck = xDoc.Descendants("Truck").Where(p => p.Element("VehicleNO").Value == vehicleNO).FirstOrDefault();
            if (currentTruck != null)
            {
                _truck.VoucherID = currentTruck.Element("VoucherID").Value;
                _truck.VehicleNO = currentTruck.Element("VehicleNO").Value;
                _truck.CheckInTime = currentTruck.Element("CheckInTime").Value;
                _truck.CheckOutTime = currentTruck.Element("CheckOutTime").Value;             
                _truck.FirstWeight = decimal.Parse(currentTruck.Element("FirstWeight").Value);
                _truck.SecondWeight = decimal.Parse(currentTruck.Element("SecondWeight").Value);           
                _truck.Note = currentTruck.Element("Note").Value;
                _truck.Status = currentTruck.Element("Status").Value;
            }
            else { _truck = null; }
            return _truck;
        }
        public Truck FindTruck(string voucherid)
        {
            _truck = new Truck();
            xDoc = ReadFile(strFile);
            XElement currentTruck = xDoc.Descendants("Truck").Where(p => p.Element("VoucherID").Value == voucherid).FirstOrDefault();
            if (currentTruck != null)
            {
                _truck.VoucherID = currentTruck.Element("VoucherID").Value;
                _truck.VehicleNO = currentTruck.Element("VehicleNO").Value;
                _truck.CheckInTime = currentTruck.Element("CheckInTime").Value;
                _truck.CheckOutTime = currentTruck.Element("CheckOutTime").Value;             
                _truck.FirstWeight = decimal.Parse(currentTruck.Element("FirstWeight").Value);
                _truck.SecondWeight = decimal.Parse(currentTruck.Element("SecondWeight").Value);            
                _truck.Note = currentTruck.Element("Note").Value;
                _truck.Status = currentTruck.Element("Status").Value;
            }

            return _truck;
        }
        public OperationResult UpdateTruck(Truck truck)
        {
            xDoc = ReadFile(strFile);
            XElement currentNode = xDoc.Descendants("Truck").FirstOrDefault(x => x.Element("VoucherID").Value == truck.VoucherID);
            if (currentNode != null)
            {
                currentNode.Element("CheckInTime").Value = truck.CheckInTime;
                currentNode.Element("CheckOutTime").Value = truck.CheckOutTime;
                currentNode.Element("Status").Value = truck.Status;
                currentNode.Element("FirstWeight").Value = truck.FirstWeight.ToString();
                currentNode.Element("SecondWeight").Value = truck.SecondWeight.ToString();
                currentNode.Element("Note").Value = truck.Note.ToString();

                xDoc.Root.Add(currentNode);
                xDoc.Root.Elements("Truck").GroupBy(i => (string)i.Element("VoucherID"))
                     .SelectMany(g => g.Skip(1))
                      .Remove();
                Save();
            }
            return operationResult;

        }
        public XDocument ReadFile(string filename)
        {

            try
            {
                xDoc = XDocument.Load(filename);

            }
            catch
            {

            }
            return xDoc;
        }     
        public void Save()
        {
            xDoc.Save(strFile);

        }
        public OperationResult Remove(string voucherid)
        {
            try
            {
                xDoc = ReadFile(strFile);
                XElement currentTruck = xDoc.Descendants("Truck").Where(p => p.Element("VoucherID").Value == voucherid).FirstOrDefault();
                if (currentTruck != null)
                {
                    currentTruck.Remove();
                }
                xDoc.Save(strFile);
                operationResult.Success = true;
                operationResult.Message = "Success";
                operationResult.Caption = "OK";
            }
            catch (Exception ex)
            {
                operationResult.Success = false;
                operationResult.Message = "Error: " + ex.ToString();
                operationResult.Caption = "Error";
            }
            return operationResult;
        }
        public Truck FindUpdateStatus(string voucherid, string status)
        {
            _truck = new Truck();
            xDoc = ReadFile(strFile);
            XElement currentTruck = xDoc.Descendants("Truck").Where(p => p.Element("VoucherID").Value == voucherid && p.Element("Status").Value ==status).FirstOrDefault();
            if (currentTruck != null)
            {
                _truck.VoucherID = currentTruck.Element("VoucherID").Value;
                _truck.VehicleNO = currentTruck.Element("VehicleNO").Value;
                _truck.CheckInTime = currentTruck.Element("CheckInTime").Value;
                _truck.CheckOutTime = currentTruck.Element("CheckOutTime").Value;
                _truck.FirstWeight = decimal.Parse(currentTruck.Element("FirstWeight").Value);
                _truck.SecondWeight = decimal.Parse(currentTruck.Element("SecondWeight").Value);
                _truck.Note = currentTruck.Element("Note").Value;
                _truck.Status = currentTruck.Element("Status").Value;
            }

            return _truck;
        }
        public List<Truck> GetAllTrucks()
        {
           
            xDoc = ReadFile(strFile);
            List<XElement> currentTruck = xDoc.Descendants("Truck").ToList();
            List<Truck> ls = new List<Truck>();
            foreach(var i in currentTruck)
            {
                _truck = new Truck();
                if (currentTruck != null)
                {
                    _truck.VoucherID = i.Element("VoucherID").Value;
                    _truck.VehicleNO = i.Element("VehicleNO").Value;
                    _truck.CheckInTime = i.Element("CheckInTime").Value;
                    _truck.CheckOutTime = i.Element("CheckOutTime").Value;
                    _truck.FirstWeight = decimal.Parse(i.Element("FirstWeight").Value);
                    _truck.SecondWeight = decimal.Parse(i.Element("SecondWeight").Value);
                    _truck.Note = i.Element("Note").Value;
                    _truck.Status = i.Element("Status").Value;
                }
                else { _truck = null; }
                ls.Add(_truck);
            }

            return ls;
        }
        
    }
}
