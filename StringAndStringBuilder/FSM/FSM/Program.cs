using System;

namespace NANO
{
    class Program
    {
        enum State { NULL, N, NA, NAN, NANO };

        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            State state = State.NULL;
            bool isFound = false;

            input.ToUpper();

            foreach (var ch in input)
            {
                switch (state)
                {
                    case State.NULL:
                        if (ch == 'N')
                        {
                            state = State.N;
                        }
                        break;

                    case State.N:
                        if (ch == 'A')
                        {
                            state = State.NA;
                        }
                        else if (ch == 'N')
                        {

                        }
                        else
                        {
                            state = State.NULL;
                        }
                        break;

                    case State.NA:
                        if (ch == 'N')
                        {
                            state = State.NAN;
                        }
                        else
                        {
                            state = State.NULL;
                        }
                        break;

                    case State.NAN:
                        if (ch == 'O')
                        {
                            state = State.NANO;
                            isFound = true;
                        }
                        else if (ch == 'A')
                        {
                            state = State.NA;
                        }
                        else if (ch == 'N')
                        {
                            state = State.N;
                        }

                        else
                        {
                            state = State.NULL;
                        }
                        break;

                    case State.NANO:
                        if (ch == 'N')
                        {
                            state = State.N;
                        }
                        else
                        {
                            state = State.NULL;
                        }
                        break;
                }
            }

            Console.WriteLine(isFound);

            if (isFound)
                Console.WriteLine(CountNANO(input));
        }

        static int CountNANO(string text)
        {
            int count = 0;
            State state = State.NULL;

            text.ToUpper();

            foreach (var ch in text)
            {
                switch (state)
                {
                    case State.NULL:
                        if (ch == 'N')
                        {
                            state = State.N;
                        }
                        break;

                    case State.N:
                        if (ch == 'A')
                        {
                            state = State.NA;
                        }
                        else if (ch == 'N')
                        {
                            
                        }
                        else
                        {
                            state = State.NULL;
                        }
                        break;

                    case State.NA:
                        if (ch == 'N')
                        {
                            state = State.NAN;
                        }
                        else
                        {
                            state = State.NULL;
                        }
                        break;

                    case State.NAN:
                        if (ch == 'O')
                        {
                            state = State.NANO;
                            count++;
                        }
                        else if (ch == 'A')
                        {
                            state = State.NA;
                        }
                        else if (ch == 'N')
                        {
                            state = State.N;
                        }

                        else
                        {
                            state = State.NULL;
                        }
                        break;

                    case State.NANO:
                        if (ch == 'N')
                        {
                            state = State.N;
                        }
                        else
                        {
                            state = State.NULL;
                        }
                        break;
                }
            }
            return count;
        }

        
        
    }
}
