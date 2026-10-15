void Main()
    
    void Main()
    {
        // Задаем день недели прямо в коде
        string day = "суббота";

        switch (day.ToLower())
        {
            case "понедельник":
            case "вторник":
            case "среда":
            case "четверг":
            case "пятница":
                print($"День недели '{day}' — это рабочий день.");
                break;

            case "суббота":
            case "воскресенье":
                print($"День недели '{day}' — это выходной день!");
                break;

            default:
                print("Ошибка: некорректный день недели.");
                break;
        }
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    // {
    //     string token = "красный";

    //     switch (token.ToLower())
    //     {
    //         case "зеленый":
    //             Console.WriteLine("Ваш напиток: Эспрессо.");
    //             break;
    //         case "красный":
    //             print("Ваш напиток: Капучино.");
    //             break;
    //         case "синий":
    //             print("Ваш напиток: Латте.");
    //             break;
    //         default:
    //             print("Ошибка: неверный жетон.");
    //             break;
    //     }
    // }
