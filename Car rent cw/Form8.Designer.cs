namespace Car_rent_cw
{
    partial class Form8
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtvehiid = new System.Windows.Forms.TextBox();
            this.txtvehibrand = new System.Windows.Forms.TextBox();
            this.txtvehiid2 = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcharge = new System.Windows.Forms.TextBox();
            this.txtadditional = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtownerid = new System.Windows.Forms.TextBox();
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
            this.btnclose.TabIndex = 3;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.label1.Location = new System.Drawing.Point(50, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vehicle Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.label2.Location = new System.Drawing.Point(50, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vehicle Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.label3.Location = new System.Drawing.Point(532, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vehicle Id";
            // 
            // txtvehiid
            // 
            this.txtvehiid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvehiid.Location = new System.Drawing.Point(299, 135);
            this.txtvehiid.Name = "txtvehiid";
            this.txtvehiid.Size = new System.Drawing.Size(187, 36);
            this.txtvehiid.TabIndex = 7;
            // 
            // txtvehibrand
            // 
            this.txtvehibrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.txtvehibrand.Location = new System.Drawing.Point(299, 206);
            this.txtvehibrand.Name = "txtvehibrand";
            this.txtvehibrand.Size = new System.Drawing.Size(187, 37);
            this.txtvehibrand.TabIndex = 8;
            this.txtvehibrand.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtvehiid2
            // 
            this.txtvehiid2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.txtvehiid2.Location = new System.Drawing.Point(687, 138);
            this.txtvehiid2.Name = "txtvehiid2";
            this.txtvehiid2.Size = new System.Drawing.Size(177, 37);
            this.txtvehiid2.TabIndex = 9;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.btnadd.Location = new System.Drawing.Point(228, 441);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(255, 54);
            this.btnadd.TabIndex = 10;
            this.btnadd.Text = "Update vehicle";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnremove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.btnremove.Location = new System.Drawing.Point(624, 441);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(240, 54);
            this.btnremove.TabIndex = 11;
            this.btnremove.Text = "Remove Vehicle";
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.btnback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnback.Location = new System.Drawing.Point(952, 512);
            this.btnback.Margin = new System.Windows.Forms.Padding(0);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(61, 48);
            this.btnback.TabIndex = 46;
            this.btnback.Text = "<";
            this.btnback.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.button11_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.label4.Location = new System.Drawing.Point(50, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 31);
            this.label4.TabIndex = 47;
            this.label4.Text = "Charge Per Day";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.label5.Location = new System.Drawing.Point(50, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 31);
            this.label5.TabIndex = 48;
            this.label5.Text = "Additional charge (pkm)";
            // 
            // txtcharge
            // 
            this.txtcharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.txtcharge.Location = new System.Drawing.Point(299, 271);
            this.txtcharge.Name = "txtcharge";
            this.txtcharge.Size = new System.Drawing.Size(184, 37);
            this.txtcharge.TabIndex = 49;
            // 
            // txtadditional
            // 
            this.txtadditional.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.txtadditional.Location = new System.Drawing.Point(375, 331);
            this.txtadditional.Name = "txtadditional";
            this.txtadditional.Size = new System.Drawing.Size(108, 37);
            this.txtadditional.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.label6.Location = new System.Drawing.Point(47, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 31);
            this.label6.TabIndex = 51;
            this.label6.Text = "Owner Id";
            // 
            // txtownerid
            // 
            this.txtownerid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.txtownerid.Location = new System.Drawing.Point(299, 379);
            this.txtownerid.Name = "txtownerid";
            this.txtownerid.Size = new System.Drawing.Size(184, 37);
            this.txtownerid.TabIndex = 52;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1025, 589);
            this.Controls.Add(this.txtownerid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtadditional);
            this.Controls.Add(this.txtcharge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtvehiid2);
            this.Controls.Add(this.txtvehibrand);
            this.Controls.Add(this.txtvehiid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnclose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "a";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtvehiid;
        private System.Windows.Forms.TextBox txtvehibrand;
        private System.Windows.Forms.TextBox txtvehiid2;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcharge;
        private System.Windows.Forms.TextBox txtadditional;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtownerid;
    }
}