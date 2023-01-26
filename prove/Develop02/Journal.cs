using System;

public class Journal {
    public void Write()
    {
        // The list of random prompts for the user 
        string[] prompts = {"What would you have done differently today? " + 
                            "What is a positive from today? " + 
                            "How were you of service to others? " + 
                            "Did you do anything productive? If not, what can you do now? " + 
                            "Is there anything that needs to be done today to prepare for tomorrow? "};
        Random rand = new Random();
        int index = rand.Next(prompts.Length);
        Console.WriteLine($"{prompts[index]} ");
        Console.ReadLine();

    }
}