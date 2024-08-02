//Створити новий репозиторій для консольного додатку "Перекладач".

class Translator
{
    static void Main(string[] args)
    {
        Dictionary<string, string>  dictionary = new Dictionary<string, string> ();

        // Display the number of command line arguments.
        Console.WriteLine(args.Length);
    }
}


//Додаток має надавати переклад стандартних фраз ("Hello" -> "Привіт", "Bye" -> "Прощавай").

//Створити 2 гілки для додатків ("en_ua", "ua_en"), куди помістити відповідне рішення

//Кожна гілка має мати:

//валідний файл .gitignore
//як мінімум два коміти ("initial" і власне розв'язок)	