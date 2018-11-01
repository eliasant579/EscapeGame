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

// test of the GitHub repo

    //test 2

namespace EscapeGame
{
    public partial class Form1 : Form
    {
        int scene = 0;
        int i = 0;
        bool angerValue = false;
        Random randGen = new Random();

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
                        //coming from textbox event
                        mainOutputLabel.Text = "There is an high probability of a fight";
                        Thread.Sleep(2000);
                        if (randGen.Next(1, 101) <= 80)
                        {
                            mainOutputLabel.Text = "A fight is starting!";
                            Thread.Sleep(1000);
                            if (randGen.Next(1, 101) <= 50 || angerValue == true)
                            {
                                scene = 4;
                            }
                            else
                            {
                                scene = 5;
                            }
                        }
                        else
                        {
                            scene = 5;
                        }
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
                        //coming from textbox event
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
                    //return;
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
                    //scene moved inside textbox event
                    break;
                case 3:
                    mainOutputLabel.Text = "You continue with the help of the other prisoners. Do you go left or right?";
                    redAnswerLabel.Text = "Right";
                    blueAnswerLabel.Text = "Left";
                    break;
                case 4:
                    mainOutputLabel.Text = "You have been knocked out during the fight";
                    if (angerValue == true)
                    {
                        mainOutputLabel.Text += ":\nthe other prisoners were anry with you because you woke them up yelling.";
                    }
                    else
                    {
                        mainOutputLabel.Text += ".";
                    }
                    //end
                    break;
                case 5:
                    mainOutputLabel.Text = "You continue alone. Do you go right or left?";
                    redAnswerLabel.Text = "Right";
                    blueAnswerLabel.Text = "Left";
                    break;
                case 6:
                    mainOutputLabel.Text = "You find a door and together you manage to knock it down";
                    goto case 11;
                    //scene = 11;
                    //break;
                case 7:
                    mainOutputLabel.Text = "The prisoners you just set free are too noisy:\n" +
                        "a bunch of officers notice you and you are all forced inside your cells.";
                    //end
                    break;
                case 8:
                    mainOutputLabel.Text = "A officer notice you, act fast!\n" +
                        "Ther's a door in front of you, find the right key!";
                    redLabel.Visible = false;
                    blueLabel.Visible = false;
                    redAnswerLabel.Text = null;
                    blueAnswerLabel.Text = null;
                    keysTextBox.Visible = true;
                    break;
                case 9:
                    mainOutputLabel.Text = "You find yourself inside the main office.\n" +
                        "Do you run the other way or you dissimulate and walk past?";
                    redAnswerLabel.Text = "Run back!";
                    blueAnswerLabel.Text = "Walk past";
                    break;
                case 10:
                    //this scene has been moved in the text box event
                    break;
                case 11:
                    //yellowAnswerLabel
                    mainOutputLabel.Text = "You are finally outside the prison! Which way do you go?";
                    redAnswerLabel.Text = "Ye";
                    blueAnswerLabel.Text = "yay";
                    break;
                case 12:
                    mainOutputLabel.Text = "You end up in the courthouse. \nAgain.";
                    //end
                    break;
                case 13:
                    mainOutputLabel.Text = "You end up in a curch and become a minister to escape the police.";
                    //end
                    break;
                case 14:
                    mainOutputLabel.Text = "You end up in Stratford Central Secondary School.\n" +
                        "At least it's not St.Mike's";
                    //end
                    break;
            }
        }

        
        private void keysTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && scene == 1)
            {
                if (keysTextBox.Text == RIGHT_KEY_S1)
                {
                    redLabel.Visible = true;
                    blueLabel.Visible = true;
                    keysTextBox.Text = null;
                    keysTextBox.Visible = false;
                    scene = 2;                      //this is scene two;
                    mainOutputLabel.Text = "Right key! \nDo you want to set the other prisoners free?";
                    redAnswerLabel.Text = "Yes";
                    blueAnswerLabel.Text = "No";
                    this.Focus();                   //leave this method
                }
                else
                {
                    redAnswerLabel.Text = "Wrong key or invalid input.";
                    keysTextBox.Text = null;
                }
            }
            if (e.KeyCode == Keys.Enter && scene == 8)
            {
                if (keysTextBox.Text == RIGHT_KEY_S8)
                {
                    redLabel.Visible = true;
                    blueLabel.Visible = true;
                    keysTextBox.Text = null;
                    keysTextBox.Visible = false;
                    scene = 11;
                    mainOutputLabel.Text = "Right key!\n" +
                        "Press any key to continue.";
                    this.Focus();                   //leave this method
                }
                else
                {
                    i++;
                    if (i == 3)
                    {
                        //scene 10
                        mainOutputLabel.Text = "You have been caught and brought back to your cell.";
                        //end
                    }
                }
            }
        }
        
    }
}
