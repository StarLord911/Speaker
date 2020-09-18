namespace Windows
{
    partial class Options
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
            this.Down = new System.Windows.Forms.Button();
            this.Up = new System.Windows.Forms.Button();
            this.speedSpeak = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Скорость озвучки";
            // 
            // Down
            // 
            this.Down.Location = new System.Drawing.Point(116, 50);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(22, 23);
            this.Down.TabIndex = 1;
            this.Down.Text = "-";
            this.Down.UseVisualStyleBackColor = true;
            // 
            // Up
            // 
            this.Up.Location = new System.Drawing.Point(187, 50);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(21, 23);
            this.Up.TabIndex = 2;
            this.Up.Text = "+";
            this.Up.UseVisualStyleBackColor = true;
            // 
            // speedSpeak
            // 
            this.speedSpeak.AutoSize = true;
            this.speedSpeak.Location = new System.Drawing.Point(144, 55);
            this.speedSpeak.Name = "speedSpeak";
            this.speedSpeak.Size = new System.Drawing.Size(35, 13);
            this.speedSpeak.TabIndex = 3;
            this.speedSpeak.Text = "label2";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 418);
            this.Controls.Add(this.speedSpeak);
            this.Controls.Add(this.Up);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(428, 456);
            this.MinimumSize = new System.Drawing.Size(428, 456);
            this.Name = "Options";
            this.Text = "Настроики";
    
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Label speedSpeak;
    }
}