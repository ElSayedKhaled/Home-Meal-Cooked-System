namespace Home_Meal_Cooked_systeam
{
    partial class DEL_ORDER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DEL_ORDER));
            this.textdelid = new System.Windows.Forms.TextBox();
            this.labid = new System.Windows.Forms.Label();
            this.butdelid = new System.Windows.Forms.Button();
            this.butVorder = new System.Windows.Forms.Button();
            this.DGV_delorder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_delorder)).BeginInit();
            this.SuspendLayout();
            // 
            // textdelid
            // 
            this.textdelid.Location = new System.Drawing.Point(15, 123);
            this.textdelid.Name = "textdelid";
            this.textdelid.Size = new System.Drawing.Size(135, 20);
            this.textdelid.TabIndex = 0;
            this.textdelid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labid
            // 
            this.labid.AutoSize = true;
            this.labid.Location = new System.Drawing.Point(12, 86);
            this.labid.Name = "labid";
            this.labid.Size = new System.Drawing.Size(63, 13);
            this.labid.TabIndex = 1;
            this.labid.Text = "ORDER_ID";
            // 
            // butdelid
            // 
            this.butdelid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butdelid.Location = new System.Drawing.Point(15, 161);
            this.butdelid.Name = "butdelid";
            this.butdelid.Size = new System.Drawing.Size(135, 29);
            this.butdelid.TabIndex = 2;
            this.butdelid.Text = "DELETE";
            this.butdelid.UseVisualStyleBackColor = true;
            this.butdelid.Click += new System.EventHandler(this.button1_Click);
            // 
            // butVorder
            // 
            this.butVorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butVorder.Location = new System.Drawing.Point(15, 12);
            this.butVorder.Name = "butVorder";
            this.butVorder.Size = new System.Drawing.Size(135, 29);
            this.butVorder.TabIndex = 3;
            this.butVorder.Text = "VIEW ORDER";
            this.butVorder.UseVisualStyleBackColor = true;
            this.butVorder.Click += new System.EventHandler(this.butVorder_Click);
            // 
            // DGV_delorder
            // 
            this.DGV_delorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_delorder.Location = new System.Drawing.Point(265, 3);
            this.DGV_delorder.Name = "DGV_delorder";
            this.DGV_delorder.Size = new System.Drawing.Size(330, 351);
            this.DGV_delorder.TabIndex = 4;
            // 
            // DEL_ORDER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(594, 326);
            this.Controls.Add(this.DGV_delorder);
            this.Controls.Add(this.butVorder);
            this.Controls.Add(this.butdelid);
            this.Controls.Add(this.labid);
            this.Controls.Add(this.textdelid);
            this.Name = "DEL_ORDER";
            this.Text = "DEL_ORDER";
            this.Load += new System.EventHandler(this.DEL_ORDER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_delorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textdelid;
        private System.Windows.Forms.Label labid;
        private System.Windows.Forms.Button butdelid;
        private System.Windows.Forms.Button butVorder;
        private System.Windows.Forms.DataGridView DGV_delorder;
    }
}