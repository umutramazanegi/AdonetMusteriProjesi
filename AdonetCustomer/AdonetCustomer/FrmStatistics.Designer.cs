namespace AdonetCustomer
{
    partial class FrmStatistics
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
            this.lblCustomerBalance = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCustomerCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCityCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCustomerBalance
            // 
            this.lblCustomerBalance.AutoSize = true;
            this.lblCustomerBalance.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerBalance.Location = new System.Drawing.Point(270, 123);
            this.lblCustomerBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerBalance.Name = "lblCustomerBalance";
            this.lblCustomerBalance.Size = new System.Drawing.Size(19, 21);
            this.lblCustomerBalance.TabIndex = 11;
            this.lblCustomerBalance.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(33, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Müşterilerin Toplam Bakiyesi:";
            // 
            // lblCustomerCount
            // 
            this.lblCustomerCount.AutoSize = true;
            this.lblCustomerCount.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerCount.Location = new System.Drawing.Point(270, 88);
            this.lblCustomerCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerCount.Name = "lblCustomerCount";
            this.lblCustomerCount.Size = new System.Drawing.Size(19, 21);
            this.lblCustomerCount.TabIndex = 9;
            this.lblCustomerCount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(87, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Toplam Müşteri Sayısı:";
            // 
            // lblCityCount
            // 
            this.lblCityCount.AutoSize = true;
            this.lblCityCount.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCityCount.Location = new System.Drawing.Point(270, 56);
            this.lblCityCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCityCount.Name = "lblCityCount";
            this.lblCityCount.Size = new System.Drawing.Size(19, 21);
            this.lblCityCount.TabIndex = 7;
            this.lblCityCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(108, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Toplam Şehir Sayısı:";
            // 
            // FrmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 215);
            this.Controls.Add(this.lblCustomerBalance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCustomerCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCityCount);
            this.Controls.Add(this.label1);
            this.Name = "FrmStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İstatistikler";
            this.Load += new System.EventHandler(this.FrmStatistics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCustomerCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCityCount;
        private System.Windows.Forms.Label label1;
    }
}