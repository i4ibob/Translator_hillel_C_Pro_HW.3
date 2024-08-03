//Створити новий репозиторій для консольного додатку "Перекладач".

using System.Text;


class Translator
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        //Додаток має надавати переклад стандартних фраз ("Hello" -> "Привіт", "Bye" -> "Прощавай").
        Dictionary<string, string> dictionary_en_ua = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        dictionary_en_ua.Add("Вітаємо в нашому перекладачі!", "Welcome to our translator!");
        dictionary_en_ua.Add("Введіть слово, переклад якого ви бажаєте побачити: ", "Enter the word for which you want to see the translation:");
        dictionary_en_ua.Add("На даний момент можна перекласти такі слова:", "At the moment, the following words can be translated:");


        // form ua to eng 
        dictionary_en_ua.Add("Привіт", "Hello");
        dictionary_en_ua.Add("До побачення", "Bye");
        dictionary_en_ua.Add("Світ", "World");
        dictionary_en_ua.Add("Порожній", "Empty");
        dictionary_en_ua.Add("Переклад", "translation");

        // form eng to ua 
        dictionary_en_ua.Add("Hello", "Привіт");
        dictionary_en_ua.Add("Bye", "До побачення");
        dictionary_en_ua.Add("World", "Світ");
        dictionary_en_ua.Add("Empty", "Порожній");
        dictionary_en_ua.Add("translation", "Переклад");

        while (true)
        {
            
            Console.WriteLine(dictionary_en_ua["Вітаємо в нашому перекладачі!"]);
            Console.WriteLine($"{dictionary_en_ua["На даний момент можна перекласти такі слова:"]}  " +
                $"({dictionary_en_ua["Привіт"]})" +
                $"({dictionary_en_ua["До побачення"]})" +
                $"({dictionary_en_ua["Світ"]})" +
                $"({dictionary_en_ua["Порожній"]})" +
                $"({dictionary_en_ua["Переклад"]})");
           

            Console.Write(dictionary_en_ua["Введіть слово, переклад якого ви бажаєте побачити: "]);
            var query = Console.ReadLine() ?? dictionary_en_ua["Порожній"];
            Console.Write($"{dictionary_en_ua["Переклад"]}: {query} --> {dictionary_en_ua[query]}\n");
            //Console.Write(dictionary_ua_en.Keys);
            Console.Write("Press any kay to continue.."); Console.ReadKey(); Console.Clear(); 
        }
    }
}




//Створити 2 гілки для додатків ("en_ua", "ua_en"), куди помістити відповідне рішення

//Кожна гілка має мати:

//валідний файл .gitignore
//як мінімум два коміти ("initial" і власне розв'язок)	