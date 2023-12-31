## Языки программирования и подходы к обучению. Есть ли жизнь после Java и призмы языков программирования
Лекция

Есть один небольшой риторический вопрос: «Есть ли жизнь после Java?». 

Java  - язык с достаточно сильно выраженными особенностями. 
То, как пишут на языке Java, редко пишут на других языках. В связи с этим есть проблемы.

Для джавистов есть даже такое выражение: «Java головного мозга». Потому что те, кто начал с языка программирования Java, продолжают писать так, как было в первом языке. 

Это свойственно не только для Java, но и практически для любого другого языка. 

### Пример из жизни:

Мы привыкли, что лягушки квакают. И в детских сказках, и в обиходе считается, что если лягушка издаёт какой-то звук, то это, скорее всего, «ква-ква». Но если вы спросите у какого-то иностранного гражданина, например, у англичанина или кого-то ещё, как, на его взгляд, квакают лягушки, то удивитесь. Вроде бы те же самые звуки, а произносят они их совершенно иначе.

Например, на слайде, где изображена лягушка иностранного гражданина, указано слово «риббит». Так издаёт звуки лягушка, по мнению англичан. То есть у них они не квакают, а говорят «риббит». Есть ещё «бреккеке» и «уп-уп» — предположительно, так говорят лягушки в Индонезии.

Вы можете выполнить одно лёгкое упражнение — набрать в Google «как квакают лягушки в разных странах» и посмотреть множество примеров, где люди пытаются подражать лягушкам.

Однако важно понимать, что лягушки на самом деле квакают одинаково, плюс-минус выходит один и тот же звук. Это люди интерпретируют его по-разному

### Шеф-повор

Представьте, что у вас есть знакомый шеф-повар, которому вы решили помочь. И он просит вас снять кожицу с помидора. 

Если повар будет пользоваться профессиональным языком, на котором он общается на кухне в ресторане, то скажет: «Бланшируй томаты». 

Для людей, хорошо знакомых с процессом приготовления пищи, кто уже работал на кухне, будет всё понятно. Но если вы увидели слово «бланшируй» в первый раз, то можете не понять, что же надо сделать. 

Исходя из того, кто выступает слушателем информации, которую хотите донести, надо выбирать правильный язык.

Если мы хотим, чтобы с помидоров сняли кожицу, потребуется сказать несколько по-другому: «Сделай надрезы на помидорах, опусти их на несколько минут в кипящую воду, потом достань и положи в холодную воду. 

После этого через несколько минут достань помидоры из воды и сними с них кожицу». 

Таким образом, поймёт обыватель. А если мы говорим о шеф-поваре на кухне, который общается с опытными сотрудниками, он скажет: «Бланшируй томаты».

Это относится ко всем сферам. Если мы говорим о математике и при этом пытаемся объяснить то, что делаем, не математику, писать квантово смысла нет. А если говорим о нотной грамоте и хотим ей пользоваться, надо понимать, что человек, которому мы это объясняем, знает её.


## Практика

Дано 5 гирь, все раазного веса. Найти вес самой тяжелой гири. Взять можно одну или несколько гирь. Запомнить вес. Поменять гири местами.

![Моя блок-схема](https://sun9-29.userapi.com/impg/C1LlmZX0dwcv0J0rMFSepWXfPSDCIzojQzvxBw/ExC09xUbhZk.jpg?size=1543x2160&quality=95&sign=4ecd431e81f6570f74240207971b90d3&type=album "schema")

[1, 8, 3, 6, 2]

1) Взять одну или несколько гирь
2) Сравнить гири по весу
3) Поменять две гири местами
4) Запомнить вес нужной гири

### Чаще всего предлагается примерно такое решение:

1. Берём первые две гирьки: 1 и 8. Для вас — слева направо. Сравниваем их между собой. Ту, что тяжелее, перетаскиваем дальше. 8 тяжелее, поэтому будет стоять чуть правее. Оставляем их.

