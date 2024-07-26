CREATE TABLE [dbo].[EmpDetails](
	[EmpID] [int] NOT NULL,
	[EmpName] [char](30) NOT NULL,
	[DEPT1_code] [char](4) NULL,
	[Designation] [varchar](20) NULL,
	[JoinDate] [date] NULL,
	[emp_age] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[EmpID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

insert into dbo.EmpDetails values (1,'Chandini','D001','Programmer','2.12.2002',22)
insert into dbo.EmpDetails values (2,'abc','D002','Developer','9.11.2032',21)
insert into dbo.EmpDetails values (3,'abd','D003','Team Lead','12.22.2022',19)
insert into dbo.EmpDetails values (4,'abe','D004','Team Lead','10.1.2019',18)
insert into dbo.EmpDetails values (5,'abf','D005','Programmer','2.2.2019',20)
insert into dbo.EmpDetails values (6,'abg','D006','Programmer','9.22.2022',21)
insert into dbo.EmpDetails values (7,'abh','D007','Developer','12.2.2023',24)
insert into dbo.EmpDetails values (8,'abi','D008','Developer','6.12.2022',23)
insert into dbo.EmpDetails values (9,'abj','D009','Team Lead','12.9.2025',25)
insert into dbo.EmpDetails values (10,'abk','D010','Programmer','12.21.2002',22)
select * from dbo.EmpDetails
