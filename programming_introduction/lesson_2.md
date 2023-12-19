## РАНЕЕ НА КУРСЕ

Ранее мы рассматривали несколько основных вопросов. 
● Аналогии с обычными языками.
● Различные способы поиска максимального элемента, например, у нас была морковка, с 
помощью которой мы с вами могли найти максимальный элемент из 5.
● Разные формы записи алгоритма, например, текстом или блок-схемой. Смотрели, как 
писать реальный код на Python и Java.

## НА ЭТОМ УРОКЕ

Сегодня мы перейдём к структурам данных. Звучит всё очень масштабно и сильно. Но на самом 
деле ничего сложного нет, мы с ними познакомимся. 

Помимо этого, мы посмотрим на простые алгоритмы с этими структурами, в первую очередь 
массив. И какие алгоритмы есть в этом массиве, попробуем перерешать заново задачи, 
которые были у нас на первом занятии и посмотрим, как они будут решаться, если использовать 
массивы. 


## СТРУКТУРА ДАННЫХ


Составление программы и написание кода - это две разные области профессиональной деятельности. Вероятно, у многих из вас возникает вопрос: "Зачем нам нужны эти блок-схемы? Мы же пришли учиться программировать, тестировать программы или заниматься аналитикой."

Давайте кратко вернемся к истории. Изначально составление алгоритмов и программ и написание кода были двумя различными профессиями. Некоторые люди разрабатывали алгоритмы, определяя, что нужно сделать компьютеру, в то время как другие трансформировали эти алгоритмы в код, чтобы они могли выполняться на конкретной машине. В эпоху огромных ЭВМ (электронных вычислительных машин) код нужно было передавать в машину для выполнения. Таким образом, составление программы и ввод кода в машину, чтобы она могла выполнить его, представляли собой две разные профессии и задачи.

Можно провести параллель с бытовым уровнем, вспомнив стенографистов, которые ранее записывали текст на печатных машинах (сейчас на компьютерах), и тех, кто произносил этот текст. Составление текста и его запись - это разные профессии. Хотя запись текста требует знания определенных условий и синтаксиса, и требует умения оформлять текст правильно, использовать определенные обороты и вносить исправления - это отдельная профессия, которую нужно освоить.

То же самое происходит в программировании. Сначала мы занимаемся составлением программ, разрабатывая алгоритмы и решая, какие действия необходимо совершить, в каком порядке, какие переменные нам нужны и что мы с ними будем делать. Затем идет этап написания самой программы, когда алгоритм уже готов, и нужно просто записать его на выбранном языке программирования. Мы выбираем язык в зависимости от задачи и, основываясь на синтаксисе и принципах языка, записываем решение. Это подразумевает выполнение программы. В большинстве обучающих программ обычно не разделяют эти две части, но моя цель на этом курсе - именно разделить эти две профессии.

В первую очередь мы будем заниматься составлением алгоритмов и программ, их анализом. Затем, переходя к следующему курсу, мы начнем программирование на конкретном языке, записывая составленные алгоритмы согласно синтаксису выбранного языка. Позже вы сможете запускать программы, следить за их выполнением. Но сейчас наша задача - разделить эти две профессии.

## МАССИВЫ

Теперь перейдём к структурам данных. Иногда удобнее работать с какими-то данными, если 
они подчиняются определённым взаимосвязям и у них есть структура. Массив — это самая 
первая структура, с которой чаще всего знакомятся. На самом деле, вы с ним уже практически 
знакомы. 

Пример с гирями

Когда мы искали максимальный элемент из 5. Мы уже говорили, что вот 1 гиря, 2 гиря, 3 гиря, 
4 гиря, 5 гиря. То есть у гирь уже были номера. 

Между ними уже была взаимосвязь, был какой-то порядок. 

Так вот, когда у нас есть взаимосвязь по индексу (номеру у этих объекта), тогда мы можем сказать, что у нас практически есть массив. 

Есть некоторая структура. У нас это гирьки, стоящие на столе. Они взаимосвязаны, имеют индекс, по которому их можно найти. 

Массив — это структура данных, в которой можно по индексу найти определённый объект. 

Теперь посмотрим, а для чего же массив нужен? У нас было 5 гирек и мы прекрасно обходились без массивов. 

Представим, что будет не 5 гирек, а 100 гирек. Если у нас 26 букв английского 
алфавита ещё есть, и первые 26 гирек, мы можем переименовать так же, как делали a, b, c, d, 
e, то с остальными непонятно, что делать? 

