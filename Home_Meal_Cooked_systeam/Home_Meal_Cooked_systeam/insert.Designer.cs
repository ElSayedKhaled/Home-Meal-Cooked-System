namespace Home_Meal_Cooked_systeam
{
    partial class insert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(insert));
            this.textname = new System.Windows.Forms.TextBox();
            this.texttime = new System.Windows.Forms.TextBox();
            this.texttype = new System.Windows.Forms.TextBox();
            this.textprice = new System.Windows.Forms.TextBox();
            this.textingr = new System.Windows.Forms.TextBox();
            this.add_items = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DGV_Items = new System.Windows.Forms.DataGridView();
            this.but_VI = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Items)).BeginInit();
            this.SuspendLayout();
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(21, 33);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(100, 20);
            this.textname.TabIndex = 1;
            this.textname.TextChanged += new System.EventHandler(this.textname_TextChanged);
            // 
            // texttime
            // 
            this.texttime.Location = new System.Drawing.Point(21, 107);
            this.texttime.Name = "texttime";
            this.texttime.Size = new System.Drawing.Size(100, 20);
            this.texttime.TabIndex = 2;
            this.texttime.Text = "hh:mm:ss";
            this.texttime.TextChanged += new System.EventHandler(this.texttime_TextChanged);
            // 
            // texttype
            // 
            this.texttype.Location = new System.Drawing.Point(21, 170);
            this.texttype.Name = "texttype";
            this.texttype.Size = new System.Drawing.Size(100, 20);
            this.texttype.TabIndex = 3;
            // 
            // textprice
            // 
            this.textprice.Location = new System.Drawing.Point(21, 293);
            this.textprice.Name = "textprice";
            this.textprice.Size = new System.Drawing.Size(100, 20);
            this.textprice.TabIndex = 5;
            // 
            // textingr
            // 
            this.textingr.Location = new System.Drawing.Point(21, 233);
            this.textingr.Name = "textingr";
            this.textingr.Size = new System.Drawing.Size(100, 20);
            this.textingr.TabIndex = 6;
            // 
            // add_items
            // 
            this.add_items.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_items.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.add_items.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_items.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.add_items.Location = new System.Drawing.Point(12, 370);
            this.add_items.Name = "add_items";
            this.add_items.Size = new System.Drawing.Size(161, 38);
            this.add_items.TabIndex = 7;
            this.add_items.Text = "ADD";
            this.add_items.UseVisualStyleBackColor = true;
            this.add_items.Click += new System.EventHandler(this.add_itens_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Item_Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "TYPE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "INGREDIENTS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "PRICE";
            // 
            // DGV_Items
            // 
            this.DGV_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Items.Location = new System.Drawing.Point(206, 69);
            this.DGV_Items.Name = "DGV_Items";
            this.DGV_Items.Size = new System.Drawing.Size(350, 352);
            this.DGV_Items.TabIndex = 13;
            this.DGV_Items.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // but_VI
            // 
            this.but_VI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_VI.Location = new System.Drawing.Point(206, 17);
            this.but_VI.Name = "but_VI";
            this.but_VI.Size = new System.Drawing.Size(155, 39);
            this.but_VI.TabIndex = 14;
            this.but_VI.Text = "VIEW ITEMS";
            this.but_VI.UseVisualStyleBackColor = true;
            this.but_VI.Click += new System.EventHandler(this.button1_Click);
            // 
            // insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(557, 420);
            this.Controls.Add(this.but_VI);
            this.Controls.Add(this.DGV_Items);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_items);
            this.Controls.Add(this.textingr);
            this.Controls.Add(this.textprice);
            this.Controls.Add(this.texttype);
            this.Controls.Add(this.texttime);
            this.Controls.Add(this.textname);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "insert";
            this.Text = "INSERT";
            this.Load += new System.EventHandler(this.insert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Items)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox texttime;
        private System.Windows.Forms.TextBox texttype;
        private System.Windows.Forms.TextBox textprice;
        private System.Windows.Forms.TextBox textingr;
        private System.Windows.Forms.Button add_items;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DGV_Items;
        private System.Windows.Forms.Button but_VI;
    }
}