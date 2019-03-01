INSERT INTO Teacher(Birthday, Name, TeacherID)
VALUES('1985-01-01', 'Henrik Kirk', 'au000001')
GO

INSERT INTO Teacher(Birthday, Name, TeacherID)
VALUES('1980-02-01', 'Michael Loft', 'au000002')
GO

INSERT INTO Teacher(Birthday, Name, TeacherID)
VALUES('1975-03-01', 'Frank Jakobsen', 'au000003')
GO

INSERT INTO Teacher(Birthday, Name, TeacherID)
VALUES('1970-04-01', 'Troels Jensen', 'au000004')
GO

INSERT INTO Teacher(Birthday, Name, TeacherID)
VALUES('1965', 'Poul  Rovsing', 'au000005')
GO




INSERT INTO Student(Name, Birthday, StudentID, EnrollDate, GraduateDate)
VALUES('Jonas Hansen', '1993-09-25', 'au100001', '1990-01-01', '2000-01-01')
GO


INSERT INTO Student(Name, Birthday, StudentID, EnrollDate, GraduateDate)
VALUES('Troels Bleicken', '1980-01-01', 'au100002', '1990-01-01', '2000-01-01')
GO

INSERT INTO Student(Name, Birthday, StudentID, EnrollDate, GraduateDate)
VALUES('Morten Rosenquist', '2000-01-01', 'au100003', '1990-01-01', '2000-01-01')
GO

INSERT INTO Student(Name, Birthday, StudentID, EnrollDate, GraduateDate)
VALUES('Oskar Thorin', '2001-01-01', 'au100004', '1990-01-01', '2000-01-01')
GO

INSERT INTO Student(Name, Birthday, StudentID, EnrollDate, GraduateDate)
VALUES('Andreas Harfeld', '2002-01-01', 'au100006', '1990-01-01', '2000-01-01')
GO

INSERT INTO Student(Name, Birthday, StudentID, EnrollDate, GraduateDate)
VALUES('Valdemar Tang', '2003-01-01', 'au100007', '1990-01-01', '2000-01-01')
GO

INSERT INTO Student(Name, Birthday, StudentID, EnrollDate, GraduateDate)
VALUES('Thomas Moeller', '2004-01-01', 'au100005', '1990-01-01', '2000-01-01')
GO



INSERT INTO Course(CourseID, Name)
VALUES('A', 'Databaser')
GO

INSERT INTO Course(CourseID, Name)
VALUES('B', 'Software Design')
GO

INSERT INTO Course(CourseID, Name)
VALUES('C', 'Software Test')
GO

INSERT INTO Course(CourseID, Name)
VALUES('D', 'GUI')
GO

INSERT INTO Course(CourseID, Name)
VALUES('E', 'IKN')
GO


INSERT INTO _Group(GroupID, GroupSize)
VALUES('01', 4)
GO

INSERT INTO _Group(GroupID, GroupSize)
VALUES('02', 1)
GO

INSERT INTO _Group(GroupID, GroupSize)
VALUES('03', 2)
GO



INSERT INTO GroupStudents(GroupID, StudentID)
VALUES('01', 'au100001')
GO

INSERT INTO GroupStudents(GroupID, StudentID)
VALUES('01', 'au100004')
GO

INSERT INTO GroupStudents(GroupID, StudentID)
VALUES('01', 'au100006')
GO

INSERT INTO GroupStudents(GroupID, StudentID)
VALUES('01', 'au100007')
GO

INSERT INTO GroupStudents(GroupID, StudentID)
VALUES('02', 'au100001')
GO

INSERT INTO GroupStudents(GroupID, StudentID)
VALUES('03', 'au100002')
GO

INSERT INTO GroupStudents(GroupID, StudentID)
VALUES('03', 'au100003')
GO



INSERT INTO Assignment(Attemps, Grade, GroupID, CourseID)
Values(0,NULL, '02', 'A')
GO

INSERT INTO Assignment(Attemps, Grade, GroupID, CourseID)
Values(0,NULL, '01', 'B')
GO

