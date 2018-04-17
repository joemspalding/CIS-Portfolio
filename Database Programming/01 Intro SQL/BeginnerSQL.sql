--103
--Write a query to display the movie title, movie yearm and movie genre for all movies.
SELECT	Movie_Title, Movie_Year, Movie_Genre 
FROM	MOVIE

--104
--Write a query to display the movie year, movie title, and movie cost sorted by movie year in descending order.
SELECT	Movie_Year, Movie_Title, Movie_Cost
FROM	MOVIE	
ORDER BY Movie_Year DESC

--105
--Write a query to display the movie title, movie year, and movie genre for all movies sorted by movie genre in ascending order, then sorted by movie year in descending order within genre.
SELECT	Movie_Title, Movie_Year, Movie_Genre
FROM	MOVIE
ORDER BY Movie_Genre ASC,
		 Movie_Year	 DESC

--106
--Write a query to display the movie number, movie title, and price code for all movies with a title that starts with the letter R.
SELECT	Movie_Num, Movie_Title, Price_Code
FROM	MOVIE
WHERE	Movie_Title LIKE 'R%'

--107
--Write a query to display the movie title, movie year, and movie cost for all movies that contain the word hope in the title. Sort the results in ascending order by title.
SELECT	Movie_Title, Movie_Year, Movie_Cost
FROM	MOVIE
WHERE	Movie_Title LIKE '%HOPE%'
ORDER BY Movie_Title ASC

--108
--Write a query to display the movie title, movie year, and movie genre for all action movies.
SELECT	Movie_Title, Movie_Year, Movie_Genre
FROM	MOVIE
WHERE	Movie_Genre = 'ACTION'

--109
--Write a query to display the movie number, movie title, and movie cost for all movies that cost more than $40.
SELECT	Movie_Num, Movie_Title, Movie_Cost
FROM	MOVIE
WHERE	Movie_Cost > 40

--110
--Write a query to display the movie number, movie title, movie cost, and movie genre for all action or comedy movies that cost less than $50. Sort the results in ascending order by genre.
SELECT	Movie_Num, Movie_Title, Movie_Cost, Movie_Genre
FROM	MOVIE
WHERE	(Movie_Genre = 'ACTION' OR Movie_Genre = 'COMEDY') AND
		Movie_Cost < 50
ORDER BY Movie_Genre ASC

--111
--Write a query to display the membership number, name, street, state, and balance for all members in TN with a balance less than $5, and whose street name inds in Avenue.
SELECT	Mem_Num, Mem_FName, Mem_LName, Mem_State, Mem_Street, Mem_Balance
FROM	MEMBERSHIP
WHERE	Mem_State = 'TN' AND
		Mem_Balance < 5 AND
		Mem_Street LIKE '%AVENUE%'

--112
--Write a query to display the movie genre and the number of movies in each genre.
SELECT	Movie_Genre, COUNT(Movie_Num) AS [Number of Movies]
FROM	MOVIE
GROUP BY Movie_Genre

--113
--Write a query to display the average cost of all the movies.
SELECT	AVG(MOVIE_COST) AS [Average Movie Cost]
FROM	MOVIE

--114
--Write a query to display the movie genre and average cost of movies in each genre.
SELECT	Movie_Genre, AVG(Movie_Cost) AS [Average Cost]
FROM	MOVIE
GROUP BY Movie_Genre

--115
--Write a query to display the movie title, price description, and price rental fee for all movies with a price code.
SELECT	Movie_Title, Movie_Genre, Price_Description, Price_RentFee
FROM	MOVIE M INNER JOIN PRICE P ON P.PRICE_CODE = M.PRICE_CODE

--116
--Write a query to display the movie genre and average rental fee for all movies in each genre that have a price.
SELECT	M.Movie_Genre, AVG(P.Price_RentFee)
FROM	MOVIE M INNER JOIN PRICE P ON M.Price_Code = P.Price_Code
GROUP BY Movie_Genre

--117
--Write a query to display the movie title and breakeven amount for each movie that has a price. The breakeven amount is the movie cost divided by the price rental fee for each movie that has a price; it determines the number of rentals needed to break even on the purchase of the movie.
SELECT	M.Movie_Title, Movie_Cost/Price_RentFee AS [Break Even Rentals]
FROM	MOVIE M INNER JOIN PRICE P ON M.Price_Code = P.Price_Code

