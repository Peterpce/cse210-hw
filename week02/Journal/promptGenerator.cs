public class promptGenerator 
{
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is something new I learned today?",
        "What was a small moment of joy I experienced today?",
        "How did I help someone today?",
        "What was the biggest challenge I faced today, and how did I handle it?",
        "What is one thing I am grateful for today?",
        "What is a goal I worked toward today?",
        "What is a mistake I made today, and what did I learn from it?",
        "If I could relive one moment from today, what would it be and why?",
        "What is one thing I am looking forward to tomorrow?",
        "How did I take care of myself today?"
    };
    
    public string GetRandomPrompt()
    { 
        Random random = new Random();
        return _prompts[random.Next(0, _prompts.Count)];
    }
}    