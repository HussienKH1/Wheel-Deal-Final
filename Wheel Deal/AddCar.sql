CREATE PROCEDURE Car
@CRID INT,
@SSN INT,
@Brand NVARCHAR(30),
@Color NVARCHAR(30),
@Speed INT, 
@Capacity INT, 
@Mileage INT,
@Engine NVARCHAR(30),
@Available BIT, 
@BoughtID INT, 
@StartId INT, 
@EndID INT, 
@PRICE INT,
@PAYMENT INT,
@Type NVARCHAR(30),
@Model NVARCHAR(30)
As
 
Insert into Car Values (@SSN, @Brand, @Color, @Speed, @Capacity, @Mileage, @Engine, @Available, @BoughtID, @StartID,
@Endid, @PRICE, @PAYMENT, @Type, @Model)

Return 0;
