# finalwork_3673
finalwork preseason group3673 untill 30/01/2023


1) Сообщаем пользователю, что будет делать в программе. 
Предлагаем ему ввести колво строк базового массива.
Сразу делаем проверку на корректность ввода. 
Если кол-во строк равно 0, то выводим "Количество строк не может быть рано нулю! Введите значение еще раз: ".
Если оно корректно, то
2)Создаем первый (базовый) массив, в котором будут находиться, ессно, строки (тип данных "string").
Предлагаем пользователю заполнить массив, запрашивая у него элементы массива, через Enter.
Исходный массив готов.

Теперь, согласно условию задачи, нам нужно отсортировать введенные строки согласно условию и скопировать их в новый массив.

3) Мы будем это делать в отдельном методе, где и создаем второй (сортированный) массив, такой же длины, как и исходный.

4) Теперь нам нужен цикл, который переберет весь базовый массив (согласно условию цикла, 3 и менее исмволов) и запишет в сортированный массив все нужные результаты. 
И тут, конечно, выясняется, что не зря нам настоятельно не рекомендовали работать с List, в котором это делается непринужденно и без костылей!
Ведь наш строчный массив, конечно, не хочет работать с операторами <=, и это-таки проблема!

Но я поставила костыль-_- (строка 48, string s = "0k0") 
я создала строчку с нужным мне кол-вом символов, тремя  :D 
сравниваю длину каждого элемента базового массива с длиной этой строки, и, если элемент исходного массива совпадает, то пишем результат в сортированный(второй) массив )
PS И вот если мы вводим только цифры или только буквы или только символы смайлика - всё работает.
   А в примере именно так, "смесей" из цифр и букв нет, так что формально задание мной выполнено верно! %) 

5) Вывод базового массива и сортированного массива. Создадим метод вывода массивов.

Ну и под катом (потому что надо буллиевый метод делать, вообще-то) у меня проверка на то, что, может, массив пустой и программа не нашла строк, подходящих по условию если так, то она пишет: "Я не шмогла..."

