namespace FizzBuzz 
{
    public class FizzBuzz 
    {
        public string FizzBuzz (int number )
        {
            if (number % 5  == 0 && number % 3 == 0) 
            {
                return "fizzbuzz";
            }
            else if (number % 3 == 0) 
            {
                return "fizz";
            }
            else if (number % 5 == 0)
            {
                return "buzz";
            }
        }
    }
}