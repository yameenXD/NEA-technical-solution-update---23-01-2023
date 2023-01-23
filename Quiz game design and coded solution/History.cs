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
    public partial class History : Form
    {
        // quiz game variables
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        int[] goArray;
        public History()
        {
            InitializeComponent();
            askQuestion(1);
            totalQuestions = 10;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == correctAnswer) // selection. If the selected answer is equal to the correct answer the score will be incremented by one.
            {
                score = score + 1;
                label3.Text = score.ToString();
            }

            questionNumber++;
            askQuestion(questionNumber);

            if (questionNumber == totalQuestions)
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

                    label1.Text = "What were winning athletes given at the ancient Olympic Games?"; // the question asked to the user

                    button1.Text = "Parcels of land"; // option 1
                    button2.Text = "Laurel wreaths"; // option 2
                    button3.Text = "Silver swords"; // option 3
                    button4.Text = "Gold Coins"; // option 4

                    correctAnswer = 2; // the correct answer would option 2


                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "Which county of Ireland is known as the 'Rebel County'?"; // the second question that is asked to the user

                    button1.Text = "Cork"; // option 1
                    button2.Text = "Sligo"; // option 2
                    button3.Text = "Limerick"; // option 3
                    button4.Text = "Galway"; // option 4

                    correctAnswer = 1; // the correct answer would be the second option in this case

                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "What was a Tin Lizzie?"; // the third question that is asked to the user

                    button1.Text = "A baked bean container"; // option 1
                    button2.Text = "A pop group"; // option 2
                    button3.Text = "A washing machine"; // option 3
                    button4.Text = "An early car"; // option 4

                    correctAnswer = 4; // the correct answer would be four in this case
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "What was Sir Thomas Raffles most famous for?"; // the third question that is asked to the user

                    button1.Text = "Introducing the first national lottery"; // option 1
                    button2.Text = "Inventing the gin and tonic drink"; // option 2
                    button3.Text = "Founding the hotel chain"; // option 3
                    button4.Text = "Fouding Singapore"; // option 4

                    correctAnswer = 4; // the correct answer would be four in this case
                    break;





                case 5:
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "The Great War heroine Nurse Cavell's given name was WHAT?"; // the third question that is asked to the user

                    button1.Text = "Gladys"; // option 1
                    button2.Text = "Cynthia"; // option 2
                    button3.Text = "Edith"; // option 3
                    button4.Text = "Cora"; // option 4

                    correctAnswer = 3; // the correct answer would be four in this case
                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "The hussars were originally light cavalry in which country?"; // the third question that is asked to the user

                    button1.Text = "France"; // option 1
                    button2.Text = "Hungry"; // option 2
                    button3.Text = "Spain"; // option 3
                    button4.Text = "Poland"; // option 4

                    correctAnswer = 2; // the correct answer would be four in this case
                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "Whose fleet was destroyed by the British at the Battle of the Nile in 1798?"; // the third question that is asked to the user

                    button1.Text = "Marquis de Montcalm"; // option 1
                    button2.Text = "Napolean Bonaparte"; // option 2
                    button3.Text = "Atilla the Hun"; // option 3
                    button4.Text = "Cleopatra"; // option 4

                    correctAnswer = 2; // the correct answer would be four in this case
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "Gwynedd was one of the kingdoms of WHICH country?"; // the third question that is asked to the user

                    button1.Text = "Scotland"; // option 1
                    button2.Text = "Wales"; // option 2
                    button3.Text = "Ireland"; // option 3
                    button4.Text = "Sweden"; // option 4

                    correctAnswer = 2; // the correct answer would be four in this case
                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "Which of Henry VIII's children reigned in England for 44 years?"; // the third question that is asked to the user

                    button1.Text = "Edward VI"; // option 1
                    button2.Text = "Elizabeth II"; // option 2
                    button3.Text = "Mary I"; // option 3
                    button4.Text = "Elizabeth I"; // option 4

                    correctAnswer = 4; // the correct answer would be two in this case
                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "The first portable calculators appeared in Japan in this year and Concorde made its first supersonic flight."; // the third question that is asked to the user

                    button1.Text = "1950"; // option 1
                    button2.Text = "1960"; // option 2
                    button3.Text = "1970"; // option 3
                    button4.Text = "1980"; // option 4

                    correctAnswer = 3; // the correct answer would be four in this case
                    break;


            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void namebox_TextChanged(object sender, EventArgs e)
        {
            
            
                string name = namebox.Text;
                namebox.Text = name;
                this.Show();

            
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
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
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Welcome {namebox.Text}");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string[] questions = new string[10];
            questions = fileReader("History.txt.txt");
            for (int i = 0; i < questions.Length; i++)
            {
                string tmp = questions[i];
                char[] charArr = tmp.ToCharArray();
                for (int j = 0; j < charArr.Length; j++)
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
            string[] questions = new string[10];
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
