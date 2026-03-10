CREATE DATABASE EcommDb;
USE EcommDb;

CREATE TABLE categories (
    category_id INT PRIMARY KEY,
    category_name VARCHAR(100) NOT NULL
);

CREATE TABLE brands (
    brand_id INT PRIMARY KEY,
    brand_name VARCHAR(100) NOT NULL
);

CREATE TABLE products (
    product_id INT PRIMARY KEY,
    product_name VARCHAR(150) NOT NULL,
    brand_id INT,
    category_id INT,
    model_year INT,
    list_price DECIMAL(10,2),

    FOREIGN KEY (brand_id) REFERENCES brands(brand_id),
    FOREIGN KEY (category_id) REFERENCES categories(category_id)
);

CREATE TABLE customers (
    customer_id INT PRIMARY KEY,
    first_name VARCHAR(50),
    last_name VARCHAR(50),
    city VARCHAR(50)
);

CREATE TABLE stores (
    store_id INT PRIMARY KEY,
    store_name VARCHAR(100),
    city VARCHAR(50)
);

CREATE TABLE staffs (
    staff_id INT PRIMARY KEY,
    staff_name VARCHAR(100),
    store_id INT,

    FOREIGN KEY (store_id) REFERENCES stores(store_id)
);

CREATE TABLE orders (
    order_id INT PRIMARY KEY,
    customer_id INT,
    store_id INT,
    staff_id INT,
    order_date DATE,

    FOREIGN KEY (customer_id) REFERENCES customers(customer_id),
    FOREIGN KEY (store_id) REFERENCES stores(store_id),
    FOREIGN KEY (staff_id) REFERENCES staffs(staff_id)
);


INSERT INTO categories VALUES
(1,'Cars'),
(2,'Motorcycles'),
(3,'Electric Vehicles'),
(4,'Spare Parts'),
(5,'Accessories');

INSERT INTO brands VALUES
(1,'Trek'),
(2,'Giant'),
(3,'Specialized'),
(4,'Cannondale'),
(5,'Scott');

INSERT INTO products VALUES
(1,'Trek Marlin 7',1,1,2023,850.00),
(2,'Giant Defy Advanced',2,2,2022,1200.00),
(3,'Specialized Turbo Vado',3,3,2023,3000.00),
(4,'Cannondale Kids Trail',4,4,2021,400.00),
(5,'Scott Bike Helmet',5,5,2023,120.00);

INSERT INTO customers VALUES
(1,'Ravi','Kumar','Hyderabad'),
(2,'Anita','Sharma','Delhi'),
(3,'Rahul','Verma','Hyderabad'),
(4,'Sneha','Reddy','Chennai'),
(5,'Arjun','Patel','Mumbai');

INSERT INTO stores VALUES
(1,'City Bike Store','Hyderabad'),
(2,'Metro Bike Hub','Delhi'),
(3,'Speed Wheels','Mumbai'),
(4,'Bike Zone','Chennai'),
(5,'Cycle World','Bangalore');

INSERT INTO staffs VALUES
(1,'Arun',1),
(2,'Ravi Babu',2),
(3,'Priya Mohan',3),
(4,'Karthik Sharma',4),
(5,'Neha',5);

INSERT INTO orders VALUES
(1,1,1,1,'2024-01-10'),
(2,2,2,2,'2024-02-15'),
(3,3,1,1,'2024-03-05'),
(4,4,3,3,'2024-03-20'),
(5,5,4,4,'2024-04-01');


