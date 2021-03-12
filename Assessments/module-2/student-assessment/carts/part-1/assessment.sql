USE assessment;
GO

-- Select all the columns in cart where the username is kmilner1j

SELECT *
FROM carts
WHERE username = 'kmilner1j';

-- Select the id and name columns from items where the item was added on or after Jan. 15, 2019 and the weight is null

SELECT id, name
FROM items
WHERE added >= '2019-01-15' AND weight IS NULL;

-- Select username and the cookie_value from carts where the username isn't null, ordered by the created date, latest first

SELECT username, cookie_value
FROM carts
WHERE username IS NOT NULL
ORDER BY created DESC;

-- Select the added date and the count of all the items added on that date

SELECT added, COUNT(*) AS number_of_items
FROM items
GROUP BY added;

-- Select the cart's username and created date and the item's name for all carts created in the month of Sept. 2019

SELECT carts.username, carts.created, items.name
FROM carts
JOIN items ON items.cart_id = carts.id
WHERE carts.created BETWEEN '2019-09-01' AND '2019-09-30';

--queries for part 2 of project
SELECT id, username, cookie_value, created FROM carts;

INSERT INTO carts (username, cookie_value, created) VALUES ('test', 'test', '2021-03-12');