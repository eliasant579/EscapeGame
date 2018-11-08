namespace EscapeGame
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
            this.mainOutputLabel = new System.Windows.Forms.Label();
            this.redAnswerLabel = new System.Windows.Forms.Label();
            this.blueAnswerLabel = new System.Windows.Forms.Label();
            this.yellowAnswerLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.yellowLabel = new System.Windows.Forms.Label();
            this.keysTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainOutputLabel
            // 
            this.mainOutputLabel.AutoSize = true;
            this.mainOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainOutputLabel.Location = new System.Drawing.Point(49, 23);
            this.mainOutputLabel.Name = "mainOutputLabel";
            this.mainOutputLabel.Size = new System.Drawing.Size(727, 72);
            this.mainOutputLabel.TabIndex = 0;
            this.mainOutputLabel.Text = "You are in jail. \r\nIt\'s nightime and you\' ve just waken up in pain because someth" +
    "ing was thrown at you. \r\nDo you shout angrily to the other prisoners?";
            // 
            // redAnswerLabel
            // 
            this.redAnswerLabel.AutoSize = true;
            this.redAnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redAnswerLabel.Location = new System.Drawing.Point(120, 143);
            this.redAnswerLabel.Name = "redAnswerLabel";
            this.redAnswerLabel.Size = new System.Drawing.Size(37, 20);
            this.redAnswerLabel.TabIndex = 1;
            this.redAnswerLabel.Text = "Yes";
            // 
            // blueAnswerLabel
            // 
            this.blueAnswerLabel.AutoSize = true;
            this.blueAnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueAnswerLabel.Location = new System.Drawing.Point(120, 223);
            this.blueAnswerLabel.Name = "blueAnswerLabel";
            this.blueAnswerLabel.Size = new System.Drawing.Size(30, 20);
            this.blueAnswerLabel.TabIndex = 2;
            this.blueAnswerLabel.Text = "No";
            // 
            // yellowAnswerLabel
            // 
            this.yellowAnswerLabel.AutoSize = true;
            this.yellowAnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowAnswerLabel.Location = new System.Drawing.Point(120, 183);
            this.yellowAnswerLabel.Name = "yellowAnswerLabel";
            this.yellowAnswerLabel.Size = new System.Drawing.Size(0, 20);
            this.yellowAnswerLabel.TabIndex = 3;
            // 
            // redLabel
            // 
            this.redLabel.BackColor = System.Drawing.Color.Red;
            this.redLabel.Location = new System.Drawing.Point(50, 140);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(64, 23);
            this.redLabel.TabIndex = 4;
            // 
            // blueLabel
            // 
            this.blueLabel.BackColor = System.Drawing.Color.Blue;
            this.blueLabel.Location = new System.Drawing.Point(50, 220);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(64, 23);
            this.blueLabel.TabIndex = 5;
            // 
            // yellowLabel
            // 
            this.yellowLabel.BackColor = System.Drawing.Color.Gold;
            this.yellowLabel.Location = new System.Drawing.Point(50, 180);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(64, 23);
            this.yellowLabel.TabIndex = 6;
            this.yellowLabel.Visible = false;
            // 
            // keysTextBox
            // 
            this.keysTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keysTextBox.Location = new System.Drawing.Point(53, 103);
            this.keysTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.keysTextBox.Name = "keysTextBox";
            this.keysTextBox.Size = new System.Drawing.Size(132, 27);
            this.keysTextBox.TabIndex = 7;
            this.keysTextBox.Visible = false;
            this.keysTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keysTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImage = global::EscapeGame.Properties.Resources.P_Bed;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Location = new System.Drawing.Point(240, 130);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(550, 300);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keysTextBox);
            this.Controls.Add(this.yellowLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.yellowAnswerLabel);
            this.Controls.Add(this.blueAnswerLabel);
            this.Controls.Add(this.redAnswerLabel);
            this.Controls.Add(this.mainOutputLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Escaping from prison";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainOutputLabel;
        private System.Windows.Forms.Label redAnswerLabel;
        private System.Windows.Forms.Label blueAnswerLabel;
        private System.Windows.Forms.Label yellowAnswerLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label yellowLabel;
        private System.Windows.Forms.TextBox keysTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

