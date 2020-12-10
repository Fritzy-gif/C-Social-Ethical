using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fritzy_Serrano___FINAL_Multiple_Choice_Quiz
{
    public partial class Form3 : Form
    {
        //variables and what data type they are, they're all integers
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;

        public Form3()
        {
            InitializeComponent();


            //calling the function that asks questions
            askQuestion(questionNumber);

            //total amount of questions is 17
            totalQuestions = 17;
        }

        //event to check answer
        private void checkAnswerEvent(object sender, EventArgs e)
        {
            //variable for the sender -- used to check which object was the sender in the Windows form
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            //if the button that the user clicks is equal to the integer of the correct answer
            if (buttonTag == correctAnswer)
            {
                //then add 1 to the score
                score++;
            }

            //if the question number is equal to the total amount of questions (a.k.a. if the user is done with the quiz)
            if (questionNumber == totalQuestions)
            {
                //work out the percentage of questions that they got correct

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                //show a message box with the score and percentage
                //Environment.Newline begins a new line in the text
                //the System class 'Environment' allows the software dev to manipulate how the output appears
                MessageBox.Show(
                    "You have completed the quiz." + Environment.NewLine +
                    "You have answered " + score + " out of 17 questions correctly." + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to re-do quiz."
                    );

                //when the user presses ok reset values to 0 or to default
                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }

            //go to next question
            questionNumber++;
            //call on question for next question
            askQuestion(questionNumber);
        }

        //event to ask question
        private void askQuestion(int qnum)
        {

            //casewhere data structure that will randomly call on the questions
            switch (qnum)
            {
                //questions for 'inappropriate data structures, for example the year 2000 problem
                case 1:
                    questionLabel.Text = "What is the Y2K problem?"; //changes the question in each case
                    //the text property on the buttons change in each case 
                    A.Text = "Computers exploding in response to the year 2000";
                    B.Text = "A virus from the early 2000s";
                    C.Text = "A storage problem that caused computer miscalculations and crashes in the early 2000s";
                    D.Text = "A phishing issue from the early 2000s";

                    //records what is the correct answer 
                    //and if the user clicks a button
                    //and it is equal to the string in the Tag property
                    //it should call the checkAnswer() function
                    correctAnswer = 3;
                    //break is used to indicate the end of a case
                    break;

                //questions for 'computer malware such as viruses'
                case 2:
                    questionLabel.Text = "What is the definition of malware?";
                    A.Text = "Software that performs an uninvited task";
                    B.Text = "Software that detects malpractice";
                    C.Text = "Software that reads mail for the user";
                    D.Text = "An AI named Mal";

                    correctAnswer = 1;
                    break;

                case 3:
                    questionLabel.Text = "What are four different types of malware?";
                    A.Text = "Snakes, ladders worms and viruses";
                    B.Text = "Trojan horses, spyware, worms and viruses";
                    C.Text = "Horses, cats, worms and centipedes";
                    D.Text = "Firewalls, paradigms, worms and viruses";

                    correctAnswer = 2;
                    break;

                case 4:
                    questionLabel.Text = "What is a Trojan horse?";
                    A.Text = "A wooden horse";
                    B.Text = "Software that obtains the user's information without their knowledge";
                    C.Text = "A code that can replicate itself to cause increased damage to software systems";
                    D.Text = "Malware that is masked as legitimate software";

                    correctAnswer = 4;
                    break;

                case 5:
                    questionLabel.Text = "Which of the following is incorrect?";
                    A.Text = "Worms are a type of virus which aims to slow down a system";
                    B.Text = "Anti-virus, anti-malware, and anti-spyware utilities are used to detect and destroy malware";
                    C.Text = "Viruses replicate themselves in order to do more malicious processing";
                    D.Text = "Spyware is used by the government to obtain information about the users";

                    correctAnswer = 4;
                    break;
                case 6:
                    questionLabel.Text = "Which best describes a worm?";
                    A.Text = "Being downloaded as legitimate software in order to perform denial of service (DoS) attacks on certain websites";
                    B.Text = "Exploiting security flaws in the operating system in order to eventually consume the RAM and slow down the system";
                    C.Text = "To capture the user’s web browsing habits or personal information";
                    D.Text = "To extract encrypted files";

                    correctAnswer = 2;
                    break;

                // questions for 'reliance on software'
                case 7:
                    questionLabel.Text = "Which of the following statements are true?";
                    A.Text = "Government authorities such as the Tax Office and Social Security rely on software";
                    B.Text = "People will never rely on software";
                    C.Text = "People do not heavily rely on software presently";
                    D.Text = "The software development industry does not have a huge responsibility to ensure that software systems are reliable";

                    correctAnswer = 1;
                    break;
                case 8:
                    questionLabel.Text = "Which of the following industries would be impacted by the lack of software?";
                    A.Text = "The Retail Industry";
                    B.Text = "The Trade Industry";
                    C.Text = "The Manufacturing Industry";
                    D.Text = "All of the above";

                    correctAnswer = 4;
                    break;
                // questions for 'social networking'
                case 9:
                    questionLabel.Text = "What was the first recognised social networking site?";
                    A.Text = "Facebook";
                    B.Text = "SixDegrees.com";
                    C.Text = "Friendster";
                    D.Text = "MySpace";

                    correctAnswer = 2;
                    break;
                case 10:
                    questionLabel.Text = "What is the definition of a social network?";
                    A.Text = "A group of people who associate with each other";
                    B.Text = "A software that requires network that is powered by several people working on it 24/7";
                    C.Text = "A series of networks that work together to achieve a task";
                    D.Text = "Networks that are run by socialites";

                    correctAnswer = 1;
                    break;
                case 11:
                    questionLabel.Text = "What is a disadvantage of social networking?";
                    A.Text = "Easy reach of other people who are inaccessible for in-person communication";
                    B.Text = "Exposure for celebrities and businesses";
                    C.Text = "Provides another platform for harassment such as cyberbullying, " +
                        "stalking and theft of personal information";
                    D.Text = "Ease of spreading information across the world";

                    correctAnswer = 3;
                    break;
                // questions for 'cyber safety'
                case 12:
                    questionLabel.Text = "Which devices are at risk of cyber security issues?";
                    A.Text = "Laptops";
                    B.Text = "Mobile phones";
                    C.Text = "Game consoles";
                    D.Text = "All of the above";

                    correctAnswer = 4;
                    break;
                case 13:
                    questionLabel.Text = "What does being cyber safe mean?";
                    A.Text = "Observing the recommended practices and procedures to protect " +
                        "one's personal information when using the internet ";
                    B.Text = "To rest one's eyes after a long amount of screen time";
                    C.Text = "To be safe from electrocution from electronic devices";
                    D.Text = "Observing the recommended practices and procedures to maintain good health whilst using electronic device";

                    correctAnswer = 1;
                    break;
                case 14:
                    questionLabel.Text = "Which of the following is not a cyber safe practice and/or procedure?";
                    A.Text = "Regularly checking privacy settings";
                    B.Text = "Forwarding a message that is harassing someone to others";
                    C.Text = "Thinking before one posts something to the social networking site" +
                        " thus leaving a digital footprint behind";
                    D.Text = "Using anti-malware utilities";

                    correctAnswer = 2;
                    break;
                case 15:
                    questionLabel.Text = "What is a digital footprint?";
                    A.Text = "A password";
                    B.Text = "When all of one’s online information is collated allowing people " +
                        "such as future employers to build an impression of the user";
                    C.Text = "An anti-malware utility";
                    D.Text = "A website";

                    correctAnswer = 2;
                    break;
                //questions for 'huge amounts of information 
                //which may be unsupported, unverifiable, misleading or incorrect)
                //available through the internet'
                case 16:
                    questionLabel.Text = "What is not a reason that one should evaluate information available through the internet?";
                    A.Text = "It could be false information";
                    B.Text = "It could be outdated information";
                    C.Text = "It could be biased information";
                    D.Text = "It could be in another language";

                    correctAnswer = 4;
                    break;
                case 17:
                    questionLabel.Text = "Which of the following is something one should ask themself when evaluating information?";
                    A.Text = "What language was this supposed to be written for?";
                    B.Text = "What font should this person be using?";
                    C.Text = "Who is the author?";
                    D.Text = "How confident is the author in the information they have published?";

                    correctAnswer = 3;
                    break;
            }
        }
    }
}
