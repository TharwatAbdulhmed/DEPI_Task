------------THARWAT ABDULHAMED ELSAYED ----------------------
--1) Create a stored procedure to show the number of students perdepartment.[use ITI DB]
--way1) 
create proc SP_GetStuCountPerDept
as
begin 
select count(St_Id) [Number Of Students]
from Student
where Dept_Id is not null
end
----------------
--way2) more Readable and Grouped per dept
Create Procedure GetNumOfStudentsPerDepartment
as
begin
	Select D.Dept_Name, count(S.St_Id) [Number Of Students]
	from Department D, Student S
	where D.Dept_Id = S.Dept_Id
	group by D.Dept_Name
end
---------------------------------------------------------------------------

/* 2) Create a stored procedure that will check for the Number of employees in
the project p1 if they are more than 3 print message to the user “'The
number of employees in the project p1 is 3 or more'” if they are less display
a message to the user “'The following employees work for the project p1'”
in addition to the first name and last name of each one. [MyCompany DB]*/

create proc Sp_CheckNumOfEmpInProject
as 
begin
declare @EmpCount int
--1)Get Emp Count 
select @EmpCount = Count(ESSn)   
from Works_for
where Pno = 100
--2) Check Condation 
if (@EmpCount >= 3)
select 'The number of employees in the project p1 is 3 or more' AS Message ;
else 
select 'The following employees work for the project p1' as Message;
select CONCAT( E.Fname ,'', E.Lname) as [FullName]
from Employee E , Works_for w
where E.SSN = w.ESSn and w.Pno =100
end
---RUN
Exec Sp_CheckNumOfEmpInProject

/*
3) : Create a stored procedure that will be used in case there is an old
employee has left the project and a new one become instead of him. The
procedure should take 3 parameters (old Emp. number, new Emp. number
and the project number) and it will be used to update works_on table.
[MyCompany DB]*/
create proc SP_UpdateWorksOnEmp  @OldEMpNum int ,@NewEMpNum int, @ProjectNum int
as
begin 
update Works_for
set ESSn = @NewEMpNum
where ESSn = @OldEMpNum and Pno = @ProjectNum
end
--RUN 
exec SP_UpdateWorksOnEmp 1111,2222,100
