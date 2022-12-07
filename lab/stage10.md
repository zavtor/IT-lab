## REST web-сервіси

Створимо проект за шаблоном ASP.NET Web API та напишемо відповідні REST API методи для GET, POST, PUT та DELETE-запитів в API-контролерах. Для зручного тестування запитів у браузері до проекту підключено Swagger/Swashbuckle.
Згідно з концепцією HATEOAS, при поверненні результату роботи запиту над певним об’єктом ми маємо включити також набір посилань на інші запити, що відповідають діям, які можна виконати над даним об’єктом або його складовими. Для цього створимо клас Response, що включатиме в себе копію об’єкта Value та набір іменованих посилань Links:

- [Response](https://github.com/zavtor/IT-lab/blob/main/Containers/RestWebApi/Response.cs)

Також до проекту додамо OpenAPI Specification, яку реалізуємо за допомогою XML-коментарів над кожним запитом. Для того щоб Swagger включав нашу документацію до опису запитів та відповідей, потрібно внести наступний код у метод ConfigureServices класу Startup:

- [ConfigureServices](https://github.com/zavtor/IT-lab/blob/main/Containers/RestWebApi/ConfigureServices.cs)

Тепер наведемо приклад методу, що відповідає запиту на оновлення рядку.
- [UpdateRow](https://github.com/zavtor/IT-lab/blob/main/Containers/RestWebApi/UpdateRow.cs)

Нижче наведено приклад виконання POST-запиту створення бази даних:

![Post-request](https://github.com/zavtor/IT-lab/blob/main/png/stage10/1.png)

У запитах також враховані можливі помилкові ситуації: наприклад, якщо ми спробуємо отримати список рядків ще не створеної таблиці, то буде виведено повідомлення про помилку:

![Validation](https://github.com/zavtor/IT-lab/blob/main/png/stage10/2.png)

Відповідні коментарі до статус-кодів можна дослідити перед виконанням запиту:
![Coments](https://github.com/zavtor/IT-lab/blob/main/png/stage10/3.png)
