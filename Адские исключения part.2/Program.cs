class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите путь файла:");
            string filePath = Console.ReadLine(); // Записывает путь файла в строку

            using (StreamReader sr = new StreamReader(filePath)) // Читает файл 
            {
                string fileContent = sr.ReadToEnd(); // Читаем

                Console.WriteLine(fileContent); // Вывод из файла
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("Кажется вы не самурай и пути у вас нет =(");
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Куда я жмал?");
            Console.WriteLine(ex.Message);
        }
    }
}

