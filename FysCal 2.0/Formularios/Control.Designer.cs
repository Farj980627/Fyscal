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
            this.Container = new System.Windows.Forms.Panel();
            this.lblCliente = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDatos = new System.Windows.Forms.Button();
            this.btnIngresos = new System.Windows.Forms.Button();
            this.btnDeducciones = new System.Windows.Forms.Button();
            this.btnCalcGeneral = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Controls.Add(this.btnDatos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnIngresos, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDeducciones, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCalcGeneral, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(230, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1060, 45);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // Container
            // 
            this.Container.AutoScroll = true;
            this.Container.Location = new System.Drawing.Point(202, 106);
            this.Container.Margin = new System.Windows.Forms.Padding(4);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(1296, 669);
            this.Container.TabIndex = 10;
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(1263, 67);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(0, 27);
            this.lblCliente.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::FysCal_2._0.Properties.Resources.Portada;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(466, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 39);
            this.button2.TabIndex = 21;
            this.button2.Text = "RESUMEN IVA";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = global::FysCal_2._0.Properties.Resources.eliminar;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(699, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(402, 39);
            this.button3.TabIndex = 22;
            this.button3.Text = "DEDUCCIONES PERSONALES";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::FysCal_2._0.Properties.Resources.Portada;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(233, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 40);
            this.button1.TabIndex = 20;
            this.button1.Text = "RESUMEN ISR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnDatos
            // 
            this.btnDatos.BackColor = System.Drawing.Color.White;
            this.btnDatos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.btnDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatos.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatos.ForeColor = System.Drawing.Color.Black;
            this.btnDatos.Image = global::FysCal_2._0.Properties.Resources.Portada;
            this.btnDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatos.Location = new System.Drawing.Point(3, 3);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(227, 39);
            this.btnDatos.TabIndex = 18;
            this.btnDatos.Text = "DATOS";
            this.btnDatos.UseVisualStyleBackColor = false;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // btnIngresos
            // 
            this.btnIngresos.BackColor = System.Drawing.Color.White;
            this.btnIngresos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.btnIngresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresos.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresos.ForeColor = System.Drawing.Color.Black;
            this.btnIngresos.Image = global::FysCal_2._0.Properties.Resources.ingresos;
            this.btnIngresos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresos.Location = new System.Drawing.Point(236, 3);
            this.btnIngresos.Name = "btnIngresos";
            this.btnIngresos.Size = new System.Drawing.Size(227, 39);
            this.btnIngresos.TabIndex = 10;
            this.btnIngresos.Text = "INGRESOS";
            this.btnIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngresos.UseVisualStyleBackColor = false;
            this.btnIngresos.Click += new System.EventHandler(this.btnIngresos_Click);
            // 
            // btnDeducciones
            // 
            this.btnDeducciones.BackColor = System.Drawing.Color.White;
            this.btnDeducciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.btnDeducciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeducciones.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeducciones.ForeColor = System.Drawing.Color.Black;
            this.btnDeducciones.Image = global::FysCal_2._0.Properties.Resources.eliminar;
            this.btnDeducciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeducciones.Location = new System.Drawing.Point(469, 3);
            this.btnDeducciones.Name = "btnDeducciones";
            this.btnDeducciones.Size = new System.Drawing.Size(227, 39);
            this.btnDeducciones.TabIndex = 15;
            this.btnDeducciones.Text = "DEDUCCIONES";
            this.btnDeducciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeducciones.UseVisualStyleBackColor = false;
            this.btnDeducciones.Click += new System.EventHandler(this.btnDeducciones_Click);
            // 
            // btnCalcGeneral
            // 
            this.btnCalcGeneral.BackColor = System.Drawing.Color.White;
            this.btnCalcGeneral.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.btnCalcGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcGeneral.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcGeneral.ForeColor = System.Drawing.Color.Black;
            this.btnCalcGeneral.Image = global::FysCal_2._0.Properties.Resources.calcGen;
            this.btnCalcGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcGeneral.Location = new System.Drawing.Point(702, 3);
            this.btnCalcGeneral.Name = "btnCalcGeneral";
            this.btnCalcGeneral.Size = new System.Drawing.Size(355, 39);
            this.btnCalcGeneral.TabIndex = 19;
            this.btnCalcGeneral.Text = "CALC. GENERAL";
            this.btnCalcGeneral.UseVisualStyleBackColor = false;
            this.btnCalcGeneral.Click += new System.EventHandler(this.btnCalcGeneral_Click);
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
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Image = global::FysCal_2._0.Properties.Resources.volver;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(4, 210);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(191, 40);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "REGRESAR";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1503, 788);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Panel Container;
        private System.Windows.Forms.Button btnIngresos;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnDatos;
        private System.Windows.Forms.Button btnDeducciones;
        private System.Windows.Forms.Button btnCalcGeneral;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnGuardar;
    }
}