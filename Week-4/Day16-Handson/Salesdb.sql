CREATE DATABASE SalesDB;

USE SalesDB;

CREATE TABLE stores
(
    store_id INT PRIMARY KEY,
    store_name VARCHAR(100)
);

CREATE TABLE products
(
    product_id INT PRIMARY KEY,
    product_name VARCHAR(100),
    price DECIMAL(10,2)
);

CREATE TABLE orders (
order_id INT PRIMARY KEY,
store_id INT,
order_date DATE,
FOREIGN KEY (store_id) REFERENCES stores(store_id)
);

CREATE TABLE order_items (
item_id INT PRIMARY KEY,
order_id INT,
product_id INT,
quantity INT,
discount DECIMAL(5,2),
FOREIGN KEY (order_id) REFERENCES orders(order_id),
FOREIGN KEY (product_id) REFERENCES products(product_id)
);

CREATE TABLE stocks(
product_id INT,
store_id INT,
quantity INT,
PRIMARY KEY(product_id,store_id)
);

INSERT INTO stores VALUES
(1,'Store1'),
(2,'Store2');
INSERT INTO products VALUES
(101,'Laptop',60000),
(102,'Mobile',20000),
(103,'Headphones',2000),
(104,'Keyboard',1500),
(105,'Mouse',800);
INSERT INTO orders VALUES
(1,1,'2026-03-01'),
(2,1,'2026-03-02'),
(3,2,'2026-03-03'),
(4,2,'2026-03-04');
INSERT INTO order_items VALUES
(1,1,101,1,10),
(2,1,105,2,5),
(3,2,102,1,0),
(4,3,103,3,5),
(5,4,101,1,15),
(6,4,104,2,0);

INSERT INTO stocks VALUES
(101,1,50),
(102,1,100),
(103,1,80),
(104,2,60),
(105,2,120);