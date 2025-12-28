using DatabaseManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormAppTemplate.Configuration;

namespace WindowsFormAppTemplate.Forms
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            CustomInitialization();
            CenterToScreen();
        }

        private void CustomInitialization()
        {
            try
            {
                lblTitle.Text = ConfigurationHandler.GetConfigurationValue("Title");
                Icon AppIcon = new Icon(ConfigurationHandler.GetConfigurationValue("Icon"));
                if (AppIcon != null)
                {
                    this.Icon = AppIcon;
                }
                string _version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                txtVersion.Text = _version;
            }
            catch (Exception ex)
            {
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
