using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;


namespace orderList
{
    public class orderList
    {

        public static string[] orderIt(string[] list1){
            string placer = "";
            string placeHolder = "";
            int replacementPlace = 0;
            for (int i = 0; i < list1.Count<string>() - 1; i++)
            {
                //set the item that will be compared to
                placer = list1[i];
                for (int j = i + 1; j < list1.Count<string>(); j++)
                {

                    //Comparison of the list items...

                    /*
                    this comparison can be done using "compareTo"
                    --------------------------------
                    if(list1[j].CompareTo(placer)<0){...}
                    --------------------------------
                    but for more controle over the language ordering type using the culture info
                    */
                    
                    if (string.Compare(list1[j],placer,true, new CultureInfo("en-150"))<0)
                    {
                        // if the comparison requirements are met, get the replacement item and its position

                        replacementPlace = j;
                        placer = list1[j];

                    }
                    


                }
                //replacemet of the item inside the list using a temp placeholder
                placeHolder = list1[i];
                //Console.WriteLine("list1[{0}] is {1}", i, list1[i]);
                list1[i] = placer;
                //Console.WriteLine("list1[{0}] is now {1}", i, list1[i]);
                list1[replacementPlace] = placeHolder;

                //Console.WriteLine("---------");
            }
            return list1;
        }

        static void Main(string[] args)
        {

            //program execution starts from here
            string[] list1 = new string[] { "Mumbai", "m n o p q r s t","ӝ җ з ӟ ѕ ӡ и", "London", "New York", "Mahesh", "Chris", "Allen", "Naveen", "Monica", "David"," ρ σ τ υ φ χ ψ ω Ϡ", " ι κ λ μ ν ξ ο " };
            string[] orderedList = orderIt(list1);
            //answer check...
            for (int i = 0; i < orderedList.Count<string>(); i++)
            {
                Console.WriteLine(orderedList[i]);
            }

        }


    }

}