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
/// define the end of the game
/// decide if you want to use the timer or not
/// </summary>


// scenes 1 & 8 & fights & KO are not yes/no decisions. Managed differently


namespace EscapeGame
{
    public partial class Form1 : Form
    {
        int scene = 0;                      //scene number
        int i = 0;                          //counter for scene 8
        bool angerValue = false;            //answer scene 0
        Random randGen = new Random();      //random counter
        const string RIGHT_KEY_S1 = "5";    //scene 1 answer
        const string RIGHT_KEY_S8 = "8";    //scene 8 answer


        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
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
                        redAnswerLabel.Visible = false;
                        redLabel.Visible = false;
                        blueAnswerLabel.Visible = false;
                        blueLabel.Visible = false;
                        Refresh();
                        if (randGen.Next() % 101 <= 70)
                        {
                            mainOutputLabel.Text = "A fight is starting!";
                            Refresh();
                            Thread.Sleep(1500);
                            if (randGen.Next() % 101 <= 50 || angerValue == true)
                            {
                                scene = 4;
                            }
                            else
                            { 
                                mainOutputLabel.Text = "You manage to leave the fight, so y";
                                scene = 5;
                            }
                        }
                        else
                        {
                            scene = 3;
                        }
                        break;
                    case 3:
                        scene = 6;
                        break;
                    case 5:
                        scene = 9;
                        break;
                    case 9:
                        scene = 8;
                        break;
                    case 11:
                        scene = 14;
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
                        scene = 8;
                        break;
                    case 9:
                        scene = 11;
                        break;
                    case 11:
                        scene = 12;
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
                    mainOutputLabel.Text = "Which of the 8 keys is the right one?";
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
                    if (angerValue == true) //if shouted at the beggining
                    {
                        mainOutputLabel.Text += ":\nthe other prisoners were angry with you because you woke them up yelling.";
                    }
                    else
                    {
                        mainOutputLabel.Text += ".";
                    }
                    //end
                    break;
                case 5:
                    redAnswerLabel.Visible = true;
                    redLabel.Visible = true;
                    blueAnswerLabel.Visible = true;
                    blueLabel.Visible = true;
                    mainOutputLabel.Text += "ou continue alone. Do you go right or left?";
                    redAnswerLabel.Text = "Right";
                    blueAnswerLabel.Text = "Left";
                    break;
                case 6:
                    mainOutputLabel.Text = "You find a door and together you manage to knock it down";
                    goto case 11;                               //fall through
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
                    redLabel.Visible = true;
                    blueLabel.Visible = true;
                    yellowLabel.Visible = true;
                    mainOutputLabel.Text = "You are finally outside the prison! Which way do you go?";
                    redAnswerLabel.Text = "Right";
                    blueAnswerLabel.Text = "Left";
                    yellowAnswerLabel.Text = "Straight on";
                    break;

                    //OUTSIDE THE PRISON

                case 12:
                    redLabel.Visible = false;
                    redAnswerLabel.Visible = false;
                    blueLabel.Visible = false;
                    blueAnswerLabel.Visible = false;
                    yellowLabel.Visible = false;
                    yellowAnswerLabel.Visible = false;
                    mainOutputLabel.Text = "You end up in the courthouse. \nAgain.";
                    //end
                    break;
                case 13:
                    redLabel.Visible = false;
                    redAnswerLabel.Visible = false;
                    blueLabel.Visible = false;
                    blueAnswerLabel.Visible = false;
                    yellowLabel.Visible = false;
                    yellowAnswerLabel.Visible = false;
                    mainOutputLabel.Text = "You end up in a curch and become a minister to escape the police.";
                    //end
                    break;
                case 14:
                    redLabel.Visible = false;
                    redAnswerLabel.Visible = false;
                    blueLabel.Visible = false;
                    blueAnswerLabel.Visible = false;
                    yellowLabel.Visible = false;
                    yellowAnswerLabel.Visible = false;
                    mainOutputLabel.Text = "You end up in Stratford Central Secondary School.\n" +
                        "At least it's not St.Mike's";
                    //end
                    break;
            }
        }

        

        //textbox event
        private void keysTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && scene == 1)          //enter is pressed the first time that the textbox appears
            {
                if (keysTextBox.Text == RIGHT_KEY_S1)           //check the right key
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
                else                                            //wrong input
                {
                    redAnswerLabel.Text = "Wrong key or invalid input.";
                    keysTextBox.Text = null;
                }
            }
            else if (e.KeyCode == Keys.Enter && scene == 8)     //enter is pressed the second time the textbox shows up
            {
                if (keysTextBox.Text == RIGHT_KEY_S8)           //check the key
                {
                    keysTextBox.Text = null;
                    keysTextBox.Visible = false;
                    scene = 11;
                    mainOutputLabel.Text = "Right key!\n" +
                        "Press any key to continue.";
                    this.Focus();                   //leave this method
                }
                else                                            //wrong input
                {
                    keysTextBox.Text = null;
                    redAnswerLabel.Text = "Wrong key!";
                    i++;
                    if (i == 3)                                 //if wrong three times end the game
                    {
                        //scene 10
                        mainOutputLabel.Text = "You have been caught and brought back to your cell.";
                        keysTextBox.Visible = false;
                        redAnswerLabel.Text = null;
                        //end
                    }
                }
            }
        }
        
    }
}
