using CodePractice.Reverse;


// ReverseText.ReverseWords("Один! Два!");

var message = new Message("бла-бла-бла ПриВеТ");
var update = new Update(message);

var myBot = new MyBot();
myBot.Update(update);

class MyBot
{
    public Task Update(Update update)
    {
        var preparedMessage = update.Message.Sms.ToLower();

        if (preparedMessage.Contains("привет") || preparedMessage.Contains("/start"))
        {
            Console.WriteLine($"User's message contains: {preparedMessage}");
        }
        

        return Task.Delay(100);
    }
}

class Message
{
    public string Sms { get; set; }

    public Message(string sms)
    {
        Sms = sms;
    }
}

class Update
{
    public Message Message { get; set; }

    public Update(Message message)
    {
        Message = message;
    }
}