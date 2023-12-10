namespace Zaytsev_Demoex.controls
{
    partial class usr_order_control
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
            this.label4 = new System.Windows.Forms.Label();
            this.sale_filter_cb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.find_ord_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ord_grid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ord_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(131, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 51;
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
            this.sale_filter_cb.Location = new System.Drawing.Point(257, 55);
            this.sale_filter_cb.Name = "sale_filter_cb";
            this.sale_filter_cb.Size = new System.Drawing.Size(121, 21);
            this.sale_filter_cb.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(582, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 45;
            this.label3.Text = "Номер заказа";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(89)))), ((int)(((byte)(17)))));
            this.panel1.Location = new System.Drawing.Point(705, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 1);
            this.panel1.TabIndex = 44;
            // 
            // find_ord_tb
            // 
            this.find_ord_tb.BackColor = System.Drawing.Color.White;
            this.find_ord_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.find_ord_tb.Location = new System.Drawing.Point(705, 62);
            this.find_ord_tb.Name = "find_ord_tb";
            this.find_ord_tb.Size = new System.Drawing.Size(150, 13);
            this.find_ord_tb.TabIndex = 43;
            this.find_ord_tb.TextChanged += new System.EventHandler(this.find_ord_tb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(408, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 30);
            this.label1.TabIndex = 42;
            this.label1.Text = "Заказы";
            // 
            // ord_grid
            // 
            this.ord_grid.BackgroundColor = System.Drawing.Color.White;
            this.ord_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ord_grid.Location = new System.Drawing.Point(280, 117);
            this.ord_grid.Name = "ord_grid";
            this.ord_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ord_grid.Size = new System.Drawing.Size(400, 217);
            this.ord_grid.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "label2";
            // 
            // usr_order_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sale_filter_cb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.find_ord_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ord_grid);
            this.Name = "usr_order_control";
            this.Size = new System.Drawing.Size(940, 412);
            this.Load += new System.EventHandler(this.usr_order_control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ord_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sale_filter_cb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox find_ord_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ord_grid;
        private System.Windows.Forms.Label label2;
    }
}
