# -final-project 
ЗАДАЧА:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решение не рекомендуется пользоваться коллекциями,лучше обойтись исключительно массивами

Алгоритм выполнения задания:
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)

Алгоритм решения задачи.
Блок-схема алгоритма решения задачи находиться в папке алгоритм.

Описание алгоритма решения задачи.
1. Первоначальный массив задан вручную.
2. Объявем второй (новый) массив. Длина второго массива равна длине первоночального массива. 
3. Объявляем переменную count равную нулю, в переменную поочередно будет записывать  строки, длина которых три символа и меньше.
4. В цикле for проходимся по каждой строке массива. На каждой итерации сверяем длину строки, если условие (меньше либо равно трём символам) соблюдается, то элемент первоначального массива записываем в count элемент нового массива. 
5. Инкрементируем count на 1.
6. Возвращемся в цекл for и инкрементируем i (счётчик цикла).
7. Если длина строки массива больше трёх, инкрементируем только счётчик цикла (i++).
