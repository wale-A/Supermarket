using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using AppFramework.Controls;
using AppFramework.Linq;
using AppFramework.AppClasses;
using FirstAppFrameworkApplicationEntities.EntityClasses;
using FirstAppFrameworkApplicationEntities.EDTs;

namespace FirstAppFrameworkApplicationEntities.ReportClasses
{
    public class ReceiptReport : MicrosoftReportViewerReportRun
    {

        private string paymentID {get; set;}

        private Payment paymentInstance { get; set; }
=======
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
>>>>>>> refs/remotes/origin/master
        public override MicrosoftReportViewerReportType ReportType
        {
            get { return MicrosoftReportViewerReportType.File; }
        }

        public override bool prompt()
        {
<<<<<<< HEAD
            IValueDataControl paymentId = this.addParameter(new PaymentEDT());

            var result = base.prompt();

            paymentID = paymentId.Value.ToString();

            return result;
        }

        public override void initDataSources()
        {
            if (Args.EntityBase != null)
            {
                paymentInstance = (Payment)Args.EntityBase;
                paymentID = paymentInstance.PaymentID;
            }

            try
            {
                var paymentData = (from i in new QueryableEntity<Payment>()
                                   where i.PaymentID == paymentID
                                   select i).ToList().AppFirst();
                var payment =  new PaymentData
                                   {
                                       date = paymentData.CreatedDateTime.Date,
                                       paymentId = paymentData.PaymentID,
                                       orderId = paymentData.OrderID,
                                       amountPaid = paymentData.Amount,
                                       description = paymentData.Description
                                   };
                
                List<PaymentData>paymentList = new List<PaymentData>();
                paymentList.Add(payment);

                var customerName = (from i in new QueryableEntity<Order>()
                                    join j in new QueryableEntity<Customers>()
                                    on i.CustomerID equals j.CustomerID
                                    where i.OrderID == payment.orderId
                                    select new Customer
                                    {
                                        name = j.Name,
                                        id = i.CustomerID
                                    }).ToList();

                LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("customer", customerName));
                LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("paymentData", paymentList));
            }
            catch (Exception ex)
            {
                throw new Exception("invalid Order ID", ex);
            }
              
=======
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
>>>>>>> refs/remotes/origin/master
        }

        public override void postInitDatasources()
        {
<<<<<<< HEAD
           // throw new NotImplementedException();
=======
            //throw new NotImplementedException();
>>>>>>> refs/remotes/origin/master
        }

        public override void postInitReport()
        {
            LocalReport.EnableExternalImages = true;
            //throw new NotImplementedException();
        }

        public override string reportPath()
        {
            return "Reports/ReceiptReport.rdlc";
<<<<<<< HEAD
=======
            //throw new NotImplementedException();
>>>>>>> refs/remotes/origin/master
        }

        public override string Title
        {
            get { return "Receipt Report"; }
        }

<<<<<<< HEAD
        public class Customer
        {
            public string name { get; set; }
            public string id { get; set; }
        }

        public class PaymentData
        {
            public DateTime date { get; set; }
            public string paymentId { get; set; }
            public Decimal amountPaid { get; set; }
            public string orderId { get; set; }
            public string description { get; set; }
        }
    }

=======
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
>>>>>>> refs/remotes/origin/master
}
