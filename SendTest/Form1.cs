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
        string tmp = "";
        string[] old_log;
        int i = 0;

        Bitmap bit;
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
            CheckSaveFile();
            lbl_version.Text = ver;
            groupBox1.Enabled = false;
            groupBox3.Enabled = false;
            picbox_load1.Enabled = false;
            picbox_load2.Enabled = false;
            btn_start.Text = "초기화를 먼저 눌러주세요";
            btn_start.Enabled = false;
            DateTime dateTime = DateTime.Now;
            lbl_hi.Text = "              반갑습니다 !! ( " + dateTime.Year + "-" + dateTime.Month + "-" + dateTime.Day + " )               ";
            today_date = dateTime.ToString("yyyy-MM-dd");
        }
        #endregion
        #region 3# Program Info
        private void btn_cinfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("설정한 초주기로 로그파일을 체크합니다\n1초단위로만 설정가능합니다.");
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
                tmr_check.Interval = time * 1000;
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
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
                btn_start.Text = "알림전송 시작하기";
                btn_start.Enabled = true;
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
                /* FileStream file = new FileStream(full_location, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                 StreamReader sr = new StreamReader(file);
                 string str = sr.ReadToEnd();
                 if (temp != str)
                 {
                     temp = str;
                     //var toSend = api.SendMessageAsync(txtbox_num.Text, temp);
                     MessageBox.Show(temp);
                 }
                 sr.Close();
                 file.Close ();   */
                //var lines = File.ReadLines(full_location).Take(15).ToArray();
                //var count = File.ReadLines(full_location).Count(s => s.Contains("WARN"));
                //lines = File.ReadLines(full_location).Where(s => !String.IsNullOrWhiteSpace(s)).ToArray();
                var lines = File.ReadLines(full_location).Where(s => s.Contains("WARN"));
                
                foreach (var line in lines)
                {
                    if (old_log[i] != line)
                        MessageBox.Show(line);
                    old_log[i] = line;
                    i++;
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.ToString()); }
            
        }
        #endregion
        #region 7# Program VersionCheck
        private void btn_version_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            Stream stream = client.OpenRead("");
            StreamReader reader = new StreamReader(stream);
            string readText = reader.ReadToEnd();
            
            if (readText != lbl_version.Text)
            {
                if (MessageBox.Show("현재 최신버전이 아닙니다. \n" + "현재버전 : " + lbl_version.Text + "\n최신버전 : " + readText +
                    "\n최신버전을 다운로드 하시겠습니까 ?", "업데이트", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    String url = "";

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
                    String url = "";

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
            Application.ExitThread();
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
                        btn_active.Text = txtFile + " 에 액세스 중입니다";                      
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

        private void btn_start_Click(object sender, EventArgs e)
        {          
            try
            {
                SetToolBox();
                
                //isChecked(chk_check.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetToolBox()
        {
            if (btn_start.Text == "알림전송 시작하기")
            {
                btn_start.Text = "알림전송 실행중..";
                btn_start.ForeColor = Color.Tomato;
                btn_start.Location = new Point(45, 146);
                btn_start.Size = new Size(161, 25);
                picbox_load1.Enabled = true;
                picbox_load2.Enabled = true;
                picbox_load1.Location = new Point(14, 167);
                picbox_load2.Location = new Point(220, 167);
                txtbox_check.Enabled = false;
                txtbox_num.Enabled = false;
                int time = Convert.ToInt32(((TextBox)txtbox_check).Text);
                tmr_check.Interval = time * 1000;
                tmr_check.Enabled = true;
            }
            else
            {
                btn_start.Text = "알림전송 시작하기";
                btn_start.ForeColor = Color.DodgerBlue;
                btn_start.Location = new Point(6, 146);
                btn_start.Size = new Size(240, 25);
                picbox_load1.Enabled = false;
                picbox_load2.Enabled = false;
                picbox_load1.Location = new Point(571, 195);
                picbox_load2.Location = new Point(610, 195);
                txtbox_check.Enabled = true;
                txtbox_num.Enabled = true;
                tmr_check.Enabled = false;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            if (btn_update.Text == ">")
            {
                btn_update.Text = "<";              
                this.Size = new Size(488, 340);
                lbl_hi.Text = "                                       반갑습니다 !! ( " + dateTime.Year + "-" + dateTime.Month + "-" + dateTime.Day + " )                                           ";
            }
            else
            {
                btn_update.Text = ">";
                this.Size = new Size(287, 340);
                lbl_hi.Text = "              반갑습니다 !! ( " + dateTime.Year + "-" + dateTime.Month + "-" + dateTime.Day + " )               ";
            }
        }

        private void 창열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleChange(true, false);
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말 종료하시겠습니까 ?","테스트 프로그램", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.cms_tray.Visible = false;
                Application.ExitThread();
            }
        }
        private void VisibleChange(bool bVisible, bool bIconVisible)
        {
            this.Visible = bVisible;
            this.ni_icon.Visible = bIconVisible;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("정말로 종료하시겠습니까 ?", "테스트 프로그램", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //e.Cancel = true;
                Application.ExitThread();
            }
            
            //VisibleChange(false, true);
        }

        private void btn_tray_Click(object sender, EventArgs e)
        {
            VisibleChange(false, true);
        }

        private void 업데이트다운로드ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.ShowDialog();
        }

        private void 트레이모드ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleChange(false, true);
        }

        private void 종료ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말 종료하시겠습니까 ?", "테스트 프로그램", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void 업데이트내역보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            if (업데이트내역보기ToolStripMenuItem.Text == "업데이트내역 확인")
            {
                업데이트내역보기ToolStripMenuItem.Text = "업데이트내역 닫기";
                this.Size = new Size(488, 307);
                lbl_hi.Text = "                                       반갑습니다 !! ( " + dateTime.Year + "-" + dateTime.Month + "-" + dateTime.Day + " )                                           ";
            }
            else
            {
                업데이트내역보기ToolStripMenuItem.Text = "업데이트내역 확인";
                this.Size = new Size(287, 307);
                lbl_hi.Text = "              반갑습니다 !! ( " + dateTime.Year + "-" + dateTime.Month + "-" + dateTime.Day + " )               ";
            }
        }

        private void 업데이트파일다운ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void 경로저장하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateSaveFile();
            /*if (경로저장하기ToolStripMenuItem.CheckOnClick == false)
            {
                CreateSaveFile();
            }*/
        }

        private void CreateSaveFile()
        {
            string path = @"loc.dio";
            if (!File.Exists(path))
            {
                using (File.Create(path))
                {
                    
                }
                WriteSaveFile();
                MessageBox.Show("현재 설정된 경로를 저장하였습니다 !");
            }
            else
            {
                if (MessageBox.Show("이미 설정된 경로가 있습니다\n현재 경로로 바꿔 저장하시겠습니까 ?","Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (File.Create(path))
                    {
                        
                    }
                    WriteSaveFile();
                    MessageBox.Show("현재 설정된 경로로 변경하였습니다 !");
                }
            }
        }

        private void WriteSaveFile()
        {
            string path = @"loc.dio";
            if (File.Exists(path))
            {
                StringWrite(path);
            }
            else
            {
                CreateSaveFile();
            }
        }

        private void StringWrite(string path)
        {
            FileStream file = new FileStream(@"loc.dio", FileMode.Append, FileAccess.Write, FileShare.ReadWrite);     
            StreamWriter writer = new StreamWriter(file);
            writer.AutoFlush = true;
            writer.Write(folder_loacation);
            writer.Close();
            /*StreamWriter writer;
            writer = File.AppendText(path);
            writer.WriteLine(folder_loacation);
            writer.Close();*/
        }

        private void CheckSaveFile()
        {
            string path = @"loc.dio";
            if (File.Exists(path))
            {
                경로저장하기ToolStripMenuItem.Checked = true;
                FileStream file = new FileStream(@"loc.dio", FileMode.Open, FileAccess.Read, FileShare.ReadWrite); 
                StreamReader sr = new StreamReader(file); 
                string read = sr.ReadToEnd();
                folder_loacation = read;
                txtbox_loc.Text = folder_loacation;
                sr.Close(); 
                file.Close();          
            }
            else
            {

            }
        }
    }
}
