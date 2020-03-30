using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ERP
{
    public partial class PurchaseOrders : Form
    {
        List<Vendor> vendors = SqliteDataAccess.LoadAllVendor();
        List<PurchaseOrder_Item> selected = new List<PurchaseOrder_Item>();
        public PurchaseOrders()
        {
            InitializeComponent();

            //Add vendors to the drop down list
            foreach (Vendor v in vendors)
            {
                comboVendor.Items.Add(String.Format("{0} - {1}", v.Vendor_ID, v.Vendor_Name));
            }
        }
        private void comboVendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboVendor.SelectedItem.ToString() != "")
            {
                List<Item> items = SqliteDataAccess.LoadVendorItem(comboVendor.SelectedItem.ToString().Substring(0, comboVendor.SelectedItem.ToString().IndexOf(" - ")));
                for (int i = 0; i < items.Count; i++)
                {
                    dataAll.Rows.Add();
                    dataAll.Rows[i].Cells["allItems"].Value = items[i].Item_Number;
                    dataAll.Rows[i].Cells["allDesc"].Value = items[i].Item_Description;
                }
            }
        }
        private void dataSelected_CellEndEdit(object sender, EventArgs e)
        {
            string itemNumber = (string)dataSelected.Rows[dataSelected.CurrentCell.RowIndex].Cells["sItem"].Value;
            double itemCost = Convert.ToDouble(dataSelected.Rows[dataSelected.CurrentCell.RowIndex].Cells["sCost"].Value);
            int itemQuantity = Convert.ToInt32(dataSelected.Rows[dataSelected.CurrentCell.RowIndex].Cells["sQuantity"].Value);
            int dataIndex = dataSelected.CurrentCell.RowIndex;

            PurchaseOrder_Item si = new PurchaseOrder_Item();
            si.Item_Number = itemNumber;
            si.Item_Quantity = itemQuantity;
            si.Item_Cost = itemCost;


            selected.RemoveAt(dataIndex);
            selected.Insert(dataIndex, si);

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            PurchaseOrder po = new PurchaseOrder();
            po.Vendor_ID = Convert.ToInt32(comboVendor.Text.Substring(0, comboVendor.Text.ToString().IndexOf(" - ")));
            po.PO_Date = DateTime.Today.ToShortDateString();
            po.PO_ShipDate = vendorDatePicker.Value.ToShortDateString();
            po.PO_ShipStreet = tbShippingStreet.Text;
            po.PO_ShipCity = tbShippingCity.Text;
            po.PO_ShipState = tbShippingState.Text;
            po.PO_ShipZip = tbShippingZip.Text;

            string id = SqliteDataAccess.AddPurchaseOrder(po);

            foreach(PurchaseOrder_Item siv in selected)
            {
                siv.PO_ID = Convert.ToInt32(id);
                SqliteDataAccess.AddPurchaseOrder_Item(siv);
            }

            this.Close();
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            string itemNumber = (string)dataAll.Rows[dataAll.CurrentCell.RowIndex].Cells["allItems"].Value;

            dataSelected.Rows.Add();
            dataSelected.Rows[dataSelected.RowCount - 1].Cells["sItem"].Value = itemNumber;
            dataSelected.Rows[dataSelected.RowCount - 1].Cells["sCost"].Value = SqliteDataAccess.LoadItem(itemNumber)[0].Item_PurchasePrice;

            dataAll.Rows.RemoveAt(dataAll.CurrentCell.RowIndex);


            PurchaseOrder_Item si = new PurchaseOrder_Item();
            si.Item_Number = itemNumber;
            si.Item_Cost = SqliteDataAccess.LoadItem(itemNumber)[0].Item_PurchasePrice;
            selected.Add(si);


            dataSelected.CurrentCell = dataSelected.Rows[dataSelected.Rows.Count - 1].Cells["sQuantity"];
            dataSelected.CurrentCell.Value = 0;
            dataSelected.BeginEdit(true);

        }

        private void BtRemove_Click(object sender, EventArgs e)
        {
            string Item_Number = (string)dataSelected.Rows[dataSelected.CurrentCell.RowIndex].Cells["sItem"].Value;
            int index = dataSelected.CurrentCell.RowIndex;


            dataSelected.Rows.RemoveAt(dataSelected.CurrentCell.RowIndex);

            Item items = SqliteDataAccess.LoadItem(Item_Number)[0];
            dataAll.Rows.Add();
            dataAll.Rows[dataAll.RowCount - 1].Cells["allItems"].Value = items.Item_Number;
            dataAll.Rows[dataAll.RowCount - 1].Cells["allDesc"].Value = items.Item_Description;

            selected.RemoveAt(index);
        }
    }
}
