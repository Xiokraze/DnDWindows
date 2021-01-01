using System.Drawing;
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
            // Update cell font styles.
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            dataGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel);

            if (control.Equals(DefaultValues.Armor))
            {
                UpdateArmorTable();
            }
            else if (control.Equals(DefaultValues.Art))
            {
                UpdateArtTable();
            }
            else if (control.Equals(DefaultValues.Gem))
            {
                UpdateGemTable();
            }
            else if (control.Equals(DefaultValues.Good))
            {
                UpdateGoodTable();
            }
            else if (control.Equals(DefaultValues.Weapon))
            {
                UpdateWeaponTable();
            }
            else if (control.Equals(DefaultValues.Trinket))
            {
                UpdateTrinketTable();
            }
        }


        private void UpdateArmorTable()
        {
            dataGridView.Columns.Add("Description", "Description");
            dataGridView.Columns.Add("Classification", "Classification");
            dataGridView.Columns.Add("Value", "Value");
            dataGridView.Columns.Add("ArmorClass", "AC");
            dataGridView.Columns.Add("RequiredStrength", "Strength");
            dataGridView.Columns.Add("StealthImpact", "Stealth");
            dataGridView.Columns.Add("Weight", "Weight");
            itemLists.armor.ForEach(item => 
            {
                string[] row = {
                    item.Description,
                    item.Classification,
                    item.Value,
                    item.ArmorClass,
                    item.RequiredStrength,
                    item.StealthImpact,
                    item.Weight
                };
                dataGridView.Rows.Add(row);
            });
        }


        private void UpdateArtTable()
        {
            dataGridView.Columns.Add("Description", "Description");
            dataGridView.Columns.Add("Classification", "Classification");
            dataGridView.Columns.Add("Value", "Value");
            itemLists.art.ForEach(item =>
            {
                string[] row = {
                    item.Description,
                    item.Classification,
                    item.Value
                };
                dataGridView.Rows.Add(row);
            });
        }


        private void UpdateGemTable()
        {
            dataGridView.Columns.Add("ItemName", "Name");
            dataGridView.Columns.Add("Description", "Description");
            dataGridView.Columns.Add("Classification", "Classification");
            dataGridView.Columns.Add("Value", "Value");
            itemLists.gems.ForEach(item =>
            {
                string[] row = {
                    item.ItemName,
                    item.Description,
                    item.Classification,
                    item.Value
                };
                dataGridView.Rows.Add(row);
            });
        }


        private void UpdateGoodTable()
        {
            dataGridView.Columns.Add("Description", "Description");
            dataGridView.Columns.Add("Classification", "Classification");
            dataGridView.Columns.Add("Value", "Value");
            dataGridView.Columns.Add("Weight", "Weight");
            itemLists.goods.ForEach(item =>
            {
                string[] row = {
                    item.Description,
                    item.Classification,
                    item.Value,
                    item.Weight
                };
                dataGridView.Rows.Add(row);
            });
        }


        private void UpdateTrinketTable()
        {
            dataGridView.Columns.Add("Description", "Description");
            dataGridView.Columns.Add("Classification", "Classification");
            itemLists.trinkets.ForEach(item =>
            {
                string[] row = {
                    item.Description,
                    item.Classification
                };
                dataGridView.Rows.Add(row);
            });
        }


        private void UpdateWeaponTable()
        {
            dataGridView.Columns.Add("Description", "Description");
            dataGridView.Columns.Add("Classification", "Classification");
            dataGridView.Columns.Add("Value", "Value");
            dataGridView.Columns.Add("Damage", "Damage");
            dataGridView.Columns.Add("Properties", "Properties");
            dataGridView.Columns.Add("Weight", "Weight");
            itemLists.weapons.ForEach(item =>
            {
                string[] row = {
                    item.Description,
                    item.Classification,
                    item.Value,
                    item.Damage,
                    item.Properties,
                    item.Weight
                };
                dataGridView.Rows.Add(row);
            });
        }
    }
}
