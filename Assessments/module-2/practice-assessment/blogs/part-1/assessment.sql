USE assessment;
GO

-- Select all columns from posts that are published

SELECT * FROM posts
WHERE published = 1;

-- Select posted_by and body from comments that have a body and were created after Oct. 15, 2019

SELECT posted_by, body
FROM comments
WHERE body IS NOT NULL AND created >  '2019-10-15';

-- Select the name and published states from posts ordered by when they were created, earliest first

SELECT name, published
FROM posts
ORDER BY created;

-- Select the created date and the count of all the comments created on that date

SELECT created, COUNT(*) as number_of_comments
FROM comments
GROUP BY created;

-- Select the post name, comment posted_by and comment body for all posts created after Oct. 1st, 2019

SELECT posts.name, comments.posted_by, comments.body
FROM posts
JOIN comments ON comments.post_id = posts.id
WHERE posts.created > '2019-10-01';

--Select all posts
SELECT id, name, body, published, created FROM posts;

--Insert new post

INSERT INTO posts (name, body, published, created)
VALUES ('test', 'test', 1, '2021-03-11');