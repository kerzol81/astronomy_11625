using System;
using System.Windows.Forms;
using System.Linq;

namespace astronomy_11625
{
    public partial class soFRM : Form
    {
        private SpaceObject so;

        internal SpaceObject So { get => so; /*set => so = value;*/ }
        public soFRM()
        {
            InitializeComponent();
            comboBox_material.DataSource = Enum.GetValues(typeof(Material));
            comboBox_crosses.Items.Add("yes");
            comboBox_crosses.Items.Add("no");
            comboBox_insolar.Items.Add("yes");
            comboBox_insolar.Items.Add("no");
            comboBox_material.SelectedIndex = 0;
            comboBox_crosses.SelectedIndex = 0;
            comboBox_insolar.SelectedIndex = 0;
        }

        internal soFRM(SpaceObject mod):this()
        {
            so = mod;
            textBox_name.Text = so.Name;
            numericUpDown_perimeter.Value = (decimal)so.Perimeter;
            comboBox_material.SelectedIndex = (int)so.Material;
            comboBox_crosses.SelectedIndex = so.CrossesEarthsOrbit? 0 : 1;
            comboBox_insolar.SelectedIndex = so.InSolarSystem ? 0 : 1;
            comboBox_insolar.Enabled = false;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (FormFilled())
            {
                if (so == null)
                {
                    so = new SpaceObject(textBox_name.Text, (double)numericUpDown_perimeter.Value, (Material)comboBox_material.SelectedIndex, Convert.ToBoolean(comboBox_crosses.SelectedIndex), Convert.ToBoolean(comboBox_insolar.SelectedIndex));
                    if (DataStore.SpaceObjects.Exists(x => x.Name == textBox_name.Text))
                    {
                        MessageBox.Show("Space Object already in the list", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);                      
                    }
                    else
                    {
                        DataStore.AddToSpaceObjects(so);
                    }                             
                }
            }
        }
        private bool FormFilled()
        {
            if (textBox_name.Text != "" && numericUpDown_perimeter.Value != 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Empty fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
                return false;
            }
        }
    }
}
