namespace seriesOfNumbers
{

class Program

        {
            static List<int> SeriesInput = new List<int>([12, 34, 655, 55]);
            static bool runing = true;

            static void Main(string[] args)
            {

                bool valid = ValidInput(SeriesInput);

                while (runing)
                {
                    WriteMenu();
                }

            }










            //  build a menu 
            static bool ValidInput(List<int> input)
            {
                if (input.Count < 3)
                {
                    return false;
                }
                else
                    foreach (int s in input)
                    {
                        if (!(s < 0))
                        {
                            return false;
                        }
                    }
                return true;
            }


            // keep the program alive 
            static void WriteMenu()
            {
                do
                {


                    Console.WriteLine("          Please select one of the options      ");
                    Console.WriteLine("1 - enter a new series \n press q to send !!");
                    Console.WriteLine("2 - print the series as is");
                    Console.WriteLine("3 - print the series revers");
                    Console.WriteLine("4 - print sorted series ");
                    Console.WriteLine("5 - find the max number in the series");
                    Console.WriteLine("6 - find the min number ");
                    Console.WriteLine("7 - find the average of the series");
                    Console.WriteLine("8 - number of elents in the series");
                    Console.WriteLine("9 - sum of the elements");
                    Console.WriteLine("10 - exit");
                    string chois = Console.ReadLine();

                    switch (chois)
                    {
                        case "1":
                            GetNewseries();
                            break;

                        case "2":
                            PrintInput(SeriesInput);
                            break;

                        case "3":
                            PrintRevers(SeriesInput);
                            break;

                        case "4":
                            PrintSort(SeriesInput);
                            break;

                        case "5":
                            PrintMax(SeriesInput);
                            break;

                        case "6":
                            PrintMin(SeriesInput);
                            break;

                        case "7":
                            PrintAverage(SeriesInput);
                            break;

                        case "8":
                            Printlen(SeriesInput);
                            break;

                        case "9":
                            PrintSum(SeriesInput);
                            break;

                        case "10":
                            Console.WriteLine("see you 👋 ");
                            runing = false;
                            break;
                        default:
                            Console.WriteLine("invalid choise: choose again");
                            break;

                    }
                }
                while (runing);
            }




            //get new input - case 1
            static void GetNewseries()
            {
                Console.WriteLine("please enter series of positive numbers");

                string new_series = Console.ReadLine();
                new_series.Split();
                SeriesInput = ConvertToIntList(new_series);


            }


            // convert to int list 
            static List<int> ConvertToIntList(string input)
            {
                List<int> int_list = new List<int>();

                foreach (string s in input.Split())
                {
                    if (s != " ")
                    {
                        try
                        {
                            int num = int.Parse(s);
                            int_list.Add(num);
                        }
                        catch
                        {
                            Console.WriteLine("please enter series of positive numbers");
                        }
                    }
                    else
                    {
                        Console.WriteLine("eeeeeeeeeeeeeee");
                    }
                }

                return int_list;
            }


            // write input - case 2
            static void PrintInput(List<int> input)
            {
                foreach (int num in input)
                {
                    Console.Write(num + " ");
                }
            }


            // print revers - case 3
            static void PrintRevers(List<int> input)
            {
                int last = input.Count - 1;
                for (int i = last; i >= 0; i--)
                {
                    Console.Write(input[i] + ",");
                }
                Console.WriteLine();
            }


            // print sort - case 4
            static void PrintSort(List<int> input)
            {
                List<int> SortedList = new List<int>(input);
                SortedList.Sort();
                Console.Write("here the series in order - \n");
                foreach (int i in SortedList)
                {
                    Console.Write(i + " ");
                }
            }


            // print max - case 5
            static void PrintMax(List<int> input)
            {
                int max = 0;
                foreach (int chr in input)
                {
                    if (chr > max)
                    {
                        max = chr;
                    }
                }
                Console.WriteLine(max + "  is the bigger number in the series");
            }


            // print min - case 6
            static void PrintMin(List<int> input)
            {
                int min = input.Max();
                foreach (int num in input)
                {
                    if (num < min)
                    {
                        min = num;
                    }
                }
                Console.WriteLine(min + " - is the minimum number in your series");
            }


            // print average - case 7
            static void PrintAverage(List<int> input)
            {
                int average = 0;
                foreach (int num in input)
                {
                    average += num;
                }
                average /= input.Count;
                Console.WriteLine("the average of your series is - " + average);
            }


            // print lengh of list - case 8
            static void Printlen(List<int> input)
            {
                int len = 0;
                for (int i = 0; i < input.Count; i++)
                    len += 1;
                Console.WriteLine("you have " + len + " in your series");

            }


            //  print sum of list - case 9 
            static void PrintSum(List<int> input)
            {
                int sum = 0;
                foreach (int num in input)
                {
                    sum += num;
                }
                Console.WriteLine("the sum of all your series is - " + sum);
            }



            // convert to int 
            static int ConverttoInt(string[] input)
            {
                return 1;
            }




            /*
        // cases 
        static void CasesToChoise(string chois)
        {

            switch (chois)
            {
                case "1":
                        GetNewseries();
                    break;

                case "2":
                    PrintInput(SeriesInput);
                    break;

                case "3":
                    PrintRevers(SeriesInput);
                    break;

                case "4":
                    PrintSort(SeriesInput);
                    break;

                case "5":
                    PrintMax(SeriesInput);
                    break;

                case "6":
                    PrintMin(SeriesInput);
                    break;

                case "7":
                    PrintAverage(SeriesInput);
                    break;

                case "8":
                    Printlen(SeriesInput);
                    break;

                case "9":
                    PrintSum(SeriesInput);
                    break;

                case "10":
                    Console.WriteLine("see you 👋");
                    break;
                default:
                    Console.WriteLine("invalid choise: choose again");
                    break;
            }
            }*/


            //    List<string> input_list = new List<string>();

            //    SeriesInput.Clear();

            //        while (true)
            //        {
            //            string NewChoise = Console.ReadLine();

            //            if (NewChoise == "q")
            //              {
            //                input_list.Add(NewChoise);
            //                return ConvertToIntList(input_list);
            //              }
            //            else
            //{
            //    input_list.Add(NewChoise);

            //}
            //}
        }
    }
    