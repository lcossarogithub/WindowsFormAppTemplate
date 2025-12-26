using DatabaseManager;
using System.Reflection;
using System.Windows.Forms;
using WindowsFormAppTemplate.Configuration;
using WindowsFormAppTemplate.Forms;

namespace WindowsFormAppTemplate
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// \brief FormMain constructor
        /// 
        /// FormMain constructor with custom initialization and center to screen command
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            CustomInitialization();
            CenterToScreen();
        }
        /// <summary>
        /// Custom initialization
        /// </summary>
        private void CustomInitialization()
        {
            try
            {
                this.Text = ConfigurationHandler.GetConfigurationValue("Title");
                Icon AppIcon = new Icon(ConfigurationHandler.GetConfigurationValue("Icon"));
                if (AppIcon != null) 
                {
                    this.Icon = AppIcon;
                }                                                
                string LogFilename = ConfigurationHandler.GetConfigurationValue("LogFilename");
            }
            catch (Exception ex)
            { }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
