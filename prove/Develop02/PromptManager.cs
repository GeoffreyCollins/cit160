using System;

class PromptManager
{
    public string[] _prompts = new string[]
    {
        "How are you today?",
        "What can you do today to prepare for tomorrow?",
        "How did you see God's hand in your life today?",
        "What could you have improved?",
        "How are you mentally?"
    };
    public string GetPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Length);
        return(_prompts[index]);
    }
}