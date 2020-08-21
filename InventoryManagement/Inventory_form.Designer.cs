namespace InventoryManagement
{
    partial class Inventory_form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.p_lb = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.id_box = new System.Windows.Forms.TextBox();
            this.button_add = new ePOSOne.btnProduct.Button_WOC();
            this.button_delete = new ePOSOne.btnProduct.Button_WOC();
            this.button_update = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(737, 293);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(689, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.id_box);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button_update);
            this.panel1.Controls.Add(this.p_lb);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(783, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 383);
            this.panel1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(165, 291);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(165, 253);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // p_lb
            // 
            this.p_lb.AutoSize = true;
            this.p_lb.Location = new System.Drawing.Point(215, 79);
            this.p_lb.Name = "p_lb";
            this.p_lb.Size = new System.Drawing.Size(13, 13);
            this.p_lb.TabIndex = 16;
            this.p_lb.Text = "0";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(63, 76);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(61, 20);
            this.textBox3.TabIndex = 15;
            this.textBox3.Validating += new System.ComponentModel.CancelEventHandler(this.textBox3_Validating);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(190, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 14;
            this.textBox2.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(74, 299);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Supplier Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(74, 261);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Measurement";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(16, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 82);
            this.panel2.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(149, 50);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(75, 20);
            this.textBox5.TabIndex = 17;
            this.textBox5.Validating += new System.ComponentModel.CancelEventHandler(this.textBox5_Validating);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(149, 22);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(75, 20);
            this.textBox4.TabIndex = 16;
            this.textBox4.Validating += new System.ComponentModel.CancelEventHandler(this.textBox4_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(130, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "$";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(130, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(58, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Interest";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Current Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(72, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Updated Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(205, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Current Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Iteam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Product ID ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Iteam Info";
            // 
            // id_box
            // 
            this.id_box.Location = new System.Drawing.Point(77, 34);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(47, 20);
            this.id_box.TabIndex = 20;
            this.id_box.Validating += new System.ComponentModel.CancelEventHandler(this.id_box_Validating);
            // 
            // button_add
            // 
            this.button_add.BorderColor = System.Drawing.Color.Silver;
            this.button_add.ButtonColor = System.Drawing.Color.OliveDrab;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Location = new System.Drawing.Point(84, 392);
            this.button_add.Name = "button_add";
            this.button_add.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_add.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_add.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_add.Size = new System.Drawing.Size(172, 34);
            this.button_add.TabIndex = 19;
            this.button_add.Text = "Add Iteam";
            this.button_add.TextColor = System.Drawing.Color.White;
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_delete
            // 
            this.button_delete.BorderColor = System.Drawing.Color.Silver;
            this.button_delete.ButtonColor = System.Drawing.Color.Red;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Location = new System.Drawing.Point(424, 392);
            this.button_delete.Name = "button_delete";
            this.button_delete.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_delete.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_delete.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_delete.Size = new System.Drawing.Size(159, 34);
            this.button_delete.TabIndex = 18;
            this.button_delete.Text = "Delete ";
            this.button_delete.TextColor = System.Drawing.Color.White;
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.BorderColor = System.Drawing.Color.Silver;
            this.button_update.ButtonColor = System.Drawing.Color.Green;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Location = new System.Drawing.Point(77, 327);
            this.button_update.Name = "button_update";
            this.button_update.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_update.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_update.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_update.Size = new System.Drawing.Size(209, 34);
            this.button_update.TabIndex = 17;
            this.button_update.Text = "Update";
            this.button_update.TextColor = System.Drawing.Color.White;
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // Inventory_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 450);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Inventory_form";
            this.Text = "Inventory_form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private ePOSOne.btnProduct.Button_WOC button_update;
        private System.Windows.Forms.Label p_lb;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ePOSOne.btnProduct.Button_WOC button_delete;
        private ePOSOne.btnProduct.Button_WOC button_add;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox id_box;
    }
}