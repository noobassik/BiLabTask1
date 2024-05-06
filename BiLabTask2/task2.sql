-- напишите SQL-запрос, который выведет имена студентов и названия курсов, на которые записаны студенты.
SELECT s.name AS student_name, c.course_name
FROM Students s
INNER JOIN Courses c ON s.course_id = c.course_id;

-- напишите SQL-запрос, который выведет имена студентов и названия курсов, на которые записаны студенты, возраст которых не превышает 25 лет.
SELECT s.name AS student_name, c.course_name
FROM Students s
INNER JOIN Courses c ON s.course_id = c.course_id
WHERE s.age <= 25;

-- напишите SQL-запрос, который выведет названия всех курсов и количество студентов, записанных на каждый курс. 
-- Если на каком-то курсе нет записанных студентов, он должен быть отображен в результатах с количеством студентов равным 0.
SELECT c.course_name, COUNT(s.student_id) AS student_count
FROM Courses c
LEFT JOIN Students s ON c.course_id = s.course_id
GROUP BY c.course_name;
