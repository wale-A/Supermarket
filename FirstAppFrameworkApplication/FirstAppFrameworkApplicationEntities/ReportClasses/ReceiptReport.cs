using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFramework.AppClasses;
using AppFramework.Controls;
using FirstAppFrameworkApplicationEntities.EDTs;
using AppFramework.Linq;
using FirstAppFrameworkApplicationEntities.EntityClasses;

namespace FirstAppFrameworkApplicationEntities.ReportClasses
{
    class ReceiptReport : MicrosoftReportViewerReportRun
    {
        public string receiptID { get; set; }
        public Payment paymentInstance { get; set; }
        public override MicrosoftReportViewerReportType ReportType
        {
            get { return MicrosoftReportViewerReportType.File; }
        }

        public override bool prompt()
        {
            IValueDataControl receiptId = this.addParameter(new PaymentEDT());
            var result = base.prompt();

            receiptID = receiptId.StringValue;
            return result;
        }
        public override void initDataSources()
        {
            if (Args.EntityBase != null)
                paymentInstance = (Payment)Args.EntityBase;

            if (paymentInstance == null)
            {
                try
                {
                    paymentInstance = (from i in new QueryableEntity<Payment>() where i.PaymentID == receiptID select i).ToList().AppFirst();
                    //OrderID = OrderInstance.OrderID;

                    var customerName = (from a in new QueryableEntity<Order>()
                                        join b in new QueryableEntity<Customers>() on a.CustomerID equals b.CustomerID
                                        where paymentInstance.OrderID == a.OrderID
                                        select new { b.Name}).ToList().AppFirst();

                    LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Payment", paymentInstance));
                    LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("CustomerName", customerName));
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
            return "Reports/ReceiptReport.rdlc";
            //throw new NotImplementedException();
        }

        public override string Title
        {
            get { return "Receipt Report"; }
        }

        public class ReceiptReportData
        {
            public DateTime date { get; set; }
            public string paymentID { get; set; }
            public string customerID { get; set; }
            public Decimal amountPaid { get; set; }
            public string orderID { get; set; }
            public string description { get; set; }
        }
    }
}
