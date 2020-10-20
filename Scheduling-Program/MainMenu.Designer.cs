namespace Scheduling_Program
{
    partial class MainMenu
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
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.btnDaySchedule = new System.Windows.Forms.Button();
            this.btnSwingSchedule = new System.Windows.Forms.Button();
            this.btnGraveSchedule = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pctLogo
            // 
            this.pctLogo.Image = global::Scheduling_Program.Properties.Resources.Bellagio_Hotel_and_Casino_01;
            this.pctLogo.Location = new System.Drawing.Point(42, 12);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(384, 270);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // btnDaySchedule
            // 
            this.btnDaySchedule.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDaySchedule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnDaySchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaySchedule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaySchedule.ForeColor = System.Drawing.Color.White;
            this.btnDaySchedule.Location = new System.Drawing.Point(500, 12);
            this.btnDaySchedule.Name = "btnDaySchedule";
            this.btnDaySchedule.Size = new System.Drawing.Size(262, 54);
            this.btnDaySchedule.TabIndex = 1;
            this.btnDaySchedule.Text = "&Day Schedule";
            this.btnDaySchedule.UseVisualStyleBackColor = false;
            this.btnDaySchedule.Click += new System.EventHandler(this.btnDaySchedule_Click);
            // 
            // btnSwingSchedule
            // 
            this.btnSwingSchedule.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSwingSchedule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnSwingSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwingSchedule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwingSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSwingSchedule.Location = new System.Drawing.Point(500, 88);
            this.btnSwingSchedule.Name = "btnSwingSchedule";
            this.btnSwingSchedule.Size = new System.Drawing.Size(262, 54);
            this.btnSwingSchedule.TabIndex = 2;
            this.btnSwingSchedule.Text = "&Swing Schedule";
            this.btnSwingSchedule.UseVisualStyleBackColor = false;
            // 
            // btnGraveSchedule
            // 
            this.btnGraveSchedule.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGraveSchedule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnGraveSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraveSchedule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraveSchedule.ForeColor = System.Drawing.Color.White;
            this.btnGraveSchedule.Location = new System.Drawing.Point(500, 161);
            this.btnGraveSchedule.Name = "btnGraveSchedule";
            this.btnGraveSchedule.Size = new System.Drawing.Size(262, 54);
            this.btnGraveSchedule.TabIndex = 3;
            this.btnGraveSchedule.Text = "&Grave Schedule";
            this.btnGraveSchedule.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(89, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 54);
            this.button1.TabIndex = 5;
            this.button1.Text = "&Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGraveSchedule);
            this.Controls.Add(this.btnSwingSchedule);
            this.Controls.Add(this.btnDaySchedule);
            this.Controls.Add(this.pctLogo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EVS Bellagio Scheduling";
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Button btnDaySchedule;
        private System.Windows.Forms.Button btnSwingSchedule;
        private System.Windows.Forms.Button btnGraveSchedule;
        private System.Windows.Forms.Button button1;
    }
}

