USE master;

 

IF DB_ID(N'TinyCollegeDB') IS NOT NULL DROP DATABASE TinyCollegeDB;

CREATE DATABASE TinyCollegeDB;

GO

 

USE TinyCollegeDB;

GO

CREATE TABLE instructor

(
       instructorId INT NOT NULL IDENTITY,
       instructorFirstName NVARCHAR(100) NOT NULL,
	   instructorLastName NVARCHAR(100) NOT NULL,
       CONSTRAINT pk_instructor PRIMARY KEY (instructorId)
);

CREATE TABLE course

(
       courseId INT NOT NULL IDENTITY,
	   courseName NVARCHAR(100) NOT NULL,
	   courseStatus CHAR NOT NULL,
       courseCreditHours INT NOT NULL,
	   courseMaxNumSeats INT NOT NULL,
       CONSTRAINT pk_course PRIMARY KEY (courseId),
);

CREATE TABLE session

(
       sessionId INT NOT NULL IDENTITY,
       sessionSeatsFilled INT NOT NULL,
	   instructorId INT NOT NULL,
	   courseId INT NOT NULL,
       CONSTRAINT pk_session PRIMARY KEY (sessionId),
       CONSTRAINT fk_session_instructor FOREIGN KEY (instructorId)
       REFERENCES instructor(instructorId),
	   CONSTRAINT fk_session_course FOREIGN KEY (courseId)
       REFERENCES course(courseId)
);

 
 CREATE TABLE student

(
       studentId INT NOT NULL IDENTITY,
       studentFirstName NVARCHAR(100) NOT NULL,
	   studentLastName NVARCHAR(100) NOT NULL,
           CONSTRAINT pk_student PRIMARY KEY (studentId)
);

CREATE TABLE registration

(
    registrationId INT NOT NULL IDENTITY,
	sessionId INT NOT NULL,
	studentId INT NOT NULL,
	grade CHAR,
    CONSTRAINT pk_registration PRIMARY KEY (registrationId),
    CONSTRAINT fk_registration_session FOREIGN KEY (sessionId)
    REFERENCES session(sessionId),
	CONSTRAINT fk_registration_student FOREIGN KEY (studentId)
    REFERENCES student(studentId)
);

INSERT INTO instructor (instructorFirstName, instructorLastName) VALUES ('Andrea', 'Boyer');
INSERT INTO instructor (instructorFirstName, instructorLastName) VALUES ('Caley', 'Cooper');
INSERT INTO instructor (instructorFirstName, instructorLastName) VALUES ('Kayla', 'Crowley');
INSERT INTO instructor (instructorFirstName, instructorLastName) VALUES ('Aaron', 'Paul');
INSERT INTO instructor (instructorFirstName, instructorLastName) VALUES ('Ashley', 'Anderson');

INSERT INTO course (courseName, courseStatus, courseCreditHours, courseMaxNumSeats) VALUES ('Biology', 'Y', '3', '10');
INSERT INTO course (courseName, courseStatus, courseCreditHours, courseMaxNumSeats) VALUES ('Chemistry', 'Y', '3', '10');
INSERT INTO course (courseName, courseStatus, courseCreditHours, courseMaxNumSeats) VALUES ('Psychology', 'Y', '3', '10');
INSERT INTO course (courseName, courseStatus, courseCreditHours, courseMaxNumSeats) VALUES ('English', 'Y', '3', '10');
INSERT INTO course (courseName, courseStatus, courseCreditHours, courseMaxNumSeats) VALUES ('College Algebra', 'Y', '3', '10');

