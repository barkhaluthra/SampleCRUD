using System.Diagnostics.Contracts;

namespace SampleCRUD
{
    public class CodingQuestions
    {

        // Reverse a string

        public string ReverseString(string input)
        {
            string Reve = "";

            //char[] charArray = input.ToCharArray();
            //Array.Reverse(charArray);
            //string reversed = new string(charArray);
            //Console.WriteLine(reversed);



            for (int i = input.Length-1; i>=0;i--)
            { 
            Reve+= input[i];
            }
            return Reve;
        }


        //count repeat chanracter in as tring
          public  void CountRepeatCharacter(string input)
        { 
       
            Dictionary<char,int> CharCount= new Dictionary<char, int>();

            foreach (char c in input)
            {

                if (CharCount.ContainsKey(c))
                {
                    CharCount[c]++;

                }
                else
                {
                    CharCount[c] = 1;
                }
                foreach (var item in CharCount)
                {

                    if (item.Value > 1)
                    {
                        Console.WriteLine($"Character: {item.Key}, Count: {item.Value}");
                    }
                }

                }
            }

        // find second largest number in array

        public int SecondAray()
        {
            int[] array = { -10, -20, 
           -35, -24, -55 };

            int first = int.MinValue;
            int second = int.MinValue;
            foreach ( var item 
                
                in array)
            {
                if (item > first)
                {
                    second = first;
                    first = item;
                }
                else if (item > second && item != first)
                {
                    second = item;
                }
            }
            return second;
        }

    }
}
