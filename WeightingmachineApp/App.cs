
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeightingmachineApp
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Load();          
        }
        //void Load()
        //{
        //    //XtraTabbedMdiManager mdiManager = new XtraTabbedMdiManager();
        //    //mdiManager.MdiParent = this;
           
        //    //EGT egt = new EGT();
        //    //EGT egt2 = new EGT();
        //    //egt.MdiParent = this;
        //    //egt2.MdiParent = this;
        //    string gate = ConfigurationSettings.AppSettings["GATE"].ToString();
        //    switch (gate)
        //    {
        //        case "B":
        //            egt.Text = ConfigurationSettings.AppSettings["NAME1"].ToString();
        //            egt2.Text = ConfigurationSettings.AppSettings["NAME2"].ToString();
        //            // Comport
        //            egt.PORT.PortName = ConfigurationSettings.AppSettings["B_Truoc"].ToString();
        //            egt2.PORT.PortName = ConfigurationSettings.AppSettings["B_Sau"].ToString();

        //            break;
        //        case "N":
        //            egt.Text = ConfigurationSettings.AppSettings["NAME3"].ToString();
        //            egt2.Text = ConfigurationSettings.AppSettings["NAME4"].ToString();
        //            // Comport
        //            egt.PORT.PortName = ConfigurationSettings.AppSettings["N_Truoc"].ToString();
        //            egt2.PORT.PortName = ConfigurationSettings.AppSettings["N_Phai"].ToString();
        //            break;
        //        default:
        //            egt.Text = ConfigurationSettings.AppSettings["NAME1"].ToString();
        //            egt2.Text = ConfigurationSettings.AppSettings["NAME2"].ToString();
        //            // Comport
        //            egt.PORT.PortName = ConfigurationSettings.AppSettings["B_Truoc"].ToString();
        //            egt2.PORT.PortName = ConfigurationSettings.AppSettings["B_Sau"].ToString();
        //            break;
        //    }
        //    egt.Show();
        //    egt2.Show();
        //}
       
        void Load()
        {
            EGT egt = new EGT();
            EGT egt2 = new EGT();
         
            tabPage1.Controls.Add(egt);
            tabPage2.Controls.Add(egt2);
            string gate = ConfigurationSettings.AppSettings["GATE"].ToString();
            switch (gate)
            {
                case "B":
                    tabPage1.Text = ConfigurationSettings.AppSettings["NAME1"].ToString();
                    tabPage2.Text = ConfigurationSettings.AppSettings["NAME2"].ToString();
                    // Comport
                    egt.PORT.PortName = ConfigurationSettings.AppSettings["B_Truoc"].ToString();
                    egt2.PORT.PortName = ConfigurationSettings.AppSettings["B_Sau"].ToString();

                    break;
                case "N":
                    tabPage1.Text = ConfigurationSettings.AppSettings["NAME3"].ToString();
                    tabPage2.Text = ConfigurationSettings.AppSettings["NAME4"].ToString();
                    // Comport
                    egt.PORT.PortName = ConfigurationSettings.AppSettings["N_Truoc"].ToString();
                    egt2.PORT.PortName = ConfigurationSettings.AppSettings["N_Phai"].ToString();
                    break;
                default:
                    tabPage1.Text = ConfigurationSettings.AppSettings["NAME1"].ToString();
                    tabPage2.Text = ConfigurationSettings.AppSettings["NAME2"].ToString();
                    // Comport
                    egt.PORT.PortName = ConfigurationSettings.AppSettings["B_Truoc"].ToString();
                    egt2.PORT.PortName = ConfigurationSettings.AppSettings["B_Sau"].ToString();
                    break;
            }
            egt.Dock = DockStyle.Fill;
            egt2.Dock = DockStyle.Fill;
            egt.Show();
            egt2.Show();
        }
    }
}
