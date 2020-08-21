namespace InventoryManagement
{
    partial class Add_Iteam
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.in_box = new System.Windows.Forms.TextBox();
            this.op_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.qty_box = new System.Windows.Forms.TextBox();
            this.id_box = new System.Windows.Forms.TextBox();
            this.qty = new System.Windows.Forms.Label();
            this.add_lb = new System.Windows.Forms.Label();
            this.name_lb = new System.Windows.Forms.Label();
            this.button_add = new ePOSOne.btnProduct.Button_WOC();
            this.s_combobox = new System.Windows.Forms.ComboBox();
            this.m_combobox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_combobox);
            this.groupBox1.Controls.Add(this.s_combobox);
            this.groupBox1.Controls.Add(this.in_box);
            this.groupBox1.Controls.Add(this.op_box);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.name_box);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.qty_box);
            this.groupBox1.Controls.Add(this.id_box);
            this.groupBox1.Controls.Add(this.qty);
            this.groupBox1.Controls.Add(this.add_lb);
            this.groupBox1.Controls.Add(this.name_lb);
            this.groupBox1.Location = new System.Drawing.Point(149, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 322);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Item Form";
            // 
            // in_box
            // 
            this.in_box.Location = new System.Drawing.Point(156, 258);
            this.in_box.Name = "in_box";
            this.in_box.Size = new System.Drawing.Size(183, 20);
            this.in_box.TabIndex = 14;
            this.in_box.Validating += new System.ComponentModel.CancelEventHandler(this.in_box_Validating);
            // 
            // op_box
            // 
            this.op_box.Location = new System.Drawing.Point(156, 213);
            this.op_box.Name = "op_box";
            this.op_box.Size = new System.Drawing.Size(183, 20);
            this.op_box.TabIndex = 13;
            this.op_box.Validating += new System.ComponentModel.CancelEventHandler(this.op_box_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Supplier Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Profit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Original Price";
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(156, 77);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(183, 20);
            this.name_box.TabIndex = 9;
            this.name_box.Validating += new System.ComponentModel.CancelEventHandler(this.name_box_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Item Id";
            // 
            // qty_box
            // 
            this.qty_box.Location = new System.Drawing.Point(156, 121);
            this.qty_box.Name = "qty_box";
            this.qty_box.Size = new System.Drawing.Size(183, 20);
            this.qty_box.TabIndex = 6;
            this.qty_box.Validating += new System.ComponentModel.CancelEventHandler(this.qty_box_Validating);
            // 
            // id_box
            // 
            this.id_box.Location = new System.Drawing.Point(156, 33);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(183, 20);
            this.id_box.TabIndex = 5;
            this.id_box.Validating += new System.ComponentModel.CancelEventHandler(this.id_box_Validating);
            // 
            // qty
            // 
            this.qty.AutoSize = true;
            this.qty.Location = new System.Drawing.Point(27, 121);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(46, 13);
            this.qty.TabIndex = 3;
            this.qty.Text = "Quantity";
            // 
            // add_lb
            // 
            this.add_lb.AutoSize = true;
            this.add_lb.Location = new System.Drawing.Point(27, 167);
            this.add_lb.Name = "add_lb";
            this.add_lb.Size = new System.Drawing.Size(71, 13);
            this.add_lb.TabIndex = 2;
            this.add_lb.Text = "Measurement";
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Location = new System.Drawing.Point(27, 77);
            this.name_lb.Name = "name_lb";
            this.name_lb.Size = new System.Drawing.Size(35, 13);
            this.name_lb.TabIndex = 0;
            this.name_lb.Text = "Name";
            // 
            // button_add
            // 
            this.button_add.BorderColor = System.Drawing.Color.White;
            this.button_add.ButtonColor = System.Drawing.Color.Lime;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Location = new System.Drawing.Point(351, 384);
            this.button_add.Name = "button_add";
            this.button_add.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_add.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_add.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_add.Size = new System.Drawing.Size(75, 38);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "Add item";
            this.button_add.TextColor = System.Drawing.Color.White;
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // s_combobox
            // 
            this.s_combobox.FormattingEnabled = true;
            this.s_combobox.Location = new System.Drawing.Point(156, 295);
            this.s_combobox.Name = "s_combobox";
            this.s_combobox.Size = new System.Drawing.Size(183, 21);
            this.s_combobox.TabIndex = 15;
            // 
            // m_combobox
            // 
            this.m_combobox.FormattingEnabled = true;
            this.m_combobox.Location = new System.Drawing.Point(156, 167);
            this.m_combobox.Name = "m_combobox";
            this.m_combobox.Size = new System.Drawing.Size(183, 21);
            this.m_combobox.TabIndex = 16;
            // 
            // Add_Iteam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.groupBox1);
            this.Name = "Add_Iteam";
            this.Text = "Add_Iteam";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox qty_box;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.Label qty;
        private System.Windows.Forms.Label add_lb;
        private System.Windows.Forms.Label name_lb;
        private ePOSOne.btnProduct.Button_WOC button_add;
        private System.Windows.Forms.TextBox in_box;
        private System.Windows.Forms.TextBox op_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox s_combobox;
        private System.Windows.Forms.ComboBox m_combobox;
    }
}