using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Drawing;

using System.ServiceModel;
using System.ServiceModel.Web;
using System.ServiceModel.Description;

using MetricsManager.Common;
using MetricsManager.Config;
using MetricsManager.SQL;
using MetricsManager.Error;

using MetricsManager.V4.Database;
using MetricsManager.V4.Entity;
using MetricsManager.V4.Service;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MetricsManager4WCF
{
    public partial class MainWindow
    {
        private MMError error;
        private MMConfig config;
        private MMSQL sql;
        private MetricsManagerDB4 mmdb;
        private LOGDB4 logdb;

        private WebServiceHost wsh;
        private MMServiceV4 mmservice;
        private string wcf_url;
        private int log_count;
        partial void init_app()
        {
            try
            {
                init_config();
                error = new MMError();
                sql = new MMSQL(this.txt_dbserver.Text, this.txt_database.Text, this.txt_userid.Text, this.txt_password.Text, this.ck_trusted.Checked);
                mmdb = new MetricsManagerDB4(sql.EntityString("MetricsManagerDB4"));
                logdb = new LOGDB4(sql.EntityString("LogDB4"));

                init_wcf();
            }
            catch (Exception err)
            {
                System.Windows.MessageBox.Show(string.Format("Error:{0}\nMessage:{1}", err.Message, err.StackTrace));
            }
        }
        partial void close_app()
        {
            save_config();
        }
        private void init_config()
        {
            config = new MMConfig();
            if (config.exists("dbserver"))
                this.txt_dbserver.Text = config["dbserver"];
            else
                config["dbserver"] = this.txt_dbserver.Text;


            if (config.exists("database"))
                config["database"] = this.txt_database.Text;
            else 
                config["database"] = this.txt_database.Text;


            if (config.exists("userid"))
                this.txt_userid.Text = config["userid"];
            else
                config["userid"] = this.txt_userid.Text;


            if (config.exists("password"))
                this.txt_password.Text = config["password"];
            else
                config["password"] = this.txt_password.Text;


            if (config.exists("trusted"))
                this.ck_trusted.Checked = config.getBool("trusted");
            else
                config["trusted"] = this.ck_trusted.Checked.ToString();

            if (config.exists("canaryservice"))
                this.txt_canary.Text = config["canaryservice"];
            else
                config["canaryservice"] = this.txt_canary.Text;


            if (config.exists("notify"))
                this.ck_notify.Checked = config.getBool("notify");
            else
                config["notify"] = this.ck_notify.Checked.ToString();
        
        
        }
        private void save_config()
        {
            config["dbserver"] = this.txt_dbserver.Text;
            config["database"] = this.txt_database.Text;
            config["userid"] = this.txt_userid.Text;
            config["password"] = this.txt_password.Text;
            config["trusted"] = this.ck_trusted.Checked.ToString();
            config["canaryservice"] = this.txt_canary.Text;
            config["notify"] = this.ck_notify.Checked.ToString(); ;
        }

        private void init_wcf()
        {
            #region WCF Service
            // WCF MMService Sevice URL 
            this.wcf_url = string.Format("http://{0}/MetricsManager/MMServiceV4/mmservice.svc/", MMNET.getIPAddress());
            this.txt_wcf_url.Text = this.wcf_url;
            MMNET.allowURL(this.wcf_url);
            
            // MMService Service Object and Service Host 
            this.mmservice = new MMServiceV4();
            this.mmservice.recieve_message += mmservice_recieve_message;
            this.wsh = new WebServiceHost(this.mmservice, new Uri[] {
                new Uri( this.wcf_url )
            });

            

            // MMService Transportation Protocal Binding
            WebHttpBinding web_http = new WebHttpBinding();
            
            //web_http.Security.Mode = WebHttpSecurityMode.Transport;
            //web_http.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;

            web_http.MaxReceivedMessageSize = 65535000;
            web_http.MaxBufferSize = 65535000;

            // MMService Service Endpoint for listening 
            ServiceEndpoint sep = wsh.AddServiceEndpoint(typeof(iMMServiceV4), web_http, "");
            // MMService behaviors for help page and other attribute 
            WebHttpBehavior whb = sep.Behaviors.Find<WebHttpBehavior>(); // 技巧：设置帮助页面
            if (whb != null)
            {
                whb.AutomaticFormatSelectionEnabled = true;
                whb.HelpEnabled = true;
            }
            else
            {
                whb = new WebHttpBehavior();
                whb.AutomaticFormatSelectionEnabled = true;
                whb.HelpEnabled = true;
                sep.Behaviors.Add(whb);  //帮助页面是附加在ServiceEndpoint上的。
            }
            
            this.wsh.Open();
            #endregion WCF Service

        }

        void mmservice_recieve_message(MMMessage message, MMError error)
        {
            this.rch_error.Text = error.ErrorMessage;
            this.rch_header.Text = MMJson.ObjectToString(message.Header);
            this.rch_body.Text = message.Body;
            this.pic_tm.Image = MMImage.StringToImage(message.Data); 
            this.lbl_tm_count.Text = string.Format("{0}", ++log_count);
        }
    }
}
