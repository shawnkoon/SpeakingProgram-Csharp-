namespace speakingProgram
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
            this.inputBox = new System.Windows.Forms.TextBox();
            this.speakButton = new System.Windows.Forms.Button();
            this.volumeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rateBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBox.Location = new System.Drawing.Point(50, 12);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputBox.Size = new System.Drawing.Size(367, 103);
            this.inputBox.TabIndex = 0;
            // 
            // speakButton
            // 
            this.speakButton.BackColor = System.Drawing.Color.DarkOrange;
            this.speakButton.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speakButton.ForeColor = System.Drawing.Color.FloralWhite;
            this.speakButton.Location = new System.Drawing.Point(136, 166);
            this.speakButton.Name = "speakButton";
            this.speakButton.Size = new System.Drawing.Size(192, 54);
            this.speakButton.TabIndex = 1;
            this.speakButton.Text = "Speak It!";
            this.speakButton.UseVisualStyleBackColor = false;
            this.speakButton.Click += new System.EventHandler(this.speakButton_Click);
            // 
            // volumeBox
            // 
            this.volumeBox.Location = new System.Drawing.Point(148, 127);
            this.volumeBox.MaxLength = 3;
            this.volumeBox.Name = "volumeBox";
            this.volumeBox.Size = new System.Drawing.Size(27, 20);
            this.volumeBox.TabIndex = 2;
            this.volumeBox.Text = "50";
            this.volumeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.volumeBox.Leave += new System.EventHandler(this.volumeBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Volume (0 ~ 100) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Speed (-10 ~ 10) :";
            // 
            // rateBox
            // 
            this.rateBox.Location = new System.Drawing.Point(353, 127);
            this.rateBox.MaxLength = 3;
            this.rateBox.Name = "rateBox";
            this.rateBox.Size = new System.Drawing.Size(27, 20);
            this.rateBox.TabIndex = 5;
            this.rateBox.Text = "0";
            this.rateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rateBox.Leave += new System.EventHandler(this.rateBox_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(459, 232);
            this.Controls.Add(this.rateBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.volumeBox);
            this.Controls.Add(this.speakButton);
            this.Controls.Add(this.inputBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button speakButton;
        private System.Windows.Forms.TextBox volumeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rateBox;
    }
}

