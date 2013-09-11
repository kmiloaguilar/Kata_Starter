﻿using Machine.Specifications;

namespace kata.specs
{
    public class when_number_is_divisible_by_5 : given_a_fizzbuzzer_context
    {

        Because of = () => { _result = FizzBuzzer.Play(20); };

        It should_return_the_word_buzz = () => { _result.ShouldEqual("buzz"); };
        static string _result;
    }
}