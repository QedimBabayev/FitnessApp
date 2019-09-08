namespace BackProject
{
    partial class PacketsAndServicess
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
            this.dgrPacketsToServices = new System.Windows.Forms.DataGridView();
            this.listServices = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPackets = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packetsAndServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgrPacketsToServices)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrPacketsToServices
            // 
            this.dgrPacketsToServices.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgrPacketsToServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrPacketsToServices.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgrPacketsToServices.Location = new System.Drawing.Point(-1, 221);
            this.dgrPacketsToServices.Name = "dgrPacketsToServices";
            this.dgrPacketsToServices.Size = new System.Drawing.Size(801, 229);
            this.dgrPacketsToServices.TabIndex = 24;
            // 
            // listServices
            // 
            this.listServices.BackColor = System.Drawing.Color.Gold;
            this.listServices.FormattingEnabled = true;
            this.listServices.Location = new System.Drawing.Point(35, 34);
            this.listServices.Name = "listServices";
            this.listServices.Size = new System.Drawing.Size(120, 94);
            this.listServices.TabIndex = 25;
            this.listServices.SelectedIndexChanged += new System.EventHandler(this.ListServices_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Packet Name";
            // 
            // cmbPackets
            // 
            this.cmbPackets.FormattingEnabled = true;
            this.cmbPackets.Location = new System.Drawing.Point(320, 67);
            this.cmbPackets.Name = "cmbPackets";
            this.cmbPackets.Size = new System.Drawing.Size(121, 21);
            this.cmbPackets.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(570, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 34);
            this.button1.TabIndex = 28;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(570, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 70);
            this.button2.TabIndex = 30;
            this.button2.Text = "delete service from Packet";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.servicesToolStripMenuItem,
            this.packetsToolStripMenuItem,
            this.packetsAndServicesToolStripMenuItem,
            this.registersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.servicesToolStripMenuItem.Text = "Services";
            this.servicesToolStripMenuItem.Click += new System.EventHandler(this.ServicesToolStripMenuItem_Click);
            // 
            // packetsToolStripMenuItem
            // 
            this.packetsToolStripMenuItem.Name = "packetsToolStripMenuItem";
            this.packetsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.packetsToolStripMenuItem.Text = "Packets";
            this.packetsToolStripMenuItem.Click += new System.EventHandler(this.PacketsToolStripMenuItem_Click);
            // 
            // packetsAndServicesToolStripMenuItem
            // 
            this.packetsAndServicesToolStripMenuItem.Name = "packetsAndServicesToolStripMenuItem";
            this.packetsAndServicesToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.packetsAndServicesToolStripMenuItem.Text = "Packets and Services";
            this.packetsAndServicesToolStripMenuItem.Click += new System.EventHandler(this.PacketsAndServicesToolStripMenuItem_Click);
            // 
            // registersToolStripMenuItem
            // 
            this.registersToolStripMenuItem.Name = "registersToolStripMenuItem";
            this.registersToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.registersToolStripMenuItem.Text = "Registers";
            this.registersToolStripMenuItem.Click += new System.EventHandler(this.RegistersToolStripMenuItem_Click);
            // 
            // PacketsAndServicess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPackets);
            this.Controls.Add(this.listServices);
            this.Controls.Add(this.dgrPacketsToServices);
            this.Name = "PacketsAndServicess";
            this.Text = "PacketsAndServicess";
            this.Load += new System.EventHandler(this.PacketsAndServicess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrPacketsToServices)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrPacketsToServices;
        private System.Windows.Forms.CheckedListBox listServices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPackets;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packetsAndServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registersToolStripMenuItem;
    }
}