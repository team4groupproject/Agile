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

INSERT INTO course (courseName, courseStatus, courseCreditHours, courseNumSeats) VALUES ('Biology', 'Y', '3', '30');
INSERT INTO course (courseName, courseStatus, courseCreditHours, courseNumSeats) VALUES ('Chemistry', 'Y', '3', '30');
INSERT INTO course (courseName, courseStatus, courseCreditHours, courseNumSeats) VALUES ('Psychology', 'Y', '3', '30');

INSERT INTO student(studentFirstName, studentLastName )VALUES('Bob', 'Harper');
INSERT INTO student(studentFirstName, studentLastName )VALUES('Jillian', 'Michaels');
INSERT INTO student(studentFirstName, studentLastName )VALUES('Dwayne', 'Johnson');

INSERT INTO session (sessionSeatsFilled, instructorId, courseId) VALUES ('1', 1, 1);
INSERT INTO session (sessionSeatsFilled, instructorId, courseId) VALUES ('1', 2, 2);
INSERT INTO session (sessionSeatsFilled, instructorId, courseId) VALUES ('1', 3, 3);

INSERT INTO registration (sessionId, studentId) VALUES (1, 3);
INSERT INTO registration (sessionId, studentId) VALUES(2,2);
INSERT INTO registration (sessionId, studentId) VALUES(3,1);