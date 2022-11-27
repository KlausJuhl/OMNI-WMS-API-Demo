using System;
using System.Text.Json;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Formatting = Newtonsoft.Json.Formatting;
using RestSharp.Serializers.Json;
using System.Numerics;

namespace OMNI_WMS_API_Demo
{


    public class Product
    {
        public string PartNumber { get; set; }
        public string Variant1 { get; set; }
        public string Variant2 { get; set; }
        public string TypeCode { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public int Width_mm { get; set; }
        public int Height_mm { get; set; }
        public int Depth_mm { get; set; }
        public int Volume_cm3 { get; set; }
        public int Weight_g { get; set; }
        public int NetWeight_g { get; set; }

        public int RegBatch { get; set; }
        public int RegExpDate { get; set; }
        public int RegSerial { get; set; }
        public int BulkQty { get; set; }

        public string ProductGroup1 { get; set; }
        public string ProductGroup2 { get; set; }
        public string ProductGroup3 { get; set; }
        public string ProductCountGroup { get; set; }
        public string SupplierNumber { get; set; }
        public string ProductABCcode { get; set; }
        public int AllowNewBarcode { get; set; }
        public string ProductPlacement { get; set; }

        public float Price { get; set; }
        public string Currency { get; set; }
        public string Description2 { get; set; }
        public string ExtReference { get; set; }
        public int Inactive { get; set; }
        public int AutoBatch { get; set; }
        public string OriginCountry { get; set; }
        public string CustomsCommodityCode { get; set; }
        public int Fragile { get; set; }
        public string StyleNumber { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public string ColorCode { get; set; }
        public string Quality { get; set; }
        public string SeasonBrand { get; set; }
        public string Material { get; set; }
        public string MaterialComposition { get; set; }
        public string ProductPictureURL { get; set; }
        public string Gender { get; set; }
        public string Manufacturer { get; set; }
        public string ManufacturerAddress { get; set; }
        public string ManufacturerPostalCode { get; set; }
        public string ManufacturerCity { get; set; }
        public string Constuction { get; set; }
        public Barcode[] Barcodes { get; set; }
        public Productpacking[] ProductPackings { get; set; }
        public Productcertificate[] ProductCertificates { get; set; }
    }

    public class Barcode
    {
        public string ProductBarcode { get; set; }
    }

    public class Productpacking
    {
        public int Qty { get; set; }
        public int Width_mm { get; set; }
        public int Height_mm { get; set; }
        public int Depth_mm { get; set; }
        public int Volume_cm3 { get; set; }
        public int Weight_g { get; set; }
        public string Barcode { get; set; }
        public int ShipDirect { get; set; }
        public string Unit { get; set; }
        public string PPT { get; set; }
        public int CustomField1 { get; set; }
        public int WeightTolerancePct { get; set; }


    }

    public class Productcertificate
    {
        public string CertificateName { get; set; }
    }

    public class SalesOrder
    {
        public string OrderNumber { get; set; }
        public string HostOrderNumber { get; set; }
        public string OrderType { get; set; }
        public string CustomerNumber { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string ContactPerson { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Language { get; set; }
        public string ShippingProduct { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShipDate { get; set; }
        public int Urgent { get; set; }
        public string PickInfo { get; set; }
        public string PackInfo { get; set; }
        public string OrderInfo { get; set; }
        public string Warehouse { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress1 { get; set; }
        public string CustomerAddress2 { get; set; }
        public string CustomerAddress3 { get; set; }
        public string CustomerAddress4 { get; set; }
        public string CustomerContactPerson { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerZip { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerProvince { get; set; }
        public string CustomerState { get; set; }
        public string CustomerCountry { get; set; }
        public string DropPointID { get; set; }
        public string DropPointName { get; set; }
        public string DropPointAddress1 { get; set; }
        public string DropPointAddress2 { get; set; }
        public string DropPointZip { get; set; }
        public string DropPointCity { get; set; }
        public string DropPointCountry { get; set; }
        public SalesOrderLine[] SalesOrderLines { get; set; }
        public SalesOrderProduction[] SalesOrderProduction { get; set; }
        public string VATNumber { get; set; }
        public string CustomerVATNumber { get; set; }
        //Customs invoice
        public string InvoiceNumber { get; set; }
        public int PrintInvoice { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string CurrencyShortName { get; set; }
        public double FreightCosts { get; set; }
        public int Insurance { get; set; }
        public double MiscCharges { get; set; }
        public double Discount { get; set; }
        public double Other_Fee { get; set; }



    }

    public class SalesOrderLine
    {
        public BigInteger Line { get; set; }
        public string ProductPartNumber { get; set; }
        public string Variant1 { get; set; }
        public string Variant2 { get; set; }
        public int QTY { get; set; }
    }

    public class SalesOrderProduction
    {
        public string ProductPartNumber { get; set; }
        public string Variant1 { get; set; }
        public string Variant2 { get; set; }
        public int QTY { get; set; }
    }
    public class SalesOrderCancelled
    {
        public string OrderNumber { get; set; }

    }

    public class PurchaseOrder
    {
        public string PONumber { get; set; }
        public string SupplierNumber { get; set; }
        public string OrderType { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string ContactPerson { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string POBox { get; set; }
        public string POBoxCode { get; set; }
        public string POCity { get; set; }
        public DateTime ETA { get; set; }
        public string Warehouse { get; set; }
        public int AllowCrossDock { get; set; }
        public string ExtReference { get; set; }
        public string ReceiveInfo { get; set; }
        public string POReference { get; set; }
        public Purchaseorderline[] PurchaseOrderLine { get; set; }


    }

    public class Purchaseorderline
    {
        public int OrderLine { get; set; }
        public string ProductPartNumber { get; set; }
        public string Variant1 { get; set; }
        public string Variant2 { get; set; }
        public int QTY { get; set; }
        public DateTime ETA { get; set; }
        public string ReserveHostOrderNumber { get; set; }
        public int ReserveLine { get; set; }
        public string Description { get; set; }
        public string BatchNumber { get; set; }
        public string HostPONumber { get; set; }
        public string HostLine { get; set; }
        public string Extendedref { get; set; }
        public string QAText { get; set; }
        public string PrintInfoLine1 { get; set; }
        public string PrintInfoLine2 { get; set; }
        public string PrintInfoLine3 { get; set; }
        public string PrintInfoLine4 { get; set; }
        public string PrintInfoLine5 { get; set; }
        public string PrintInfoLine6 { get; set; }
        public string PrintInfoLine7 { get; set; }
        public string PrintInfoLine8 { get; set; }
        public string ERPStore { get; set; }
    }

    public class ReturnOrder
    {
        public string OrderNumber { get; set; }
        public string OrgOrderNumber { get; set; }
        public string CustomerNumber { get; set; }
        public DateTime ReturnDate { get; set; }
        public string OrderType { get; set; }
        public string Warehouse { get; set; }
        public string AutoReceiveBarcode { get; set; }
        public ReturnOrderline[] ReturnOrderLine { get; set; }


    }

    public class ReturnOrderline
    {
        public int Line { get; set; }
        public int OrgLine { get; set; }
        public string PartNumber { get; set; }
        public string Variant1 { get; set; }
        public string Variant2 { get; set; }
        public int QTY { get; set; }
        public string ExtReference { get; set; }
        public string CustomsReference { get; set; }
        public string ReturnDescription { get; set; }

    }



    public class WMSResponse
    {
        public bool Success { get; set; }
        public int ErrorCode { get; set; }
        public string Message { get; set; }
        public WMSdata[] Data { get; set; }
    }

    public class WMSdata
    {
        public PCSYS_WMS_Export PCSYS_WMS_Export { get; set; }
    }

    public class PCSYS_WMS_Export
    {
        public Purchaseorderlinereceived PurchaseOrderLineReceived { get; set; }
        public Productupdate ProductUpdate { get; set; }
        public Salesorderpicked SalesOrderPicked { get; set; }
        public Stockadjustment StockAdjustment { get; set; }
        public Salesorderpickedandpacked SalesOrderPickedAndPacked { get; set; }
        public Returnorderlinereceived ReturnOrderLineReceived { get; set; }
        public Returnorderclosed ReturnOrderClosed { get; set; }
        public Purchaseorderclosed PurchaseOrderClosed { get; set; }
        public Stockmove StockMove { get; set; }

    }

    public class Purchaseorderlinereceived
    {
        public string Owner { get; set; }
        public string StockContainerCode { get; set; }
        public string OrderNumber { get; set; }
        public string OrderLine { get; set; }
        public string PartNumber { get; set; }
        public string Variant1 { get; set; }
        public string Variant2 { get; set; }
        public int Qty { get; set; }
        public string ERPStoreName { get; set; }
        public string PurchaseOrderTypeHostCode { get; set; }
        public string ExtReference { get; set; }
        public string Batch { get; set; }
        public string POCompleted { get; set; }
        public string Lot { get; set; }
        public string ContainerBarcode { get; set; }
        public string ContainerType { get; set; }
        public string Unit { get; set; }
        public string StyleNumber { get; set; }
    }


    public class Productupdate
    {
        public string Owner { get; set; }
        public string PartNumber { get; set; }
        public string Variant1 { get; set; }
        public string Variant2 { get; set; }
        public int Width_mm { get; set; }
        public int Height_mm { get; set; }
        public int Depth_mm { get; set; }
        public int Volume_cm3 { get; set; }
        public int Weight_g { get; set; }
        public Productbarcodes ProductBarcodes { get; set; }
    }

    public class Productbarcodes
    {
        public object Barcode { get; set; }
    }

    public class Salesorderpicked
    {
        public string PickTime { get; set; }
        public string Owner { get; set; }
        public string CustomerNumber { get; set; }
        public string HostOrderNumber { get; set; }
        public string OrderNumber { get; set; }
        public string Reference { get; set; }
        public Salesorderpickedline[] SalesOrderPickedLine { get; set; }
    }

    public class Salesorderpickedline
    {
        public string OrderLine { get; set; }
        public string PartNumber { get; set; }
        public string Variant1 { get; set; }
        public string Variant2 { get; set; }
        public int Qty { get; set; }
        public string TypeCode { get; set; }
        public string ERPStoreName { get; set; }
        public string Batch { get; set; }
        public Serialnumbers SerialNumbers { get; set; }
    }

    public class Serialnumbers
    {
        public object SerialNumber { get; set; }
    }

    public class Stockadjustment
    {
        public string Owner { get; set; }
        public string PartNumber { get; set; }
        public string Variant1 { get; set; }
        public string Variant2 { get; set; }
        public string Barcode { get; set; }
        public int Qty { get; set; }
        public string ERPStoreName { get; set; }
        public string ReasonCode { get; set; }
        public string ReasonDescription { get; set; }
        public string Batch { get; set; }
        public string Lot { get; set; }
        public string ContainerBarcode { get; set; }
        public string StyleNumber { get; set; }
    }

    public class Salesorderpickedandpacked
    {
        public string Owner { get; set; }
        public string CustomerNumber { get; set; }
        public string HostOrderNumber { get; set; }
        public string OrderNumber { get; set; }
        public string TrackingURL { get; set; }
        public string ReturnTrackingNumber { get; set; }
        public string ReturnTrackingURL { get; set; }
        public Salesorderpickedandpackedline[] SalesOrderPickedAndPackedLine { get; set; }
    }

    public class Salesorderpickedandpackedline
    {
        public string OrderLine { get; set; }
        public string PartNumber { get; set; }
        public string Variant1 { get; set; }
        public string Variant2 { get; set; }
        public string TrackAndTraceBarcode { get; set; }
        public int Qty { get; set; }
        public string TypeCode { get; set; }
        public string ERPStoreName { get; set; }
        public string Batch { get; set; }
        public string PackageNo { get; set; }
        public string Lot { get; set; }
        public string TrackingURL { get; set; }
        public string PickedContainerBarcode { get; set; }
        public string ExtReference { get; set; }
        public string ReturnTrackingNumber { get; set; }
        public string ReturnTrackingURL { get; set; }
        public Serialnumbers1 SerialNumbers { get; set; }
    }

    public class Serialnumbers1
    {
        public object SerialNumber { get; set; }
    }

    public class Returnorderlinereceived
    {
        public string Owner { get; set; }
        public string OrderNumber { get; set; }
        public string OrderLine { get; set; }
        public string ReturnDate { get; set; }
        public string PartNumber { get; set; }
        public string Variant1 { get; set; }
        public string Variant2 { get; set; }
        public int Qty { get; set; }
        public string ERPStoreName { get; set; }
        public string ReasonCode { get; set; }
        public string ReasonDescription { get; set; }
        public string Batch { get; set; }
    }

    public class Returnorderclosed
    {
        public string Owner { get; set; }
        public string CustomerNumber { get; set; }
        public string OrderNumber { get; set; }
        public string ReturnDate { get; set; }
        public string Reference { get; set; }
        public string Warehouse { get; set; }
        public string OrgOrderNumber { get; set; }
        public string OrderType { get; set; }
        public Returnorderclosedline[] ReturnOrderClosedLine { get; set; }
    }

    public class Returnorderclosedline
    {
        public string OrderLine { get; set; }
        public string PartNumber { get; set; }
        public string Variant1 { get; set; }
        public string Variant2 { get; set; }
        public int Qty { get; set; }
        public string TypeCode { get; set; }
        public string ERPStoreName { get; set; }
        public string Batch { get; set; }
        public string ReasonCode { get; set; }
    }

    public class Purchaseorderclosed
    {
        public string Owner { get; set; }
        public string OrderNumber { get; set; }
    }

    public class Stockmove
    {
        public string Owner { get; set; }
        public string HostOrderNumber { get; set; }
        public string OrderNumber { get; set; }
        public string PartNumber { get; set; }
        public string Variant1 { get; set; }
        public string Variant2 { get; set; }
        public string Barcode { get; set; }
        public int Qty { get; set; }
        public string FromERPStoreName { get; set; }
        public string ToERPStoreName { get; set; }
        public string Batch { get; set; }
    }

    
    public class APICreateMethods
    {
        public static int ProductCreate(Product p, string APIURL, string APIKey, out string ErrorText)
        {
            int ErrorCode = 0;
            ErrorText = "";
            RestRequest request;

            var client = new RestClient(APIURL)
            .AddDefaultHeader("Content-Type", "application/json");

            // Serialize with default class property names - to avoid camelCase 
            client.UseSystemTextJson(new JsonSerializerOptions(JsonSerializerDefaults.General));

            try
            {
                Console.WriteLine("Create Product " + p.PartNumber);

                request = new RestRequest("ProductCreate?APIKey=" + APIKey, Method.Post)
                .AddJsonBody(p);
                var r = client.Execute(request);
                WMSResponse response = System.Text.Json.JsonSerializer.Deserialize<WMSResponse>(r.Content);

                if (r.IsSuccessful)
                {
                    if (response.ErrorCode != 0)
                    {
                        Console.WriteLine("POST ProductCreate failed: " + response.ErrorCode + " " + response.Message);
                        ErrorText = response.Message;
                        ErrorCode = response.ErrorCode;
                    }
                    else
                    {
                        Console.WriteLine("POST ProductCreate success ");
                        ErrorText = response.Message;
                        ErrorCode = response.ErrorCode;
                    }
                }
                else
                {
                    Console.WriteLine("POST ProductCreate failed: " + r.Content);
                    ErrorText = r.Content;
                    ErrorCode = 98;
                }

                return ErrorCode;

            }
            catch (Exception ex)
            {
                Console.WriteLine("POST ProductCreate failed:, {0}", ex);
                ErrorText = ex.Message;
                return 99;
            }
        }
        public static int SalesOrderCreate(SalesOrder s, string APIURL, string APIKey, out string ErrorText)
        {
            int ErrorCode = 0;
            ErrorText = "";
            RestRequest request;

            var client = new RestClient(APIURL)
            .AddDefaultHeader("Content-Type", "application/json");

            // Serialize with default class property names - to avoid camelCase 
            client.UseSystemTextJson(new JsonSerializerOptions(JsonSerializerDefaults.General));

            try
            {
                Console.WriteLine("Create SalesOrder " + s.OrderNumber);

                request = new RestRequest("SalesOrderCreate?APIKey=" + APIKey, Method.Post)
                .AddJsonBody(s);
                var r = client.Execute(request);
                WMSResponse response = System.Text.Json.JsonSerializer.Deserialize<WMSResponse>(r.Content);

                if (r.IsSuccessful)
                {
                    if (response.ErrorCode != 0)
                    {
                        Console.WriteLine("POST SalesOrderCreate failed: " + response.ErrorCode + " " + response.Message);
                        ErrorText = response.Message;
                        ErrorCode = response.ErrorCode;
                    }
                    else
                    {
                        Console.WriteLine("POST SalesOrderCreate success ");
                        ErrorText = response.Message;
                        ErrorCode = response.ErrorCode;
                    }
                }
                else
                {
                    Console.WriteLine("POST SalesOrderCreate failed: " + r.Content);
                    ErrorText = r.Content;
                    ErrorCode = 98;
                }

                return ErrorCode;

            }
            catch (Exception ex)
            {
                Console.WriteLine("POST SalesOrderCreate failed:, {0}", ex);
                ErrorText = ex.Message;
                return 99;
            }
        }
        public static int SalesOrderCancelled(string SalesOrderNumber, string APIURL, string APIKey, out string ErrorText)
        {
            int ErrorCode = 0;
            ErrorText = "";
            RestRequest request;

            var client = new RestClient(APIURL)
            .AddDefaultHeader("Content-Type", "application/json");

            // Serialize with default class property names - to avoid camelCase 
            client.UseSystemTextJson(new JsonSerializerOptions(JsonSerializerDefaults.General));

            try
            {
                Console.WriteLine("Cancel SalesOrder " + SalesOrderNumber);

                request = new RestRequest("SalesOrderCanceled?APIKey=" + APIKey + "&orderNumber=" + SalesOrderNumber, Method.Post);

                var r = client.Execute(request);
                WMSResponse response = System.Text.Json.JsonSerializer.Deserialize<WMSResponse>(r.Content);

                if (r.IsSuccessful)
                {
                    if (response.ErrorCode != 0)
                    {
                        Console.WriteLine("POST Cancel SalesOrder failed: " + response.ErrorCode + " " + response.Message);
                        ErrorText = response.Message;
                        ErrorCode = response.ErrorCode;
                    }
                    else
                    {
                        Console.WriteLine("POST Cancel SalesOrder success ");
                        ErrorText = response.Message;
                        ErrorCode = response.ErrorCode;
                    }
                }
                else
                {
                    Console.WriteLine("POST Cancel SalesOrder failed: " + r.Content);
                    ErrorText = r.Content;
                    ErrorCode = 98;
                }

                return ErrorCode;

            }
            catch (Exception ex)
            {
                Console.WriteLine("POST Cancel SalesOrder failed:, {0}", ex);
                ErrorText = ex.Message;
                return 99;
            }
        }
        public static int PurchaseOrderCreate(PurchaseOrder p, string APIURL, string APIKey, out string ErrorText)
        {
            int ErrorCode = 0;
            ErrorText = "";
            RestRequest request;

            var client = new RestClient(APIURL)
            .AddDefaultHeader("Content-Type", "application/json");

            // Serialize with default class property names - to avoid camelCase 
            client.UseSystemTextJson(new JsonSerializerOptions(JsonSerializerDefaults.General));

            try
            {
                Console.WriteLine("Create PurchaseOrder " + p.PONumber);

                request = new RestRequest("PurchaseOrderCreate?APIKey=" + APIKey, Method.Post)
                .AddJsonBody(p);
                var r = client.Execute(request);
                WMSResponse response = System.Text.Json.JsonSerializer.Deserialize<WMSResponse>(r.Content);

                if (r.IsSuccessful)
                {
                    if (response.ErrorCode != 0)
                    {
                        Console.WriteLine("POST PurchaseOrderCreate failed: " + response.ErrorCode + " " + response.Message);
                        ErrorText = response.Message;
                        ErrorCode = response.ErrorCode;
                    }
                    else
                    {
                        Console.WriteLine("POST PurchaseOrderCreate success ");
                        ErrorText = response.Message;
                        ErrorCode = response.ErrorCode;
                    }
                }
                else
                {
                    Console.WriteLine("POST PurchaseOrderCreate failed: " + r.Content);
                    ErrorText = r.Content;
                    ErrorCode = 98;
                }

                return ErrorCode;

            }
            catch (Exception ex)
            {
                Console.WriteLine("POST PurchaseOrderCreate failed:, {0}", ex);
                ErrorText = ex.Message;
                return 99;
            }
        }
        public static int PurchaseOrderFinished(string PONumber, string APIURL, string APIKey, out string ErrorText)
        {
            int ErrorCode = 0;
            ErrorText = "";
            RestRequest request;

            var client = new RestClient(APIURL)
            .AddDefaultHeader("Content-Type", "application/json");

            // Serialize with default class property names - to avoid camelCase 
            client.UseSystemTextJson(new JsonSerializerOptions(JsonSerializerDefaults.General));

            try
            {
                Console.WriteLine("Cancel Purchase " + PONumber);

                request = new RestRequest("PurchaseOrderFinished?APIKey=" + APIKey + "&PONumber=" + PONumber, Method.Post);

                var r = client.Execute(request);
                WMSResponse response = System.Text.Json.JsonSerializer.Deserialize<WMSResponse>(r.Content);

                if (r.IsSuccessful)
                {
                    if (response.ErrorCode != 0)
                    {
                        Console.WriteLine("POST PurchaseOrderFinished failed: " + response.ErrorCode + " " + response.Message);
                        ErrorText = response.Message;
                        ErrorCode = response.ErrorCode;
                    }
                    else
                    {
                        Console.WriteLine("POST PurchaseOrderFinished success ");
                        ErrorText = response.Message;
                        ErrorCode = response.ErrorCode;
                    }
                }
                else
                {
                    Console.WriteLine("POST PurchaseOrderFinished failed: " + r.Content);
                    ErrorText = r.Content;
                    ErrorCode = 98;
                }

                return ErrorCode;

            }
            catch (Exception ex)
            {
                Console.WriteLine("POST PurchaseOrderFinished failed:, {0}", ex);
                ErrorText = ex.Message;
                return 99;
            }
        }
        public static int ReturnOrderCreate(ReturnOrder ro, string APIURL, string APIKey, out string ErrorText)
        {
            int ErrorCode = 0;
            ErrorText = "";
            RestRequest request;

            var client = new RestClient(APIURL)
            .AddDefaultHeader("Content-Type", "application/json");

            // Serialize with default class property names - to avoid camelCase 
            client.UseSystemTextJson(new JsonSerializerOptions(JsonSerializerDefaults.General));

            try
            {
                Console.WriteLine("Create ReturnOrder " + ro.OrderNumber);

                request = new RestRequest("ReturnOrderCreate?APIKey=" + APIKey, Method.Post)
                .AddJsonBody(ro);
                var r = client.Execute(request);
                WMSResponse response = System.Text.Json.JsonSerializer.Deserialize<WMSResponse>(r.Content);

                if (r.IsSuccessful)
                {
                    if (response.ErrorCode != 0)
                    {
                        Console.WriteLine("POST ReturnOrderCreate failed: " + response.ErrorCode + " " + response.Message);
                        ErrorText = response.Message;
                        ErrorCode = response.ErrorCode;
                    }
                    else
                    {
                        Console.WriteLine("POST ReturnOrderCreate success ");
                        ErrorText = response.Message;
                        ErrorCode = response.ErrorCode;
                    }
                }
                else
                {
                    Console.WriteLine("POST ReturnOrderCreate failed: " + r.Content);
                    ErrorText = r.Content;
                    ErrorCode = 98;
                }

                return ErrorCode;

            }
            catch (Exception ex)
            {
                Console.WriteLine("POST ReturnOrderCreate failed:, {0}", ex);
                ErrorText = ex.Message;
                return 99;
            }
        }
    }


    public class GetMethods
    {
        public static int GetJSONTransactions(string APIURL,string APIKey, int NumberOfTransactions, out WMSdata[] Data, out string ErrorText)
        {
            int ErrorCode = 0;
            ErrorText = "";
            RestRequest request;

            var client = new RestClient(APIURL)
            .AddDefaultHeader("Content-Type", "application/json");

            try
            {
                Console.WriteLine("GetJSONTransactions");

                request = new RestRequest("GetJSONTransactions?numTrans=" + NumberOfTransactions + "&APIKey=" + APIKey, Method.Get);

                var r = client.Execute(request);

                if (r.IsSuccessful)
                {
                    Console.WriteLine("GetJSONTransactions success ");
                    WMSResponse response = System.Text.Json.JsonSerializer.Deserialize<WMSResponse>(r.Content);
                    Data = response.Data;




                }

                else
                {
                    Console.WriteLine("GetJSONTransactions failed: " + r.Content);
                    ErrorText = r.Content;
                    ErrorCode = 98;
                    Data = new WMSdata[1];
                }

                return ErrorCode;

            }
            catch (Exception ex)
            {
                Console.WriteLine("GetJSONTransactions failed:, {0}", ex);
                ErrorText = ex.Message;
                Data = new WMSdata[1];
                return 99;
            }
        }
    }







}
