using DatabaseManager;
using System.Reflection;
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
                this.Icon = new Icon("Icons/computer_30842_32x32.ico");
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string _version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            DialogResult res = MessageBox.Show("Version: "+ _version, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
