namespace Home_Meal_Cooked_systeam
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DGV = new System.Windows.Forms.DataGridView();
            this.but_view = new System.Windows.Forms.Button();
            this.but_search = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.insert_items = new System.Windows.Forms.Button();
            this.insert_order = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.butdelorder = new System.Windows.Forms.Button();
            this.textnaprice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.BackgroundColor = System.Drawing.Color.Teal;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(548, 12);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(484, 437);
            this.DGV.TabIndex = 0;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // but_view
            // 
            this.but_view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_view.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.but_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_view.Location = new System.Drawing.Point(371, 1);
            this.but_view.Name = "but_view";
            this.but_view.Size = new System.Drawing.Size(159, 30);
            this.but_view.TabIndex = 1;
            this.but_view.Text = "View Price";
            this.but_view.UseVisualStyleBackColor = true;
            this.but_view.Click += new System.EventHandler(this.but_view_Click);
            // 
            // but_search
            // 
            this.but_search.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.but_search.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.but_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_search.Location = new System.Drawing.Point(383, 137);
            this.but_search.Name = "but_search";
            this.but_search.Size = new System.Drawing.Size(159, 31);
            this.but_search.TabIndex = 2;
            this.but_search.Text = "Search";
            this.but_search.UseVisualStyleBackColor = true;
            this.but_search.Click += new System.EventHandler(this.but_search_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(158, 145);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(159, 20);
            this.textSearch.TabIndex = 3;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(105, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "AREA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // insert_items
            // 
            this.insert_items.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insert_items.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_items.ForeColor = System.Drawing.Color.Teal;
            this.insert_items.Location = new System.Drawing.Point(32, 320);
            this.insert_items.Name = "insert_items";
            this.insert_items.Size = new System.Drawing.Size(138, 34);
            this.insert_items.TabIndex = 5;
            this.insert_items.Text = "INSERT ITEM";
            this.insert_items.UseVisualStyleBackColor = true;
            this.insert_items.Click += new System.EventHandler(this.button1_Click);
            // 
            // insert_order
            // 
            this.insert_order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insert_order.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.insert_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_order.ForeColor = System.Drawing.Color.DarkRed;
            this.insert_order.Location = new System.Drawing.Point(404, 320);
            this.insert_order.Name = "insert_order";
            this.insert_order.Size = new System.Drawing.Size(138, 33);
            this.insert_order.TabIndex = 6;
            this.insert_order.Text = "INSERT ORDER";
            this.insert_order.UseVisualStyleBackColor = true;
            this.insert_order.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(217, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "UPDAT ITEM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(231, 414);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(143, 34);
            this.button2.TabIndex = 8;
            this.button2.Text = "DELETE ITEM";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // butdelorder
            // 
            this.butdelorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butdelorder.Location = new System.Drawing.Point(15, 416);
            this.butdelorder.Name = "butdelorder";
            this.butdelorder.Size = new System.Drawing.Size(155, 33);
            this.butdelorder.TabIndex = 9;
            this.butdelorder.Text = "DELETE ORDER";
            this.butdelorder.UseVisualStyleBackColor = true;
            this.butdelorder.Click += new System.EventHandler(this.butdelorder_Click);
            // 
            // textnaprice
            // 
            this.textnaprice.Location = new System.Drawing.Point(217, 13);
            this.textnaprice.Name = "textnaprice";
            this.textnaprice.Size = new System.Drawing.Size(100, 20);
            this.textnaprice.TabIndex = 10;
            this.textnaprice.TextChanged += new System.EventHandler(this.textnaprice_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(105, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "ITEM NAME";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1033, 451);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textnaprice);
            this.Controls.Add(this.butdelorder);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.insert_order);
            this.Controls.Add(this.insert_items);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.but_search);
            this.Controls.Add(this.but_view);
            this.Controls.Add(this.DGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "MAIN_MENU";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button but_view;
        private System.Windows.Forms.Button but_search;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button insert_items;
        private System.Windows.Forms.Button insert_order;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button butdelorder;
        private System.Windows.Forms.TextBox textnaprice;
        private System.Windows.Forms.Label label2;
    }
}

