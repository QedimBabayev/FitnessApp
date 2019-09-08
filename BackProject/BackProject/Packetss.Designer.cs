namespace BackProject
{
    partial class Packetss
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packetsAndServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServiceDuration = new System.Windows.Forms.TextBox();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.cmbPackets = new System.Windows.Forms.ComboBox();
            this.dgrPackets = new System.Windows.Forms.DataGridView();
            this.numPacket = new System.Windows.Forms.NumericUpDown();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.registersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrPackets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPacket)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.TabIndex = 1;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(204, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 50);
            this.button1.TabIndex = 22;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gold;
            this.btnUpdate.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(16, 119);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 50);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(200, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "New Packet Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(414, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Packet  Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(580, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Packet Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Packet Name";
            // 
            // txtServiceDuration
            // 
            this.txtServiceDuration.Location = new System.Drawing.Point(583, 70);
            this.txtServiceDuration.Name = "txtServiceDuration";
            this.txtServiceDuration.Size = new System.Drawing.Size(157, 20);
            this.txtServiceDuration.TabIndex = 16;
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(204, 70);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(173, 20);
            this.txtNewName.TabIndex = 14;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Lime;
            this.btnCreate.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(584, 121);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(156, 50);
            this.btnCreate.TabIndex = 13;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // cmbPackets
            // 
            this.cmbPackets.FormattingEnabled = true;
            this.cmbPackets.Location = new System.Drawing.Point(16, 69);
            this.cmbPackets.Name = "cmbPackets";
            this.cmbPackets.Size = new System.Drawing.Size(121, 21);
            this.cmbPackets.TabIndex = 12;
            // 
            // dgrPackets
            // 
            this.dgrPackets.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgrPackets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrPackets.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrPackets.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgrPackets.Location = new System.Drawing.Point(0, 217);
            this.dgrPackets.Name = "dgrPackets";
            this.dgrPackets.Size = new System.Drawing.Size(800, 233);
            this.dgrPackets.TabIndex = 23;
            this.dgrPackets.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgrPackets_RowHeaderMouseDoubleClick);
            // 
            // numPacket
            // 
            this.numPacket.Location = new System.Drawing.Point(428, 69);
            this.numPacket.Name = "numPacket";
            this.numPacket.Size = new System.Drawing.Size(120, 20);
            this.numPacket.TabIndex = 24;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // registersToolStripMenuItem
            // 
            this.registersToolStripMenuItem.Name = "registersToolStripMenuItem";
            this.registersToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.registersToolStripMenuItem.Text = "Registers";
            this.registersToolStripMenuItem.Click += new System.EventHandler(this.RegistersToolStripMenuItem_Click);
            // 
            // Packetss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numPacket);
            this.Controls.Add(this.dgrPackets);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServiceDuration);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cmbPackets);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Packetss";
            this.Text = "Packetss";
            this.Load += new System.EventHandler(this.Packetss_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrPackets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPacket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packetsToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServiceDuration;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cmbPackets;
        private System.Windows.Forms.DataGridView dgrPackets;
        private System.Windows.Forms.NumericUpDown numPacket;
        private System.Windows.Forms.ToolStripMenuItem packetsAndServicesToolStripMenuItem;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.ToolStripMenuItem registersToolStripMenuItem;
    }
}