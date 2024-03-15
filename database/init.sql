-- init database
CREATE DATABASE IF NOT EXISTS banking DEFAULT CHARACTER SET utf8;
USE banking;

-- Path: database/tables.sql
-- create tables
CREATE TABLE IF NOT EXISTS accounts (
  id int(11) NOT NULL AUTO_INCREMENT,
  name varchar(255) NOT NULL,
  balance decimal(10,2) NOT NULL,
  PRIMARY KEY (`id`)
);

CREATE TABLE IF NOT EXISTS passwords (
    id int(11) NOT NULL REFERENCES accounts(id),
    password varchar(255) NOT NULL,
    PRIMARY KEY (`id`)
);

-- Path: database/seed.sql
-- seed data
INSERT INTO accounts (name, balance) VALUES
('John Doe', 1000.00),
('Jane Doe', 2000.00),
('Pierre Fictif', 3000.00),
('Alexandre Fictif', 4000.00),
('Jean Fictif', 5000.00),
('Ivan Vasiliev', 6000.00),
('Piotr Ilyich', 7000.00),
('Sergei Rachmaninoff', 8000.00),
('Nikolai Rimsky-Korsakov', 9000.00),
('Igor Stravinsky', 10000.00),
('Dmitri Sheremetiev', 13200.00);

INSERT INTO passwords (id, password) VALUES
(1, 'password'),
(2, 'password'),
(3, 'password'),
(4, 'password'),
(5, 'password'),
(6, 'password'),
(7, 'password'),
(8, 'password'),
(9, 'password'),
(10, 'password'),
(11, 'password');


