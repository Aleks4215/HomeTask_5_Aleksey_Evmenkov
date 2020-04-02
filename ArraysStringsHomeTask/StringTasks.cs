using System;
namespace ArraysStringsHomeTask
{
    public class StringTasks
    {
        public void taskOne()
        {
            char[] words = { 'а', 'у', 'о', 'ы', 'и', 'э', 'я', 'ю', 'ё', 'е' };
            Console.WriteLine("Введите текст");
            var text = Console.ReadLine().ToLower();
            var counter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (text[i] == words[j])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine($"Количество гласных букв в введеном тексте : {counter}");

            if (counter == 0)
            {
                Console.WriteLine("Гласных букв не найдено");
            }
        }

        public static void taskTwo()
        {
            Console.WriteLine("Введите текст");
            var text = Console.ReadLine();
            foreach (var i in text)
            {
                int index = text.IndexOf('а');
                if (index != -1)
                {
                    int tempIndex = index;
                    char[] arr = text.ToCharArray();
                    arr[tempIndex] = 'А';
                    text = new string(arr);
                }
            }

            Console.WriteLine(text);

        }
        }
}

