using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OMNI_WMS_API_Demo;

namespace OMNI_WMS_API_Demo
{
    public partial class APIform : Form
    {
        public APIform()
        {
            InitializeComponent();
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.PartNumber = textPartNumber.Text;
            p.TypeCode = textTypeCode.Text;
            p.Description = textDescription.Text;
            if (textUnit.Text.Length > 0)
                p.Unit = textUnit.Text;
            if (chkRegBatch.Checked)
                p.RegBatch = 1;
            if (chkRegExpDate.Checked)
                p.RegExpDate = 1;
            if (chkRegSerial.Checked)
                p.RegSerial = 1;
            if (textProductCountGroup.Text.Length > 0)
                p.ProductCountGroup = textProductCountGroup.Text;
            if (textOriginCountry.Text.Length > 0)
                p.OriginCountry = textOriginCountry.Text;
            if (textCommodityCode.Text.Length > 0)
                p.CustomsCommodityCode = textCommodityCode.Text;

            if (textBarcode.Text.Length > 0)
            {
                Barcode[] obj = new Barcode[1];
                p.Barcodes = obj;
                p.Barcodes[0] = new Barcode();
                p.Barcodes[0].ProductBarcode = textBarcode.Text;
            }

            if (textPPQty.Text.Length > 0)
            {
                Productpacking[] obj2 = new Productpacking[1];
                p.ProductPackings = obj2;
                p.ProductPackings[0] = new Productpacking();

                if (!int.TryParse(textPPQty.Text, out int PPQty))
                    PPQty = 0;
                p.ProductPackings[0].Qty = PPQty;
                if (!int.TryParse(textPPWidth.Text, out int PPWidth))
                    PPWidth = 0;
                p.ProductPackings[0].Width_mm = PPWidth;
                if (!int.TryParse(textPPHeight.Text, out int PPHeight))
                    PPHeight = 0;
                p.ProductPackings[0].Height_mm = PPHeight;
                if (!int.TryParse(textPPDepth.Text, out int PPDepth))
                    PPDepth = 0;
                p.ProductPackings[0].Depth_mm = PPDepth;
                if (!int.TryParse(textPPVolume.Text, out int PPVolume))
                    PPVolume = 0;
                p.ProductPackings[0].Volume_cm3 = PPVolume;
                if (!int.TryParse(textPPWeight.Text, out int PPWeight))
                    PPWeight = 0;
                p.ProductPackings[0].Weight_g = PPWeight;
                p.ProductPackings[0].Barcode = textPPBarcode.Text;
                if (!int.TryParse(textPPShipDirect.Text, out int PPShipDirect))
                    PPShipDirect = 0;
                p.ProductPackings[0].ShipDirect = PPShipDirect;

                p.ProductPackings[0].PPT = textPPPPT.Text;
            }
            int r = APICreateMethods.ProductCreate(p, textAPIKey.Text, out string Errortxt);
            lblAPIReturnCode.Text = r.ToString() + " " + Errortxt;

        }

        
        private void btnCreateSalesOrder_Click(object sender, EventArgs e)
        {
            SalesOrder s = new SalesOrder();

            s.OrderNumber = textSOOrderNumber.Text;
            s.HostOrderNumber = textSOHostOrderNumber.Text;
            if (textSOOrderType.Text.Length > 0)
                s.OrderType = textSOOrderType.Text;
            if (textSOShippingProduct.Text.Length > 0)
                s.ShippingProduct = textSOShippingProduct.Text;
            s.OrderDate = dateTimeSOOrderDate.Value;
            s.ShipDate = dateTimeSOShipDate.Value;
            if (chkUrgent.Checked)
                s.Urgent = 1;
            s.PickInfo = textSOPickInfo.Text;
            s.PackInfo = textSOPackInfo.Text;
            s.OrderInfo = textSOOrderInfo.Text;
            s.Warehouse = textSOWarehouse.Text;
            // SHIP TO
            s.CustomerNumber = textSOCustomerNumber.Text;
            s.Name = textSOName.Text;
            s.Address1 = textSOAddress1.Text;
            s.Address2 = textSOAddress2.Text;
            s.ContactPerson = textSOContactPerson.Text;
            s.Phone = textSOPhone.Text;
            s.Email = textSOEmail.Text;
            s.Zip = textSOZip.Text;
            s.Province = textSOProvince.Text;
            s.State = textSOState.Text;
            s.Country = textSOCountry.Text;
            // BILL TO
            s.CustomerName = textSOName.Text;
            s.CustomerAddress1 = textSOCustomerAddress1.Text;
            s.CustomerAddress2 = textSOCustomerAddress2.Text;
            s.CustomerContactPerson = textSOCustomerContactPerson.Text;
            s.CustomerPhone = textSOCustomerPhone.Text;
            s.CustomerEmail = textSOCustomerEmail.Text;
            s.CustomerZip = textSOCustomerZip.Text;
            s.CustomerProvince = textSOCustomerProvince.Text;
            s.CustomerState = textSOCustomerState.Text;
            s.CustomerCountry = textSOCustomerCountry.Text;
            // SalesOrderLine
            if (textSOLProductPartNumber.Text.Length > 0 && textSOLLine.Text.Length > 0)
            {
                SalesOrderLine[] obj = new SalesOrderLine[1];
                s.SalesOrderLines = obj;
                s.SalesOrderLines[0] = new SalesOrderLine();

                if (!int.TryParse(textSOLLine.Text, out int SOLLine))
                    SOLLine = 0;
                s.SalesOrderLines[0].Line = SOLLine;
                s.SalesOrderLines[0].ProductPartNumber = textSOLProductPartNumber.Text;
                s.SalesOrderLines[0].Variant1 = textSOLVariant1.Text;
                s.SalesOrderLines[0].Variant2 = textSOLVariant2.Text;
                if (!int.TryParse(textSOLQTY.Text, out int SOLQTY))
                    SOLQTY = 0;
                s.SalesOrderLines[0].QTY = SOLQTY;
            }
            // Production
            if (textSOPProductPartNumber.Text.Length > 0)
            {
                SalesOrderProduction[] obj = new SalesOrderProduction[1];
                s.SalesOrderProduction = obj;
                s.SalesOrderProduction[0] = new SalesOrderProduction();

                s.SalesOrderProduction[0].ProductPartNumber = textSOPProductPartNumber.Text;
                s.SalesOrderProduction[0].Variant1 = textSOPVariant1.Text;
                s.SalesOrderProduction[0].Variant2 = textSOPVariant2.Text;
                if (!int.TryParse(textSOPQTY.Text, out int SOPQTY))
                    SOPQTY = 0;
                s.SalesOrderProduction[0].QTY = SOPQTY;
            }
            int r = APICreateMethods.SalesOrderCreate(s, textAPIKey.Text, out string Errortxt);
            lblAPIReturnCode.Text = r.ToString() + " " + Errortxt;

        }

