namespace Zaytsev_Demoex
{
    partial class UserPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.usr_login_lbl = new System.Windows.Forms.Label();
            this.usr_id_lbl = new System.Windows.Forms.Label();
            this.fio_user_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.find_ord_btn = new System.Windows.Forms.Button();
            this.prod_btn = new System.Windows.Forms.Button();
            this.sidepan = new System.Windows.Forms.Panel();
            this.home_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.user_home_control1 = new Zaytsev_Demoex.controls.user_home_control();
            this.user_prod_control1 = new Zaytsev_Demoex.controls.user_prod_control();
            this.usr_order_control1 = new Zaytsev_Demoex.controls.usr_order_control();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(336, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "ООО \"Украшение\"";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(203)))));
            this.panel2.Controls.Add(this.usr_login_lbl);
            this.panel2.Controls.Add(this.usr_id_lbl);
            this.panel2.Controls.Add(this.fio_user_lbl);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(940, 39);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // usr_login_lbl
            // 
            this.usr_login_lbl.AutoSize = true;
            this.usr_login_lbl.Location = new System.Drawing.Point(6, 9);
            this.usr_login_lbl.Name = "usr_login_lbl";
            this.usr_login_lbl.Size = new System.Drawing.Size(35, 13);
            this.usr_login_lbl.TabIndex = 19;
            this.usr_login_lbl.Text = "label3";
            // 
            // usr_id_lbl
            // 
            this.usr_id_lbl.AutoSize = true;
            this.usr_id_lbl.Location = new System.Drawing.Point(736, 12);
            this.usr_id_lbl.Name = "usr_id_lbl";
            this.usr_id_lbl.Size = new System.Drawing.Size(35, 13);
            this.usr_id_lbl.TabIndex = 18;
            this.usr_id_lbl.Text = "label3";
            this.usr_id_lbl.Visible = false;
            // 
            // fio_user_lbl
            // 
            this.fio_user_lbl.AutoSize = true;
            this.fio_user_lbl.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio_user_lbl.Location = new System.Drawing.Point(363, 4);
            this.fio_user_lbl.Name = "fio_user_lbl";
            this.fio_user_lbl.Size = new System.Drawing.Size(0, 30);
            this.fio_user_lbl.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(136, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 30);
            this.label2.TabIndex = 16;
            this.label2.Text = "Добро пожаловать,";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(203)))));
            this.panel1.Controls.Add(this.find_ord_btn);
            this.panel1.Controls.Add(this.prod_btn);
            this.panel1.Controls.Add(this.sidepan);
            this.panel1.Controls.Add(this.home_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 558);
            this.panel1.TabIndex = 4;
            // 
            // find_ord_btn
            // 
            this.find_ord_btn.BackColor = System.Drawing.Color.Transparent;
            this.find_ord_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.find_ord_btn.FlatAppearance.BorderSize = 0;
            this.find_ord_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.find_ord_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepPink;
            this.find_ord_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.find_ord_btn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.find_ord_btn.ForeColor = System.Drawing.Color.Black;
            this.find_ord_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.find_ord_btn.Location = new System.Drawing.Point(12, 214);
            this.find_ord_btn.Name = "find_ord_btn";
            this.find_ord_btn.Size = new System.Drawing.Size(188, 38);
            this.find_ord_btn.TabIndex = 27;
            this.find_ord_btn.Text = "Найти заказ";
            this.find_ord_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.find_ord_btn.UseVisualStyleBackColor = false;
            this.find_ord_btn.Click += new System.EventHandler(this.find_ord_btn_Click);
            // 
            // prod_btn
            // 
            this.prod_btn.BackColor = System.Drawing.Color.Transparent;
            this.prod_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prod_btn.FlatAppearance.BorderSize = 0;
            this.prod_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.prod_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepPink;
            this.prod_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prod_btn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prod_btn.ForeColor = System.Drawing.Color.Black;
            this.prod_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.prod_btn.Location = new System.Drawing.Point(12, 148);
            this.prod_btn.Name = "prod_btn";
            this.prod_btn.Size = new System.Drawing.Size(188, 31);
            this.prod_btn.TabIndex = 26;
            this.prod_btn.Text = "Товары";
            this.prod_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.prod_btn.UseVisualStyleBackColor = false;
            this.prod_btn.Click += new System.EventHandler(this.prod_btn_Click);
            // 
            // sidepan
            // 
            this.sidepan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(89)))), ((int)(((byte)(17)))));
            this.sidepan.Location = new System.Drawing.Point(3, 83);
            this.sidepan.Name = "sidepan";
            this.sidepan.Size = new System.Drawing.Size(10, 35);
            this.sidepan.TabIndex = 5;
            // 
            // home_btn
            // 
            this.home_btn.BackColor = System.Drawing.Color.Transparent;
            this.home_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home_btn.FlatAppearance.BorderSize = 0;
            this.home_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.home_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepPink;
            this.home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_btn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.home_btn.ForeColor = System.Drawing.Color.Black;
            this.home_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_btn.Location = new System.Drawing.Point(12, 83);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(188, 31);
            this.home_btn.TabIndex = 25;
            this.home_btn.Text = "Главная";
            this.home_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.home_btn.UseVisualStyleBackColor = false;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Zaytsev_Demoex.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(230, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // user_home_control1
            // 
            this.user_home_control1.BackColor = System.Drawing.Color.White;
            this.user_home_control1.Location = new System.Drawing.Point(200, 146);
            this.user_home_control1.Name = "user_home_control1";
            this.user_home_control1.Size = new System.Drawing.Size(940, 412);
            this.user_home_control1.TabIndex = 16;
            // 
            // user_prod_control1
            // 
            this.user_prod_control1.BackColor = System.Drawing.Color.White;
            this.user_prod_control1.Location = new System.Drawing.Point(200, 146);
            this.user_prod_control1.Name = "user_prod_control1";
            this.user_prod_control1.Size = new System.Drawing.Size(940, 412);
            this.user_prod_control1.TabIndex = 15;
            this.user_prod_control1.Load += new System.EventHandler(this.user_prod_control1_Load);
            // 
            // usr_order_control1
            // 
            this.usr_order_control1.BackColor = System.Drawing.Color.White;
            this.usr_order_control1.Location = new System.Drawing.Point(200, 146);
            this.usr_order_control1.Name = "usr_order_control1";
            this.usr_order_control1.Size = new System.Drawing.Size(940, 412);
            this.usr_order_control1.TabIndex = 17;
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1140, 558);
            this.Controls.Add(this.usr_order_control1);
            this.Controls.Add(this.user_home_control1);
            this.Controls.Add(this.user_prod_control1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserPanel";
            this.Text = "UserPanel";
            this.Load += new System.EventHandler(this.UserPanel_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button find_ord_btn;
        private System.Windows.Forms.Button prod_btn;
        private System.Windows.Forms.Panel sidepan;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private controls.user_prod_control user_prod_control1;
        private System.Windows.Forms.Label usr_id_lbl;
        private System.Windows.Forms.Label fio_user_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label usr_login_lbl;
        private controls.user_home_control user_home_control1;
        private controls.usr_order_control usr_order_control1;
    }
}