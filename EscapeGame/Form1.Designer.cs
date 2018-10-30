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
            this.SuspendLayout();
            // 
            // mainOutputLabel
            // 
            this.mainOutputLabel.AutoSize = true;
            this.mainOutputLabel.Location = new System.Drawing.Point(41, 22);
            this.mainOutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mainOutputLabel.Name = "mainOutputLabel";
            this.mainOutputLabel.Size = new System.Drawing.Size(401, 39);
            this.mainOutputLabel.TabIndex = 0;
            this.mainOutputLabel.Text = "You are in jail. \r\nIt\'s nightime and you\' ve just wake up in pain because sometin" +
    "g was thrown at you. \r\nDo you shout angrily to the other prisoners?";
            // 
            // redAnswerLabel
            // 
            this.redAnswerLabel.AutoSize = true;
            this.redAnswerLabel.Location = new System.Drawing.Point(94, 134);
            this.redAnswerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.redAnswerLabel.Name = "redAnswerLabel";
            this.redAnswerLabel.Size = new System.Drawing.Size(25, 13);
            this.redAnswerLabel.TabIndex = 1;
            this.redAnswerLabel.Text = "Yes";
            // 
            // blueAnswerLabel
            // 
            this.blueAnswerLabel.AutoSize = true;
            this.blueAnswerLabel.Location = new System.Drawing.Point(94, 184);
            this.blueAnswerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.blueAnswerLabel.Name = "blueAnswerLabel";
            this.blueAnswerLabel.Size = new System.Drawing.Size(21, 13);
            this.blueAnswerLabel.TabIndex = 2;
            this.blueAnswerLabel.Text = "No";
            // 
            // yellowAnswerLabel
            // 
            this.yellowAnswerLabel.AutoSize = true;
            this.yellowAnswerLabel.Location = new System.Drawing.Point(96, 229);
            this.yellowAnswerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yellowAnswerLabel.Name = "yellowAnswerLabel";
            this.yellowAnswerLabel.Size = new System.Drawing.Size(0, 13);
            this.yellowAnswerLabel.TabIndex = 3;
            // 
            // redLabel
            // 
            this.redLabel.BackColor = System.Drawing.Color.Red;
            this.redLabel.Location = new System.Drawing.Point(41, 129);
            this.redLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(48, 19);
            this.redLabel.TabIndex = 4;
            // 
            // blueLabel
            // 
            this.blueLabel.BackColor = System.Drawing.Color.Blue;
            this.blueLabel.Location = new System.Drawing.Point(41, 180);
            this.blueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(48, 19);
            this.blueLabel.TabIndex = 5;
            // 
            // yellowLabel
            // 
            this.yellowLabel.BackColor = System.Drawing.Color.Gold;
            this.yellowLabel.Location = new System.Drawing.Point(41, 224);
            this.yellowLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(48, 19);
            this.yellowLabel.TabIndex = 6;
            // 
            // keysTextBox
            // 
            this.keysTextBox.Location = new System.Drawing.Point(342, 77);
            this.keysTextBox.Name = "keysTextBox";
            this.keysTextBox.Size = new System.Drawing.Size(100, 20);
            this.keysTextBox.TabIndex = 7;
            this.keysTextBox.Visible = false;
            this.keysTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keysTextBox_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.keysTextBox);
            this.Controls.Add(this.yellowLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.yellowAnswerLabel);
            this.Controls.Add(this.blueAnswerLabel);
            this.Controls.Add(this.redAnswerLabel);
            this.Controls.Add(this.mainOutputLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
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
    }
}

