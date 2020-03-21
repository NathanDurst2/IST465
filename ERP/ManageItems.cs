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
            List<Item> c = new List<Item>();
            c = SqliteDataAccess.LoadAllItem();

            if(items != null)
                selected = items;
            RefreshSelectedItems();

            for(int i=0; i < c.Count; i++)
            {
                foreach(SelectedItems si in selected)
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
                dataAllItems.Rows[i].Cells["itemNumber"].Value = c[i].Item_Number;
                dataAllItems.Rows[i].Cells["itemVendor"].Value = c[i].Vendor_ID;
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
            string itemDesc = (string)dataAllItems.Rows[dataAllItems.CurrentCell.RowIndex].Cells["itemDesc"].Value;
            int itemVendorID = (int)dataAllItems.Rows[dataAllItems.CurrentCell.RowIndex].Cells["itemVendor"].Value;
            int index = dataAllItems.CurrentCell.RowIndex;
            dataAllItems.Rows.RemoveAt(index);

            SelectedItems si = new SelectedItems();
            si.Item_Number = itemNumber;
            si.Item_Description = itemDesc;
            si.Vendor_ID = itemVendorID;

            selected.Add(si);
            RefreshSelectedItems();

            dataSelectedItems.CurrentCell = dataSelectedItems.Rows[dataSelectedItems.Rows.Count-1].Cells["sItemQuantity"];
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
                    if (dataSelectedItems.Rows.Count == i)
                    {
                        dataSelectedItems.Rows.Add();
                    }
                    dataSelectedItems.Rows[i].Cells["sItemNumber"].Value = c[i].Item_Number;
                    dataSelectedItems.Rows[i].Cells["sItemVendor"].Value = c[i].Vendor_ID;
                    dataSelectedItems.Rows[i].Cells["sItemDesc"].Value = c[i].Item_Description;
                    dataSelectedItems.Rows[i].Cells["sItemQuantity"].Value = c[i].Item_Quantity;
                }
            
        }

        private void BtRemove_Click(object sender, EventArgs e)
        {
            string itemNumber = (string)dataSelectedItems.Rows[dataSelectedItems.CurrentCell.RowIndex].Cells["sItemNumber"].Value;
            string itemDesc = (string)dataSelectedItems.Rows[dataSelectedItems.CurrentCell.RowIndex].Cells["sItemDesc"].Value;
            int itemVendorID = (int)dataSelectedItems.Rows[dataSelectedItems.CurrentCell.RowIndex].Cells["sItemVendor"].Value;

            int index = dataSelectedItems.CurrentCell.RowIndex;
            dataSelectedItems.Rows.RemoveAt(index);

            selected.RemoveAt(index);

            
            RefreshSelectedItems();

            dataAllItems.Rows.Add();
            int lastRow = dataAllItems.Rows.GetLastRow(DataGridViewElementStates.Visible);

            dataAllItems.Rows[lastRow].Cells["itemNumber"].Value = itemNumber;
            dataAllItems.Rows[lastRow].Cells["itemDesc"].Value = itemDesc;
            dataAllItems.Rows[lastRow].Cells["itemVendor"].Value = itemVendorID;
        }
        private void dataSelectedItems_EndEdit(object sender, EventArgs e)
        {
            string itemNumber = (string)dataSelectedItems.Rows[dataSelectedItems.CurrentCell.RowIndex].Cells["sItemNumber"].Value;
            string itemDesc = (string)dataSelectedItems.Rows[dataSelectedItems.CurrentCell.RowIndex].Cells["sItemDesc"].Value;
            int itemVendorID = (int)dataSelectedItems.Rows[dataSelectedItems.CurrentCell.RowIndex].Cells["sItemVendor"].Value;
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
