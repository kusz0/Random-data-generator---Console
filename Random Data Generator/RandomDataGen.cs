using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Data_Generator
{
    internal class RandomDataGen
    {
        
        private int dataLength;
        private readonly char[] specialChars = new char[]
        {
            '!', '@','#','$','%','&','?'
        };
        private readonly int[] numbers = new int[]
        {
            1,2,3,4,5,6,7,8,9,0
        };

        public RandomDataGen(int dataLength)
        {
            this.dataLength = dataLength;
        }


        Random random = new Random();
        
        public string RandomID()
        {
            StringBuilder randomId = new StringBuilder();
            for(int i = 0; i < dataLength; i++)
            {
                int type = random.Next(0,2);
                if(type == 0)
                {
                    int randomChar = random.Next(0, specialChars.Length );
                    randomId.Append(specialChars[randomChar]);
                }else
                {
                    int randomInt = random.Next(0,numbers.Length );
                    randomId.Append(numbers[randomInt].ToString());
                }

            }
            return randomId.ToString();

        }


    }
}
