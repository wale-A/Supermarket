using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFramework.AppClasses;
using AppFramework.Controls;
using FirstAppFrameworkApplicationEntities.EDTs;
using FirstAppFrameworkApplicationEntities.EntityClasses;
using AppFramework.Linq;

namespace FirstAppFrameworkApplicationEntities.ReportClasses
{
    class OrderReport : MicrosoftReportViewerReportRun
    {
        public string OrderID { get; set; }
        public Order OrderInstance { get; set; }

        public override MicrosoftReportViewerReportType ReportType
        {
            get { return MicrosoftReportViewerReportType.File; }
        }
        public override bool prompt()
        {
            IValueDataControl OrderId = this.addParameter(new OrderEDT());
            var result = base.prompt();

            OrderID = OrderId.StringValue;
            return result;
        }

        public override void initDataSources()
        {
            if (Args.EntityBase != null)
                OrderInstance = (Order)Args.EntityBase;
            
            if (OrderInstance == null)
            {
                try
                {
                    OrderInstance = (from i in new QueryableEntity<Order>() where i.OrderID == OrderID select i).ToList().AppFirst();
                    //OrderID = OrderInstance.OrderID;

                    var reportData = (from i in new QueryableEntity<Order>()
                                      join u in new QueryableEntity<Users>() on i.CreatedBy equals u.Username
                                      join c in new QueryableEntity<Customers>() on i.CustomerID equals c.CustomerID
                                      where i.OrderID == OrderID
                                      select new OrderReportDataLine
                                      {
                                          OrderID = i.OrderID,
                                          Customer = c.Name,
                                          StaffName = u.Name,
                                          Date = i.CreatedDateTime,
                                      }).ToList();

                    var orderDetails = (from o in new QueryableEntity<Order>()
                                        join od in new QueryableEntity<OrderDetails>() on o.OrderID equals od.OrderID
                                        join i in new QueryableEntity<Items>() on od.ItemID equals i.ItemID
                                        where o.OrderID == OrderID
                                        select new OrderDetailsReportDataLine
                                        {
                                            Description = i.ItemName,
                                            Quantity = od.Quantity,
                                            UnitPrice = i.Price,
                                            Amount = od.Amount
                                        }).ToList();
                    //var OrderItems = (from id in new QueryableEntity<OrderDetails>() where id.OrderID == OrderID select id).ToList();

                    LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Order", reportData));
                    LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Items", orderDetails));
                }
                catch (Exception ex)
                {
                    throw new Exception("invalid Order ID");
                }
            }            
        }

        public override void postInitDatasources()
        {
            //throw new NotImplementedException();
        }

        public override void postInitReport()
        {
            LocalReport.EnableExternalImages = true;
            //throw new NotImplementedException();
        }

        public override string reportPath()
        {
            return "Reports/InvoiceReport.rdlc";
            //throw new NotImplementedException();
        }

        public override string Title
        {
            get { return "Order Report"; }
        }

        public class OrderReportDataLine
        {
            public string OrderID { get; set; }
            public string Customer { get; set; }
            public string StaffName { get; set; }
            public DateTime Date { get; set; }
        }

        public class OrderDetailsReportDataLine
        {
            public string Description { get; set; }
            public int Quantity { get; set; }
            public decimal UnitPrice { get; set; }
            public decimal Amount { get; set; }
        }
    }
}
