namespace Zaytsev_Demoex.controls
{
    partial class admord_control
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
            this.change_ord = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.find_ord_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ord_grid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.sale_filter_cb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.new_status_cb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ord_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // change_ord
            // 
            this.change_ord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(89)))), ((int)(((byte)(17)))));
            this.change_ord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.change_ord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change_ord.Location = new System.Drawing.Point(515, 281);
            this.change_ord.Name = "change_ord";
            this.change_ord.Size = new System.Drawing.Size(101, 34);
            this.change_ord.TabIndex = 31;
            this.change_ord.Text = "Изменить";
            this.change_ord.UseVisualStyleBackColor = false;
            this.change_ord.Click += new System.EventHandler(this.change_ord_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(413, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "Номер заказа";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(89)))), ((int)(((byte)(17)))));
            this.panel1.Location = new System.Drawing.Point(536, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 1);
            this.panel1.TabIndex = 28;
            // 
            // find_ord_tb
            // 
            this.find_ord_tb.BackColor = System.Drawing.Color.White;
            this.find_ord_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.find_ord_tb.Location = new System.Drawing.Point(536, 127);
            this.find_ord_tb.Name = "find_ord_tb";
            this.find_ord_tb.Size = new System.Drawing.Size(150, 13);
            this.find_ord_tb.TabIndex = 27;
            this.find_ord_tb.TextChanged += new System.EventHandler(this.find_ord_tb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(293, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 30);
            this.label1.TabIndex = 25;
            this.label1.Text = "Заказы";
            // 
            // ord_grid
            // 
            this.ord_grid.BackgroundColor = System.Drawing.Color.White;
            this.ord_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ord_grid.Location = new System.Drawing.Point(7, 82);
            this.ord_grid.Name = "ord_grid";
            this.ord_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ord_grid.Size = new System.Drawing.Size(400, 217);
            this.ord_grid.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(89)))), ((int)(((byte)(17)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(545, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 42);
            this.button1.TabIndex = 36;
            this.button1.Text = "Сбросить фильтры";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 38;
            this.label4.Text = "Размер скидки";
            // 
            // sale_filter_cb
            // 
            this.sale_filter_cb.FormattingEnabled = true;
            this.sale_filter_cb.Items.AddRange(new object[] {
            "Все диапазоны",
            "0-10%",
            "11-14,99%",
            "15% и более"});
            this.sale_filter_cb.Location = new System.Drawing.Point(142, 50);
            this.sale_filter_cb.Name = "sale_filter_cb";
            this.sale_filter_cb.Size = new System.Drawing.Size(121, 21);
            this.sale_filter_cb.TabIndex = 37;
            this.sale_filter_cb.SelectedIndexChanged += new System.EventHandler(this.sale_filter_cb_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(413, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 23);
            this.label5.TabIndex = 39;
            this.label5.Text = "Новый статус";
            // 
            // new_status_cb
            // 
            this.new_status_cb.FormattingEnabled = true;
            this.new_status_cb.Location = new System.Drawing.Point(539, 217);
            this.new_status_cb.Name = "new_status_cb";
            this.new_status_cb.Size = new System.Drawing.Size(121, 21);
            this.new_status_cb.TabIndex = 40;
            // 
            // admord_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.new_status_cb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sale_filter_cb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.change_ord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.find_ord_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ord_grid);
            this.Name = "admord_control";
            this.Size = new System.Drawing.Size(745, 408);
            this.Load += new System.EventHandler(this.admord_control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ord_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button change_ord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox find_ord_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ord_grid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sale_filter_cb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox new_status_cb;
    }
}
