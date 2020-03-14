using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class ManageItems : Form
    {
        public ManageItems()
        {
            InitializeComponent();

            dataAllItems.Rows.Clear();
            dataAllItems.DataSource = null;
            List<Item> c = new List<Item>();
            c = SqliteDataAccess.LoadAllItem();

            for (int i = 0; i < c.Count; i++)
            {
                if (dataAllItems.Rows.Count == i)
                {
                    dataAllItems.Rows.Add();
                }
                dataAllItems.Rows[i].Cells["itemNumber"].Value = c[i].Item_Number;
                dataAllItems.Rows[i].Cells["itemVendor"].Value = c[i].Vendor_ID;
                dataAllItems.Rows[i].Cells["itemDesc"].Value = c[i].Item_Description;
            }

            
        }
        List<Item> selectedItems = new List<Item>();
        private void BtSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            string itemNumber = (string)dataAllItems.Rows[dataAllItems.CurrentCell.RowIndex].Cells["itemNumber"].Value;
            int index = dataAllItems.CurrentCell.RowIndex;
            dataAllItems.Rows.RemoveAt(index);

            Item it = SqliteDataAccess.LoadItem(itemNumber)[0];

            selectedItems.Add(it);

            RefreshSelectedItems();
        }
        private void RefreshSelectedItems()
        {
            dataSelectedItems.Rows.Clear();
            dataSelectedItems.DataSource = null;

            List<Item> c = selectedItems;

            for (int i = 0; i < c.Count; i++)
            {
                if (dataSelectedItems.Rows.Count == i)
                {
                    dataSelectedItems.Rows.Add();
                }
                dataSelectedItems.Rows[i].Cells["sItemNumber"].Value = c[i].Item_Number;
                dataSelectedItems.Rows[i].Cells["sItemVendor"].Value = c[i].Vendor_ID;
                dataSelectedItems.Rows[i].Cells["sItemDesc"].Value = c[i].Item_Description;
            }
        }

        private void BtRemove_Click(object sender, EventArgs e)
        {
            string itemNumber = (string)dataSelectedItems.Rows[dataSelectedItems.CurrentCell.RowIndex].Cells["sItemNumber"].Value;
            int index = dataSelectedItems.CurrentCell.RowIndex;
            dataSelectedItems.Rows.RemoveAt(index);

            Item it = SqliteDataAccess.LoadItem(itemNumber)[0];
            Item RemoveExact = new Item();

            for(int i =0; i< selectedItems.Count; i++)
            {
                if(selectedItems[i].Item_Number == it.Item_Number)
                {
                    RemoveExact = selectedItems[i];
                    break;
                }
            }
            selectedItems.Remove(RemoveExact);
            RefreshSelectedItems();

            dataAllItems.Rows.Add();
            int lastRow = dataAllItems.Rows.GetLastRow(DataGridViewElementStates.Visible);

            dataAllItems.Rows[lastRow].Cells["itemNumber"].Value = RemoveExact.Item_Number;
            dataAllItems.Rows[lastRow].Cells["itemDesc"].Value = RemoveExact.Item_Description;
            dataAllItems.Rows[lastRow].Cells["itemVendor"].Value = RemoveExact.Vendor_ID;


        }
    }
}