Нам нужно будет придумать, какие-то составные имена. В принципе, блок с инициализацией после заведения этих переменных станет очень большим. 

Это будет крайне неудобно менять. Далее, когда нам нужно будет перебирать эти гирьки, вспоминать, какую гирьку мы уже посмотрели, а с какой надо работать дальше? 

Именно поэтому гораздо удобнее, если объекты однотипные, заводить их в какую-то структуру. 

## Формула поиска n-ого элемента в массиве

Для этого есть формула:

an = start + (n-1) * cell_size

В качестве an будем рассматривать любую ячейку массива. Например, если нам нужно найти 
первый элемент массива, тогда вместо n поставим 1. Вот а1 это первый элемент нашего 
массива. 

Далее start — это адрес первой ячейки (места, откуда начинается массив). Если он нам известен, 
а он должен быть известен, потому что это один из обязательных параметров, то подставляем 
его. 

Дальше почему-то n-1, с этим сейчас разберёмся. 

Теперь умножаем, получившееся здесь, количество на cell_size (с английского cell — ячейка, size — размер). 

Как формула работает на нашем котике

Есть cat, мы знаем, что у нас: 
* массив начинается в ячейке 127, поэтому start = 127; 
* каждый элемент занимает ровно одну ячейку, поэтому cell_size = 1;
* всего три таких элемента. 

Теперь найдём, например, адрес первого элемента. Ищем а1.
* start = 127, то есть ячейка под номером 127. 
* N-1, мы ищем первый элемент, поэтому 1 - 1 = 0. 
* Cell_size = 1.
* В результате — а1 = 127 + 0×1, то есть а1 = 127. 

Таким образом, мы понимаем, что первый элемент нашего массива буковка «c» находится в 
ячейке 127. Теперь вы, наверное, догадались, почему мы вычитаем 1, если бы не вычитали, то 
эта формула работала бы неправильно. При такой нумерации элементов нам приходится 
вычитать 1.

Попробуем по аналогии найти, например, третий элемент букву «t». Что у нас получается? 
* А3 = 127 + (3–1). 
* Умножаем на cell_size. Cell_size = 1. 
* Получаем 127+2×1=129. Третий элемент буква «t» находится в ячейке с номером 129. 

Таким образом, если вам заранее известны все параметры массива, то вот по такой простой 
формуле вы можете найти любой элемент этого массива

### Разберём задачу с прошлого лекции

Теперь познакомившись с массивами, посмотрим, как можно было решить задачу с прошлого 
занятия, используя структуру данных. 

У меня есть стаканчики, для удобства их расставлю. У нас было 1, 8, 3, 2, 6. Допустим, вот так 
они у нас стояли. Мы искали максимальный. Но нам приходилось именовать каждый из них. 

Был стаканчик а, стаканчик b, c, d, e. Но как я уже говорил, таких стаканчиков может быть очень 
много, например, 100 стаканчиков и имён всем не хватит. 

Мы можем рассматривать то, что есть сейчас как массив. Имеется 5 элементов. Мы знаем, что 
каждая гирька имеет размер. Есть 1 гирька, рядом с ней стоят 2, 3, 4, 5. Помимо этого, мы по 
индексу легко можем их получить. Мне нужна третья гирька, я отсчитываю номер 3. Она ещё 
совпадает с весом гирьки. 

Прежде чем перейдём дальше, мы должны обсудить один очень важный момент. Когда считаем 
объекты сами, мы считаем 1, 2, 3, 4, 5, но программисты любят всё оптимизировать. И эта часть 
в нашей формуле им не нравится. Нам приходится каждый раз, когда мы ищем какой-то 
элемент делать дополнительные вычисления, а это нагрузка на наш процессор. Что придумали 
программисты? Программисты решили, что нумеровать элементы массива мы будем не с 1, как 
привыкли считать в обычной жизни, а с 0. Эта гирька будет не первой, а нулевой. А эта гирька 
будет не второй, а с индексом 1. Чтобы не путаться, мы будем говорить, что эта гирька будет с 
индексом 0, эта с индексом 1 и т. д. 

Что произойдёт? Если вместе с n, вместо 1 (первого элемента), поставить индекс 0, тогда можно 
не вычитать 1. Я начинаю от старта, для нулевого индекса здесь автоматически станет 0. То 
есть вместо n-1, я просто оставлю n, где n теперь индекс элемента.

