# Performancemonitor – диспетчер задач со своими сюрпризами

## 1 Техническое задание

### 1.1 Общая сведение о проекте

Наименование программы: Performance monitor.

Монитор ресурсов, инструмент, позволяющий просматривать сведения об использовании и характеристики аппаратных ресурсов (процессора, оперативной памяти, физических дисков и видеокарты) в режиме реального времени.

### 1.2 Цели проекта

Цели создание программного обеспечения:

- Составления логики работы программного обеспечения;
- Составления графического интерфейса программного обеспечения;
- Разработка программного обеспечения;
- Тестирование программного обеспечения;
- Составления технических документаций.

### 1.3 Целевая аудитория

Мужчины и женщины в возрасте от 12 до 45 лет, системным администраторам, продвинутым пользователям и ИТ-специалистам.

### 1.4 Структура программного обеспечения

1. О программе;
2. Общая информация – общая информация о операционной системе, процессоре, оперативной памяти, видеокарте, физических дисков;
3. ЦП – информация о процессоре;
4. ОЗУ – информация о оперативной памяти;
5. ГП – информация о видеокарте;
6. Диски – информация о физических дисках.

### 1.5 Стилистическое оформление программного обеспечения

Стилистическое оформление программного обеспечения должно соответствовать корпоративному стилю и использовать его цветовые и графические элементы, должна быть простой и дружелюбный внешний вид.

Шрифты, используемые в графических элементах программного обеспечения, Times New Roman.

Фон программного обеспечения в сером цвете. Цветовая палитра остальных элементов: светло-серый.

### 1.6 Требование к работе программного обеспечения в компьютере

Программное обеспечения должно стабильно и корректно работать в операционных системах в семействах MicrosoftWindows.

### 1.7 Технические характеристики программного обеспечения

- Операционная система: MicrosoftWindows;
- Оперативная память: не меньше 2-х ГБ;
- Процессор: 32-х или 64-х битные (Intel или AMD);
- Наличия доступа к интернету;
- Наличие динамиков;
- Физический диск: не ниже 100 МБ;
- Разрешения дисплея: не ниже 1366 х 768 рх.

### 1.8 Требование к функционалу программного обеспечения

Общая требования к функционалу программного обеспечения (Таблица 1.1):

Таблица 1.1 Функционал программного обеспечения

| Наименование функционала | Описание функции |
| --- | --- |
| Кнопки навигации | Необходимо для удобного перехода по разделам программы (Рисунок 1.1). ![](RackMultipart20210625-4-ovnsv_html_408a634c7ad8f8c0.png) Рисунок 1.1 – Кнопки программы |
| О программе | Информации программы (Рисунок 1.2). ![](RackMultipart20210625-4-ovnsv_html_ddf38713b31f251d.png) Рисунок 1.2 – О программе |
| Раздел «Общая информация» | Находится общая информация о операционной системе, процессоре, оперативной памяти, видеокарте, физических дисков (Рисунок 1.3). ![](RackMultipart20210625-4-ovnsv_html_28721daf726d10c7.png) Рисунок 1.3 – Общая информация |
| Разделы «ЦП, ОЗУ, ГП, Диски» | Находятся информация о конкретном компоненте компьютере, график использованной компонента компьютера в режиме реального времени (Рисунок 1.4). ![](RackMultipart20210625-4-ovnsv_html_27ad3d6756ef11c4.png) Рисунок 1.4 – Раздел «ЦП» |

Использовали 3 API:

- Windows.Forms – необходим для работы с графическим интерфейсом программного обеспечения;
- Management – необходим для извлечения информации о компонентах компьютерах через WMI;
- OpenHardwareMonitor – сторонний API, необходим для работы датчиков в реальном времени.

2 Проведение тестирования и отладки программного обеспечения

2.1 Тест-план

Тест план - это документ, описывающий весь объем работ по тестированию, начиная с описания объекта, стратегии, расписания, критериев начала и окончания тестирования, до необходимого в процессе работы оборудования, специальных знаний, а также оценки рисков с вариантами их разрешения.

2.1.1 Введение.

Целью составления данного тест плана является описание процесса тестирования программы «Performance monitor».

2.1.2 Объект тестирования: программа «Performance monitor».

2.1.3 Предполагается провести.

Для отдельных полей:

- Позитивное тестирование приложения (корректные шаги, корректные данные);
- Негативное тестирование (подразумевает введение некорректных данных).

Для всей системы:

- Функциональное тестирование;
- Юзабилити тестирование;
- Тестирование графического интерфейса.

