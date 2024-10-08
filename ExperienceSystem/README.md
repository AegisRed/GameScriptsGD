# Experience System for your Godot Game (NEED EVENTBUS)

## Описание
Этот проект предоставляет систему опыта для игр, созданных на движке Godot. Для корректной работы требуется наличие EventBus.
## ExperienceSystem.cs
Скрипт ExperienceSystem.cs реализует систему управления опытом и уровнями персонажа в игре. Вот основные функции и методы, которые он выполняет:

1.	Переменные и Экспорты:
•	MinExpRequirement: Минимальное количество опыта, необходимое для достижения первого уровня.
•	PerLvlExpRequirement: Количество опыта, необходимое для каждого последующего уровня.
•	CurrentExp: Текущий опыт персонажа.
•	CurrentLevel: Текущий уровень персонажа.
2.	Метод _Ready:
•	Вызывается при инициализации узла.
•	Подписывается на событие ExperienceGained, чтобы отслеживать получение опыта.
3.	Метод GetExpRequirementForLevel:
•	Принимает уровень в качестве параметра.
•	Возвращает количество опыта, необходимое для достижения указанного уровня.
4.	Метод OnExperienceGained:
•	Вызывается при получении опыта.
•	Увеличивает текущий опыт на значение, переданное в аргументах.
•	Вызывает метод CheckLevelUp для проверки, достигнут ли новый уровень.
5.	Метод CheckLevelUp:
•	Проверяет, достаточно ли текущего опыта для повышения уровня.
•	Если текущий опыт превышает или равен требуемому для следующего уровня, уменьшает текущий опыт на необходимое количество и увеличивает уровень.

Этот скрипт обеспечивает автоматическое управление опытом и уровнями, реагируя на события получения опыта и обновляя состояние персонажа соответственно.

## ExperienceGiver.cs
Скрипт ExperienceGiver.cs отвечает за предоставление опыта другим объектам в игре. Вот основные функции и методы, которые он выполняет:

1.	Переменные и Экспорты:
•	ExpAmount: Количество опыта, которое будет предоставлено при вызове метода GiveExperience.
2.	Делегаты:
•	ExpirienceGainedHandler: Делегат для обработки события получения опыта.
3.	Метод GiveExperience:
•	Вызывает метод Publish из EventBus, чтобы оповестить систему о том, что было получено определенное количество опыта (ExpAmount).
•	Публикует событие ExperienceGained, передавая текущее количество опыта (ExpAmount).

Этот скрипт используется для генерации опыта, который затем может быть обработан другими системами, такими как ExperienceSystem, для обновления текущего опыта и уровня персонажа.

## Установка
1. Склонируйте репозиторий: https://github.com/AegisRed/GameScriptsGD
    
2. Импортируйте скрипты и сцены в Godot.
3. Добавьте EventBus плагин в ваш проект либо напишите сами можно использовать самый простой.

## Использование
1. Создайте новый узел в дереве сцен и добавьте к нему скрипт ExperienceSystem.cs.
2. Установите значения MinExpRequirement и PerLvlExpRequirement в соответствии с вашими потребностями.
3. Подпишитесь на событие ExperienceGained, чтобы передавать опыт персонажу.
4. При получении опыта вызовите метод OnExperienceGained, передав количество полученного опыта в качестве аргумента.
5. После получения опыта система автоматически обновит уровень персонажа, если это необходимо.
6. Поздравляем! Теперь у вас есть система опыта для вашей игры.
