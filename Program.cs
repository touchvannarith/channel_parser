using System.Text.RegularExpressions;

namespace ChannelParser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input channel:");
            var title = Console.ReadLine();

            // A list of valid notification channels
            List<string> channels = new List<string>() { "BE", "FE", "QA", "Urgent" };

            // A regular expression to match tags enclosed in square brackets
            Regex regex = new Regex(@"\[(.*?)\]");

            // A list to store the matched tags
            List<string> tags = new List<string>();

            // Loop through the matches and add them to the list
            foreach (Match match in regex.Matches(title))
            {
                tags.Add(match.Groups[1].Value);
            }

            // Print the receive channels by filtering the tags
            Console.WriteLine("Receive channels: " + string.Join(", ", tags.FindAll(tag => channels.Contains(tag))));
        }
    }
}