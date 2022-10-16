Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
Алгоритм решения:
Задать начальный массив строк и заполнить его.
Узнать сколько строк из массива удовлетворяют условию длинны (не более 3х символов)
Создать новый массив строк и заполнить его значениями из начального массива значениями удовлетворяющими условию длинны (не более 3х символов).
Вывести в консоль начальный массив и конечный.