### Решаем задачу с помощью массива

Нужно понять, как к индексу можно обращаться. 

Представим блок-схему. Раньше были переменные a, b, c, d и т. д. Потом мы водили переменные, состоявшие из нескольких слов (firstFriendSpeed, secondFriendSpeed). 

Теперь у нас появляются новый объект, назовём его — numbers (от английского — числа). Считается хорошим тоном, когда вы именуете переменные заложенным в них смыслом. 

В нашей переменной numbers будет храниться массив, то есть набор некоторых элементов с определённым порядком. Элементы нам хорошо известно, это число 1, 8, 3, 2, 6. 

Масса гирек или цифры на стаканчиках, с которыми мы работали. 

Вводим переменную size, говорящую о размере массива. 

Теперь нам нужен индекс. Мы будем стартовать с самого начала, поэтому индекс возьмём равным 0. Потому что у самого первого элемента нашего массива индекс равен 0. 

Также мы введём наш максимум это первый элемент. 

Если раньше у нас было написано, что максимум равен «а», то сейчас первую гирьку зовут не 
«а», её зовут numbers с индексом 0. Именно так можно получить элемент нашего массива. 

Есть массив numbers, в квадратных скобках может быть указан индекс элемента, который мы 
хотим из него достать. Поэтому max = numbers [0], значит то же, что мы до этого писали, max=а 
или max=1, как первая гирька.

### Конструкция цикла

Далее, уже знакомая нам конструкция — это цикл. То есть мы отсюда, в зависимости от ответа 
на вопрос уходим либо по веточке «yes», либо по веточке «no». Но если мы возвращаемся, то 
будем снова отвечать на этот вопрос. И мы будем делать это до тех пор, пока ответ на вопрос 
будет «да». Как только ответ станет «нет», мы выскочим. 

Дальше, мы здесь с вами указываем размер нашего массива. Обратите внимание, мы могли не 
вводить переменную size. И поставить просто число 5. Что тогда бы случилось? 

Если мы поменяли массив и в нём количество элементов стало другим вместо 5, например, 
взяли 10, то нам пришлось бы менять число не только в блоке инициализации, но и внутри 
нашей программы. А как вы помните, мы хотим сделать так, чтобы программа была более или 
менее универсальной. В самом начале мы для этого водили переменные.

Мы именовали гирьки так, чтобы если взять другие гирьки, то менять числа нужно было только в блоках 
инициализации, которые этим гирькам соответствуют, хранящихся в этих переменных. 
Сейчас мы сделали массив, у него есть параметр размера. 

Здесь мы его зафиксировали. Size=5. 

Если мы здесь его не зафиксировали в блоке инициализации, а вот сюда поставили число. 
То когда мы поменяем размер массива, нужно будет обязательно вспомнить и переписать это 
внутри всей программы. 

Поэтому крайне нежелательно внутри программы указывать конкретные числа, которые могут меняться. Вот +1 — это нормально, потому что у вас всегда при любом массиве и любых начальных данных, индекс будет меняться один за одним. Он будет просто расти. 

А если мы говорим, о каких-то параметрах, каких-то вводных данных в вашей программе, то их всегда необходимо определять в каком-то блоке инициализации, в самом начале работы вашей программы. Чтобы внутри не было никаких чисел.

### Разберём запись в псевдокоде

Первые две строчки — это блок инициализации, которые был на блок-схеме. Есть массив 
numbers, заданный нами. 

Ввели переменную size (размер нашего массива). Начинаем алгоритм с того, что пойдём к 
элементу с индексом ноль (самого первого для нас элемента) и возьмём максимальный 
элемент самым первым элементом массива, то есть элемента с индексом 0. 

Теперь начинаем цикл. 

У нас написано:
● while (index < size) do 
Что получается если это перевести? 
● До тех пор, пока индекс меньше размера, делай. 

В очень похожих терминах этот цикл создаётся почти в любых языках программирования. У нас есть:
1. while do циклы;
2. до тех пор;
3. после идёт какое-то условие, которое нам необходимо записать;
4. какой-то призыв к действию, а где-то он может опускаться просто, чтобы язык стал более лаконичны. 

По нашей блок схеме нам нужно было ответить на вопрос, рассматриваемый сейчас элемент массива больше максимального или нет? Опять же, некоторые знания английского языка позволяет нам прочитать написанное. 

