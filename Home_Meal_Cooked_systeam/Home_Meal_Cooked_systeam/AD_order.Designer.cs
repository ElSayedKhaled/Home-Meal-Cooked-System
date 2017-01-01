namespace Home_Meal_Cooked_systeam
{
    partial class AD_order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AD_order));
            this.add_order = new System.Windows.Forms.Button();
            this.textnum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VIEWORDER = new System.Windows.Forms.Button();
            this.DGV_OR = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_OR)).BeginInit();
            this.SuspendLayout();
            // 
            // add_order
            // 
            this.add_order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_order.Location = new System.Drawing.Point(15, 241);
            this.add_order.Name = "add_order";
            this.add_order.Size = new System.Drawing.Size(136, 44);
            this.add_order.TabIndex = 0;
            this.add_order.Text = "ADD";
            this.add_order.UseVisualStyleBackColor = true;
            this.add_order.Click += new System.EventHandler(this.add_order_Click);
            // 
            // textnum
            // 
            this.textnum.Location = new System.Drawing.Point(15, 203);
            this.textnum.Name = "textnum";
            this.textnum.Size = new System.Drawing.Size(136, 20);
            this.textnum.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ITEMS NUMBER";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(15, 80);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(136, 20);
            this.textname.TabIndex = 7;
            this.textname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ITEM NAME";
            // 
            // VIEWORDER
            // 
            this.VIEWORDER.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VIEWORDER.Location = new System.Drawing.Point(395, 12);
            this.VIEWORDER.Name = "VIEWORDER";
            this.VIEWORDER.Size = new System.Drawing.Size(147, 35);
            this.VIEWORDER.TabIndex = 9;
            this.VIEWORDER.Text = "VIEW ORDER";
            this.VIEWORDER.UseVisualStyleBackColor = true;
            this.VIEWORDER.Click += new System.EventHandler(this.VIEWORDER_Click);
            // 
            // DGV_OR
            // 
            this.DGV_OR.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DGV_OR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_OR.GridColor = System.Drawing.Color.Fuchsia;
            this.DGV_OR.Location = new System.Drawing.Point(223, 65);
            this.DGV_OR.Name = "DGV_OR";
            this.DGV_OR.Size = new System.Drawing.Size(331, 297);
            this.DGV_OR.TabIndex = 10;
            this.DGV_OR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(237, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "VIEW ITEMS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(183, 340);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(34, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // AD_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(554, 363);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGV_OR);
            this.Controls.Add(this.VIEWORDER);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textnum);
            this.Controls.Add(this.add_order);
            this.Name = "AD_order";
            this.Text = "ADD_Order";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_OR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_order;
        private System.Windows.Forms.TextBox textnum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button VIEWORDER;
        private System.Windows.Forms.DataGridView DGV_OR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}