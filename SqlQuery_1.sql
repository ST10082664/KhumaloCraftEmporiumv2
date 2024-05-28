-- Create Users Table
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    UserName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    Password NVARCHAR(100) NOT NULL,
    CreationDate DATETIME DEFAULT GETDATE(),
    PurchaseHistory TEXT
);

-- Create Products Table
CREATE TABLE Products (
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    ProductName NVARCHAR(100) NOT NULL,
    Description TEXT,
    Price DECIMAL(10, 2) NOT NULL,
    ArtisanNames NVARCHAR(100) NOT NULL,
    Category NVARCHAR(100),
    Availability NVARCHAR(50)
);
-- Create Transactions Table
CREATE TABLE Transactions (
    TransactionID INT PRIMARY KEY IDENTITY(1,1),
    TransactionDate DATETIME DEFAULT GETDATE(),
    Quantity INT NOT NULL,
    TotalAmount AS Quantity * (SELECT Price FROM Products WHERE Products.ProductID = Transactions.ProductID),
    ProductID INT,
    UserID INT,
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

SELECT 
    Transactions.TransactionID, 
    Transactions.TransactionDate, 
    Transactions.Quantity, 
    Transactions.ProductID, 
    Transactions.UserID, 
    Transactions.Quantity * Products.Price AS TotalAmount
FROM 
    Transactions 
INNER JOIN 
    Products ON Transactions.ProductID = Products.ProductID;

