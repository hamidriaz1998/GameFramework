namespace GravityGame
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
            this.GameLoop = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.BlueLabel = new System.Windows.Forms.Label();
            this.BlueHealth = new System.Windows.Forms.ProgressBar();
            this.GreenLabel = new System.Windows.Forms.Label();
            this.GreenHealth = new System.Windows.Forms.ProgressBar();
            this.RedLabel = new System.Windows.Forms.Label();
            this.RedHealth = new System.Windows.Forms.ProgressBar();
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.PlayerHealth = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameLoop
            // 
            this.GameLoop.Enabled = true;
            this.GameLoop.Interval = 10;
            this.GameLoop.Tick += new System.EventHandler(this.GameLoop_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.BlueLabel);
            this.panel1.Controls.Add(this.BlueHealth);
            this.panel1.Controls.Add(this.GreenLabel);
            this.panel1.Controls.Add(this.GreenHealth);
            this.panel1.Controls.Add(this.RedLabel);
            this.panel1.Controls.Add(this.RedHealth);
            this.panel1.Controls.Add(this.PlayerLabel);
            this.panel1.Controls.Add(this.PlayerHealth);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 59);
            this.panel1.TabIndex = 0;
            // 
            // BlueLabel
            // 
            this.BlueLabel.AutoSize = true;
            this.BlueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlueLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BlueLabel.Location = new System.Drawing.Point(634, 22);
            this.BlueLabel.Name = "BlueLabel";
            this.BlueLabel.Size = new System.Drawing.Size(41, 18);
            this.BlueLabel.TabIndex = 7;
            this.BlueLabel.Text = "Blue";
            // 
            // BlueHealth
            // 
            this.BlueHealth.Location = new System.Drawing.Point(695, 22);
            this.BlueHealth.Name = "BlueHealth";
            this.BlueHealth.Size = new System.Drawing.Size(100, 23);
            this.BlueHealth.TabIndex = 6;
            // 
            // GreenLabel
            // 
            this.GreenLabel.AutoSize = true;
            this.GreenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GreenLabel.Location = new System.Drawing.Point(413, 22);
            this.GreenLabel.Name = "GreenLabel";
            this.GreenLabel.Size = new System.Drawing.Size(59, 18);
            this.GreenLabel.TabIndex = 5;
            this.GreenLabel.Text = " Green";
            // 
            // GreenHealth
            // 
            this.GreenHealth.Location = new System.Drawing.Point(474, 22);
            this.GreenHealth.Name = "GreenHealth";
            this.GreenHealth.Size = new System.Drawing.Size(100, 23);
            this.GreenHealth.TabIndex = 4;
            // 
            // RedLabel
            // 
            this.RedLabel.AutoSize = true;
            this.RedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RedLabel.Location = new System.Drawing.Point(220, 22);
            this.RedLabel.Name = "RedLabel";
            this.RedLabel.Size = new System.Drawing.Size(43, 18);
            this.RedLabel.TabIndex = 3;
            this.RedLabel.Text = " Red";
            // 
            // RedHealth
            // 
            this.RedHealth.Location = new System.Drawing.Point(281, 22);
            this.RedHealth.Name = "RedHealth";
            this.RedHealth.Size = new System.Drawing.Size(100, 23);
            this.RedHealth.TabIndex = 2;
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.AutoSize = true;
            this.PlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PlayerLabel.Location = new System.Drawing.Point(12, 22);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(55, 18);
            this.PlayerLabel.TabIndex = 1;
            this.PlayerLabel.Text = "Player";
            // 
            // PlayerHealth
            // 
            this.PlayerHealth.Location = new System.Drawing.Point(73, 22);
            this.PlayerHealth.Name = "PlayerHealth";
            this.PlayerHealth.Size = new System.Drawing.Size(100, 23);
            this.PlayerHealth.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 524);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer GameLoop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.ProgressBar PlayerHealth;
        private System.Windows.Forms.Label BlueLabel;
        private System.Windows.Forms.ProgressBar BlueHealth;
        private System.Windows.Forms.Label GreenLabel;
        private System.Windows.Forms.ProgressBar GreenHealth;
        private System.Windows.Forms.Label RedLabel;
        private System.Windows.Forms.ProgressBar RedHealth;
    }
}

