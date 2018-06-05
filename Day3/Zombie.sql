Create Database Zombiedbs;
use Zombiedbs;

CREATE TABLE Person
(
PersonID int,
FirstName varchar(25),
LastName varchar(25),
PersonStatusId int
);
 
INSERT INTO person
(PersonID,FirstName,LastName,PersonStatusId)
VALUES
(001,'Alton','Shrumpet',1),
(002,'Alton','Shrumpet',2),
(003,'Alton','Shrumpet',3),
(004,'Alton','Shrumpet',2),
(005,'Alton','Shrumpet',1),
(006,'Alton','Shrumpet',4);


CREATE TABLE PersonStatus
(
PersonStatusId int,
StatusDescription varchar(25)
);

INSERT INTO personstatus
(PersonStatusId,StatusDescription)
VALUES
(1,'Alive');
INSERT INTO personstatus
(PersonStatusId,StatusDescription)
VALUES
(2,'Zombie');
INSERT INTO personstatus
(PersonStatusId,StatusDescription)
VALUES
(3,'Dead'),
(4,'Unknown');

SELECT * FROM person;


SELECT * FROM person
WHERE PersonStatusId = 4;



UPDATE person
SET FirstName = 'Brody'
WHERE PersonID = 002;


UPDATE person
SET FirstName = 'Drew',LastName ='Shelter'

WHERE PersonID = 003;

UPDATE person
SET FirstName = 'Yaw',LastName ='Boateng', PersonStatusId = 2

WHERE PersonID = 006;

SELECT P.PersonID, P.FirstName, P.LastName, PS.StatusDescription
FROM Person P
INNER JOIN PersonStatus PS
ON P.PersonStatusID = PS.PersonStatusID;

UPDATE person
SET FirstName = 'Lineker',LastName ='Bolton'

WHERE PersonID = 005;