INSERT INTO Assignment(Attemps, Grade, GroupID, CourseID)
Values(0,NULL, '01', 'C')
GO

INSERT INTO Assignment(Attemps, Grade, GroupID, CourseID)
Values(0,NULL, '03', 'A')
GO



INSERT INTO Enrolled(Status, CourseID, StudentID)
VALUES('Active', 'A', 'au100001')
GO

INSERT INTO Enrolled(Status, CourseID, StudentID)
VALUES('Active', 'B', 'au100001')
GO

INSERT INTO Enrolled(Status, CourseID, StudentID)
VALUES('Active', 'C', 'au100001')
GO

INSERT INTO Enrolled(Status, CourseID, StudentID)
VALUES('Active', 'D', 'au100001')
GO

INSERT INTO Enrolled(Status, CourseID, StudentID)
VALUES('Active', 'E', 'au100001')
GO


INSERT INTO Enrolled(Status, CourseID, StudentID)
VALUES('Active', 'A', 'au100002')
GO

INSERT INTO Enrolled(Status, CourseID, StudentID)
VALUES('Passed', 'B', 'au100002')
GO


INSERT INTO Enrolled(Status, CourseID, StudentID)
VALUES('Active', 'A', 'au100003')
GO

INSERT INTO Enrolled(Status, CourseID, StudentID)
VALUES('Active', 'E', 'au100003')
GO


INSERT INTO Enrolled(Status, CourseID, StudentID)
VALUES('Passed', 'B', 'au100004')
GO

INSERT INTO Enrolled(Status, CourseID, StudentID)
VALUES('Passed', 'C', 'au100004')
GO


INSERT INTO Enrolled(Status, CourseID, StudentID)
VALUES('Active', 'D', 'au100005')
GO

INSERT INTO Enrolled(Status, CourseID, StudentID)
VALUES('Active', 'C', 'au100005')
GO

INSERT INTO Enrolled(Status, CourseID, StudentID)
VALUES('Active', 'A', 'au100006')
GO

INSERT INTO Enrolled(Status, CourseID, StudentID)
VALUES('Active', 'C', 'au100006')
GO

INSERT INTO Enrolled(Status, CourseID, StudentID)
VALUES('Passed', 'E', 'au100006')
GO

INSERT INTO Enrolled(Status, CourseID, StudentID)
VALUES('Active', 'B', 'au100007')
GO

INSERT INTO Enrolled(Status, CourseID, StudentID)
VALUES('Active', 'D', 'au100007')
GO



INSERT INTO Grader(TeacherID, AssignmentID)
VALUES('au000001',4 )
GO

INSERT INTO Grader(TeacherID, AssignmentID)
VALUES('au000001',1 )
GO

INSERT INTO Grader(TeacherID, AssignmentID)
VALUES('au000002',2 )
GO

INSERT INTO Grader(TeacherID, AssignmentID)
VALUES('au000003',3 )
GO


INSERT INTO TeachesCourse(CourseID,TeacherID,Role)
VALUES('A','au000001', 'Responsible')
GO

INSERT INTO TeachesCourse(CourseID,TeacherID,Role)
VALUES('B','au000002', 'Responsible')
GO

INSERT INTO TeachesCourse(CourseID,TeacherID,Role)
VALUES('C','au000003', 'Responsible')
GO

INSERT INTO TeachesCourse(CourseID,TeacherID,Role)
VALUES('D','au000005', 'Responsible')
GO

INSERT INTO TeachesCourse(CourseID,TeacherID,Role)
VALUES('E','au000004', 'Responsible')
GO





INSERT INTO Calendar(CourseID, Type, _DateTime)
VALUES('A', 'Deadline', '2020-01-01 14:00:00')
GO

INSERT INTO Calendar(CourseID, Type, _DateTime)
VALUES('A', 'Handin', '2020-02-01 15:00:00')
GO

INSERT INTO Calendar(CourseID, Type, _DateTime)
VALUES('A', 'Course lecture', '2020-03-01 16:00:00')
GO

