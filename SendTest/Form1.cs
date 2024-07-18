using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoolSms;
using System.Net;
using System.Net.Http;

namespace SendTest
{
    public partial class Form1 : Form
    {
        #region 1# Program Setting
        string temp = "";
        string ver = "0.9";
        string folder_loacation = "";
        string today_date = "";
        string txtFile = "";
        string full_location = "";

        SmsApi api = new SmsApi(new SmsApiOptions
        {
            ApiKey = "NCSHZCNBPOXY1DLR",
            ApiSecret = "KTSPOONTARPOPU2MQYCDBZUQUXWHW3J8",
            DefaultSenderId = "01034717524"
        });
        /*private string _location;
        public string location
        {
            get { return _location; } set { _location = value; }
        }*/
        #endregion
        #region 2# Program Load
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_version.Text = ver;
            groupBox1.Enabled = false;
            
            DateTime dateTime = DateTime.Now;
            lbl_hi.Text = "              반갑습니다 !! ( " + dateTime.Year + "-" + dateTime.Month + "-" + dateTime.Day + " )               ";
            today_date = dateTime.ToString("yyyy-MM-dd");
        }
        #endregion
        #region 3# Program Info
        private void btn_cinfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1000ms = 1초 입니다. \n기본 값은 10000ms 로 \n10초 주기로 메모장 알림사항을 \n체크합니다.");
        }
        private void btn_info_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.ShowDialog();
        }
        #endregion
        #region 4# ProgramChecked
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int time = Convert.ToInt32(((TextBox)txtbox_check).Text);
                tmr_check.Interval = time;
                isChecked(chk_check.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void isChecked(bool Checked)
        {
            if (Checked)
            {
                tmr_check.Enabled = true;
            }
            else
            {
                tmr_check.Enabled = false;
            }
        }
        #endregion
        #region 5# Program Init
        private void btn_active_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(folder_loacation))
            {
                MessageBox.Show("경로설정을 먼저해주세요");
            }
            else
            {
                CheckFile(folder_loacation);
                FileStream file = new FileStream(full_location, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                StreamReader sr = new StreamReader(file);
                temp = sr.ReadToEnd();
                sr.Close();
                file.Close();
                groupBox1.Enabled = true;
                btn_active.Enabled = false;
                //CheckEmptyFolder(folder_loacation);
            }
        }
        #endregion
        #region 6# Program Main
        private void txtbox_check_Press(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }
        private void tmr_check_Tick(object sender, EventArgs e)
        {
            try
            {
                FileStream file = new FileStream(full_location, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                StreamReader sr = new StreamReader(file);
                string str = sr.ReadToEnd();
                if (temp != str)
                {
                    temp = str;
                    //var toSend = api.SendMessageAsync(txtbox_num.Text, temp);
                    MessageBox.Show(temp);
                }
                sr.Close();
                file.Close ();             
            }
            catch(Exception ex) { MessageBox.Show(ex.ToString()); }
            
        }
        #endregion
        #region 7# Program VersionCheck
        private void btn_version_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            Stream stream = client.OpenRead("http://oracle312.dothome.co.kr/version.txt");
            StreamReader reader = new StreamReader(stream);
            string readText = reader.ReadToEnd();
            
            if (readText != lbl_version.Text)
            {
                if (MessageBox.Show("현재 최신버전이 아닙니다. \n" + "현재버전 : " + lbl_version.Text + "\n최신버전 : " + readText +
                    "\n최신버전을 다운로드 하시겠습니까 ?", "업데이트", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    String url = "http://oracle312.dothome.co.kr/UPDATE.7z";

                    string content;
                    using (HttpClient clients = new HttpClient())
                    {
                        content = clients.GetStringAsync(url).Result;
                    }

                    string dest = @"UPDATE.7z";
                    File.WriteAllText(dest, content);
                    MessageBox.Show("다운로드 완료 !! \nUPDATE.7z 의 압축을 풀어주세요.");
                }
            }
            else
            {
                if (MessageBox.Show("현재 최신버전 입니다. \n" + "현재버전 : " + lbl_version.Text + "\n최신버전 : " + readText +
                    "\n그래도 새로 다운로드 하시겠습니까 ?", "업데이트", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    String url = "http://oracle312.dothome.co.kr/UPDATE.7z";

                    string content;
                    using (HttpClient clients = new HttpClient())
                    {
                        content = clients.GetStringAsync(url).Result;
                    }

                    string dest = @"UPDATE.7z";
                    File.WriteAllText(dest, content);
                    MessageBox.Show("다운로드 완료 !! \nUPDATE.7z 의 압축을 풀어주세요.");
                }
            }     
        }
        #endregion
        #region 8# Program Exit
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void btn_loc_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                folder_loacation = fbd.SelectedPath;
                txtbox_loc.Text = folder_loacation;
            }
        }

        private void CheckEmptyFolder (string path)
        {
            if (!File.Exists(path))
            {
                MessageBox.Show("폴더에 아무것도 존재하지 않습니다. \n다시 시도해주세요.");
            }
            else
            {
                CheckFile(path);
                groupBox1.Enabled = true;
                btn_active.Enabled = false;
            }
        }

        private void CheckFile (string path)
        {
            DirectoryInfo di = new DirectoryInfo (path);
            foreach (FileInfo fi in di.GetFiles("*.txt"))
            {
                try
                {
                    //MessageBox.Show(folder_loacation +"\\"+ fi.Name);
                    MessageBox.Show(today_date + "\n" + fi.CreationTime.ToString().Substring(0, 10));            
                    if (today_date == fi.CreationTime.ToString().Substring(0, 10))
                    {
                        txtFile = fi.Name;
                        full_location = folder_loacation + "\\" + txtFile;
                        groupBox2.Enabled = true;                      
                    }
                    else
                    {
                        MessageBox.Show("오늘 생성된 로그가 없습니다");
                    }
                                      
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
