CREATE PROCEDURE [dbo].[spUserLookup]
	@Id nchar(128)
AS
begin
	select Id, FirstName, LastName, EmailAddress, CreatedDate
	from [dbo].[User]
	where Id=@Id;
end
