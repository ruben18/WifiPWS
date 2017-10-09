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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // getWifis
            // 
            this.getWifis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("getWifis.BackgroundImage")));
            this.getWifis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.getWifis.Location = new System.Drawing.Point(12, 266);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
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
            this.sync.Location = new System.Drawing.Point(51, 266);
            this.sync.Name = "sync";
            this.sync.Size = new System.Drawing.Size(33, 31);
            this.sync.TabIndex = 2;
            this.sync.UseVisualStyleBackColor = true;
            this.sync.Click += new System.EventHandler(this.sync_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 301);
            this.Controls.Add(this.sync);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.getWifis);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getWifis;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SSID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Authentication;
        private System.Windows.Forms.DataGridViewTextBoxColumn KEY;
        private System.Windows.Forms.Button sync;
    }
}

