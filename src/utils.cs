namespace BusBoardCsharp.src
{
    public class Utils
    {
        public static string UserInput(string prompt)
            {
                Console.Write(prompt);
                return Console.ReadLine();
            }
    }
}