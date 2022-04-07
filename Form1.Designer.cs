namespace TAPU2_Ejemplo11
{
    partial class frmEjecucion
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
            this.btnCrearControl = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCrearCajas = new System.Windows.Forms.Button();
            this.tbCantidad = new System.Windows.Forms.TrackBar();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearControl
            // 
            this.btnCrearControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearControl.Location = new System.Drawing.Point(18, 40);
            this.btnCrearControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCrearControl.Name = "btnCrearControl";
            this.btnCrearControl.Size = new System.Drawing.Size(214, 83);
            this.btnCrearControl.TabIndex = 0;
            this.btnCrearControl.Text = "Crear control";
            this.btnCrearControl.UseVisualStyleBackColor = true;
            this.btnCrearControl.Click += new System.EventHandler(this.btnCrearControl_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 245);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 98);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCrearCajas
            // 
            this.btnCrearCajas.Location = new System.Drawing.Point(22, 435);
            this.btnCrearCajas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCrearCajas.Name = "btnCrearCajas";
            this.btnCrearCajas.Size = new System.Drawing.Size(210, 98);
            this.btnCrearCajas.TabIndex = 2;
            this.btnCrearCajas.Text = "Crear cajas";
            this.btnCrearCajas.UseVisualStyleBackColor = true;
            this.btnCrearCajas.Click += new System.EventHandler(this.btnCrearCajas_Click);
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(22, 562);
            this.tbCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCantidad.Maximum = 15;
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(206, 69);
            this.tbCantidad.TabIndex = 3;
            this.tbCantidad.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbCantidad.Scroll += new System.EventHandler(this.tbCantidad_Scroll);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(238, 582);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(0, 19);
            this.lblCantidad.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(517, 266);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmEjecucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 709);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.btnCrearCajas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCrearControl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEjecucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejecucion";
            this.Load += new System.EventHandler(this.frmEjecucion_Load);
            this.DoubleClick += new System.EventHandler(this.frmEjecucion_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.tbCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearControl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCrearCajas;
        private System.Windows.Forms.TrackBar tbCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

