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
        public List<SelectedItems> selected = new List<SelectedItems>();
        public ManageItems(List<SelectedItems> items)
        {
            InitializeComponent();

            dataAllItems.Rows.Clear();
            dataAllItems.DataSource = null;
            List<Item> c = SqliteDataAccess.LoadAllItem();

            if (items != null)
                selected = items;
            RefreshSelectedItems();

            for (int i = 0; i < c.Count; i++)
            {
                foreach (SelectedItems si in selected)
                {
                    if (c[i].Item_Number == si.Item_Number)
                        c.RemoveAt(i);
                }
            }


            for (int i = 0; i < c.Count; i++)
            {

                if (dataAllItems.Rows.Count == i)
                {
                    dataAllItems.Rows.Add();
                }
                Vendor ven = SqliteDataAccess.LoadVendor(c[i].Vendor_ID)[0];
                dataAllItems.Rows[i].Cells["itemNumber"].Value = c[i].Item_Number;
                dataAllItems.Rows[i].Cells["itemVendor"].Value = String.Format(c[i].Vendor_ID.ToString() + " - " + ven.Vendor_Name);
                dataAllItems.Rows[i].Cells["itemDesc"].Value = c[i].Item_Description;
            }

        }


        private void BtSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            string itemNumber = (string)dataAllItems.Rows[dataAllItems.CurrentCell.RowIndex].Cells["itemNumber"].Value;
            string itemDesc = SqliteDataAccess.LoadItem(itemNumber)[0].Item_Description;
            int itemVendorID = SqliteDataAccess.LoadItem(itemNumber)[0].Vendor_ID;
            int index = dataAllItems.CurrentCell.RowIndex;
            dataAllItems.Rows.RemoveAt(index);

            SelectedItems si = new SelectedItems();
            si.Item_Number = itemNumber;
            si.Item_Description = itemDesc;
            si.Vendor_ID = itemVendorID;

            selected.Add(si);
            RefreshSelectedItems();

            dataSelectedItems.CurrentCell = dataSelectedItems.Rows[dataSelectedItems.Rows.Count - 1].Cells["sItemQuantity"];
            dataSelectedItems.CurrentCell.Value = 0;
            dataSelectedItems.BeginEdit(true);
        }
        private void RefreshSelectedItems()
        {
            dataSelectedItems.Rows.Clear();
            dataSelectedItems.DataSource = null;

            List<SelectedItems> c = selected;

            for (int i = 0; i < c.Count; i++)
            {
                List<Item> items = SqliteDataAccess.LoadItem(c[i].Item_Number);
                if (dataSelectedItems.Rows.Count == i)
                {
                    dataSelectedItems.Rows.Add();
                }
                Vendor ven = SqliteDataAccess.LoadVendor(c[i].Vendor_ID)[0];
                dataSelectedItems.Rows[i].Cells["sItemNumber"].Value = c[i].Item_Number;
                dataSelectedItems.Rows[i].Cells["sItemVendor"].Value = String.Format(c[i].Vendor_ID.ToString() + " - " + ven.Vendor_Name);
                dataSelectedItems.Rows[i].Cells["sItemDesc"].Value = items[0].Item_Description;
                dataSelectedItems.Rows[i].Cells["sItemQuantity"].Value = c[i].Item_Quantity;
            }

        }

        private void BtRemove_Click(object sender, EventArgs e)
        {
            string itemNumber = (string)dataSelectedItems.Rows[dataSelectedItems.CurrentCell.RowIndex].Cells["sItemNumber"].Value;
            string itemDesc = SqliteDataAccess.LoadItem(itemNumber)[0].Item_Description;
            int itemVendorID = SqliteDataAccess.LoadItem(itemNumber)[0].Vendor_ID;

            int index = dataSelectedItems.CurrentCell.RowIndex;
            dataSelectedItems.Rows.RemoveAt(index);

            selected.RemoveAt(index);


            RefreshSelectedItems();

            dataAllItems.Rows.Add();
            int lastRow = dataAllItems.Rows.GetLastRow(DataGridViewElementStates.Visible);
            Vendor ven = SqliteDataAccess.LoadVendor(itemVendorID)[0];
            dataAllItems.Rows[lastRow].Cells["itemNumber"].Value = itemNumber;
            dataAllItems.Rows[lastRow].Cells["itemDesc"].Value = itemDesc;
            dataAllItems.Rows[lastRow].Cells["itemVendor"].Value = String.Format(itemVendorID.ToString() + " - " + ven.Vendor_Name);
        }
        private void dataSelectedItems_EndEdit(object sender, EventArgs e)
        {
            string itemNumber = (string)dataSelectedItems.Rows[dataSelectedItems.CurrentCell.RowIndex].Cells["sItemNumber"].Value;
            string itemDesc = SqliteDataAccess.LoadItem(itemNumber)[0].Item_Description;
            int itemVendorID = SqliteDataAccess.LoadItem(itemNumber)[0].Vendor_ID;
            int itemQuantity = Convert.ToInt32((dataSelectedItems.Rows[dataSelectedItems.CurrentCell.RowIndex].Cells["sItemQuantity"].Value));
            int dataIndex = dataSelectedItems.CurrentCell.RowIndex;

            SelectedItems si = new SelectedItems();
            si.Item_Number = itemNumber;
            si.Item_Description = itemDesc;
            si.Vendor_ID = itemVendorID;
            si.Item_Quantity = itemQuantity;

            selected.RemoveAt(dataIndex);
            selected.Insert(dataIndex, si);


        }
    }
}
