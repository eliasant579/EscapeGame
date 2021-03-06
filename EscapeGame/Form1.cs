﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Elia Santagiuliana 08/11/18
/// 
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
                        redAnswerLabel.Text = null;
                        redLabel.Visible = false;
                        blueAnswerLabel.Text = null;
                        blueLabel.Visible = false;
                        mainOutputLabel.Text = null;
                        mainOutputLabel.Text = "You open their cells and tell them to be quiet." +
                            "\nSome of them try to punch others in a friendly way.";
                        Refresh();
                        Thread.Sleep(5000);
                        if (randGen.Next() % 101 <= 70)
                        {
                            SoundPlayer fightSound = new SoundPlayer(Properties.Resources.Many_Punches_SoundBible_com_1623072177);
                            fightSound.Play();
                            mainOutputLabel.Text = "A fight is starting!";
                            Refresh();
                            Thread.Sleep(2500);
                            if (randGen.Next() % 101 <= 40 || angerValue == true)
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
                        scene = 7;
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
                        mainOutputLabel.Text = "Y";
                        scene = 5;
                        break;
                    case 3:
                        scene = 6;
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
                    yellowAnswerLabel.Text = "Oak's words echoed... " +
                        "\nThere's a time and place for everything, " +
                        "\nbut not now...";
                    pictureBox.Visible = false;
                    Refresh();
                    Thread.Sleep(2100);
                    yellowAnswerLabel.Text = null;
                    redLabel.Visible = true;
                    redAnswerLabel.Visible = true;
                    blueLabel.Visible = true;
                    blueAnswerLabel.Visible = true;
                    yellowLabel.Visible = false;
                    pictureBox.Visible = true;
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
                    mainOutputLabel.Text = "You realise it was a bunch of eight keys! " +
                        "\nMaybe yours is among them, let's find out!" +
                        "\nInsert the number of the key you want to use";
                    break;
                case 2:
                    //scene moved inside textbox event
                    break;
                case 3:
                    //make stuff visible again
                    redAnswerLabel.Visible = true;
                    blueAnswerLabel.Visible = true;
                    redLabel.Visible = true;
                    blueLabel.Visible = true;
                    mainOutputLabel.Text = "You continue with the help of the other prisoners. Do you go left or right?";
                    redAnswerLabel.Text = "Right";
                    blueAnswerLabel.Text = "Left";
                    break;
                case 4:
                    //ko image
                    SoundPlayer koSound = new SoundPlayer(Properties.Resources.Boxing_arena_sound_Samantha_Enrico_246597508);
                    koSound.Play();
                    pictureBox.BackgroundImage = EscapeGame.Properties.Resources.KO;
                    mainOutputLabel.Text = "You have been knocked out during the fight";
                    if (angerValue == true) //if shouted at the beggining
                    {
                        mainOutputLabel.Text += ":\nthe other prisoners were angry with you because you woke them up yelling.";
                    }
                    else
                    {
                        mainOutputLabel.Text += ".";
                    }
                    End();
                    break;
                case 5:
                    pictureBox.BackgroundImage = null;
                    redAnswerLabel.Visible = true;
                    redLabel.Visible = true;
                    blueAnswerLabel.Visible = true;
                    blueLabel.Visible = true;
                    mainOutputLabel.Text += "ou continue alone. Do you go right or left?";
                    redAnswerLabel.Text = "Right";
                    blueAnswerLabel.Text = "Left";
                    break;
                case 6:
                    pictureBox.BackgroundImage = EscapeGame.Properties.Resources.P_Door;
                    mainOutputLabel.Text = "You find a door and together you manage to knock it down";
                    Thread.Sleep(4000);
                    goto case 11;                               //fall through
                case 7:
                    pictureBox.BackgroundImage = EscapeGame.Properties.Resources.P_Cells;
                    mainOutputLabel.Text = "The prisoners you just set free are too noisy:\n" +
                        "a bunch of officers notice you and you are all forced inside your cells.";
                    End();
                    break;
                case 8:
                    pictureBox.BackgroundImage = EscapeGame.Properties.Resources.P_Door;
                    mainOutputLabel.Text = "A officer notices you, act fast!\n" +
                        "Ther's a door in front of you, find the right key!";
                    redLabel.Visible = false;
                    blueLabel.Visible = false;
                    redAnswerLabel.Text = null;
                    blueAnswerLabel.Text = null;
                    keysTextBox.Visible = true;
                    break;
                case 9:
                    pictureBox.BackgroundImage = EscapeGame.Properties.Resources.P_Main_Office;
                    mainOutputLabel.Text = "You find yourself inside the main office.\n" +
                        "Do you run the other way or do you act as nothing is happening and walk past?";
                    redAnswerLabel.Text = "Run back!";
                    blueAnswerLabel.Text = "Walk past";
                    break;
                case 10:
                    //this scene has been moved in the text box event
                    break;
                case 11:
                    //+yellowAnswerLabel
                    //image free
                    pictureBox.BackgroundImage = EscapeGame.Properties.Resources.background;
                    redLabel.Visible = true;
                    blueLabel.Visible = true;
                    yellowLabel.Visible = true;
                    mainOutputLabel.Text = "You are finally outside the prison! Which way do you go?";
                    redAnswerLabel.Text = "Right";
                    blueAnswerLabel.Text = "Left";
                    yellowAnswerLabel.Text = "Straight";
                    break;

                    //OUTSIDE THE PRISON

                case 12:
                    //image court house
                    pictureBox.BackgroundImage = EscapeGame.Properties.Resources.Court_House;
                    mainOutputLabel.Text = "You end up in the courthouse. \nAgain.";
                    End();
                    break;
                case 13:
                    //image church
                    pictureBox.BackgroundImage = EscapeGame.Properties.Resources.Church;
                    mainOutputLabel.Text = "You end up in a curch and become a minister to escape the police.";
                    End();
                    break;
                case 14:
                    pictureBox.BackgroundImage = EscapeGame.Properties.Resources.Scss;
                    mainOutputLabel.Text = "You end up in Stratford Central Secondary School.\n" +
                        "At least it's not St.Mike's";
                    End();
                    break;
                case 400:
                    if (e.KeyCode == Keys.R)
                    {
                        //restart game
                        pictureBox.BackgroundImage = EscapeGame.Properties.Resources.P_Bed;
                        mainOutputLabel.Text = "You are in jail. \nIt's nightime and you' ve just waken up" +
                            " in pain because something was thrown at you. " +
                            "\nDo you shout angrily to the other prisoners?";
                        redAnswerLabel.Text = "Yes";
                        blueAnswerLabel.Text = "No";
                        Refresh();
                        scene = 0;
                        angerValue = false;
                    }
                    else if (e.KeyCode == Keys.B)
                    {
                        //exit
                        mainOutputLabel.Text = "Thanks for playing";
                        Thread.Sleep(500);
                        Application.Exit();
                    }
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
                    pictureBox.BackgroundImage = EscapeGame.Properties.Resources.P_Cells;
                    mainOutputLabel.Text = "Right key! \nYou move quietly into the hallway, where you notice the other cells.\n" +
                        "Do you want to set the other prisoners free?";
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
                    redAnswerLabel.Text = null;
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
                        End();
                    }
                }
            }
        }  
        
        void End()
        {
            Refresh();
            redLabel.Visible = false;
            redAnswerLabel.Text = null;
            blueLabel.Visible = false;
            blueAnswerLabel.Text = null;
            yellowLabel.Visible = false;
            yellowAnswerLabel.Text = null;
            Thread.Sleep(3000);
            redLabel.Visible = true;
            blueLabel.Visible = true;
            mainOutputLabel.Text += "\n\nDo you want to play again?";
            redAnswerLabel.Text = "Yes";
            blueAnswerLabel.Text = "No";
            scene = 400;
        }

    }
}
