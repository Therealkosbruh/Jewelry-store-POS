namespace Zaytsev_Demoex.controls
{
    partial class user_prod_control
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
            this.label2 = new System.Windows.Forms.Label();
            this.prod_grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
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
            this.label9 = new System.Windows.Forms.Label();
            this.sale_filter_cb = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.prod_filter_tb = new System.Windows.Forms.TextBox();
            this.add_to_cart_btn = new System.Windows.Forms.Button();
            this.cartList = new System.Windows.Forms.DataGridView();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete_btn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.total_price_tb = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.make_ord_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.address_cb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.retr_code_lbl = new System.Windows.Forms.Label();
            this.ord_number_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usr_label = new System.Windows.Forms.Label();
            this.addr_index = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prod_grid)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // prod_grid
            // 
            this.prod_grid.BackgroundColor = System.Drawing.Color.White;
            this.prod_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prod_grid.Location = new System.Drawing.Point(3, 89);
            this.prod_grid.Name = "prod_grid";
            this.prod_grid.Size = new System.Drawing.Size(352, 196);
            this.prod_grid.TabIndex = 11;
            this.prod_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prod_grid_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(195, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "Каталог";
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
            this.panel2.Location = new System.Drawing.Point(0, 295);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(521, 117);
            this.panel2.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(369, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Скидка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(172, 86);
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
            this.panel4.Location = new System.Drawing.Point(328, 6);
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
            this.panel3.Location = new System.Drawing.Point(142, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 77);
            this.panel3.TabIndex = 1;
            // 
            // desc_lbl
            // 
            this.desc_lbl.AutoSize = true;
            this.desc_lbl.Location = new System.Drawing.Point(23, 9);
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(7, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 23);
            this.label9.TabIndex = 29;
            this.label9.Text = "Размер скидки";
            // 
            // sale_filter_cb
            // 
            this.sale_filter_cb.FormattingEnabled = true;
            this.sale_filter_cb.Items.AddRange(new object[] {
            "Все диапазоны",
            "0-9,99%",
            "10-14,99%",
            "15% и более"});
            this.sale_filter_cb.Location = new System.Drawing.Point(133, 52);
            this.sale_filter_cb.Name = "sale_filter_cb";
            this.sale_filter_cb.Size = new System.Drawing.Size(103, 21);
            this.sale_filter_cb.TabIndex = 28;
            this.sale_filter_cb.SelectedIndexChanged += new System.EventHandler(this.sale_filter_cb_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(250, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 19);
            this.label10.TabIndex = 32;
            this.label10.Text = "Название";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(89)))), ((int)(((byte)(17)))));
            this.panel6.Location = new System.Drawing.Point(324, 80);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(150, 1);
            this.panel6.TabIndex = 31;
            // 
            // prod_filter_tb
            // 
            this.prod_filter_tb.BackColor = System.Drawing.Color.White;
            this.prod_filter_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prod_filter_tb.Location = new System.Drawing.Point(324, 54);
            this.prod_filter_tb.Name = "prod_filter_tb";
            this.prod_filter_tb.Size = new System.Drawing.Size(150, 13);
            this.prod_filter_tb.TabIndex = 30;
            this.prod_filter_tb.TextChanged += new System.EventHandler(this.prod_filter_tb_TextChanged);
            // 
            // add_to_cart_btn
            // 
            this.add_to_cart_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(89)))), ((int)(((byte)(17)))));
            this.add_to_cart_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_to_cart_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_to_cart_btn.Location = new System.Drawing.Point(361, 246);
            this.add_to_cart_btn.Name = "add_to_cart_btn";
            this.add_to_cart_btn.Size = new System.Drawing.Size(109, 34);
            this.add_to_cart_btn.TabIndex = 33;
            this.add_to_cart_btn.Text = "Добавить";
            this.add_to_cart_btn.UseVisualStyleBackColor = false;
            this.add_to_cart_btn.Click += new System.EventHandler(this.add_to_cart_btn_Click);
            // 
            // cartList
            // 
            this.cartList.BackgroundColor = System.Drawing.Color.White;
            this.cartList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdName,
            this.Price,
            this.sale,
            this.qty,
            this.qty_price,
            this.delete_btn});
            this.cartList.Location = new System.Drawing.Point(0, 65);
            this.cartList.Name = "cartList";
            this.cartList.Size = new System.Drawing.Size(410, 150);
            this.cartList.TabIndex = 0;
            // 
            // ProdName
            // 
            this.ProdName.HeaderText = "Название";
            this.ProdName.Name = "ProdName";
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            this.Price.Width = 50;
            // 
            // sale
            // 
            this.sale.HeaderText = "Скидка";
            this.sale.Name = "sale";
            // 
            // qty
            // 
            this.qty.HeaderText = "Колличество";
            this.qty.Name = "qty";
            this.qty.Width = 50;
            // 
            // qty_price
            // 
            this.qty_price.HeaderText = "qty_price";
            this.qty_price.Name = "qty_price";
            // 
            // delete_btn
            // 
            this.delete_btn.HeaderText = "Удалить";
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete_btn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete_btn.Width = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(125, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ваша корзина";
            // 
            // total_price_tb
            // 
            this.total_price_tb.BackColor = System.Drawing.Color.White;
            this.total_price_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.total_price_tb.Location = new System.Drawing.Point(107, 310);
            this.total_price_tb.Name = "total_price_tb";
            this.total_price_tb.Size = new System.Drawing.Size(150, 13);
            this.total_price_tb.TabIndex = 21;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(89)))), ((int)(((byte)(17)))));
            this.panel5.Location = new System.Drawing.Point(107, 336);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(150, 1);
            this.panel5.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 30);
            this.label7.TabIndex = 23;
            this.label7.Text = "Итог:";
            // 
            // make_ord_btn
            // 
            this.make_ord_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(89)))), ((int)(((byte)(17)))));
            this.make_ord_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.make_ord_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.make_ord_btn.Location = new System.Drawing.Point(181, 360);
            this.make_ord_btn.Name = "make_ord_btn";
            this.make_ord_btn.Size = new System.Drawing.Size(109, 34);
            this.make_ord_btn.TabIndex = 24;
            this.make_ord_btn.Text = "Заказать";
            this.make_ord_btn.UseVisualStyleBackColor = false;
            this.make_ord_btn.Click += new System.EventHandler(this.make_ord_btn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(263, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 30);
            this.label8.TabIndex = 25;
            this.label8.Text = "₽";
            // 
            // address_cb
            // 
            this.address_cb.FormattingEnabled = true;
            this.address_cb.Location = new System.Drawing.Point(192, 234);
            this.address_cb.Name = "address_cb";
            this.address_cb.Size = new System.Drawing.Size(161, 21);
            this.address_cb.TabIndex = 26;
            this.address_cb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(3, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 30);
            this.label11.TabIndex = 27;
            this.label11.Text = "Адрес доставки";
            // 
            // retr_code_lbl
            // 
            this.retr_code_lbl.AutoSize = true;
            this.retr_code_lbl.Location = new System.Drawing.Point(327, 27);
            this.retr_code_lbl.Name = "retr_code_lbl";
            this.retr_code_lbl.Size = new System.Drawing.Size(41, 13);
            this.retr_code_lbl.TabIndex = 29;
            this.retr_code_lbl.Text = "label12";
            this.retr_code_lbl.Visible = false;
            // 
            // ord_number_lbl
            // 
            this.ord_number_lbl.AutoSize = true;
            this.ord_number_lbl.Location = new System.Drawing.Point(31, 28);
            this.ord_number_lbl.Name = "ord_number_lbl";
            this.ord_number_lbl.Size = new System.Drawing.Size(41, 13);
            this.ord_number_lbl.TabIndex = 30;
            this.ord_number_lbl.Text = "label12";
            this.ord_number_lbl.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.usr_label);
            this.panel1.Controls.Add(this.addr_index);
            this.panel1.Controls.Add(this.ord_number_lbl);
            this.panel1.Controls.Add(this.retr_code_lbl);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.address_cb);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.make_ord_btn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.total_price_tb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cartList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(527, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 412);
            this.panel1.TabIndex = 13;
            // 
            // usr_label
            // 
            this.usr_label.AutoSize = true;
            this.usr_label.Location = new System.Drawing.Point(360, 272);
            this.usr_label.Name = "usr_label";
            this.usr_label.Size = new System.Drawing.Size(41, 13);
            this.usr_label.TabIndex = 32;
            this.usr_label.Text = "label12";
            this.usr_label.Visible = false;
            // 
            // addr_index
            // 
            this.addr_index.AutoSize = true;
            this.addr_index.Location = new System.Drawing.Point(360, 234);
            this.addr_index.Name = "addr_index";
            this.addr_index.Size = new System.Drawing.Size(41, 13);
            this.addr_index.TabIndex = 31;
            this.addr_index.Text = "label12";
            this.addr_index.Visible = false;
            // 
            // user_prod_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.add_to_cart_btn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.prod_filter_tb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sale_filter_cb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prod_grid);
            this.Name = "user_prod_control";
            this.Size = new System.Drawing.Size(940, 412);
            this.Load += new System.EventHandler(this.user_prod_control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prod_grid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView prod_grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label sale_qty_lbl;
        private System.Windows.Forms.Label sale_price_lbl;
        private System.Windows.Forms.Label price_lbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label desc_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox sale_filter_cb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox prod_filter_tb;
        private System.Windows.Forms.Button add_to_cart_btn;
        private System.Windows.Forms.DataGridView cartList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox total_price_tb;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button make_ord_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox address_cb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label retr_code_lbl;
        private System.Windows.Forms.Label ord_number_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label addr_index;
        private System.Windows.Forms.Label usr_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty_price;
        private System.Windows.Forms.DataGridViewButtonColumn delete_btn;
    }
}
