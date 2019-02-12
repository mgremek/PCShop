CREATE TABLE Users
(
	Id int PRIMARY KEY IDENTITY(1,1),
	"Login" nvarchar(50) NOT NULL,
	"Password" nvarchar(50) NOT NULL
)
