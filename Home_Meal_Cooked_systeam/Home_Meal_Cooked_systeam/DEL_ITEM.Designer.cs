namespace Home_Meal_Cooked_systeam
{
    partial class DEL_ITEM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DEL_ITEM));
            this.but_del = new System.Windows.Forms.Button();
            this.textdelname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butVITEM = new System.Windows.Forms.Button();
            this.DGVdel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdel)).BeginInit();
            this.SuspendLayout();
            // 
            // but_del
            // 
            this.but_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_del.Location = new System.Drawing.Point(9, 230);
            this.but_del.Name = "but_del";
            this.but_del.Size = new System.Drawing.Size(117, 32);
            this.but_del.TabIndex = 0;
            this.but_del.Text = "DELETE";
            this.but_del.UseVisualStyleBackColor = true;
            this.but_del.Click += new System.EventHandler(this.but_del_Click);
            // 
            // textdelname
            // 
            this.textdelname.Location = new System.Drawing.Point(9, 165);
            this.textdelname.Name = "textdelname";
            this.textdelname.Size = new System.Drawing.Size(125, 20);
            this.textdelname.TabIndex = 1;
            this.textdelname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ITEM NAME";
            // 
            // butVITEM
            // 
            this.butVITEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butVITEM.Location = new System.Drawing.Point(12, 40);
            this.butVITEM.Name = "butVITEM";
            this.butVITEM.Size = new System.Drawing.Size(114, 29);
            this.butVITEM.TabIndex = 3;
            this.butVITEM.Text = "VIEW ITEM";
            this.butVITEM.UseVisualStyleBackColor = true;
            this.butVITEM.Click += new System.EventHandler(this.butVITEM_Click);
            // 
            // DGVdel
            // 
            this.DGVdel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVdel.Location = new System.Drawing.Point(159, 12);
            this.DGVdel.Name = "DGVdel";
            this.DGVdel.Size = new System.Drawing.Size(334, 298);
            this.DGVdel.TabIndex = 4;
            this.DGVdel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DEL_ITEM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(493, 309);
            this.Controls.Add(this.DGVdel);
            this.Controls.Add(this.butVITEM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textdelname);
            this.Controls.Add(this.but_del);
            this.Name = "DEL_ITEM";
            this.Text = "DEL_ITEM";
            this.Load += new System.EventHandler(this.DEL_ITEM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVdel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_del;
        private System.Windows.Forms.TextBox textdelname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butVITEM;
        private System.Windows.Forms.DataGridView DGVdel;
    }
}