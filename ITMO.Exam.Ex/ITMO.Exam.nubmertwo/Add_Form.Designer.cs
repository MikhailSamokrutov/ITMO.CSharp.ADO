namespace ITMO.Exam.nubmertwo
{
    partial class Add_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_type2 = new System.Windows.Forms.TextBox();
            this.textBox_count2 = new System.Windows.Forms.TextBox();
            this.textBox_postav2 = new System.Windows.Forms.TextBox();
            this.textBox_price2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(133, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Создание записи";
            // 
            // textBox_type2
            // 
            this.textBox_type2.Location = new System.Drawing.Point(186, 192);
            this.textBox_type2.Name = "textBox_type2";
            this.textBox_type2.Size = new System.Drawing.Size(174, 20);
            this.textBox_type2.TabIndex = 1;
            // 
            // textBox_count2
            // 
            this.textBox_count2.Location = new System.Drawing.Point(186, 218);
            this.textBox_count2.Name = "textBox_count2";
            this.textBox_count2.Size = new System.Drawing.Size(174, 20);
            this.textBox_count2.TabIndex = 2;
            this.textBox_count2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_postav2
            // 
            this.textBox_postav2.Location = new System.Drawing.Point(186, 244);
            this.textBox_postav2.Name = "textBox_postav2";
            this.textBox_postav2.Size = new System.Drawing.Size(174, 20);
            this.textBox_postav2.TabIndex = 3;
            // 
            // textBox_price2
            // 
            this.textBox_price2.Location = new System.Drawing.Point(186, 270);
            this.textBox_price2.Name = "textBox_price2";
            this.textBox_price2.Size = new System.Drawing.Size(174, 20);
            this.textBox_price2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Тип товара:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Поставщик:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Цена:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 352);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_price2);
            this.Controls.Add(this.textBox_postav2);
            this.Controls.Add(this.textBox_count2);
            this.Controls.Add(this.textBox_type2);
            this.Controls.Add(this.panel1);
            this.Name = "Add_Form";
            this.Text = "Add_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_type2;
        private System.Windows.Forms.TextBox textBox_count2;
        private System.Windows.Forms.TextBox textBox_postav2;
        private System.Windows.Forms.TextBox textBox_price2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}