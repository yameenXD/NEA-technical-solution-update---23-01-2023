using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_game_design_and_coded_solution
{
    public partial class General_knowledge_question : Form
    {
        // quiz game variables

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        int[] goArray;
        string[] questions;



        public General_knowledge_question()
        {
            InitializeComponent();
            askQuestion(1); // this calls to the method 
            totalQuestions = 10; // 10 is the number of total questions


        }

        //private method for checkanswerEvent to check if the answer to a particular to a question in correct
        private void checkAnswereEvent(object sender, EventArgs e)
        {

            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == correctAnswer) // selection. If the selected answer is equal to the correct answer the score will be incremented by one.
            {
                score = score + 1; // score will be incremented by one
                label3.Text = score.ToString();
            }

            questionNumber++; // increments the question number by one
            askQuestion(questionNumber);

            if (questionNumber == totalQuestions) // Selection. If the question is equal to the total amount of questions
            {
                // Working out the percentage 

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                // this will display when the quiz has ended 
                MessageBox.Show("Quiz Ended!" + Environment.NewLine + "You have answered " + score + "questions correctly" + Environment.NewLine +
                    "Your total percentage is" + percentage + "%" + Environment.NewLine +
                    "Click OK to play again");
                score = 0; // this will reset the code to 0
                questionNumber = 0;
                askQuestion(questionNumber);


            }
        }

        private void askQuestion(int qnum)  // private method for asking the questions
        {
            switch (qnum)  // to allow it to select many code blocks to be executed
            {
                case 1: // question one 
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "What is the colour of the sky?"; // the question asked to the user

                    button1.Text = "Blue"; // option 1
                    button2.Text = "Yellow"; // option 2
                    button3.Text = "Orange"; // option 3
                    button4.Text = "Red"; // option 4

                    correctAnswer = 1; // the correct answer would option 1


                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "What is the name main character from Iron Man?"; // the second question that is asked to the user

                    button1.Text = "Tony Stank"; // option 1
                    button2.Text = "Tony Stark"; // option 2
                    button3.Text = "Rody"; // option 3
                    button4.Text = "Peter Quill"; // option 4

                    correctAnswer = 2; // the correct answer would be the second option in this case

                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "What game company created Fornite ?"; // the third question that is asked to the user

                    button1.Text = "Blizzard"; // option 1
                    button2.Text = "Steam"; // option 2
                    button3.Text = "Activision"; // option 3
                    button4.Text = "Epic Games"; // option 4

                    correctAnswer = 4; // the correct answer would be four in this case
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "Which country was once known as 'The Great Bear'? "; // the third question that is asked to the user

                    button1.Text = "Canada"; // option 1
                    button2.Text = "Australia"; // option 2
                    button3.Text = "Soviet Union"; // option 3
                    button4.Text = "China"; // option 4

                    correctAnswer = 3; // the correct answer would be four in this case
                    break;





                case 5:
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "Which horror film stars Sissy Spacek?"; // the third question that is asked to the user

                    button1.Text = "Halloween"; // option 1
                    button2.Text = "The Omen"; // option 2
                    button3.Text = "Carrie"; // option 3
                    button4.Text = "The Exorcist"; // option 4

                    correctAnswer = 3; // the correct answer would be four in this case
                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "Which of the following happened first"; // the third question that is asked to the user

                    button1.Text = "Henery VIII dies"; // option 1
                    button2.Text = "Issac Newton discovers gravitation?"; // option 2
                    button3.Text = "Napolean Bonaparte was born"; // option 3
                    button4.Text = "Photography was invented"; // option 4

                    correctAnswer = 1; // the correct answer would be four in this case
                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "What is a VELD?"; // the third question that is asked to the user

                    button1.Text = "A large knife"; // option 1
                    button2.Text = "A young deer"; // option 2
                    button3.Text = "A cow's leg shackle"; // option 3
                    button4.Text = "South African grassland"; // option 4

                    correctAnswer = 4; // the correct answer would be four in this case
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "Salsette Island is a densely populated island of WHICH country?"; // the third question that is asked to the user

                    button1.Text = "Mexico"; // option 1
                    button2.Text = "Canada"; // option 2
                    button3.Text = "India"; // option 3
                    button4.Text = "China"; // option 4

                    correctAnswer = 3; // the correct answer would be four in this case
                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "What natural feature occupies a quarter of Northern Africa?"; // the third question that is asked to the user

                    button1.Text = "Savanna grasslands"; // option 1
                    button2.Text = "Sahara desert"; // option 2
                    button3.Text = "Jungle"; // option 3
                    button4.Text = "Lakes and rivers"; // option 4

                    correctAnswer = 2; // the correct answer would be two in this case
                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "In addition to \"9 1/2 Weeks\", \"You Can Leave Your Hat On\" is a song from WHICH film??"; // the third question that is asked to the user

                    button1.Text = "Mad Max Beyond Thunderdome"; // option 1
                    button2.Text = "The Full Monty"; // option 2
                    button3.Text = "Reservior Dogs"; // option 3
                    button4.Text = "Jungle Books"; // option 4

                    correctAnswer = 2; // the correct answer would be four in this case
                    break;


            }
        }

        private void exitBtn_Click(object sender, EventArgs e) // private method for exit button
        {
            this.Close();   // This will allow the user to close 
        }

        private void namebox_TextChanged(object sender, EventArgs e)
        {


            string name = namebox.Text;
            namebox.Text = name;
            this.Show();


        }




        private void label2_Click(object sender, EventArgs e)
        {
            /* var senderObject = (Button)sender;
             int buttonTag = Convert.ToInt32(senderObject.Tag);

             if (buttonTag == correctAnswer) // selection. If the selected answer is equal to the correct answer the score will be incremented by one.
             {
                 score = score + 1; // score will be incremented by one
                 label2.ResetText();
                 score = 0;
                 int goscore = goArray[0];

                 this.Hide();
                 Form1 f1 = new Form1();
                 f1.ShowDialog();
                 this.Close();
             }*/

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Welcome {namebox.Text}");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            /*score = 0;
            label3.Text = score.ToString();*/
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string[] questions = new string[10];
            questions = fileReader("GeneralGeneral knowledge.txt.txt");
            for(int i = 0; i < questions.Length; i++)
            {
                string tmp = questions[i];
                char[] charArr  =tmp.ToCharArray();
                for(int j = 0; j < charArr.Length; j++)
                {
                    int ascii = (int)charArr[j];
                    Console.WriteLine(ascii);
                    char newChar = (char)(ascii);
                    Console.WriteLine(newChar);
                }
            }
        }

        private string[] fileReader(string filename)
        {
            string[] files = new string[10];
            int index = 0;

            try
            {
                StreamReader sr = new StreamReader(filename);
                while (sr.Peek() >= 0)
                {
                    questions[index] = sr.ReadLine();
                    index++;
                }
                return questions;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

    }
}