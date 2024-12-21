namespace ass4_final
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Demo
            #region loop statment
            //Console.WriteLine("1T");
            //Console.WriteLine("2");
            //Console.WriteLine("3");
            //Console.WriteLine("4");
            //Console.WriteLine("5");
            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{i}  T");
            //}


            #endregion

            #region For - foreach
            //  int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    if (Numbers[i] == 5)
            //    {
            //        //break; // will stop when [i]=5
            //        continue; // will skip [i]=5 and continue after 5
            //    }
            //    Console.WriteLine(Numbers[i]);


            //}
            //class implement interface IEnummrable
            //foreach--- for print only 
            //forloop faster than foreach because foreach work in copy of array 
            //foreach(int Number in Numbers)
            //{
            //    Console.WriteLine(Number);
            //    //Number+=10 --- invalid we cannot edit in number
            //    //But we can do this that doesnt mean we edit in value(we didnot reassign )
            //    Console.WriteLine(Number+ 10);
            //}

            #endregion


            #region while - Do While

            //dowhile if we dont know how many time to iterate
            //int number;
            //bool flag;
            //do

            //{

            //    Console.WriteLine("Enter Even Number");
            //  //  number = int.Parse(Console.ReadLine());
            //    flag = int.TryParse(Console.ReadLine(), out number);



            //} while (number%2==1 ||!flag);


            //Console.WriteLine($"{number} is even");

            //int number = 3;
            //bool flag = false;
            //while (number % 2 == 1 || !flag) {


            //    Console.WriteLine("Enter Even Number");
            //    flag = int.TryParse(Console.ReadLine(), out number);
            //}
            //Console.WriteLine($"{number} is even");


            #endregion

            #region string
            //class =>reference type
            //immutable data type[value cant be change]
            //array of chars
            //a h m e d
            // string name;
            //name = new string("ahmed");
            //   name = "ahmed"; //the same with previous line (syntax sugar ) because we usually use string

            //string name01 = "ahmed";
            //string name02 = "ahmed";
            ////load string --if more than one object have the same value it will be the same hash code ---name01,name02 point to the same value
            //Console.WriteLine($"name 01 HC:{name01.GetHashCode()}");
            //Console.WriteLine($"name 02 HC:{name02.GetHashCode()}");

            //string name01 = "ahmed";
            //string name02 = "ali";
            //Console.WriteLine($"name 01 HC:{name01.GetHashCode()}");
            //Console.WriteLine($"name 02 HC:{name02.GetHashCode()}");

            //name02 = name01;
            //Console.WriteLine($"name 01 HC:{name01.GetHashCode()}");
            //Console.WriteLine($"name 02 HC:{name02.GetHashCode()}");

            //name01 = "mostafa";
            //Console.WriteLine($"name 01 HC:{name01.GetHashCode()}");
            //Console.WriteLine($"name 02 HC:{name02.GetHashCode()}");

            //string message = "hello";
            //Console.WriteLine(message);
            //Console.WriteLine(message.GetHashCode());
            ////k2ny 3mlt object gded b arrary b size gdeda l2no immutable mb8yrsh fe elsize bta3o elsize bta3o sabt
            //message += "route";
            //Console.WriteLine(message);
            //Console.WriteLine(message.GetHashCode());



            #endregion
            #region string builder
            //linked list of characters -- mutable size
            //StringBuilder message;
            //message = new StringBuilder("ahmed");
            ////message = "ahmed";--- Invald (No syntax sugar)
            //Console.WriteLine(message);
            //Console.WriteLine(message.GetHashCode());
            //message.Append("route"); // --- append in the same object (mutable)

            #endregion

            #region stringBuilder Methods

            ////bst5dmo lw ana kol shwia 3arfa eny h8yr el value bta3t elstring yb2a ast5dm string builder lw msh h8yr yb2a string 
            //StringBuilder message=new StringBuilder("welcome");
            //message.Append("route");
            //message.AppendLine("salwa");// b ynzl satr fe el append elle ba3do
            //message.Append("mohammed");
            //Console.WriteLine(message);

            //message.Remove(0,7);//bta5od start index w el 3dd elle a2os ba3do
            //message.Insert(0, "hello");

            //int age = 10;
            //string name = "salwa";

            //message.AppendFormat("Name :{0},age :{1}", name, age);

            //message.AppendJoin("/", "salwa", "roshdy", "mohammed");// /spertator added after every ,
            //Console.WriteLine(message);

            #endregion
            #region Array 1 D
            //int[] Numbers = new int[3] { 1,2,3};
            // int[] Numbers = new int[] { 1, 2, 3 };
            //int[] Numbers =  { 1, 2, 3 };//synatx sugar
            // int[] Numbers = new int[3];
            //Numbers[0] = 1;
            //Numbers[0] = 2;
            //Numbers[0] = 3;
            //Console.WriteLine(Numbers[1])

            //for(int i = 0; i <= Numbers.Length; i++)
            //{
            //    Numbers[i] = i + 1;
            //}
            //for (int i = 0; i <= Numbers.Length; i++)
            //{
            //    Console.WriteLine( Numbers[i]) ;
            //}


            //for (int i = 0; i <= Numbers.Length; i++)
            //{
            //    Console.WriteLine($"enter element number{i + 1}");
            //    Numbers[i] = int.Parse(Console.ReadLine());

            //}
            //Console.WriteLine(Numbers.Length);
            //Console.WriteLine(Numbers.Rank);
            #endregion

            #region Array 2 D
            // int[,] Marks = new int[3, 5];//15  //4byte * 15=60
            // int[,] Marks = new int[3, 5] { { 1,2,3,4,5 } ,{10,20,30,40,50 },{10,20,30,40,50 }};
            // int[,] Marks = new int[3, 5];
            //Console.WriteLine(Marks.Length); //15
            //Console.WriteLine(Marks.Rank); //2d
            //Console.WriteLine(Marks.GetLength(0)); //number of rows
            //Console.WriteLine(Marks.GetLength(1)); //numbers of columns
            //bool flag;
            //for(int i=0; i < Marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"enter grade student ({i + 1})");
            //for(int k = 0; k < Marks.GetLength(1);/*k++*/)
            //    {
            //        Console.WriteLine($"enter grade subject ({k + 1})");
            //        // Marks[i, k] = int.Parse(Console.ReadLine());
            //        flag = int.TryParse(Console.ReadLine(), out Marks[i, k]);
            //        //if(flag && Marks[i,k]>=0)
            //        //{
            //        //    k++;
            //        //}

            //        k = flag && Marks[i, k] >= 0 ? ++k : k ;
            //    }
            //}

            //for (int i = 0; i <= Marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($" grade student ({i + 1})");
            //    for (int k = 0; k < Marks.GetLength(1); k++)
            //    {
            //        Console.WriteLine($" grade subject ({k + 1})");
            // Console.WriteLine(Marks[i,k]);
            //    }
            //}
            //for (int i = 0; i <= Marks.GetLength(0); i++)
            //{
            //    Console.WriteLine(Marks[i/Marks.GetLength(1),i%Marks.GetLength(1)]);

            //}
            #endregion
            #endregion


            #region Assignment

            #region 1 - Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.WriteLine("Enter Number");
            //int x;
            //bool flag = int.TryParse(Console.ReadLine(),out x);

            //if (flag && x >= 0)
            //{
            //    for (int i = 1; i <= x; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion

            #region 2 - Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //Console.WriteLine("Enter Number");
            //int x;
            //bool flag = int.TryParse(Console.ReadLine(), out x);
            //if (flag && x >= 0) {
            //    for (int i = 1; i <= 12; i++)
            //    {
            //        Console.WriteLine($"{x}*{i}={x*i}");
            //    }
            //}

            #endregion


            #region 3 - Write a program that allows to user to insert number then print all even numbers between 1 to this number

            //int x=-1;
            //bool flag=false; 
            //while (!flag || x < 0) //true && true --true  false &&false 0--false
            //{
            //    Console.WriteLine("Enter Number");
            //    flag = int.TryParse(Console.ReadLine(), out x);

            //    //Console.WriteLine(flag);

            //    //Console.WriteLine(x);
            //}

            //for (int i = 1; i <= x; i++)
            //   {
            //    if (i % 2 == 0) {
            //        Console.WriteLine(i);
            //    }

            //   }

            #endregion

            #region 4- Write a program that takes two integers then prints the power.

            //int x = -1;
            //int y = -1;
            //bool flagX = false;
            //bool flagY = false;
            //while (!flagX ||  x<0  ) 
            //{
            //    Console.WriteLine("Enter the first integer ");
            //    flagX = int.TryParse(Console.ReadLine(), out x);


            //}

            //while (!flagY || y < 0)
            //{

            //    Console.WriteLine("Enter the second integer ");
            //    flagY = int.TryParse(Console.ReadLine(), out y);

            //}
            //int result = 1;
            //Console.WriteLine("\n");
            //if (y > 0)
            //{
            //    for (int i = 1; i <= y; ++i)         

            //    {

            //        result *= x;            

            //    }

            //}
            //else if (y < 0)
            //{
            //    for (int i = -1; i >= y; --i)
            //    {
            //        result /= x;
            //    }
            //}

            //Console.WriteLine($"result is {result}");
            #endregion


            #region 5 - Write a program to allow the user to enter a string and print the REVERSE of it.

            //string str = Console.ReadLine();

            //string reverse = "";
            //for(int i = str.Length - 1; i >=0; i--)
            //{
            //    reverse += str[i];


            //}
            //Console.WriteLine(reverse);

            #endregion

            #region  6 - Write a program in C# Sharp to find prime numbers within a range of numbers.  

            //int   ctr, start, end; 

            //Console.WriteLine("******************************");  

            //Console.WriteLine("Input starting number of range: ");  
            //start = Convert.ToInt32(Console.ReadLine()); 

            //Console.WriteLine("Input ending number of range : ");
            //end = Convert.ToInt32(Console.ReadLine());  

            //Console.Write("The prime numbers between {0} and {1} are : ", start, end);  

            //for (int n = start; n <= end; n++)
            //{
            //    ctr = 0;  

            //    for (int i = 2; i <= n / 2; i++)
            //    {
            //        if (n % i == 0)
            //        {
            //            ctr++;  
            //            break;  
            //        }
            //    }

            //    if (ctr == 0 && n != 1)
            //    {
            //        Console.Write("{0} ", n);  
            //    }
            //}

            #endregion


            #region 7. Write a program in C# Sharp to convert a decimal number into binary without using an array. ??? reverse result

            //Console.WriteLine("Enter Number");

            //int x = int.Parse(Console.ReadLine());

            ////string s;
            //StringBuilder s = new StringBuilder();

            //while (x >= 1)
            //{
            //    s = s.Append(x % 2); 
            //    x = x / 2;


            //}
            //Console.WriteLine($"The Binary of 25 is {s}");


            #endregion

            #region 8 - .Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n. ?????
            //Console.WriteLine("Input a number:");
            //int n= Convert.ToInt32(Console.ReadLine());

            //var M = Enumerable.Range(0, n)
            //        .Select(i =>
            //            Enumerable.Repeat(0, n)
            //                .Select((z, j) => j == i ? 1 : 0) 
            //                .ToList()
            //        )
            //        .ToList();


            //foreach (var row in M)
            //{
            //    foreach (var element in row)
            //    {
            //        Console.Write(" " + element); 
            //    }
            //    Console.WriteLine(); 
            //}


            #endregion


            #region 9-Write C# program that Extract a substring from a given string. 

            //Console.WriteLine("Enter the string ");
            //string x = Console.ReadLine();
            //int strlength = x.Length;
            //char[] arr = x.ToCharArray(0, strlength);
            //Console.WriteLine("Enter the Position to strart extracting ");
            //int pos = int.Parse(Console.ReadLine());
            //Console.Write("Enter the length of substring :");
            //int length = int.Parse(Console.ReadLine());
            //int c=0;
            //Console.Write("The substring retrieved from the string is : ");
            //while (c < length)
            //{
            //    Console.Write(arr[pos + c - 1]); // Output each character of the substring
            //    c++;
            //}


            #endregion


            #region    10 - Write C# program that take two string variables and print them as one variable 
            //Console.WriteLine(" Enter the first string variable");
            //string x = Console.ReadLine();
            //Console.WriteLine(" Enter the second string variable");
            //string y = Console.ReadLine();
            //StringBuilder sum = new StringBuilder();
            //sum.Append(x);
            //sum.Append(y);
            //Console.WriteLine($"the result is {sum} ");
            #endregion


            #region 12 - Write a program in C# Sharp to find the sum of all elements of the array.
            //Console.WriteLine(" Enter the size of array ");
            // int range = int.Parse(Console.ReadLine());
            // Console.WriteLine(" Enter the array ");
            // int[] x = new int[range] ;
            // int sum = 0;
            // for(int i=0;i<=x.Length-1; i++)
            // {
            //     x[i] = int.Parse(Console.ReadLine());
            //     sum += x[i];

            // }

            //     Console.WriteLine($"the sum is {sum}");


            #endregion


            #region 13- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            //Console.WriteLine(" Enter the size of the first array ");
            //int range = int.Parse(Console.ReadLine());

            // int[] x = new int[range] ;

            //Console.WriteLine(" Enter the first array ");
            //for (int i = 0; i <= x.Length - 1; i++)
            //{
            //    x[i] = int.Parse(Console.ReadLine());


            //}
            //Console.WriteLine(" Enter the size of the second array ");
            //int range2 = int.Parse(Console.ReadLine());
            //int[] y = new int[range2];  

            //int sizeOfMerge = range + range2;
            //int[] merge=new int[sizeOfMerge];
            //Console.WriteLine(" Enter the second array ");
            //for (int i = 0; i <= y.Length - 1; i++)
            //{
            //    y[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i <= x.Length - 1; i++)
            //{
            //    merge[i] = x[i];
            //}

            //for ( int j = 0; j <= y.Length - 1; j++)
            //{

            //    merge[range] = y[j];
            //    range++;

            //}

            //int z;
            //for (int j = 0; j < merge.Length ; j++) //{3,4} {1,2} ={4,3,1,2}
            //{                                                          //0             
            //    for(int k = 0; k < merge.Length-1; k++)        //0
            //    {

            //         if (merge[k] >= merge[k + 1])              //4>3
            //        {
            //          z  =merge[k + 1];
            //           merge[k + 1] = merge[k];
            //            merge[k] = z;
            //        }


            //    }

            //}


            //Console.WriteLine("the third arr is ");

            //for (int j= 0; j<= merge.Length - 1;j++)
            //{
            //    Console.WriteLine(merge[j]);
            //}


            #endregion


            #region 14- Write a program in C# Sharp to count the frequency of each element of an array.
            //Console.WriteLine(" Enter the size of array ");
            //int range = int.Parse(Console.ReadLine());
            //int count = 0;
            //Console.WriteLine(" Enter the array ");
            //int[] x = new int[range];
            //int[] freq = new int[range];
            //for (int i = 0; i <= x.Length - 1; i++)
            //{
            //    x[i] = int.Parse(Console.ReadLine());
            //    freq[i] = -1;

            //}

            //for (int i = 0; i <=x.Length-1 ; i++)// x[0]=1
            //{
            //    for(int j=i+1; j <= x.Length-1; j++)
            //    {
            //        if (x[i] == x[j]) 
            //        {
            //            count++;
            //            freq[j] = 0;
            //        }
            //    }
            //    if (freq[i] != 0)  
            //    {
            //        freq[i] = count;  
            //    }


            //}

            //for (int i = 0; i <=x.Length-1; i++)
            //{
            //    if (freq[i] != 0) 
            //    {
            //        Console.Write("{0} occurs {1} times\n", x[i], freq[i]); 
            //    }
            //}


            #endregion

            #region 15 - Write a program in C# Sharp to find maximum and minimum element in an array

            //Console.WriteLine(" Enter the size of array ");
            //int range = int.Parse(Console.ReadLine());
            //int min=0;
            //int max=0;
            //Console.WriteLine(" Enter the array ");
            //int[] x = new int[range];
            //for (int i = 0; i <= x.Length - 1; i++)
            //{
            //    x[i] = int.Parse(Console.ReadLine());

            //}
            //max = x[0];           //5  
            //min = x[0];
            //for (int i = 0; i <= x.Length - 1; ++i) //{5,4,4,7,8 }
            //{

            //    if (x[i] > max) // x[0]=5>5    x[1]=4>5   x[2]=4>5  x[3]=7>5 max=7     x[4]=8>7
            //    {
            //        max = x[i];
            //    }
            //    if (x[i] < min) 
            //    {
            //        min = x[i];
            //    }

            //}
            //Console.WriteLine($"Maximum is {max}");
            //Console.WriteLine($"Minimum is {min}");

            #endregion

            #region 16 - Write a program in C# Sharp to find the second largest element in an array.
            //Console.WriteLine(" Enter the size of the  array ");
            //int range = int.Parse(Console.ReadLine());

            //int[] x = new int[range];

            //Console.WriteLine(" Enter the  array ");
            //for (int i = 0; i <= x.Length - 1; i++)
            //{
            //    x[i] = int.Parse(Console.ReadLine());


            //}

            //int z;
            //for (int j = 0; j < x.Length; j++) //{3,4} {1,2} ={4,3,1,2}
            //{                                                          //0             
            //    for (int k = 0; k < x.Length - 1; k++)        //0
            //    {

            //        if (x[k] >= x[k + 1])              //4>3
            //        {
            //            z = x[k + 1];
            //            x[k + 1] = x[k];
            //            x[k] = z;
            //        }


            //    }

            //}

            //int y = x.Length - 2;
            //Console.WriteLine($"the second largest element is {x[y]}");





            #endregion

            #region  17 -.Consider an Array of Integer values with size N, having values as his Example  ?????
            //Console.WriteLine(" Enter the size of the  array ");
            //int range = int.Parse(Console.ReadLine());

            //int[] x = new int[range];

            //Console.WriteLine(" Enter the  array ");
            //for (int i = 0; i <= x.Length - 1; i++)
            //{
            //    x[i] = int.Parse(Console.ReadLine());


            //}

            //for (int j = 0; j <= x.Length-1; j++)
            //{
            //    int max_dist = 0;
            //    int first = x[j];
            //    for (int secondelement = j + 1; secondelement <= x.Length-1; secondelement++)
            //    {
            //        int second = x[secondelement];
            //        if (first == second)
            //        {
            //            if (max_dist < secondelement - j)
            //            {
            //                max_dist = secondelement - j;
            //            }
            //            first = second;
            //        }
            //    }
            //    System.Console.WriteLine(first + " " + max_dist);
            //}


            #endregion

            #region 18- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.


            //Console.WriteLine("enter Number of rows of first array");
            //int x1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter Number of columns of first array");
            //int y1 = int.Parse(Console.ReadLine());
            //int[,] arr1 = new int[x1, y1];

            //bool flag1;

            //Console.WriteLine("enter first array");

            //for (int i = 0; i < x1; i++)
            //{
            //    Console.WriteLine($"enter rows ({i + 1})");
            //    for (int k = 0; k < y1;/*k++*/)
            //    {
            //        Console.WriteLine($"enter columns ({k + 1})");

            //        flag1 = int.TryParse(Console.ReadLine(), out arr1[i, k]);
            //        if (flag1 && arr1[i, k] >= 0)
            //        {
            //            k++;
            //        }

            //    }
            //}


            //int[,] arr2 = new int[x1, y1];

            //for (int i = 0; i < x1; i++)
            //{

            //    for (int k = 0; k < y1;k++)
            //    {

            //        arr2[i, k] = arr1[i, k];

            //    }
            //}
            //Console.WriteLine("************************************");
            //Console.WriteLine("The second Array ");
            //for (int i = 0; i < x1; i++)
            //{
            //    Console.WriteLine($" row ({i + 1})");
            //    for (int k = 0; k < y1; k++)
            //    {
            //        Console.WriteLine($" col ({k + 1})");

            //        Console.WriteLine(arr2[i, k]);

            //    }
            //}



            #endregion

            #region 19- Write a Program to Print One Dimensional Array in Reverse Order
            Console.WriteLine(" Enter the size of array ");
            int range = int.Parse(Console.ReadLine());

            Console.WriteLine(" Enter the array ");
            int[] x = new int[range];
            for (int i = 0; i <= x.Length - 1; i++)
            {
                x[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("the array in Reverse Order is ");
            for (int i = x.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(x[i]);
            }

            #endregion


            #endregion
        }
    }
}
