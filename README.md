# Информационная система по школьному предмету «Алгебра».
### Название приложения: AlgebraApp
### Описание приложения:
**Система предназначена для изучения математических тем, таких как “Понятие алгебраической дроби”, “Упрощение рациональных выражений” и “Понятие квадратного корня”. Пользователи могут свободно перемещаться между темами, а так же добавлять новые материалы.**

# Функции, реализованные в программе:
1. **Просмотр тем.** При запуске программы сразу виден список доступных тем. При нажатии на кнопку “Открыть первую тему” открывается материал по теме, которая находится вверху списка.
2. **Добавление.** При нажатии на кнопку "Добавить тему" откроется соответсвующая форма для заполнения.
3. **Решение уравнений** При нажатии на кнопку "Решение уравнений" откроется форма для вычислений.
4. **Таблица квадратов** При нажатии на кнопку “Таблица квадратов” откроется окно со значениями.

# Технологии, которые были использованы для разработки приложения:
- **C#** - объектно-ориентированный язык программирования.
- **Visual Studio Community 2022** - интегрированная среда разработки (IDE), которая обеспечивает удобное создание, отладку и развертывание приложений.
- **Windows Presentation Foundation** - система для построения клиентских приложений Windows с визуально привлекательными возможностями взаимодействия с пользователем, графическая подсистема в составе .NET Framework, использующая язык XAML.
- **SQLite** - компактная встраиваемая СУБД.
- **Microsoft.Data.Sqlite** — это упрощённый поставщик ADO.NET для SQLite.

# Описание базы данных:
#### Файл базы данных называется algebra.db <br/>
Файл базы данных расположен локально в проекте по пути **Algebra\Algebra\bin\Debug** </br>
В базе данных находится 2 таблицы: _Theme_, которая состоит из колонок _id_, _nameTheme_, _contentTheme_. В этой таблице храняться все темы по алгебре, доступные для чтения в приложении. _tableSquares_, которая состоит из колонок _id_, _number_, _result_. В этой таблице храняться значения таблицы квадратов.

# Скриншоты приложения:

![Главная страница](https://github.com/vanyaokblog/PhysicApp/blob/main/Screenshots/MainWindow.png)
## Главная страница
</br> </br> </br>

![Просмотр темы, выбранной из списка](https://github.com/vanyaokblog/PhysicApp/blob/main/Screenshots/TopicWin.png)
## Просмотр темы, выбранной из списка
</br> </br> </br>

![Добавление данных](https://github.com/vanyaokblog/PhysicApp/blob/main/Screenshots/AddWin.png)
## Добавление данных
</br> </br> </br>

![Калькулятор по закону Ома](https://github.com/vanyaokblog/PhysicApp/blob/main/Screenshots/OhmsWin.png)
## Калькулятор по закону Ома
</br> </br> </br>

![Перевод единиц силы тока](https://github.com/vanyaokblog/PhysicApp/blob/main/Screenshots/CurrentConverterWin.png)
## Перевод единиц силы тока
</br> </br> </br>