namespace Ping_pong
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
            this.components = new System.ComponentModel.Container();
            this.titulo = new System.Windows.Forms.Label();
            this.label_titulo = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.barra_izquierda = new System.Windows.Forms.Panel();
            this.barra_derecha = new System.Windows.Forms.Panel();
            this.ball = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.Location = new System.Drawing.Point(190, 120);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(36, 13);
            this.titulo.TabIndex = 0;
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Location = new System.Drawing.Point(381, 114);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(33, 13);
            this.label_titulo.TabIndex = 0;
            this.label_titulo.Text = "Titulo";
            // 
            // barra_izquierda
            // 
            this.barra_izquierda.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.barra_izquierda.Location = new System.Drawing.Point(41, 74);
            this.barra_izquierda.Name = "barra_izquierda";
            this.barra_izquierda.Size = new System.Drawing.Size(30, 150);
            this.barra_izquierda.TabIndex = 3;
            // 
            // barra_derecha
            // 
            this.barra_derecha.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.barra_derecha.Location = new System.Drawing.Point(710, 74);
            this.barra_derecha.Name = "barra_derecha";
            this.barra_derecha.Size = new System.Drawing.Size(30, 150);
            this.barra_derecha.TabIndex = 4;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ball.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ball.Location = new System.Drawing.Point(367, 152);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(20, 20);
            this.ball.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.barra_derecha);
            this.Controls.Add(this.barra_izquierda);
            this.Controls.Add(this.label_titulo);
            this.Name = "Form1";
            this.Text = "Ping Pong";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel barra_izquierda;
        private System.Windows.Forms.Panel barra_derecha;
        private System.Windows.Forms.Panel ball;
    }
}

