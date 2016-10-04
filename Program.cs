using System;

namespace ConsoleApplication
{
    public class Program
    {
        // Print 1 - 255
        public static void print1_255()
        {
            for(int i= 1; i<= 255; i++)
            {
                Console.WriteLine(i);
            }
        }

        // Print odd numbers 1 - 255
        public static void print_odd()
        {
            for(int j= 1; j<= 255; j = j+2)
            {
                Console.WriteLine(j);
            }
        }

        // Print Sum
        public static void print_sum()
        {
            var sum = 0; 
            for(int j= 0; j<= 255; j++)
            {
                sum +=  j;
                Console.WriteLine("New number: {0} Sum: {1}", j, sum);
            }
        }

        // Iterating through an Array
        public static void iterartingArray()
        {
            int[] X = new int[6]{1,3,5,7,9,13};
            foreach(int x in X)
            {
                 Console.WriteLine(x);
            }
        }

        //Find max
        public static void findMax(int[] array)  // Prameter passed to function is an array
        {
            var max = array[0];

            foreach (int num in array)
            {
                if (max < num )
                {
                    max = num;
                }
            }

            Console.WriteLine("Maximum number in this array is {0}", max);
        }

        // Get average
        public static void getAvg(int[] array)
        {
            var sum = 0 ;

            foreach (int num in array)
            {
                sum += num;
            }

            var avg = sum/array.Length;
            Console.WriteLine("Average number in this array is {0}", avg);
        }

        // Array with odds numbers
        public static void arrayOdd1to255()
        {
            int[] array = new int[128];
            int j = 0;

            for ( int i = 1; i < 256; i += 2)
            {
                array[j] = i; // Assigning values to an array and pointing next index by incrementing that
                j++;
          
            }
            Console.WriteLine(string.Join(",", array));
        }

        // Greater than Y
        public static void greaterY(int[] array, int Y)
        {
            int count = 0;
            foreach (int num in array)
            {
                if ( num > Y)
                {
                    count ++;
                }
            }

            Console.WriteLine("There are {0} numbers that are greater than {1}.", count, Y);
        }

        // Squaring values in an array
        public static void squareNum(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * array[i];
            }

            Console.WriteLine(string.Join(", ", array));
        }

        // Eliminate Negative numbers
        public static void noNeg(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = 0;
                }
            }

            Console.WriteLine(string.Join(", ", array));

        }

        // MIN, MAX, Avg using Object datatype of array
        public static void basicOper(object[] array)
        {
            var sum = 0;
            var max = array[0];
            var min = array[0];

            for (var i = 0; i < array.Length; i++)
            {
                if ((int)max < (int)array[i])
                {
                    max = array[i];
                }

                if ((int)min > (int)array[i])
                {
                    min = (int)array[i];
                }
                
                sum += (int)array[i];               
            }

                var avg = sum/(int)array.Length;
                Console.WriteLine("Max : {0} , Min: {1}, Average: {2}", max, min, avg);
        }

        // Shifting the values in an array
        public static void shiftingArray(object[] array)
        {
   
            for (var i = 0; i < array.Length-1; i++)
            {
                var temp = array[i];
                array[i] = array[i+1];
                array[i+1] = temp;
            }
            Console.WriteLine(string.Join(" ,", array));
        }

        // Neg Number to String
        public static void Neg_string(object[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                if ( (int)array[i] < 0)
                {
                    array[i] = "Dojo";
                }
            }

            Console.WriteLine(string.Join(", ", array));

        }


        //Invoking Functions that are written above
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // print1_255();
            // print_odd();
            // print_sum();
            // iterartingArray();

            int[] array = new int[4] {-1,0,4,-5};
            // findMax(array);
            // getAvg(array);
            arrayOdd1to255();
            // greaterY(array,3);
            // squareNum(array);
            // noNeg(array);
            object[] array_obj = new object[4] {-6,0,4,-5};
            basicOper(array_obj);
            // shiftingArray(array_obj);
            // Neg_string(array_obj);

        }

    }
}
