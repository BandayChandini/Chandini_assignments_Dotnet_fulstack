create table Department(Dept_no varchar(20) primary key,
Dept_name varchar(30),
location varchar(100));

create table Employee(emp_no integer primary key,
emp_fname varchar(20),
emp_lname varchar(20),
dept_no varchar(20),
foreign key(Dept_no) references Department(Dept_no));

create table Project(project_no varchar(10) primary key,
project_name varchar(20),
Budget integer);

create table Works_on(emp_no integer,
project_no varchar(10),
Job varchar(20) null,
enter_date date,
foreign key(emp_no) references Employee(emp_no),
foreign key(project_no) references Project(project_no));

insert into Department values('d1','Research','Dallas'),
('d2','Accounting','Seattle'),
('d3','Marketing','Dallas');

insert into Employee values(25348,'Matthew','Smith','d3'),
(10102,'Ann','Jones','d3'),
(18316,'John','Barrimore','d1'),
(29346,'James','James','d2');

insert into Project values('p1','Apollo',120000),
('p2','Gemini',95000),
('p3','Mercury',185600);

insert into works_on values(10102,'p1','Analyst','1997.10.1'),
(10102,'p3','manager','1999.1.1'),
(25348,'p2','Clerk','1998.2.15'),
(18316,'p2',null,'1998.6.1'),
(29346,'p2',null,'1998.12.15'),
(25348,'p3','Analyst','1998.10.15'),
(18316,'p1','Manager','1998.4.15'),
(29346,'p1',null,'1998.8.1'),
(18316,'p2','Clerk','1992.2.1'),
(10102,'p3','Clerk','1997.11.15'),
(29346,'p1','Clerk','1998.1.4');

select * from Department
select * from Employee
select * from Project
--1.Get all row of the works-on table
select * from Works_on
--2.Get the employee numbers for all clerks
select emp_no from Works_on where Job='Clerk';
/*3. Get the employee numbers for employees working in project p2, 
and having employee numbers smaller than 10000. */
select emp_no from Works_on  where project_no='p2' and emp_no>10000
/*4. Get the employee numbers for all employees who didn’t enter their 
project in 1998.*/
select distinct(emp_no) from Works_on where year(enter_date)!=1998
/*5. Get the employee numbers for all employees who have a leading
job( i.e., Analyst or Manager) in project p1*/
select emp_no from Works_on where Job in('Analyst','Manager') and project_no='p1' 
/*6. Get the enter dates for all employess in project p2 whose jobs 
have not been determined yet.*/
select enter_date from Works_on where project_no='p2' and Job is null
/*7. Get the employee numbers and last names of all employees 
whose first names contain two letter t’s.*/
select emp_no,emp_lname from Employee where emp_fname like '%t%t%';
/*8. Get the employee numbers and first names of all employees 
whose last names have a letter o or a as the second character and 
end with the letters es.*/
select emp_no,emp_fname from Employee where
(emp_lname like '_o%es' or emp_lname like '_a%es')
/*9. Get the employee numbers of all employees whose departments 
are located in Seattle.*/
select e.emp_no from Employee e join Department d
on e.dept_no=d.dept_no
where location ='Seattle'
/*10. Find the last and first names of all employess who entered 
their projects on 04.01.1998*/
select emp_fname,emp_lname 
from employee e join Works_on w
on e.emp_no=w.emp_no
where enter_date='02.15.1998'
--11. Group all departments using their locations.
select count(Dept_no),location from Department group by location
--12. Find the biggest employee number
select max(emp_no) from Employee 
--13. Get the jobs that are done by more than two employees.select Job,count(emp_no) from Works_on group by Job having count(emp_no)>2 and Job is not null
/*14. Find the employee numbers of all employees who are clerks 
or work for department d3.*/
select distinct(e.emp_no) 
from Works_on w join Employee e 
on w.emp_no=e.emp_no where w.Job='Clerk' or e.dept_no='d3'