        private void btnGetJSONTransactions_Click(object sender, EventArgs e)
        {

            WMSdata[] d;

            // Get the Number of transactions from the input field
            if (!int.TryParse(textNumOfTrans.Text, out int NumTrans))
                NumTrans = 1;

            // Get transactions from WMS
            int r = GetMethods.GetJSONTransactions(textAPIKey.Text,NumTrans, out d, out string Errortxt);
            // Show error code and message
            lblAPIReturnCode.Text = r.ToString() + " " + Errortxt;

            // Go through all the returned rows from WMS
            foreach (WMSdata data in d)
            {
                if (data.PCSYS_WMS_Export.ProductUpdate != null)
                {
                    txtTransactions.AppendText(Environment.NewLine + "ProductUpdate\t" + "O=" + data.PCSYS_WMS_Export.ProductUpdate.Owner + " PN="+ data.PCSYS_WMS_Export.ProductUpdate.PartNumber);
                }
                else if (data.PCSYS_WMS_Export.PurchaseOrderLineReceived != null)
                {
                    txtTransactions.AppendText(Environment.NewLine + "PurchaseOrderLineReceived\t" + "O=" + data.PCSYS_WMS_Export.PurchaseOrderLineReceived.Owner + " PN=" + data.PCSYS_WMS_Export.PurchaseOrderLineReceived.PartNumber + " Qty=" + data.PCSYS_WMS_Export.PurchaseOrderLineReceived.Qty+ " Erp=" + data.PCSYS_WMS_Export.PurchaseOrderLineReceived.ERPStoreName);
                }
                else if (data.PCSYS_WMS_Export.SalesOrderPicked != null)
                {
                    txtTransactions.AppendText(Environment.NewLine + "SalesOrderPicked\t" + "O=" + data.PCSYS_WMS_Export.SalesOrderPicked.Owner + "ON=" + data.PCSYS_WMS_Export.SalesOrderPicked.OrderNumber);
                    foreach (Salesorderpickedline SOLP in data.PCSYS_WMS_Export.SalesOrderPicked.SalesOrderPickedLine)
                        txtTransactions.AppendText(Environment.NewLine + "- SalesOrderPickedLine\t" + " PN=" + SOLP.PartNumber + " Qty=" + SOLP.Qty);
                }
                else if (data.PCSYS_WMS_Export.StockAdjustment != null)
                {
                    txtTransactions.AppendText(Environment.NewLine + "StockAdjustment\t" + data.PCSYS_WMS_Export.StockAdjustment.Owner);
                }
                else if (data.PCSYS_WMS_Export.SalesOrderPickedAndPacked != null)
                {
                    txtTransactions.AppendText(Environment.NewLine + "SalesOrderPickedAndPacked\t" + data.PCSYS_WMS_Export.SalesOrderPickedAndPacked.Owner);
                }
                else if (data.PCSYS_WMS_Export.ReturnOrderLineReceived != null)
                {
                    txtTransactions.AppendText(Environment.NewLine + "ReturnOrderLineReceived\t" + data.PCSYS_WMS_Export.ReturnOrderLineReceived.Owner);
                }
                else if (data.PCSYS_WMS_Export.ReturnOrderClosed != null)
                {
                    txtTransactions.AppendText(Environment.NewLine + "ReturnOrderClosed\t" + data.PCSYS_WMS_Export.ReturnOrderClosed.Owner);
                }
                else if (data.PCSYS_WMS_Export.PurchaseOrderClosed != null)
                {
                    txtTransactions.AppendText(Environment.NewLine + "PurchaseOrderClosed\t" + data.PCSYS_WMS_Export.PurchaseOrderClosed.Owner);
                }
                else if (data.PCSYS_WMS_Export.StockMove != null)
                {
                    txtTransactions.AppendText(Environment.NewLine + "StockMove\t" + data.PCSYS_WMS_Export.StockMove.Owner);
                }
                else
                {
                    txtTransactions.AppendText(Environment.NewLine + "Unhandled data");
                }



            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear textbox
            txtTransactions.Text = "";

        }

        private void btnSalesOrderCancel_Click(object sender, EventArgs e)
        {
            int r = APICreateMethods.SalesOrderCancelled(textSOOrderNumber.Text, textAPIKey.Text, out string Errortxt);
            lblAPIReturnCode.Text = r.ToString() + " " + Errortxt;
        }

        private void btnCreatePurchaseOrder_Click(object sender, EventArgs e)
        {
            PurchaseOrder po = new PurchaseOrder();

            po.PONumber = txtPONumber.Text;
            if (txtPOOrderType.Text.Length > 0)
                po.OrderType = txtPOOrderType.Text;
            po.ETA = dateTimePickerPOETA.Value;
            if (chkPOAllowCrossDock.Checked)
                po.AllowCrossDock= 1;
            po.Warehouse = txtPOWarehouse.Text;
            po.ExtReference = txtPOExtReference.Text;
            po.ReceiveInfo = txtPOReceiveInfo.Text;
            po.POReference = txtPOReference.Text;

            po.SupplierNumber = txtPOSupplierNumber.Text;
            po.Name = txtPOName.Text;
            po.Address1 = txtPOAddress1.Text;
            po.Address2 = txtPOAddress2.Text;
            po.ContactPerson = txtPOContactPerson.Text;
            po.Phone = txtPOPhone.Text;
            po.Email = txtPOEmail.Text;
            po.Zip = txtPOZip.Text;
            po.Province = txtPOProvince.Text;
            po.State = txtPOState.Text;
            po.Country = txtPOCountry.Text;
            // PurchaseOrderLine
            if (txtPOLProductPartNumber.Text.Length > 0 && txtPOLOrderLine.Text.Length > 0)
            {
                Purchaseorderline[] obj = new Purchaseorderline[1];
                po.PurchaseOrderLine = obj;
                po.PurchaseOrderLine[0] = new Purchaseorderline();

                if (!int.TryParse(txtPOLOrderLine.Text, out int POLLine))
                    POLLine = 0;
                po.PurchaseOrderLine[0].OrderLine = POLLine;
                po.PurchaseOrderLine[0].ProductPartNumber = txtPOLProductPartNumber.Text;
                po.PurchaseOrderLine[0].Variant1 = txtPOLVariant1.Text;
                po.PurchaseOrderLine[0].Variant2 = txtPOLVariant2.Text;
                if (!int.TryParse(txtPOLQTY.Text, out int POLQTY))
                    POLQTY = 0;
                po.PurchaseOrderLine[0].QTY = POLQTY;
                po.PurchaseOrderLine[0].ETA = dateTimePickerPOLETA.Value;
                po.PurchaseOrderLine[0].Description = txtPOLDescription.Text;
                if (txtPOLERPStore.Text.Length > 0)
                    po.PurchaseOrderLine[0].ERPStore = txtPOLERPStore.Text;

            }
            int r = APICreateMethods.PurchaseOrderCreate(po, textAPIKey.Text, out string Errortxt);
            lblAPIReturnCode.Text = r.ToString() + " " + Errortxt;

        }

        private void btnPurchaseOrderFinished_Click(object sender, EventArgs e)
        {
            int r = APICreateMethods.PurchaseOrderFinished(txtPONumber.Text, textAPIKey.Text, out string Errortxt);
            lblAPIReturnCode.Text = r.ToString() + " " + Errortxt;
        }

        private void btnReturnOrderCreate_Click(object sender, EventArgs e)
        {
            ReturnOrder ro = new ReturnOrder();

            ro.OrderNumber = txtROOrderNumber.Text;
            ro.OrgOrderNumber = txtROOrgOrderNumber.Text;
            ro.CustomerNumber = txtROCustomerNumber.Text;
            ro.ReturnDate = dateTimePickerROReturnDate.Value;
            if (txtROOrderType.Text.Length > 0)
                ro.OrderType = txtROOrderType.Text;
            ro.Warehouse = txtROWarehouse.Text;
            // ReturnOrderLine
            if (txtROLPartNumber.Text.Length > 0 && txtROLLine.Text.Length > 0)
            {
                ReturnOrderline[] obj = new ReturnOrderline[1];
                ro.ReturnOrderLine = obj;
                ro.ReturnOrderLine[0] = new ReturnOrderline();

                if (!int.TryParse(txtROLLine.Text, out int ROLLine))
                    ROLLine = 0;
                ro.ReturnOrderLine[0].Line = ROLLine;
                ro.ReturnOrderLine[0].PartNumber = txtROLPartNumber.Text;
                ro.ReturnOrderLine[0].Variant1 = txtROLVariant1.Text;
                ro.ReturnOrderLine[0].Variant2 = txtROLVariant2.Text;
                if (!int.TryParse(txtROLQTY.Text, out int ROLQTY))
                    ROLQTY = 0;
                ro.ReturnOrderLine[0].QTY = ROLQTY;
                ro.ReturnOrderLine[0].ExtReference = txtROLExtReference.Text;
                ro.ReturnOrderLine[0].CustomsReference = txtROLCustomsReference.Text;
                ro.ReturnOrderLine[0].ReturnDescription = txtROLReturnDescription.Text;
            }
            int r = APICreateMethods.ReturnOrderCreate(ro, textAPIKey.Text, out string Errortxt);
            lblAPIReturnCode.Text = r.ToString() + " " + Errortxt;

        }
    }
}
