namespace BD_stock
{
    partial class Form1
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
            this.b_connect = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.b_product = new System.Windows.Forms.Button();
            this.b_supplers = new System.Windows.Forms.Button();
            this.b_type = new System.Windows.Forms.Button();
            this.tb_connectstring = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_minCount = new System.Windows.Forms.RadioButton();
            this.rb_maxCount = new System.Windows.Forms.RadioButton();
            this.rb_minprice = new System.Windows.Forms.RadioButton();
            this.rb_maxprice = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_types = new System.Windows.Forms.ComboBox();
            this.cb_supplyes = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // b_connect
            // 
            this.b_connect.Location = new System.Drawing.Point(645, 24);
            this.b_connect.Name = "b_connect";
            this.b_connect.Size = new System.Drawing.Size(75, 23);
            this.b_connect.TabIndex = 0;
            this.b_connect.Text = "Connect";
            this.b_connect.UseVisualStyleBackColor = true;
            this.b_connect.Click += new System.EventHandler(this.b_connect_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(565, 219);
            this.dataGridView1.TabIndex = 3;
            // 
            // b_product
            // 
            this.b_product.Location = new System.Drawing.Point(608, 74);
            this.b_product.Name = "b_product";
            this.b_product.Size = new System.Drawing.Size(138, 23);
            this.b_product.TabIndex = 4;
            this.b_product.Text = "Товар";
            this.b_product.UseVisualStyleBackColor = true;
            this.b_product.Click += new System.EventHandler(this.b_product_Click);
            // 
            // b_supplers
            // 
            this.b_supplers.Location = new System.Drawing.Point(608, 104);
            this.b_supplers.Name = "b_supplers";
            this.b_supplers.Size = new System.Drawing.Size(138, 23);
            this.b_supplers.TabIndex = 5;
            this.b_supplers.Text = "поставщики";
            this.b_supplers.UseVisualStyleBackColor = true;
            this.b_supplers.Click += new System.EventHandler(this.b_supplers_Click);
            // 
            // b_type
            // 
            this.b_type.Location = new System.Drawing.Point(608, 134);
            this.b_type.Name = "b_type";
            this.b_type.Size = new System.Drawing.Size(138, 23);
            this.b_type.TabIndex = 6;
            this.b_type.Text = "Тип товара";
            this.b_type.UseVisualStyleBackColor = true;
            this.b_type.Click += new System.EventHandler(this.b_type_Click);
            // 
            // tb_connectstring
            // 
            this.tb_connectstring.Location = new System.Drawing.Point(119, 24);
            this.tb_connectstring.Name = "tb_connectstring";
            this.tb_connectstring.Size = new System.Drawing.Size(471, 20);
            this.tb_connectstring.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Connection String";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(25, 319);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(286, 45);
            this.dataGridView2.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_maxprice);
            this.groupBox1.Controls.Add(this.rb_minprice);
            this.groupBox1.Controls.Add(this.rb_maxCount);
            this.groupBox1.Controls.Add(this.rb_minCount);
            this.groupBox1.Location = new System.Drawing.Point(332, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 70);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // rb_minCount
            // 
            this.rb_minCount.AutoSize = true;
            this.rb_minCount.Location = new System.Drawing.Point(7, 11);
            this.rb_minCount.Name = "rb_minCount";
            this.rb_minCount.Size = new System.Drawing.Size(110, 17);
            this.rb_minCount.TabIndex = 0;
            this.rb_minCount.TabStop = true;
            this.rb_minCount.Text = "Мин. количество";
            this.rb_minCount.UseVisualStyleBackColor = true;
            this.rb_minCount.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rb_maxCount
            // 
            this.rb_maxCount.AutoSize = true;
            this.rb_maxCount.Location = new System.Drawing.Point(7, 35);
            this.rb_maxCount.Name = "rb_maxCount";
            this.rb_maxCount.Size = new System.Drawing.Size(109, 17);
            this.rb_maxCount.TabIndex = 1;
            this.rb_maxCount.TabStop = true;
            this.rb_maxCount.Text = "Мах. количество";
            this.rb_maxCount.UseVisualStyleBackColor = true;
            this.rb_maxCount.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rb_minprice
            // 
            this.rb_minprice.AutoSize = true;
            this.rb_minprice.Location = new System.Drawing.Point(127, 11);
            this.rb_minprice.Name = "rb_minprice";
            this.rb_minprice.Size = new System.Drawing.Size(76, 17);
            this.rb_minprice.TabIndex = 2;
            this.rb_minprice.TabStop = true;
            this.rb_minprice.Text = "Мин. цена";
            this.rb_minprice.UseVisualStyleBackColor = true;
            this.rb_minprice.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rb_maxprice
            // 
            this.rb_maxprice.AutoSize = true;
            this.rb_maxprice.Location = new System.Drawing.Point(127, 34);
            this.rb_maxprice.Name = "rb_maxprice";
            this.rb_maxprice.Size = new System.Drawing.Size(75, 17);
            this.rb_maxprice.TabIndex = 3;
            this.rb_maxprice.TabStop = true;
            this.rb_maxprice.Text = "Мах. цена";
            this.rb_maxprice.UseVisualStyleBackColor = true;
            this.rb_maxprice.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Товар";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(28, 393);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(240, 150);
            this.dataGridView3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "товары категории";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Товары поставщика";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Самый старый товар";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Среднее количество товаров по каждому типу";
            // 
            // cb_types
            // 
            this.cb_types.FormattingEnabled = true;
            this.cb_types.Location = new System.Drawing.Point(459, 393);
            this.cb_types.Name = "cb_types";
            this.cb_types.Size = new System.Drawing.Size(172, 21);
            this.cb_types.TabIndex = 16;
            // 
            // cb_supplyes
            // 
            this.cb_supplyes.FormattingEnabled = true;
            this.cb_supplyes.Location = new System.Drawing.Point(459, 422);
            this.cb_supplyes.Name = "cb_supplyes";
            this.cb_supplyes.Size = new System.Drawing.Size(172, 21);
            this.cb_supplyes.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(567, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Показать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(567, 480);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Показать";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 588);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_supplyes);
            this.Controls.Add(this.cb_types);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.b_type);
            this.Controls.Add(this.b_supplers);
            this.Controls.Add(this.b_product);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_connectstring);
            this.Controls.Add(this.b_connect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_connect;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button b_product;
        private System.Windows.Forms.Button b_supplers;
        private System.Windows.Forms.Button b_type;
        private System.Windows.Forms.TextBox tb_connectstring;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_maxprice;
        private System.Windows.Forms.RadioButton rb_minprice;
        private System.Windows.Forms.RadioButton rb_maxCount;
        private System.Windows.Forms.RadioButton rb_minCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_types;
        private System.Windows.Forms.ComboBox cb_supplyes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

