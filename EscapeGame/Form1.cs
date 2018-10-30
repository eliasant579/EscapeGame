using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscapeGame
{
    public partial class Form1 : Form
    {
        int scene = 0;
        bool angerValue = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            // scenes 1 & 8 & fights & KO are not yes/no decisions. Managed differently

            if (e.KeyCode == Keys.R)                //red button (left)
            {
                switch (scene)
                {
                    case 0:
                        angerValue = true;
                        scene = 1;
                        break;
                    case 3:
                        scene = 6;
                        break;
                    case 5:
                        scene = 8;
                        break;
                    case 9:
                        scene = 8;
                        break;
                    case 11:
                        scene = 12;
                        break;

                }
            }
            else if (e.KeyCode == Keys.B)           //blue button (right)
            {
                switch (scene)
                {
                    case 0:
                        scene = 1;
                        break;
                    case 2:
                        scene = 5;
                        break;
                    case 3:
                        scene = 7;
                        break;
                    case 5:
                        scene = 9;
                        break;
                    case 9:
                        scene = 11;
                        break;
                    case 11:
                        scene = 14;
                        break;
                }
            }
            else if (e.KeyCode == Keys.Y)           //yellow button
            {
                if (scene == 11)
                {
                    scene = 13;
                }
                else
                {
                    //Oak's words echoed... There's a time and place for everything, but not now.
                    return;
                }
            }

            switch (scene)
            {
                case 0:
                    break;
                case 1:
                    mainOutputLabel.Text = "Some stuff";
                    redAnswerLabel.Text = "Ye";
                    blueAnswerLabel.Text = "yay";
                    break;
                case 2:
                    mainOutputLabel.Text = "Some stuff";
                    //80% fight, to scene 3 or other case (5 or 7)
                    break;
                case 3:
                    mainOutputLabel.Text = "Some stuff";
                    redAnswerLabel.Text = "Ye";
                    blueAnswerLabel.Text = "yay";
                    break;
                case 4:
                    mainOutputLabel.Text = "Some stuff";
                    //end
                    break;
                case 5:
                    mainOutputLabel.Text = "Some stuff";
                    redAnswerLabel.Text = "Ye";
                    blueAnswerLabel.Text = "yay";
                    break;
                case 6:
                    mainOutputLabel.Text = "Some stuff";
                    break;
                case 7:
                    mainOutputLabel.Text = "Some stuff";
                    //end
                    break;
                case 8:
                    break;
                case 9:
                    mainOutputLabel.Text = "Some stuff";
                    redAnswerLabel.Text = "Ye";
                    blueAnswerLabel.Text = "yay";
                    break;
                case 10:
                    mainOutputLabel.Text = "Some stuff";
                    //end
                    break;
                case 11:
                    mainOutputLabel.Text = "Some stuff";
                    redAnswerLabel.Text = "Ye";
                    blueAnswerLabel.Text = "yay";
                    break;
                case 12:
                    mainOutputLabel.Text = "Some stuff";
                    //end
                    break;
                case 13:
                    mainOutputLabel.Text = "Some stuff";
                    //end
                    break;
                case 14:
                    mainOutputLabel.Text = "Some stuff";
                    //end
                    break;
            }
        }
    }
}
