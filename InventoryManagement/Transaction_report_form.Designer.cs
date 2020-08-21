namespace InventoryManagement
{
    partial class Transaction_report_form
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
            this.button_del = new ePOSOne.btnProduct.Button_WOC();
            this.button_clear = new ePOSOne.btnProduct.Button_WOC();
            this.button_tran = new ePOSOne.btnProduct.Button_WOC();
            this.button_Inv = new ePOSOne.btnProduct.Button_WOC();
            this.button_crystal = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(783, 275);
            this.dataGridView1.TabIndex = 5;
            // 
            // button_del
            // 
            this.button_del.BorderColor = System.Drawing.Color.Silver;
            this.button_del.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_del.Location = new System.Drawing.Point(590, 395);
            this.button_del.Name = "button_del";
            this.button_del.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_del.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_del.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_del.Size = new System.Drawing.Size(186, 32);
            this.button_del.TabIndex = 13;
            this.button_del.Text = "Print";
            this.button_del.TextColor = System.Drawing.Color.White;
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // button_clear
            // 
            this.button_clear.BorderColor = System.Drawing.Color.Silver;
            this.button_clear.ButtonColor = System.Drawing.Color.Red;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Location = new System.Drawing.Point(12, 395);
            this.button_clear.Name = "button_clear";
            this.button_clear.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_clear.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_clear.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_clear.Size = new System.Drawing.Size(169, 32);
            this.button_clear.TabIndex = 12;
            this.button_clear.Text = "Export As Excel";
            this.button_clear.TextColor = System.Drawing.Color.White;
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_tran
            // 
            this.button_tran.BorderColor = System.Drawing.Color.Silver;
            this.button_tran.ButtonColor = System.Drawing.Color.Red;
            this.button_tran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tran.Location = new System.Drawing.Point(12, 334);
            this.button_tran.Name = "button_tran";
            this.button_tran.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_tran.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_tran.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_tran.Size = new System.Drawing.Size(372, 32);
            this.button_tran.TabIndex = 14;
            this.button_tran.Text = "View Transaction Report";
            this.button_tran.TextColor = System.Drawing.Color.White;
            this.button_tran.UseVisualStyleBackColor = true;
            this.button_tran.Click += new System.EventHandler(this.button_tran_Click);
            // 
            // button_Inv
            // 
            this.button_Inv.BorderColor = System.Drawing.Color.Silver;
            this.button_Inv.ButtonColor = System.Drawing.Color.Red;
            this.button_Inv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Inv.Location = new System.Drawing.Point(422, 334);
            this.button_Inv.Name = "button_Inv";
            this.button_Inv.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_Inv.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_Inv.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_Inv.Size = new System.Drawing.Size(354, 32);
            this.button_Inv.TabIndex = 15;
            this.button_Inv.Text = "View Inventory Report";
            this.button_Inv.TextColor = System.Drawing.Color.White;
            this.button_Inv.UseVisualStyleBackColor = true;
            this.button_Inv.Click += new System.EventHandler(this.button_Inv_Click);
            // 
            // button_crystal
            // 
            this.button_crystal.BorderColor = System.Drawing.Color.Silver;
            this.button_crystal.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_crystal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_crystal.Location = new System.Drawing.Point(289, 395);
            this.button_crystal.Name = "button_crystal";
            this.button_crystal.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_crystal.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_crystal.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_crystal.Size = new System.Drawing.Size(186, 32);
            this.button_crystal.TabIndex = 16;
            this.button_crystal.Text = "Crystal Report";
            this.button_crystal.TextColor = System.Drawing.Color.White;
            this.button_crystal.UseVisualStyleBackColor = true;
            this.button_crystal.Click += new System.EventHandler(this.button_crystal_Click);
            // 
            // Transaction_report_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_crystal);
            this.Controls.Add(this.button_Inv);
            this.Controls.Add(this.button_tran);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Transaction_report_form";
            this.Text = "Transaction_report_form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ePOSOne.btnProduct.Button_WOC button_del;
        private ePOSOne.btnProduct.Button_WOC button_clear;
        private ePOSOne.btnProduct.Button_WOC button_tran;
        private ePOSOne.btnProduct.Button_WOC button_Inv;
        private ePOSOne.btnProduct.Button_WOC button_crystal;
    }
}