namespace KinoProgramvareApp
{
    partial class FrmShowTimeSeats
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
            this.SelectShowTime = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgMovieShowTimes = new System.Windows.Forms.DataGridView();
            this.lblTickets = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMovieShowTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectShowTime
            // 
            this.SelectShowTime.Location = new System.Drawing.Point(61, 491);
            this.SelectShowTime.Name = "SelectShowTime";
            this.SelectShowTime.Size = new System.Drawing.Size(202, 49);
            this.SelectShowTime.TabIndex = 15;
            this.SelectShowTime.Text = "Elegir Horario";
            this.SelectShowTime.UseVisualStyleBackColor = true;
            this.SelectShowTime.Click += new System.EventHandler(this.SelectShowTime_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1175, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 46);
            this.button3.TabIndex = 14;
            this.button3.Text = "ENTRADA";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(567, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(585, 46);
            this.button2.TabIndex = 13;
            this.button2.Text = "PANTALLA";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 46);
            this.button1.TabIndex = 12;
            this.button1.Text = "SALIDA";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgMovieShowTimes
            // 
            this.dgMovieShowTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMovieShowTimes.Location = new System.Drawing.Point(12, 118);
            this.dgMovieShowTimes.Name = "dgMovieShowTimes";
            this.dgMovieShowTimes.RowHeadersWidth = 51;
            this.dgMovieShowTimes.RowTemplate.Height = 24;
            this.dgMovieShowTimes.Size = new System.Drawing.Size(320, 353);
            this.dgMovieShowTimes.TabIndex = 11;
            this.dgMovieShowTimes.DoubleClick += new System.EventHandler(this.dgMovieShowTimes_DoubleClick);
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTickets.Location = new System.Drawing.Point(44, 74);
            this.lblTickets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(219, 25);
            this.lblTickets.TabIndex = 69;
            this.lblTickets.Text = "Selección de butacas";
            // 
            // FrmShowTimeSeats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1378, 691);
            this.Controls.Add(this.lblTickets);
            this.Controls.Add(this.SelectShowTime);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgMovieShowTimes);
            this.Name = "FrmShowTimeSeats";
            this.Text = "Selección de Butacas";
            this.Load += new System.EventHandler(this.FrmShowTimeSeats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMovieShowTimes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectShowTime;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgMovieShowTimes;
        private System.Windows.Forms.Label lblTickets;
    }
}