INSERT INTO Calendar(CourseID, Type, _DateTime)
VALUES('B', 'Deadline', '2020-04-01 17:00:00')
GO

INSERT INTO Calendar(CourseID, Type, _DateTime)
VALUES('B', 'Handin', '2020-05-01 18:00:00')
GO

INSERT INTO Calendar(CourseID, Type, _DateTime)
VALUES('B', 'Course lecture', '2020-06-01 19:00:00')
GO



INSERT INTO ContentArea(TextBlock, GroupSignupLink, Audio, Video, AreaID)
VALUES('TextBlok1', 'Gruppelink1', 'Audio1', 'Video1', '01')
GO

INSERT INTO ContentArea(TextBlock, GroupSignupLink, Audio, Video, AreaID)
VALUES('TextBlok2', 'Gruppelink2', 'Audio2', 'Video2', '02')
GO

INSERT INTO ContentArea(TextBlock, GroupSignupLink, Audio, Video, AreaID)
VALUES('TextBlok3', 'Gruppelink3', 'Audio3', 'Video3', '03')
GO

INSERT INTO ContentArea(TextBlock, GroupSignupLink, Audio, Video, AreaID)
VALUES('TextBlok4', 'Gruppelink4', 'Audio4', 'Video4', '04')
GO

INSERT INTO ContentArea(TextBlock, GroupSignupLink, Audio, Video, AreaID)
VALUES('TextBlok5', 'Gruppelink5', 'Audio5', 'Video5', '05')
GO



INSERT INTO Folder(FolderID)
VALUES('01')
GO

INSERT INTO Folder(FolderID)
VALUES('02')
GO

INSERT INTO Folder(FolderID)
VALUES('03')
GO

INSERT INTO Folder(FolderID)
VALUES('04')
GO

INSERT INTO Folder(FolderID)
VALUES('05')
GO

INSERT INTO Folder(FolderID)
VALUES('06')
GO





INSERT INTO CourseContent(ContentID, CourseID)
VALUES('01', 'A')
GO

INSERT INTO CourseContent(ContentID, CourseID)
VALUES('02', 'B')
GO

INSERT INTO CourseContent(ContentID, CourseID)
VALUES('03', 'C')
GO

INSERT INTO CourseContent(ContentID, CourseID)
VALUES('04', 'D')
GO

INSERT INTO CourseContent(ContentID, CourseID)
VALUES('05', 'E')
GO



INSERT INTO ContentToFolder(CourseContent, ContentFolder)
VALUES('01', '01')
GO

INSERT INTO ContentToFolder(CourseContent, ContentFolder)
VALUES('02', '02')
GO

INSERT INTO ContentToFolder(CourseContent, ContentFolder)
VALUES('03', '03')
GO

INSERT INTO ContentToFolder(CourseContent, ContentFolder)
VALUES('04', '04')
GO

INSERT INTO ContentToFolder(CourseContent, ContentFolder)
VALUES('05', '05')
GO


INSERT INTO ContentToArea(CourseContent, ContentArea)
VALUES('01', '01')
GO

INSERT INTO ContentToArea(CourseContent, ContentArea)
VALUES('02', '02')
GO

INSERT INTO ContentToArea(CourseContent, ContentArea)
VALUES('03', '03')
GO

INSERT INTO ContentToArea(CourseContent, ContentArea)
VALUES('04', '04')
GO

INSERT INTO ContentToArea(CourseContent, ContentArea)
VALUES('05', '05')
GO



INSERT INTO AreaToFolder(AreaID, FolderID)
VALUES('01', '01')
GO

INSERT INTO AreaToFolder(AreaID, FolderID)
VALUES('02', '01')
GO

INSERT INTO AreaToFolder(AreaID, FolderID)
VALUES('03', '02')
GO

INSERT INTO AreaToFolder(AreaID, FolderID)
VALUES('04', '02')
GO

INSERT INTO AreaToFolder(AreaID, FolderID)
VALUES('05', '02')
GO


