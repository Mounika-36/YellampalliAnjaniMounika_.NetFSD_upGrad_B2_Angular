CREATE DATABASE Customer

USE Customer;


CREATE TABLE categories (
    category_id INT PRIMARY KEY,
    category_name VARCHAR(50)
);


CREATE TABLE products (
    product_id INT PRIMARY KEY,
    product_name VARCHAR(50),
    model_year INT,
    list_price DECIMAL(10,2),
    category_id INT
);


CREATE TABLE customers (
    customer_id INT PRIMARY KEY,
    first_name VARCHAR(50),
    last_name VARCHAR(50)
);


CREATE TABLE orders (
    order_id INT PRIMARY KEY,
    customer_id INT,
    order_date DATE,
    shipped_date DATE,
    required_date DATE,
    order_status INT
);


CREATE TABLE order_items (
    item_id INT PRIMARY KEY,
    order_id INT,
    product_id INT,
    quantity INT,
    list_price DECIMAL(10,2),
    discount DECIMAL(10,2)
);


CREATE TABLE stores (
    store_id INT PRIMARY KEY,
    store_name VARCHAR(50)
);


CREATE TABLE stocks (
    store_id INT,
    product_id INT,
    quantity INT
);

INSERT INTO categories VALUES
(1,'Bikes'),
(2,'Accessories'),
(3,'Clothing');


INSERT INTO Products VALUES
(1, 'Duke Bike',2017, 800,1),
(2, 'Pulsar Bike', 2018, 1200,1),
(3, 'Tvs Bike', 2019, 1000,1),
(4, 'Electric Bike', 2018, 2000,2),
(5, 'Hero Honda Bike', 2019, 1500,2),
(6, 'Royal Enfield Bike', 2017, 700,2);

INSERT INTO customers VALUES
(1,'Anjani ','Yellampalli'),
(2,'Deepika','Nagasuri'),
(3,'Kavya','David');


INSERT INTO orders VALUES
(1,1,'2023-01-10','2023-01-15','2023-01-20',1),
(2,2,'2023-02-01','2023-02-05','2023-02-07',2),
(3,1,'2022-01-01','2022-01-05','2022-01-06',3);


INSERT INTO order_items VALUES
(1,1,1,2,8000,500),
(2,1,3,1,2000,100),
(3,2,2,1,12000,1000);


INSERT INTO stores VALUES
(1,'Hyderabad Store'),
(2,'Chennai Store');


INSERT INTO stocks VALUES
(1,1,10),
(1,2,0),
(2,3,5);