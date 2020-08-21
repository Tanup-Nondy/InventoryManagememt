namespace InventoryManagement
{
    partial class Transaction_form
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
            this.label3 = new System.Windows.Forms.Label();
            this.cart_b = new System.Windows.Forms.TextBox();
            this.button_clear = new ePOSOne.btnProduct.Button_WOC();
            this.button_del = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(783, 275);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Search";
            // 
            // cart_b
            // 
            this.cart_b.Location = new System.Drawing.Point(107, 29);
            this.cart_b.Name = "cart_b";
            this.cart_b.Size = new System.Drawing.Size(681, 20);
            this.cart_b.TabIndex = 8;
            this.cart_b.TextChanged += new System.EventHandler(this.cart_b_TextChanged);
            // 
            // button_clear
            // 
            this.button_clear.BorderColor = System.Drawing.Color.Silver;
            this.button_clear.ButtonColor = System.Drawing.Color.Red;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Location = new System.Drawing.Point(9, 388);
            this.button_clear.Name = "button_clear";
            this.button_clear.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_clear.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_clear.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_clear.Size = new System.Drawing.Size(372, 32);
            this.button_clear.TabIndex = 10;
            this.button_clear.Text = "Clear All";
            this.button_clear.TextColor = System.Drawing.Color.White;
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_del
            // 
            this.button_del.BorderColor = System.Drawing.Color.Silver;
            this.button_del.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_del.Location = new System.Drawing.Point(438, 388);
            this.button_del.Name = "button_del";
            this.button_del.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_del.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_del.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_del.Size = new System.Drawing.Size(354, 32);
            this.button_del.TabIndex = 11;
            this.button_del.Text = "Delete";
            this.button_del.TextColor = System.Drawing.Color.White;
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // Transaction_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cart_b);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Transaction_form";
            this.Text = "Transaction_form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cart_b;
        private ePOSOne.btnProduct.Button_WOC button_clear;
        private ePOSOne.btnProduct.Button_WOC button_del;
    }
}