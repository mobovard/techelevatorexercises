USE master;
GO

DROP DATABASE IF EXISTS ProjectOrganizer

CREATE DATABASE ProjectOrganizer;
GO

USE ProjectOrganizer;
GO

BEGIN TRANSACTION; 

CREATE TABLE department
(
	department_id		int			identity(1, 1),
	department_name		varchar(100)		NOT NULL,

	CONSTRAINT pk_department PRIMARY KEY (department_id)
);


CREATE TABLE employee
(
	employee_number		int				identity(1, 1),
	job_title			varchar(100)	NOT NULL,
	last_name			varchar(100)	NOT NULL,
	first_name			varchar(100)	NOT NULL,
	gender				varchar(100),
	date_of_birth		datetime,
	date_of_hire		datetime,
	department_id		int,	
	
	CONSTRAINT pk_employee PRIMARY KEY (employee_number),
	CONSTRAINT fk_employee_department FOREIGN KEY (department_id) REFERENCES department(department_id)
);

CREATE TABLE project
(
	project_number		int			identity(1, 1),
	project_name		varchar(100)		NOT NULL,
	start_date			datetime,

	CONSTRAINT pk_project PRIMARY KEY (project_number)
);


CREATE TABLE employee_project
(
	project_number		int		NOT NULL,
	employee_number		int		NOT NULL,

	CONSTRAINT pk_employee_project PRIMARY KEY (project_number, employee_number),
	CONSTRAINT fk_employee_project_number FOREIGN KEY (project_number) REFERENCES project  (project_number),
	CONSTRAINT fk_employee_project_employee_number FOREIGN KEY (employee_number) REFERENCES employee (employee_number)
);


INSERT INTO project (project_name, start_date)
VALUES ('project purple', CONVERT(DATETIME,'12/20/20'));

INSERT INTO project (project_name, start_date)
VALUES ('project blue', CONVERT(DATETIME,'02/15/21'));

INSERT INTO project (project_name, start_date)
VALUES ('project pink', CONVERT(DATETIME,'02/01/21'));

INSERT INTO project (project_name, start_date)
VALUES ('project green', CONVERT(DATETIME,'01/05/21'));

INSERT INTO department (department_name)
VALUES ('Engineering');

INSERT INTO department (department_name)
VALUES ('Finance');

INSERT INTO department (department_name)
VALUES ('Culinary');

SELECT * FROM department;

SELECT * FROM project;

INSERT INTO employee (job_title, last_name, first_name, gender, date_of_birth, date_of_hire, department_id)
VALUES ('Manager', 'Ackles', 'Jensen', 'Male', CONVERT(datetime,'01/01/1990'), CONVERT(datetime,'01/01/2015'), 1);

INSERT INTO employee (job_title, last_name, first_name, gender, date_of_birth, date_of_hire, department_id)
VALUES ('Hacker', 'Winchester', 'Samuel', 'Male', CONVERT(datetime,'01/01/1992'), CONVERT(datetime,'01/01/2017'), 1);

INSERT INTO employee (job_title, last_name, first_name, gender, date_of_birth, date_of_hire, department_id)
VALUES ('Controller', 'Padalecki', 'Jared', 'Male', CONVERT(datetime,'01/01/1970'), CONVERT(datetime,'01/01/2018'), 2);

INSERT INTO employee (job_title, last_name, first_name, gender, date_of_birth, date_of_hire, department_id)
VALUES ('Accountant', 'Winchester', 'Dean', 'Male', CONVERT(datetime,'01/01/1990'), CONVERT(datetime,'01/01/2015'), 2);

INSERT INTO employee (job_title, last_name, first_name, gender, date_of_birth, date_of_hire, department_id)
VALUES ('Sous Chef', 'Collins', 'Misha', 'Male', CONVERT(datetime,'01/01/1985'), CONVERT(datetime,'01/01/2016'), 3);

INSERT INTO employee (job_title, last_name, first_name, gender, date_of_birth, date_of_hire, department_id)
VALUES ('Line Cook', 'Angel', 'Castiel', 'Male', CONVERT(datetime,'01/01/1805'), CONVERT(datetime,'01/01/2000'), 3);

INSERT INTO employee (job_title, last_name, first_name, gender, date_of_birth, date_of_hire, department_id)
VALUES ('Server', 'Macleod', 'Fergus', 'Male', CONVERT(datetime,'01/01/1760'), CONVERT(datetime,'01/01/2005'), 3);

INSERT INTO employee (job_title, last_name, first_name, gender, date_of_birth, date_of_hire, department_id)
VALUES ('Plater', 'Crowley', 'King', 'Male', CONVERT(datetime,'01/01/1800'), CONVERT(datetime,'01/01/2012'), 3);

SELECT * FROM employee;

INSERT INTO employee_project (project_number, employee_number)
VALUES (1, 1);

INSERT INTO employee_project (project_number, employee_number)
VALUES (3, 2);

INSERT INTO employee_project (project_number, employee_number)
VALUES (2, 3);

INSERT INTO employee_project (project_number, employee_number)
VALUES (4, 4);

SELECT * FROM project;

SELECT * FROM employee_project;

COMMIT TRANSACTION;

