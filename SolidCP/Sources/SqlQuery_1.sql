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


SELECT
	U.UserID,
	D.DomainID
FROM Users AS U
INNER JOIN UsersTree(@UserID, 1) AS UT ON U.UserID = UT.UserID
LEFT OUTER JOIN Packages AS P ON U.UserID = P.UserID
LEFT OUTER JOIN Domains AS D ON P.PackageID = D.PackageID
WHERE
	U.UserID = @UserID AND U.IsPeer = 0