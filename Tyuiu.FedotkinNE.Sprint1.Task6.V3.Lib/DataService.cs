using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.FedotkinNE.Sprint1.Task6.V3.Lib
{
    public class DataService : ISprint1Task6V3
    {

        public string LastLetterWord(string value)
        {
            string lastLetters = "";
            string[] words = value.Split(' ');

            foreach (string word in words)
            {
                if (word.Length > 0)
                {
                    lastLetters += word[word.Length - 1];
                }
            }
            return lastLetters;
        }
    }
}
