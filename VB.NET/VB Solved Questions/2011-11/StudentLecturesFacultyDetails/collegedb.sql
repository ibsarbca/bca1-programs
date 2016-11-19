--create table classes
--(
--classname nvarchar(100) PRIMARY KEY
--)

--create table faculty
--(
--facultyid int identity(100,1) primary key,
--facultyName nvarchar(200) not null
--)

--create table lectures
--(
--lectureid int identity(100, 1) primary key,
--lectureName nvarchar(100) not null,
--facultyId int FOREIGN KEY REFERENCES faculty(facultyId)
--)

--insert into classes values('bca1')
--insert into classes values('bca2')
--insert into classes values('bca3')

--insert into faculty(facultyName) values('prof aaa')
--insert into faculty(facultyName) values('prof bbb')
--insert into faculty(facultyName) values('prof ccc')
--insert into faculty(facultyName) values('prof ddd')

----Lecture here means subject
--insert into lectures(lectureName, facultyId) values('c++', 100)
--insert into lectures(lectureName, facultyId) values('vb.net', 101)
--insert into lectures(lectureName, facultyId) values('dbms', 102)
--insert into lectures(lectureName, facultyId) values('linux', 100)
--insert into lectures(lectureName, facultyId) values('erp', 100)
--insert into lectures(lectureName, facultyId) values('ppm2', 101)
--insert into lectures(lectureName, facultyId) values('oracle', 103)
--insert into lectures(lectureName, facultyId) values('cprog', 100)
--insert into lectures(lectureName, facultyId) values('nf', 103)
--insert into lectures(lectureName, facultyId) values('cf', 102)

---- This is called a junction table
---- It used to represent Many to many relationships
--create table classesXlectures
--(
--classname nvarchar(100) FOREIGN KEY REFERENCES classes(classname),
--lectureId int FOREIGN KEY REFERENCES lectures(lectureId)
--)

--insert into classesXlectures values('bca1', 108)
--insert into classesXlectures values('bca1', 109)
--insert into classesXlectures values('bca1', 110)
--insert into classesXlectures values('bca2', 101)
--insert into classesXlectures values('bca2', 102)
--insert into classesXlectures values('bca2', 103)
--insert into classesXlectures values('bca3', 104)
--insert into classesXlectures values('bca3', 105)
--insert into classesXlectures values('bca3', 106)


--insert into students(name, age, classname) values('abc', 20, 'bca1')
--insert into students(name, age, classname) values('bcd', 20, 'bca1')
--insert into students(name, age, classname) values('cde', 20, 'bca1')
--insert into students(name, age, classname) values('def', 20, 'bca2')
--insert into students(name, age, classname) values('efg', 20, 'bca2')
--insert into students(name, age, classname) values('fgh', 20, 'bca2')
--insert into students(name, age, classname) values('ghi', 20, 'bca3')
--insert into students(name, age, classname) values('hij', 20, 'bca3')

---- This join gives us a student's classname, the subjects in those classes and the faculty of those subjects(lectures)
---- First it gets the lectureID from classesXlectures where student.classname = classesXlectures.classname
---- Then it gets the faculty id that by matching the lectureId to the facultyId from the lectures table
---- Then it matches that facultyID to the faculty name in the faculty table.

--- Notice that the values for each individual column might repeat, no two entire tuples are exactly the same.

-- This is one example of where Denormalization might be useful.


--create view StudentLectureFacultyJoin
--as
--select students.studentid, students.name, students.classname, lectures.lectureName, faculty.facultyName
--	from students join classesXlectures 
--		on students.classname = classesXlectures.classname -- Match students' classes 
--	join lectures on classesXlectures.lectureid = lectures.lectureid -- match those classes to lectures
--	join faculty on lectures.facultyid = faculty.facultyid -- match those lectures to faculty

-- This is the join itself
select students.studentid, students.name, students.classname, lectures.lectureName, faculty.facultyName
	from students join classesXlectures
		on students.classname = classesXlectures.classname -- Match students' classes 
	join lectures on classesXlectures.lectureid = lectures.lectureid -- match those classes to lectures
	join faculty on lectures.facultyid = faculty.facultyid -- match those lectures to faculty
	order by students.studentid

