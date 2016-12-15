using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiddleTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string riddle1 = "What begins with a T, ends with T and has T in it?";
            string riddle2 = "What is big and yellow and comes in the morning, to brighten mum's day?";

            string ans1 = "teapot";
            string ans2 = "schoolbus";

            string userAns1 = "";
            string userAns2 = "";

            bool input1 = false;
            bool input2 = false;

            int points = 0;
            int chances1 = 0;
            int chances2 = 0;

            do
            {
                Console.WriteLine(riddle1);
                userAns1 = Console.ReadLine().ToLower();

                //Correct Answer 1
                if (userAns1 == ans1)
                {
                    //break the loop
                    Console.WriteLine("Congratulations! You have answered the first riddle correctly. You gain one point");
                    points += 1;
                    input1 = true;
                }
                else
                {
                    chances1 += 1;
                    //Answer is wrong now what?
                    Console.WriteLine("You're answer is wrong. You have " + (3 - chances1) + " chance(s) left witht the first riddle.");
                }
                    
                Console.WriteLine("Do you want to continue? (y/n)");
                string cont = Console.ReadLine().ToLower();

                //read their choice
                if (cont == "y")
                {
                    continue;
                }
                else
                {
                    break;
                }

            } while (input1 != true && chances1 != 3) ;


            while (input2 != true && chances2 != 3)
            {
                //Read riddle2
                Console.WriteLine(riddle2);
                //Take answer2
                userAns2 = Console.ReadLine().ToLower();

                //Answer 2 is correct
                if (userAns2 == ans2)
                {
                    Console.WriteLine("Congratulations! You have answered the second riddle correctly. You gain one point.");
                    points += 1;
                    //Break loop
                    input2 = true;
                }
                else
                {
                    chances2 += 1;
                    //Answer is wrong, now what?
                    Console.WriteLine("You're answer is wrong. You have " + (3 - chances2) + " chance(s) left. Do you want to continue? (y/n)");
                    string cont = Console.ReadLine().ToLower();

                    if (cont == "y")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Console.WriteLine("The total number of points you have gained is: " + points);
        }
    }
}
