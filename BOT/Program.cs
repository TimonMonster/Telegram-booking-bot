using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types.InlineQueryResults;
using BOT;
using Newtonsoft.Json;
using Npgsql;
using BD;
using System.IO;
using System.Text.Json;
using File = System.IO.File;
using System.Text.Encodings.Web;

var botClient = new TelegramBotClient("Ваш ключ Bot API");




using CancellationTokenSource cts = new();

// StartReceiving does not block the caller thread. Receiving is done on the ThreadPool.
ReceiverOptions receiverOptions = new()
{
    AllowedUpdates = Array.Empty<UpdateType>() // receive all update types
};


var myDatabase = new MyDatabase("Данные вашей бд");

string selectedcity = null;
string selectedcountry = null;
string Name = null;
string Stars = null;
string resorts = null;


Class1 class1 = new Class1();
Class2 class2 = new Class2();
Class3 class3 = new Class3();
Class4 class4 = new Class4();
Class5 class5 = new Class5();



Madr1 madrid1 = new Madr1();
Madr2 madrid2 = new Madr2();
Madr3 madrid3 = new Madr3();
Madr4 madrid4 = new Madr4();
Madr5 madrid5 = new Madr5();



PSG1 psg1 = new PSG1();
PSG2 psg2 = new PSG2();
PSG3 psg3 = new PSG3();
PSG4 psg4 = new PSG4();
PSG5 psg5 = new PSG5();



TUL1 tul1 = new TUL1();
TUL2 tul2 = new TUL2();
TUL3 tul3 = new TUL3();
TUL4 tul4 = new TUL4();
TUL5 tul5 = new TUL5();


botClient.StartReceiving(
    updateHandler: HandleUpdateAsync,
    pollingErrorHandler: HandlePollingErrorAsync,
    receiverOptions: receiverOptions,
    cancellationToken: cts.Token
);


async Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
{
    var ErrorMessage = exception switch
    {
        ApiRequestException apiRequestException
            => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
        _ => exception.ToString()
    };
    if (class1 == null)

    {
        Console.WriteLine("class is not initialized.");
    }
    Console.WriteLine(ErrorMessage);
    await Task.CompletedTask;
}

var me = await botClient.GetMeAsync();


Console.WriteLine($"Start listening for @{me.Username}");
Console.ReadLine();

// Send cancellation request to stop bot
cts.Cancel();




