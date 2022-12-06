## About

Фрагментарна реалізація систем управління табличними базами даних

## І. Загальні вимоги

**Основні вимоги щодо структури бази:**

- кількість таблиць принципово не обмежена (реляції між таблицями не враховувати);
- кількість полів та кількість записів у кожній таблиці також принципово не обмежені.

**У кожній роботі треба забезпечити підтримку (для полів у таблицях) наступних (загальних для всіх варіантів!) типів:**

- integer;
- real;
- char;
- string.

**Також у кожній роботі треба реалізувати функціональну підтримку для:**

- створення бази;
- створення (із валідацією даних) та знищення таблиці з бази;
- перегляду та редагування рядків таблиці;
- збереження табличної бази на диску та, навпаки, зчитування її з диску.

## ІІ. Варіанти додаткових типів

**Потрібно забезпечити підтримку (для можливого використання у таблицях) двох додаткових типів у відповідності з одним із наступних варіантів:**

7) $ (грошовий форматний тип, max$ =10,000,000,000,000.00); $Invl;

## ІІІ. Варіанти додаткових операцiй над таблицями

**Потрібно реалізувати операцiї над таблицями у відповідності з варіантом:**

3) рiзниця таблиць;
