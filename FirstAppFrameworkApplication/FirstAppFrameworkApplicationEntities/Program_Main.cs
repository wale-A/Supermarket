using AppFramework.AppClasses;
using AppFramework.AppForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstAppFrameworkApplicationEntities
{
    public class Program_Main
    {
        private static Setup setup = new Setup();

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
        }

        public static void startupApplication()
        {
            //setup();

            //if (AppSettings.ClientOrServer == ClientOrServer.Client)
            {
//#if DEBUG
//                System.Threading.Thread.Sleep(1000);
//#endif
                //MessageBox.Show("");

                setup.setupWindowsClient();

                //if (!Process.GetCurrentProcess().ProcessName.Contains("AppFrameworkBatchClient"))
                {
                    //Server.start();
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    //AppSettings.EnableAlerts = false;
                    FormBase.show(typeof(Login), true);
                    if (Session.User != null)
                    {
                        
                        MainForm mainForm = MainForm.getMainForm();
                        //mainForm.Load += mainForm_Load;
                        //mainForm.FormClosing += mainForm_FormClosing;
                        String endPoint = "";
                        try
                        {
                            endPoint = DatabaseHandler.DefaultDatabaseHandlerObject.Client.TcpClient.Client.RemoteEndPoint.ToString();
                        }
                        catch { }
                        mainForm.Text = String.Format("Premier [{0}] [{1}] [{2}]", Session.Username, endPoint, AppSettings.LicenseData.Item1);


                        //mainForm.Load += mainForm_Load;
                        setup.setupNavigationMenus();
                        Application.Run(mainForm);
                    }
                }
                //else
                //{
                //    //throw new Exception("Authentication Failure");
                //}
            }
            //else
            //{
            //    //setup();
            //    ////Infolog.add(Application.StartupPath, InfoType.Warning);
            //    //setupServer();
            //    bursarySetup.setupServer();
            //    Server.start();
            //}
        }
    }
}
