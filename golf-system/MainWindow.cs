using golf_system.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace golf_system
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void läggTillMedlemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bokaTidToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void visaBokningarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void databasinställningarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDatabaseSettings();
        }

        private static void openDatabaseSettings()
        {
            //Create database window and show it as a modal dialog
            var dbsettings_window = new DatabaseSettings();
            dbsettings_window.ShowDialog();
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Exit the application
            Application.Exit();
        }

        private void anslutTillDatabasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Simple check to see if all database conection info is provided
            if (!(
                Settings.Default["db_address"].ToString().Length < 1 ||
                Settings.Default["db_database"].ToString().Length < 1 ||
                Settings.Default["db_username"].ToString().Length < 1 ||
                Settings.Default["db_password"].ToString().Length < 1
                ))
            {
                //In case it is...
                //TODO Connect to database
            }
            else
            {
                //In case not
                MessageBox.Show("Saknar inställningar för att ansluta till databasen!",
                    "Inställnignar saknas");
                openDatabaseSettings();
            }
        }
    }
}
