
//30. Write a C# Sharp program to create a string like "aababcabcd" from a given string "abcd".
//Console.WriteLine(test("abc"));
//string test(string str)
//{
//	string result = string.Empty;
//	for (int i = 0; i < str.Length; i++)
//	{
//        result += str.Substring(0, i + 1);
//	}
//	return result;
//}
//---------------------------------------------------------------------------
// Write a C# Sharp program to create a string like "aababcabcd" from a given string "abcd".
//----------------------------------------------------------------------------------------------------------------------------------------------------------------------
//20. Write a C# Sharp program to check whether two given integers are in the range 40..50 inclusive, or they are both in the range 50..60 inclusive.
//Console.WriteLine(test(78, 95));
//Console.WriteLine(test(25, 35));
//Console.WriteLine(test(40, 50));
//Console.WriteLine(test(55, 60));
//Console.ReadLine();


//         bool test(int x, int y)
//{
//    return (x >= 40 && x <= 50 && y >= 40 && y <= 50) || (x >= 50 && x <= 60 && y >= 50 && y <= 60);
//}
//------------------------------------------------------------------------------------------------------------------------------------------------------
//Write a C# Sharp program to check if a given positive number is a multiple of 3 or 7.
//***************************
//Console.WriteLine("Enter a multipe of 3 or 7");
//int x = Convert.ToInt32(Console.ReadLine());
//if (x % 3 == 0 || x % 7 == 0)
//{
//    Console.WriteLine($"The number {x} is multiple of 3 or 7");
//}
//else
//{
//    Console.WriteLine($" The number {x} is not multiple of 3 or 7");
//}

//--------------------------------------
//****************
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.WriteLine(sum_matrix_elements(
//                new int[][] {
//                    new int[]{0, 2, 3, 2},
//                    new int[]{0, 6, 0, 1},
//                    new int[]{4, 0, 3, 0}
//                }));
//        Console.ReadLine();
//    }

//        public static int sum_matrix_elements(int[][] my_matrix)
//        {
//            int x = 0;
//            for (int i = 0; i < my_matrix[0].Length; i++)
//                for (int j = 0; j < my_matrix.Length && my_matrix[j][i] > 0; j++)
//                    x += my_matrix[j][i];

//            return x;
//        }



//}
//---------------------------------------------------------------------------------------
//*****************************************
//Rotate Array
//***********************************
//Console.WriteLine("Enter the length if the array");
//var Length = Convert.ToInt32(Console.ReadLine());
//int[] nums = new int[Length];
//for (int i = 1; i <= Length; i++)
//{
//    Console.WriteLine($"Enter the {i}th Index of array");
//    nums[i-1] = Convert.ToInt32( Console.ReadLine() );
//}
//Console.WriteLine($"The  array before rotat  is {String.Join(",", nums)}");

//int temp = nums[0];

//for (int i = 0; i < nums.Length - 1; i++)
//{
//    nums[i] = nums[i + 1];
//}
//nums[nums.Length - 1] = temp;
//Console.WriteLine($"The rotated array is {String.Join(",",nums)}");
//---------------------------------------------------------------------------------------
//******************************************
//The nearest number to 20
//**********************************
//Console.WriteLine("Enter First Number ");

//var x = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Enter Second Number ");
//var y = Convert.ToDouble(Console.ReadLine());

//var z = Math.Abs(20 - x);
//var b = Math.Abs(20 - y);
//if(z > b)
//{
//    Console.WriteLine($"The nearst Number for 20 is {y}");
//}else if(b > z)
//{
//    Console.WriteLine($"The nearst Number for 20 is {x}");
//}
//else
//{
//    Console.WriteLine(0);
//}

//Console.ReadKey();
//---------------------------------------------------------------------------------------
//**********************************
//Convert from hexa to decimal 
//***********************************
//Console.Write("Enter a hexadecimal number: ");
//string hex = Console.ReadLine();
//int dec = HexToDec(hex);
//Console.WriteLine("The decimal equivalent of " + hex + " is " + dec);

//static int HexToDec(string hex)
//{
//    int dec = 0;
//    for (int i = 0; i < hex.Length; i++)
//    {
//        char c = hex[i];
//        int d;
//        if (c >= '0' && c <= '9')
//            d = c - '0';
//        else if (c >= 'A' && c <= 'F')
//            d = c - 'A' + 10;
//        else if (c >= 'a' && c <= 'f')
//            d = c - 'a' + 10;
//        else
//            throw new ArgumentException("Invalid hexadecimal digit: " + c);
//        dec = dec * 16 + d;
//    }
//    return dec;
//}