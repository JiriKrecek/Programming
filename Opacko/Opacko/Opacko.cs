using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opacko
{
    internal class Opacko
    {
        public void Run()
        {
           // List<int> nums = new List<int>() { 9,4,8,3,64,8,1,5};

           // Console.WriteLine(ListToString(nums));




            using (StreamWriter sw = new StreamWriter("output.txt", true))
            {
                sw.WriteLine("ahoj");
            }

            
        }

        string ListToString(List<int> list)
        {
            string stringFromList = "";
            for (int i = 0; i < list.Count; i++)
            {
                stringFromList += list[i].ToString() + ", ";
            }

            return stringFromList;
        }

        int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
        int[] b = new int[] { 5, 6, 7, 8, 9, 10 };

        void Prunik()
        {
            List<int> list = new List<int>();

            for (int j = 0; j < a.Length; j++)
            {
                int num = a[j];

                for (int i = 0; i < b.Length; i++)
                {
                    if (num == b[i])
                    {
                        list.Add(num);
                    }
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + ", ");
            }
        }
        void Sjednoceni() 
        {
            List<int> list = new List<int>();

            for (int i = 0; i < a.Length; i++)
            {
                list.Add(a[i]);
            }

            for (int i = 0; i < b.Length; i++)
            {
                bool exists = false;
                for (int j = 0; j < list.Count; j++)
                {
                    if (b[i] == list[j])
                    {
                        exists = true;
                    }
                }

                if (exists == false)
                {
                    list.Add(b[i]);
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + ", ");
            }
        }
        void Rozdil()
        {

        }

    }
}