2.1.4 Тестовое окружение (Таблица 2.1).

Таблица 2.1 Тестовое окружение

| Операционная система: | Microsoft Windows 7, 8, 8.1, 10 |
| --- | --- |
| Разрешения дисплея: | 1366х768; 1280х800; 1280х1024; 1680х1050; 1929х1080. |

2.1.5 Тестируемый функционал программы.

Будет протестирована следующая функциональность программы:

- Датчики – приоритет высокий;
- Характеристики компонента компьютера – приоритет высокий;
- Графики – приоритет высокий;
- Графический интерфейс – приоритет низкий.

Не будет проведено нагрузочное и тестирование безопасности в виду отсутствия необходимых ресурсов.

2.1.6 Конфигурации (Таблица 2.2).

Таблица 2.2 Конфигурация тестового стенда

| Ноутбук №1 | Операционная система: Microsoft Windows 10; Оперативная память: 8 ГБ; Процессор: Intel Core i5-5200U; Физический диск: 120 ГБ; Разрешения дисплея: 1929х1080 рх. |
| --- | --- |
| Ноутбук №2 | Операционная система: Microsoft Windows 10; Оперативная память: 8 ГБ; Процессор: Intel Core i5-8250U; Физический диск: 240 ГБ; Разрешения дисплея: 1929х1080 рх. |

2.1.7 Процесс тестирования.

Для максимального покрытия программы предполагается составление чек-листов и тест-кейсов

2.1.8 Критерии начала и окончания тестирования.

Тестирование может быть начато, если выполнены следующие условия:

1. Готова и утверждена необходимая документация;
2. Тестируемый функционал окончен и готов для передачи в тестирование.

Тестирование окончено, если выполнены следующие условия:

- Все найденные дефекты задокументированы.

2.1.9 План работ (Таблица 2.3).

Таблица 2.3 - План работ

| Задача | Время | Дата начала | Дата окончания |
| --- | --- | --- | --- |
| Составление тест плана | 3час. | 03.06.2020 | 03.06.2020 |
| Корректировка тест плана | 1 час. | 03.06.2020 | 03.06.2020 |
| Выполнение тестов | Ноутбук №1: 1 час. Ноутбук №1: 1 час. | 04.06.2020 | 04.06.2020 |
| Выполнения тест-дизайн | 2 час. | 04.06.2020 | 04.06.2020 |
| Выполнения CASE-тест | 2 час. | 05.06.2020 | 05.06.2020 |
| Выполнения bag-report | 2 час. | 05.06.2020 | 05.06.2020 |

2.1.10 Риски и ограничения:

- ввиду ограниченности ресурсов, гарантировать корректное работы программы можем только на устройствах, которые указаны в таблице «Конфигурации» (Таблица 4.2).

2.1.11 Тестовая документация:

После окончания тестирования планируется наличие таких документов:

- Тест-план
- Тест-дизайн
- CASE-тест
- Bag-report

2.2 Тест-дизайн

Тест дизайн – это этап процесса тестирования программного обеспечение, на котором проектируются и создаются тестовые случаи (тест кейсы), в соответствии с определёнными ранее критериями качества и целями тестирования.

Тест дизайн программы «Performancemonitor» (Таблица 2.4).

Таблица 2.4 - Тест дизайн программы «Performancemonitor»

| Элемент | Тип элемента | Требование |
| --- | --- | --- |
| Кнопка «О программе» | button | Состояние: 1. По умолчанию - не активна (Disabled) 2. После нажатия становится активна (Enabled) Действия после нажатия: открытия раздела «О программе». |
| О программе | Windows.Forms | Выводить информацию о программе. |
| Кнопки разделов: «Общая информация, ЦП, ОЗУ, ГП, Диски» | button | Состояние: 1. По умолчанию - не активна (Disabled) 2. После нажатия становится активна (Enabled) Действия после нажатия: открытия конкретного раздела. |
| Разделы: «Общая информация, ЦП, ОЗУ, ГП, Диски» | Windows.Forms | Выводит информация о конкретном компоненте компьютере, график использованной компонента компьютера в режиме реального времени. |

2.3 CASE-тест

CASE-тест – это артефакт, описывающий совокупность шагов, конкретных условий и параметров, необходимых для проверки реализации тестируемой функции или её части.

CASE-тест №1. Запуск программы без дискретной видеокарты.

Шаги:

1. Запустить программу на компьютере без дискретной видеокарты;
2. Нажать на «Да» при запросе доступа администратора;
3. Зайти в раздел «Общая информация».

