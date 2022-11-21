# OMNI-WMS-API-Demo
This project is created as an example on how to interface to the Tecsys OMNI WMS using c#.

The demo can create/update:
* Products (Item master data)
* SalesOrders (Outbound orders)
* PurchaseOrders (Inbound orders)
* ReturnOrders (RMA inbound)

In the class file: OMNIWMSRestAPI you can see all the c# classes are implemented to support the Serialization and Deserialization to/from JSON.
Please observe that the OMNI-WMS API is case sensitive and uses "PascalCase" - meaning a default camelCase Serializer will not work.

With the "Get Transaction" button you can see how to get transactions from the OMNI WMS
You can either fetch one transaction at the time or get at number of transactions
In this simple demo the transactions are shown in a text box and not all the fields are shown.

