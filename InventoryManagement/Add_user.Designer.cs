﻿namespace InventoryManagement
{
    partial class Add_user
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
            this.data_panel = new System.Windows.Forms.Panel();
            this.user_listBox = new System.Windows.Forms.ListBox();
            this.button_add = new ePOSOne.btnProduct.Button_WOC();
            this.list_lbl = new System.Windows.Forms.Label();
            this.info_panel = new System.Windows.Forms.Panel();
            this.button_update = new ePOSOne.btnProduct.Button_WOC();
            this.button_delete = new ePOSOne.btnProduct.Button_WOC();
            this.address_textBox = new System.Windows.Forms.TextBox();
            this.con_textBox = new System.Windows.Forms.TextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.uname_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.data_panel.SuspendLayout();
            this.info_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_panel
            // 
            this.data_panel.Controls.Add(this.user_listBox);
            this.data_panel.Controls.Add(this.button_delete);
            this.data_panel.Controls.Add(this.button_add);
            this.data_panel.Controls.Add(this.list_lbl);
            this.data_panel.Location = new System.Drawing.Point(51, 52);
            this.data_panel.Name = "data_panel";
            this.data_panel.Size = new System.Drawing.Size(327, 373);
            this.data_panel.TabIndex = 0;
            // 
            // user_listBox
            // 
            this.user_listBox.FormattingEnabled = true;
            this.user_listBox.Location = new System.Drawing.Point(4, 66);
            this.user_listBox.Name = "user_listBox";
            this.user_listBox.Size = new System.Drawing.Size(320, 238);
            this.user_listBox.TabIndex = 6;
            this.user_listBox.SelectedIndexChanged += new System.EventHandler(this.user_listBox_SelectedIndexChanged);
            // 
            // button_add
            // 
            this.button_add.BorderColor = System.Drawing.Color.Silver;
            this.button_add.ButtonColor = System.Drawing.Color.OliveDrab;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Location = new System.Drawing.Point(52, 324);
            this.button_add.Name = "button_add";
            this.button_add.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_add.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_add.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_add.Size = new System.Drawing.Size(75, 34);
            this.button_add.TabIndex = 4;
            this.button_add.Text = "Add";
            this.button_add.TextColor = System.Drawing.Color.White;
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // list_lbl
            // 
            this.list_lbl.AutoSize = true;
            this.list_lbl.Location = new System.Drawing.Point(136, 27);
            this.list_lbl.Name = "list_lbl";
            this.list_lbl.Size = new System.Drawing.Size(48, 13);
            this.list_lbl.TabIndex = 3;
            this.list_lbl.Text = "User List";
            // 
            // info_panel
            // 
            this.info_panel.Controls.Add(this.button_update);
            this.info_panel.Controls.Add(this.address_textBox);
            this.info_panel.Controls.Add(this.con_textBox);
            this.info_panel.Controls.Add(this.name_textBox);
            this.info_panel.Controls.Add(this.uname_textBox);
            this.info_panel.Controls.Add(this.label5);
            this.info_panel.Controls.Add(this.label4);
            this.info_panel.Controls.Add(this.label3);
            this.info_panel.Controls.Add(this.label2);
            this.info_panel.Controls.Add(this.label1);
            this.info_panel.Location = new System.Drawing.Point(427, 52);
            this.info_panel.Name = "info_panel";
            this.info_panel.Size = new System.Drawing.Size(327, 373);
            this.info_panel.TabIndex = 1;
            // 
            // button_update
            // 
            this.button_update.BorderColor = System.Drawing.Color.Silver;
            this.button_update.ButtonColor = System.Drawing.Color.DarkGreen;
            this.button_update.Location = new System.Drawing.Point(125, 300);
            this.button_update.Name = "button_update";
            this.button_update.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_update.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_update.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_update.Size = new System.Drawing.Size(75, 34);
            this.button_update.TabIndex = 6;
            this.button_update.Text = "Update";
            this.button_update.TextColor = System.Drawing.Color.White;
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.BorderColor = System.Drawing.Color.Silver;
            this.button_delete.ButtonColor = System.Drawing.Color.Red;
            this.button_delete.Location = new System.Drawing.Point(190, 324);
            this.button_delete.Name = "button_delete";
            this.button_delete.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_delete.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_delete.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_delete.Size = new System.Drawing.Size(75, 34);
            this.button_delete.TabIndex = 7;
            this.button_delete.Text = "Delete";
            this.button_delete.TextColor = System.Drawing.Color.White;
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // address_textBox
            // 
            this.address_textBox.Location = new System.Drawing.Point(171, 243);
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.Size = new System.Drawing.Size(131, 20);
            this.address_textBox.TabIndex = 12;
            this.address_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.address_textBox_Validating);
            // 
            // con_textBox
            // 
            this.con_textBox.Location = new System.Drawing.Point(171, 191);
            this.con_textBox.Name = "con_textBox";
            this.con_textBox.Size = new System.Drawing.Size(131, 20);
            this.con_textBox.TabIndex = 11;
            this.con_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.con_textBox_Validating);
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(171, 143);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(131, 20);
            this.name_textBox.TabIndex = 10;
            this.name_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.name_textBox_Validating);
            // 
            // uname_textBox
            // 
            this.uname_textBox.Location = new System.Drawing.Point(171, 94);
            this.uname_textBox.Name = "uname_textBox";
            this.uname_textBox.Size = new System.Drawing.Size(131, 20);
            this.uname_textBox.TabIndex = 9;
            this.uname_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.uname_textBox_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Information";
            // 
            // Add_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.info_panel);
            this.Controls.Add(this.data_panel);
            this.Name = "Add_user";
            this.Text = "Add_user";
            this.data_panel.ResumeLayout(false);
            this.data_panel.PerformLayout();
            this.info_panel.ResumeLayout(false);
            this.info_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel data_panel;
        private ePOSOne.btnProduct.Button_WOC button_add;
        private System.Windows.Forms.Label list_lbl;
        private System.Windows.Forms.Panel info_panel;
        private System.Windows.Forms.TextBox address_textBox;
        private System.Windows.Forms.TextBox con_textBox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox uname_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ePOSOne.btnProduct.Button_WOC button_update;
        private ePOSOne.btnProduct.Button_WOC button_delete;
        private System.Windows.Forms.ListBox user_listBox;
    }
}