﻿namespace kata
{
    public class FizzBuzzer
    {
        public string Play(int number)
        {
            if (number % 3 == 0)
            {
                return "Fizz";
            }
            if (number % 5 == 0)
            {
                return "Buzz";
            }
            return number + "";
        }
    }
}