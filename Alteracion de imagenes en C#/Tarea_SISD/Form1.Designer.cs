
namespace Tarea_SISD
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb = new System.Windows.Forms.PictureBox();
            this.pbblanconegro = new System.Windows.Forms.PictureBox();
            this.btnabrir = new System.Windows.Forms.Button();
            this.btnconvbl = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progres = new System.Windows.Forms.ProgressBar();
            this.btnguardarbl = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnconvresol = new System.Windows.Forms.Button();
            this.pb_resol = new System.Windows.Forms.PictureBox();
            this.btnguardares = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbblanconegro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resol)).BeginInit();
            this.SuspendLayout();
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(12, 133);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(423, 401);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb.TabIndex = 0;
            this.pb.TabStop = false;
            // 
            // pbblanconegro
            // 
            this.pbblanconegro.Location = new System.Drawing.Point(479, 133);
            this.pbblanconegro.Name = "pbblanconegro";
            this.pbblanconegro.Size = new System.Drawing.Size(423, 397);
            this.pbblanconegro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbblanconegro.TabIndex = 1;
            this.pbblanconegro.TabStop = false;
            // 
            // btnabrir
            // 
            this.btnabrir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnabrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnabrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnabrir.ForeColor = System.Drawing.Color.White;
            this.btnabrir.Location = new System.Drawing.Point(12, 44);
            this.btnabrir.Name = "btnabrir";
            this.btnabrir.Size = new System.Drawing.Size(423, 68);
            this.btnabrir.TabIndex = 2;
            this.btnabrir.Text = "Buscar imagen";
            this.btnabrir.UseVisualStyleBackColor = true;
            // 
            // btnconvbl
            // 
            this.btnconvbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconvbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnconvbl.ForeColor = System.Drawing.Color.White;
            this.btnconvbl.Location = new System.Drawing.Point(479, 44);
            this.btnconvbl.Name = "btnconvbl";
            this.btnconvbl.Size = new System.Drawing.Size(423, 68);
            this.btnconvbl.TabIndex = 3;
            this.btnconvbl.Text = "Convertir imagen (B y N)";
            this.btnconvbl.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(457, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 480);
            this.panel1.TabIndex = 4;
            // 
            // progres
            // 
            this.progres.Dock = System.Windows.Forms.DockStyle.Top;
            this.progres.Location = new System.Drawing.Point(0, 0);
            this.progres.Name = "progres";
            this.progres.Size = new System.Drawing.Size(1402, 10);
            this.progres.TabIndex = 5;
            // 
            // btnguardarbl
            // 
            this.btnguardarbl.BackColor = System.Drawing.Color.DimGray;
            this.btnguardarbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardarbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnguardarbl.ForeColor = System.Drawing.Color.White;
            this.btnguardarbl.Location = new System.Drawing.Point(12, 542);
            this.btnguardarbl.Name = "btnguardarbl";
            this.btnguardarbl.Size = new System.Drawing.Size(579, 68);
            this.btnguardarbl.TabIndex = 6;
            this.btnguardarbl.Text = "Guardar blanco y negro";
            this.btnguardarbl.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(927, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 480);
            this.panel2.TabIndex = 9;
            // 
            // btnconvresol
            // 
            this.btnconvresol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconvresol.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnconvresol.ForeColor = System.Drawing.Color.White;
            this.btnconvresol.Location = new System.Drawing.Point(947, 44);
            this.btnconvresol.Name = "btnconvresol";
            this.btnconvresol.Size = new System.Drawing.Size(423, 68);
            this.btnconvresol.TabIndex = 8;
            this.btnconvresol.Text = "Aumentar pixels";
            this.btnconvresol.UseVisualStyleBackColor = true;
            // 
            // pb_resol
            // 
            this.pb_resol.Location = new System.Drawing.Point(947, 133);
            this.pb_resol.Name = "pb_resol";
            this.pb_resol.Size = new System.Drawing.Size(423, 397);
            this.pb_resol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_resol.TabIndex = 7;
            this.pb_resol.TabStop = false;
            // 
            // btnguardares
            // 
            this.btnguardares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardares.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnguardares.ForeColor = System.Drawing.Color.White;
            this.btnguardares.Location = new System.Drawing.Point(650, 542);
            this.btnguardares.Name = "btnguardares";
            this.btnguardares.Size = new System.Drawing.Size(720, 68);
            this.btnguardares.TabIndex = 10;
            this.btnguardares.Text = "Guardar imagen (mayor resolucion)";
            this.btnguardares.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1402, 622);
            this.Controls.Add(this.btnguardares);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnconvresol);
            this.Controls.Add(this.pb_resol);
            this.Controls.Add(this.btnguardarbl);
            this.Controls.Add(this.progres);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnconvbl);
            this.Controls.Add(this.btnabrir);
            this.Controls.Add(this.pbblanconegro);
            this.Controls.Add(this.pb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto Grupal";
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbblanconegro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resol)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TextBox txtexpr;
        private System.Windows.Forms.Label lbresultado;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.PictureBox pbblanconegro;
        private System.Windows.Forms.Button btnabrir;
        private System.Windows.Forms.Button btnconvbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progres;
        private System.Windows.Forms.Button btnguardarbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnconvresol;
        private System.Windows.Forms.PictureBox pb_resol;
        private System.Windows.Forms.Button btnguardares;
    }
}