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
(002,'Zoban','Balkin',2),
(003,'Isuza','Hanao',3),
(004,'Ryoji','Honda',2),
(005,'Zoltan','Akos',1),
(006,'Kwame','Biggs',4);


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

SELECT * FROM person
WHERE PersonStatusId = 1 OR PersonStatusId = 4;
-----------------------------------------------------

SELECT * FROM person
WHERE PersonStatusId = 1 AND FirstName = 'Tom';


-----------------------------------------------------


UPDATE person
SET PersonStatusId = 2
WHERE FirstName = 'Tom';


-----------------------------------------------------
DELETE FROM person

WHERE PersonStatusId = 4;


SELECT P.PersonID, P.FirstName, P.LastName,PS.PersonStatusId, PS.StatusDescription
FROM Person P
INNER JOIN PersonStatus PS
ON P.PersonStatusID = PS.PersonStatusID;


SELECT P.PersonID, P.FirstName, P.LastName,PS.PersonStatusId, PS.StatusDescription
FROM Person P
INNER JOIN PersonStatus PS;