--118
--Write a query to display the movie title and movie year for all movies that have a price code.
SELECT	Movie_Title, Movie_Year
FROM	MOVIE
WHERE	Price_Code IS NOT NULL

--119
--Write a query to display the movie title, movie genre, and movie cost for all movies that cost between $44.99 and $49.99.
SELECT	Movie_Title, Movie_Genre, Movie_Cost
FROM	MOVIE
WHERE	Movie_Cost >= 44.99 AND
		Movie_Cost <= 49.99

--120
--Write a query to display the movie title, price description, price rental fee, and genre for all movies that are in the genres of family, comedy, or drama.
SELECT	M.Movie_Title, P.Price_Description, P.Price_RentFee, M.Movie_Genre
FROM	MOVIE M INNER JOIN PRICE P ON M.Price_Code = P.Price_Code
WHERE	M.Movie_Genre = 'FAMILY' OR
		M.Movie_Genre = 'COMEDY' OR
		M.Movie_Genre = 'DRAMA'

--121
--Write a query to display the membership number, first name, lst name, and balance of the memberships that have a rental.
SELECT	M.Mem_Num, M.Mem_FName, M.Mem_LName, M.Mem_Balance
FROM	MEMBERSHIP M INNER JOIN RENTAL R ON M.MEM_NUM = R.MEM_NUM
WHERE	R.Mem_Num IS NOT NULL

--122
--Write a query to display the minimum balance, maximum balance, and average balance for the memberships that have a rental.
SELECT	MIN(M.Mem_Balance) AS [Minimum Balance],
		MAX(M.Mem_Balance) AS [Maximum Balance],
		AVG(M.Mem_Balance) AS [Average Balance]
FROM	MEMBERSHIP M INNER JOIN RENTAL R ON M.MEM_NUM = R.MEM_NUM
WHERE	R.Mem_Num IS NOT NULL

--123
--Write a query to display the rental number, rental date, video number, movie title, due date, and return date for all videos that were returned after the due date. Sort the results by rental number and movie title.
SELECT	R.Rent_Num, R.Rent_Date, V.Vid_Num, M.Movie_Title, D.Detail_DueDate, D.Detail_ReturnDate
FROM	RENTAL R INNER JOIN DETAILRENTAL D ON R.RENT_NUM = D.RENT_NUM
		INNER JOIN VIDEO V ON D.VID_NUM = V.VID_NUM 
		INNER JOIN MOVIE M ON V.Movie_Num = M.Movie_Num
WHERE	D.Detail_ReturnDate > D.Detail_DueDate
ORDER BY R.Rent_Num, M.Movie_Title

--124
--Write a query to display the rental number, rental date, movie title, and detail fee for each movie that was returned on or before the due date.
SELECT	R.Rent_Num, R.Rent_Date, V.Vid_Num, M.Movie_Title, D.Detail_Fee
FROM	RENTAL R INNER JOIN DETAILRENTAL D ON R.RENT_NUM = D.RENT_NUM
		INNER JOIN VIDEO V ON D.VID_NUM = V.VID_NUM 
		INNER JOIN MOVIE M ON V.Movie_Num = M.Movie_Num
WHERE	D.Detail_ReturnDate <= D.Detail_DueDate

--125
--Write a query to display the movie number, movie genre, average cost of movies in that genre, cost of the individual movie, and the percentage difference between the average movie cost and the individual movie cost. 
--The percentage difference is the cost of the individual movie minus the average cost of movies in that genre, divided by the average cost of movies in that genre multiplied by 100.

--Create a view for the complicated subquery
CREATE VIEW TEMP_VIEW AS
SELECT	M.Movie_Genre, (
						SELECT	AVG(Movie_Cost)
						FROM	MOVIE 
						WHERE	M.Movie_Genre = Movie_Genre
					    ) AS [Average_Cost]
FROM	MOVIE M

--Answer to 125
SELECT	M.Movie_Num, M.Movie_Genre, V.Average_Cost, M.Movie_Cost, (M.Movie_Cost-V.Average_Cost)/V.Average_Cost * 100 AS [Percent_Difference]
FROM	MOVIE M INNER JOIN TEMP_VIEW V ON M.Movie_Genre = V.Movie_Genre

--Drop the view
DROP VIEW TEMP_VIEW

