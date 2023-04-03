using System;

namespace GolfAndSpaResort
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int lineCount = 1;

            while (input[0] != "End")
            {
                if (input.Length == 4)
                {
                    Employee inputEmpoyee = new Employee(input[0], input[1], input[2], int.Parse(input[3]));

                    inputEmpoyee.StartWorkingDay();
                }
                else if (input.Length == 3)
                {
                    Member inputMember = new Member(input[0], input[1], int.Parse(input[2]));

                    if (lineCount % 2 == 0)
                        inputMember.GetMemberCard("fitness");

                    else
                        inputMember.GetMemberCard("spa");
                }
                else if (input.Length == 2)
                {
                    Guest inputGuest = new Guest(input[0], input[1]);

                    inputGuest.NewGuest();
                }

                input = Console.ReadLine().Split();
                lineCount++;
            }
        }
    }
}
