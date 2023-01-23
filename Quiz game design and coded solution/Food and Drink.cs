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
    public partial class Food_and_Drink : Form
    {
        // quiz game variables
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        int [] goArray;

        public Food_and_Drink()
        {
            InitializeComponent();
            totalQuestions = 10;
            askQuestion(1);
        }


        

       

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == correctAnswer)
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
        //Private method that asks questions to the user
        private void askQuestion(int qnum) 
        {
            switch (qnum)  // to allow it to select many code blocks to be executed
            {
                case 1: // question one 
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "What was the name of Christopher and Mary Penfold's original home, which carries the name of a renowned red wine?"; // the question asked to the user

                    button1.Text = "Magill Estate"; // option 1
                    button2.Text = "Grange"; // option 2
                    button3.Text = "Mackgill Estate"; // option 3
                    button4.Text = "Penfold Homestead"; // option 4

                    correctAnswer = 2; // the correct answer would option 1


                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "Which of these cuisines is Italian?"; // the second question that is asked to the user

                    button1.Text = "Goulash"; // option 1
                    button2.Text = "Calzone"; // option 2
                    button3.Text = "Borscht"; // option 3
                    button4.Text = "Croissant"; // option 4

                    correctAnswer = 2; // the correct answer would be the second option in this case

                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "Oenology is the study of WHAT beverage?"; // the third question that is asked to the user

                    button1.Text = "Rum"; // option 1
                    button2.Text = "Coffee"; // option 2
                    button3.Text = "Beer"; // option 3
                    button4.Text = "Wine"; // option 4

                    correctAnswer = 4; // the correct answer would be four in this case
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "Which drink helps to make the 'sunrise' in a Tequila Sunrise?"; // the third question that is asked to the user

                    button1.Text = "Apple cider"; // option 1
                    button2.Text = "Cherry brandy"; // option 2
                    button3.Text = "Grenadine"; // option 3
                    button4.Text = "Benedictine"; // option 4

                    correctAnswer = 3; // the correct answer would be four in this case
                    break;





                case 5:
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "Which type of wine should be used in a 'coq au vin'?"; // the third question that is asked to the user

                    button1.Text = "Red"; // option 1
                    button2.Text = "Sweet"; // option 2
                    button3.Text = "Rose"; // option 3
                    button4.Text = "White"; // option 4

                    correctAnswer = 1; // the correct answer would be four in this case
                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "Which of these wine-producing regions is NOT in South Australia?"; // the third question that is asked to the user

                    button1.Text = "Coonawarra"; // option 1
                    button2.Text = "Margaret River"; // option 2
                    button3.Text = "Barossa"; // option 3
                    button4.Text = "McLaren Vale"; // option 4

                    correctAnswer = 2; // the correct answer would be four in this case
                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "What is the South African snack 'biltong'?"; // the third question that is asked to the user

                    button1.Text = "Strips of dried meat"; // option 1
                    button2.Text = "Pastry dessert"; // option 2
                    button3.Text = "Vegetable relish"; // option 3
                    button4.Text = "Corn kernels"; // option 4

                    correctAnswer = 1; // the correct answer would be four in this case
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "Where does Edam cheese come from originally?"; // the third question that is asked to the user

                    button1.Text = "Netherlands"; // option 1
                    button2.Text = "Germany"; // option 2
                    button3.Text = "Denmark"; // option 3
                    button4.Text = "France"; // option 4

                    correctAnswer = 1; // the correct answer would be four in this case
                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "Which Spanish city does the waiter Manuel from TV's \"Fawlty Towers\" come from?"; // the third question that is asked to the user

                    button1.Text = "Madrid"; // option 1
                    button2.Text = "Seville"; // option 2
                    button3.Text = "Barcelona"; // option 3
                    button4.Text = "Pamplona"; // option 4

                    correctAnswer = 3; // the correct answer would be four in this case
                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources.images;

                    label1.Text = "What is a small section of garlic called?"; // the third question that is asked to the user

                    button1.Text = "Clove"; // option 1
                    button2.Text = "Peel"; // option 2
                    button3.Text = "Nip"; // option 3
                    button4.Text = "Piece"; // option 4

                    correctAnswer = 1; // the correct answer would be four in this case
                    break;


            }
        }

        

        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void namebox_TextChanged(object sender, EventArgs e)
        {
            string name = namebox.Text;
            namebox.Text = name;
            this.Show();
            
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
            questions = fileReader("Food and Drink.txt.txt");
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
