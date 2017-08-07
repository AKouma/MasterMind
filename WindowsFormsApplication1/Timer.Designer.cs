namespace WindowsFormsApplication1
{
    partial class Timer
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
            this.Debutant = new System.Windows.Forms.Label();
            this.intermediaire = new System.Windows.Forms.Label();
            this.Master = new System.Windows.Forms.Label();
            this.min10 = new System.Windows.Forms.RadioButton();
            this.min1 = new System.Windows.Forms.RadioButton();
            this.min5 = new System.Windows.Forms.RadioButton();
            this.Valider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "MODE  TIMER";
            // 
            // Debutant
            // 
            this.Debutant.AutoSize = true;
            this.Debutant.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Debutant.ForeColor = System.Drawing.Color.White;
            this.Debutant.Location = new System.Drawing.Point(12, 85);
            this.Debutant.Name = "Debutant";
            this.Debutant.Size = new System.Drawing.Size(148, 24);
            this.Debutant.TabIndex = 2;
            this.Debutant.Text = "DEBUTANT    ";
            // 
            // intermediaire
            // 
            this.intermediaire.AutoSize = true;
            this.intermediaire.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intermediaire.ForeColor = System.Drawing.Color.Blue;
            this.intermediaire.Location = new System.Drawing.Point(12, 128);
            this.intermediaire.Name = "intermediaire";
            this.intermediaire.Size = new System.Drawing.Size(175, 24);
            this.intermediaire.TabIndex = 3;
            this.intermediaire.Text = "INTERMEDIAIRE";
            // 
            // Master
            // 
            this.Master.AutoSize = true;
            this.Master.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Master.ForeColor = System.Drawing.Color.Red;
            this.Master.Location = new System.Drawing.Point(12, 170);
            this.Master.Name = "Master";
            this.Master.Size = new System.Drawing.Size(97, 24);
            this.Master.TabIndex = 4;
            this.Master.Text = "MASTER";
            this.Master.Click += new System.EventHandler(this.label4_Click);
            // 
            // min10
            // 
            this.min10.AutoSize = true;
            this.min10.Location = new System.Drawing.Point(210, 85);
            this.min10.Name = "min10";
            this.min10.Size = new System.Drawing.Size(60, 17);
            this.min10.TabIndex = 5;
            this.min10.TabStop = true;
            this.min10.Text = "10 MIN";
            this.min10.UseVisualStyleBackColor = true;
            // 
            // min1
            // 
            this.min1.AutoSize = true;
            this.min1.Location = new System.Drawing.Point(210, 170);
            this.min1.Name = "min1";
            this.min1.Size = new System.Drawing.Size(54, 17);
            this.min1.TabIndex = 6;
            this.min1.TabStop = true;
            this.min1.Text = "1 MIN";
            this.min1.UseVisualStyleBackColor = true;
            // 
            // min5
            // 
            this.min5.AutoSize = true;
            this.min5.Location = new System.Drawing.Point(210, 128);
            this.min5.Name = "min5";
            this.min5.Size = new System.Drawing.Size(54, 17);
            this.min5.TabIndex = 7;
            this.min5.TabStop = true;
            this.min5.Text = "5 MIN";
            this.min5.UseVisualStyleBackColor = true;
            // 
            // Valider
            // 
            this.Valider.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Valider.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Valider.Location = new System.Drawing.Point(140, 222);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(122, 27);
            this.Valider.TabIndex = 8;
            this.Valider.Text = "VALIDER";
            this.Valider.UseVisualStyleBackColor = false;
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._8119_l;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.min5);
            this.Controls.Add(this.min1);
            this.Controls.Add(this.min10);
            this.Controls.Add(this.Master);
            this.Controls.Add(this.intermediaire);
            this.Controls.Add(this.Debutant);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Timer";
            this.Text = "Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Debutant;
        private System.Windows.Forms.Label intermediaire;
        private System.Windows.Forms.Label Master;
        private System.Windows.Forms.RadioButton min10;
        private System.Windows.Forms.RadioButton min1;
        private System.Windows.Forms.RadioButton min5;
        private System.Windows.Forms.Button Valider;
    }
}