2. Берём следующие две гирьки, то есть вторую и третью. Сравниваем их. 8 тяжелее 3. Значит, 8 и 3 меняем местами, чтобы 8 была ближе к правому краю. Прячем их номера обратно и не запоминаем. Всё, что мы делаем — просто переставляем, ничего не запоминая.

3. Берём следующие две гирьки. Это 8 и 6. 8 тяжелее 6, поэтому 8 опять перейдёт в правую сторону. 

А так как мы их не запоминали, то снова прячем. Забываем про них.

4. Берём последние две гирьки. Это 8 и 2. 8 опять побеждает. 

Переставляем их и прячем.

5. Гирек не осталось. Сравнивать больше нечего.

### Второе решение. У нас есть помощник — морковка. 

1. Возьмем один стаканчик и предположим, что он самый тяжелый. Это логично, ведь я рассмотрел всего лишь одну гирьку, и она, следовательно, кажется самой тяжелой. Таким образом, мы выбираем этот стаканчик для дальнейших сравнений.

2. Теперь возьмем вторую гирьку и сравним ее с предполагаемо самой тяжелой гирькой из первого шага. Оказывается, что вторая гирька (8) тяжелее первой (1).

3. Запоминаем, что гирька с весом 8 является текущей кандидаткой на самую тяжелую. Поменяем местами знак "самой тяжелой" с первой гирьки на вторую.

4. Возьмем следующую гирьку и сравним ее с текущей "самой тяжелой" (теперь 8). Гирька 8 остается самой тяжелой.

5. Повторяем процесс с оставшимися гирьками, каждый раз сравнивая текущую "самую тяжелую" с новой гирькой и обновляя, если необходимо.

В конце концов, мы узнаем, что гирька с весом 8 является самой тяжелой. Таким образом, нет необходимости перемещать гири, мы идентифицировали самую тяжелую с минимальным количеством сравнений.

Обрати внимание, что есть разные методы решения этой задачи, и мы выбрали один из них.

## ЛАБИРИНТ

Итак, мы от гирек переключились на лабиринт. Давайте рассмотрим путь к выходу.

Входим в лабиринт с нижнего правого угла, где находится вход. Первый шаг - касаться левой рукой стены и двигаться вперед.

Когда мы сталкиваемся со стеной, поворачиваем вправо, чтобы левая рука всегда касалась стены.

Идем вправо, пока стена не исчезнет, затем поворачиваем в том направлении, где была стена.

Продолжаем двигаться вдоль стены.

Поворачиваем снова и идем вдоль новой стены, чтобы левая рука не отрывалась.

Встретив тупик, продолжаем следовать правилу левой руки, поворачиваем и идем дальше.

Продолжаем следовать по стене.

Поворачиваем и следуем вдоль другой стены, чтобы левая рука оставалась на стене.

Продолжаем движение вперед.

Снова встречаем тупик, но не беспокоимся, продолжаем алгоритм.

Проходим дальше и, следуя правилу левой руки, достигаем выхода из лабиринта.

Этот алгоритм, известный как "правило левой руки", помогает нам успешно выбираться из лабиринта. Попробуйте его в действии!

