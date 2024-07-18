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
            this.lbl_num = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_version = new System.Windows.Forms.Label();
            this.lbl_ver = new System.Windows.Forms.Label();
            this.chk_check = new System.Windows.Forms.CheckBox();
            this.btn_cinfo = new System.Windows.Forms.Button();
            this.txtbox_check = new System.Windows.Forms.TextBox();
            this.txtbox_num = new System.Windows.Forms.TextBox();
            this.btn_active = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.btn_version = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_hi = new System.Windows.Forms.Label();
            this.tmr_check = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_loc = new System.Windows.Forms.Button();
            this.txtbox_loc = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_num.Location = new System.Drawing.Point(6, 38);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(70, 15);
            this.lbl_num.TabIndex = 0;
            this.lbl_num.Text = "착신 번호 : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_version);
            this.groupBox1.Controls.Add(this.lbl_ver);
            this.groupBox1.Controls.Add(this.chk_check);
            this.groupBox1.Controls.Add(this.btn_cinfo);
            this.groupBox1.Controls.Add(this.txtbox_check);
            this.groupBox1.Controls.Add(this.txtbox_num);
            this.groupBox1.Controls.Add(this.lbl_num);
            this.groupBox1.Location = new System.Drawing.Point(6, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 111);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_version.ForeColor = System.Drawing.Color.Red;
            this.lbl_version.Location = new System.Drawing.Point(210, 12);
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
            this.lbl_ver.Location = new System.Drawing.Point(147, 12);
            this.lbl_ver.Name = "lbl_ver";
            this.lbl_ver.Size = new System.Drawing.Size(61, 15);
            this.lbl_ver.TabIndex = 6;
            this.lbl_ver.Text = "Version  :";
            // 
            // chk_check
            // 
            this.chk_check.AutoSize = true;
            this.chk_check.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chk_check.Location = new System.Drawing.Point(6, 68);
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
            this.btn_cinfo.Location = new System.Drawing.Point(205, 64);
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
            this.txtbox_check.Location = new System.Drawing.Point(125, 64);
            this.txtbox_check.Name = "txtbox_check";
            this.txtbox_check.Size = new System.Drawing.Size(74, 23);
            this.txtbox_check.TabIndex = 3;
            this.txtbox_check.Text = "10000";
            this.txtbox_check.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbox_check.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_check_Press);
            // 
            // txtbox_num
            // 
            this.txtbox_num.BackColor = System.Drawing.Color.White;
            this.txtbox_num.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_num.Location = new System.Drawing.Point(78, 35);
            this.txtbox_num.Name = "txtbox_num";
            this.txtbox_num.Size = new System.Drawing.Size(156, 23);
            this.txtbox_num.TabIndex = 1;
            this.txtbox_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_active
            // 
            this.btn_active.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_active.Location = new System.Drawing.Point(6, 126);
            this.btn_active.Name = "btn_active";
            this.btn_active.Size = new System.Drawing.Size(240, 25);
            this.btn_active.TabIndex = 6;
            this.btn_active.Text = "초기화";
            this.btn_active.UseVisualStyleBackColor = true;
            this.btn_active.Click += new System.EventHandler(this.btn_active_Click);
            // 
            // btn_info
            // 
            this.btn_info.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_info.Location = new System.Drawing.Point(14, 222);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(76, 23);
            this.btn_info.TabIndex = 2;
            this.btn_info.Text = "정보";
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // btn_version
            // 
            this.btn_version.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_version.Location = new System.Drawing.Point(96, 222);
            this.btn_version.Name = "btn_version";
            this.btn_version.Size = new System.Drawing.Size(76, 23);
            this.btn_version.TabIndex = 3;
            this.btn_version.Text = "업데이트";
            this.btn_version.UseVisualStyleBackColor = true;
            this.btn_version.Click += new System.EventHandler(this.btn_version_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_exit.Location = new System.Drawing.Point(178, 222);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(76, 23);
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
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.btn_active);
            this.groupBox2.Location = new System.Drawing.Point(8, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 163);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // btn_loc
            // 
            this.btn_loc.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_loc.Location = new System.Drawing.Point(182, 193);
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
            this.txtbox_loc.Location = new System.Drawing.Point(14, 193);
            this.txtbox_loc.Name = "txtbox_loc";
            this.txtbox_loc.ReadOnly = true;
            this.txtbox_loc.Size = new System.Drawing.Size(158, 22);
            this.txtbox_loc.TabIndex = 9;
            this.txtbox_loc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(747, 467);
            this.Controls.Add(this.txtbox_loc);
            this.Controls.Add(this.btn_loc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_hi);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_version);
            this.Controls.Add(this.btn_info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "테스트";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
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
    }
}

