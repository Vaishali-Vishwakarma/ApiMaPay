create table [dbo].[tblAdmin](
id int identity(1,1) Not null,
email nvarchar(max) not null,
password nvarchar(max) not null
)

create proc sp_adminlogin
(
@email nvarchar(50)=null,
@password nvarchar(50)=null,
@stmttype nvarchar(50)
)
as
begin
	if(@stmttype='adminlogin')
	begin
		select*from tblAdmin where
		email=@email and password=@password
	end;
end;