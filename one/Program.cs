using System;

namespace one
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer1, answer2, question1, question2;

            answer1 = " Программирование -  мир где нет границ, нет религии и цвета кожи. Лишь твоё воображения и разбитые надежды";
            answer2 = "Хочу извратить своё мир как мир извратил моё мозг";

            question1 = "Что для меня программирование?";
            question2 = "Почему я хочу стать программистом ?";

            Console.WriteLine( $"Первый вопрос {question1}    Ответ: {answer1}" +
                $"Второй вопрос {question2}  Ответ: {answer2}");



        }
    }
}
