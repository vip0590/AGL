using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;


namespace AGL_Test
{
    class Person
    {
        
        public string name { get; set; }
        
        public string gender { get; set; }
        
        public int age { get; set; }

        public List<Pet> pets { get; set; }

        public override string ToString()
        {
            return name.ToString();
        }
    }

    public class Pet
    {
        public string name { get; set; }
        public string type { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            String data=JsonData.getData();
            JavaScriptSerializer ser = new JavaScriptSerializer();
            Person[] p = ser.Deserialize<Person[]>(data);
            List<Pet> pe = new List<Pet>();
            List<String> male_cats = new List<String>();
            List<String> female_cats = new List<String>();
            for (int i = 0; i < p.Length; ++i)
            {
                //Pet[] pe =new Pet[10];
                pe = p[i].pets;
                if (pe != null)
                {
                    for (int j = 0; j < pe.Count; ++j)
                    {
                        if(pe[j].type.Equals("Cat"))
                        {
                            if (p[i].gender.Equals("Male"))
                            {
                                male_cats.Add(pe[j].name);
                            }
                            else
                            {
                                female_cats.Add(pe[j].name);
                            }
                        }
                    }
                }


                
            }
            male_cats.Sort();
            female_cats.Sort();
            Console.WriteLine("Male:\n");
            male_cats.ForEach(Console.WriteLine);

            Console.WriteLine("\nFemale:\n");
            female_cats.ForEach(Console.WriteLine);

            Console.WriteLine("\nPress Any key to continue..");
            Console.ReadLine();
        }
    }
}
