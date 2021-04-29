
namespace Presentacion
{
    partial class Detalle
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
            this.detPrecio = new System.Windows.Forms.TextBox();
            this.detSalir = new System.Windows.Forms.Button();
            this.detNombre = new System.Windows.Forms.TextBox();
            this.detDescripcion = new System.Windows.Forms.TextBox();
            this.detCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.Label();
            this.detMarca = new System.Windows.Forms.TextBox();
            this.detCategoria = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Precio";
            // 
            // detPrecio
            // 
            this.detPrecio.BackColor = System.Drawing.Color.LemonChiffon;
            this.detPrecio.Enabled = false;
            this.detPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detPrecio.Location = new System.Drawing.Point(136, 129);
            this.detPrecio.Name = "detPrecio";
            this.detPrecio.ReadOnly = true;
            this.detPrecio.Size = new System.Drawing.Size(98, 24);
            this.detPrecio.TabIndex = 28;
            // 
            // detSalir
            // 
            this.detSalir.Location = new System.Drawing.Point(128, 346);
            this.detSalir.Name = "detSalir";
            this.detSalir.Size = new System.Drawing.Size(80, 23);
            this.detSalir.TabIndex = 27;
            this.detSalir.Text = "SALIR";
            this.detSalir.UseVisualStyleBackColor = true;
            this.detSalir.Click += new System.EventHandler(this.detSalir_Click);
            // 
            // detNombre
            // 
            this.detNombre.BackColor = System.Drawing.Color.LemonChiffon;
            this.detNombre.Enabled = false;
            this.detNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detNombre.Location = new System.Drawing.Point(136, 89);
            this.detNombre.Name = "detNombre";
            this.detNombre.ReadOnly = true;
            this.detNombre.Size = new System.Drawing.Size(98, 22);
            this.detNombre.TabIndex = 24;
            // 
            // detDescripcion
            // 
            this.detDescripcion.BackColor = System.Drawing.Color.LemonChiffon;
            this.detDescripcion.Enabled = false;
            this.detDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detDescripcion.Location = new System.Drawing.Point(136, 171);
            this.detDescripcion.Multiline = true;
            this.detDescripcion.Name = "detDescripcion";
            this.detDescripcion.ReadOnly = true;
            this.detDescripcion.Size = new System.Drawing.Size(193, 39);
            this.detDescripcion.TabIndex = 23;
            // 
            // detCodigo
            // 
            this.detCodigo.BackColor = System.Drawing.Color.LemonChiffon;
            this.detCodigo.Enabled = false;
            this.detCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detCodigo.Location = new System.Drawing.Point(136, 36);
            this.detCodigo.Name = "detCodigo";
            this.detCodigo.ReadOnly = true;
            this.detCodigo.Size = new System.Drawing.Size(58, 24);
            this.detCodigo.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre";
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Location = new System.Drawing.Point(70, 39);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(40, 13);
            this.Codigo.TabIndex = 15;
            this.Codigo.Text = "Codigo";
            // 
            // detMarca
            // 
            this.detMarca.BackColor = System.Drawing.Color.LemonChiffon;
            this.detMarca.Enabled = false;
            this.detMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detMarca.Location = new System.Drawing.Point(136, 242);
            this.detMarca.Name = "detMarca";
            this.detMarca.ReadOnly = true;
            this.detMarca.Size = new System.Drawing.Size(98, 24);
            this.detMarca.TabIndex = 30;
            // 
            // detCategoria
            // 
            this.detCategoria.BackColor = System.Drawing.Color.LemonChiffon;
            this.detCategoria.Enabled = false;
            this.detCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detCategoria.Location = new System.Drawing.Point(136, 295);
            this.detCategoria.Name = "detCategoria";
            this.detCategoria.ReadOnly = true;
            this.detCategoria.Size = new System.Drawing.Size(98, 24);
            this.detCategoria.TabIndex = 31;
            // 
            // Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 399);
            this.Controls.Add(this.detCategoria);
            this.Controls.Add(this.detMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.detPrecio);
            this.Controls.Add(this.detSalir);
            this.Controls.Add(this.detNombre);
            this.Controls.Add(this.detDescripcion);
            this.Controls.Add(this.detCodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Codigo);
            this.Name = "Detalle";
            this.Text = "Detalle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox detPrecio;
        private System.Windows.Forms.Button detSalir;
        private System.Windows.Forms.TextBox detNombre;
        private System.Windows.Forms.TextBox detDescripcion;
        private System.Windows.Forms.TextBox detCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.TextBox detMarca;
        private System.Windows.Forms.TextBox detCategoria;
    }
}