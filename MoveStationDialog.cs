using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EliteDangerousTradingAssistant
{
    public partial class MoveStationDialog : Form
    {
        private GameData data;
        private StarSystem result;

        public StarSystem Result
        {
            get { return result; }
        }

        public MoveStationDialog(GameData data)
        {
            InitializeComponent();
            this.Icon = new Icon("Graphics\\EliteDangerousIcon.ico");
            result = null;

            foreach (StarSystem starSystem in data.StarSystems)
                comboBox1.Items.Add(starSystem.Name);

            this.data = data;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Please select a known system.", "Error: System name needed", MessageBoxButtons.OK);
                return;
            }

            var system = data.StarSystems.FirstOrDefault(i => i.Name == comboBox1.Text);
            if (system == null)
            {
                MessageBox.Show("Please select a known system.", "Error: System name needed", MessageBoxButtons.OK);
                return;
            }
            
            result = system;
            this.Close();
        }
    }
}
