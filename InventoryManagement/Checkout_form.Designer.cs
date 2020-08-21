namespace InventoryManagement
{
    partial class Checkout_form
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.total_b = new System.Windows.Forms.TextBox();
            this.qr_b = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.meas_b = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.sname_b = new System.Windows.Forms.TextBox();
            this.cp_b = new System.Windows.Forms.TextBox();
            this.qa_b = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_cart = new ePOSOne.btnProduct.Button_WOC();
            this.label1 = new System.Windows.Forms.Label();
            this.search_b = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cname_b = new System.Windows.Forms.TextBox();
            this.cart_b = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.change_lb = new System.Windows.Forms.Label();
            this.tendered_lb = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.total_lb = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_checkout = new ePOSOne.btnProduct.Button_WOC();
            this.button_remove = new ePOSOne.btnProduct.Button_WOC();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.c_add_b = new System.Windows.Forms.TextBox();
            this.c_con_b = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.total_b);
            this.panel1.Controls.Add(this.qr_b);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button_cart);
            this.panel1.Location = new System.Drawing.Point(827, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 366);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(261, 120);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // total_b
            // 
            this.total_b.Location = new System.Drawing.Point(135, 297);
            this.total_b.Name = "total_b";
            this.total_b.ReadOnly = true;
            this.total_b.Size = new System.Drawing.Size(112, 20);
            this.total_b.TabIndex = 6;
            // 
            // qr_b
            // 
            this.qr_b.Location = new System.Drawing.Point(135, 268);
            this.qr_b.Name = "qr_b";
            this.qr_b.Size = new System.Drawing.Size(112, 20);
            this.qr_b.TabIndex = 5;
            this.qr_b.TextChanged += new System.EventHandler(this.qr_b_TextChanged);
            this.qr_b.Validating += new System.ComponentModel.CancelEventHandler(this.qr_b_Validating);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.meas_b);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.sname_b);
            this.panel2.Controls.Add(this.cp_b);
            this.panel2.Controls.Add(this.qa_b);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(0, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 130);
            this.panel2.TabIndex = 4;
            // 
            // meas_b
            // 
            this.meas_b.Location = new System.Drawing.Point(135, 42);
            this.meas_b.Name = "meas_b";
            this.meas_b.ReadOnly = true;
            this.meas_b.Size = new System.Drawing.Size(112, 20);
            this.meas_b.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Measuerement";
            // 
            // sname_b
            // 
            this.sname_b.Location = new System.Drawing.Point(135, 99);
            this.sname_b.Name = "sname_b";
            this.sname_b.ReadOnly = true;
            this.sname_b.Size = new System.Drawing.Size(112, 20);
            this.sname_b.TabIndex = 10;
            // 
            // cp_b
            // 
            this.cp_b.Location = new System.Drawing.Point(135, 69);
            this.cp_b.Name = "cp_b";
            this.cp_b.ReadOnly = true;
            this.cp_b.Size = new System.Drawing.Size(112, 20);
            this.cp_b.TabIndex = 9;
            // 
            // qa_b
            // 
            this.qa_b.Location = new System.Drawing.Point(135, 13);
            this.qa_b.Name = "qa_b";
            this.qa_b.ReadOnly = true;
            this.qa_b.Size = new System.Drawing.Size(112, 20);
            this.qa_b.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Quantity Available";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Current Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Supplier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Quantity Required";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total Price";
            // 
            // button_cart
            // 
            this.button_cart.BorderColor = System.Drawing.Color.Silver;
            this.button_cart.ButtonColor = System.Drawing.Color.Navy;
            this.button_cart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cart.Location = new System.Drawing.Point(17, 326);
            this.button_cart.Name = "button_cart";
            this.button_cart.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_cart.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_cart.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_cart.Size = new System.Drawing.Size(230, 34);
            this.button_cart.TabIndex = 1;
            this.button_cart.Text = "Add To Cart";
            this.button_cart.TextColor = System.Drawing.Color.White;
            this.button_cart.UseVisualStyleBackColor = true;
            this.button_cart.Click += new System.EventHandler(this.button_cart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(824, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // search_b
            // 
            this.search_b.Location = new System.Drawing.Point(874, 38);
            this.search_b.Name = "search_b";
            this.search_b.Size = new System.Drawing.Size(214, 20);
            this.search_b.TabIndex = 2;
            this.search_b.TextChanged += new System.EventHandler(this.search_b_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(783, 201);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Customer Name";
            // 
            // cname_b
            // 
            this.cname_b.Location = new System.Drawing.Point(100, 35);
            this.cname_b.Name = "cname_b";
            this.cname_b.Size = new System.Drawing.Size(262, 20);
            this.cname_b.TabIndex = 5;
            this.cname_b.Validating += new System.ComponentModel.CancelEventHandler(this.cname_b_Validating);
            // 
            // cart_b
            // 
            this.cart_b.Location = new System.Drawing.Point(552, 35);
            this.cart_b.Name = "cart_b";
            this.cart_b.Size = new System.Drawing.Size(243, 20);
            this.cart_b.TabIndex = 6;
            this.cart_b.Validating += new System.ComponentModel.CancelEventHandler(this.cart_b_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cart No.";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.change_lb);
            this.panel3.Controls.Add(this.tendered_lb);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(459, 327);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 64);
            this.panel3.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(143, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 25);
            this.label13.TabIndex = 18;
            this.label13.Text = "$";
            // 
            // change_lb
            // 
            this.change_lb.AutoSize = true;
            this.change_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_lb.Location = new System.Drawing.Point(165, 36);
            this.change_lb.Name = "change_lb";
            this.change_lb.Size = new System.Drawing.Size(25, 25);
            this.change_lb.TabIndex = 17;
            this.change_lb.Text = "0";
            // 
            // tendered_lb
            // 
            this.tendered_lb.AutoSize = true;
            this.tendered_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tendered_lb.Location = new System.Drawing.Point(165, 6);
            this.tendered_lb.Name = "tendered_lb";
            this.tendered_lb.Size = new System.Drawing.Size(25, 25);
            this.tendered_lb.TabIndex = 16;
            this.tendered_lb.Text = "0";
            this.tendered_lb.Click += new System.EventHandler(this.tendered_lb_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(143, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 25);
            this.label16.TabIndex = 14;
            this.label16.Text = "$";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 25);
            this.label15.TabIndex = 13;
            this.label15.Text = "Change";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 25);
            this.label14.TabIndex = 12;
            this.label14.Text = "Tendered ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(82, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Total Sale";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(82, 366);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "Tendered ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(306, 340);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 25);
            this.label11.TabIndex = 12;
            this.label11.Text = "$";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(253, 366);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 25);
            this.label12.TabIndex = 13;
            this.label12.Text = "$";
            // 
            // total_lb
            // 
            this.total_lb.AutoSize = true;
            this.total_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_lb.Location = new System.Drawing.Point(337, 340);
            this.total_lb.Name = "total_lb";
            this.total_lb.Size = new System.Drawing.Size(25, 25);
            this.total_lb.TabIndex = 14;
            this.total_lb.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(284, 369);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // button_checkout
            // 
            this.button_checkout.BorderColor = System.Drawing.Color.Silver;
            this.button_checkout.ButtonColor = System.Drawing.Color.Green;
            this.button_checkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_checkout.Location = new System.Drawing.Point(149, 400);
            this.button_checkout.Name = "button_checkout";
            this.button_checkout.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_checkout.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_checkout.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_checkout.Size = new System.Drawing.Size(191, 32);
            this.button_checkout.TabIndex = 8;
            this.button_checkout.Text = "Check Out";
            this.button_checkout.TextColor = System.Drawing.Color.White;
            this.button_checkout.UseVisualStyleBackColor = true;
            this.button_checkout.Click += new System.EventHandler(this.button_checkout_Click);
            // 
            // button_remove
            // 
            this.button_remove.BorderColor = System.Drawing.Color.Silver;
            this.button_remove.ButtonColor = System.Drawing.Color.Red;
            this.button_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_remove.Location = new System.Drawing.Point(483, 404);
            this.button_remove.Name = "button_remove";
            this.button_remove.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_remove.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_remove.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_remove.Size = new System.Drawing.Size(166, 34);
            this.button_remove.TabIndex = 2;
            this.button_remove.Text = "Remove from Cart";
            this.button_remove.TextColor = System.Drawing.Color.White;
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 81);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "Address";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(456, 81);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 13);
            this.label19.TabIndex = 17;
            this.label19.Text = "Contact No.";
            // 
            // c_add_b
            // 
            this.c_add_b.Location = new System.Drawing.Point(100, 81);
            this.c_add_b.Name = "c_add_b";
            this.c_add_b.Size = new System.Drawing.Size(262, 20);
            this.c_add_b.TabIndex = 18;
            // 
            // c_con_b
            // 
            this.c_con_b.Location = new System.Drawing.Point(552, 81);
            this.c_con_b.Name = "c_con_b";
            this.c_con_b.Size = new System.Drawing.Size(243, 20);
            this.c_con_b.TabIndex = 19;
            this.c_con_b.Validating += new System.ComponentModel.CancelEventHandler(this.c_con_b_Validating);
            // 
            // Checkout_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 450);
            this.Controls.Add(this.c_con_b);
            this.Controls.Add(this.c_add_b);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.total_lb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button_checkout);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cart_b);
            this.Controls.Add(this.cname_b);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search_b);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Checkout_form";
            this.Text = "Checkout_form";
            this.Load += new System.EventHandler(this.Checkout_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_b;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox total_b;
        private System.Windows.Forms.TextBox qr_b;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox sname_b;
        private System.Windows.Forms.TextBox cp_b;
        private System.Windows.Forms.TextBox qa_b;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private ePOSOne.btnProduct.Button_WOC button_cart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cname_b;
        private System.Windows.Forms.TextBox cart_b;
        private System.Windows.Forms.Label label3;
        private ePOSOne.btnProduct.Button_WOC button_remove;
        private ePOSOne.btnProduct.Button_WOC button_checkout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label change_lb;
        private System.Windows.Forms.Label tendered_lb;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label total_lb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox meas_b;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox c_add_b;
        private System.Windows.Forms.TextBox c_con_b;
    }
}