Ожидаемый результат: должно появится сообщения «Нет ГП дискретной».

CASE-тест №2. Не запуск программы от имени администратора.

Шаги:

1. Запустить программу;
2. Нажать на «Нет» при запросе доступа администратора.

Ожидаемый результат: программа не должна запуститься.

CASE-тест №3. Песня из картинки.

Шаги:

1. Запустить программу;
2. Нажать на «Да» при запросе доступа администратора;
3. Нажать на картинку.

Ожидаемый результат: должно проигрываться песни группы «БИ-2».

2.4 Bag-report

Bag-report – это документ, описывающий ситуацию или последовательность действий приведшую к некорректной работе объекта тестирования, с указанием причин и ожидаемого результата.

Шаги к воспроизведению

1. Запустить программу;
2. Нажать на «Да» при запросе доступа администратора;
3. Зайти в раздел «ГП дискретная».

Результат: не выводится информация о встроенной видеокарте и не работает график использованной ресурсов.

Ожидаемый результат: выводится информация о встроенной видеокарте и график использованной ресурсов.

3 Адаптация программного обеспечения

3.1 Инструкция по установки

1. Находим папку с установщиком программы «Performance monitor» и открываем её;
2. Находим файл «setup.exe» и запускаем её;
3. Выходящем окне нажимаем на «Установить»;

Программа установлена и находится в меню «Пуск». Внимание, программу нужно запускать от имени администратора, при запуске программа запросит доступ, нужно будет нажать «Да».

3.2 Инструкция по эксплуатации

![](RackMultipart20210625-4-ovnsv_html_199f2d8a861f6de6.gif)

2

3.2.1 Содержание программы (Рисунок 3.1):

![](RackMultipart20210625-4-ovnsv_html_7168817fba81bd56.gif) ![](RackMultipart20210625-4-ovnsv_html_632bd74c592e1884.gif) ![](RackMultipart20210625-4-ovnsv_html_ad3ea3bab3f8fce7.gif) ![](RackMultipart20210625-4-ovnsv_html_e9368368cea3ebaf.gif) ![](RackMultipart20210625-4-ovnsv_html_49cb059ab5863453.gif) ![](RackMultipart20210625-4-ovnsv_html_199f2d8a861f6de6.gif) ![](RackMultipart20210625-4-ovnsv_html_199f2d8a861f6de6.gif) ![](RackMultipart20210625-4-ovnsv_html_199f2d8a861f6de6.gif) ![](RackMultipart20210625-4-ovnsv_html_199f2d8a861f6de6.gif) ![](RackMultipart20210625-4-ovnsv_html_199f2d8a861f6de6.gif) ![](RackMultipart20210625-4-ovnsv_html_ffab16572d800cdd.gif)

1

3 ![](RackMultipart20210625-4-ovnsv_html_5ea71994df577f18.jpg)

5 ![](RackMultipart20210625-4-ovnsv_html_92029037a38efbfd.jpg) ![](RackMultipart20210625-4-ovnsv_html_92029037a38efbfd.jpg) ![](RackMultipart20210625-4-ovnsv_html_5ea71994df577f18.jpg)

4 ![](RackMultipart20210625-4-ovnsv_html_92029037a38efbfd.jpg) ![](RackMultipart20210625-4-ovnsv_html_92029037a38efbfd.jpg) ![](RackMultipart20210625-4-ovnsv_html_5ea71994df577f18.jpg)

6 ![](RackMultipart20210625-4-ovnsv_html_92029037a38efbfd.jpg) ![](RackMultipart20210625-4-ovnsv_html_92029037a38efbfd.jpg) ![](RackMultipart20210625-4-ovnsv_html_5ea71994df577f18.jpg)

 ![](RackMultipart20210625-4-ovnsv_html_e05317faa0d5132e.png)

Рисунок 3.1 – Интерфейс программы

1. Кнопки навигации по разделам;
2. О программе;
3. Характеристики выбранного компонента компьютера;
4. Датчики, отслеживающие в реальном времени выбранного компонента компьютера;
5. График, отслеживающие в реальном времени выбранного компонента компьютера;

3.2.2 Работа с программой

После запуска программы, вы можете выбрать нужную вам компонент компьютера для отслеживания за нею через кнопки навигации по разделам (1). После выбора и открытия нужного вами раздела появится окно с выбранным компонентом компьютера, в ней будут выведены характеристики (3), датчики (4) и график (5). Датчики и график выводят значения в реальном времени. Можете запускать несколько окошек с компонентами компьютера для удобного отслеживание за состоянием компьютера.