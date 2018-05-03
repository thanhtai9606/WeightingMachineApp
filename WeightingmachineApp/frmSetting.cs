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
    public partial class frmSetting : Form
    {
        
        public string Gate { set; get; }
        public delegate void ReloadConfig(string cofig);
        public event ReloadConfig ConfigEvent;
        public frmSetting()
        {
            InitializeComponent();
            btnOK.Click += new EventHandler(btnOK_Click);
            btnCancel.Click += new EventHandler(btnCancel_Click);
            this.Load += new System.EventHandler(this.frmSetting_Load);
        }
        public void btnOK_Click(object sender, EventArgs e)
        {          
            var checkedButton = groupBox1.Controls.OfType<RadioButton>()
                                         .FirstOrDefault(r => r.Checked); //Load all Checkbox button and check where is the button checked!          
            Gate = checkedButton.Tag.ToString();      
            try
            {
                //Save value Gate into Config File
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                config.AppSettings.Settings["GATE"].Value = Gate;           
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                if(ConfigEvent !=null)
                {
                    ConfigEvent(Gate);
                    this.Close();      
                }                     
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
       
        private void btnCancel_Click(object sender, EventArgs e)
        {           
            this.Close();      
        }
        /// <summary>
        /// Load Gate into Checkbox is checked
        /// </summary>
        /// <param name="Gate"></param>
        /// <param name="Checkbox button is checked"></param>
        private void frmSetting_Load(object sender, EventArgs e)
        {          

            Gate = ConfigurationSettings.AppSettings["GATE"].ToString();
            var checkedButton = groupBox1.Controls.OfType<RadioButton>().ToList();

            foreach (var a in checkedButton)
            {
                if (a.Tag.ToString() == Gate)
                {
                    a.Checked = true;
                }
            }
        }    
    }
}
