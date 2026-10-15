void Main()
 
    {
        bool isStudent = true;
        bool isPensioner = false;
        bool hasClubCard = true;

        // Логическое выражение: (или студент, или пенсионер) И обязательно есть клубная карта
        if ((isStudent || isPensioner) && hasClubCard)
        {
            print("Поздравляем! Вам доступна максимальная скидка 30% на билет.");
        }
        else if (isStudent || isPensioner)
        {
            print("У вас льготный статус, но без клубной карты скидка только 10%.");
        }
        else
        {
            print("Скидки не предусмотрены. Стандартная стоимость билета.");
        }
    }















    // {
    //     double sum = 3500; // Сумма в сомах
    //     double discountPercent = 0;

    //     // Определяем размер скидки в зависимости от суммы
    //     if (sum >= 5000)
    //     {
    //         discountPercent = 25.0; // 25% скидка
    //     }
    //     else if (sum >= 3000)
    //     {
    //         discountPercent = 15.0; // 15% скидка
    //     }
    //     else
    //     {
    //         discountPercent = 5.0;  // 5% минимальная скидка
    //     }

    //     // Вычисление итоговой суммы
    //     double discountAmount = sum * (discountPercent / 100);
    //     double finalSum = sum - discountAmount;

    //     // Вывод с использованием интерполяции строк ($)
    //     print($"Исходная сумма: {sum} сом.");
    //     print($"Вам предоставлена скидка: {discountPercent}%");
    //    print ($"Сумма скидки: {discountAmount} сом.");
    //     print($"Итого к оплате: {finalSum} сом.");
    // }















    // {
    //     string name = "Тимур";
    //     string status = "студент";

         
    //     if (name == "Тимур" && status == "студент")
    //     {
    //         print($"Добро пожаловать, {name}! Ваш статус: {status}. Доступ к студенческому порталу разрешен.");
    //     }
    //     else if (status == "рабочий" || status == "клерк")
    //     {
    //         print($"Здравствуйте, {name}. Вы сотрудник компании, доступ ограничен рабочим временем.");
    //     }
    //     else
    //     {
    //         print($"Пользователь {name} со статусом '{status}' не распознан системой.");
    //     }
    // }
