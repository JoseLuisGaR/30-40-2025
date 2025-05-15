namespace _30_40_2025
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
            btnCrearFichero = new Button();
            btnCrear2 = new Button();
            bTNLeerArchivo2 = new Button();
            btnLeerArchivo1 = new Button();
            btnLeerArchivo4 = new Button();
            btnLeerArchivo3 = new Button();
            btnModificar = new Button();
            SuspendLayout();
            // 
            // btnCrearFichero
            // 
            btnCrearFichero.Location = new Point(6, 16);
            btnCrearFichero.Name = "btnCrearFichero";
            btnCrearFichero.Size = new Size(89, 47);
            btnCrearFichero.TabIndex = 0;
            btnCrearFichero.Text = "Crear Fichero";
            btnCrearFichero.UseVisualStyleBackColor = true;
            btnCrearFichero.Click += btnCrearFichero_Click;
            // 
            // btnCrear2
            // 
            btnCrear2.Location = new Point(101, 16);
            btnCrear2.Name = "btnCrear2";
            btnCrear2.Size = new Size(89, 47);
            btnCrear2.TabIndex = 1;
            btnCrear2.Text = "Forma 2 de Crear";
            btnCrear2.UseVisualStyleBackColor = true;
            btnCrear2.Click += btnCrear2_Click;
            // 
            // bTNLeerArchivo2
            // 
            bTNLeerArchivo2.Location = new Point(291, 16);
            bTNLeerArchivo2.Name = "bTNLeerArchivo2";
            bTNLeerArchivo2.Size = new Size(89, 47);
            bTNLeerArchivo2.TabIndex = 3;
            bTNLeerArchivo2.Text = "Leer Archivo";
            bTNLeerArchivo2.UseVisualStyleBackColor = true;
            bTNLeerArchivo2.Click += bTNLeerArchivo2_Click;
            // 
            // btnLeerArchivo1
            // 
            btnLeerArchivo1.Location = new Point(196, 16);
            btnLeerArchivo1.Name = "btnLeerArchivo1";
            btnLeerArchivo1.Size = new Size(89, 47);
            btnLeerArchivo1.TabIndex = 2;
            btnLeerArchivo1.Text = "Leer Archivo";
            btnLeerArchivo1.UseVisualStyleBackColor = true;
            btnLeerArchivo1.Click += btnLeerArchivo1_Click;
            // 
            // btnLeerArchivo4
            // 
            btnLeerArchivo4.Location = new Point(101, 69);
            btnLeerArchivo4.Name = "btnLeerArchivo4";
            btnLeerArchivo4.Size = new Size(89, 47);
            btnLeerArchivo4.TabIndex = 5;
            btnLeerArchivo4.Text = "Leer Archivo";
            btnLeerArchivo4.UseVisualStyleBackColor = true;
            // 
            // btnLeerArchivo3
            // 
            btnLeerArchivo3.Location = new Point(6, 69);
            btnLeerArchivo3.Name = "btnLeerArchivo3";
            btnLeerArchivo3.Size = new Size(89, 47);
            btnLeerArchivo3.TabIndex = 4;
            btnLeerArchivo3.Text = "Leer Archivo";
            btnLeerArchivo3.UseVisualStyleBackColor = true;
            btnLeerArchivo3.Click += btnLeerArchivo3_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(196, 69);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(89, 47);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModificar);
            Controls.Add(btnLeerArchivo4);
            Controls.Add(btnLeerArchivo3);
            Controls.Add(bTNLeerArchivo2);
            Controls.Add(btnLeerArchivo1);
            Controls.Add(btnCrear2);
            Controls.Add(btnCrearFichero);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCrearFichero;
        private Button btnCrear2;
        private Button bTNLeerArchivo2;
        private Button btnLeerArchivo1;
        private Button btnLeerArchivo4;
        private Button btnLeerArchivo3;
        private Button btnModificar;
    }
}
