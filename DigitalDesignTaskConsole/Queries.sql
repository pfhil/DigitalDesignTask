--Запрос 1 (Сотрудник с максимальной заработной платой)
SELECT * FROM employee WHERE salary = (SELECT max(salary) FROM employee)

--Запрос 2 (Максимальная длина цепочки руководителей по таблице сотрудников)
WITH t1(lvl, id, chief_id) AS (
    SELECT 1 as lvl, id, chief_id
    FROM employee
    WHERE chief_id IS NULL

    UNION ALL

    SELECT lvl + 1, t2.id, t2.chief_id
    FROM employee t2, t1
    WHERE t2.chief_id = t1.id)
SELECT max(lvl)
FROM t1;

--Запрос 3 (Отдел, с максимальной суммарной зарплатой сотрудников)
WITH SUM_SAL AS (
    SELECT d.name, SUM(e.SALARY) AS SUM_SALARY
    FROM employee e
    INNER JOIN departament d
    ON d.id = e.departament_id
    GROUP BY d.name),
MAX_SAL AS (
    SELECT MAX(SUM_SALARY) AS MAX_SALARY
    FROM SUM_SAL)
SELECT s.name, m.MAX_SALARY
FROM SUM_SAL s
INNER JOIN MAX_SAL m
ON m.MAX_SALARY = s.SUM_SALARY


--Запрос 4 (Сотрудник, чье имя начинается на «Р» и заканчивается на «н»)
SELECT * FROM employee
WHERE NAME LIKE 'Р%н'