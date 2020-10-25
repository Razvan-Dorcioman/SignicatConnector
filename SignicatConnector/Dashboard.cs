using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignicatConnector
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private async void submitButton_Click(object sender, EventArgs e)
        {
            var clientId = clientIdTextBox.Text;
            var clientSecret = clientSecretTextBox.Text;

            SignicatConnector connector = new SignicatConnector(clientId, clientSecret);

            var res = await connector.OpenDashboard();

            errorLabel.Visible = !res;
        }
    }
}
