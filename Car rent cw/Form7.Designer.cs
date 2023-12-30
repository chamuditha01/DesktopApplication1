namespace Car_rent_cw
{
    partial class Form7
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
            this.btnclose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btncustomize = new System.Windows.Forms.Button();
            this.btnselect = new System.Windows.Forms.Button();
            this.comborenttype = new System.Windows.Forms.ComboBox();
            this.btnpricing = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Red;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnclose.Location = new System.Drawing.Point(964, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(49, 41);
            this.btnclose.TabIndex = 2;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(380, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 72);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dashboard";
            // 
            // btncustomize
            // 
            this.btncustomize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btncustomize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncustomize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.btncustomize.Location = new System.Drawing.Point(302, 127);
            this.btncustomize.Name = "btncustomize";
            this.btncustomize.Size = new System.Drawing.Size(387, 74);
            this.btncustomize.TabIndex = 4;
            this.btncustomize.Text = "Customize Vehicles";
            this.btncustomize.UseVisualStyleBackColor = false;
            this.btncustomize.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnselect
            // 
            this.btnselect.BackColor = System.Drawing.Color.White;
            this.btnselect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.btnselect.Location = new System.Drawing.Point(302, 229);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(387, 72);
            this.btnselect.TabIndex = 4;
            this.btnselect.Text = "View Vehicles";
            this.btnselect.UseVisualStyleBackColor = false;
            this.btnselect.Click += new System.EventHandler(this.button3_Click);
            // 
            // comborenttype
            // 
            this.comborenttype.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comborenttype.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.comborenttype.FormattingEnabled = true;
            this.comborenttype.Items.AddRange(new object[] {
            "FAMILY",
            "WEDDING"});
            this.comborenttype.Location = new System.Drawing.Point(727, 247);
            this.comborenttype.Name = "comborenttype";
            this.comborenttype.Size = new System.Drawing.Size(196, 38);
            this.comborenttype.TabIndex = 12;
            this.comborenttype.Text = "--SELECT--";
            // 
            // btnpricing
            // 
            this.btnpricing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnpricing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpricing.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.btnpricing.Location = new System.Drawing.Point(302, 330);
            this.btnpricing.Name = "btnpricing";
            this.btnpricing.Size = new System.Drawing.Size(387, 69);
            this.btnpricing.TabIndex = 4;
            this.btnpricing.Text = "Pricing Vehicles";
            this.btnpricing.UseVisualStyleBackColor = false;
            this.btnpricing.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.PeachPuff;
            this.dataGridView1.Location = new System.Drawing.Point(204, 496);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(597, 81);
            this.dataGridView1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.button1.Location = new System.Drawing.Point(302, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(387, 72);
            this.button1.TabIndex = 14;
            this.button1.Text = "View Payments";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1025, 589);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comborenttype);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.btnpricing);
            this.Controls.Add(this.btncustomize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnclose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncustomize;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.ComboBox comborenttype;
        private System.Windows.Forms.Button btnpricing;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}