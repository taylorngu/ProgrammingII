using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Media;

namespace Animals
{


    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

        }




        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Random gen = new Random();


                if (radDog.Checked)
                {

                    Gender randomGender = (Gender)gen.Next((int)Gender.Male, (int)Gender.Unknown + 1);

                    Dog shep = new Dog();

                    shep.name = Interaction.InputBox("Enter your dog's name.", "Name");
                    shep.color = Interaction.InputBox("Enter your dog's color.", "Color");
                    shep.weight = Convert.ToDouble(Interaction.InputBox("Enter your dog's weight.", "Weight"));
                    shep.gender = randomGender;

                    lblOut.Text += shep.ToString();
                    shep.MakeNoise();

                }
                else if (radCat.Checked)
                {

                    Cat mittens = new Cat();

                    Gender randomGender = (Gender)gen.Next((int)Gender.Male, (int)Gender.Unknown + 1);

                    mittens.name = Interaction.InputBox("Enter your cat's name.", "Name");
                    mittens.color = Interaction.InputBox("Enter your cat's color.", "Color");
                    mittens.weight = Convert.ToDouble(Interaction.InputBox("Enter your cat's weight.", "Weight"));
                    mittens.gender = randomGender;

                    lblOut.Text += mittens.ToString();
                    mittens.MakeNoise();

                }
                else
                {

                    Bird tweetie = new Bird();

                    Gender randomGender = (Gender)gen.Next((int)Gender.Male, (int)Gender.Unknown + 1);

                    tweetie.name = Interaction.InputBox("Enter your bird's name.", "Name");
                    tweetie.color = Interaction.InputBox("Enter your bird's color.", "Color");
                    tweetie.weight = Convert.ToDouble(Interaction.InputBox("Enter your bird's weight.", "Weight"));
                    tweetie.gender = randomGender;

                    lblOut.Text += tweetie.ToString();
                    tweetie.MakeNoise();

                }

            }

            catch
            {

                lblOut.Text = "Please enter valid values.";

            }
        }
    }

    enum Gender : byte { Male, Female, Neutered, Spayed, Unknown };
 
    abstract class Animal
        {
            public string name { get; set; }
            public string color { get; set; }
            public double weight { get; set; }
            public Gender gender { get; set; }


            public Animal(string name = "", string color = "", double weight = 0, Gender gender = Gender.Unknown)
            {

                this.name = name;
                this.color = color;
                this.weight = weight;
                this.gender = gender;

            }

            public abstract void MakeNoise();

            public override string ToString()
            {

                return String.Format("\n\nName: {0} \nColor: {1} \nWeight: {2} \nGender: {3}", name, color, weight, gender);

            }

        }
        class Dog : Animal
        {

            public Dog(string name = "", string color = "", double weight = 0, Gender gender = Gender.Unknown) : base(name, color, weight, gender) { }

            public override void MakeNoise()
            {
                SoundPlayer simpleSound = new SoundPlayer(@"res/dog-bark1.wav");
                simpleSound.Play();
            }

        }
        class Cat: Animal 
        {

           public Cat(string name = "", string color = "", double weight = 0, Gender gender = Gender.Unknown) : base(name, color, weight, gender) { }

            public override void MakeNoise()
            {
                SoundPlayer simpleSound = new SoundPlayer(@"res/CatMeow.wav");
                simpleSound.Play();
            }
   
        }
        class Bird : Animal
        {

           public Bird(string name = "", string color = "", double weight = 0, Gender gender = Gender.Unknown) : base(name, color, weight, gender) { }

            public override void MakeNoise()
            {
                SoundPlayer simpleSound = new SoundPlayer(@"res/KilldeerSong.wav");
                simpleSound.Play();

            }


        }

    }

