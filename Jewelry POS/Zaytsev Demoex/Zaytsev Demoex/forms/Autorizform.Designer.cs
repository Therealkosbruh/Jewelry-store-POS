namespace Zaytsev_Demoex
{
    partial class Autorizform
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.regtransit_btn = new System.Windows.Forms.Button();
            this.rmmbr_chb = new System.Windows.Forms.CheckBox();
            this.guestlink = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pass_tb = new System.Windows.Forms.TextBox();
            this.login_tb = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // regtransit_btn
            // 
            this.regtransit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(89)))), ((int)(((byte)(17)))));
            this.regtransit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regtransit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regtransit_btn.Location = new System.Drawing.Point(214, 372);
            this.regtransit_btn.Name = "regtransit_btn";
            this.regtransit_btn.Size = new System.Drawing.Size(123, 34);
            this.regtransit_btn.TabIndex = 23;
            this.regtransit_btn.Text = "Регистрация";
            this.regtransit_btn.UseVisualStyleBackColor = false;
            // 
            // rmmbr_chb
            // 
            this.rmmbr_chb.AutoSize = true;
            this.rmmbr_chb.Location = new System.Drawing.Point(158, 293);
            this.rmmbr_chb.Name = "rmmbr_chb";
            this.rmmbr_chb.Size = new System.Drawing.Size(111, 17);
            this.rmmbr_chb.TabIndex = 22;
            this.rmmbr_chb.Text = "Запомнить меня";
            this.rmmbr_chb.UseVisualStyleBackColor = true;
            // 
            // guestlink
            // 
            this.guestlink.AutoSize = true;
            this.guestlink.Location = new System.Drawing.Point(139, 322);
            this.guestlink.Name = "guestlink";
            this.guestlink.Size = new System.Drawing.Size(153, 13);
            this.guestlink.TabIndex = 21;
            this.guestlink.TabStop = true;
            this.guestlink.Text = "Продолжить в режиме гостя";
            this.guestlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.guestlink_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(87, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(87, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Логин";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(89)))), ((int)(((byte)(17)))));
            this.panel2.Location = new System.Drawing.Point(158, 267);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 1);
            this.panel2.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(89)))), ((int)(((byte)(17)))));
            this.panel1.Location = new System.Drawing.Point(158, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 1);
            this.panel1.TabIndex = 17;
            // 
            // pass_tb
            // 
            this.pass_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(203)))));
            this.pass_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass_tb.Location = new System.Drawing.Point(158, 241);
            this.pass_tb.Name = "pass_tb";
            this.pass_tb.PasswordChar = '*';
            this.pass_tb.Size = new System.Drawing.Size(150, 13);
            this.pass_tb.TabIndex = 16;
            // 
            // login_tb
            // 
            this.login_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(203)))));
            this.login_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_tb.Location = new System.Drawing.Point(158, 191);
            this.login_tb.Name = "login_tb";
            this.login_tb.Size = new System.Drawing.Size(150, 13);
            this.login_tb.TabIndex = 15;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(89)))), ((int)(((byte)(17)))));
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Location = new System.Drawing.Point(63, 372);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(123, 34);
            this.login_btn.TabIndex = 14;
            this.login_btn.Text = "Войти";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Zaytsev_Demoex.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(169, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(111, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "ООО \"Украшение\"";
            // 
            // Autorizform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(395, 451);
            this.Controls.Add(this.regtransit_btn);
            this.Controls.Add(this.rmmbr_chb);
            this.Controls.Add(this.guestlink);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pass_tb);
            this.Controls.Add(this.login_tb);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Autorizform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Autorizform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regtransit_btn;
        private System.Windows.Forms.CheckBox rmmbr_chb;
        private System.Windows.Forms.LinkLabel guestlink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox pass_tb;
        private System.Windows.Forms.TextBox login_tb;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

