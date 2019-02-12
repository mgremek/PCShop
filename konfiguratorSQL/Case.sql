CREATE TABLE "Case"
(
	Id int PRIMARY KEY IDENTITY(1,1),
	Price float NOT NULL,
	Manufacturer varchar(50) NOT NULL,
	Model varchar(50) NOT NULL,
	Color varchar(50) NOT NULL,
	Material varchar(50) NOT NULL,
	Window BINARY NOT NULL
);
SELECT * FROM "Case";