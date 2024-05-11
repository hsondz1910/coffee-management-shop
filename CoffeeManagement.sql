CREATE DATABASE CoffeeManagement;

USE CoffeeManagement;

-- Tạo bảng Người dùng (User)
CREATE TABLE [User] (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(100),
    Password NVARCHAR(100),
    PhoneNumber NVARCHAR(20),
    Email NVARCHAR(255)
);

-- Tạo bảng Danh mục (Category)
CREATE TABLE Category (
    CategoryID INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName NVARCHAR(100)
);

-- Tạo bảng Menu (Product)
CREATE TABLE Product (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName NVARCHAR(100),
    Price DECIMAL(18, 2),
    CategoryID INT REFERENCES Category(CategoryID)
);

-- Tạo bảng Khách hàng (Customer)
CREATE TABLE Customer (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerName NVARCHAR(100),
    Phone NVARCHAR(20),
    Address NVARCHAR(255)
);

-- Tạo bảng Đơn hàng (Order)
CREATE TABLE [Order] (
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
    OrderDate DATE,
    CustomerID INT REFERENCES Customer(CustomerID),
    TotalAmount DECIMAL(18, 2)
);

-- Tạo bảng Chi tiết đơn hàng (OrderDetail)
CREATE TABLE OrderDetail (
    OrderDetailID INT IDENTITY(1,1) PRIMARY KEY,
    OrderID INT REFERENCES [Order](OrderID),
    ProductID INT REFERENCES Product(ProductID),
    Quantity INT,
    Price DECIMAL(18, 2)
);

-- Tạo bảng Thanh toán (Payment)
CREATE TABLE Payment (
    PaymentID INT IDENTITY(1,1) PRIMARY KEY,
    OrderID INT REFERENCES [Order](OrderID),
    PaymentDate DATE,
    PaymentAmount DECIMAL(18, 2)
);

-- Tạo bảng Báo cáo doanh thu (RevenueReport)
CREATE TABLE RevenueReport (
    ReportID INT IDENTITY(1,1) PRIMARY KEY,
    ReportDate DATE,
    TotalRevenue DECIMAL(18, 2)
);

-- Tạo bảng Bàn (Table)
CREATE TABLE [Table] (
    TableID INT IDENTITY(1,1) PRIMARY KEY,
    TableName NVARCHAR(100),
    Capacity INT
);

-- Thêm trường TableID vào bảng Order để lưu thông tin về bàn mà đơn hàng được đặt.
ALTER TABLE [Order]
ADD TableID INT REFERENCES [Table](TableID);

INSERT INTO [User] (Username, Password, PhoneNumber, Email) VALUES 
('admin', 'password1', '123-456-7890', 'admin1@gmail.com'),
('nhanvien1', 'password2', '456-789-0123', 'nhanvien1@gmail.com');

INSERT INTO Category (CategoryName) VALUES 
('Coffee'),
('Tea'),
('Pastries'),
('Sandwiches'),
('Smoothies'),
('Desserts'),
('Salads'),
('Breakfast'),
('Lunch'),
('Dinner');

INSERT INTO Product (ProductName, Price, CategoryID) VALUES 
('Espresso', 2.50, 1),
('Latte', 3.50, 1),
('Cappuccino', 3.00, 1),
('Green Tea', 2.00, 2),
('Black Tea', 2.00, 2),
('Matcha Latte', 4.00, 2),
('Croissant', 2.00, 3),
('Chocolate Muffin', 2.50, 3),
('Ham and Cheese', 5.00, 4),
('Turkey Sandwich', 5.50, 4),
('Berry Smoothie', 4.50, 5),
('Mango Smoothie', 4.50, 5),
('Cheesecake', 4.00, 6),
('Apple Pie', 3.50, 6),
('Caesar Salad', 6.00, 7);

INSERT INTO Customer (CustomerName, Phone, Address) VALUES 
('John Doe', '123-456-7890', '123 Main St'),
('Jane Smith', '456-789-0123', '456 Elm St'),
('Mike Johnson', '789-012-3456', '789 Oak St'),
('Emily Brown', '321-654-9870', '321 Pine St'),
('David Lee', '987-654-3210', '987 Maple St');

INSERT INTO [Order] (OrderDate, CustomerID, TotalAmount, TableID) VALUES 
('2023-01-15', 1, 10.50, 'A1'),
('2023-02-20', 2, 15.00, 'A2'),
('2023-03-25', 3, 20.50, 'B1'),
('2023-04-10', 4, 25.00, 'B2'),
('2023-05-05', 5, 30.00, 'C1');

INSERT INTO OrderDetail (OrderID, ProductID, Quantity, Price) VALUES 
(1, 1, 2, 5.00),
(1, 7, 1, 2.00),
(2, 6, 1, 4.00),
(2, 9, 1, 5.00),
(3, 12, 1, 4.50),
(3, 15, 1, 6.00),
(4, 3, 1, 3.00),
(4, 8, 1, 2.50),
(4, 10, 1, 5.50),
(5, 2, 2, 7.00),
(5, 11, 1, 4.50),
(5, 14, 1, 3.50);

INSERT INTO Payment (OrderID, PaymentDate, PaymentAmount) VALUES 
(1, '2023-01-15', 10.50),
(2, '2023-02-20', 15.00),
(3, '2023-03-25', 20.50),
(4, '2023-04-10', 25.00),
(5, '2023-05-05', 30.00);

INSERT INTO RevenueReport (ReportDate, TotalRevenue) VALUES 
('2023-01-01', 10.50),
('2023-02-01', 15.00),
('2023-03-01', 20.50),
('2023-04-01', 25.00),
('2023-05-01', 30.00);

INSERT INTO [Table] (TableName, Capacity) VALUES 
('A1', 4),
('A2', 6),
('B1', 8),
('B2', 4),
('C1', 6),
('C2', 6);