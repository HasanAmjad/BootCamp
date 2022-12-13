CREATE TABLE Users
( 
userID int IDENTITY(1,1),
userName VARCHAR(50)NOT NULL,
email VARCHAR(100) NOT NULL,
userRole VARCHAR(50) NOT NULL,
Password VARCHAR(100) NOT NULL,
PRIMARY KEY (userID));

ALTER TABLE Posts
ADD Column postTime GetDate;
CREATE TABLE Posts
(
postID int IDENTITY(1,1),
title VARCHAR(50)NOT NULL,
body VARCHAR(500) NOT NULL,
postUserID int,
postTime datetime DEFAULT GETDATE(),
upVoteCount int DEFAULT 0,
downVoteCount int DEFAULT 0, 
PRIMARY KEY (postID),
FOREIGN KEY (postUserID) REFERENCES Users(userID) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE Comments
(
commentID int IDENTITY(1,1),
userName VARCHAR(50)NOT NULL,
commentText NVARCHAR(500) NOT NULL,
commentUserID int,
commentPostID int, 
PRIMARY KEY (commentID),
FOREIGN KEY (commentUserID) REFERENCES Users(userID) ON DELETE CASCADE ON UPDATE CASCADE,
FOREIGN KEY (commentPostID) REFERENCES Posts(postID) ON DELETE CASCADE ON UPDATE CASCADE
);
GO
CREATE PROCEDURE displayPostsList
AS BEGIN
SELECT *FROM Posts;
END
GO
CREATE PROCEDURE addPost 
	@uID INT, 
	@title VARCHAR(30), 
	@body VARCHAR(100)
AS
BEGIN
INSERT INTO Posts (postUserID, title, body)
VALUES (@uID, @title, @body)
END
EXECUTE addPost 1, 'Hello','Test Annoucement';