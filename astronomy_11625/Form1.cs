using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace astronomy_11625
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void DataStore_SpaceObjectsChanged()
        {
            UpdateLSTBXs();
            //MessageBox.Show("Event fired");
        }

        private void button_new_so_Click(object sender, EventArgs e)
        {
            var frm = new soFRM();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //UpdateLSTBXs();
            }
        }

        private void UpdateLSTBXs()
        {
            listBox_space_objects.DataSource = null;
            listBox_space_objects.DataSource = DataStore.SpaceObjects;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataStore.LoadSpaceObjects();
            DataStore.SpaceObjectsChanged += DataStore_SpaceObjectsChanged;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CSV_Entity.WriteSpaceObjects();
            DataStore.SpaceObjectsChanged -= DataStore_SpaceObjectsChanged;
        }

        private void button_edit_so_Click(object sender, EventArgs e)
        {

            if (listBox_space_objects.SelectedIndex != -1 && listBox_space_objects.SelectedItem is SpaceObject selected)
            {
                var frm = new soFRM(selected);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    DataStore.SpaceObjects.Remove(selected);
                    DataStore.AddToSpaceObjects(frm.So);          
                }
            }
        }

        private void button_del_so_Click(object sender, EventArgs e)
        {
            if (listBox_space_objects.SelectedIndex != -1 && listBox_space_objects.SelectedItem is SpaceObject selected)
            {
                if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DataStore.RemoveFromSpaceObjects(selected);
                }
            }
            else
            {
                MessageBox.Show("Nothing has been selected!");
            }
        }
    }
}
