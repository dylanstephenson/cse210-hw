public class PromptGenerator
{
    public List<string> _prompts = new List<string> {"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "What did I prioritize the most today?", "If I had one thing I could do over today, what would it be?", "List 5 things you are grateful for.", "If you had a day without any responsibilities, how would you spend it?", "If you had time to learn an instrument, which would you learn and why?" };

    public List<string> _inspirationalQuotes = new List<string> {
        "'It takes courage to grow up and become who you really are.' - E.E. Cummings",
        "'Your self-worth is determined by you. You don't have to depend on someone telling you who you are.' - Beyoncé",
        "'Nothing is impossible. The word itself says 'I'm possible!'' - Audrey Hepburn",
        "'Keep your face always toward the sunshine, and shadows will fall behind you.' - Walt Whitman",
        "'You have brains in your head. You have feet in your shoes. You can steer yourself any direction you choose. You're on your own. And you know what you know. And you are the guy who'll decide where to go.' - Dr. Seuss",
        "'Attitude is a little thing that makes a big difference.' - Winston Churchill",
        "'To bring about change, you must not be afraid to take the first step. We will fail when we fail to try.' - Rosa Parks",
        "'All our dreams can come true, if we have the courage to pursue them.' - Walt Disney",
        "'Don't sit down and wait for the opportunities to come. Get up and make them.' - Madam C.J. Walker",
        "'Champions keep playing until they get it right.' - Billie Jean King",
        "'You are never too old to set another goal or to dream a new dream.' - C.S.Lewis",
        "'Just don't give up trying to do what you really want to do. Where there is love and inspiration, I don't think you can go wrong.' - Ella Fitzgerald",
        "'Try to be a rainbow in someone's cloud.' - Maya Angelou",
        "'If you don't like the road you're walking, start paving another one.' - Dolly Parton",
        "'It is never too late to be what you might have been.' - George Eliot",
        "'When you put love out in the world it travels, and it can touch people and reach people in ways that we never even expected.' - Laverne Cox",
        "'Give light and people will find the way.' - Ella Baker",
        "'Don't count the days, make the days count.' - Muhammad Ali",
        "'If you're having fun, that's when the best memories are built.' - Simone Biles",
        "'Hard things will happen to us. We will recover. We will learn from it. We will grow more resilient because of it.' - Taylor Swift",
        "'To live is the rarest thing in the world. Most people just exist.' - Oscar Wilde"

    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string _randPrompt = _prompts[index];
        return _randPrompt;
    }
    public string GetInspired()
    {
        Random random = new Random();
        int index = random.Next(_inspirationalQuotes.Count);
        string _inspired = _inspirationalQuotes[index];
        return _inspired;
    }
}