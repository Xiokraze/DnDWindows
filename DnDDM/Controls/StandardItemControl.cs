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
    }
}
