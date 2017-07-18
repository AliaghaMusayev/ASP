create procedure prcStudentAllList
as
begin
Select stdID, Name, Age from student
end;

--------------------------------
create procedure prcStudentAge 
@StudentId int
as
begin
Select Age from student where stdID=@StudentId
end;