![Моя блок-схема](https://sun9-39.userapi.com/impg/itDKce8Fq4wXZrqJKP_Z2hzdo2hwKC1OeiIFUw/VJrRAQuqCH4.jpg?size=1543x2160&quality=95&sign=c81b6aacd9f4f3947cc4dd70ac354923&type=album "schema2")

#### Реализуем его на JavaScript

function followLeftHandRule() {
  
    let position = { x: 0, y: 0 };

    let direction = "up";  
    

    while (!isExit(position)) {

        if (hasWallOnLeft(position, direction)) {
            
            direction = turnRight(direction);
        
        } else if (isPathAhead(position, direction)) {
            
            position = moveForward(position, direction);
        
        } else if (!hasWallOnLeft(position, direction)) {
            
            direction = turnLeft(direction);
        }
    }

    console.log("Выход найден!");
}

*****

#### Проверка, достигли ли мы выхода

```function isExit(position) {    return position.x === exitX && position.y === exitY;}```

#### Проверка наличия стены слева от текущего положения и направления

```function hasWallOnLeft(position, direction) {}```

#### Проверка наличия свободного прохода вперед

```function isPathAhead(position, direction) {}```

#### Поворот налево

function turnLeft(direction) 
{
    const directions = ["up", "left", "down","right"];

    const currentIndex = directions.indexOf(direction);

    const newIndex = (currentIndex + 1) % 4;

    return directions[newIndex];
}

#### Поворот направо

function turnRight(direction) {
       
    const directions = ["up", "left", "down", "right"];
    
    const currentIndex = directions.indexOf(direction);
    
    const newIndex = (currentIndex - 1 + 4) % 4;
    
    return directions[newIndex];
}

#### Движение вперед

function moveForward(position, direction) {

    const { x, y } = position;
    
    if (direction === "up") {
        return { x: x - 1, y };
    } 
    
    else if (direction === "down") {
        return { x: x + 1, y };
    } 
    
    else if (direction === "left") {
        return { x, y: y - 1 };
    } 
    
    else if (direction === "right") {
        return { x, y: y + 1 };
    }
}

#### Задайте координаты выхода
const exitX = 0;
const exitY = 0;

#### Запуск алгоритма
followLeftHandRule();



## Реализуем функции

const maze = [
    
    [1, 1, 1, 1, 1],

    [1, 0, 0, 0, 1],

    [1, 0, 1, 0, 1],
    
    [1, 0, 0, 0, 1],
    
    [1, 1, 1, 1, 1]
];

function hasWallOnLeft(position, direction) {
    const { x, y } = position;
    let newX, newY;

    if (direction === "up") {
        newX = x;
        newY = y - 1;
    } else if (direction === "down") {
        newX = x;
        newY = y + 1;
    } else if (direction === "left") {
        newX = x + 1;
        newY = y;
    } else if (direction === "right") {
        newX = x - 1;
        newY = y;
    }

    return maze[newX][newY] === 1; // 1 представляет стену в лабиринте
}

function isPathAhead(position, direction) {
    const { x, y } = position;
    let newX, newY;

    if (direction === "up") {
        newX = x - 1;
        newY = y;
    } else if (direction === "down") {
        newX = x + 1;
        newY = y;
    } else if (direction === "left") {
        newX = x;
        newY = y - 1;
    } else if (direction === "right") {
        newX = x;
        newY = y + 1;
    }

    return maze[newX][newY] === 0; // 0 представляет свободный проход в лабиринте
}

// Пример использования:
followLeftHandRule();


## Задача с собакой

![Задача](https://sun9-69.userapi.com/impg/3w-Jr2Y06DaUvCtuCaUHAkpW7MWwRPqbXEwfmg/2CbKSpe6kO0.jpg?size=1647x692&quality=95&sign=f1247a48d6ec6075f117e4cb30c0f80d&type=album)

Эта задача представляет собой интересный головоломный сценарий. Основная идея в том, чтобы определить, сколько раз собака перебежит от друга 1 к другу 2, прежде чем они встретятся. Нам нужно рассмотреть их движение и использовать формулы расстояния, времени и скорости.

![Моя блок-схема](https://sun9-30.userapi.com/impg/jYj_CrGwUu8lhhKDIzbXPTQzi8IFaPxQcrkQew/6yLKBJ7OyHM.jpg?size=1543x2160&quality=95&sign=beee7b247e7b2f52b82ca0a545c55eef&type=album "schema3")

### Алгоритм решения задачи

Появилось много новых дополнительных переменных. Если до сих пор наши переменные назывались однобуквенно, и только у одной переменной было имя max, то здесь почему-то сразу стало много букв. 


У нас есть первая переменная, которая называется count. 

Count переводится с английского как «количество». То есть в этой переменной мы будем считать, сколько раз собака перебежала от одного 
хозяина ко второму и обратно.

Есть переменная distance

Мы задаём, с каким же изначально расстоянием между ребятами мы начинаем решать свою задачу.

Есть переменная, в которой сразу написано много слов — firstFriendSpeed. 

Так мы зафиксировали значение первого друга.
1. Похожая на предыдущую переменная — переменная secondFriendSpeed. Это скорость второго 
друга, равная 2.
2. Есть ещё переменная dogSpeed — скорость нашей собаки.
3. Ещё есть один флаг, о котором мы поговорим отдельно. Это переменная friend, которая равна 2.


1. Сначала проверим, чему равно distance. Перед нами стоит вопрос distance > 10? 

2. Скажем, что алгоритм завершился, и собака пробежала count раз. Вместо count подставим то значение, которое получится в ходе нашего алгоритма. Если вы считаете, что 10 метров — слишком далеко, чтобы встретиться, можете подставить 5 метров или 1 метр.

Таким образом, есть какое-то условие, в результате которого мы поймём, завершился ли алгоритм.

3. Далее мы должны понять, куда бежит собака: от друга 1 к другу 2 или от друга 2 к другу 1. То есть у задачи есть два состояния: собака бежит слева направо и справа налево. В зависимости от этого 
задача решается по-разному, вычисление будет немного отличаться.

4. Посмотрим, что произойдёт, если переменная friend будет равна 2.
Изначально мы сказали, что собака побежит к другу 2. Вспоминаем, что если переменная friend равна 2, значит, собака побежит от друга 1 к другу 2. А если friend будет равно 1, собака побежит 
от друга 2 к другу 1. Так мы укажем, к какому другу она побежит.
Допустим friend равен 2, значит, на вопрос friend = 1? мы отвечаем No, так как friend равен 2.

5. Далее появляется новая переменная — time. Чтобы рассчитать time, расстояние между друзьями делим на сумму скорости друга 2 (secondFriendSpeed) и собаки (dogSpeed). Так как они бегут друг 
к другу навстречу, скорость их сближения — это сумма их скоростей. То есть расстояние между ними, которое изначально было 10 км, они пробегут, как скорость друга 2 и скорость собаки — secondFriendSpeed = 2 и dogSpeed = 5. Таким образом, двигаться навстречу друг к другу они будут 
со скоростью 7 м/с.

Так мы сможем рассчитать, через какое время собака добежит до друга 2.

6. Посчитали и запомнили.

7. Сказали, что дальше собака побежит к другу 1.

8. В это время друг 1 не стоял на месте, а двигался. Нам важно понять, когда собака добежала до друга 2, какое расстояние стало между другом 1 и другом 2. Это считается в ячейке, где текущее значение расстояния (distance) будет равно разности между расстоянием (10 км) и суммой скоростей друзей (firstFriendSpeed + secondFriendSpeed), 
умноженной на время (time), за которое собака пробежала от одного друга ко второму.

То есть собака добежала до друга 2, друг 1 при этом шёл навстречу. Расстояние между ними стало меньше. Далее мы вычисляем, какое расстояние осталось между ними, когда собака добежала до друга 2.

distance = distance - (firstFriendSpeed + secondFriendSpeed) * time — то скажу, что здесь что-то не так. 

distance стоит до и после знака «=». Это как в уравнении: x находится с обеих сторон от знака «=». Если перенести все x в одну сторону, они исчезнут, и получится нуль, равный чему то.

В программировании знак равенства работает иначе. Опять же, от языка к языку синтаксис может меняться: где-то это один знак «=», где-то он с двоеточием, как в языке Pascal. Но здесь равенство не уравнение, а присваивание. То есть сначала мы вычислим то, что написано справа от знака «=», а когда получим конкретное значение, напишем его слева от знака «=». 

Посмотрим, как это будет работать.

Изначально distance = 10 000 м. Нам надо узнать, чему она будет равна потом. Для этого подставим имеющиеся значения в формулу distance = distance - (firstFriendSpeed + secondFriendSpeed) * time и посчитаем, что получилось. Справа от знака «=» у меня будет конкретное число. Получившееся значение запишем в переменную distance. Поменяется то, что находится внутри distance. То есть вместо 10 000 будет меньшее число, потому что из него мы что-то вычитали, ведь друзья стали ближе друг другу.

9. Далее используем тот же приём, чтобы этот счётчик перекинуть. Для этого берём формулу count = count + 1.

Помним, что count = 0. Сначала вычислим то, что находится справа от знака «=». 

a. Вместо count подставим 0:
0 + 1 = 1

b. Полученное значение, то есть единицу, запишем в count. В переменной count станет храниться не 0, а 1. То есть после этой ячейки будет единица. А когда мы зайдём сюда потом, то вместо 1 будет 2 — после каждого посещения аккаунта число станет 
увеличиваться на единицу.

10. То же самое здесь — distance = distance - (firstFriendSpeed + secondFriendSpeed) * time. Каждый раз, когда мы станем сюда заходить, distance будет уменьшаться, так как ребята движутся друг к 
другу, и расстояние между ними сокращается.

Таким образом, мы пошли по ветке time = distance/(secondFriendSpeed + dogSpeed). Собака добежала до друга 2 и побежит дальше к первому.
Мы выяснили, какое расстояние осталось между другом 1 и другом 2, и увеличили наш счётчик на единицу.

11. Отправляемся обратно и отвечаем на вопрос distance > 10?
Если расстояние между друзьями больше 10, то есть они ещё не встретились по нашему условию, то спускаемся. Значение friend мы поменяли на 1, теперь там хранится единица. 

12. Далее переходим вправо, где представлена формула time = distance/(firstFriendSpeed + dogSpeed). Здесь мы складываем не скорость друга 2 и собаки, а скорость друга 1 и собаки, потому что собака теперь бежит навстречу другу 1.

13. Считаем время, когда собака добежит до друга 1, и меняем состояние алгоритма, так как пёс далее побежит к другу 2.

14. Далее идёт то же самое — пока собака бежала к другу 1, расстояние между друзьями сократилось снова. Поменяли значение счётчика.

15. Снова выясняем, насколько близко друзья находятся друг от друга. И когда они достаточно близко подойдут друг к другу, мы узнаем, сколько раз собака перебежала от одного к другому.

Алгоритм может быть немного сложным, особенно для первой лекции. Но не стоит пугаться. 

Посмотрите на него ещё раз. Здесь есть ряд вещей, возможно, новых для вас, но на них надо обратить внимание.

Например, мы перестали использовать буквы, чтобы именовать переменные, а начали применять конкретные слова. Если знать значение этих слов, то даже человек, который не посвящён в наш алгоритм, сможет понять, что distance — это расстояние, firstFriendSpeed — скорее всего, скорость первого друга, secondFriendSpeed — скорость второго друга, а time — время.

Будет гораздо лучше, если вы в своих алгоритмах будете использовать осмысленные конкретные слова, а не просто какие-то отдельные буквы. — x, y, a, b — которые понятны только вам и только сейчас. Если 
назовёте свои переменные a, b, c, то через какое-то время, например, через неделю, скорее всего, не сможете вспомнить, что там было. А если значения переменных будут осмысленными, то возвращаться к 
своим задачам станет проще.

Ещё мы снова обратились к циклам и можем повторять какие-то действия из раза в раз. Если собака бегает от первого друга ко второму и от второго друга к первому, и так несколько раз, то проще этот процесс 
зациклить. Программа сама поймёт, когда надо остановиться.
У нас есть точка выхода из программы. Например, когда нам надо добавить какое-то условие. Если оно выполняется, выходим из алгоритма. В нашем случае это расстояние между ребятами.

Мы также разобрали очень важный приём, когда знак «=» в программировании не уравнение, а присваивание значения. Сначала вычисляется всё, что находится справа, а потом записывается в переменную слева, даже если справа и слева находится одна и та же переменная.