async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken )
{




    // Only process Message updates: https://core.telegram.org/bots/api#message
    if (update.Message is not { } message)
        return;
    // Only process text messages
    if (message.Text is not { } messageText)
        return;

    var chatId = message.Chat.Id;



    Console.WriteLine($"Received a '{messageText}' message in chat {chatId}. User Id: {message.Chat.Id} ");


    if (message.Text.ToLower() == "хочу")
    {
        ReplyKeyboardMarkup replyKeyboardMarkup = new(new[]
{
    new KeyboardButton[] { "🇪🇸", "🇫🇷" }

})
        {
            ResizeKeyboard = true
        };

        Message keyboard = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Выбери страну",
            replyMarkup: replyKeyboardMarkup,
            cancellationToken: cancellationToken);

    }


    switch (message.Text)
    {
        case "🇪🇸":
            selectedcountry = "🇪🇸";

            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали {message.Text}");
            ReplyKeyboardMarkup keycityesp = new(new[]
    {
new KeyboardButton[] { "Барселона", "Мадрид" }

})
            {
                ResizeKeyboard = true
            };

            Message cityesp = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Выбери город",
            replyMarkup: keycityesp,
            cancellationToken: cancellationToken);

            break;

        case "🇫🇷":
            selectedcountry = "🇫🇷";
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали {message.Text}");
            ReplyKeyboardMarkup keycityfr = new(new[]
    {
new KeyboardButton[] { "Париж", "Тулуза" }

})
            {
                ResizeKeyboard = true
            };

            Message cityft = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Выбери город",
            replyMarkup: keycityfr,
            cancellationToken: cancellationToken);

            break;

    }

    switch (message.Text)
    {
        case "Барселона":
            selectedcity = "Барселона";
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали {message.Text}");
            ReplyKeyboardMarkup keycitybar = new(new[]
    {
                new KeyboardButton[] { "4", "5" },
new KeyboardButton[] { "1", "2", "3" }


})
            {
                ResizeKeyboard = true
            };

            Message citybar = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Выбери количество звёзд",
            replyMarkup: keycitybar,
            cancellationToken: cancellationToken);
            break;

        case "1" when selectedcity == "Барселона":
            Stars = "1";
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 1 звезду");

            string selectedOption = class1.SelectRandomHotel(class1.barcelona);

            ReplyKeyboardMarkup reload_bar1 = new(new[]
  {
                new KeyboardButton[] { "Спасибо" },
                 new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message realodbar1 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Если вам не нравится, можно поменять, а если норм, то вернём вас в начало",
            replyMarkup: reload_bar1,
            cancellationToken: cancellationToken);


            InlineKeyboardMarkup inlineKeyboard1 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url: selectedOption)
});

            Message sentMessage1 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard1,
                cancellationToken: cancellationToken);

            var result = myDatabase.InsertData($"{message.Chat.Id}", "Spain", "barca", "1", $"{selectedOption}");

            json param_bar1 = new json()
            {
                Country = selectedcountry,
                City = selectedcity,
                Stars = Stars,
                Hotels = selectedOption
            };


            var options_bar1 = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string json_bar1 = System.Text.Json.JsonSerializer.Serialize(param_bar1, options_bar1);
            File.WriteAllText("json.json", json_bar1);



            break;
        case "2" when selectedcity == "Барселона":
            Stars = "2";
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 2 звезды");
            string selectedOption2 = class2.SelectRandomHotel(class2.barcelona2);

            ReplyKeyboardMarkup reload_bar2 = new(new[]
 {
                new KeyboardButton[] { "Спасибо" },
                 new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message realodbar2 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Если вам не нравится, можно поменять, а если норм, то вернём вас в начало",
            replyMarkup: reload_bar2,
            cancellationToken: cancellationToken);
            InlineKeyboardMarkup inlineKeyboard2 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url: selectedOption2)
});

            Message sentMessage2 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard2,
                cancellationToken: cancellationToken);

            var result1 = myDatabase.InsertData($"{message.Chat.Id}", "Spain", "barca", "2", $"{selectedOption2}");

            json param_bar2 = new json()
            {
                Country = selectedcountry,
                City = selectedcity,
                Stars = Stars,
                Hotels = selectedOption2
            };
           
            
            var options_bar2 = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string json_bar2 = System.Text.Json.JsonSerializer.Serialize(param_bar2, options_bar2);
            File.WriteAllText("json.json", json_bar2);

            break;

        case "3" when selectedcity == "Барселона":
            Stars = "3";
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 3 звезды");

            string selectedOption3 = class3.SelectRandomHotel(class3.barcelona3);
            ReplyKeyboardMarkup reload_bar3 = new(new[]
 {
                new KeyboardButton[] { "Спасибо" },
                 new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message realodbar3 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Если вам не нравится, можно поменять, а если норм, то вернём вас в начало",
            replyMarkup: reload_bar3,
            cancellationToken: cancellationToken);
            InlineKeyboardMarkup inlineKeyboard3 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url: selectedOption3)
});

            Message sentMessage3 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard3,
                cancellationToken: cancellationToken);

            var result2 = myDatabase.InsertData($"{message.Chat.Id}", "Spain", "barca", "3", $"{selectedOption3}");

            json param_bar3 = new json()
            {
                Country = selectedcountry,
                City = selectedcity,
                Stars = Stars,
                Hotels = selectedOption3
            };


            var options_bar3 = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string json_bar3 = System.Text.Json.JsonSerializer.Serialize(param_bar3, options_bar3);
            File.WriteAllText("json.json", json_bar3);

            break;

        case "4" when selectedcity == "Барселона":
            Stars = "4";
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 4 звезды");
            string selectedOption4 = class4.SelectRandomHotel(class4.barcelona4);
            ReplyKeyboardMarkup reload_bar4 = new(new[]
 {
                new KeyboardButton[] { "Спасибо" },
                 new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message realodbar4 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Если вам не нравится, можно поменять, а если норм, то вернём вас в начало",
            replyMarkup: reload_bar4,
            cancellationToken: cancellationToken);
            InlineKeyboardMarkup inlineKeyboard4 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url: selectedOption4)
});

            Message sentMessage4 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard4,
                cancellationToken: cancellationToken);

            var result3 = myDatabase.InsertData($"{message.Chat.Id}", "Spain", "barca", "4", $"{selectedOption4}");

            json param_bar4 = new json()
            {
                Country = selectedcountry,
                City = selectedcity,
                Stars = Stars,
                Hotels = selectedOption4
            };


            var options_bar4 = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string json_bar4 = System.Text.Json.JsonSerializer.Serialize(param_bar4, options_bar4);
            File.WriteAllText("json.json", json_bar4);

            break;

        case "5" when selectedcity == "Барселона":
            Stars = "5";
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 5 звёзд");
            string selectedOption5 = class5.SelectRandomHotel(class5.barcelona5);
            ReplyKeyboardMarkup reload_bar5 = new(new[]
 {
                new KeyboardButton[] { "Спасибо" },
                 new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message realodbar5 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Если вам не нравится, можно поменять, а если норм, то вернём вас в начало",
            replyMarkup: reload_bar5,
            cancellationToken: cancellationToken);
            InlineKeyboardMarkup inlineKeyboard5 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url: selectedOption5)
});

            Message sentMessage5 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard5,
                cancellationToken: cancellationToken);

            var result4 = myDatabase.InsertData($"{message.Chat.Id}", "Spain", "barca", "5", $"{selectedOption5}");

            json param_bar5 = new json()
            {
                Country = selectedcountry,
                City = selectedcity,
                Stars = Stars,
                Hotels = selectedOption5
            };


            var options_bar5 = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string json_bar5 = System.Text.Json.JsonSerializer.Serialize(param_bar5, options_bar5);
            File.WriteAllText("json.json", json_bar5);

            break;


    }

    switch (message.Text)
    {
        case "Обновить" when selectedcity == "Барселона" && Stars == "1":
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 1 звезду");
            string selectedOption_reload_bar1 = class1.SelectRandomHotel(class1.barcelona);


            ReplyKeyboardMarkup reload_bar1 = new(new[]
  {
                 new KeyboardButton[] { "Спасибо" },
                new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message realodbar1 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Обновили",
            replyMarkup: reload_bar1,
            cancellationToken: cancellationToken);


            InlineKeyboardMarkup inlineKeyboard1 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url: selectedOption_reload_bar1)
});

            Message sentMessage1 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard1,
                cancellationToken: cancellationToken);


            break;

        case "Обновить" when selectedcity == "Барселона" && Stars == "2":
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 2 звезды");
            string selectedOption_reload_bar2 = class2.SelectRandomHotel(class2.barcelona2);

            ReplyKeyboardMarkup reload_bar2 = new(new[]
  {
                new KeyboardButton[] { "Спасибо" },
                new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message realodbar2 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Обновили",
            replyMarkup: reload_bar2,
            cancellationToken: cancellationToken);


            InlineKeyboardMarkup inlineKeyboard_bar2 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url: selectedOption_reload_bar2)
});

            Message sentMessage_bar2 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard_bar2,
                cancellationToken: cancellationToken);


            break;

        case "Обновить" when selectedcity == "Барселона" && Stars == "3":
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 3 звезды");
            string selectedOption_reload_bar3 = class3.SelectRandomHotel(class3.barcelona3);

            ReplyKeyboardMarkup reload_bar3 = new(new[]
  {
                new KeyboardButton[] { "Спасибо" },
                new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message realodbar3 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Обновили",
            replyMarkup: reload_bar3,
            cancellationToken: cancellationToken);


            InlineKeyboardMarkup inlineKeyboard_bar3 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url: selectedOption_reload_bar3)
});

            Message sentMessage_bar3 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard_bar3,
                cancellationToken: cancellationToken);


            break;

        case "Обновить" when selectedcity == "Барселона" && Stars == "4":
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 4 звезды");
            string selectedOption_reload_bar4 = class4.SelectRandomHotel(class4.barcelona4);

            ReplyKeyboardMarkup reload_bar4 = new(new[]
  {
                new KeyboardButton[] { "Спасибо" },
                new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message realodbar4 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Обновили",
            replyMarkup: reload_bar4,
            cancellationToken: cancellationToken);


            InlineKeyboardMarkup inlineKeyboard_bar4 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url: selectedOption_reload_bar4)
});

            Message sentMessage_bar4 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard_bar4,
                cancellationToken: cancellationToken);


            break;

        case "Обновить" when selectedcity == "Барселона" && Stars == "5":
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 5 звезд");
            string selectedOption_reload_bar5 = class5.SelectRandomHotel(class5.barcelona5);

            ReplyKeyboardMarkup reload_bar5 = new(new[]
  {
                new KeyboardButton[] { "Спасибо" },
                new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message realodbar5 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Обновили",
            replyMarkup: reload_bar5,
            cancellationToken: cancellationToken);


            InlineKeyboardMarkup inlineKeyboard_bar5 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url: selectedOption_reload_bar5)
});

            Message sentMessage_bar5 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard_bar5,
                cancellationToken: cancellationToken);


            break;

    }


    switch (message.Text)
    {
        case "Мадрид":
            selectedcity = "Мадрид";
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали {message.Text}");
            

            ReplyKeyboardMarkup keycitybar = new(new[]
    {
                new KeyboardButton[] { "4", "5" },
new KeyboardButton[] { "1", "2", "3" }


})
            {
                ResizeKeyboard = true
            };

            Message citybar = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Выбери количество звёзд",
            replyMarkup: keycitybar,
            cancellationToken: cancellationToken);


            break;

        case "1" when selectedcity == "Мадрид":
            Stars = "1";
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 1 звезду");
            string mad1 = madrid1.SelectRandomHotel(madrid1.madrid1);
            ReplyKeyboardMarkup reload_bar4 = new(new[]
{
                new KeyboardButton[] { "Спасибо" },
                 new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message realodbar4 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Если вам не нравится, можно поменять, а если норм, то вернём вас в начало",
            replyMarkup: reload_bar4,
            cancellationToken: cancellationToken);

            InlineKeyboardMarkup inlineKeyboard_mad1 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url: mad1)
});

            Message sentMessage1 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard_mad1,
                cancellationToken: cancellationToken);

            var result_mad1 = myDatabase.InsertData($"{message.Chat.Id}", "Spain", "Madrid", "1", $"{mad1}");

            json param_mad1 = new json()
            {
                Country = selectedcountry,
                City = selectedcity,
                Stars = Stars,
                Hotels = mad1
            };


            var options_mad1 = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string json_mad1 = System.Text.Json.JsonSerializer.Serialize(param_mad1, options_mad1);
            File.WriteAllText("json.json", json_mad1);
            break;
        case "2" when selectedcity == "Мадрид":
            Stars = "2";
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 2 звезды");
            string mad2 = madrid1.SelectRandomHotel(madrid2.madrid2);
            ReplyKeyboardMarkup reload_mad1 = new(new[]
{
                new KeyboardButton[] { "Спасибо" },
                 new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message reaload_mad1 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Если вам не нравится, можно поменять, а если норм, то вернём вас в начало",
            replyMarkup: reload_mad1,
            cancellationToken: cancellationToken);

            InlineKeyboardMarkup inlineKeyboard_mad2 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url: mad2)
});

            Message sentMessage2 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard_mad2,
                cancellationToken: cancellationToken);

            var result_mad2 = myDatabase.InsertData($"{message.Chat.Id}", "Spain", "Madrid", "2", $"{mad2}");

            json param_mad2 = new json()
            {
                Country = selectedcountry,
                City = selectedcity,
                Stars = Stars,
                Hotels = mad2
            };


            var options_mad2 = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string json_mad2 = System.Text.Json.JsonSerializer.Serialize(param_mad2, options_mad2);
            File.WriteAllText("json.json", json_mad2);

            break;

        case "3" when selectedcity == "Мадрид":
            Stars = "3";
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 3 звезды");
            string mad3 = madrid3.SelectRandomHotel(madrid3.madrid3);

            ReplyKeyboardMarkup reload_mad2 = new(new[]
{
                new KeyboardButton[] { "Спасибо" },
                 new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message reaload_mad2 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Если вам не нравится, можно поменять, а если норм, то вернём вас в начало",
            replyMarkup: reload_mad2,
            cancellationToken: cancellationToken);

            InlineKeyboardMarkup inlineKeyboard_mad3 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url: mad3)
});

            Message sentMessage3 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard_mad3,
                cancellationToken: cancellationToken);

            var result_mad3 = myDatabase.InsertData($"{message.Chat.Id}", "Spain", "Madrid", "3", $"{mad3}");

            json param_mad3 = new json()
            {
                Country = selectedcountry,
                City = selectedcity,
                Stars = Stars,
                Hotels = mad3
            };


            var options_mad3 = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string json_mad3 = System.Text.Json.JsonSerializer.Serialize(param_mad3, options_mad3);
            File.WriteAllText("json.json", json_mad3);

            break;

        case "4" when selectedcity == "Мадрид":
            Stars = "4";
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 4 звезды");
            string mad4 = madrid4.SelectRandomHotel(madrid4.madrid4);

            ReplyKeyboardMarkup reload_mad3 = new(new[]
{
                new KeyboardButton[] { "Спасибо" },
                 new KeyboardButton[] { "Обновить" }


})
            {
                ResizeKeyboard = true
            };

            Message reaload_mad3 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Если вам не нравится, можно поменять, а если норм, то вернём вас в начало",
            replyMarkup: reload_mad3,
            cancellationToken: cancellationToken);

            InlineKeyboardMarkup inlineKeyboard_mad4 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url: mad4)
});

            Message sentMessage4 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard_mad4,
                cancellationToken: cancellationToken);

            var result_mad4 = myDatabase.InsertData($"{message.Chat.Id}", "Spain", "Madrid", "4", $"{mad4}");

            json param_mad4 = new json()
            {
                Country = selectedcountry,
                City = selectedcity,
                Stars = Stars,
                Hotels = mad4
            };


            var options_mad4 = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string json_mad4 = System.Text.Json.JsonSerializer.Serialize(param_mad4, options_mad4);
            File.WriteAllText("json.json", json_mad4);

            break;

        case "5" when selectedcity == "Мадрид":
            Stars = "5";
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 5 звёзд");
            string mad5 = madrid5.SelectRandomHotel(madrid5.madrid5);

            ReplyKeyboardMarkup reload_mad4 = new(new[]
{
                new KeyboardButton[] { "Спасибо" },
                 new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message reaload_mad4 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Если вам не нравится, можно поменять, а если норм, то вернём вас в начало",
            replyMarkup: reload_mad4,
            cancellationToken: cancellationToken);

            InlineKeyboardMarkup inlineKeyboard_mad5 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url: mad5)
});

            Message sentMessage5 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard_mad5,
                cancellationToken: cancellationToken);

            var result_mad5 = myDatabase.InsertData($"{message.Chat.Id}", "Spain", "Madrid", "5", $"{mad5}");


            json param_mad5 = new json()
            {
                Country = selectedcountry,
                City = selectedcity,
                Stars = Stars,
                Hotels = mad5
            };


            var options_mad5 = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string json_mad5 = System.Text.Json.JsonSerializer.Serialize(param_mad5, options_mad5);
            File.WriteAllText("json.json", json_mad5);

            break;




    }

    switch (message.Text)
    {
        case "Обновить" when selectedcity == "Мадрид" && Stars == "1":
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 1 звезду");
            string mad_reload1 = madrid1.SelectRandomHotel(madrid1.madrid1);

            ReplyKeyboardMarkup reload_bar1 = new(new[]
  {
                 new KeyboardButton[] { "Спасибо" },
                new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message realodbar1 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Обновили",
            replyMarkup: reload_bar1,
            cancellationToken: cancellationToken);


            InlineKeyboardMarkup inlineKeyboard1 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url: mad_reload1)
});

            Message sentMessage1 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard1,
                cancellationToken: cancellationToken);


            break;

        case "Обновить" when selectedcity == "Мадрид" && Stars == "2":
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 2 звезды");

            string mad_reload2 = madrid2.SelectRandomHotel(madrid2.madrid2);

            ReplyKeyboardMarkup reload_bar2 = new(new[]
  {
                new KeyboardButton[] { "Спасибо" },
                new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message realodbar2 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Обновили",
            replyMarkup: reload_bar2,
            cancellationToken: cancellationToken);


            InlineKeyboardMarkup inlineKeyboard_bar2 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url:  mad_reload2)
});

            Message sentMessage_bar2 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard_bar2,
                cancellationToken: cancellationToken);


            break;

        case "Обновить" when selectedcity == "Мадрид" && Stars == "3":
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 3 звезды");

            string mad_reload3 = madrid3.SelectRandomHotel(madrid3.madrid3);

            ReplyKeyboardMarkup reload_bar3 = new(new[]
  {
                new KeyboardButton[] { "Спасибо" },
                new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message realodbar3 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Обновили",
            replyMarkup: reload_bar3,
            cancellationToken: cancellationToken);


            InlineKeyboardMarkup inlineKeyboard_bar3 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url:  mad_reload3)
});

            Message sentMessage_bar3 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard_bar3,
                cancellationToken: cancellationToken);


            break;

        case "Обновить" when selectedcity == "Мадрид" && Stars == "4":
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 4 звезды");

            string mad_reload4 = madrid4.SelectRandomHotel(madrid4.madrid4);

            ReplyKeyboardMarkup reload_bar4 = new(new[]
  {
                new KeyboardButton[] { "Спасибо" },
                new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message realodbar4 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Обновили",
            replyMarkup: reload_bar4,
            cancellationToken: cancellationToken);


            InlineKeyboardMarkup inlineKeyboard_bar4 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url:  mad_reload4)
});

            Message sentMessage_bar4 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard_bar4,
                cancellationToken: cancellationToken);


            break;

        case "Обновить" when selectedcity == "Мадрид" && Stars == "5":
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 5 звезд");

            string mad_reload5 = madrid5.SelectRandomHotel(madrid5.madrid5);

            ReplyKeyboardMarkup reload_bar5 = new(new[]
  {
                new KeyboardButton[] { "Спасибо" },
                new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message realodbar5 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Обновили",
            replyMarkup: reload_bar5,
            cancellationToken: cancellationToken);


            InlineKeyboardMarkup inlineKeyboard_bar5 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url:  mad_reload5)
});

            Message sentMessage_bar5 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard_bar5,
                cancellationToken: cancellationToken);


            break;

    }

    switch (message.Text)
    {
        case "Париж":
            selectedcity = "Париж";
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали {message.Text}");
            ReplyKeyboardMarkup keycitybar = new(new[]
    {
                new KeyboardButton[] { "4", "5" },
new KeyboardButton[] { "1", "2", "3" }


})
            {
                ResizeKeyboard = true
            };

            Message citybar = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Выбери количество звёзд",
            replyMarkup: keycitybar,
            cancellationToken: cancellationToken);


            break;

        case "1" when selectedcity == "Париж":
            Stars = "1";
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 1 звезду");
            string paris1 = psg1.SelectRandomHotel(psg1.psg1);

            ReplyKeyboardMarkup reload_par1 = new(new[]
{
                new KeyboardButton[] { "Спасибо" },
                 new KeyboardButton[] { "Обновить" }


})
            {
                ResizeKeyboard = true
            };

            Message reaload_par1 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Если вам не нравится, можно поменять, а если норм, то вернём вас в начало",
            replyMarkup: reload_par1,
            cancellationToken: cancellationToken);

            InlineKeyboardMarkup inlineKeyboard_psg1 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url: paris1)
});

            Message sentMessage1 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard_psg1,
                cancellationToken: cancellationToken);

            var result_par1 = myDatabase.InsertData($"{message.Chat.Id}", "France", "Paris", "1", $"{paris1}");

            json param_par1 = new json()
            {
                Country = selectedcountry,
                City = selectedcity,
                Stars = Stars,
                Hotels = paris1
            };


            var options_par1 = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string json_par1 = System.Text.Json.JsonSerializer.Serialize(param_par1, options_par1);
            File.WriteAllText("json.json", json_par1);

            break;
        case "2" when selectedcity == "Париж":
            Stars = "2";
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 2 звезды");
            string paris2 = psg2.SelectRandomHotel(psg2.psg2);

            ReplyKeyboardMarkup reload_par2 = new(new[]
{
                new KeyboardButton[] { "Спасибо" },
                 new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message reaload_par2 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Если вам не нравится, можно поменять, а если норм, то вернём вас в начало",
            replyMarkup: reload_par2,
            cancellationToken: cancellationToken);

            InlineKeyboardMarkup inlineKeyboard_psg2 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url: paris2)
});

            Message sentMessage2 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard_psg2,
                cancellationToken: cancellationToken);

            var result_par2 = myDatabase.InsertData($"{message.Chat.Id}", "France", "Paris", "2", $"{paris2}");

            json param_par2 = new json()
            {
                Country = selectedcountry,
                City = selectedcity,
                Stars = Stars,
                Hotels = paris2
            };


            var options_par2 = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string json_par2 = System.Text.Json.JsonSerializer.Serialize(param_par2, options_par2);
            File.WriteAllText("json.json", json_par2);

            break;

        case "3" when selectedcity == "Париж":
            Stars = "3";
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 3 звезды");
            string paris3 = psg3.SelectRandomHotel(psg3.psg3);

            ReplyKeyboardMarkup reload_par3 = new(new[]
{
                new KeyboardButton[] { "Спасибо" },
                 new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message reaload_par3 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Если вам не нравится, можно поменять, а если норм, то вернём вас в начало",
            replyMarkup: reload_par3,
            cancellationToken: cancellationToken);

            InlineKeyboardMarkup inlineKeyboard_psg3 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url: paris3)
});

            Message sentMessage3 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard_psg3,
                cancellationToken: cancellationToken);

            var result_par3 = myDatabase.InsertData($"{message.Chat.Id}", "France", "Paris", "3", $"{paris3}");

            json param_par3 = new json()
            {
                Country = selectedcountry,
                City = selectedcity,
                Stars = Stars,
                Hotels = paris3
            };


            var options_par3 = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string json_par3 = System.Text.Json.JsonSerializer.Serialize(param_par3, options_par3);
            File.WriteAllText("json.json", json_par3);

            break;

        case "4" when selectedcity == "Париж":
            Stars = "4";
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 4 звезды");
            string paris4 = psg4.SelectRandomHotel(psg4.psg4);

            ReplyKeyboardMarkup reload_par4 = new(new[]
{
                new KeyboardButton[] { "Спасибо" },
                 new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message reaload_par4 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Если вам не нравится, можно поменять, а если норм, то вернём вас в начало",
            replyMarkup: reload_par4,
            cancellationToken: cancellationToken);

            InlineKeyboardMarkup inlineKeyboard_psg4 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url: paris4)
});

            Message sentMessage4 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard_psg4,
                cancellationToken: cancellationToken);

            var result_par4 = myDatabase.InsertData($"{message.Chat.Id}", "France", "Paris", "4", $"{paris4}");

            json param_par4 = new json()
            {
                Country = selectedcountry,
                City = selectedcity,
                Stars = Stars,
                Hotels = paris4
            };


            var options_par4 = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string json_par4 = System.Text.Json.JsonSerializer.Serialize(param_par4, options_par4);
            File.WriteAllText("json.json", json_par4);

            break;

        case "5" when selectedcity == "Париж":
            Stars = "5";
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 5 звёзд");
            string paris5 = psg5.SelectRandomHotel(psg5.psg5);

            ReplyKeyboardMarkup reload_par5 = new(new[]
{
                new KeyboardButton[] { "Спасибо" },
                 new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message reaload_par5 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Если вам не нравится, можно поменять, а если норм, то вернём вас в начало",
            replyMarkup: reload_par5,
            cancellationToken: cancellationToken);

            InlineKeyboardMarkup inlineKeyboard_psg5 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url: paris5)
});

            Message sentMessage5 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard_psg5,
                cancellationToken: cancellationToken);

            var result_par5 = myDatabase.InsertData($"{message.Chat.Id}", "France", "Paris", "5", $"{paris5}");

            json param_par5 = new json()
            {
                Country = selectedcountry,
                City = selectedcity,
                Stars = Stars,
                Hotels = paris5
            };


            var options_par5 = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string json_par5 = System.Text.Json.JsonSerializer.Serialize(param_par5, options_par5);
            File.WriteAllText("json.json", json_par5);

            break;




    }

    switch (message.Text)
    {
        case "Обновить" when selectedcity == "Париж" && Stars == "1":
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 1 звезду");

            string paris_reload1 = psg1.SelectRandomHotel(psg1.psg1);

            ReplyKeyboardMarkup reload_bar1 = new(new[]
  {
                 new KeyboardButton[] { "Спасибо" },
                new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message realodbar1 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Обновили",
            replyMarkup: reload_bar1,
            cancellationToken: cancellationToken);


            InlineKeyboardMarkup inlineKeyboard1 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url: paris_reload1)
});

            Message sentMessage1 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard1,
                cancellationToken: cancellationToken);


            break;

        case "Обновить" when selectedcity == "Париж" && Stars == "2":
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 2 звезды");

            string paris_reload2 = psg2.SelectRandomHotel(psg2.psg2);

            ReplyKeyboardMarkup reload_bar2 = new(new[]
  {
                new KeyboardButton[] { "Спасибо" },
                new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message realodbar2 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Обновили",
            replyMarkup: reload_bar2,
            cancellationToken: cancellationToken);


            InlineKeyboardMarkup inlineKeyboard_bar2 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url:  paris_reload2)
});

            Message sentMessage_bar2 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard_bar2,
                cancellationToken: cancellationToken);


            break;

        case "Обновить" when selectedcity == "Париж" && Stars == "3":
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 3 звезды");

            string paris_reload3 = psg3.SelectRandomHotel(psg3.psg3);

            ReplyKeyboardMarkup reload_bar3 = new(new[]
  {
                new KeyboardButton[] { "Спасибо" },
                new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message realodbar3 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Обновили",
            replyMarkup: reload_bar3,
            cancellationToken: cancellationToken);


            InlineKeyboardMarkup inlineKeyboard_bar3 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url:   paris_reload3)
});

            Message sentMessage_bar3 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard_bar3,
                cancellationToken: cancellationToken);


            break;

        case "Обновить" when selectedcity == "Париж" && Stars == "4":
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 4 звезды");

            string paris_reload4 = psg4.SelectRandomHotel(psg4.psg4);

            ReplyKeyboardMarkup reload_bar4 = new(new[]
  {
                new KeyboardButton[] { "Спасибо" },
                new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message realodbar4 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Обновили",
            replyMarkup: reload_bar4,
            cancellationToken: cancellationToken);


            InlineKeyboardMarkup inlineKeyboard_bar4 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url:  paris_reload4)
});

            Message sentMessage_bar4 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard_bar4,
                cancellationToken: cancellationToken);


            break;

        case "Обновить" when selectedcity == "Париж" && Stars == "5":
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 5 звезд");

            string paris_reload5 = psg5.SelectRandomHotel(psg5.psg5);

            ReplyKeyboardMarkup reload_bar5 = new(new[]
  {
                new KeyboardButton[] { "Спасибо" },
                new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message realodbar5 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Обновили",
            replyMarkup: reload_bar5,
            cancellationToken: cancellationToken);


            InlineKeyboardMarkup inlineKeyboard_bar5 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url:   paris_reload5)
});

            Message sentMessage_bar5 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard_bar5,
                cancellationToken: cancellationToken);


            break;

    }

    switch (message.Text)
    {
        case "Тулуза":
            selectedcity = "Тулуза";
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали {message.Text}");
            ReplyKeyboardMarkup keycitybar = new(new[]
    {
                new KeyboardButton[] { "4", "5" },
new KeyboardButton[] { "1", "2", "3" }


})
            {
                ResizeKeyboard = true
            };

            Message citybar = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Выбери количество звёзд",
            replyMarkup: keycitybar,
            cancellationToken: cancellationToken);


            break;

        case "1" when selectedcity == "Тулуза":
            Stars = "1";

            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 1 звезду");
            string tulusa1 = tul1.SelectRandomHotel(tul1.tul1);

            ReplyKeyboardMarkup reload_tul1 = new(new[]
{
                new KeyboardButton[] { "Спасибо" },
                 new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message reaload_tul1 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Если вам не нравится, можно поменять, а если норм, то вернём вас в начало",
            replyMarkup: reload_tul1,
            cancellationToken: cancellationToken);

            InlineKeyboardMarkup inlineKeyboard_tul1 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url: tulusa1)
});

            Message sentMessage1 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard_tul1,
                cancellationToken: cancellationToken);




            var result_tulusa1 = myDatabase.InsertData($"{message.Chat.Id}", "France", "Tulusa", "1", $"{tulusa1}");

            json param_tul1 = new json()
            {
                Country = selectedcountry,
                City = selectedcity,
                Stars = Stars,
                Hotels = tulusa1
            };


            var options_tul1 = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string json_tul1 = System.Text.Json.JsonSerializer.Serialize(param_tul1, options_tul1);
            File.WriteAllText("json.json", json_tul1);

            break;

        case "2" when selectedcity == "Тулуза":
            Stars = "2";
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 2 звезды");
            string tulusa2 = tul2.SelectRandomHotel(tul2.tul2);

            ReplyKeyboardMarkup reload_tul2 = new(new[]
{
                new KeyboardButton[] { "Спасибо" },
                 new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message reaload_tul2 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Если вам не нравится, можно поменять, а если норм, то вернём вас в начало",
            replyMarkup: reload_tul2,
            cancellationToken: cancellationToken);

            InlineKeyboardMarkup inlineKeyboard_tul2 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url: tulusa2)
});

            Message sentMessage2 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard_tul2,
                cancellationToken: cancellationToken);

            var result_tulusa2 = myDatabase.InsertData($"{message.Chat.Id}", "France", "Tulusa", "2", $"{tulusa2}");

            json param_tul2 = new json()
            {
                Country = selectedcountry,
                City = selectedcity,
                Stars = Stars,
                Hotels = tulusa2
            };


            var options_tul2 = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string json_tul2 = System.Text.Json.JsonSerializer.Serialize(param_tul2, options_tul2);
            File.WriteAllText("json.json", json_tul2);

            break;

        case "3" when selectedcity == "Тулуза":
            Stars = "3";
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 3 звезды");
            string tulusa3 = tul3.SelectRandomHotel(tul3.tul3);

            ReplyKeyboardMarkup reload_tul3 = new(new[]
{
                new KeyboardButton[] { "Спасибо" },
                 new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message reaload_tul3 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Если вам не нравится, можно поменять, а если норм, то вернём вас в начало",
            replyMarkup: reload_tul3,
            cancellationToken: cancellationToken);

            InlineKeyboardMarkup inlineKeyboard_tul3 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url: tulusa3)
});

            Message sentMessage3 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard_tul3,
                cancellationToken: cancellationToken);

            var result_tulusa3 = myDatabase.InsertData($"{message.Chat.Id}", "France", "Tulusa", "3", $"{tulusa3}");

            json param_tul3 = new json()
            {
                Country = selectedcountry,
                City = selectedcity,
                Stars = Stars,
                Hotels = tulusa3
            };


            var options_tul3 = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string json_tul3 = System.Text.Json.JsonSerializer.Serialize(param_tul3, options_tul3);
            File.WriteAllText("json.json", json_tul3);

            break;

        case "4" when selectedcity == "Тулуза":
            Stars = "4";
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 4 звезды");
            string tulusa4 = tul4.SelectRandomHotel(tul4.tul4);

            ReplyKeyboardMarkup reload_tul4 = new(new[]
{
                new KeyboardButton[] { "Спасибо" },
                 new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message reaload_tul4 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Если вам не нравится, можно поменять, а если норм, то вернём вас в начало",
            replyMarkup: reload_tul4,
            cancellationToken: cancellationToken);

            InlineKeyboardMarkup inlineKeyboard_tul4 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url: tulusa4)
});

            Message sentMessage4 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard_tul4,
                cancellationToken: cancellationToken);

            var result_tulusa4 = myDatabase.InsertData($"{message.Chat.Id}", "France", "Tulusa", "4", $"{tulusa4}");

            json param_tul4 = new json()
            {
                Country = selectedcountry,
                City = selectedcity,
                Stars = Stars,
                Hotels = tulusa4
            };


            var options_tul4 = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string json_tul4 = System.Text.Json.JsonSerializer.Serialize(param_tul4, options_tul4);
            File.WriteAllText("json.json", json_tul4);

            break;

        case "5" when selectedcity == "Тулуза":
            Stars = "5";
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 5 звёзд");
            string tulusa5 = tul5.SelectRandomHotel(tul5.tul5);


            ReplyKeyboardMarkup reload_tul5 = new(new[]
{
                new KeyboardButton[] { "Спасибо" },
                 new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message reaload_tul5 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Если вам не нравится, можно поменять, а если норм, то вернём вас в начало",
            replyMarkup: reload_tul5,
            cancellationToken: cancellationToken);

            InlineKeyboardMarkup inlineKeyboard_tul5 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url: tulusa5)
});

            Message sentMessage5 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard_tul5,
                cancellationToken: cancellationToken);

            var result_tulusa5 = myDatabase.InsertData($"{message.Chat.Id}", "France", "Tulusa", "5", $"{tulusa5}");

            json param_tul5 = new json()
            {
                Country = selectedcountry,
                City = selectedcity,
                Stars = Stars,
                Hotels = tulusa5
            };


            var options_tul5 = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string json_tul5 = System.Text.Json.JsonSerializer.Serialize(param_tul5, options_tul5);
            File.WriteAllText("json.json", json_tul5);

            break;




    }

    switch (message.Text)
    {
        case "Обновить" when selectedcity == "Тулуза" && Stars == "1":
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 1 звезду");
            string tulusa_reload1 = tul1.SelectRandomHotel(tul1.tul1);

            ReplyKeyboardMarkup reload_bar1 = new(new[]
  {
                 new KeyboardButton[] { "Спасибо" },
                new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message realodbar1 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Обновили",
            replyMarkup: reload_bar1,
            cancellationToken: cancellationToken);


            InlineKeyboardMarkup inlineKeyboard1 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url: tulusa_reload1)
});

            Message sentMessage1 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard1,
                cancellationToken: cancellationToken);


            break;

        case "Обновить" when selectedcity == "Тулуза" && Stars == "2":
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 2 звезды");

            string tulusa_reload2 = tul2.SelectRandomHotel(tul2.tul2);

            ReplyKeyboardMarkup reload_bar2 = new(new[]
  {
                new KeyboardButton[] { "Спасибо" },
                new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message realodbar2 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Обновили",
            replyMarkup: reload_bar2,
            cancellationToken: cancellationToken);


            InlineKeyboardMarkup inlineKeyboard_bar2 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url:  tulusa_reload2)
});

            Message sentMessage_bar2 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard_bar2,
                cancellationToken: cancellationToken);


            break;

        case "Обновить" when selectedcity == "Тулуза" && Stars == "3":
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 3 звезды");

            string tulusa_reload3 = tul3.SelectRandomHotel(tul3.tul3);

            ReplyKeyboardMarkup reload_bar3 = new(new[]
  {
                new KeyboardButton[] { "Спасибо" },
                new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message realodbar3 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Обновили",
            replyMarkup: reload_bar3,
            cancellationToken: cancellationToken);


            InlineKeyboardMarkup inlineKeyboard_bar3 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url:   tulusa_reload3)
});

            Message sentMessage_bar3 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard_bar3,
                cancellationToken: cancellationToken);


            break;

        case "Обновить" when selectedcity == "Тулуза" && Stars == "4":
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 4 звезды");

            string tulusa_reload4 = tul4.SelectRandomHotel(tul4.tul4);

            ReplyKeyboardMarkup reload_bar4 = new(new[]
  {
                new KeyboardButton[] { "Спасибо" },
                new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message realodbar4 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Обновили",
            replyMarkup: reload_bar4,
            cancellationToken: cancellationToken);


            InlineKeyboardMarkup inlineKeyboard_bar4 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url:  tulusa_reload4)
});

            Message sentMessage_bar4 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard_bar4,
                cancellationToken: cancellationToken);


            break;

        case "Обновить" when selectedcity == "Тулуза" && Stars == "5":
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Вы выбрали 5 звезд");

            string tulusa_reload5 = tul5.SelectRandomHotel(tul5.tul5);

            ReplyKeyboardMarkup reload_bar5 = new(new[]
  {
                new KeyboardButton[] { "Спасибо" },
                new KeyboardButton[] { "Обновить" }



})
            {
                ResizeKeyboard = true
            };

            Message realodbar5 = await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Обновили",
            replyMarkup: reload_bar5,
            cancellationToken: cancellationToken);


            InlineKeyboardMarkup inlineKeyboard_bar5 = new(new[]
{
    InlineKeyboardButton.WithUrl(
        text: "Подобрал для вас вариант",
        url:   tulusa_reload5)
});

            Message sentMessage_bar5 = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Подобрал для тебя вариант",
                replyMarkup: inlineKeyboard_bar5,
                cancellationToken: cancellationToken);


            break;

    }

    switch (message.Text)
    {
        case "Спасибо":
            await botClient.SendTextMessageAsync(message.Chat.Id, $"Обращайтесь. Возвращаем вас на начало");
            ReplyKeyboardMarkup replyKeyboardMarkup = new(new[]
{
    new KeyboardButton[] { "🇪🇸", "🇫🇷" }

})
            {
                ResizeKeyboard = true
            };

            Message keyboard = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Выбери страну",
                replyMarkup: replyKeyboardMarkup,
                cancellationToken: cancellationToken);

            break;
    }

}



    













