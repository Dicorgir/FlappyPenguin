using System;

namespace FlappyPenguin
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TuboArriba = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.TuboAbajo = new System.Windows.Forms.PictureBox();
            this.Barrera = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.Puntaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TuboArriba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TuboAbajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barrera)).BeginInit();
            this.SuspendLayout();
            // 
            // TuboArriba
            // 
            this.TuboArriba.BackColor = System.Drawing.Color.Transparent;
            this.TuboArriba.Image = global::FlappyPenguin.Properties.Resources.tuberia21;
            this.TuboArriba.Location = new System.Drawing.Point(143, -98);
            this.TuboArriba.Name = "TuboArriba";
            this.TuboArriba.Size = new System.Drawing.Size(111, 400);
            this.TuboArriba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TuboArriba.TabIndex = 0;
            this.TuboArriba.TabStop = false;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::FlappyPenguin.Properties.Resources.pinguino1;
            this.Player.Location = new System.Drawing.Point(43, 226);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(83, 76);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 1;
            this.Player.TabStop = false;
            // 
            // TuboAbajo
            // 
            this.TuboAbajo.BackColor = System.Drawing.Color.Transparent;
            this.TuboAbajo.Image = global::FlappyPenguin.Properties.Resources.tuberia3;
            this.TuboAbajo.Location = new System.Drawing.Point(143, 359);
            this.TuboAbajo.Name = "TuboAbajo";
            this.TuboAbajo.Size = new System.Drawing.Size(111, 237);
            this.TuboAbajo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TuboAbajo.TabIndex = 2;
            this.TuboAbajo.TabStop = false;
            // 
            // Barrera
            // 
            this.Barrera.Image = global::FlappyPenguin.Properties.Resources.franja;
            this.Barrera.Location = new System.Drawing.Point(-27, 420);
            this.Barrera.Name = "Barrera";
            this.Barrera.Size = new System.Drawing.Size(1616, 33);
            this.Barrera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Barrera.TabIndex = 3;
            this.Barrera.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Puntaje
            // 
            this.Puntaje.AutoSize = true;
            this.Puntaje.Location = new System.Drawing.Point(76, 207);
            this.Puntaje.Name = "Puntaje";
            this.Puntaje.Size = new System.Drawing.Size(14, 16);
            this.Puntaje.TabIndex = 4;
            this.Puntaje.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(307, 456);
            this.Controls.Add(this.Puntaje);
            this.Controls.Add(this.TuboAbajo);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.TuboArriba);
            this.Controls.Add(this.Barrera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Flappy Penguin";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.TuboArriba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TuboAbajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barrera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TuboArriba;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox TuboAbajo;
        private System.Windows.Forms.PictureBox Barrera;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label Puntaje;
    }
}

