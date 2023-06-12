namespace WindowsFormsApp1
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.opcion1 = new System.Windows.Forms.Button();
            this.opcion2 = new System.Windows.Forms.Button();
            this.opcion3 = new System.Windows.Forms.Button();
            this.opcion4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.puntaje = new System.Windows.Forms.Label();
            this.numeroVidasRestantes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(158, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 195);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // opcion1
            // 
            this.opcion1.Location = new System.Drawing.Point(111, 346);
            this.opcion1.Name = "opcion1";
            this.opcion1.Size = new System.Drawing.Size(57, 31);
            this.opcion1.TabIndex = 1;
            this.opcion1.Text = "button1";
            this.opcion1.UseVisualStyleBackColor = true;
            // 
            // opcion2
            // 
            this.opcion2.Location = new System.Drawing.Point(229, 346);
            this.opcion2.Name = "opcion2";
            this.opcion2.Size = new System.Drawing.Size(57, 31);
            this.opcion2.TabIndex = 2;
            this.opcion2.Text = "button2";
            this.opcion2.UseVisualStyleBackColor = true;
            // 
            // opcion3
            // 
            this.opcion3.Location = new System.Drawing.Point(363, 330);
            this.opcion3.Name = "opcion3";
            this.opcion3.Size = new System.Drawing.Size(57, 31);
            this.opcion3.TabIndex = 3;
            this.opcion3.Text = "button3";
            this.opcion3.UseVisualStyleBackColor = true;
            // 
            // opcion4
            // 
            this.opcion4.Location = new System.Drawing.Point(524, 346);
            this.opcion4.Name = "opcion4";
            this.opcion4.Size = new System.Drawing.Size(57, 31);
            this.opcion4.TabIndex = 4;
            this.opcion4.Text = "button4";
            this.opcion4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // puntaje
            // 
            this.puntaje.AutoSize = true;
            this.puntaje.Location = new System.Drawing.Point(503, 134);
            this.puntaje.Name = "puntaje";
            this.puntaje.Size = new System.Drawing.Size(13, 13);
            this.puntaje.TabIndex = 7;
            this.puntaje.Text = "0";
            // 
            // numeroVidasRestantes
            // 
            this.numeroVidasRestantes.AutoSize = true;
            this.numeroVidasRestantes.Location = new System.Drawing.Point(521, 203);
            this.numeroVidasRestantes.Name = "numeroVidasRestantes";
            this.numeroVidasRestantes.Size = new System.Drawing.Size(13, 13);
            this.numeroVidasRestantes.TabIndex = 8;
            this.numeroVidasRestantes.Text = "3";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 419);
            this.Controls.Add(this.numeroVidasRestantes);
            this.Controls.Add(this.puntaje);
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
            this.Name = "Form4";
            this.Text = "NIVEL 2";
            this.Load += new System.EventHandler(this.Form4_Load);
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
        private System.Windows.Forms.Label puntaje;
        private System.Windows.Forms.Label numeroVidasRestantes;
    }
}