namespace KinoProgramvareApp
{
    partial class FrmOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCreditCard = new System.Windows.Forms.TextBox();
            this.cboSnack = new System.Windows.Forms.ComboBox();
            this.dgSnacks = new System.Windows.Forms.DataGridView();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddSnacks = new System.Windows.Forms.Button();
            this.dgOrders = new System.Windows.Forms.DataGridView();
            this.txtNinosMenores = new System.Windows.Forms.TextBox();
            this.txtNiños = new System.Windows.Forms.TextBox();
            this.txtEntradasGenerales = new System.Windows.Forms.TextBox();
            this.txtAdultosMayores = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.lblTickets = new System.Windows.Forms.Label();
            this.dgMovies = new System.Windows.Forms.DataGridView();
            this.dgCustomers = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSnacks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 85;
            this.label1.Text = "Tarjeta de Crédito";
            // 
            // txtCreditCard
            // 
            this.txtCreditCard.Location = new System.Drawing.Point(403, 211);
            this.txtCreditCard.Name = "txtCreditCard";
            this.txtCreditCard.Size = new System.Drawing.Size(166, 22);
            this.txtCreditCard.TabIndex = 84;
            // 
            // cboSnack
            // 
            this.cboSnack.FormattingEnabled = true;
            this.cboSnack.Location = new System.Drawing.Point(1080, 280);
            this.cboSnack.Name = "cboSnack";
            this.cboSnack.Size = new System.Drawing.Size(298, 24);
            this.cboSnack.TabIndex = 83;
            // 
            // dgSnacks
            // 
            this.dgSnacks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSnacks.Location = new System.Drawing.Point(1033, 401);
            this.dgSnacks.Name = "dgSnacks";
            this.dgSnacks.RowHeadersWidth = 51;
            this.dgSnacks.RowTemplate.Height = 24;
            this.dgSnacks.Size = new System.Drawing.Size(393, 311);
            this.dgSnacks.TabIndex = 82;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(1213, 310);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(107, 22);
            this.txtCantidad.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1139, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 80;
            this.label2.Text = "Cantidad:";
            // 
            // btnAddSnacks
            // 
            this.btnAddSnacks.Location = new System.Drawing.Point(1080, 338);
            this.btnAddSnacks.Name = "btnAddSnacks";
            this.btnAddSnacks.Size = new System.Drawing.Size(143, 57);
            this.btnAddSnacks.TabIndex = 79;
            this.btnAddSnacks.Text = "Agregar a la compra";
            this.btnAddSnacks.UseVisualStyleBackColor = true;
            this.btnAddSnacks.Click += new System.EventHandler(this.btnAddSnacks_Click);
            // 
            // dgOrders
            // 
            this.dgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrders.Location = new System.Drawing.Point(15, 262);
            this.dgOrders.Name = "dgOrders";
            this.dgOrders.RowHeadersWidth = 51;
            this.dgOrders.RowTemplate.Height = 24;
            this.dgOrders.Size = new System.Drawing.Size(1001, 450);
            this.dgOrders.TabIndex = 78;
            // 
            // txtNinosMenores
            // 
            this.txtNinosMenores.Location = new System.Drawing.Point(403, 141);
            this.txtNinosMenores.Margin = new System.Windows.Forms.Padding(4);
            this.txtNinosMenores.Name = "txtNinosMenores";
            this.txtNinosMenores.Size = new System.Drawing.Size(121, 22);
            this.txtNinosMenores.TabIndex = 77;
            // 
            // txtNiños
            // 
            this.txtNiños.Location = new System.Drawing.Point(403, 114);
            this.txtNiños.Margin = new System.Windows.Forms.Padding(4);
            this.txtNiños.Name = "txtNiños";
            this.txtNiños.Size = new System.Drawing.Size(121, 22);
            this.txtNiños.TabIndex = 76;
            // 
            // txtEntradasGenerales
            // 
            this.txtEntradasGenerales.Location = new System.Drawing.Point(403, 88);
            this.txtEntradasGenerales.Margin = new System.Windows.Forms.Padding(4);
            this.txtEntradasGenerales.Name = "txtEntradasGenerales";
            this.txtEntradasGenerales.Size = new System.Drawing.Size(121, 22);
            this.txtEntradasGenerales.TabIndex = 75;
            // 
            // txtAdultosMayores
            // 
            this.txtAdultosMayores.Location = new System.Drawing.Point(403, 62);
            this.txtAdultosMayores.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdultosMayores.Name = "txtAdultosMayores";
            this.txtAdultosMayores.Size = new System.Drawing.Size(121, 22);
            this.txtAdultosMayores.TabIndex = 74;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(135, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 17);
            this.label8.TabIndex = 73;
            this.label8.Text = "Niño (Menor de 2 años):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 17);
            this.label7.TabIndex = 72;
            this.label7.Text = "Niño (A partir de 2 a 12 años):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 17);
            this.label6.TabIndex = 71;
            this.label6.Text = "Entrada General (de 13 años a más):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 70;
            this.label5.Text = "Adulto Mayor:";
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Location = new System.Drawing.Point(15, 200);
            this.btnCreateOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(181, 49);
            this.btnCreateOrder.TabIndex = 69;
            this.btnCreateOrder.Text = "Comprar";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTickets.Location = new System.Drawing.Point(189, 21);
            this.lblTickets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(296, 25);
            this.lblTickets.TabIndex = 68;
            this.lblTickets.Text = "Cantidad de Tickets por edad";
            // 
            // dgMovies
            // 
            this.dgMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMovies.Location = new System.Drawing.Point(676, 30);
            this.dgMovies.Name = "dgMovies";
            this.dgMovies.RowHeadersWidth = 51;
            this.dgMovies.RowTemplate.Height = 24;
            this.dgMovies.Size = new System.Drawing.Size(340, 190);
            this.dgMovies.TabIndex = 67;
            this.dgMovies.DoubleClick += new System.EventHandler(this.dgMovies_DoubleClick);
            // 
            // dgCustomers
            // 
            this.dgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomers.Location = new System.Drawing.Point(1033, 30);
            this.dgCustomers.Name = "dgCustomers";
            this.dgCustomers.RowHeadersWidth = 51;
            this.dgCustomers.RowTemplate.Height = 24;
            this.dgCustomers.Size = new System.Drawing.Size(393, 190);
            this.dgCustomers.TabIndex = 66;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1235, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 57);
            this.button1.TabIndex = 86;
            this.button1.Text = "Eliminar de la compra";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1441, 742);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCreditCard);
            this.Controls.Add(this.cboSnack);
            this.Controls.Add(this.dgSnacks);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddSnacks);
            this.Controls.Add(this.dgOrders);
            this.Controls.Add(this.txtNinosMenores);
            this.Controls.Add(this.txtNiños);
            this.Controls.Add(this.txtEntradasGenerales);
            this.Controls.Add(this.txtAdultosMayores);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.lblTickets);
            this.Controls.Add(this.dgMovies);
            this.Controls.Add(this.dgCustomers);
            this.Name = "FrmOrder";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.FrmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSnacks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCreditCard;
        private System.Windows.Forms.ComboBox cboSnack;
        private System.Windows.Forms.DataGridView dgSnacks;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddSnacks;
        private System.Windows.Forms.DataGridView dgOrders;
        private System.Windows.Forms.TextBox txtNinosMenores;
        private System.Windows.Forms.TextBox txtNiños;
        private System.Windows.Forms.TextBox txtEntradasGenerales;
        private System.Windows.Forms.TextBox txtAdultosMayores;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Label lblTickets;
        private System.Windows.Forms.DataGridView dgMovies;
        private System.Windows.Forms.DataGridView dgCustomers;
        private System.Windows.Forms.Button button1;
    }
}