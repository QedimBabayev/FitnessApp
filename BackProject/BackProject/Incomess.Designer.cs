namespace BackProject
{
    partial class Incomess
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
            this.dgrIncomes = new System.Windows.Forms.DataGridView();
            this.dtMonthMin = new System.Windows.Forms.DateTimePicker();
            this.dtMonthMax = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTools = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPureIcomes = new System.Windows.Forms.TextBox();
            this.txtResultIncome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCleaning = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgrOutcomes = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrIncomes)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrOutcomes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrIncomes
            // 
            this.dgrIncomes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgrIncomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrIncomes.Location = new System.Drawing.Point(33, 297);
            this.dgrIncomes.Name = "dgrIncomes";
            this.dgrIncomes.Size = new System.Drawing.Size(373, 150);
            this.dgrIncomes.TabIndex = 8;
            // 
            // dtMonthMin
            // 
            this.dtMonthMin.Location = new System.Drawing.Point(46, 35);
            this.dtMonthMin.Name = "dtMonthMin";
            this.dtMonthMin.Size = new System.Drawing.Size(250, 23);
            this.dtMonthMin.TabIndex = 9;
            this.dtMonthMin.Value = new System.DateTime(2019, 9, 8, 20, 34, 2, 0);
            this.dtMonthMin.ValueChanged += new System.EventHandler(this.MonthValueChanged);
            // 
            // dtMonthMax
            // 
            this.dtMonthMax.Location = new System.Drawing.Point(353, 41);
            this.dtMonthMax.Name = "dtMonthMax";
            this.dtMonthMax.Size = new System.Drawing.Size(250, 23);
            this.dtMonthMax.TabIndex = 10;
            this.dtMonthMax.Value = new System.DateTime(2019, 9, 8, 20, 34, 7, 0);
            this.dtMonthMax.ValueChanged += new System.EventHandler(this.MonthValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(43, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Minimum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(350, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Maximum";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtCleaning);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtTools);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPureIcomes);
            this.panel1.Controls.Add(this.txtResultIncome);
            this.panel1.Controls.Add(this.dtMonthMin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtMonthMax);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(33, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 281);
            this.panel1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(43, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tools Outcomes";
            // 
            // txtTools
            // 
            this.txtTools.Location = new System.Drawing.Point(37, 167);
            this.txtTools.Name = "txtTools";
            this.txtTools.Size = new System.Drawing.Size(259, 23);
            this.txtTools.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(43, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Total Incomes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(350, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Pure Income";
            // 
            // txtPureIcomes
            // 
            this.txtPureIcomes.Location = new System.Drawing.Point(353, 112);
            this.txtPureIcomes.Name = "txtPureIcomes";
            this.txtPureIcomes.Size = new System.Drawing.Size(259, 23);
            this.txtPureIcomes.TabIndex = 15;
            // 
            // txtResultIncome
            // 
            this.txtResultIncome.Location = new System.Drawing.Point(46, 101);
            this.txtResultIncome.Name = "txtResultIncome";
            this.txtResultIncome.Size = new System.Drawing.Size(259, 23);
            this.txtResultIncome.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(350, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Cleaning Outcomes";
            // 
            // txtCleaning
            // 
            this.txtCleaning.Location = new System.Drawing.Point(353, 167);
            this.txtCleaning.Name = "txtCleaning";
            this.txtCleaning.Size = new System.Drawing.Size(259, 23);
            this.txtCleaning.TabIndex = 20;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(227, 232);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(259, 23);
            this.txtTotal.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(224, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Total Outcomes";
            // 
            // dgrOutcomes
            // 
            this.dgrOutcomes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgrOutcomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrOutcomes.Location = new System.Drawing.Point(412, 297);
            this.dgrOutcomes.Name = "dgrOutcomes";
            this.dgrOutcomes.Size = new System.Drawing.Size(353, 150);
            this.dgrOutcomes.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(76, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(536, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Please, select date range from minimum and maximum boxes for looking monthly inco" +
    "mes and monthly outcomes.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(35, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "NOT:";
            // 
            // Incomess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgrOutcomes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgrIncomes);
            this.Name = "Incomess";
            this.Text = "Incomess";
            this.Load += new System.EventHandler(this.Incomess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrIncomes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrOutcomes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrIncomes;
        private System.Windows.Forms.DateTimePicker dtMonthMin;
        private System.Windows.Forms.DateTimePicker dtMonthMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPureIcomes;
        private System.Windows.Forms.TextBox txtResultIncome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTools;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCleaning;
        private System.Windows.Forms.DataGridView dgrOutcomes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}