# Telegram-booking-bot
Это мой первый телеграмм бот на C#. Он умеет подбирать гостинницы, основываясь на предопчтениях пользователя (гостинницы подбираются рандомно). 
Так же программа записывает выборы пользователя в json файл и в PostgreSQL.


В файле json мы создаём свойства для будущей записи выбора пользователем страны, города, количества звёзд и выдачу ему гостинницы.


В файде bd  код является примером класса MyDatabase, который обеспечивает подключение к базе данных PostgreSQL и позволяет вставлять данные в таблицу Resort.
В конструкторе класса задается строка подключения к базе данных с помощью параметров хоста, порта, имени базы данных, имени пользователя и пароля.
Метод InsertData используется для вставки данных в таблицу Resort.
Он создает новое подключение к базе данных с помощью строки подключения, формирует запрос INSERT, указывая параметры, и выполняет его с помощью метода ExecuteNonQuery. 
Затем метод возвращает объект Params, содержащий значения вставленных параметров.
Функция Main создает экземпляр класса MyDatabase и передает ему параметры подключения к базе данных.

В файле Class1 (приведу пример лишь с одним случаем, так как остальные делаются по такому же методу) мы объявляем класс Class1 с открытым полем списка строк "barcelona" и двумя методами. 
Конструктор Class1() инициализирует список "barcelona" четырьмя URL-адресами отелей в Барселоне. 
Метод SelectRandomHotel(List<string> hotels) возвращает случайный URL-адрес из списка "barcelona" при помощи класса Random.
Таким образом, этот код генерирует случайный URL-адрес отеля в Барселоне из списка "barcelona", который можно использовать для бронирования отеля

Ну и в основном файле Program.cs мы создаём подключение к телеграмм боту, делаем стандартные подключения Telegram bot API и заставляем наш код работать
