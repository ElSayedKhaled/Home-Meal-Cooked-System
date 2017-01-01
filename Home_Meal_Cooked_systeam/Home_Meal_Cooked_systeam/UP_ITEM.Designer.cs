namespace Home_Meal_Cooked_systeam
{
    partial class UP_ITEM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UP_ITEM));
            this.textitname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textnewprice = new System.Windows.Forms.TextBox();
            this.but_up = new System.Windows.Forms.Button();
            this.DGView = new System.Windows.Forms.DataGridView();
            this.butview = new System.Windows.Forms.Button();
            this.texttype = new System.Windows.Forms.TextBox();
            this.texttime = new System.Windows.Forms.TextBox();
            this.textinger = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGView)).BeginInit();
            this.SuspendLayout();
            // 
            // textitname
            // 
            this.textitname.Location = new System.Drawing.Point(12, 37);
            this.textitname.Name = "textitname";
            this.textitname.Size = new System.Drawing.Size(133, 20);
            this.textitname.TabIndex = 0;
            this.textitname.TextChanged += new System.EventHandler(this.textitname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ITEM NAME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "PRICE";
            // 
            // textnewprice
            // 
            this.textnewprice.Location = new System.Drawing.Point(12, 84);
            this.textnewprice.Name = "textnewprice";
            this.textnewprice.Size = new System.Drawing.Size(133, 20);
            this.textnewprice.TabIndex = 8;
            this.textnewprice.TextChanged += new System.EventHandler(this.textnewprice_TextChanged);
            // 
            // but_up
            // 
            this.but_up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_up.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.but_up.Location = new System.Drawing.Point(12, 281);
            this.but_up.Name = "but_up";
            this.but_up.Size = new System.Drawing.Size(116, 38);
            this.but_up.TabIndex = 9;
            this.but_up.Text = "UPDATE";
            this.but_up.UseVisualStyleBackColor = true;
            this.but_up.Click += new System.EventHandler(this.button1_Click);
            // 
            // DGView
            // 
            this.DGView.BackgroundColor = System.Drawing.Color.Firebrick;
            this.DGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGView.Location = new System.Drawing.Point(166, 54);
            this.DGView.Name = "DGView";
            this.DGView.Size = new System.Drawing.Size(346, 286);
            this.DGView.TabIndex = 10;
            // 
            // butview
            // 
            this.butview.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butview.Location = new System.Drawing.Point(166, 12);
            this.butview.Name = "butview";
            this.butview.Size = new System.Drawing.Size(146, 36);
            this.butview.TabIndex = 11;
            this.butview.Text = "VIEW ITEM";
            this.butview.UseVisualStyleBackColor = true;
            this.butview.Click += new System.EventHandler(this.butview_Click);
            // 
            // texttype
            // 
            this.texttype.Location = new System.Drawing.Point(12, 128);
            this.texttype.Name = "texttype";
            this.texttype.Size = new System.Drawing.Size(133, 20);
            this.texttype.TabIndex = 12;
            // 
            // texttime
            // 
            this.texttime.Location = new System.Drawing.Point(12, 185);
            this.texttime.Name = "texttime";
            this.texttime.Size = new System.Drawing.Size(133, 20);
            this.texttime.TabIndex = 13;
            // 
            // textinger
            // 
            this.textinger.Location = new System.Drawing.Point(12, 237);
            this.textinger.Name = "textinger";
            this.textinger.Size = new System.Drawing.Size(133, 20);
            this.textinger.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "TYPE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "TIME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "INGERDIENTS";
            // 
            // UP_ITEM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(513, 340);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textinger);
            this.Controls.Add(this.texttime);
            this.Controls.Add(this.texttype);
            this.Controls.Add(this.butview);
            this.Controls.Add(this.DGView);
            this.Controls.Add(this.but_up);
            this.Controls.Add(this.textnewprice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textitname);
            this.Name = "UP_ITEM";
            this.Text = "UP_ITEM";
            this.Load += new System.EventHandler(this.UP_ITEM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textitname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textnewprice;
        private System.Windows.Forms.Button but_up;
        private System.Windows.Forms.DataGridView DGView;
        private System.Windows.Forms.Button butview;
        private System.Windows.Forms.TextBox texttype;
        private System.Windows.Forms.TextBox texttime;
        private System.Windows.Forms.TextBox textinger;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}