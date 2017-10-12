namespace wifiPasswords
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
            this.getWifis = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SSID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Authentication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KEY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sync = new System.Windows.Forms.Button();
            this.dataGridViewAllWifis = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllWifis)).BeginInit();
            this.SuspendLayout();
            // 
            // getWifis
            // 
            this.getWifis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("getWifis.BackgroundImage")));
            this.getWifis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.getWifis.Location = new System.Drawing.Point(12, 282);
            this.getWifis.Name = "getWifis";
            this.getWifis.Size = new System.Drawing.Size(33, 31);
            this.getWifis.TabIndex = 0;
            this.getWifis.UseVisualStyleBackColor = true;
            this.getWifis.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SSID,
            this.Authentication,
            this.KEY});
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(345, 248);
            this.dataGridView1.TabIndex = 1;
            // 
            // SSID
            // 
            this.SSID.HeaderText = "Name";
            this.SSID.Name = "SSID";
            this.SSID.ReadOnly = true;
            // 
            // Authentication
            // 
            this.Authentication.HeaderText = "Authentication";
            this.Authentication.Name = "Authentication";
            this.Authentication.ReadOnly = true;
            // 
            // KEY
            // 
            this.KEY.HeaderText = "Password";
            this.KEY.Name = "KEY";
            this.KEY.ReadOnly = true;
            // 
            // sync
            // 
            this.sync.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sync.BackgroundImage")));
            this.sync.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sync.Enabled = false;
            this.sync.Location = new System.Drawing.Point(47, 282);
            this.sync.Name = "sync";
            this.sync.Size = new System.Drawing.Size(33, 31);
            this.sync.TabIndex = 2;
            this.sync.UseVisualStyleBackColor = true;
            this.sync.Click += new System.EventHandler(this.sync_Click);
            // 
            // dataGridViewAllWifis
            // 
            this.dataGridViewAllWifis.AllowUserToAddRows = false;
            this.dataGridViewAllWifis.AllowUserToDeleteRows = false;
            this.dataGridViewAllWifis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllWifis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridViewAllWifis.Location = new System.Drawing.Point(12, 335);
            this.dataGridViewAllWifis.Name = "dataGridViewAllWifis";
            this.dataGridViewAllWifis.ReadOnly = true;
            this.dataGridViewAllWifis.Size = new System.Drawing.Size(345, 248);
            this.dataGridViewAllWifis.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Authentication";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Password";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "All Wifis ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yours saved Wifis ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 594);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewAllWifis);
            this.Controls.Add(this.sync);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.getWifis);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Wifi Passwords";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllWifis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getWifis;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SSID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Authentication;
        private System.Windows.Forms.DataGridViewTextBoxColumn KEY;
        private System.Windows.Forms.Button sync;
        private System.Windows.Forms.DataGridView dataGridViewAllWifis;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

