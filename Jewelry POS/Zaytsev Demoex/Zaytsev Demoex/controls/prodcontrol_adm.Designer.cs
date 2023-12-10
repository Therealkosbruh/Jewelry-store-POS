namespace Zaytsev_Demoex.controls
{
    partial class prodcontrol_adm
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.prod_grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.find_prod_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.prod_filter_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.del_prod_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.add_prod_trans = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.sale_qty_lbl = new System.Windows.Forms.Label();
            this.sale_price_lbl = new System.Windows.Forms.Label();
            this.price_lbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.desc_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sale_filter_cb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prod_grid)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // prod_grid
            // 
            this.prod_grid.BackgroundColor = System.Drawing.Color.White;
            this.prod_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prod_grid.Location = new System.Drawing.Point(16, 91);
            this.prod_grid.Name = "prod_grid";
            this.prod_grid.Size = new System.Drawing.Size(400, 217);
            this.prod_grid.TabIndex = 0;
            this.prod_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prod_grid_CellClick);
            this.prod_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Товары";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // find_prod_btn
            // 
            this.find_prod_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(89)))), ((int)(((byte)(17)))));
            this.find_prod_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.find_prod_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.find_prod_btn.Location = new System.Drawing.Point(538, 120);
            this.find_prod_btn.Name = "find_prod_btn";
            this.find_prod_btn.Size = new System.Drawing.Size(123, 34);
            this.find_prod_btn.TabIndex = 15;
            this.find_prod_btn.Text = "Найти";
            this.find_prod_btn.UseVisualStyleBackColor = false;
            this.find_prod_btn.Click += new System.EventHandler(this.find_prod_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(89)))), ((int)(((byte)(17)))));
            this.panel1.Location = new System.Drawing.Point(527, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 1);
            this.panel1.TabIndex = 19;
            // 
            // prod_filter_tb
            // 
            this.prod_filter_tb.BackColor = System.Drawing.Color.White;
            this.prod_filter_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prod_filter_tb.Location = new System.Drawing.Point(527, 78);
            this.prod_filter_tb.Name = "prod_filter_tb";
            this.prod_filter_tb.Size = new System.Drawing.Size(150, 13);
            this.prod_filter_tb.TabIndex = 18;
            this.prod_filter_tb.TextChanged += new System.EventHandler(this.prod_filter_tb_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(479, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 30);
            this.label3.TabIndex = 20;
            this.label3.Text = "Id";
            // 
            // del_prod_btn
            // 
            this.del_prod_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(89)))), ((int)(((byte)(17)))));
            this.del_prod_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.del_prod_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_prod_btn.Location = new System.Drawing.Point(600, 199);
            this.del_prod_btn.Name = "del_prod_btn";
            this.del_prod_btn.Size = new System.Drawing.Size(109, 34);
            this.del_prod_btn.TabIndex = 21;
            this.del_prod_btn.Text = "Удалить";
            this.del_prod_btn.UseVisualStyleBackColor = false;
            this.del_prod_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(89)))), ((int)(((byte)(17)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(484, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 34);
            this.button2.TabIndex = 22;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // add_prod_trans
            // 
            this.add_prod_trans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(89)))), ((int)(((byte)(17)))));
            this.add_prod_trans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_prod_trans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_prod_trans.Location = new System.Drawing.Point(538, 249);
            this.add_prod_trans.Name = "add_prod_trans";
            this.add_prod_trans.Size = new System.Drawing.Size(109, 34);
            this.add_prod_trans.TabIndex = 23;
            this.add_prod_trans.Text = "Добавить";
            this.add_prod_trans.UseVisualStyleBackColor = false;
            this.add_prod_trans.Click += new System.EventHandler(this.add_prod_trans_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(203)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 291);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(745, 117);
            this.panel2.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(549, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Скидка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(292, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Описание";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(50, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Фото";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.sale_qty_lbl);
            this.panel4.Controls.Add(this.sale_price_lbl);
            this.panel4.Controls.Add(this.price_lbl);
            this.panel4.Location = new System.Drawing.Point(527, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(130, 77);
            this.panel4.TabIndex = 2;
            // 
            // sale_qty_lbl
            // 
            this.sale_qty_lbl.AutoSize = true;
            this.sale_qty_lbl.Location = new System.Drawing.Point(93, 9);
            this.sale_qty_lbl.Name = "sale_qty_lbl";
            this.sale_qty_lbl.Size = new System.Drawing.Size(35, 13);
            this.sale_qty_lbl.TabIndex = 29;
            this.sale_qty_lbl.Text = "label8";
            this.sale_qty_lbl.Visible = false;
            // 
            // sale_price_lbl
            // 
            this.sale_price_lbl.AutoSize = true;
            this.sale_price_lbl.Location = new System.Drawing.Point(42, 42);
            this.sale_price_lbl.Name = "sale_price_lbl";
            this.sale_price_lbl.Size = new System.Drawing.Size(35, 13);
            this.sale_price_lbl.TabIndex = 28;
            this.sale_price_lbl.Text = "label8";
            // 
            // price_lbl
            // 
            this.price_lbl.AutoSize = true;
            this.price_lbl.Location = new System.Drawing.Point(42, 9);
            this.price_lbl.Name = "price_lbl";
            this.price_lbl.Size = new System.Drawing.Size(35, 13);
            this.price_lbl.TabIndex = 28;
            this.price_lbl.Text = "label8";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.desc_lbl);
            this.panel3.Location = new System.Drawing.Point(247, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 77);
            this.panel3.TabIndex = 1;
            // 
            // desc_lbl
            // 
            this.desc_lbl.AutoSize = true;
            this.desc_lbl.Location = new System.Drawing.Point(3, 9);
            this.desc_lbl.Name = "desc_lbl";
            this.desc_lbl.Size = new System.Drawing.Size(35, 13);
            this.desc_lbl.TabIndex = 0;
            this.desc_lbl.Text = "label8";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 77);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // sale_filter_cb
            // 
            this.sale_filter_cb.FormattingEnabled = true;
            this.sale_filter_cb.Items.AddRange(new object[] {
            "Все диапазоны",
            "0-9,99%",
            "10-14,99%",
            "15% и более"});
            this.sale_filter_cb.Location = new System.Drawing.Point(139, 58);
            this.sale_filter_cb.Name = "sale_filter_cb";
            this.sale_filter_cb.Size = new System.Drawing.Size(121, 21);
            this.sale_filter_cb.TabIndex = 26;
            this.sale_filter_cb.SelectedIndexChanged += new System.EventHandler(this.sale_filter_cb_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(13, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 23);
            this.label7.TabIndex = 27;
            this.label7.Text = "Размер скидки";
            // 
            // prodcontrol_adm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sale_filter_cb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.add_prod_trans);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.del_prod_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.prod_filter_tb);
            this.Controls.Add(this.find_prod_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prod_grid);
            this.Name = "prodcontrol_adm";
            this.Size = new System.Drawing.Size(745, 408);
            this.Load += new System.EventHandler(this.prodcontrol_adm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prod_grid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView prod_grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button find_prod_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox prod_filter_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button del_prod_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button add_prod_trans;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox sale_filter_cb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label sale_price_lbl;
        private System.Windows.Forms.Label price_lbl;
        private System.Windows.Forms.Label desc_lbl;
        private System.Windows.Forms.Label sale_qty_lbl;
    }
}
