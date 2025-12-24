using DatabaseManager;
using System.Windows.Forms;
using WindowsFormAppTemplate.Configuration;
using WindowsFormAppTemplate.Forms;

namespace WindowsFormAppTemplate
{
    public partial class FormMain : Form
    {
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
                string LogFilename = ConfigurationHandler.GetConfigurationValue("LogFilename");



            }
            catch (Exception ex)
            { }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