INSERT INTO student(studentFirstName, studentLastName )VALUES('Bob', 'Harper');
INSERT INTO student(studentFirstName, studentLastName )VALUES('Jillian', 'Michaels');
INSERT INTO student(studentFirstName, studentLastName )VALUES('Harrison', 'Ford');
INSERT INTO student(studentFirstName, studentLastName )VALUES('Will', 'Smith');
INSERT INTO student(studentFirstName, studentLastName )VALUES('Ben', 'Stiller');
INSERT INTO student(studentFirstName, studentLastName )VALUES('Julia', 'Roberts');
INSERT INTO student(studentFirstName, studentLastName )VALUES('Tom', 'Cruise');
INSERT INTO student(studentFirstName, studentLastName )VALUES('Betty', 'White');
INSERT INTO student(studentFirstName, studentLastName )VALUES('Johnny', 'Depp');
INSERT INTO student(studentFirstName, studentLastName )VALUES('Elizabeth', 'Windsor');
INSERT INTO student(studentFirstName, studentLastName )VALUES('Chris', 'Pratt');
INSERT INTO student(studentFirstName, studentLastName )VALUES('Vin', 'Diesel');
INSERT INTO student(studentFirstName, studentLastName )VALUES('Barak', 'Obama');
INSERT INTO student(studentFirstName, studentLastName )VALUES('Michael', 'Phelps');
INSERT INTO student(studentFirstName, studentLastName )VALUES('Danny', 'Devito');
INSERT INTO student(studentFirstName, studentLastName )VALUES('Leonardo', 'DiCaprio');
INSERT INTO student(studentFirstName, studentLastName )VALUES('Brad', 'Pitt');
INSERT INTO student(studentFirstName, studentLastName )VALUES('Tom', 'Hanks');
INSERT INTO student(studentFirstName, studentLastName )VALUES('George', 'Clooney');
INSERT INTO student(studentFirstName, studentLastName )VALUES('Denzel', 'Washington');
INSERT INTO student(studentFirstName, studentLastName )VALUES('Liam', 'Neeson');
INSERT INTO student(studentFirstName, studentLastName )VALUES('Morgan', 'Freeman');
INSERT INTO student(studentFirstName, studentLastName )VALUES('Quentin', 'Tarantino');
INSERT INTO student(studentFirstName, studentLastName )VALUES('Samuel', 'Jackson');

INSERT INTO session (sessionSeatsFilled, instructorId, courseId) VALUES ('10', 1, 1);
INSERT INTO session (sessionSeatsFilled, instructorId, courseId) VALUES ('4', 2, 2);
INSERT INTO session (sessionSeatsFilled, instructorId, courseId) VALUES ('5', 3, 3);
INSERT INTO session (sessionSeatsFilled, instructorId, courseId) VALUES ('4', 4, 4);
INSERT INTO session (sessionSeatsFilled, instructorId, courseId) VALUES ('1', 5, 5);


INSERT INTO registration (sessionId, studentId) VALUES (1, 3);
INSERT INTO registration (sessionId, studentId) VALUES(1,2);
INSERT INTO registration (sessionId, studentId) VALUES(1,1);
INSERT INTO registration (sessionId, studentId) VALUES(1,4);
INSERT INTO registration (sessionId, studentId) VALUES(1,5);
INSERT INTO registration (sessionId, studentId) VALUES(1,6);
INSERT INTO registration (sessionId, studentId) VALUES(1,7);
INSERT INTO registration (sessionId, studentId) VALUES(1,8);
INSERT INTO registration (sessionId, studentId) VALUES(1,9);
INSERT INTO registration (sessionId, studentId) VALUES(1,10);
INSERT INTO registration (sessionId, studentId) VALUES(2,11);
INSERT INTO registration (sessionId, studentId) VALUES(3,12);
INSERT INTO registration (sessionId, studentId) VALUES(3,13);
INSERT INTO registration (sessionId, studentId) VALUES(3,14);
INSERT INTO registration (sessionId, studentId) VALUES(3,15);
INSERT INTO registration (sessionId, studentId) VALUES(3,16);
INSERT INTO registration (sessionId, studentId) VALUES(2,17);
INSERT INTO registration (sessionId, studentId) VALUES(2,18);
INSERT INTO registration (sessionId, studentId) VALUES(2,19);
INSERT INTO registration (sessionId, studentId) VALUES(4,20);
INSERT INTO registration (sessionId, studentId) VALUES(4,21);
INSERT INTO registration (sessionId, studentId) VALUES(4,22);
INSERT INTO registration (sessionId, studentId) VALUES(2,23);
INSERT INTO registration (sessionId, studentId) VALUES(5,24);

