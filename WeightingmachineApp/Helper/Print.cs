using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeightingmachineApp.Contact;
using WeightingmachineApp.Implementation;
using WeightingmachineApp.Model;

namespace WeightingmachineApp.Helper
{
    public class Print
    {
        PrintDocument pDoc = new PrintDocument();
        public void PrintBill(bool isPaperPrint)
        {
            //isPaperPrint = true : Printing
            if (!isPaperPrint)
                return;

            if ((string)_Setting[0] == "H")
                pDoc.DefaultPageSettings.Landscape = true;

            pDoc.DefaultPageSettings.PaperSize = new PaperSize("Custom Size 1", Convert.ToInt32(_Setting[2].Trim()), Convert.ToInt32(_Setting[1].Trim()));
            pDoc.Print();
        }

        string _PonderationID = string.Empty;
        string _Type = string.Empty;
      
        Truck currentTruck = new Truck();

        private string[] _Setting;
        //Setting="Paper Type; Paper Height; Paper Width; IsPrintFrame; FrameX; FrameY; OrginX; OrginY";
        public string Setting
        {
            set
            {
                _Setting = value.Split(';');
            }
        }

        public Print(string PonderationID)
        {
            _PonderationID = PonderationID;

            ITruckDAL _truckDAL = new TruckDALService();
          
            currentTruck = _truckDAL.FindTruck(_PonderationID);
            this.pDoc.PrintPage += new PrintPageEventHandler(PrintWeightBill_FEPV);

        }
        public void PrintWeightBill_FEPV(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


            //Print Frame 
            if (Convert.ToBoolean(_Setting[3].Trim()))
                e.Graphics.DrawImage(Resource.Bill, Convert.ToInt32(_Setting[4].Trim()), Convert.ToInt32(_Setting[5].Trim()));

            Font font = new Font("Times New Roman", 12, FontStyle.Bold);
            Font fonttime = new Font("Times New Roman", 10, FontStyle.Bold);

            int x = Convert.ToInt32(_Setting[6].Trim()),//80
                y = Convert.ToInt32(_Setting[7].Trim());//90
            for (int i = 0; i < 3; i++)
            {
                e.Graphics.DrawString(currentTruck.CheckInTime.ToString(),
                    fonttime, Brushes.Black, x, y + 10);
                e.Graphics.DrawString(currentTruck.CheckOutTime.ToString(),
                    fonttime, Brushes.Black, x, y + 40);
                e.Graphics.DrawString(currentTruck.VehicleNO.ToString(),
                    font, Brushes.Black, x - 30, y + 65);
             
                e.Graphics.DrawString(currentTruck.FirstWeight.ToString() + " Kg",
                    font, Brushes.Black, x + 22, y + 230);
                e.Graphics.DrawString(currentTruck.SecondWeight.ToString() + " Kg",
                    font, Brushes.Black, x + 22, y + 260);
                //e.Graphics.DrawString(currentTruck.Note,
                //  font, Brushes.Black, x + 27, y + 330);      
                x += 286;
            }
            e.HasMorePages = false;

        }
    }
}
