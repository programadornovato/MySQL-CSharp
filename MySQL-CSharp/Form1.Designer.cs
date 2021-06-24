
namespace MySQL_CSharp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblResultado = new System.Windows.Forms.Label();
            this.dgTrabajadores = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBusNombre = new System.Windows.Forms.TextBox();
            this.txtBusPuesto = new System.Windows.Forms.TextBox();
            this.txtBusEdad = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInNombre = new System.Windows.Forms.TextBox();
            this.txtInPuesto = new System.Windows.Forms.TextBox();
            this.txtInEdad = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTrabajadores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(348, 598);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(206, 25);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "Estado de la conexion";
            // 
            // dgTrabajadores
            // 
            this.dgTrabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTrabajadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nombre,
            this.puesto,
            this.Edad});
            this.dgTrabajadores.Location = new System.Drawing.Point(45, 338);
            this.dgTrabajadores.Name = "dgTrabajadores";
            this.dgTrabajadores.RowTemplate.Height = 25;
            this.dgTrabajadores.Size = new System.Drawing.Size(509, 243);
            this.dgTrabajadores.TabIndex = 2;
            this.dgTrabajadores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTrabajadores_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "nombre";
            this.Nombre.Name = "Nombre";
            // 
            // puesto
            // 
            this.puesto.HeaderText = "Puesto";
            this.puesto.Name = "puesto";
            // 
            // Edad
            // 
            this.Edad.HeaderText = "edad";
            this.Edad.Name = "Edad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Puesto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Edad";
            // 
            // txtBusNombre
            // 
            this.txtBusNombre.Location = new System.Drawing.Point(45, 296);
            this.txtBusNombre.Name = "txtBusNombre";
            this.txtBusNombre.Size = new System.Drawing.Size(100, 33);
            this.txtBusNombre.TabIndex = 4;
            // 
            // txtBusPuesto
            // 
            this.txtBusPuesto.Location = new System.Drawing.Point(170, 296);
            this.txtBusPuesto.Name = "txtBusPuesto";
            this.txtBusPuesto.Size = new System.Drawing.Size(100, 33);
            this.txtBusPuesto.TabIndex = 4;
            // 
            // txtBusEdad
            // 
            this.txtBusEdad.Location = new System.Drawing.Point(300, 296);
            this.txtBusEdad.Name = "txtBusEdad";
            this.txtBusEdad.Size = new System.Drawing.Size(100, 33);
            this.txtBusEdad.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(440, 288);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 41);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Puesto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Edad";
            // 
            // txtInNombre
            // 
            this.txtInNombre.Location = new System.Drawing.Point(159, 25);
            this.txtInNombre.Name = "txtInNombre";
            this.txtInNombre.Size = new System.Drawing.Size(395, 33);
            this.txtInNombre.TabIndex = 4;
            // 
            // txtInPuesto
            // 
            this.txtInPuesto.Location = new System.Drawing.Point(159, 78);
            this.txtInPuesto.Name = "txtInPuesto";
            this.txtInPuesto.Size = new System.Drawing.Size(395, 33);
            this.txtInPuesto.TabIndex = 4;
            // 
            // txtInEdad
            // 
            this.txtInEdad.Location = new System.Drawing.Point(159, 122);
            this.txtInEdad.Name = "txtInEdad";
            this.txtInEdad.Size = new System.Drawing.Size(395, 33);
            this.txtInEdad.TabIndex = 4;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(457, 183);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(97, 43);
            this.btnInsertar.TabIndex = 6;
            this.btnInsertar.Text = "Guardar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(300, 183);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 43);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 655);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtInEdad);
            this.Controls.Add(this.txtInPuesto);
            this.Controls.Add(this.txtBusEdad);
            this.Controls.Add(this.txtInNombre);
            this.Controls.Add(this.txtBusPuesto);
            this.Controls.Add(this.txtBusNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgTrabajadores);
            this.Controls.Add(this.lblResultado);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgTrabajadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.DataGridView dgTrabajadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn puesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBusNombre;
        private System.Windows.Forms.TextBox txtBusPuesto;
        private System.Windows.Forms.TextBox txtBusEdad;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInNombre;
        private System.Windows.Forms.TextBox txtInPuesto;
        private System.Windows.Forms.TextBox txtInEdad;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEditar;
    }
}

