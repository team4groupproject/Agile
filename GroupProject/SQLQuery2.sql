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
	   courseNumSeats INT NOT NULL,
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

INSERT INTO course (courseName, courseStatus, courseCreditHours, courseNumSeats) VALUES ('Biology', 'Y', '3', '30');
INSERT INTO course (courseName, courseStatus, courseCreditHours, courseNumSeats) VALUES ('Chemistry', 'Y', '3', '30');
INSERT INTO course (courseName, courseStatus, courseCreditHours, courseNumSeats) VALUES ('Psychology', 'Y', '3', '30');
INSERT INTO course (courseName, courseStatus, courseCreditHours, courseNumSeats) VALUES ('English', 'Y', '3', '30');
INSERT INTO course (courseName, courseStatus, courseCreditHours, courseNumSeats) VALUES ('College Algebra', 'Y', '3', '30');

INSERT INTO student(studentFirstName, studentLastName )VALUES('Bob', 'Harper');
INSERT INTO student(studentFirstName, studentLastName )VALUES('Jillian', 'Michaels');
INSERT INTO student(studentFirstName, studentLastName )VALUES('Dwayne', 'Johnson');
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
INSERT INTO student(studentFirstName, studentLastName )VALUES('Barack', 'Obama');
INSERT INTO student(studentFirstName, studentLastName )VALUES('Michael', 'Phelps');


INSERT INTO session (sessionSeatsFilled, instructorId, courseId) VALUES ('3', 1, 1);
INSERT INTO session (sessionSeatsFilled, instructorId, courseId) VALUES ('3', 2, 2);
INSERT INTO session (sessionSeatsFilled, instructorId, courseId) VALUES ('3', 3, 3);
INSERT INTO session (sessionSeatsFilled, instructorId, courseId) VALUES ('3', 4, 4);
INSERT INTO session (sessionSeatsFilled, instructorId, courseId) VALUES ('3', 5, 5);

INSERT INTO registration (sessionId, studentId) VALUES (1, 1);
INSERT INTO registration (sessionId, studentId) VALUES(2,2);
INSERT INTO registration (sessionId, studentId) VALUES(3,3);
INSERT INTO registration (sessionId, studentId) VALUES (4, 4);
INSERT INTO registration (sessionId, studentId) VALUES(5,5);
INSERT INTO registration (sessionId, studentId) VALUES(1,6);
INSERT INTO registration (sessionId, studentId) VALUES (2, 7);
INSERT INTO registration (sessionId, studentId) VALUES(3,8);
INSERT INTO registration (sessionId, studentId) VALUES(4,9);
INSERT INTO registration (sessionId, studentId) VALUES (5, 10);
INSERT INTO registration (sessionId, studentId) VALUES(1,11);
INSERT INTO registration (sessionId, studentId) VALUES(2,12);
INSERT INTO registration (sessionId, studentId) VALUES (3, 13);
INSERT INTO registration (sessionId, studentId) VALUES(4,14);
INSERT INTO registration (sessionId, studentId) VALUES(5,15);
