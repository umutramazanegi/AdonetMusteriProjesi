namespace AdonetCustomer
{
    partial class FrmMap
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
            this.btnStatisticsForm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOpenCustomerForm = new System.Windows.Forms.Button();
            this.btnOpenCityForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStatisticsForm
            // 
            this.btnStatisticsForm.Location = new System.Drawing.Point(38, 167);
            this.btnStatisticsForm.Margin = new System.Windows.Forms.Padding(2);
            this.btnStatisticsForm.Name = "btnStatisticsForm";
            this.btnStatisticsForm.Size = new System.Drawing.Size(149, 54);
            this.btnStatisticsForm.TabIndex = 7;
            this.btnStatisticsForm.Text = "İstatistikler";
            this.btnStatisticsForm.UseVisualStyleBackColor = true;
            this.btnStatisticsForm.Click += new System.EventHandler(this.btnStatisticsForm_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(38, 236);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 54);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Çıkış Yap";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOpenCustomerForm
            // 
            this.btnOpenCustomerForm.Location = new System.Drawing.Point(38, 97);
            this.btnOpenCustomerForm.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenCustomerForm.Name = "btnOpenCustomerForm";
            this.btnOpenCustomerForm.Size = new System.Drawing.Size(149, 54);
            this.btnOpenCustomerForm.TabIndex = 5;
            this.btnOpenCustomerForm.Text = "Müşteri İşlemleri";
            this.btnOpenCustomerForm.UseVisualStyleBackColor = true;
            this.btnOpenCustomerForm.Click += new System.EventHandler(this.btnOpenCustomerForm_Click);
            // 
            // btnOpenCityForm
            // 
            this.btnOpenCityForm.Location = new System.Drawing.Point(38, 24);
            this.btnOpenCityForm.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenCityForm.Name = "btnOpenCityForm";
            this.btnOpenCityForm.Size = new System.Drawing.Size(149, 54);
            this.btnOpenCityForm.TabIndex = 4;
            this.btnOpenCityForm.Text = "Şehir İşlemleri";
            this.btnOpenCityForm.UseVisualStyleBackColor = true;
            this.btnOpenCityForm.Click += new System.EventHandler(this.btnOpenCityForm_Click);
            // 
            // FrmMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 312);
            this.Controls.Add(this.btnStatisticsForm);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOpenCustomerForm);
            this.Controls.Add(this.btnOpenCityForm);
            this.Name = "FrmMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formlar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStatisticsForm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOpenCustomerForm;
        private System.Windows.Forms.Button btnOpenCityForm;
    }
}