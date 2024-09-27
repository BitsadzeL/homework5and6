using System.ComponentModel.DataAnnotations;

namespace homework5and6
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //#5.1
            string text=Console.ReadLine().Trim();
            string[] sentences = text.Split('.');
            for (int i = 0; i < sentences.Length; i++) 
            {
                sentences[i] = sentences[i].Trim();
            }

            for (int i = 0; i < sentences.Length; i++) 
            {
                sentences[i] = char.ToUpper(sentences[i][0]) + sentences[i].Substring(1);
            }

            string result = string.Join(". ", sentences);
            Console.WriteLine(result);


            //#6.1
            //Console.WriteLine("Enter sentence:");
            //string text=Console.ReadLine().ToLower();
            //Console.WriteLine("Enter symbol to count:");
            //char symbol = Convert.ToChar(Console.ReadLine().ToLower());
            //Console.WriteLine("There is "+CountCharacters(text,symbol)+" "+symbol); 

            //#6.2
            //int[] arr=new int[10];
            //Random random = new Random();
            //for(int i=0;i<arr.Length; i++) { arr[i]= random.Next(0,101); }
            //for (int i = 0; i < arr.Length; i++) { Console.WriteLine(arr[i]); }
            //Console.WriteLine("Sum of the array is: "+SumOfArr(arr));



            //#6.3
            //int[] arr = new int[10];
            //Random random = new Random();
            //for (int i = 0; i < arr.Length; i++) { arr[i] = random.Next(0, 101); }
            //for (int i = 0; i < arr.Length; i++) { Console.WriteLine(arr[i]); }
            //Console.WriteLine("Sum of the odd elements of the array is: " + SumOfOdds(arr));


            //#6.4
            //int a=Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Sum is: "+Sum(a,b));


            //#6.5
            //int[] arr = new int[10];
            //Random random = new Random();
            //for (int i = 0; i < arr.Length; i++) { arr[i] = random.Next(0, 101); }
            //for (int i = 0; i < arr.Length; i++) { Console.WriteLine(arr[i]); }
            //Console.WriteLine("Maximum: " + FindMaxInArray(arr));



            //#6.6
            //int[] arr = new int[10];
            //Random random = new Random();
            //for (int i = 0; i < arr.Length; i++) { arr[i] = random.Next(0, 101); }
            //Console.Write("Enter number to search: ");
            //int number=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Element is on position: "+FindElement(arr,number));


            //#6.7
            //int[] arr = new int[10];
            //Random random = new Random();
            //for (int i = 0; i < arr.Length; i++) { arr[i] = random.Next(0, 101); }
            //Sort(arr);



            //#6.8
            //Console.WriteLine("Enter sentence:");
            //string text = Console.ReadLine().ToLower();
            //Console.WriteLine("Enter symbol to search and find out if it contains:");
            //char symbol = Convert.ToChar(Console.ReadLine().ToLower());
            //Console.WriteLine("Found symbol in the string: "+ Contains(text,symbol));



            //#6.9
            //Console.WriteLine("Enter sentence:");
            //string text = Console.ReadLine().ToLower();
            //Console.WriteLine("Enter symbol to check:");
            //char symbol = Convert.ToChar(Console.ReadLine().ToLower());
            //Console.WriteLine("Every symbol equals to the "+symbol+": " + AreAllSame(text, symbol));









            //#6.1
            static int CountCharacters(string s, char c)
            {
                int count = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if(s[i] == c)
                    {
                        count++;
                    }
                }
                return count;
            }



            //#6.2
            static int SumOfArr(int[] a)
            {
                int sum = 0;
                for(int i=0; i < a.Length; i++)
                {
                    sum += a[i];
                }
                return sum;

            }

            //#6.3
            static int SumOfOdds(int[] a)
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i]%2 != 0)
                    {
                        sum += a[i];
                    }
                }

                return sum;
            }


            //#6.4
            static int Sum(int x, int y)
            {
                return x + y;
            }


            //#6.5
            static int FindMaxInArray(int[] arr)
            {
                int max = arr[0];

                for(int i = 1; i < arr.Length; i++)
                {
                    if (arr[i]>max)
                    {
                        max = arr[i];
                        
                    }
                }

                return max;
            }



            //#6.6
            static int FindElement(int[] arr, int a)
            {
                int index = -1;
                for(int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == a)
                    {
                        index = i;
                        break;
                    }
                }
                return index;
            }


            //#6.7
            static void Sort(int[] arr)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    int min_idx = i;
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[j] < arr[min_idx])
                            min_idx = j;
                    }


                    int temp = arr[min_idx];
                    arr[min_idx] = arr[i];
                    arr[i] = temp;
                }

                for (int i = 0; i < arr.Length; i++) { Console.WriteLine(arr[i]); }

            }


            //#6.8
            static bool Contains(string s, char c)
            {
                bool found=false;

                for(int i = 0; i < s.Length; i++)
                {
                    if(s[i] == c)
                    {
                        found = true;
                        break;
                    }
                }

                return found;

            }


            //#6.9
            static bool AreAllSame(string s, char c)
            {
                bool same = true;

                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] != c)
                    {
                        same = false;
                        break;
                    }
                }

                return same;

            }
        }
    }
}
