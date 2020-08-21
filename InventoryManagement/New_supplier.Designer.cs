namespace InventoryManagement
{
    partial class New_supplier
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.con_lb = new System.Windows.Forms.Label();
            this.add_lb = new System.Windows.Forms.Label();
            this.name_lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_add = new ePOSOne.btnProduct.Button_WOC();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.con_lb);
            this.groupBox1.Controls.Add(this.add_lb);
            this.groupBox1.Controls.Add(this.name_lb);
            this.groupBox1.Location = new System.Drawing.Point(155, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New User Form";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(156, 189);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(183, 20);
            this.textBox4.TabIndex = 7;
            this.textBox4.Validating += new System.ComponentModel.CancelEventHandler(this.textBox4_Validating);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(156, 142);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(183, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.Validating += new System.ComponentModel.CancelEventHandler(this.textBox3_Validating);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(156, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
            // 
            // con_lb
            // 
            this.con_lb.AutoSize = true;
            this.con_lb.Location = new System.Drawing.Point(27, 149);
            this.con_lb.Name = "con_lb";
            this.con_lb.Size = new System.Drawing.Size(44, 13);
            this.con_lb.TabIndex = 3;
            this.con_lb.Text = "Contact";
            // 
            // add_lb
            // 
            this.add_lb.AutoSize = true;
            this.add_lb.Location = new System.Drawing.Point(27, 196);
            this.add_lb.Name = "add_lb";
            this.add_lb.Size = new System.Drawing.Size(45, 13);
            this.add_lb.TabIndex = 2;
            this.add_lb.Text = "Address";
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Location = new System.Drawing.Point(27, 101);
            this.name_lb.Name = "name_lb";
            this.name_lb.Size = new System.Drawing.Size(35, 13);
            this.name_lb.TabIndex = 0;
            this.name_lb.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Supplier Id";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // button_add
            // 
            this.button_add.BorderColor = System.Drawing.Color.White;
            this.button_add.ButtonColor = System.Drawing.Color.Lime;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Location = new System.Drawing.Point(369, 325);
            this.button_add.Name = "button_add";
            this.button_add.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_add.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_add.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_add.Size = new System.Drawing.Size(75, 38);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "Add User";
            this.button_add.TextColor = System.Drawing.Color.White;
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // New_supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.groupBox1);
            this.Name = "New_supplier";
            this.Text = "New_supplier";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label con_lb;
        private System.Windows.Forms.Label add_lb;
        private System.Windows.Forms.Label name_lb;
        private ePOSOne.btnProduct.Button_WOC button_add;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}