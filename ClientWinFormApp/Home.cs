using SOAP_WebService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ClientWinFormApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
        }

        #region Members
        private static WaitingForm instance;
        public static WaitingForm GetWaitingFormInstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new WaitingForm();
                }
                return instance;
            }
        }
        BackgroundWorker worker;
        #endregion

        #region Methods

        /// <summary>
        /// On completed, we close the waiting form show result
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            GetWaitingFormInstance.Close();
            MessageBox.Show(e.Result.ToString());
        }


        /// <summary>
        /// Time consuming operation 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            int value = (int)e.Argument;
            using (WebService ws = new WebService())
            {
                Thread.Sleep(5000);
                e.Result = ws.Fibonacci(value);
            }
        }

        #endregion

        #region Event Handlers
        private void btCallFibonacciWS_Click(object sender, EventArgs e)
        {
            //This line helps to do work while modal window is displayed
            BeginInvoke(new Action(() => GetWaitingFormInstance.ShowDialog(this)));

            int value = 0;
            int.TryParse(numericUpDownInput.Value.ToString(), out value);
            worker.RunWorkerAsync(argument: value);
        }

        private void btGenerateXml_Click(object sender, EventArgs e)
        {
            try
            {
                string xml = "<TRANS><HPAY><ID>103</ID><STATUS>3</STATUS><EXTRA><IS3DS>0</IS3DS><AUTH>031183</AUTH></EXTRA><INT_MSG/><MLABEL>501767XXXXXX6700</MLABEL><MTOKEN>project01</MTOKEN></HPAY></TRANS>";
                tbXml.Text = System.Xml.Linq.XDocument.Parse(xml).ToString();
            }
            catch (Exception ex)
            {

                tbXml.Text = ex.Message;
            }
        }

        private void btXmlToJson_Click(object sender, EventArgs e)
        {
            try
            {
                using (WebService ws = new WebService())
                {
                    string result = ws.XmlToJson(tbXml.Text);
                    tbJson.Text = result.ToString();
                }
            }
            catch (Exception ex)
            {
                tbJson.Text = ex.Message;
            }
        }
        #endregion
    }
}
