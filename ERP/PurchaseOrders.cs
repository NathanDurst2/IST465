using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using System.Linq;

namespace ERP
{
    public partial class PurchaseOrders : Form
    {
        List<Vendor> vendors = SqliteDataAccess.LoadAllVendor();
        List<PurchaseOrder_Item> selected = new List<PurchaseOrder_Item>();
        double cost = 0;
        string originType = "new";
        int originID = 0;
        public PurchaseOrders(PurchaseOrder po, string originType)
        {
            InitializeComponent();

            //Add vendors to the drop down list
            foreach (Vendor v in vendors)
            {
                comboVendor.Items.Add(String.Format("{0} - {1}", v.Vendor_ID, v.Vendor_Name));
            }

            if (originType == "edit")
            {
                originID = po.PO_ID;
                selected = SqliteDataAccess.LoadPurchaseOrder_Item(originID);
                this.originType = originType;

                comboVendor.SelectedIndex = comboVendor.FindString(po.Vendor_ID.ToString());
                tbShippingStreet.Text = po.PO_ShipStreet;
                tbShippingCity.Text = po.PO_ShipCity;
                tbShippingState.Text = po.PO_ShipState;
                tbShippingZip.Text = po.PO_ShipZip;
                vendorDatePicker.Value = DateTime.Parse(po.PO_ShipDate);

                double costed = 0;
                foreach (PurchaseOrder_Item poi in selected)
                {
                    dataSelected.Rows.Add();
                    dataSelected.Rows[dataSelected.RowCount - 1].Cells["sItem"].Value = poi.Item_Number;
                    dataSelected.Rows[dataSelected.RowCount - 1].Cells["sCost"].Value = poi.Item_Cost;
                    dataSelected.Rows[dataSelected.RowCount - 1].Cells["sQuantity"].Value = poi.Item_Quantity;
                    costed += poi.Item_Cost * poi.Item_Quantity;
                }
                tbSubTotal.Text = String.Format("$ " + Math.Round(costed, 2));
                tbTotalCost.Text = String.Format("$ " + Math.Round(costed * (1 + taxRate), 2));
                cost = costed;
            }
        }
        double taxRate = Convert.ToDouble(ConfigurationManager.AppSettings.Get("taxRate").ToString());
        private void comboVendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboVendor.SelectedItem.ToString() != "")
            {
                List<Item> items = SqliteDataAccess.LoadVendorItem(comboVendor.SelectedItem.ToString().Substring(0, comboVendor.SelectedItem.ToString().IndexOf(" - ")));
                for (int i = 0; i < items.Count; i++)
                {
                    bool inSelected = false;
                    foreach(PurchaseOrder_Item poi in selected)
                    {
                        if (poi.Item_Number == items[i].Item_Number)
                            inSelected = true;
                    }
                    if (inSelected == false)
                    {
                        dataAll.Rows.Add();
                        dataAll.Rows[dataAll.RowCount - 1].Cells["allItems"].Value = items[i].Item_Number;
                        dataAll.Rows[dataAll.RowCount - 1].Cells["allDesc"].Value = items[i].Item_Description;
                    }
                }

                if(originType == "new")
                {
                    tbShippingStreet.Text = ConfigurationManager.AppSettings.Get("purchaseOrderDefaultStreet").ToString();
                    tbShippingCity.Text = ConfigurationManager.AppSettings.Get("purchaseOrderDefaultCity").ToString();
                    tbShippingState.Text = ConfigurationManager.AppSettings.Get("purchaseOrderDefaultState").ToString();
                    tbShippingZip.Text = ConfigurationManager.AppSettings.Get("purchaseOrderDefaultZip").ToString();
                }
            }
        }
        private void dataSelected_CellEndEdit(object sender, EventArgs e)
        {
            try
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

                double costed = 0;
                foreach (PurchaseOrder_Item poi in selected)
                {
                    costed += poi.Item_Cost * poi.Item_Quantity;
                }
                tbSubTotal.Text = String.Format("$ " + Math.Round(costed, 2));
                tbTotalCost.Text = String.Format("$ " + Math.Round(costed * (1 + taxRate), 2));
                cost = costed;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid value entered - please try again");
                dataSelected.CurrentCell.Value = 0;
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            try
            {
                PurchaseOrder po = new PurchaseOrder();
                po.Vendor_ID = Convert.ToInt32(comboVendor.Text.Substring(0, comboVendor.Text.ToString().IndexOf(" - ")));
                po.PO_Date = DateTime.Today.ToShortDateString();
                po.PO_Subtotal = cost;
                po.PO_Total = cost * (1 + taxRate);
                po.PO_ShipDate = vendorDatePicker.Value.ToShortDateString();
                po.PO_ShipStreet = tbShippingStreet.Text;
                po.PO_ShipCity = tbShippingCity.Text;
                po.PO_ShipState = tbShippingState.Text;
                po.PO_ShipZip = tbShippingZip.Text;

                string id = "";
                if (originType == "new")
                    id = SqliteDataAccess.AddPurchaseOrder(po);
                else if (originType == "edit")
                {
                    SqliteDataAccess.EditPurchaseOrder(po);
                    SqliteDataAccess.DeletePurchaseOrder_Item(originID);
                    id = originID.ToString();
                }


                foreach (PurchaseOrder_Item siv in selected)
                {
                    siv.PO_ID = Convert.ToInt32(id);
                    SqliteDataAccess.AddPurchaseOrder_Item(siv);
                }
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Closing without saving");
            }

            this.Close();
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            if(dataAll.CurrentCell != null)
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
                //tbSubTotal.Text = String.Format("$ " + Math.Round(cost, 2));
                //tbTotalCost.Text = String.Format("$ " + Math.Round((cost * (1 + taxRate)), 2));
            }
            else
            {
                MessageBox.Show("Please select a row and try again");
            }
        }

        private void BtRemove_Click(object sender, EventArgs e)
        {
            if(dataSelected.CurrentCell != null)
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
            else
            {
                MessageBox.Show("Please select a row and try again");
            }

        }
    }
}
