namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.opcion1 = new System.Windows.Forms.Button();
            this.opcion2 = new System.Windows.Forms.Button();
            this.opcion3 = new System.Windows.Forms.Button();
            this.opcion4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numeroVidasRestantes = new System.Windows.Forms.Label();
            this.puntaje = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // opcion1
            // 
            this.opcion1.BackColor = System.Drawing.Color.HotPink;
            this.opcion1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.opcion1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcion1.Location = new System.Drawing.Point(10, 328);
            this.opcion1.Name = "opcion1";
            this.opcion1.Size = new System.Drawing.Size(155, 79);
            this.opcion1.TabIndex = 1;
            this.opcion1.Text = "button1";
            this.opcion1.UseVisualStyleBackColor = false;
            this.opcion1.Click += new System.EventHandler(this.button1_Click);
            // 
            // opcion2
            // 
            this.opcion2.BackColor = System.Drawing.Color.MediumOrchid;
            this.opcion2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.opcion2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcion2.Location = new System.Drawing.Point(171, 328);
            this.opcion2.Name = "opcion2";
            this.opcion2.Size = new System.Drawing.Size(158, 79);
            this.opcion2.TabIndex = 2;
            this.opcion2.Text = "button2";
            this.opcion2.UseVisualStyleBackColor = false;
            this.opcion2.Click += new System.EventHandler(this.opcion2_Click);
            // 
            // opcion3
            // 
            this.opcion3.BackColor = System.Drawing.Color.Orange;
            this.opcion3.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.opcion3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcion3.Location = new System.Drawing.Point(335, 328);
            this.opcion3.Name = "opcion3";
            this.opcion3.Size = new System.Drawing.Size(155, 79);
            this.opcion3.TabIndex = 3;
            this.opcion3.Text = "button3";
            this.opcion3.UseVisualStyleBackColor = false;
            this.opcion3.Click += new System.EventHandler(this.opcion3_Click);
            // 
            // opcion4
            // 
            this.opcion4.BackColor = System.Drawing.Color.DodgerBlue;
            this.opcion4.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.opcion4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcion4.Location = new System.Drawing.Point(496, 328);
            this.opcion4.Name = "opcion4";
            this.opcion4.Size = new System.Drawing.Size(158, 79);
            this.opcion4.TabIndex = 4;
            this.opcion4.Text = "button4";
            this.opcion4.UseVisualStyleBackColor = false;
            this.opcion4.Click += new System.EventHandler(this.opcion4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(528, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vidas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "Puntaje";
            // 
            // numeroVidasRestantes
            // 
            this.numeroVidasRestantes.AutoSize = true;
            this.numeroVidasRestantes.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroVidasRestantes.Location = new System.Drawing.Point(634, 5);
            this.numeroVidasRestantes.Name = "numeroVidasRestantes";
            this.numeroVidasRestantes.Size = new System.Drawing.Size(26, 29);
            this.numeroVidasRestantes.TabIndex = 7;
            this.numeroVidasRestantes.Text = "3";
            // 
            // puntaje
            // 
            this.puntaje.AutoSize = true;
            this.puntaje.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntaje.Location = new System.Drawing.Point(321, 9);
            this.puntaje.Name = "puntaje";
            this.puntaje.Size = new System.Drawing.Size(26, 29);
            this.puntaje.TabIndex = 8;
            this.puntaje.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(171, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 240);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources.regresar;
            this.button1.Location = new System.Drawing.Point(-2, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 39);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 419);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.puntaje);
            this.Controls.Add(this.numeroVidasRestantes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.opcion4);
            this.Controls.Add(this.opcion3);
            this.Controls.Add(this.opcion2);
            this.Controls.Add(this.opcion1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "NIVEL 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button opcion1;
        private System.Windows.Forms.Button opcion2;
        private System.Windows.Forms.Button opcion3;
        private System.Windows.Forms.Button opcion4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numeroVidasRestantes;
        private System.Windows.Forms.Label puntaje;
        private System.Windows.Forms.Button button1;
    }
}

