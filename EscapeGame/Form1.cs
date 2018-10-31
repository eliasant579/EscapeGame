using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Elia Santagiuliana gg/11/18
/// 
/// Reminder: ask if there's a function for counting time
/// </summary>

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

        const string RIGHT_KEY_S1 = "5";
        const string RIGHT_KEY_S8 = "8";

        public void Form1_KeyDown(object sender, KeyEventArgs e)
            //gets only one KeyCode
        {
            // scenes 1 & 8 & fights & KO are not yes/no decisions. Managed differently
            if (e.KeyCode == Keys.R)                //red button (left)
            {
                switch (scene)
                {
                    case 0:
                        //to scene one counting the value
                        angerValue = true;
                        scene = 1;
                        break;
                    case 2:
                        //reciving input (perhaps) from satisfied if statement in textbox event
                        mainOutputLabel.Text = "You got this!";
                        //80% fight, to scene 3 or other case (5 or 7)
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
                        //to scene one without counting the value
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
                    redLabel.Visible = false;
                    redAnswerLabel.Visible = false;
                    blueLabel.Visible = false;
                    blueAnswerLabel.Visible = false;
                    yellowLabel.Visible = true;
                    yellowAnswerLabel.Text = "Oak's words echoed... \nThere's a time and place for everything, but not now.";
                    Refresh();
                    Thread.Sleep(2100);
                    yellowAnswerLabel.Text = null;
                    redLabel.Visible = true;
                    redAnswerLabel.Visible = true;
                    blueLabel.Visible = true;
                    blueAnswerLabel.Visible = true;
                    yellowLabel.Visible = false;
                    return;
                }
            }

            //this switch is used if scenes are "standard" decisions, without looping or testing
            switch (scene)
            {
                case 0:
                    break;
                case 1:
                    //choosing keys
                    keysTextBox.Visible = true;
                    redAnswerLabel.Text = null;
                    blueAnswerLabel.Text = null;
                    redLabel.Visible = false;
                    blueLabel.Visible = false;
                    mainOutputLabel.Text = "Which of the key is the right one?";
                    break;
                case 2:
                    //free or not?
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

        
        private void keysTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (keysTextBox.Text == RIGHT_KEY_S1)
                {
                    redLabel.Visible = true;
                    blueLabel.Visible = true;
                    keysTextBox.Text = null;
                    keysTextBox.Visible = false;
                    mainOutputLabel.Text = "Right key! \nDo you want to set the other prisoners free?";
                    redAnswerLabel.Text = "Yes";
                    blueAnswerLabel.Text = "No";
                    scene = 2;
                    this.Focus();
                    //how do I leave this method and go back to from1 keydown?
                }
                else
                {
                    redAnswerLabel.Text = "Wrong key or invalid input.";
                    keysTextBox.Text = null;
                }
            }
        }
        
    }
}
