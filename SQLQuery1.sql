Create procedure sp_login
@username nvarchar(20),
@password nvarchar(20)
AS
BEGIN
	Select * from Login where username=@username
	and password=@password
END