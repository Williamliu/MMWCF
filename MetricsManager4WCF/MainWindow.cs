using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;

using MetricsManager.Common;
using MetricsManager.Config;
using MetricsManager.SQL;
using MetricsManager.Error;
using MetricsManager.V4.Database;
using MetricsManager.V4.Entity;

namespace MetricsManager4WCF
{
    public partial class MainWindow : Form
    {
        #region Windows Initial
        partial void init_app();
        partial void close_app();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.Text += string.Format("     IP Address: {0}", MMNET.getIPAddress());
            init_app();
        }
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            close_app();
        }
        #endregion Windows Initial

        #region MeticsManager Database verification and creation
        private void btn_validate_db_Click(object sender, EventArgs e)
        {
            try
            {
                this.error.clear();
                sql = new MMSQL(this.txt_dbserver.Text, this.txt_database.Text, this.txt_userid.Text, this.txt_password.Text, this.ck_trusted.Checked);
                this.mmdb = new MetricsManagerDB4(sql.EntityString("MetricsManagerDB4"));

                if (!this.mmdb.Database.Exists())
                {
                    this.error.append(MMLogType.Fail, MMErrorType.Fail, string.Format("Database '{0}' doesn't exist !", this.mmdb.Database.Connection.Database));
                    MessageBox.Show(this.error.ErrorMessage);
                }
                else
                {
                    this.error.append(MMLogType.Pass, MMErrorType.Pass, string.Format("Database '{0}' already exist.", this.mmdb.Database.Connection.Database));
                    MessageBox.Show(this.error.ErrorMessage);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(string.Format("Error:{0}\nMessage:{1}", err.Message, err.StackTrace));
            }
        }

        private void btn_create_db_Click(object sender, EventArgs e)
        {
            try
            {
                this.error.clear();
                sql = new MMSQL(this.txt_dbserver.Text, this.txt_database.Text, this.txt_userid.Text, this.txt_password.Text, this.ck_trusted.Checked);
                this.mmdb = new MetricsManagerDB4(sql.EntityString("MetricsManagerDB4"));

                if (!this.mmdb.Database.Exists())
                {
                    this.mmdb.Database.CreateIfNotExists();
                    this.error.append(MMLogType.Pass, MMErrorType.Pass, string.Format("Created Database '{0}' successfully.", this.mmdb.Database.Connection.Database));
                    this.mmdb.MetricsManagerDBInitialize(this.sql);
                    this.error.append(MMLogType.Pass, MMErrorType.Pass, string.Format("Modified Database '{0}' metadata successfully.", this.mmdb.Database.Connection.Database));
                }
                else
                {
                    this.error.append(MMLogType.Pass, MMErrorType.Pass, string.Format("Database '{0}' already exists !", this.mmdb.Database.Connection.Database));
                }
                MessageBox.Show(this.error.ErrorMessage);

            }
            catch (Exception err)
            {
                MessageBox.Show(string.Format("Error:{0}\nMessage:{1}", err.Message, err.StackTrace));
            }
        }

        private void btn_test_connect_Click(object sender, EventArgs e)
        {
            this.error.clear();
            try
            {
                sql = new MMSQL(this.txt_dbserver.Text, this.txt_database.Text, this.txt_userid.Text, this.txt_password.Text, this.ck_trusted.Checked);
                this.mmdb = new MetricsManagerDB4(sql.EntityString("MetricsManagerDB4"));
                this.mmdb.Database.Connection.Open();
                this.error.append(MMLogType.Pass, MMErrorType.Pass, string.Format("Connect to database '{0}' successfully.", this.mmdb.Database.Connection.Database));
                MessageBox.Show(this.error.ErrorMessage);
            }
            catch (Exception err)
            {
                this.error.append(MMLogType.Fail, MMErrorType.Fail, string.Format("Connect to database '{0}' failed.\nError:{1}", this.mmdb.Database.Connection.Database, err.Message));
                MessageBox.Show(this.error.ErrorMessage);
            }

        }
        #endregion  MeticsManager Database verification and creation


        #region Button Click for Logs
        private void btn_createlog_Click(object sender, EventArgs e)
        {
            int utc = MMDate.toUTC(DateTime.Now);
            DateTime ut = MMDate.mktime(utc);
            string str2 = string.Format("{0}\n{1}\n{2}", ut, ut.ToUniversalTime(), ut.ToUniversalTime().ToLocalTime() );
                              
            MessageBox.Show(str2);
            
            try
            {
                this.logdb = new LOGDB4(sql.EntityString("LogDB4"));
                this.logdb.UpdateConfig(sql.Server, sql.Database, sql.User, sql.Password);
            }
            catch (Exception err)
            {
                MessageBox.Show(string.Format("Error:{0}\nMessage:{1}", err.Message, err.StackTrace));
            }
        }

        private void btn_tm_Click(object sender, EventArgs e)
        {
            try
            {
                // Attach independent System Object to LogDB
                ET_LOG_SYSTEM logSystem = new ET_LOG_SYSTEM()
                {
                    uuid = "1000-2000-3000",
                    ip_current = "192.168.1.83",  // it will automatic provide by WCF Service remote_client
                    name = "System Name",
                    description = "System Description",
                    last_updated = DateTime.Now,
                    status = 1,
                    softversion = "VES V1.0"
                };
                this.logdb.AppSystem = logSystem;

                // Create new TM Log
                ET_LOG_TM tmLog = new ET_LOG_TM();

                // Attach TM Log to System  and Current Config which import for file_path, file_url etc.
                tmLog.LogSystem = this.logdb.AppSystem;
                tmLog.LogConfig = this.logdb.AppConfig;
                

                // Basic Info
                tmLog.log_utctime = 1405461978;
                tmLog.log_timeoffset = 18000;

                tmLog.file_name = "tm_2014.11.24.30_12.35.45.jpg";
                tmLog.file_path = @"data\source\";
                tmLog.file_url = "data/source/";
                
                tmLog.logversion = 1;
                tmLog.softversion = "";
                tmLog.valid = 1;
                
                //Special Info for TM 
                tmLog.nteeth = 8;
                tmLog.alarmstate = 16;
                tmLog.toothstatus = "[0,0,0,16,0,0,1,0]";
                                
                // Create TM Teeth Status
                byte[] teeths = new byte[] { 0, 0, 0, 16, 0, 0, 1, 0 };
                tmLog.TeethInsert(teeths);

                // Add new log to database and save
                this.logdb.LogTM.Add(tmLog);
                this.logdb.SaveChanges();
                
                MessageBox.Show("TM Log Inserted Successfully.");
               
                string debug_file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tmlog.json");
            
                using (FileStream fs = File.Open(debug_file, FileMode.OpenOrCreate))
                using (StreamWriter sw = new StreamWriter(fs))
                using (JsonWriter jw = new JsonTextWriter(sw))
                {
                  jw.Formatting = Formatting.Indented;
                  JsonSerializer serializer = new JsonSerializer();
                  serializer.Serialize(jw, tmLog, typeof(ET_LOG_TM));
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(string.Format("Error:{0}\nMessage:{1}", err.Message, err.StackTrace));
            }
        }

        private void btn_fm_Click(object sender, EventArgs e)
        {
            try
            {
                // Attach independent System Object to LogDB
                ET_LOG_SYSTEM logSystem = new ET_LOG_SYSTEM()
                {
                    uuid = "1000-2000-3000",
                    ip_current = "192.168.1.83", // it will automatic provide by WCF Service remote_client
                    name = "System Name",
                    description = "System Description",
                    last_updated = DateTime.Now,
                    status = 1,
                    softversion = "VES V1.0"
                };
                this.logdb.AppSystem = logSystem;

                // Create new FM Log
                ET_LOG_FM fmLog = new ET_LOG_FM();

                // Attach FM Log to System  and Current Config which import for file_path, file_url etc.
                fmLog.LogSystem = this.logdb.AppSystem;
                fmLog.LogConfig = this.logdb.AppConfig;

                //Basic Info
                fmLog.log_utctime = 1405461978;
                fmLog.log_timeoffset = 18000;

                fmLog.file_name = "tm_2014.11.24.30_12.35.45.jpg";
                fmLog.file_path = @"data\source\";
                fmLog.file_url = "data/source/";

                fmLog.logversion = 1;
                fmLog.softversion = "";
                fmLog.valid = 1;

                
                // Special Info for FM
                fmLog.bucketBB = "bucketBB";
                fmLog.cropBB = "cropBB";
                fmLog.bucketWidthCM = 36.36;
                fmLog.bucketWithPX = 200;

                
                // Create FM Result
                ET_LOG_FM_RESULT fmLogResult = new ET_LOG_FM_RESULT();
                fmLogResult.bucketBB = fmLog.bucketBB;
                fmLogResult.cropBB = fmLog.cropBB;
                fmLogResult.bucketWidthCM = fmLog.bucketWidthCM;
                fmLogResult.bucketWithPX = fmLog.bucketWithPX;
                fmLogResult.p10 = 10;
                fmLogResult.p20 = 20;
                fmLogResult.p30 = 30;
                fmLogResult.p40 = 40;
                fmLogResult.p50 = 50;
                fmLogResult.p60 = 60;
                fmLogResult.p70 = 70;
                fmLogResult.p80 = 80;
                fmLogResult.p90 = 90;
                fmLogResult.p100 = 100;
                fmLogResult.exclude = true;
                fmLog.ResultInsert(fmLogResult);


                // Add new log to database and save
                this.logdb.LogFM.Add(fmLog);
                this.logdb.SaveChanges();

                MessageBox.Show("FM Log Inserted Successfully.");

                string debug_file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "fmlog.json");

                using (FileStream fs = File.Open(debug_file, FileMode.OpenOrCreate))
                using (StreamWriter sw = new StreamWriter(fs))
                using (JsonWriter jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(jw, fmLog);
                }                

            }
            catch (Exception err)
            {
                MessageBox.Show(string.Format("Error:{0}\nMessage:{1}", err.Message, err.StackTrace));
            }

        }

        private void btn_lm_Click(object sender, EventArgs e)
        {
            try
            {
                // Attach independent System Object to LogDB
                ET_LOG_SYSTEM logSystem = new ET_LOG_SYSTEM()
                {
                    uuid = "1000-2000-3000",
                    ip_current = "192.168.1.83", // it will automatic provide by WCF Service remote_client
                    name = "System Name",
                    description = "System Description",
                    last_updated = DateTime.Now,
                    status = 1,
                    softversion = "VES V1.0"
                };
                this.logdb.AppSystem = logSystem;

                // Create new LM Log
                ET_LOG_LM lmLog = new ET_LOG_LM();

                // Attach LM Log to System  and Current Config which import for file_path, file_url etc.
                lmLog.LogSystem = this.logdb.AppSystem;
                lmLog.LogConfig = this.logdb.AppConfig;

                //Basic Info
                lmLog.log_utctime = 1405461978;
                lmLog.log_timeoffset = 18000;

                lmLog.file_name = "tm_2014.11.24.30_12.35.45.jpg";
                lmLog.file_path = @"data\source\";
                lmLog.file_url = "data/source/";

                lmLog.logversion = 1;
                lmLog.softversion = "";
                lmLog.valid = 1;


                // Special Info for LM
                lmLog.eventtype = 301;
                lmLog.value1 = 100;
                lmLog.value2 = 200;
                lmLog.value3 = 300;
                lmLog.value4 = 400;
                lmLog.string1 = "LM String1";
                lmLog.string2 = "LM String2";

                // Add new log to database and save
                this.logdb.LogLM.Add(lmLog);
                this.logdb.SaveChanges();

                MessageBox.Show("LM Log Inserted Successfully.");

                string debug_file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "lmlog.json");

                using (FileStream fs = File.Open(debug_file, FileMode.OpenOrCreate))
                using (StreamWriter sw = new StreamWriter(fs))
                using (JsonWriter jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(jw, lmLog);
                }                

            }
            catch (Exception err)
            {
                MessageBox.Show(string.Format("Error:{0}\nMessage:{1}", err.Message, err.StackTrace));
            }
        }

        private void btn_rm_Click(object sender, EventArgs e)
        {
            try
            {
                // Attach independent System Object to LogDB
                ET_LOG_SYSTEM logSystem = new ET_LOG_SYSTEM()
                {
                    uuid = "1000-2000-3000",
                    ip_current = "192.168.1.83", // it will automatic provide by WCF Service remote_client
                    name = "System Name",
                    description = "System Description",
                    last_updated = DateTime.Now,
                    status = 1,
                    softversion = "VES V1.0"
                };
                this.logdb.AppSystem = logSystem;

                // Create new RM Log
                ET_LOG_RM rmLog = new ET_LOG_RM();

                // Attach RM Log to System  and Current Config which import for file_path, file_url etc.
                rmLog.LogSystem = this.logdb.AppSystem;
                rmLog.LogConfig = this.logdb.AppConfig;

                //Basic Info
                rmLog.log_utctime = 1405461978;
                rmLog.log_timeoffset = 18000;

                rmLog.file_name = "tm_2014.11.24.30_12.35.45.jpg";
                rmLog.file_path = @"data\source\";
                rmLog.file_url = "data/source/";

                rmLog.logversion = 1;
                rmLog.softversion = "";
                rmLog.valid = 1;


                // Special Info for RM
                rmLog.eventType = 401;
                rmLog.radarTableSize = 7;
                rmLog.alarmStateThisCycle = 20;
                rmLog.alarmState = 30;


                // Create RM Result
                List<ET_LOG_RM_RADARS> RMRadasTables = new List<ET_LOG_RM_RADARS>()
                {
                    new ET_LOG_RM_RADARS(){ 
                        radas_no = 1,
                        valid = 1,
                        proximity = 5,
                        isCalibrated = 1,
                        XLocation = -1.111,
                        YLocation = 1.222,
                        PanAngle = 100,
                        TiltAngle = 111,
                        Range = 11,
                        alarmState = 0
                    },
                    new ET_LOG_RM_RADARS(){
                        radas_no = 2,
                        valid = 1,
                        proximity = 5,
                        isCalibrated = 1,
                        XLocation = -2.111,
                        YLocation = 2.222,
                        PanAngle = 200,
                        TiltAngle = 222,
                        Range = 22,
                        alarmState = 4
                    },
                    new ET_LOG_RM_RADARS(){
                        radas_no = 3,
                        valid = 1,
                        proximity = 5,
                        isCalibrated = 1,
                        XLocation = -3.111,
                        YLocation = 3.222,
                        PanAngle = 300,
                        TiltAngle = 333,
                        Range = 33,
                        alarmState = 16
                    },
                    new ET_LOG_RM_RADARS(){
                        radas_no = 4,
                        valid = 1,
                        proximity = 5,
                        isCalibrated = 1,
                        XLocation = -4.111,
                        YLocation = 4.222,
                        PanAngle = 400,
                        TiltAngle = 444,
                        Range = 44,
                        alarmState = 0
                    },
                    new ET_LOG_RM_RADARS(){
                        radas_no = 5,
                        valid = 1,
                        proximity = 5,
                        isCalibrated = 1,
                        XLocation = -5.111,
                        YLocation = 5.222,
                        PanAngle = 500,
                        TiltAngle = 555,
                        Range = 55,
                        alarmState = 0
                    },
                    new ET_LOG_RM_RADARS(){
                        radas_no = 6, 
                        valid = 1,
                        proximity = 5,
                        isCalibrated = 1,
                        XLocation = -6.111,
                        YLocation = 6.222,
                        PanAngle = 600,
                        TiltAngle = 666,
                        Range = 66,
                        alarmState = 16
                    },
                    new ET_LOG_RM_RADARS(){
                        radas_no = 7,
                        valid = 1,
                        proximity = 5,
                        isCalibrated = 1,
                        XLocation = -7.111,
                        YLocation = 7.222,
                        PanAngle = 700,
                        TiltAngle = 777,
                        Range = 77,
                        alarmState = 0
                    }
                };

                rmLog.RMRadasInsert(RMRadasTables);


                // Add new log to database and save
                this.logdb.LogRM.Add(rmLog);
                this.logdb.SaveChanges();

                MessageBox.Show("RM Log Inserted Successfully.");

                string debug_file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "rmlog.json");

                using (FileStream fs = File.Open(debug_file, FileMode.OpenOrCreate))
                using (StreamWriter sw = new StreamWriter(fs))
                using (JsonWriter jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(jw, rmLog);
                }                

            }
            catch (Exception err)
            {
                MessageBox.Show(string.Format("Error:{0}\nMessage:{1}", err.Message, err.StackTrace));
            }

        }

        private void btn_wm_Click(object sender, EventArgs e)
        {
            try
            {
                // Attach independent System Object to LogDB
                ET_LOG_SYSTEM logSystem = new ET_LOG_SYSTEM()
                {
                    uuid = "1000-2000-3000",
                    ip_current = "192.168.1.83", // it will automatic provide by WCF Service remote_client
                    name = "System Name",
                    description = "System Description",
                    last_updated = DateTime.Now,
                    status = 1,
                    softversion = "VES V1.0"
                };
                this.logdb.AppSystem = logSystem;

                // Create new WM Log
                ET_LOG_WM wmLog = new ET_LOG_WM();

                // Attach WM Log to System  and Current Config which import for file_path, file_url etc.
                wmLog.LogSystem = this.logdb.AppSystem;
                wmLog.LogConfig = this.logdb.AppConfig;


                //Basic Info
                wmLog.log_utctime = 1405461978;
                wmLog.log_timeoffset = 18000;

                wmLog.file_name = "tm_2014.11.24.30_12.35.45.jpg";
                wmLog.file_path = @"data\source\";
                wmLog.file_url = "data/source/";

                wmLog.logversion = 1;
                wmLog.softversion = "";
                wmLog.valid = 1;


                // Special Info for WM

                //WM Log Info
                wmLog.nteeth = 7;
                wmLog.toothProportionNew = 0.125;
                wmLog.toothProportionWorn = 0.0625;
                wmLog.bucketWidthMeters = 4.6;
                wmLog.bucketWidthPX = 218.237;

                //individual tooth insert
                List<ET_LOG_WM_TEETH> teethList = new List<ET_LOG_WM_TEETH>()
                {
                    new ET_LOG_WM_TEETH() {
                        tooth_no = 1,
                        rawLengthPX = 28.7948,
                        rawLengthM = 0.527769,
                        toothX = 211.548,
                        toothY = 341.43,
                        toothTilt = 51
                    },
                    new ET_LOG_WM_TEETH() {
                        tooth_no = 2,
                        rawLengthPX = 27.8342,
                        rawLengthM = 0.510163,
                        toothX = 249.118,
                        toothY = 338.319,
                        toothTilt = 50
                    },
                    new ET_LOG_WM_TEETH() {
                        tooth_no = 3,
                        rawLengthPX = 27.1869,
                        rawLengthM = 0.529356,
                        toothX = 285.582,
                        toothY = 337.668,
                        toothTilt = 49
                    },
                    new ET_LOG_WM_TEETH() {
                        tooth_no = 4,
                        rawLengthPX = 28.8814,
                        rawLengthM = 0.498299,
                        toothX = 320.943,
                        toothY = 339.267,
                        toothTilt = 48
                    },
                    new ET_LOG_WM_TEETH() {
                        tooth_no = 5,
                        rawLengthPX = 26.7662,
                        rawLengthM = 0.490589,
                        toothX = 356.303,
                        toothY = 343.059,
                        toothTilt = 44
                    },
                    new ET_LOG_WM_TEETH() {
                        tooth_no = 6,
                        rawLengthPX = 30.7013,
                        rawLengthM = 0.562714,
                        toothX = 394.425,
                        toothY = 349.606,
                        toothTilt = 41
                    },
                    new ET_LOG_WM_TEETH() {
                        tooth_no = 7,
                        rawLengthPX = 31.6426,
                        rawLengthM = 0.579966,
                        toothX = 429.785,
                        toothY = 357.959,
                        toothTilt = 41
                    }
                };

                wmLog.TeethInsert(teethList);

                // Add new log to database and save
                this.logdb.LogWM.Add(wmLog);
                this.logdb.SaveChanges();


                // WM Config Update after wmlog insert and assign id;
                ET_LOG_WM_CONFIG wmConfig = new ET_LOG_WM_CONFIG();
                wmConfig.log_id = wmLog.id;
                wmConfig.toothProportionNew = wmLog.toothProportionNew;
                wmConfig.toothProportionWorn = wmLog.toothProportionWorn;
                wmConfig.bucketWidthMeters = wmLog.bucketWidthMeters;
                wmLog.WMConfigUpdate(wmConfig);


                MessageBox.Show("WM Log Inserted Successfully.");

                string debug_file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "wmlog.json");

                using (FileStream fs = File.Open(debug_file, FileMode.OpenOrCreate))
                using (StreamWriter sw = new StreamWriter(fs))
                using (JsonWriter jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(jw, wmLog);
                }                
            
            }
            catch (Exception err)
            {
                MessageBox.Show(string.Format("Error:{0}\nMessage:{1}", err.Message, err.StackTrace));
            }
        }
        #endregion Button Click for logs

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.pic_tm.Image = null;
            this.rch_header.Text = "";
            this.rch_body.Text = "";
            this.rch_error.Text = "";
        }

        private void ck_notify_CheckedChanged(object sender, EventArgs e)
        {
            this.config["notify"] = this.ck_notify.Checked.ToString();
        }
    }
}
