namespace WindowsFormsApp1
{
    partial class juego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(juego));
            this.pac = new System.Windows.Forms.PictureBox();
            this.cherry = new System.Windows.Forms.PictureBox();
            this.verde = new System.Windows.Forms.PictureBox();
            this.fantasmarosado = new System.Windows.Forms.PictureBox();
            this.fantasmarojo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cherry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fantasmarosado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fantasmarojo)).BeginInit();
            this.SuspendLayout();
            // 
            // pac
            // 
            this.pac.Image = global::WindowsFormsApp1.Properties.Resources.pacman_right;
            this.pac.Location = new System.Drawing.Point(121, 109);
            this.pac.Name = "pac";
            this.pac.Size = new System.Drawing.Size(30, 28);
            this.pac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pac.TabIndex = 0;
            this.pac.TabStop = false;
            this.pac.Tag = "";
            this.pac.Click += new System.EventHandler(this.pac_Click);
            // 
            // cherry
            // 
            this.cherry.Image = ((System.Drawing.Image)(resources.GetObject("cherry.Image")));
            this.cherry.Location = new System.Drawing.Point(170, 177);
            this.cherry.Name = "cherry";
            this.cherry.Size = new System.Drawing.Size(27, 27);
            this.cherry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cherry.TabIndex = 1;
            this.cherry.TabStop = false;
            // 
            // verde
            // 
            this.verde.Image = ((System.Drawing.Image)(resources.GetObject("verde.Image")));
            this.verde.Location = new System.Drawing.Point(171, 38);
            this.verde.Name = "verde";
            this.verde.Size = new System.Drawing.Size(26, 27);
            this.verde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.verde.TabIndex = 2;
            this.verde.TabStop = false;
            // 
            // fantasmarosado
            // 
            this.fantasmarosado.Image = ((System.Drawing.Image)(resources.GetObject("fantasmarosado.Image")));
            this.fantasmarosado.Location = new System.Drawing.Point(247, 222);
            this.fantasmarosado.Name = "fantasmarosado";
            this.fantasmarosado.Size = new System.Drawing.Size(25, 27);
            this.fantasmarosado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fantasmarosado.TabIndex = 3;
            this.fantasmarosado.TabStop = false;
            // 
            // fantasmarojo
            // 
            this.fantasmarojo.Image = ((System.Drawing.Image)(resources.GetObject("fantasmarojo.Image")));
            this.fantasmarojo.Location = new System.Drawing.Point(22, 137);
            this.fantasmarojo.Name = "fantasmarojo";
            this.fantasmarojo.Size = new System.Drawing.Size(30, 28);
            this.fantasmarojo.TabIndex = 4;
            this.fantasmarojo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 301);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fantasmarojo);
            this.Controls.Add(this.fantasmarosado);
            this.Controls.Add(this.verde);
            this.Controls.Add(this.cherry);
            this.Controls.Add(this.pac);
            this.Name = "juego";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.juego_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cherry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fantasmarosado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fantasmarojo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pac;
        private System.Windows.Forms.PictureBox cherry;
        private System.Windows.Forms.PictureBox verde;
        private System.Windows.Forms.PictureBox fantasmarosado;
        private System.Windows.Forms.PictureBox fantasmarojo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}