namespace PASSWORD__Problema_4._5_
{
    partial class Form1
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
            this.txtContrasenia2 = new System.Windows.Forms.TextBox();
            this.buttVerificar = new System.Windows.Forms.Button();
            this.txtContrasenia1 = new System.Windows.Forms.TextBox();
            this.lblNueva_Contrasenia = new System.Windows.Forms.Label();
            this.lblRepetir_Contraseña = new System.Windows.Forms.Label();
            this.lblEsFuerte = new System.Windows.Forms.Label();
            this.lblContrasenia_Aleatoria = new System.Windows.Forms.Label();
            this.txtContraseña_Aleatoria = new System.Windows.Forms.TextBox();
            this.buttContrasenia_Aleatoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "VERIFICAR LA CONTRASEÑA";
            // 
            // txtContrasenia2
            // 
            this.txtContrasenia2.Location = new System.Drawing.Point(65, 154);
            this.txtContrasenia2.Name = "txtContrasenia2";
            this.txtContrasenia2.Size = new System.Drawing.Size(213, 20);
            this.txtContrasenia2.TabIndex = 2;
            // 
            // buttVerificar
            // 
            this.buttVerificar.Location = new System.Drawing.Point(120, 215);
            this.buttVerificar.Name = "buttVerificar";
            this.buttVerificar.Size = new System.Drawing.Size(75, 23);
            this.buttVerificar.TabIndex = 3;
            this.buttVerificar.Text = "Verificar";
            this.buttVerificar.UseVisualStyleBackColor = true;
            this.buttVerificar.Click += new System.EventHandler(this.buttVerificar_Click);
            // 
            // txtContrasenia1
            // 
            this.txtContrasenia1.Location = new System.Drawing.Point(65, 96);
            this.txtContrasenia1.Name = "txtContrasenia1";
            this.txtContrasenia1.Size = new System.Drawing.Size(213, 20);
            this.txtContrasenia1.TabIndex = 1;
            // 
            // lblNueva_Contrasenia
            // 
            this.lblNueva_Contrasenia.AutoSize = true;
            this.lblNueva_Contrasenia.Location = new System.Drawing.Point(65, 77);
            this.lblNueva_Contrasenia.Name = "lblNueva_Contrasenia";
            this.lblNueva_Contrasenia.Size = new System.Drawing.Size(99, 13);
            this.lblNueva_Contrasenia.TabIndex = 4;
            this.lblNueva_Contrasenia.Text = "Nueva Contraseña:";
            // 
            // lblRepetir_Contraseña
            // 
            this.lblRepetir_Contraseña.AutoSize = true;
            this.lblRepetir_Contraseña.Location = new System.Drawing.Point(65, 138);
            this.lblRepetir_Contraseña.Name = "lblRepetir_Contraseña";
            this.lblRepetir_Contraseña.Size = new System.Drawing.Size(101, 13);
            this.lblRepetir_Contraseña.TabIndex = 5;
            this.lblRepetir_Contraseña.Text = "Repetir Contraseña:";
            // 
            // lblEsFuerte
            // 
            this.lblEsFuerte.AutoSize = true;
            this.lblEsFuerte.Location = new System.Drawing.Point(129, 186);
            this.lblEsFuerte.Name = "lblEsFuerte";
            this.lblEsFuerte.Size = new System.Drawing.Size(58, 13);
            this.lblEsFuerte.TabIndex = 6;
            this.lblEsFuerte.Text = "Es Fuerte?";
            // 
            // lblContrasenia_Aleatoria
            // 
            this.lblContrasenia_Aleatoria.AutoSize = true;
            this.lblContrasenia_Aleatoria.Location = new System.Drawing.Point(65, 289);
            this.lblContrasenia_Aleatoria.Name = "lblContrasenia_Aleatoria";
            this.lblContrasenia_Aleatoria.Size = new System.Drawing.Size(108, 13);
            this.lblContrasenia_Aleatoria.TabIndex = 7;
            this.lblContrasenia_Aleatoria.Text = "Contraseña Aleatoria:";
            // 
            // txtContraseña_Aleatoria
            // 
            this.txtContraseña_Aleatoria.Location = new System.Drawing.Point(68, 306);
            this.txtContraseña_Aleatoria.Name = "txtContraseña_Aleatoria";
            this.txtContraseña_Aleatoria.ReadOnly = true;
            this.txtContraseña_Aleatoria.Size = new System.Drawing.Size(210, 20);
            this.txtContraseña_Aleatoria.TabIndex = 8;
            // 
            // buttContrasenia_Aleatoria
            // 
            this.buttContrasenia_Aleatoria.Location = new System.Drawing.Point(101, 332);
            this.buttContrasenia_Aleatoria.Name = "buttContrasenia_Aleatoria";
            this.buttContrasenia_Aleatoria.Size = new System.Drawing.Size(129, 23);
            this.buttContrasenia_Aleatoria.TabIndex = 4;
            this.buttContrasenia_Aleatoria.Text = "Generar Contraseña";
            this.buttContrasenia_Aleatoria.UseVisualStyleBackColor = true;
            this.buttContrasenia_Aleatoria.Click += new System.EventHandler(this.buttContrasenia_Aleatoria_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 450);
            this.Controls.Add(this.buttContrasenia_Aleatoria);
            this.Controls.Add(this.txtContraseña_Aleatoria);
            this.Controls.Add(this.lblContrasenia_Aleatoria);
            this.Controls.Add(this.lblEsFuerte);
            this.Controls.Add(this.lblRepetir_Contraseña);
            this.Controls.Add(this.lblNueva_Contrasenia);
            this.Controls.Add(this.txtContrasenia1);
            this.Controls.Add(this.buttVerificar);
            this.Controls.Add(this.txtContrasenia2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "VERIFICACION ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContrasenia2;
        private System.Windows.Forms.Button buttVerificar;
        private System.Windows.Forms.TextBox txtContrasenia1;
        private System.Windows.Forms.Label lblNueva_Contrasenia;
        private System.Windows.Forms.Label lblRepetir_Contraseña;
        private System.Windows.Forms.Label lblEsFuerte;
        private System.Windows.Forms.Label lblContrasenia_Aleatoria;
        private System.Windows.Forms.TextBox txtContraseña_Aleatoria;
        private System.Windows.Forms.Button buttContrasenia_Aleatoria;
    }
}

