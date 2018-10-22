namespace FysCal_2._0
{
    partial class login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnAcceder, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(329, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(429, 563);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.Black;
            this.btnAcceder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.ForeColor = System.Drawing.Color.White;
            this.btnAcceder.Location = new System.Drawing.Point(3, 423);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(423, 134);
            this.btnAcceder.TabIndex = 3;
            this.btnAcceder.Text = "ACCEDER";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.txtContrasenia);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 283);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 134);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::FysCal_2._0.Properties.Resources.Contrasenia;
            this.pictureBox5.Location = new System.Drawing.Point(159, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(105, 91);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.txtContrasenia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtContrasenia.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenia.ForeColor = System.Drawing.Color.White;
            this.txtContrasenia.Location = new System.Drawing.Point(0, 97);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(423, 37);
            this.txtContrasenia.TabIndex = 2;
            this.txtContrasenia.Text = "Contraseña...";
            this.txtContrasenia.Enter += new System.EventHandler(this.txtContrasenia_Enter);
            this.txtContrasenia.Leave += new System.EventHandler(this.txtContrasenia_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 134);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::FysCal_2._0.Properties.Resources.Usuario;
            this.pictureBox4.Location = new System.Drawing.Point(159, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(105, 91);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.txtUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtUsuario.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(0, 97);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(423, 37);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Text = "Usuario...";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(423, 134);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(423, 76);
            this.button1.TabIndex = 1;
            this.button1.Text = "INICIAR SESIÓN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FysCal_2._0.Properties.Resources.Adorno;
            this.pictureBox3.Location = new System.Drawing.Point(3, 85);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(420, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FysCal_2._0.Properties.Resources.LOGO;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 174);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(34)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1087, 587);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

