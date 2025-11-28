--CREATE PROCEDURE [dbo].[GetUserDomainsPaged]
--(
--	@ActorID int,
--	@UserID int,
--	@FilterColumn nvarchar(50) = '',
--	@FilterValue nvarchar(50) = '',
--	@SortColumn nvarchar(50),
--	@StartRow int,
--	@MaximumRows int
--)
--AS

	DECLARE @ActorID int
	DECLARE @UserID int
	DECLARE @FilterColumn nvarchar(50) = ''
	DECLARE @FilterValue nvarchar(50) = ''
	DECLARE @SortColumn nvarchar(50)
	DECLARE @StartRow int
	DECLARE @MaximumRows int
	SET @ActorID = 30
	SET @UserID = 30
	SET @FilterColumn = ''
	SET @FilterValue = ''
	SET @SortColumn = ''
	SET @StartRow = 0
	SET @MaximumRows = 100

-- build query and run it to the temporary table
DECLARE @sql nvarchar(2000)

SET @sql = '
DECLARE @HasUserRights bit
SET @HasUserRights = dbo.CheckActorUserRights(@ActorID, @UserID)

DECLARE @EndRow int
SET @EndRow = @StartRow + @MaximumRows
DECLARE @Users TABLE
(
	ItemPosition int IDENTITY(1,1),
	UserID int,
	DomainID int
)
INSERT INTO @Users (UserID, DomainID)
SELECT
	U.UserID,
	D.DomainID
FROM Users AS U
INNER JOIN UsersTree(@UserID, 1) AS UT ON U.UserID = UT.UserID
LEFT OUTER JOIN Packages AS P ON U.UserID = P.UserID
LEFT OUTER JOIN Domains AS D ON P.PackageID = D.PackageID
WHERE
	U.UserID <> @UserID AND U.IsPeer = 0
	AND @HasUserRights = 1 '

IF @FilterColumn <> '' AND @FilterValue <> ''
SET @sql = @sql + ' AND ' + @FilterColumn + ' LIKE @FilterValue '

IF @SortColumn <> '' AND @SortColumn IS NOT NULL
SET @sql = @sql + ' ORDER BY ' + @SortColumn + ' '

SET @sql = @sql + ' SELECT COUNT(UserID) FROM @Users;
SELECT
	U.UserID,
	U.RoleID,
	U.StatusID,
	U.SubscriberNumber,
	U.LoginStatusId,
	U.FailedLogins,
	U.OwnerID,
	U.Created,
	U.Changed,
	U.IsDemo,
	U.Comments,
	U.IsPeer,
	U.Username,
	U.FirstName,
	U.LastName,
	U.Email,
	D.DomainName
FROM @Users AS TU
INNER JOIN Users AS U ON TU.UserID = U.UserID
LEFT OUTER JOIN Domains AS D ON TU.DomainID = D.DomainID
WHERE TU.ItemPosition BETWEEN @StartRow AND @EndRow'

exec sp_executesql @sql, N'@StartRow int, @MaximumRows int, @UserID int, @FilterValue nvarchar(50), @ActorID int',
@StartRow, @MaximumRows, @UserID, @FilterValue, @ActorID


RETURN
