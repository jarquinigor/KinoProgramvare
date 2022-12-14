namespace KinoProgramvareApp
{
    partial class FrmTheater
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
            this.dgTheaters = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTickets = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgTheaters)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTheaters
            // 
            this.dgTheaters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTheaters.Location = new System.Drawing.Point(389, 33);
            this.dgTheaters.Name = "dgTheaters";
            this.dgTheaters.RowHeadersWidth = 51;
            this.dgTheaters.RowTemplate.Height = 24;
            this.dgTheaters.Size = new System.Drawing.Size(448, 378);
            this.dgTheaters.TabIndex = 12;
            this.dgTheaters.DoubleClick += new System.EventHandler(this.dgTheaters_DoubleClick);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(132, 210);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(123, 30);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Crear Sala";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(200, 160);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 22);
            this.txtNumber.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Número de Sala";
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTickets.Location = new System.Drawing.Point(160, 114);
            this.lblTickets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(67, 25);
            this.lblTickets.TabIndex = 69;
            this.lblTickets.Text = "Salas";
            // 
            // FrmTheater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(885, 450);
            this.Controls.Add(this.lblTickets);
            this.Controls.Add(this.dgTheaters);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label1);
            this.Name = "FrmTheater";
            this.Text = "Sala";
            this.Load += new System.EventHandler(this.FrmTheater_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTheaters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTheaters;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTickets;
    }
}