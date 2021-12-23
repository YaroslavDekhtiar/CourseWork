using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;


namespace FarmerApp
{   

    class PermutationOfElements
    {
        private int counter = 1;
        public static List<string> getBest = new List<string>();

        static void makeJaggedArray(string[] a, int n, ref int counter, ref string[][] jaggedArray)
        {

            int value = 0;
            while (value < 1)
            {
                for (int i = 0; i < n; i++)
                {
                    jaggedArray[counter - 1] = new string[n];
                }

                for (int i = 0; i < n; i++)
                {
                    jaggedArray[counter - 1][i] = a[i];
                }
                value++;
            }

            if(counter == getFectorial(n))
            {
                PermutationOfElements getBestCombinations = new PermutationOfElements();
                getBestCombinations.getBestCombinations(jaggedArray, n);
            }
        }

        static void heapPermutation(string[] a, int size, int n, ref int counter, ref string[][] jaggedArray)
        {
            if (size == 1)
            {
                makeJaggedArray(a, n, ref counter, ref jaggedArray);
                counter++;
            }

            for (int i = 0; i < size; i++)
            {
                heapPermutation(a, size - 1, n, ref counter, ref jaggedArray);

                if (size % 2 == 1)
                {
                    string temp = a[0];
                    a[0] = a[size - 1];
                    a[size - 1] = temp;                
                }

                else
                {
                    string temp = a[i];
                    a[i] = a[size - 1];
                    a[size - 1] = temp;    
                }
            }
    }

        public void setArray(string[] array)
        {
            string[] a = array;
            string[][] jaggedArray = new string[getFectorial(a.Length)][];

            heapPermutation(a, a.Length, a.Length, ref counter, ref jaggedArray);
        }


        static int getFectorial(int n)
        {
            int fectorial = 1;

            for (int i = 1; i <= n; i++)
                fectorial = fectorial * i;
            return fectorial;
        }

        private void getBestCombinations(string[][] jaggedArray, int sizeInnerArr)
        {
            int max;
            int[] sum = new int[jaggedArray.Length];
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < (sizeInnerArr - 1); j++)
                {
                    sum[i] += getElementFromDB(jaggedArray[i][j], jaggedArray[i][j + 1]);
                }
            }

            max = Array.IndexOf(sum, sum.Max());
            
            for (int i = 0; i < sizeInnerArr; i++)
            {
                getBest.Add(jaggedArray[max][i]);
            }
        }

        static int getElementFromDB(string firstValue, string secondValue) 
        {
            int value = 0;
            DB db = new DB();
            db.openConnection();
            using (MySqlCommand command = new MySqlCommand("SELECT mark FROM plants_combinations WHERE first_plant = @fp AND second_plant = @sp", db.getConnection()))
            {
                command.Parameters.Add("@fp", MySqlDbType.VarChar).Value = firstValue;
                command.Parameters.Add("@sp", MySqlDbType.VarChar).Value = secondValue;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        value = reader.GetInt32(0);
                    }
                }
            }
            return value;
        }
            
    }
}
