# finalwork_3673
finalwork preseason group3673 untill 30/01/2023


1) Сообщаем пользователю, что будет делать программа. 
Предлагаем ему ввести кол-во строк базового массива.
Сразу делаем проверку на корректность ввода. 
Если кол-во строк (то есть длина будущего массива равна 0), то выводим "Количество элементов массива не должно быть рано нулю! Введите значение еще раз: ".
Если оно корректно, то

2) Создаем первый массив (arrayBase), в котором будут находиться, ессно, строки (тип данных "string").
Предлагаем пользователю заполнить массив, запрашивая ввод элементов массива, через Enter.
Исходный массив готов.

Теперь, согласно условию задачи, нам нужно отсортировать введенные строки согласно условию и скопировать их в новый массив.

3) Мы будем это делать в отдельном методе, где и создаем второй (сортированный) массив, такой же длины, как и исходный.

4) Теперь нам нужен цикл, который переберет весь базовый массив (согласно условию цикла, 3 и менее смволов) и запишет в сортированный массив все нужные результаты. 
И тут, конечно, выясняется, что не зря нам настоятельно не рекомендовали работать с List, в котором это делается легко и непринужденно!

------ ремарка --------

но можно поставить костыль%) 
я создала строчку с нужным мне кол-вом символов, тремя  :D  (строка 48, string s = "0k0") 
Мы создаем массив такой же длины, как и исходный (сейчас я про самый простой путь).
Далее я сравниваю длину каждого элемента базового массива с длиной этой строки, и, если элемент исходного массива совпадает, то пишем результат в сортированный(второй) массив )
PS И вот если мы вводим только цифры или только буквы или только символы смайлика, как в референсном примере - всё работает ("смесей" из цифр и букв нет).
  
  Однако решение, хоть формально и работает, явно  НЕ то, что предполагалось по замыслу автора задачи.
  я его отправила под // =)
-------конец ремарки--------

Нам нужен второй массив для выборки симоволов. Чтоб не делать его избыточным, сделаем сначала метод счетчик (CountSymbols)
и узнаем кол-во элементов длиной менее трех в исходном массиве.
Результат передадим как длину нового массива (arraySorted) уже в новом методе (LessThan3SymbolsArray), который, собственно, и будет записывыать в этот массив нужные по условию задачи элементы. И, так как мы будем сравнивать длину элементов <= 3 - проблем не будет.


5) Вывод базового массива и сортированного массива. Создадим метод вывода массивов.

PS Ну и под вторым катом (потому что надо буллиевый метод делать, вообще-то) у меня проверка на то, что, может, массив пустой и программа не нашла строк, подходящих по условию если так, то она пишет: "Я не шмогла..."

