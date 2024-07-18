namespace SendTest
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_num = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbox_num = new System.Windows.Forms.TextBox();
            this.lbl_version = new System.Windows.Forms.Label();
            this.lbl_ver = new System.Windows.Forms.Label();
            this.chk_check = new System.Windows.Forms.CheckBox();
            this.btn_cinfo = new System.Windows.Forms.Button();
            this.txtbox_check = new System.Windows.Forms.TextBox();
            this.btn_active = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.btn_version = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_hi = new System.Windows.Forms.Label();
            this.tmr_check = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_loc = new System.Windows.Forms.Button();
            this.txtbox_loc = new System.Windows.Forms.TextBox();
            this.picbox_load1 = new System.Windows.Forms.PictureBox();
            this.picbox_load2 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtbox_update = new System.Windows.Forms.TextBox();
            this.cms_tray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.창열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ni_icon = new System.Windows.Forms.NotifyIcon(this.components);
            this.btn_tray = new System.Windows.Forms.Button();
            this.ms_menu = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기능ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.트레이모드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.업데이트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.업데이트파일다운ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.업데이트내역보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.경로저장하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_load1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_load2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.cms_tray.SuspendLayout();
            this.ms_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_num.Location = new System.Drawing.Point(100, 25);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(115, 15);
            this.lbl_num.TabIndex = 0;
            this.lbl_num.Text = "초 주기로 로그 확인";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbox_num);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(6, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 56);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "착신번호";
            // 
            // txtbox_num
            // 
            this.txtbox_num.BackColor = System.Drawing.Color.White;
            this.txtbox_num.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_num.Location = new System.Drawing.Point(6, 22);
            this.txtbox_num.Name = "txtbox_num";
            this.txtbox_num.Size = new System.Drawing.Size(228, 23);
            this.txtbox_num.TabIndex = 1;
            this.txtbox_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_version.ForeColor = System.Drawing.Color.Red;
            this.lbl_version.Location = new System.Drawing.Point(225, 12);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(24, 15);
            this.lbl_version.TabIndex = 7;
            this.lbl_version.Text = "0.9";
            // 
            // lbl_ver
            // 
            this.lbl_ver.AutoSize = true;
            this.lbl_ver.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_ver.ForeColor = System.Drawing.Color.Red;
            this.lbl_ver.Location = new System.Drawing.Point(160, 12);
            this.lbl_ver.Name = "lbl_ver";
            this.lbl_ver.Size = new System.Drawing.Size(61, 15);
            this.lbl_ver.TabIndex = 6;
            this.lbl_ver.Text = "Version  :";
            // 
            // chk_check
            // 
            this.chk_check.AutoSize = true;
            this.chk_check.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chk_check.Location = new System.Drawing.Point(566, 130);
            this.chk_check.Name = "chk_check";
            this.chk_check.Size = new System.Drawing.Size(113, 19);
            this.chk_check.TabIndex = 5;
            this.chk_check.Text = "알림확인 시작 : ";
            this.chk_check.UseVisualStyleBackColor = true;
            this.chk_check.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn_cinfo
            // 
            this.btn_cinfo.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_cinfo.Location = new System.Drawing.Point(6, 21);
            this.btn_cinfo.Name = "btn_cinfo";
            this.btn_cinfo.Size = new System.Drawing.Size(29, 23);
            this.btn_cinfo.TabIndex = 4;
            this.btn_cinfo.Text = "?";
            this.btn_cinfo.UseVisualStyleBackColor = true;
            this.btn_cinfo.Click += new System.EventHandler(this.btn_cinfo_Click);
            // 
            // txtbox_check
            // 
            this.txtbox_check.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_check.Location = new System.Drawing.Point(41, 22);
            this.txtbox_check.Name = "txtbox_check";
            this.txtbox_check.Size = new System.Drawing.Size(56, 23);
            this.txtbox_check.TabIndex = 3;
            this.txtbox_check.Text = "10";
            this.txtbox_check.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbox_check.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_check_Press);
            // 
            // btn_active
            // 
            this.btn_active.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_active.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_active.Location = new System.Drawing.Point(6, 177);
            this.btn_active.Name = "btn_active";
            this.btn_active.Size = new System.Drawing.Size(239, 25);
            this.btn_active.TabIndex = 6;
            this.btn_active.Text = "초기화";
            this.btn_active.UseVisualStyleBackColor = true;
            this.btn_active.Click += new System.EventHandler(this.btn_active_Click);
            // 
            // btn_info
            // 
            this.btn_info.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_info.Location = new System.Drawing.Point(89, 383);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(50, 23);
            this.btn_info.TabIndex = 2;
            this.btn_info.Text = "정보";
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // btn_version
            // 
            this.btn_version.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_version.Location = new System.Drawing.Point(145, 383);
            this.btn_version.Name = "btn_version";
            this.btn_version.Size = new System.Drawing.Size(69, 23);
            this.btn_version.TabIndex = 3;
            this.btn_version.Text = "업데이트";
            this.btn_version.UseVisualStyleBackColor = true;
            this.btn_version.Click += new System.EventHandler(this.btn_version_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_exit.Location = new System.Drawing.Point(279, 383);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(49, 23);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "종료";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_hi
            // 
            this.lbl_hi.AutoSize = true;
            this.lbl_hi.BackColor = System.Drawing.Color.Black;
            this.lbl_hi.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_hi.ForeColor = System.Drawing.Color.White;
            this.lbl_hi.Location = new System.Drawing.Point(-2, -1);
            this.lbl_hi.Name = "lbl_hi";
            this.lbl_hi.Size = new System.Drawing.Size(127, 15);
            this.lbl_hi.TabIndex = 5;
            this.lbl_hi.Text = "                              ";
            // 
            // tmr_check
            // 
            this.tmr_check.Tick += new System.EventHandler(this.tmr_check_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_start);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.lbl_version);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.lbl_ver);
            this.groupBox2.Controls.Add(this.btn_active);
            this.groupBox2.Location = new System.Drawing.Point(8, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 208);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_start.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_start.Location = new System.Drawing.Point(6, 146);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(239, 25);
            this.btn_start.TabIndex = 9;
            this.btn_start.Text = "알림전송 시작하기";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtbox_check);
            this.groupBox3.Controls.Add(this.lbl_num);
            this.groupBox3.Controls.Add(this.btn_cinfo);
            this.groupBox3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(6, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 55);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "알림";
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_update.Location = new System.Drawing.Point(334, 381);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(30, 25);
            this.btn_update.TabIndex = 12;
            this.btn_update.Text = ">";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_loc
            // 
            this.btn_loc.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_loc.Location = new System.Drawing.Point(182, 238);
            this.btn_loc.Name = "btn_loc";
            this.btn_loc.Size = new System.Drawing.Size(71, 23);
            this.btn_loc.TabIndex = 8;
            this.btn_loc.Text = "경로설정";
            this.btn_loc.UseVisualStyleBackColor = true;
            this.btn_loc.Click += new System.EventHandler(this.btn_loc_Click);
            // 
            // txtbox_loc
            // 
            this.txtbox_loc.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_loc.Location = new System.Drawing.Point(14, 238);
            this.txtbox_loc.Name = "txtbox_loc";
            this.txtbox_loc.ReadOnly = true;
            this.txtbox_loc.Size = new System.Drawing.Size(158, 22);
            this.txtbox_loc.TabIndex = 9;
            this.txtbox_loc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picbox_load1
            // 
            this.picbox_load1.Image = ((System.Drawing.Image)(resources.GetObject("picbox_load1.Image")));
            this.picbox_load1.Location = new System.Drawing.Point(571, 195);
            this.picbox_load1.Name = "picbox_load1";
            this.picbox_load1.Size = new System.Drawing.Size(33, 31);
            this.picbox_load1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_load1.TabIndex = 10;
            this.picbox_load1.TabStop = false;
            // 
            // picbox_load2
            // 
            this.picbox_load2.Image = ((System.Drawing.Image)(resources.GetObject("picbox_load2.Image")));
            this.picbox_load2.Location = new System.Drawing.Point(610, 195);
            this.picbox_load2.Name = "picbox_load2";
            this.picbox_load2.Size = new System.Drawing.Size(33, 31);
            this.picbox_load2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_load2.TabIndex = 11;
            this.picbox_load2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtbox_update);
            this.groupBox4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.Location = new System.Drawing.Point(275, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(188, 237);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "업데이트 내역";
            // 
            // txtbox_update
            // 
            this.txtbox_update.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_update.Location = new System.Drawing.Point(10, 24);
            this.txtbox_update.Multiline = true;
            this.txtbox_update.Name = "txtbox_update";
            this.txtbox_update.ReadOnly = true;
            this.txtbox_update.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbox_update.Size = new System.Drawing.Size(167, 196);
            this.txtbox_update.TabIndex = 0;
            this.txtbox_update.Text = "Version ~ 0.7 :: AlphaTest\r\n>> 고정파일 체크가능\r\n>> 체크주기 설정가능\r\n>> 프로그램 업데이트 기능추가\r\n\r\nVers" +
    "ion 0.8 :: BetaTest\r\n>> 경로설정 추가\r\n>> 경로저장기능 추가\r\n>> 경로의 금일 생성된 txt 확장자 파일 자동읽기\r\n\r\n" +
    "";
            // 
            // cms_tray
            // 
            this.cms_tray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.창열기ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.cms_tray.Name = "cms_tray";
            this.cms_tray.Size = new System.Drawing.Size(115, 48);
            // 
            // 창열기ToolStripMenuItem
            // 
            this.창열기ToolStripMenuItem.Name = "창열기ToolStripMenuItem";
            this.창열기ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.창열기ToolStripMenuItem.Text = "창 열기";
            this.창열기ToolStripMenuItem.Click += new System.EventHandler(this.창열기ToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // ni_icon
            // 
            this.ni_icon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ni_icon.BalloonTipText = "트레이 최소화 되었습니다 !!";
            this.ni_icon.BalloonTipTitle = "테스트 프로그램";
            this.ni_icon.ContextMenuStrip = this.cms_tray;
            this.ni_icon.Icon = ((System.Drawing.Icon)(resources.GetObject("ni_icon.Icon")));
            this.ni_icon.Text = "테스트 프로그램";
            this.ni_icon.Visible = true;
            // 
            // btn_tray
            // 
            this.btn_tray.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_tray.Location = new System.Drawing.Point(220, 383);
            this.btn_tray.Name = "btn_tray";
            this.btn_tray.Size = new System.Drawing.Size(53, 23);
            this.btn_tray.TabIndex = 14;
            this.btn_tray.Text = "트레이";
            this.btn_tray.UseVisualStyleBackColor = true;
            this.btn_tray.Click += new System.EventHandler(this.btn_tray_Click);
            // 
            // ms_menu
            // 
            this.ms_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.기능ToolStripMenuItem,
            this.업데이트ToolStripMenuItem});
            this.ms_menu.Location = new System.Drawing.Point(0, 0);
            this.ms_menu.Name = "ms_menu";
            this.ms_menu.Size = new System.Drawing.Size(271, 24);
            this.ms_menu.TabIndex = 15;
            this.ms_menu.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.정보ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 정보ToolStripMenuItem
            // 
            this.정보ToolStripMenuItem.Name = "정보ToolStripMenuItem";
            this.정보ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.정보ToolStripMenuItem.Text = "정보";
            this.정보ToolStripMenuItem.Click += new System.EventHandler(this.정보ToolStripMenuItem_Click);
            // 
            // 기능ToolStripMenuItem
            // 
            this.기능ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.경로저장하기ToolStripMenuItem,
            this.트레이모드ToolStripMenuItem,
            this.종료ToolStripMenuItem1});
            this.기능ToolStripMenuItem.Name = "기능ToolStripMenuItem";
            this.기능ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.기능ToolStripMenuItem.Text = "기능";
            // 
            // 트레이모드ToolStripMenuItem
            // 
            this.트레이모드ToolStripMenuItem.Name = "트레이모드ToolStripMenuItem";
            this.트레이모드ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.트레이모드ToolStripMenuItem.Text = "트레이 최소화";
            this.트레이모드ToolStripMenuItem.Click += new System.EventHandler(this.트레이모드ToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem1
            // 
            this.종료ToolStripMenuItem1.Name = "종료ToolStripMenuItem1";
            this.종료ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.종료ToolStripMenuItem1.Text = "종료";
            this.종료ToolStripMenuItem1.Click += new System.EventHandler(this.종료ToolStripMenuItem1_Click);
            // 
            // 업데이트ToolStripMenuItem
            // 
            this.업데이트ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.업데이트파일다운ToolStripMenuItem,
            this.업데이트내역보기ToolStripMenuItem});
            this.업데이트ToolStripMenuItem.Name = "업데이트ToolStripMenuItem";
            this.업데이트ToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.업데이트ToolStripMenuItem.Text = "프로그램 업데이트";
            // 
            // 업데이트파일다운ToolStripMenuItem
            // 
            this.업데이트파일다운ToolStripMenuItem.Name = "업데이트파일다운ToolStripMenuItem";
            this.업데이트파일다운ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.업데이트파일다운ToolStripMenuItem.Text = "최신파일 다운로드";
            this.업데이트파일다운ToolStripMenuItem.Click += new System.EventHandler(this.업데이트파일다운ToolStripMenuItem_Click);
            // 
            // 업데이트내역보기ToolStripMenuItem
            // 
            this.업데이트내역보기ToolStripMenuItem.Name = "업데이트내역보기ToolStripMenuItem";
            this.업데이트내역보기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.업데이트내역보기ToolStripMenuItem.Text = "업데이트내역 확인";
            this.업데이트내역보기ToolStripMenuItem.Click += new System.EventHandler(this.업데이트내역보기ToolStripMenuItem_Click);
            // 
            // 경로저장하기ToolStripMenuItem
            // 
            this.경로저장하기ToolStripMenuItem.CheckOnClick = true;
            this.경로저장하기ToolStripMenuItem.Name = "경로저장하기ToolStripMenuItem";
            this.경로저장하기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.경로저장하기ToolStripMenuItem.Text = "경로 저장하기";
            this.경로저장하기ToolStripMenuItem.Click += new System.EventHandler(this.경로저장하기ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(271, 268);
            this.Controls.Add(this.ms_menu);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_tray);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.picbox_load2);
            this.Controls.Add(this.picbox_load1);
            this.Controls.Add(this.txtbox_loc);
            this.Controls.Add(this.btn_loc);
            this.Controls.Add(this.chk_check);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_hi);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_version);
            this.Controls.Add(this.btn_info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms_menu;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "테스트";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_load1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_load2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.cms_tray.ResumeLayout(false);
            this.ms_menu.ResumeLayout(false);
            this.ms_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbox_num;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button btn_version;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_cinfo;
        private System.Windows.Forms.TextBox txtbox_check;
        private System.Windows.Forms.Button btn_active;
        private System.Windows.Forms.CheckBox chk_check;
        private System.Windows.Forms.Label lbl_hi;
        private System.Windows.Forms.Timer tmr_check;
        private System.Windows.Forms.Label lbl_ver;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_loc;
        private System.Windows.Forms.TextBox txtbox_loc;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox picbox_load1;
        private System.Windows.Forms.PictureBox picbox_load2;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtbox_update;
        private System.Windows.Forms.ContextMenuStrip cms_tray;
        private System.Windows.Forms.ToolStripMenuItem 창열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon ni_icon;
        private System.Windows.Forms.Button btn_tray;
        private System.Windows.Forms.MenuStrip ms_menu;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 기능ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 트레이모드ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 업데이트ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 업데이트파일다운ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 업데이트내역보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 경로저장하기ToolStripMenuItem;
    }
}

