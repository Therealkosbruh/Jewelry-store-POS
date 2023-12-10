namespace Zaytsev_Demoex
{
    partial class Captcha
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cptch_btn = new System.Windows.Forms.Button();
            this.find_ord_tb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(177, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 77);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(146, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 30);
            this.label1.TabIndex = 26;
            this.label1.Text = "Введите текст с картинки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(146, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 30);
            this.label2.TabIndex = 27;
            this.label2.Text = "Ввод";
            // 
            // cptch_btn
            // 
            this.cptch_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(89)))), ((int)(((byte)(17)))));
            this.cptch_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cptch_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cptch_btn.Location = new System.Drawing.Point(199, 220);
            this.cptch_btn.Name = "cptch_btn";
            this.cptch_btn.Size = new System.Drawing.Size(176, 34);
            this.cptch_btn.TabIndex = 32;
            this.cptch_btn.Text = "Ввести";
            this.cptch_btn.UseVisualStyleBackColor = false;
            // 
            // find_ord_tb
            // 
            this.find_ord_tb.BackColor = System.Drawing.Color.White;
            this.find_ord_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.find_ord_tb.Location = new System.Drawing.Point(213, 166);
            this.find_ord_tb.Name = "find_ord_tb";
            this.find_ord_tb.Size = new System.Drawing.Size(150, 13);
            this.find_ord_tb.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(89)))), ((int)(((byte)(17)))));
            this.panel1.Location = new System.Drawing.Point(213, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 1);
            this.panel1.TabIndex = 34;
            // 
            // Captcha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(585, 285);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.find_ord_tb);
            this.Controls.Add(this.cptch_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Captcha";
            this.Text = "Captcha";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cptch_btn;
        private System.Windows.Forms.TextBox find_ord_tb;
        private System.Windows.Forms.Panel panel1;
    }
}