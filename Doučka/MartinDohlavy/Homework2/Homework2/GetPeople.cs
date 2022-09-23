using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class GetPeople
    {
        public void Run()
        {
            var data = File.ReadAllLines("data.txt");

            using (StreamWriter sw = new StreamWriter("output.txt"))
            {

                for (int i = 0; i < data.Length; i++)
                {
                    var personInfo = data[i].Split(";");
                    if (personInfo[2] == "US Dollar" && personInfo[3] == "True")
                    {
                        sw.WriteLine(data[i]);
                    }
                }
            }
        }
    }
}