while (index < size) do 
If (numbers[index] > max) then
max = numbers[index]
index = index + 1
До тех пор, пока индекс меньше размера, делай.
Если это условие выполняется тогда,делаем эту строку.
Если условие не выполняется, то переходим на эту строку.

### Здача по нахождению скалярного произведения

(a, b) x (c, d) = a x c + b x d

Вот у нас есть некоторые вектор с двумя координатами а и b, и ещё один вектор с координатами 
c и d. Чтобы найти скалярное произведение, нужно соответствующие элементы перемножить 
между собой, то есть, а×с, b×d и потом их сложить. Таким образом, вы найдёте скалярное 
произведение. 

Важно, чтобы количество элементов в каждом из наших массивов (наборов) было одинаковым. 
Если будет разным, то для кого-то не будет соответствующего элемента. Например, если здесь 
было три элемента, а здесь два элемента, то по похожей формуле мы не смогли бы всё 
посчитать. Мы бы первый с первым перемножили, второй со вторым перемножили, а третьему 
просто нет пары. Поэтому скалярное произведение работает только для одинаковых наборов 
элементов.

Скалярным произведением векторов 1, 8 и 3, 2 будет число 19. 

Попробуйте на листочках или в программе для рисования блок-схем, составить блок-схему для подсчёта скалярного произведения. 

![Скалярное произведение](https://sun9-26.userapi.com/impg/YDoETxWt-AfMaOUHRfi3mAArlvjz3SqGim60yQ/yg-Rm2L2Q5Q.jpg?size=1543x2160&quality=95&sign=95779de7a2f32e9d9b41fc402173168d&type=album)

### Пример решения задачи

Итак, я думаю, что все справились с задачей хотя бы для двух элементов. Посмотрим на возможное решение, как эту блок-схему можно было бы записать. Мы с вами что имеем? 

У нас есть опять блока инициализации, и мы с вами вводим два вектора. По аналогии с задачей про друзей и собаку, у нас есть firstVector (1 вектор) и secondVector(2 вектор). 

Допустим, задали числа 1, 8 и 6, 3. Главное, размеры векторов одинаковые и у каждого элемента есть свой напарник из второго вектора. 

Дальше вводим некоторые аккумуляторы. Скорее всего, вы на семинарах уже смотрели, как это работает и для чего нужно. Сюда я буду складывать результат скалярного произведения, соответственно, называю переменную scalarProduct (скалярное произведение). 

Так как туда я буду складывать сумму, мне нужно будет просто прибавлять произведения пар каждых элементов, изначально возьму 0, потому что относительно там сложения 0 это вот нейтральный элемент. Можем прибавлять 0, можем вычитать 0, ничего не поменяется. Поэтому, когда берём аккумулятор для того, чтобы сложение работало, мы берём 0. Ну и опять же мы начинаем с элемента с index 0, поэтому index изначально взяли равным 0. Начинаем наш цикл. 

Сравниваем index со значением размера нашего массива и считаем скалярное произведение. 

Мы в аккумулятор к уже имеющемуся значению, собственно, он аккумулирует эти значения, будем добавлять произведение двух каких-то элементов. 

Берём firstVector с индексом 0 и secondVector с индексом 0, здесь будет из первого вектора 1, из второго вектора 6. 

ScalarProduct сейчас, аккумулятор равен 0. Справа получается 0 + 1 × 6. И в аккумулятор в scalarProduct записывается число 6. 

Переходим дальше, увеличиваем наш индекс. Index теперь стал равен 1, возвращаемся в условия нашего цикла, 1<2, ответ положительный. Соответственно, мы возвращаемся к scalarProduct, сейчас у нас сохранится число 6, потому что на предыдущей итерации мы с вами это записали. 

Итерация — это один проход нашего цикла. 6 плюс firstVector с индексом 1, то 
есть 8, а здесь второй вектор с индексом 1, 3. Получаем 8 × 3 = 24. Здесь стоит 6, здесь 24, сложили, получилось 30. 

30 записали в наш аккумулятор scalarProduct. 

Индекс теперь стал равен 2. 

Возвращаемся снова к нашему условию. Отвечая на вопрос 2<2 или, нет? 

Ответ отрицательный, потому что 2 равно 2. 2 не может быть меньше. Поэтому идём по веточке «no», и печатаем значение нашего скалярного произведения. 

Действительно, скалярное произведение двух этих векторов первого и второго равно 30, как мы с вами и нашли.