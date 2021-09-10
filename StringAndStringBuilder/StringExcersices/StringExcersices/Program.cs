using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace StringExcersices
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] textFilterArray = { "love", "c#"};

            //ReverseString("svetlina");
            //CheckBrackets("(1-2))");
            //CheckOccurences("We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.", "in");
            //Capitals("We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.");
            //FillTo20Characters("apple");
            //ConvertToUnicode("Nakov");
            XORCipher("Nakov", "ab");
            //CheckWordOccurences("We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.", "in");
            //TextFilter("I love c#", textFilterArray);
            //NumberFormat("100");
            //WebsiteUrl("http://www.devbg.org/forum/index.php");
            //ReverseTheWords("C# is not C++ and PHP is not Delphi");
            //UserInputDictionary();
            //ReplaceHyperLinks(@"<a href=""www.devbg.org"">our forum</a>");
            //CalculateDays("3.03.2004", "27.02.2006");
            //CalculateDateAfterTime("3.03.2004 23:30:30");
            //FindEmailAddresses("Please contact us by phone (+359 222 222 222) or by email at example@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @softuni.bg.com. Neither this: a@a.b.");
            //FindDates("I was born at 14.06.1980. My sister was born at 3.7.1984. In 5/1999 I graduated my high school. The law says (see section 7.3.12) that we are allowed to do this (section 7.4.2.9).");
            //FindPalindrome("ABBA lamal not dog exe");
            //CountLetters("hello world");
            //CountWords("hello world hello galaxy hello universe");
            //ShortenRepeatingLetters("aaaaaaaabc");
            //PrintAlphabetically("cheese, bear, apple");
            //HTMLCompiler(@"<html><title>Telerik Academyy</title><body><p><a href=""https://softuni.bg"">Telerik Academy</a> aims to provide free real - world practical training for young people who want to turn into skillful.NET software engineers.</p></body></html>");
        }

        //2
        static void ReverseString(string inputString)
        {
            StringBuilder reversedString = new StringBuilder(inputString.Length);

            for (int i = inputString.Length - 1; i >= 0; i--)
                reversedString.Append(inputString[i]);

            Console.WriteLine(reversedString);
        }

        //3
        static void CheckBrackets(string input)
        {
            int openingBracketCount = 0;
            int closingBrackedCount = 0;
            foreach (char character in input)
            {
                switch (character)
                {
                    case '(':
                        openingBracketCount++;
                        break;
                    case ')':
                        closingBrackedCount++;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(openingBracketCount == closingBrackedCount);
        }

        //5
        /*/
        static void CheckOccurences(string input, string keyword)
        {
            int index = input.IndexOf(keyword);
            int count = 0;

            while (index != -1)
            {
                count++;
                index = input.IndexOf(keyword, index + 1);
            }

            Console.WriteLine(count);
        }
        /*/
        static void CheckOccurences(string input, string keyword)
        {
            MatchCollection matches = Regex.Matches(input.ToLower(), keyword);

            Console.WriteLine(matches.Count);
        }

        //6
        static void Capitals(string input)
        {
            Regex expression = new Regex(@"<upcase>([a-zA-z ]+)<\/upcase>");

            Console.WriteLine(expression.Replace(input, MatchEvaluatorFor6));
        }

        static string MatchEvaluatorFor6(Match match)
        {
            return match.Groups[1].Value.ToUpper();
        }

        //7
        static void FillTo20Characters(string input)
        {
            StringBuilder text = new StringBuilder(20);
            text.Append(input);

            int len = 20 - text.Length;

            for (int i = 1; i <= len; i++)
            {
                text.Append('*');
            }

            Console.WriteLine(text);
        }

        //8
        static void ConvertToUnicode(string input)
        {
            var result = input.Select(x => $"U+{Convert.ToUInt16(x):X4}").ToList();
            result.ForEach(x => Console.Write($@"\{x}"));;
        }

        //9 UNICODE
        static void XORCipher(string input, string cipher)
        {
            List<char> result = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                result.Add(Convert.ToChar(input[i] ^ cipher[i % cipher.Length]));
            }

            result.ForEach(x => Console.Write($"\\u{Convert.ToUInt16(x):X4}"));
        }

        //10
        static void CheckWordOccurences(string input, string keyword)
        {
            string[] words = input.Split();
            int matches = 0;

            foreach (string word in words)
            {
                if (word == keyword)
                    matches++;
            }

            Console.WriteLine(matches);
        }

        //11
        static void TextFilter(string input, string[] bannedWords)
        {
            foreach (string word in bannedWords)
                input = Regex.Replace(input, $"{word}", new string('*', word.Length));

            Console.WriteLine(input);
        }

        //12
        static void NumberFormat(string input)
        {
            double inputNumber = double.Parse(input);
            int pow = 0;

            Console.Write(new string(' ', 15 - input.Length));
            Console.WriteLine(input);

            Console.Write(new string(' ', 15 - Convert.ToInt32(input).ToString("X").Length));
            Console.WriteLine(Convert.ToInt32(input).ToString("X"));

            Console.Write(new string(' ', 14 - input.Length));
            Console.WriteLine(input + "%");

            Console.Write(new string(' ', 14 - input.Length));
            Console.WriteLine(input + "$");

            while (inputNumber >= 10)
            {
                inputNumber /= 10;
                pow++;
            }
            Console.Write(new string(' ', 15 - $"{inputNumber}*10^{pow}".Length));
            Console.WriteLine($"{inputNumber}*10^{pow}");
        }

        //13
        static void WebsiteUrl(string input)
        {
            Regex expression = new Regex(@"(?<protocol>[a-z]+):\/\/(?<server>www\.[a-zA-Z]+\.[a-z]{2,3})(?<resource>(\/.+)+)");
            if (expression.IsMatch(input))
            {
                Match url = expression.Match(input);

                Console.WriteLine($"[protocol] = {url.Groups["protocol"]}\n" +
                    $"[server] = {url.Groups["server"]}\n" +
                    $"[resource] = {url.Groups["resource"]}");
            }
        }

        //14
        static void ReverseTheWords(string input)
        {
            List<string> sentence = input.Split().ToList();
            sentence.Reverse();

            Console.WriteLine(String.Join(" ", sentence));
        }

        //15
        static void UserInputDictionary()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add(".NET", "platform for applications from Microsoft");
            dictionary.Add("CLR", "managed execution environment for .NET");
            dictionary.Add("namespace", "hierarchical organization of classes");

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                    break;

                if (dictionary.ContainsKey(input))
                    Console.WriteLine(dictionary[input]);
                else
                    Console.WriteLine("Word is Missing!");
            }
        }

        //16
        static void ReplaceHyperLinks(string input)
        {
            Regex expression = new Regex(@"<a href=""(.+)"">(.+)<\/a>");

            if (expression.IsMatch(input))
            {
                Console.WriteLine(expression.Replace(input, $"[URL={"$1"}]{"$2"}[/URL]"));
                //Console.WriteLine(firstPart.Replace(input, MatchEvaluatorFor16));
            }
        }

        private static string MatchEvaluatorFor16(Match m)
        {
            string url = m.Groups["url"].Value;
            string text = m.Groups["text"].Value;
            return $"[URL={url}]{text}[/URL]";
        }

        //17
        static void CalculateDays(string inputDateOne, string inputDateTwo)
        {
            Match matchOne = Regex.Match(inputDateOne, @"(?<days>[\d]{1,2}).(?<months>[0|1][0-9]).(?<year>[\d]{4})");
            Match matchTwo = Regex.Match(inputDateTwo, @"(?<days>[\d]{1,2}).(?<months>[0|1][0-9]).(?<year>[\d]{4})");

            DateTime firstDate = new DateTime(int.Parse(matchOne.Groups["year"].Value), int.Parse(matchOne.Groups["months"].Value), int.Parse(matchOne.Groups["days"].Value));
            DateTime secondDate = new DateTime(int.Parse(matchTwo.Groups["year"].Value), int.Parse(matchTwo.Groups["months"].Value), int.Parse(matchTwo.Groups["days"].Value));

            Console.WriteLine(Math.Abs((firstDate - secondDate).TotalDays));
        }

        //18
        static void CalculateDateAfterTime(string inputDate)
        {
            Match match = Regex.Match(inputDate, @"(?<days>[\d]{1,2}).(?<months>[0|1][0-9]).(?<year>[\d]{4}) (?<hour>[0-2][0-9]):(?<minutes>[0-5][0-9]):(?<seconds>[0-5][0-9])");

            DateTime date = new DateTime(int.Parse(match.Groups["year"].Value), int.Parse(match.Groups["months"].Value), int.Parse(match.Groups["days"].Value), int.Parse(match.Groups["hour"].Value), int.Parse(match.Groups["minutes"].Value), int.Parse(match.Groups["seconds"].Value));
            Console.WriteLine(date.AddHours(6).AddMinutes(30));
        
        }

        //19
        static void FindEmailAddresses(string input)
        {
            MatchCollection emails = Regex.Matches(input, @"[a-zA-Z.-_\d]+\@[a-z-_]+\.[a-z]{2,3}");
            Console.WriteLine(String.Join(", ", emails));
        }

        //20
        static void FindDates(string input)
        {
            MatchCollection emails = Regex.Matches(input, @"([\d]{1,2}).([\d]{1,2}).([\d]{4})");
            Console.WriteLine(String.Join(", ", emails));
        }

        //21
        static void FindPalindrome(string input)
        {
            string[] words = input.Split();

            foreach (string word in words)
            {
                char[] reversedWord = word.ToCharArray();

                Array.Reverse(reversedWord);

                if (word == String.Join("", reversedWord))
                    Console.WriteLine(word);
            }
        }

        //22
        static void CountLetters(string input)
        {
            Dictionary<char, int> letterCount = new Dictionary<char, int>();

            foreach (char letter in input)
            {
                if (letterCount.ContainsKey(letter))
                    letterCount[letter] += 1;

                else if (letter != ' ')
                    letterCount.Add(letter, 1);
            }

            foreach (char letter in letterCount.Keys.OrderBy(x => x))
            {
                Console.WriteLine($"{letter} - {letterCount[letter]}");
            }
        }

        //23
        static void CountWords(string input)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            string[] wordsList = input.Split();

            foreach (string word in wordsList)
            {
                if (wordCount.ContainsKey(word))
                    wordCount[word] += 1;

                else 
                    wordCount.Add(word, 1);
            }

            foreach (string word in wordCount.Keys.OrderBy(x => x))
            {
                Console.WriteLine($"{word} - {wordCount[word]}");
            }
        }

        //24
        static void ShortenRepeatingLetters(string input)
        {
            Console.WriteLine(Regex.Replace(input, @"([a-z])\1+", "$1"));
        }

        //25
        static void PrintAlphabetically(string input)
        {
            string[] inputArray = input.Split(", ");

            foreach (string word in inputArray.OrderBy(x => x))
            {
                Console.WriteLine(word);
            }
        }
        
        //26
        
        static void HTMLCompiler(string input)
        {
            input = Regex.Replace(input, @"<title>(.+)</title>", "Title: $1\n");
            input = Regex.Replace(input, @"<body>(.+)</body>", "Body: \n$1");
            input = Regex.Replace(input, @"<[^>]+>|</[^>]+>", "");
            Console.WriteLine(input);
        }
    }
}
