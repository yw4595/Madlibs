using System;
using System.IO;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Author: ChatGPT
            //Purpose: Entry point for the Mad Libs game program
            //Restrictions: None
            // Prompt user to play Mad Libs
            Console.WriteLine("Welcome to Mad Libs! Would you like to play? (yes/no)");
            string play = Console.ReadLine();
            // Validate user input
            while (!play.Equals("yes", StringComparison.InvariantCultureIgnoreCase) && !play.Equals("no", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("Invalid input. Please enter either 'yes' or 'no':");
                play = Console.ReadLine();
            }

            // If user chooses to play
            if (play.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
            {
                // Read stories from file
                string[] stories = ReadStoriesFromFile();

                // Display story options to user
                Console.WriteLine("Please choose a story (1-" + stories.Length + "):");
                for (int i = 0; i < stories.Length; i++)
                {
                    Console.WriteLine((i + 1) + ": " + stories[i].Split(new string[] { "\n" }, StringSplitOptions.None)[0]);
                }

                // Validate user's story choice
                int storyIndex = -1;
                while (storyIndex < 0 || storyIndex >= stories.Length)
                {
                    Console.WriteLine("Invalid story choice. Please enter a number between 1 and " + stories.Length + ":");
                    int.TryParse(Console.ReadLine(), out storyIndex);
                    storyIndex--;
                }

                // Fill in story with user input
                string resultString = FillInStory(stories[storyIndex]);

                // Display completed story
                Console.WriteLine(resultString);
            }
            else
            {
                Console.WriteLine("Goodbye!");
            }
        }

        /*
         * Reads stories from file
         * 
         * Returns:
         *   string[] - the stories read from the file
         */
        static string[] ReadStoriesFromFile()
        {
            // Read stories from file
            string[] stories = File.ReadAllLines("MadLibsTemplate.txt");

            return stories;
        }

        /*
         * Fills in the story with user input
         * 
         * Parameters:
         *   story - the story to fill in
         * 
         * Returns:
         *   string - the completed story
         */
        static string FillInStory(string story)
        {
            // TODO: Implement this method
            return null;
        }
    }
}
