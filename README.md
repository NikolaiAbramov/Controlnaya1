### Задача: 

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Описание решения

1. Вводим количество строк и сами строки.
2. Создается новый массив, в котором будут только те строки, длина которых не превышает 3-х символов.
3. Проходим по исходному массиву строк. Первый - чтобы посчитать количество строк длины не более 3 символов, второй - чтобы скопировать эти строки в новый массив.
4. Новый массив строк выводим на экран.

*Примеры*:

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

[“1234”, “1567”, “-2”, “computer science”] → [“-2”]

[“Russia”, “Denmark”, “Kazan”] → []

