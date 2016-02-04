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
using AppFramework.AppClasses.EDTs;

namespace FirstAppFrameworkApplicationEntities.ReportClasses
{
    class OrderReport : MicrosoftReportViewerReportRun
    {
        Dictionary<string, OrderReportDataLine> OrderList { get; set; }
        public string OrderID { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public Order OrderInstance { get; set; }

        public override MicrosoftReportViewerReportType ReportType
        {
            get { return MicrosoftReportViewerReportType.File; }
        }
        public override bool prompt()
        {
            IValueDataControl orderId = this.addParameter(new OrderEDT());
            IValueDataControl fromDate = this.addParameter(new DateEDT(), "From");
            IValueDataControl toDate = this.addParameter(new DateEDT(), "To");
            var result = base.prompt();

            OrderID = orderId.StringValue;
            FromDate = fromDate.DateTimeValue;
            ToDate = toDate.DateTimeValue;
            return result;
        }

        public override void initDataSources()
        {
            if (Args.EntityBaseList != null && Args.EntityBaseList.Count > 1)
            {
                List<Order> xx = new List<Order>();
                foreach (var x in Args.EntityBaseList)
                {
                    xx.Add((Order)x);                   
                }
                setReportDataWithListOfID(xx);
            }
            else if (Args.EntityBase != null)
            {
                OrderInstance = (Order)Args.EntityBase;
                OrderID = OrderInstance.OrderID;
                setReportDataWithID();
            }
            else
            {
                if (OrderID != null)
                {
                    if (FromDate.Year >= 2015 && ToDate.Year > 2015)
                        setReportDataWithDateAndID();
                    else
                        setReportDataWithID();
                }
                        //LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Items", orderDetails));
                        //LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Misc", total));
                        
                    //catch (Exception ex)
                    //{
                    //    throw new Exception("invalid Order ID", ex);
                    //}
            }

            LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Order", OrderList.ToList()));
        }

        private void setReportDataWithListOfID(List<Order> param)
        {
            foreach (Order o in param)
            {
                var x = (from i in new QueryableEntity<Order>()
                         join u in new QueryableEntity<Users>() on i.CreatedBy equals u.Username
                         join c in new QueryableEntity<Customers>() on i.CustomerID equals c.CustomerID
                         where i.OrderID == o.OrderID
                         select new OrderReportDataLine
                         {
                             OrderID = i.OrderID,
                             Customer = c.Name,
                             StaffName = u.Name,
                             Date = i.CreatedDateTime,
                         }).ToList();
                OrderList.Add(x[0].OrderID, x[0]);
            }
        }

        private void setReportDataWithID()
        {
            OrderList = (from i in new QueryableEntity<Order>()
                         join u in new QueryableEntity<Users>() on i.CreatedBy equals u.Username
                         join c in new QueryableEntity<Customers>() on i.CustomerID equals c.CustomerID
                         where i.OrderID == OrderID
                         select new OrderReportDataLine
                         {
                             OrderID = i.OrderID,
                             Customer = c.Name,
                             StaffName = u.Name,
                             Date = i.CreatedDateTime,
                         }).ToList().ToDictionary(x => x.OrderID, x => x);
        }

        private void setReportDataWithDateAndID()
        {
            if (FromDate > ToDate)
            {
                DateTime temp = FromDate;
                FromDate = ToDate;
                ToDate = FromDate;
            }

            OrderList = (from i in new QueryableEntity<Order>()
                         join u in new QueryableEntity<Users>() on i.CreatedBy equals u.Username
                         join c in new QueryableEntity<Customers>() on i.CustomerID equals c.CustomerID
                         where i.OrderID == OrderID && i.CreatedDateTime <= ToDate && i.CreatedDateTime >= FromDate
                         select new OrderReportDataLine
                         {
                             OrderID = i.OrderID,
                             Customer = c.Name,
                             StaffName = u.Name,
                             Date = i.CreatedDateTime,
                         }).ToList().ToDictionary(x => x.OrderID, x => x);
        }


        public override void postInitDatasources()
        {
            LocalReport.SubreportProcessing += LocalReport_SubreportProcessing;
            //throw new NotImplementedException();
        }

        void LocalReport_SubreportProcessing(object sender, Microsoft.Reporting.WinForms.SubreportProcessingEventArgs e)
        {
            string orderId = e.Parameters[0].ToString();

            OrderReportDataLine order = OrderList[orderId];

            var orderDetails = (from o in new QueryableEntity<Order>()
                                join od in new QueryableEntity<OrderDetails>() on o.OrderID equals od.OrderID
                                join i in new QueryableEntity<Items>() on od.ItemID equals i.ItemID
                                where o.OrderID == order.OrderID
                                select new OrderDetailsReportDataLine
                                {
                                    Description = i.ItemName,
                                    Quantity = od.Quantity,
                                    UnitPrice = i.Price,
                                    Amount = od.Amount
                                }).ToList();

            var total = (from t in new QueryableEntity<Total>()
                         where t.OrderID == order.OrderID
                         select t).ToList();

            e.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Order", new List<OrderReportDataLine>() { order }));
            //LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Items", setOrderDetails(order)));
            //LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Misc", setExtraCharges(order)));

            LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Items", orderDetails));
            LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Misc", total));

        }

        private System.Collections.IEnumerable setExtraCharges(OrderReportDataLine order)
        {
            return (from t in new QueryableEntity<Total>()
                         where t.OrderID == order.OrderID
                         select t).ToList();
        }

        private System.Collections.IEnumerable setOrderDetails(OrderReportDataLine order)
        {
            return (from o in new QueryableEntity<Order>()
                                join od in new QueryableEntity<OrderDetails>() on o.OrderID equals od.OrderID
                                join i in new QueryableEntity<Items>() on od.ItemID equals i.ItemID
                                where o.OrderID == order.OrderID
                                select new OrderDetailsReportDataLine
                                {
                                    Description = i.ItemName,
                                    Quantity = od.Quantity,
                                    UnitPrice = i.Price,
                                    Amount = od.Amount
                                }).ToList();
        }

        public override void postInitReport()
        {
            LocalReport.EnableExternalImages = true;
            //throw new NotImplementedException();
        }

        public override string reportPath()
        {
            return "Reports/InvoiceReportContainer.rdlc";
            //throw new NotImplementedException();
        }

        public override string Title
        {
            get { return "Invoice Report"; }
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

        //public class ExtraCharges
        //{
        //    public string Description { get; set; }
        //    public decimal Amount { get; set; }
        //}
    }
}
