namespace KinoProgramvareApp
{
    partial class FrmShowTime
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
            this.dgShowTimes = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMovies = new System.Windows.Forms.ComboBox();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTickets = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgShowTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgShowTimes
            // 
            this.dgShowTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgShowTimes.Location = new System.Drawing.Point(345, 52);
            this.dgShowTimes.Name = "dgShowTimes";
            this.dgShowTimes.RowHeadersWidth = 51;
            this.dgShowTimes.RowTemplate.Height = 24;
            this.dgShowTimes.Size = new System.Drawing.Size(412, 345);
            this.dgShowTimes.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Película";
            // 
            // cboMovies
            // 
            this.cboMovies.FormattingEnabled = true;
            this.cboMovies.Location = new System.Drawing.Point(165, 207);
            this.cboMovies.Name = "cboMovies";
            this.cboMovies.Size = new System.Drawing.Size(121, 24);
            this.cboMovies.TabIndex = 18;
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(165, 168);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(121, 22);
            this.txtMinutes.TabIndex = 17;
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(165, 129);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(121, 22);
            this.txtHour.TabIndex = 16;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(122, 260);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(132, 52);
            this.btnCreate.TabIndex = 15;
            this.btnCreate.Text = "Agregar Horario";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Minutos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Hora";
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTickets.Location = new System.Drawing.Point(83, 64);
            this.lblTickets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(203, 25);
            this.lblTickets.TabIndex = 69;
            this.lblTickets.Text = "Gestión de Horarios";
            // 
            // FrmShowTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTickets);
            this.Controls.Add(this.dgShowTimes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboMovies);
            this.Controls.Add(this.txtMinutes);
            this.Controls.Add(this.txtHour);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmShowTime";
            this.Text = "Horario";
            this.Load += new System.EventHandler(this.FrmShowTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgShowTimes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgShowTimes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMovies;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTickets;
    }
}