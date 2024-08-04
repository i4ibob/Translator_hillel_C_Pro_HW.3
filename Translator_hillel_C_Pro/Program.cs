//Створити новий репозиторій для консольного додатку "Перекладач".

using System.Text;


class Translator
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        //Додаток має надавати переклад стандартних фраз ("Hello" -> "Привіт", "Bye" -> "Прощавай").
        Dictionary<string, string> dictionary_en_ua = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        dictionary_en_ua.Add("Welcome to our translator!", "Вітаємо в нашому перекладачі!");
        dictionary_en_ua.Add("At the moment, the following words can be translated:","На даний момент можна перекласти такі слова:" );
        dictionary_en_ua.Add("Enter the word for which you want to see the translation:","Введіть слово, переклад якого ви бажаєте побачити: ");
        


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
            
            Console.WriteLine(dictionary_en_ua["Welcome to our translator!"]);
            Console.WriteLine($"{dictionary_en_ua["At the moment, the following words can be translated:"]}  " +
                $"({dictionary_en_ua["Hello"]})" +
                $"({dictionary_en_ua["Bye"]})" +
                $"({dictionary_en_ua["World"]})" +
                $"({dictionary_en_ua["Empty"]})" +
                $"({dictionary_en_ua["translation"]})");
           

            Console.Write(dictionary_en_ua["Enter the word for which you want to see the translation:"]);
            var query = Console.ReadLine() ?? dictionary_en_ua["Empty"];
            Console.Write($"{dictionary_en_ua["translation"]}: {query} --> {dictionary_en_ua[query]}\n");
            //Console.Write(dictionary_ua_en.Keys);
            Console.Write("Press any kay to continue.."); Console.ReadKey(); Console.Clear(); 
        }
    }
}


    

//Створити 2 гілки для додатків ("en_ua", "ua_en"), куди помістити відповідне рішення

//Кожна гілка має мати:

//валідний файл .gitignore
//як мінімум два коміти ("initial" і власне розв'язок)	