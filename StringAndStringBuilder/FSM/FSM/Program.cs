using System;

namespace FSM
{
    class Program
    {
        enum State { NULL, S, SO, SOS, N, NA, NAN, NANO };


        static bool FindNANO(string text)
        {
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
                            return true;
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

            return false;
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

        
        static void Main(string[] args)
        {
            Console.WriteLine(CountNANO("NANNANO"));
        }
    }
}
