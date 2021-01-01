using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DnDDM.Classes;

namespace DnDDM.Controls
{
    public partial class StandardItemControl : UserControl
    {
        private readonly StandardItemLists itemLists = new StandardItemLists();
        public StandardItemControl(string control)
        {
            InitializeComponent();
            UpdateGUI(control);
        }


        private void UpdateGUI(string control)
        {
            if (control.Equals(DefaultValues.Armor))
            {
                UpdateArmorTable();
            }
        }


        private void UpdateArmorTable()
        {
            dataGridView.Columns.Add("Classification", "Classification");
            dataGridView.Columns.Add("Description", "Description");
            dataGridView.Columns.Add("Value", "Value");
            dataGridView.Columns.Add("ArmorClass", "AC");
            dataGridView.Columns.Add("RequiredStrength", "Strength");
            dataGridView.Columns.Add("StealthImpact", "Stealth");
            dataGridView.Columns.Add("Weight", "Weight");
            dataGridView.DataSource = itemLists.armor;
        }
    }
}
