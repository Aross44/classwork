CREATE TABLE Students
(
student_id	serial	not null,
first_name	varchar(20) not null,
last_name 	varchar(20) not null, 	
email		varchar(40),
phone		varchar(15),
CONSTRAINT pk_student_id PRIMARY KEY (student_id)
)
;

drop table if exists Students CASCADE;
INSERT INTO Students
(firstname	, lastname, email, phone)
Values ('Jane', 'Doe', 'jane@example.com', '313-555-0001'),
	   ('James', 'Smith', 'james@example.com', '313-555-0002'),
	   ('Susan', 'Jones', 'susan@example.com', '313-555-0003'),
	   ('Javier', 'Rodriguez', 'javier@example.com', '313-555-0004'), -- null?
	   ('DeAndre', 'Taylor', 'deandre@example.com', '313-555-0005')
	   ;

select * from Students;


select * from students;
update students
	where lastname = 'Chirpus'
	set lastname = 'Rodriguez'	
;
	select * from students;

DELETE FROM Students
where firstname = 'Deandre' 
and lastname = 'Taylor'
;


SELECT* FROM Students
Where firstname 'James'
;




CREATE TABLE Assignments
( Id serial PRIMARY KEY	
Title varchar(40),
Score smallint,
StudentID int 
);

INSERT INTO Assignments 
(Tittle, Score, StudentID)
Values
('Geography Quiz', 85 ),
('US States Worksheet', 10),
('Geography Quiz', 92)
;

INSERT INTO Assignments (Title, Score, StudentId) VALUES
('Geography Quiz', 85, (SELECT Id FROM Students WHERE FirstName = 'Jane' AND LastName = 'Doe')),
('US States Worksheet', 10, (SELECT Id FROM Students WHERE FirstName = 'Jane' AND LastName = 'Doe')),
('Geography Quiz', 92, (SELECT Id FROM Students WHERE FirstName = 'Javier' AND LastName = 'Chirpus'));






SELECT 
    Title,
    Score,
    (SELECT FirstName FROM Students WHERE Students.Id = Assignments.StudentId) AS FirstName,
    (SELECT LastName FROM Students WHERE Students.Id = Assignments.StudentId) AS LastName
FROM Assignments;

SELECT 
    (SELECT FirstName FROM Students WHERE Students.Id = Assignments.StudentId) AS FirstName,
    (SELECT LastName FROM Students WHERE Students.Id = Assignments.StudentId) AS LastName
FROM Assignments
WHERE Title = 'Geography Quiz' AND Score > 90;




