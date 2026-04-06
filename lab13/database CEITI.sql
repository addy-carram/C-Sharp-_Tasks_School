CREATE DATABASE CEITI
USE CEITI;

/* Creating the tables of the database*/
CREATE TABLE Class(
	id_class INT PRIMARY KEY,
	c_name NVARCHAR(100) UNIQUE,
	c_year TINYINT NOT NULL
)
GO
CREATE TABLE Pupils(
	ID_Pupil INT PRIMARY KEY,
	first_name NVARCHAR(100) NOT NULL,
	last_name NVARCHAR(100) NOT NULL,
	d_birth DATE NOT NULL,
	email NVARCHAR(100) UNIQUE,
	phone NVARCHAR(13),
	id_class INT REFERENCES Class(id_class)
	ON DELETE CASCADE
)
GO
CREATE TABLE Teacher(
	id_teacher INT PRIMARY KEY,
	first_name NVARCHAR(100) NOT NULL,
	last_name NVARCHAR(100) NOT NULL,
	d_birth DATE NOT NULL,
	email NVARCHAR(100) UNIQUE,
	phone NVARCHAR(13) UNIQUE
)
GO
CREATE TABLE Objects_S(
	id_object INT PRIMARY KEY,
	o_object NVARCHAR(100) UNIQUE
)
GO
CREATE TABLE Scheduale(
	id_scheduale INT PRIMARY KEY,
	s_room TINYINT NOT NULL,
	s_day NVARCHAR(100) check(s_day='Monday' or s_day='Tuesday' or s_day='Wednesday' or s_day='Thursday' or s_day='Friday'),
	s_hour DATETIME NOT NULL,
	id_class INT REFERENCES Class(id_class),
	id_teacher INT REFERENCES Teacher(id_teacher),
	id_object INT REFERENCES Objects_S(id_object)
	ON DELETE CASCADE
	ON UPDATE CASCADE
)
GO
-- Class
INSERT INTO Class VALUES (1, '10A', 10),
						(2, '10B', 10),
						(3, '11A', 11),
						(4, '11B', 11),
						(5, '12A', 12);

GO
-- Teacher
INSERT INTO Teacher VALUES (1, 'Ion', 'Popescu', '1980-03-15', 'i.popescu@ceiti.md', '+37369100001'),
							(2, 'Maria', 'Ionescu', '1975-07-22', 'm.ionescu@ceiti.md', '+37369100002'),
							(3, 'Andrei', 'Rusu', '1985-11-10', 'a.rusu@ceiti.md', '+37369100003'),
							(4, 'Elena', 'Munteanu', '1978-05-30', 'e.munteanu@ceiti.md', '+37369100004'),
							(5, 'Victor', 'Grosu', '1990-01-18', 'v.grosu@ceiti.md', '+37369100005');
GO
-- Objects_S
INSERT INTO Objects_S VALUES (1, 'Mathematics'),
							 (2, 'Informatics'),
							 (3, 'Physics'),
							 (4, 'Romanian Language'),
							 (5, 'English Language'),
							 (6, 'History');
GO
-- Pupils
INSERT INTO Pupils VALUES (1,  'Alexandru', 'Ciobanu',  '2006-04-12', 'a.ciobanu@elev.ceiti.md',  '+37368200001', 1),
						 (2,  'Diana',     'Lungu',    '2006-09-25', 'd.lungu@elev.ceiti.md',    '+37368200002', 1),
						 (3,  'Mihai',     'Bordeianu','2006-02-14', 'm.bordeianu@elev.ceiti.md','+37368200003', 1),
						 (4,  'Ana',       'Rotaru',   '2006-11-03', 'a.rotaru@elev.ceiti.md',   '+37368200004', 2),
						 (5,  'Cristian',  'Botnaru',  '2006-07-19', 'c.botnaru@elev.ceiti.md',  '+37368200005', 2),
						 (6,  'Valeria',   'Negru',    '2005-03-08', 'v.negru@elev.ceiti.md',    '+37368200006', 3),
						 (7,  'Radu',      'Cojocaru', '2005-06-21', 'r.cojocaru@elev.ceiti.md', '+37368200007', 3),
						 (8,  'Natalia',   'Popovici', '2005-12-17', 'n.popovici@elev.ceiti.md', '+37368200008', 4),
						 (9,  'Sergiu',    'Vrabie',   '2005-08-05', 's.vrabie@elev.ceiti.md',   '+37368200009', 4),
						 (10, 'Ioana',     'Damaschin','2004-01-30', 'i.damaschin@elev.ceiti.md','+37368200010', 5);
GO
-- Scheduale
INSERT INTO Scheduale VALUES (1,  101, 'Monday',    '2024-01-01 08:00:00', 1, 1, 2),
							 (2,  102, 'Monday',    '2024-01-01 09:00:00', 2, 2, 1),
							 (3,  103, 'Tuesday',   '2024-01-01 08:00:00', 3, 3, 3),
							 (4,  104, 'Tuesday',   '2024-01-01 10:00:00', 4, 4, 4),
							 (5,  105, 'Wednesday', '2024-01-01 08:00:00', 5, 5, 5),
							 (6,  101, 'Wednesday', '2024-01-01 09:00:00', 1, 2, 6),
							 (7,  102, 'Thursday',  '2024-01-01 08:00:00', 2, 3, 2),
							 (8,  103, 'Thursday',  '2024-01-01 11:00:00', 3, 1, 1),
							 (9,  104, 'Friday',    '2024-01-01 08:00:00', 4, 5, 3),
							 (10, 105, 'Friday',    '2024-01-01 10:00:00', 5, 4, 4);


SELECT * FROM Pupils;





