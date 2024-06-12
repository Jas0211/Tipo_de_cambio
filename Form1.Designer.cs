namespace Tipo_de_cambio
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
            this.Txt_Colones = new System.Windows.Forms.TextBox();
            this.Lbl_Colones_1 = new System.Windows.Forms.Label();
            this.Txt_cambio_euros = new System.Windows.Forms.TextBox();
            this.Lbl_tipo_Euros = new System.Windows.Forms.Label();
            this.Txt_cambio_dolares = new System.Windows.Forms.TextBox();
            this.Lbl_tipo_Dolares = new System.Windows.Forms.Label();
            this.Cbx_Convertir = new System.Windows.Forms.ComboBox();
            this.Lbl_Convertir = new System.Windows.Forms.Label();
            this.Lbl_euros = new System.Windows.Forms.Label();
            this.Btn_euros = new System.Windows.Forms.Button();
            this.Lbl_Dolares = new System.Windows.Forms.Label();
            this.Btn_dolares = new System.Windows.Forms.Button();
            this.Lbl_Colones_2 = new System.Windows.Forms.Label();
            this.Lbl_Monto = new System.Windows.Forms.Label();
            this.Lbl_Colones_3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_Colones
            // 
            this.Txt_Colones.Location = new System.Drawing.Point(126, 357);
            this.Txt_Colones.Name = "Txt_Colones";
            this.Txt_Colones.Size = new System.Drawing.Size(100, 20);
            this.Txt_Colones.TabIndex = 5;
            this.Txt_Colones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeros_KeyPress);
            // 
            // Lbl_Colones_1
            // 
            this.Lbl_Colones_1.AutoSize = true;
            this.Lbl_Colones_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Colones_1.Location = new System.Drawing.Point(729, 83);
            this.Lbl_Colones_1.Name = "Lbl_Colones_1";
            this.Lbl_Colones_1.Size = new System.Drawing.Size(52, 13);
            this.Lbl_Colones_1.TabIndex = 4;
            this.Lbl_Colones_1.Text = "Colones";
            // 
            // Txt_cambio_euros
            // 
            this.Txt_cambio_euros.Location = new System.Drawing.Point(576, 168);
            this.Txt_cambio_euros.Name = "Txt_cambio_euros";
            this.Txt_cambio_euros.Size = new System.Drawing.Size(147, 20);
            this.Txt_cambio_euros.TabIndex = 3;
            this.Txt_cambio_euros.TextChanged += new System.EventHandler(this.Txt_cambio_euros_TextChanged);
            this.Txt_cambio_euros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeros_KeyPress);
            // 
            // Lbl_tipo_Euros
            // 
            this.Lbl_tipo_Euros.AutoSize = true;
            this.Lbl_tipo_Euros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tipo_Euros.Location = new System.Drawing.Point(429, 171);
            this.Lbl_tipo_Euros.Name = "Lbl_tipo_Euros";
            this.Lbl_tipo_Euros.Size = new System.Drawing.Size(130, 13);
            this.Lbl_tipo_Euros.TabIndex = 2;
            this.Lbl_tipo_Euros.Text = "Tipo de cambio Euros";
            // 
            // Txt_cambio_dolares
            // 
            this.Txt_cambio_dolares.Location = new System.Drawing.Point(576, 80);
            this.Txt_cambio_dolares.Name = "Txt_cambio_dolares";
            this.Txt_cambio_dolares.Size = new System.Drawing.Size(147, 20);
            this.Txt_cambio_dolares.TabIndex = 1;
            this.Txt_cambio_dolares.TextChanged += new System.EventHandler(this.Txt_cambio_dolares_TextChanged);
            this.Txt_cambio_dolares.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeros_KeyPress);
            // 
            // Lbl_tipo_Dolares
            // 
            this.Lbl_tipo_Dolares.AutoSize = true;
            this.Lbl_tipo_Dolares.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tipo_Dolares.Location = new System.Drawing.Point(429, 82);
            this.Lbl_tipo_Dolares.Name = "Lbl_tipo_Dolares";
            this.Lbl_tipo_Dolares.Size = new System.Drawing.Size(141, 13);
            this.Lbl_tipo_Dolares.TabIndex = 0;
            this.Lbl_tipo_Dolares.Text = "Tipo de cambio Dolares";
            // 
            // Cbx_Convertir
            // 
            this.Cbx_Convertir.Items.AddRange(new object[] {
            "Dolares",
            "Euros"});
            this.Cbx_Convertir.Location = new System.Drawing.Point(563, 360);
            this.Cbx_Convertir.Name = "Cbx_Convertir";
            this.Cbx_Convertir.Size = new System.Drawing.Size(121, 21);
            this.Cbx_Convertir.TabIndex = 0;
            this.Cbx_Convertir.SelectedIndexChanged += new System.EventHandler(this.Cbx_Convertir_SelectedIndexChanged);
            // 
            // Lbl_Convertir
            // 
            this.Lbl_Convertir.AutoSize = true;
            this.Lbl_Convertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Convertir.Location = new System.Drawing.Point(471, 361);
            this.Lbl_Convertir.Name = "Lbl_Convertir";
            this.Lbl_Convertir.Size = new System.Drawing.Size(86, 16);
            this.Lbl_Convertir.TabIndex = 0;
            this.Lbl_Convertir.Text = "Convertir a:";
            // 
            // Lbl_euros
            // 
            this.Lbl_euros.AutoSize = true;
            this.Lbl_euros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_euros.Location = new System.Drawing.Point(182, 54);
            this.Lbl_euros.Name = "Lbl_euros";
            this.Lbl_euros.Size = new System.Drawing.Size(44, 15);
            this.Lbl_euros.TabIndex = 3;
            this.Lbl_euros.Text = "Euros";
            // 
            // Btn_euros
            // 
            this.Btn_euros.BackgroundImage = global::Tipo_de_cambio.Properties.Resources.simbolo_euros;
            this.Btn_euros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_euros.Location = new System.Drawing.Point(185, 72);
            this.Btn_euros.Name = "Btn_euros";
            this.Btn_euros.Size = new System.Drawing.Size(96, 86);
            this.Btn_euros.TabIndex = 1;
            this.Btn_euros.UseVisualStyleBackColor = true;
            this.Btn_euros.Click += new System.EventHandler(this.Btn_euros_Click);
            // 
            // Lbl_Dolares
            // 
            this.Lbl_Dolares.AutoSize = true;
            this.Lbl_Dolares.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Dolares.Location = new System.Drawing.Point(47, 54);
            this.Lbl_Dolares.Name = "Lbl_Dolares";
            this.Lbl_Dolares.Size = new System.Drawing.Size(57, 15);
            this.Lbl_Dolares.TabIndex = 2;
            this.Lbl_Dolares.Text = "Dolares";
            // 
            // Btn_dolares
            // 
            this.Btn_dolares.BackgroundImage = global::Tipo_de_cambio.Properties.Resources.simbolo_dolares;
            this.Btn_dolares.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_dolares.Location = new System.Drawing.Point(36, 72);
            this.Btn_dolares.Name = "Btn_dolares";
            this.Btn_dolares.Size = new System.Drawing.Size(96, 86);
            this.Btn_dolares.TabIndex = 0;
            this.Btn_dolares.UseVisualStyleBackColor = true;
            this.Btn_dolares.Click += new System.EventHandler(this.Btn_dolares_Click);
            // 
            // Lbl_Colones_2
            // 
            this.Lbl_Colones_2.AutoSize = true;
            this.Lbl_Colones_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Colones_2.Location = new System.Drawing.Point(729, 175);
            this.Lbl_Colones_2.Name = "Lbl_Colones_2";
            this.Lbl_Colones_2.Size = new System.Drawing.Size(52, 13);
            this.Lbl_Colones_2.TabIndex = 6;
            this.Lbl_Colones_2.Text = "Colones";
            // 
            // Lbl_Monto
            // 
            this.Lbl_Monto.AutoSize = true;
            this.Lbl_Monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Monto.Location = new System.Drawing.Point(74, 360);
            this.Lbl_Monto.Name = "Lbl_Monto";
            this.Lbl_Monto.Size = new System.Drawing.Size(46, 13);
            this.Lbl_Monto.TabIndex = 7;
            this.Lbl_Monto.Text = "Monto:";
            // 
            // Lbl_Colones_3
            // 
            this.Lbl_Colones_3.AutoSize = true;
            this.Lbl_Colones_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Colones_3.Location = new System.Drawing.Point(232, 360);
            this.Lbl_Colones_3.Name = "Lbl_Colones_3";
            this.Lbl_Colones_3.Size = new System.Drawing.Size(52, 13);
            this.Lbl_Colones_3.TabIndex = 8;
            this.Lbl_Colones_3.Text = "Colones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 450);
            this.Controls.Add(this.Lbl_Colones_3);
            this.Controls.Add(this.Lbl_Monto);
            this.Controls.Add(this.Lbl_Colones_2);
            this.Controls.Add(this.Cbx_Convertir);
            this.Controls.Add(this.Lbl_Convertir);
            this.Controls.Add(this.Btn_dolares);
            this.Controls.Add(this.Lbl_Colones_1);
            this.Controls.Add(this.Lbl_Dolares);
            this.Controls.Add(this.Txt_cambio_euros);
            this.Controls.Add(this.Txt_Colones);
            this.Controls.Add(this.Lbl_tipo_Euros);
            this.Controls.Add(this.Txt_cambio_dolares);
            this.Controls.Add(this.Btn_euros);
            this.Controls.Add(this.Lbl_tipo_Dolares);
            this.Controls.Add(this.Lbl_euros);
            this.Name = "Form1";
            this.Text = "Sistema de Cambio de Divisas";
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       
        private System.Windows.Forms.TextBox Txt_Colones;
    
        private System.Windows.Forms.Label Lbl_tipo_Dolares;
 
        private System.Windows.Forms.Label Lbl_Colones_1;
        private System.Windows.Forms.TextBox Txt_cambio_euros;
        private System.Windows.Forms.Label Lbl_tipo_Euros;
        private System.Windows.Forms.TextBox Txt_cambio_dolares;
        private System.Windows.Forms.ComboBox Cbx_Convertir;
        private System.Windows.Forms.Label Lbl_Convertir;
        private System.Windows.Forms.Label Lbl_euros;
        private System.Windows.Forms.Button Btn_euros;
        private System.Windows.Forms.Label Lbl_Dolares;
        private System.Windows.Forms.Button Btn_dolares;
        private System.Windows.Forms.Label Lbl_Colones_2;
        private System.Windows.Forms.Label Lbl_Monto;
        private System.Windows.Forms.Label Lbl_Colones_3;
    }
}

