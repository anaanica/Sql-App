USE [LIBRARY]

--ddl
CREATE TABLE EmployeeDetails(
    IdDetails INT PRIMARY KEY IDENTITY,
    [Address] NVARCHAR(100) null,
    Phone NVARCHAR(20) not null,
    Email NVARCHAR(100) null
);

CREATE TABLE Employee(
	IdEmployee INT PRIMARY KEY IDENTITY,
	ManagerId INT null FOREIGN KEY REFERENCES Employee(IDEmployee), --self-referencing
	[Name] NVARCHAR(50) not null,
	DetailsId INT null FOREIGN KEY REFERENCES EmployeeDetails(IdDetails) UNIQUE --one-to-one
);

CREATE TABLE Author(
    IdAuthor INT PRIMARY KEY IDENTITY,
    [Name] NVARCHAR(100)
);

CREATE TABLE Publisher(
    IdPublisher INT PRIMARY KEY IDENTITY,
    [Name] NVARCHAR(100)
);

CREATE TABLE Book(
    IdBook INT PRIMARY KEY IDENTITY,
    Title NVARCHAR(255),
    Isbn NVARCHAR(20),
	PublisherId INT not null FOREIGN KEY REFERENCES Publisher(IdPublisher) --one-to-many (one publisher multiple books)
);

CREATE TABLE BookAuthor(
	IdBookAuthor INT PRIMARY KEY IDENTITY,
	BookId INT not null FOREIGN KEY REFERENCES Book(IdBook),
	AuthorId INT null FOREIGN KEY REFERENCES Author(IdAuthor) --many-to-many
);

CREATE TABLE Category(
    IdCategory INT PRIMARY KEY IDENTITY,
    [Name] NVARCHAR(100)
);

CREATE TABLE BookCategory(
	IdBookCategory INT PRIMARY KEY IDENTITY,
	BookId INT not null FOREIGN KEY REFERENCES Book(IdBook),
	CategoryId INT null FOREIGN KEY REFERENCES Category(IdCategory) --many-to-many
);

CREATE TABLE Member(
    IdMember INT PRIMARY KEY IDENTITY,
    [Name] NVARCHAR(100),
    Email NVARCHAR(100)
);

CREATE TABLE Loan(
    IdLoan INT PRIMARY KEY IDENTITY,
    LoanDate DATETIME2 (7) not null,
    ReturnDate DATETIME2 (7) null,
	MemberId INT not null FOREIGN KEY REFERENCES Member(IdMember), --many-to-one (one member multiple loans)
	EmployeeId INT not null FOREIGN KEY REFERENCES Employee(IdEmployee)
);

CREATE TABLE BookLoan( --many-to-many
    IdBookLoan INT PRIMARY KEY IDENTITY,
	LoanId INT not null FOREIGN KEY REFERENCES Loan(IdLoan),
	BookId INT not null FOREIGN KEY REFERENCES Book(IdBook)
);

CREATE TABLE Review(
    IdReview INT PRIMARY KEY IDENTITY,
    ReviewText TEXT not null,
    CreatedAt DATETIME2 (7) not null,
	BookId INT not null FOREIGN KEY REFERENCES Book(IdBook),
	MemberId INT not null FOREIGN KEY REFERENCES Member(IdMember)
);

ALTER TABLE Review
ADD DeletedAt DATETIME2(7) NULL;

DROP TABLE Review;

--dml

INSERT INTO Member VALUES ('Milica Krmpotic', 'milica@gmail.com')
INSERT INTO Member VALUES ('Ana Anic', 'ana@gmail.com')

SELECT * FROM Member

UPDATE Member SET Email = 'milicaaa@gmail.com' WHERE IdMember = 1

DELETE FROM Member WHERE IdMember = 2



