namespace FysCal_2._0.Formularios
{
    partial class Control
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnIngresos = new System.Windows.Forms.Button();
            this.btnDatos = new System.Windows.Forms.Button();
            this.btnDeducciones = new System.Windows.Forms.Button();
            this.Container = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.btnIngresos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDatos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDeducciones, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(199, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(636, 45);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // btnIngresos
            // 
            this.btnIngresos.BackColor = System.Drawing.Color.White;
            this.btnIngresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIngresos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.btnIngresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresos.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresos.ForeColor = System.Drawing.Color.Black;
            this.btnIngresos.Image = global::FysCal_2._0.Properties.Resources.ingresos;
            this.btnIngresos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresos.Location = new System.Drawing.Point(193, 3);
            this.btnIngresos.Name = "btnIngresos";
            this.btnIngresos.Size = new System.Drawing.Size(184, 39);
            this.btnIngresos.TabIndex = 10;
            this.btnIngresos.Text = "INGRESOS";
            this.btnIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngresos.UseVisualStyleBackColor = false;
            this.btnIngresos.Click += new System.EventHandler(this.btnIngresos_Click);
            // 
            // btnDatos
            // 
            this.btnDatos.BackColor = System.Drawing.Color.White;
            this.btnDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDatos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.btnDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatos.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatos.ForeColor = System.Drawing.Color.Black;
            this.btnDatos.Image = global::FysCal_2._0.Properties.Resources.Portada;
            this.btnDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatos.Location = new System.Drawing.Point(3, 3);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(184, 39);
            this.btnDatos.TabIndex = 8;
            this.btnDatos.Text = "DATOS";
            this.btnDatos.UseVisualStyleBackColor = false;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // btnDeducciones
            // 
            this.btnDeducciones.BackColor = System.Drawing.Color.White;
            this.btnDeducciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeducciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.btnDeducciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeducciones.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeducciones.ForeColor = System.Drawing.Color.Black;
            this.btnDeducciones.Image = global::FysCal_2._0.Properties.Resources.eliminar;
            this.btnDeducciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeducciones.Location = new System.Drawing.Point(383, 3);
            this.btnDeducciones.Name = "btnDeducciones";
            this.btnDeducciones.Size = new System.Drawing.Size(250, 39);
            this.btnDeducciones.TabIndex = 9;
            this.btnDeducciones.Text = "DEDUCCIONES";
            this.btnDeducciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeducciones.UseVisualStyleBackColor = false;
            this.btnDeducciones.Click += new System.EventHandler(this.btnDeducciones_Click);
            // 
            // Container
            // 
            this.Container.AutoScroll = true;
            this.Container.Location = new System.Drawing.Point(202, 64);
            this.Container.Margin = new System.Windows.Forms.Padding(4);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(1296, 711);
            this.Container.TabIndex = 10;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FysCal_2._0.Properties.Resources.LOGO;
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(163, 157);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(851, 22);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(0, 27);
            this.lblCliente.TabIndex = 11;
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1503, 788);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox3);
            this.Name = "Control";
            this.Text = "Control";
            this.Load += new System.EventHandler(this.Control_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDatos;
        private System.Windows.Forms.Panel Container;
        private System.Windows.Forms.Button btnDeducciones;
        private System.Windows.Forms.Button btnIngresos;
        private System.Windows.Forms.Label lblCliente;
    }
}