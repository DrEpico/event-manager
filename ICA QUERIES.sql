 -- TSQL09 ICA-Demo: Grouping and Aggregating Data
-- TSQL09 ICA-Demo 1: Using the GROUP BY Clause for Aggregation [BASIC]
-- End user: I want to see a list of clubs along with the total number of players and their average market value, 
--	so I can compare how well clubs are doing in terms of player talent and value. I’m interested in how the average 
--	value of players differs across clubs, and it would be useful to see these values rounded to a higher level for easier comparison.
-- SQL Developer: I need to create a query that joins data from multiple tables (Players, PlayerClubs, and Clubs) to provide an aggregate 
--	summary of the number of players and their average market value per club. 
-- Data Scientist: I want to analyze player market value distribution across different clubs to help identify clubs that have a higher 
--	concentration of valuable players. Additionally, rounding the average player value to the nearest significant number will help in 
--	understanding the broader trends without being distracted by granular fluctuations.
SELECT 
    C.name AS ClubName, 
    COUNT(P.player_id) AS TotalPlayers,
    ROUND(CAST(AVG(P.value) AS DECIMAL(18, 2)), -5) AS AvgPlayerValue
FROM Players P
JOIN PlayerClubs PC 
    ON P.player_id = PC.player_id
JOIN Clubs C
    ON PC.club_id = C.club_id
GROUP BY C.name
ORDER BY AvgPlayerValue DESC;

--2. TSQL09 ICA-Demo 2: Applying Aggregate Functions (SUM, COUNT, AVG, MIN, MAX) [BASIC]
-- End user: I want to view country-wise player statistics to analyze team strength and market value.
-- SQL developer: I want to write queries that aggregate player data by country to provide insights 
--	on total player count, market value, and wage distribution.
-- Data Scientist: I want to analyze the aggregated player data to discover patterns in player wages 
--	and market values across different countries.
SELECT 
    CO.name AS CountryName,
    COUNT(P.player_id) AS TotalPlayers,
    SUM(P.value) AS TotalMarketValue,
    AVG(P.wage) AS AvgPlayerWage,
    MIN(P.value) AS MinPlayerValue,
    MAX(P.value) AS MaxPlayerValue
FROM Players P
JOIN PlayerCountries PC 
    ON P.player_id = PC.player_id
JOIN Countries CO
    ON PC.country_id = CO.country_id
GROUP BY CO.name
ORDER BY TotalMarketValue DESC;

-- 3. TSQL09 ICA-Demo 3: Filtering Groups with the HAVING Clause [INTERMEDIATE]
-- End user: I want to filter and compare top-performing players or countries based on custom criteria
-- SQL developer: I want to write queries using the HAVING clause to filter grouped data, 
--	such as players from countries where total player value exceeds a specific threshold, enabling more refined reporting.
-- Data Scientist: I want to apply data filters after aggregation to analyze only countries or clubs 
--	that meet specific performance conditions, such as average player wage or number of specialities per player.
SELECT 
    CO.name AS CountryName, 
    COUNT(P.player_id) AS TotalPlayers, 
    SUM(P.value) AS TotalMarketValue, 
    AVG(P.wage) AS AvgPlayerWage, 
    MIN(P.value) AS MinPlayerValue, 
    MAX(P.value) AS MaxPlayerValue
FROM Players P
JOIN PlayerCountries PC ON P.player_id = PC.player_id
JOIN Countries CO ON PC.country_id = CO.country_id
GROUP BY CO.name
HAVING SUM(P.value) > 1000000000  -- Filtering countries with total market value > 1 billion
ORDER BY TotalMarketValue DESC;

-- 4. TSQL09 ICA-Demo 4: Grouping Data by Multiple Columns [INTERMEDIATE]
-- End user: I want to see player statistics grouped by both country and club, so I can 
--	compare how players from different clubs perform within the same country.
-- SQL developer: I want to write a query that groups players by country and club to provide a 
--	detailed view of how player market value and wages vary across these dimensions.
-- Data Scientist: I want to analyze data grouped by country and club to identify trends in player attributes, 
--	such as average value or wage differences within each club across countries.
SELECT 
    CO.name AS CountryName, 
    CL.name AS ClubName, 
    COUNT(P.player_id) AS TotalPlayers, 
    SUM(P.value) AS TotalMarketValue, 
    AVG(P.wage) AS AvgPlayerWage, 
    MIN(P.value) AS MinPlayerValue, 
    MAX(P.value) AS MaxPlayerValue
FROM Players P
JOIN PlayerCountries PC ON P.player_id = PC.player_id
JOIN Countries CO ON PC.country_id = CO.country_id
JOIN PlayerClubs PCU ON P.player_id = PCU.player_id
JOIN Clubs CL ON PCU.club_id = CL.club_id
GROUP BY CO.name, CL.name
ORDER BY CO.name, CL.name;


--TSQL09 Demo 5: Using ROLLUP to Create Subtotals [ADVANCED]
-- This query uses ROLLUP to calculate subtotals and grand totals of player wages grouped by leagues and clubs.
SELECT 
    l.name AS LeagueName,
    c.name AS ClubName,
    SUM(p.wage) AS TotalWage
FROM 
    Players p
JOIN 
    PlayerClubs pc ON p.player_id = pc.player_id
JOIN 
    Clubs c ON pc.club_id = c.club_id
JOIN 
    Leagues l ON c.league_id = l.league_id
GROUP BY 
    ROLLUP (l.name, c.name)
ORDER BY 
    l.name, c.name;

-- TSQL09 ICA Demo 6: Using CUBE for Multidimensional Aggregates [ADVANCED]
-- This query uses CUBE to analyze the total value of players across countries and leagues, providing all combinations.
SELECT 
    co.name AS CountryName,
    l.name AS LeagueName,
    SUM(p.value) AS TotalPlayerValue
FROM 
    Players p
JOIN 
    PlayerCountries pc ON p.player_id = pc.player_id
JOIN 
    Countries co ON pc.country_id = co.country_id
JOIN 
    PlayerClubs plc ON p.player_id = plc.player_id
JOIN 
    Clubs c ON plc.club_id = c.club_id
JOIN 
    Leagues l ON c.league_id = l.league_id
GROUP BY 
    CUBE (co.name, l.name)
ORDER BY 
    co.name, l.name;

-- TSQL09 ICA Demo 7: Combining GROUP BY with Window Functions for Advanced Aggregates [ADVANCED]
-- This query computes the total player value for each league, the rank of each club based on its player value, and includes league-wide aggregates.
SELECT 
    l.name AS LeagueName,
    c.name AS ClubName,
    SUM(p.value) AS ClubTotalValue,
    RANK() OVER (PARTITION BY l.name ORDER BY SUM(p.value) DESC) AS ClubRankInLeague,
    SUM(SUM(p.value)) OVER (PARTITION BY l.name) AS LeagueTotalValue
FROM 
    Players p
JOIN 
    PlayerClubs pc ON p.player_id = pc.player_id
JOIN 
    Clubs c ON pc.club_id = c.club_id
JOIN 
    Leagues l ON c.league_id = l.league_id
GROUP BY 
    l.name, c.name;

-- TSQL09 ICA Demo 8: Optimizing Aggregation Queries for Performance [ADVANCED]
-- Optimized Aggregation Query for Top Players in Each League
-- This query calculates the top player's value in each league for performance optimization using window functions.
SELECT DISTINCT
    l.name AS LeagueName,
    p.name AS PlayerName,
    p.value AS PlayerValue
FROM 
    Players p
JOIN 
    PlayerClubs pc ON p.player_id = pc.player_id
JOIN 
    Clubs c ON pc.club_id = c.club_id
JOIN 
    Leagues l ON c.league_id = l.league_id
WHERE 
    p.value = (
        SELECT MAX(p1.value)
        FROM Players p1
        JOIN PlayerClubs pc1 ON p1.player_id = pc1.player_id
        JOIN Clubs c1 ON pc1.club_id = c1.club_id
        JOIN Leagues l1 ON c1.league_id = l1.league_id
        WHERE l1.league_id = l.league_id
    )
ORDER BY 
    LeagueName, PlayerValue DESC;



-- TSQL10 ICA-Demo: Using Subqueries
-- 1. TSQL10 ICA-Demo 1: Writing Simple Subqueries in SELECT Statements [BASIC]
-- End user: 
-- SQL developer: 
-- Data Scientist: 
SELECT 
    P.name AS PlayerName, 
    P.value AS PlayerValue, 
    P.wage AS PlayerWage, 
	--while sub queries are sometimes not the most efficient option but if used correctly it can optimise the query to for example use 
	--data from multiple tables without using Join's 
    (SELECT AVG(value) FROM Players) AS AvgPlayerValue, 
    (SELECT AVG(wage) FROM Players) AS AvgPlayerWage,
    P.value - (SELECT AVG(value) FROM Players) AS ValueDifference
FROM Players P
ORDER BY PlayerValue DESC;

-- 2. TSQL10 ICA-Demo 2: Using Subqueries in the WHERE Clause [BASIC]
-- End user: 
-- SQL developer: 
-- Data Scientist: 
-- We are selecting player_id, name, potential, club_name, and league_name for players.
SELECT p.player_id, p.name, pa.potential, c.name AS club_name, l.name AS league_name
FROM Players p
JOIN PlayerAttributes pa ON p.player_id = pa.player_id
JOIN PlayerClubs pc ON p.player_id = pc.player_id
JOIN Clubs c ON pc.club_id = c.club_id
JOIN Leagues l ON c.league_id = l.league_id
WHERE l.name = 'Premier League'
AND pa.potential > (
    SELECT AVG(pa2.potential)
    FROM Players p2
    JOIN PlayerAttributes pa2 ON p2.player_id = pa2.player_id
    JOIN PlayerClubs pc2 ON p2.player_id = pc2.player_id
    JOIN Clubs c2 ON pc2.club_id = c2.club_id
    JOIN Leagues l2 ON c2.league_id = l2.league_id
    WHERE l2.name = 'Premier League'
);
-- We use a subquery to find the average potential rating of all players in the Premier League and compare 
-- each player's potential to that value. Only players with a potential higher than the average are returned.

-- 3. TSQL10 ICA-Demo 3: Writing Correlated Subqueries 
-- Scenario: We want to find all players who have a wage higher than the average wage of players in their club. 
--	This requires a correlated subquery because for each player, we’ll compare their wage to the 
--	average wage of the players in the same club.
-- End user: 
-- SQL developer: 
-- Data Scientist: 
SELECT p.player_id, p.name, p.wage, c.name AS club_name
FROM Players p
JOIN PlayerClubs pc ON p.player_id = pc.player_id
JOIN Clubs c ON pc.club_id = c.club_id
WHERE p.wage > (
    SELECT AVG(p2.wage)
    FROM Players p2
    JOIN PlayerClubs pc2 ON p2.player_id = pc2.player_id
    WHERE pc2.club_id = pc.club_id
);
-- The subquery is correlated because it refers to pc.club_id from the outer query.
-- For each player, the subquery calculates the average wage of all players in the same club (pc.club_id).
-- We filter the players where their wage is greater than the average wage of the players in their club.
-- This query helps identify players who are earning more than their peers in the same club by using a correlated subquery to 
--	calculate the average wage dynamically for each player’s club.

-- 4. TSQL10 ICA-Demo 4: Using Subqueries in the FROM Clause [INTERMEDIATE]
-- Scenario: We want to find all clubs along with the average player value in each club, but only 
--	include clubs where the average player value is greater than €10 million.
-- End user: 
-- SQL developer: 
-- Data Scientist: 
SELECT c.name AS club_name, 
      CASE -- for imporoved readability of the results
           WHEN avg_values.avg_value % 1000000 = 0
           THEN CAST(avg_values.avg_value / 1000000 AS VARCHAR(10)) + 'M'
           ELSE CAST(CAST(ROUND(avg_values.avg_value / 1000000.0, 1) AS DECIMAL(10,1)) AS VARCHAR(10)) + 'M'
      END AS avg_value
-- The main query selects the club_name from the Clubs table and the avg_value from the subquery result.
FROM Clubs c
-- We use a JOIN to combine the subquery’s result (avg_values) with the Clubs table based on club_id.
JOIN (
	-- This subquery calculates the average player value for each club.
	-- It selects the club_id from PlayerClubs and calculates the AVG(p.value) from the Players table.
    SELECT pc.club_id, AVG(p.value) AS avg_value
    FROM Players p
    JOIN PlayerClubs pc ON p.player_id = pc.player_id
    GROUP BY pc.club_id
	-- The result set is grouped by club_id to get the average value for each club.
) AS avg_values ON c.club_id = avg_values.club_id
WHERE avg_values.avg_value > 10000000;
-- The WHERE clause filters out clubs where the average player value is less than or equal to €10 million (10000000).
-- The subquery in the FROM clause generates a temporary result set (a derived table) that can be referenced in the main query.
--	We calculate the average player value per club in the subquery and then filter those results in the main query to show only the 
--	clubs with an average value above a certain threshold. This approach is useful when you need to compute aggregations 
--	(such as averages) and use them in a larger query.

-- 5. TSQL10 ICA-Demo 5: Combining Subqueries with Aggregate Functions [INTERMEDIATE]
-- Select the top 5 clubs with the highest average player value
-- (only considering players above the overall average value)
-- End user: 
-- SQL developer: 
-- Data Scientist: 
SELECT TOP 5
    c.name AS club_name,
    CASE 
        WHEN ROUND(avg_player_value / 1000000.0, 1) = ROUND(avg_player_value / 1000000.0, 0)
        THEN CAST(ROUND(avg_player_value / 1000000.0, 0) AS VARCHAR(10)) + 'M'
        ELSE CAST(ROUND(avg_player_value / 1000000.0, 1) AS VARCHAR(10)) + 'M'
    END AS avg_player_value
FROM (
    -- Subquery to calculate average player value for each club
    -- (only for players above overall average value)
    SELECT 
        pc.club_id,
        AVG(CAST(p.value AS FLOAT)) AS avg_player_value
    FROM Players p
    JOIN PlayerClubs pc ON p.player_id = pc.player_id
    -- Subquery to get the overall average player value
    WHERE p.value > (
        SELECT AVG(value)
        FROM Players
    )
    GROUP BY pc.club_id
) AS club_avgs
JOIN Clubs c ON c.club_id = club_avgs.club_id
ORDER BY avg_player_value DESC;
-- The innermost subquery calculates the overall average player value across all players.
-- The middle subquery selects players whose value is above this overall average, then calculates the average value for 
--	each club considering only these above-average players.
-- The main query joins this result with the Clubs table to get the club names.
-- We use a CASE statement to format the average value in millions, showing whole numbers when possible and one decimal place when necessary.
-- The results are ordered by average player value in descending order, and we select only the top 5 clubs.

-- 6. TSQL10 ICA-Demo 6: Using EXISTS and NOT EXISTS with Subqueries [ADVANCED]
-- End user: 
-- SQL developer: 
-- Data Scientist: 
SELECT c.name AS club_name, c.rating AS club_rating
FROM Clubs c
WHERE EXISTS (
    -- Subquery to check if the club has at least one player with long_shots > 80
    SELECT 1
    FROM Players p
    JOIN PlayerClubs pc ON p.player_id = pc.player_id
    JOIN PlayerAttributes pa ON p.player_id = pa.player_id
    WHERE pc.club_id = c.club_id
    AND pa.long_shots > 80
)
AND NOT EXISTS (
    -- Subquery to check if the club has any goalkeeper with gk_reflexes > 85
    SELECT 1
    FROM Players p
    JOIN PlayerClubs pc ON p.player_id = pc.player_id
    JOIN GoalkeeperAttributes ga ON p.player_id = ga.player_id
    WHERE pc.club_id = c.club_id
    AND ga.gk_reflexes > 85
)
ORDER BY c.rating DESC;
-- The query will return a list of clubs that meet both criteria:
--	They have at least one player good at long shots (long_shots > 80)
--	They don't have any exceptional goalkeepers in terms of reflexes (gk_reflexes <= 85)

-- 7. TSQL10 ICA-Demo 7: Optimizing Correlated Subqueries for Performance [ADVANCED]
-- Correlated subqueries can be performance-intensive because they are executed once for each row 
--	processed by the outer query. In some cases, we can improve performance by rewriting these queries 
--	using JOINs or by using derived tables.
-- Original Query with Correlated Subquery:
SELECT p.player_id, p.name, p.value
FROM Players p
WHERE p.value > (
    SELECT AVG(p2.value) * 2
    FROM Players p2
    JOIN PlayerClubs pc ON p2.player_id = pc.player_id
    WHERE pc.club_id = (
        SELECT pc2.club_id
        FROM PlayerClubs pc2
        WHERE pc2.player_id = p.player_id
    )
)
ORDER BY p.value DESC;
-- This query finds players whose value is more than twice the average value of players in their club. However, 
--	it uses a correlated subquery, which can be inefficient for large datasets.
-- Optimized Query:
WITH ClubAverages AS (
    SELECT pc.club_id, AVG(p.value) * 2 AS double_avg_value
    FROM Players p
    JOIN PlayerClubs pc ON p.player_id = pc.player_id
    GROUP BY pc.club_id
)
SELECT p.player_id, p.name, p.value
FROM Players p
JOIN PlayerClubs pc ON p.player_id = pc.player_id
JOIN ClubAverages ca ON pc.club_id = ca.club_id
WHERE p.value > ca.double_avg_value
ORDER BY p.value DESC;
-- 1. We use a Common Table Expression (CTE) named ClubAverages to pre-calculate the average value (doubled) 
--		for each club. This replaces the innermost correlated subquery.
-- 2. In the main query, we join the Players table with PlayerClubs and our CTE.
-- 3. We then filter the results based on the pre-calculated average values.
-- Benefits:
--Reduced complexity: The query is now more straightforward and easier to understand.
--Improved performance: By pre-calculating the club averages, we avoid recalculating for each player.
--Scalability: This approach scales better with larger datasets.
--Index utilization: The optimized query can better utilize indexes on the club_id and player_id columns.


-- 8. TSQL10 ICA-Demo 8: Rewriting Subqueries as JOINs for Efficiency [ADVANCED]
-- I have used the query from Demo 6 and re-wrote it using JOINs
SELECT DISTINCT 
    c.name AS club_name, 
    c.rating AS club_rating
FROM 
    Clubs c
JOIN 
    PlayerClubs pc ON c.club_id = pc.club_id
JOIN 
    Players p ON pc.player_id = p.player_id
LEFT JOIN 
    PlayerAttributes pa ON p.player_id = pa.player_id
LEFT JOIN 
    GoalkeeperAttributes ga ON p.player_id = ga.player_id
WHERE 
    -- Club must have at least one player with long_shots > 80
    pa.long_shots > 80
    -- Exclude clubs with any goalkeeper having gk_reflexes > 85
    AND c.club_id NOT IN (
        SELECT DISTINCT c2.club_id
        FROM Clubs c2
        JOIN PlayerClubs pc2 ON c2.club_id = pc2.club_id
        JOIN GoalkeeperAttributes ga2 ON pc2.player_id = ga2.player_id
        WHERE ga2.gk_reflexes > 85
    )
ORDER BY 
    c.rating DESC;


-- TSQL11 ICA-Demo: Using Table Expressions
-- 1. TSQL11 ICA-Demo 1: Creating and Using Views [BASIC]
-- Step 1: Creating the View
CREATE VIEW vw_PlayerSummary AS
SELECT 
    p.player_id,
    p.name AS player_name,
    pa.overall_rating,
    pa.potential,
    p.value AS player_value,
    c.name AS club_name,
    l.name AS league_name
FROM 
    Players p
JOIN PlayerClubs pc ON p.player_id = pc.player_id
JOIN Clubs c ON pc.club_id = c.club_id
JOIN Leagues l ON c.league_id = l.league_id
JOIN PlayerAttributes pa ON p.player_id = pa.player_id

-- Basic query to retrieve all data from the view:
SELECT * FROM vw_PlayerSummary;

-- Query to find the top 10 most valuable players:
SELECT TOP 10 * FROM vw_PlayerSummary
ORDER BY player_value DESC;

-- Query to find the average overall rating of players in each league:
SELECT 
    league_name, 
    AVG(overall_rating) AS avg_overall_rating
FROM vw_PlayerSummary
GROUP BY league_name
ORDER BY avg_overall_rating DESC;

-- Query to find players with high potential in a specific league:
SELECT 
    player_name, 
    club_name, 
    overall_rating, 
    potential
FROM vw_PlayerSummary
WHERE league_name = 'Premier League' AND potential > 85
ORDER BY potential DESC;
--Benefits of using views:
--	Simplification: Complex joins and conditions are encapsulated in the view, making queries simpler.
--	Security: Views can restrict access to certain columns or rows, enhancing data security.
--	Consistency: Views ensure that data is queried consistently across different applications or users.
--	Performance: In some cases, views can be indexed or materialized for better performance.
-- while views simplify querying, they don't store data themselves. Each time a view is queried, 
--	the underlying SELECT statement is executed. For frequently accessed, computation-heavy views, 
--	you might consider indexed views (also known as materialized views in some databases) for performance optimization.

-- 2. TSQL11 ICA-Demo 2: Writing Inline Table-Valued Functions (TVFs) [INTERMEDIATE]
CREATE FUNCTION dbo.GetPlayersByRatingAndPosition
(
	-- @MinRating: The minimum rating of players to be included in the result.
	-- @Position: The specific position to filter players by, such as "Striker", "Midfielder", etc.
    @MinRating INT,
    @Position NVARCHAR(50)
)
RETURNS TABLE
AS
RETURN
(
    SELECT 
        p.player_id,
        p.name,
        p.full_name,
        pa.overall_rating,
        pa.potential,
        p.value,
        p.wage,
        p.positions
    FROM 
        Players p
    INNER JOIN 
        PlayerAttributes pa ON p.player_id = pa.player_id
    WHERE 
        pa.overall_rating >= @MinRating
        AND p.positions LIKE '%' + @Position + '%'
);
SELECT * 
FROM dbo.GetPlayersByRatingAndPosition(80, 'ST');

-- include the club name and league name
CREATE FUNCTION dbo.GetPlayersWithClubAndLeague
(
    @MinRating INT,
    @Position NVARCHAR(50)
)
RETURNS TABLE
AS
RETURN
(
    SELECT 
        p.player_id,
        p.name,
        p.full_name,
        pa.overall_rating,
        pa.potential,
        p.value,
        p.wage,
        p.positions,
        c.name AS club_name,
        l.name AS league_name
    FROM 
        Players p
    INNER JOIN 
        PlayerAttributes pa ON p.player_id = pa.player_id
    INNER JOIN
        PlayerClubs pc ON p.player_id = pc.player_id
    INNER JOIN
        Clubs c ON pc.club_id = c.club_id
    INNER JOIN
        Leagues l ON c.league_id = l.league_id
    WHERE 
        pa.overall_rating >= @MinRating
        AND p.positions LIKE '%' + @Position + '%'
);
SELECT * 
FROM dbo.GetPlayersWithClubAndLeague(70, 'CM');

-- 3. TSQL11 ICA-Demo 3: Using Derived Tables in Queries  [INTERMEDIATE]
-- Task: Retrieve players with an overall rating of 85 or higher, including their club names, but first calculate 
--	the player's total market value (value + wage) using a derived table.
SELECT 
    dt.player_id,
    dt.name,
    dt.club_name,
    dt.total_market_value,
    dt.overall_rating
FROM
(
    SELECT 
        p.player_id,
        p.name,
        pa.overall_rating,
        (p.value + p.wage) AS total_market_value,
        c.name AS club_name
    FROM 
        Players p
    INNER JOIN 
        PlayerAttributes pa ON p.player_id = pa.player_id
    INNER JOIN 
        PlayerClubs pc ON p.player_id = pc.player_id
    INNER JOIN 
        Clubs c ON pc.club_id = c.club_id
) AS dt
WHERE 
    dt.overall_rating >= 85
ORDER BY 
    dt.total_market_value DESC;
-- Join the necessary tables: We'll need to join the Players, PlayerAttributes, and Clubs tables to get 
--	the player's name, overall rating, and club name.
-- Calculate total value: We'll calculate the player's total market value as the sum of value and wage and use this in the derived table.
-- Filter based on overall rating: The outer query will filter the results to only include players with an overall rating of 85 or higher.

-- 4. TSQL11 ICA-Demo 4: Implementing Common Table Expressions (CTEs) [INTERMEDIATE]
-- Retrieve the top 10 players with the highest overall ratings.
-- Include their club names and player details.
-- Use the CTE to simplify the query and reference the result multiple times if needed.
WITH TopPlayers AS
(
    SELECT 
        p.player_id,
        p.name,
        pa.overall_rating,
        (p.value + p.wage) AS total_market_value,
        c.name AS club_name
    FROM 
        Players p
    INNER JOIN 
        PlayerAttributes pa ON p.player_id = pa.player_id
    INNER JOIN 
        PlayerClubs pc ON p.player_id = pc.player_id
    INNER JOIN 
        Clubs c ON pc.club_id = c.club_id
)
-- Main query using the CTE
SELECT TOP 10 
    player_id,
    name,
    overall_rating,
    total_market_value,
    club_name
FROM 
    TopPlayers
ORDER BY 
    overall_rating DESC;

-- TSQL11 ICA Demo 5: Recursive CTEs for Hierarchical Data [ADVANCED]
WITH LeagueClubHierarchy AS (
    -- Anchor Member: Start with all leagues (top-level entities)
    SELECT 
        l.league_id AS id,
        l.name AS name,
        NULL AS parent_id,
        CAST('League' AS VARCHAR(10)) AS entity_type, -- Explicit cast
        0 AS level
    FROM 
        Leagues l
    UNION ALL
    -- Recursive Member: Add clubs under each league
    SELECT 
        c.club_id AS id,
        c.name AS name,
        c.league_id AS parent_id,
        CAST('Club' AS VARCHAR(10)) AS entity_type, -- Matching cast
        h.level + 1 AS level
    FROM 
        Clubs c
    JOIN 
        LeagueClubHierarchy h ON c.league_id = h.id
    WHERE 
        h.entity_type = 'League'
)
-- Final Query: Retrieve the entire hierarchy
SELECT 
    id,
    name,
    parent_id,
    entity_type,
    level
FROM 
    LeagueClubHierarchy
ORDER BY 
    level, name;

-- TSQL11 ICA Demo 6: Combining multiple CTE's
-- Hypothetical context:
--- Identify players who have an overall rating above 85 and play in clubs with a rating above 4.
--- Retrieve the players’ names, positions, clubs, and league names.
--- Additionally, calculate the average wage of players per league.
-- Combining multiple CTEs in a single query
WITH HighRatedPlayers AS (
    -- CTE to fetch players with an overall rating above 85
    SELECT 
        p.player_id,
        p.name AS player_name,
        pc.position,
        pc.club_id,
        pa.overall_rating
    FROM 
        Players p
    JOIN 
        PlayerAttributes pa ON p.player_id = pa.player_id
    JOIN 
        PlayerClubs pc ON p.player_id = pc.player_id
    WHERE 
        pa.overall_rating > 85
),
HighRatedClubs AS (
    -- CTE to fetch clubs with a rating above 4
    SELECT 
        c.club_id,
        c.name AS club_name,
        c.rating AS club_rating,
        c.league_id
    FROM 
        Clubs c
    WHERE 
        c.rating > 4
),
AverageWageByLeague AS (
    -- CTE to calculate the average wage of players per league
    SELECT 
        l.league_id,
        l.name AS league_name,
        AVG(p.wage) AS avg_wage
    FROM 
        Players p
    JOIN 
        PlayerClubs pc ON p.player_id = pc.player_id
    JOIN 
        Clubs c ON pc.club_id = c.club_id
    JOIN 
        Leagues l ON c.league_id = l.league_id
    GROUP BY 
        l.league_id, l.name
)
-- Final query combining all CTEs
SELECT 
    hrp.player_name,
    hrp.position,
    hrc.club_name,
    awbl.league_name,
    awbl.avg_wage
FROM 
    HighRatedPlayers hrp
JOIN 
    HighRatedClubs hrc ON hrp.club_id = hrc.club_id
JOIN 
    Leagues l ON hrc.league_id = l.league_id
JOIN 
    AverageWageByLeague awbl ON l.league_id = awbl.league_id;


-- TSQL12 ICA-Demo: Using Set Operators
-- 1. TSQL12 ICA-Demo 1: Using UNION to Combine Result Sets [BASIC]
-- First query: players with an overall rating of 85 or higher
SELECT 
    p.player_id,
    p.name,
    pa.overall_rating,
    p.wage
FROM 
    Players p
INNER JOIN 
    PlayerAttributes pa ON p.player_id = pa.player_id
WHERE 
    pa.overall_rating >= 85
UNION
-- Second query: players with a wage of more than 50,000
SELECT 
    p.player_id,
    p.name,
    pa.overall_rating,
    p.wage
FROM 
    Players p
INNER JOIN 
    PlayerAttributes pa ON p.player_id = pa.player_id
WHERE 
    p.wage > 50000
-- Optionally, you can order the final result set
ORDER BY overall_rating DESC, wage DESC;

-- 2. TSQL12 ICA-Demo 2: Using UNION ALL to Combine Result Sets without Removing Duplicates [BASIC]
-- Key Points about UNION ALL:
--	The number of columns and the data types of the columns in each SELECT statement must still match, just like with UNION.
--	Unlike UNION, UNION ALL includes all rows from each query, including duplicates.
-- First query: players with an overall rating of 85 or higher
SELECT 
    p.player_id,
    p.name,
    pa.overall_rating,
    p.wage
FROM 
    Players p
INNER JOIN 
    PlayerAttributes pa ON p.player_id = pa.player_id
WHERE 
    pa.overall_rating >= 85

UNION ALL

-- Second query: players with a wage of more than 50,000
SELECT 
    p.player_id,
    p.name,
    pa.overall_rating,
    p.wage
FROM 
    Players p
INNER JOIN 
    PlayerAttributes pa ON p.player_id = pa.player_id
WHERE 
    p.wage > 50000

-- Optionally, you can order the final result set
ORDER BY 
    overall_rating DESC, wage DESC;
-- First Query: Retrieves players with an overall_rating of 85 or higher.
-- Second Query: Retrieves players with a wage of more than 50,000.
-- UNION ALL: Combines the results of these two queries, including any 
--	duplicates (i.e., if a player meets both conditions, they’ll appear twice in the result set).
-- ORDER BY: Orders the final result by overall_rating and wage in descending order.
-- Benefits of Using UNION ALL:
-- Keeps Duplicates: If you want to retain duplicates (for example, if a player matches both conditions), 
--	UNION ALL ensures that no rows are omitted.
-- Performance: UNION ALL can be more efficient than UNION, since it doesn’t have to remove duplicates.
-- Performance Consideration: Since UNION ALL doesn’t require the database to check for and remove duplicates, 
--	it can be more efficient in certain situations compared to UNION.

-- 3. TSQL12 ICA-Demo 3: Using INTERSECT to Find Common Rows Between Queries [INTERMEDIATE]
-- Let's say we want to find players who meet both of the following conditions:
-- Have an overall rating of 85 or higher.
-- Have a wage of more than 50,000.
-- First query: players with an overall rating of 85 or higher
SELECT 
    p.player_id,
    p.name,
    pa.overall_rating,
    p.wage
FROM 
    Players p
INNER JOIN 
    PlayerAttributes pa ON p.player_id = pa.player_id
WHERE 
    pa.overall_rating >= 85
INTERSECT
-- Second query: players with a wage of more than 50,000
SELECT 
    p.player_id,
    p.name,
    pa.overall_rating,
    p.wage
FROM 
    Players p
INNER JOIN 
    PlayerAttributes pa ON p.player_id = pa.player_id
WHERE 
    p.wage > 50000

-- Optionally, order the result set
ORDER BY 
    overall_rating DESC, wage DESC;
--First Query: Retrieves players with an overall_rating of 85 or higher.
--Second Query: Retrieves players with a wage of more than 50,000.
--INTERSECT: Combines these queries and returns only the rows (players) that are common between the two queries, 
--	meaning the players who meet both conditions.

-- TSQL12 ICA-Demo 4: Using EXCEPT to Find Differences Between Queries [INTERMEDIATE]
-- The EXCEPT operator in SQL is used to return the rows from the first query that are not present in the second query. In other words, 
--	it subtracts the result set of the second query from the first query.
-- First query: players with an overall rating of 85 or higher
SELECT 
    p.player_id,
    p.name,
    pa.overall_rating,
    p.wage
FROM 
    Players p
INNER JOIN 
    PlayerAttributes pa ON p.player_id = pa.player_id
WHERE 
    pa.overall_rating >= 85
EXCEPT
-- Second query: players with a wage of more than 50,000
SELECT 
    p.player_id,
    p.name,
    pa.overall_rating,
    p.wage
FROM 
    Players p
INNER JOIN 
    PlayerAttributes pa ON p.player_id = pa.player_id
WHERE 
    p.wage > 50000
-- Optionally, order the result set
ORDER BY 
    overall_rating DESC, wage ASC;
-- First Query: Retrieves all players who have an overall_rating of 85 or higher.
-- Second Query: Retrieves players who have a wage of more than 50,000.
-- EXCEPT: Returns only the players from the first query who do not appear in the second query, 
--	i.e., players with a high rating but lower wage (≤ 50,000).

-- TSQL12 ICA-Demo 5: Handling NULL Values in Set Operations [INTERMEDIATE]
-- One dataset contains players with their overall_rating, wage and release_clause.
-- Another dataset contains similar player information but may have some NULL values in the release_clause column.
-- First query: players with overall_rating >= 85
SELECT 
    p.player_id,
    p.name,
    pa.overall_rating,
    p.value as market_value,
	p.release_clause
FROM 
    Players p
INNER JOIN 
    PlayerAttributes pa ON p.player_id = pa.player_id
WHERE 
    pa.overall_rating >= 85
UNION ALL
-- Second query: players with release_clause > 50,000 (some NULL values in wage)
SELECT 
    p.player_id,
    p.name,
    pa.overall_rating,
    p.value,
	p.release_clause
FROM 
    Players p
INNER JOIN 
    PlayerAttributes pa ON p.player_id = pa.player_id
WHERE 
    p.wage > 50000 OR p.wage IS NULL
-- Optional: Order the result set
ORDER BY 
    overall_rating DESC;
-- UNION ALL will keep rows with NULL values and will not remove any duplicates. Players with NULL wages will appear in the result set.
-- UNION (if used instead) will remove any duplicates, treating rows with NULL values as equal.

SELECT *
FROM Players
WHERE [name] IS NULL
      OR [full_name] IS NULL
      OR [value] IS NULL
      OR [wage] IS NULL
      OR [release_clause] IS NULL 
      OR [description] IS NULL
      OR [image] IS NULL 
      OR [height_cm] IS NULL
      OR [weight_kg] IS NULL
      OR [dob] IS NULL
      OR [positions] IS NULL 
      OR [preferred_foot] IS NULL
      OR [international_reputation] IS NULL
      OR [real_face] IS NULL
-- TSQL12 ICA Demo 6 [ADVANCED]: Combining Multiple Set Operators in a Single Query
--- Players who are either goalkeepers or have a speciality listed.
--- Players who play for clubs in leagues with the name starting with 'Premier'.
--- Combine these results to create a union of the two datasets, but exclude any players who have a market value of less 
---	than 10,000,000 using a set difference.
-- Combine multiple set operators in a single query
SELECT 
    p.player_id,
    p.name AS player_name,
    'Goalkeeper/Speciality' AS source
FROM 
    Players p
LEFT JOIN 
    GoalkeeperAttributes ga ON p.player_id = ga.player_id
LEFT JOIN 
    PlayerSpecialities ps ON p.player_id = ps.player_id
WHERE 
    ga.player_id IS NOT NULL OR ps.speciality IS NOT NULL

UNION -- Combine with players in Premier leagues

SELECT 
    p.player_id,
    p.name AS player_name,
    'Premier League Club' AS source
FROM 
    Players p
JOIN 
    PlayerClubs pc ON p.player_id = pc.player_id
JOIN 
    Clubs c ON pc.club_id = c.club_id
JOIN 
    Leagues l ON c.league_id = l.league_id
WHERE 
    l.name LIKE 'Premier%'

EXCEPT -- Remove players with value < 10,000,000

SELECT 
    p.player_id,
    p.name AS player_name,
    'Excluded' AS source
FROM 
    Players p
WHERE 
    p.value < 10000000;

-- TSQL12 ICA Demo 7: Optimizing Queries with Set Operators for Large Datasets [ADVANCED]
--- Scenario
--- Players who either:
--- Play for clubs with a rating above 4 or
--- Have a speciality listed (PlayerSpecialities table).
--- Remove duplicates from the combined result set.
--- Exclude players whose wage exceeds £200,000.
-- Optimized query for large datasets
WITH HighRatedClubPlayers AS (
    -- Fetch players in clubs with a rating above 4
    SELECT 
        p.player_id,
        p.name AS player_name,
        c.name AS club_name
    FROM 
        Players p
    JOIN 
        PlayerClubs pc ON p.player_id = pc.player_id
    JOIN 
        Clubs c ON pc.club_id = c.club_id
    WHERE 
        c.rating > 4
),
SpecialityPlayers AS (
    -- Fetch players who have a speciality
    SELECT 
        p.player_id,
        p.name AS player_name,
        'Speciality' AS source
    FROM 
        Players p
    JOIN 
        PlayerSpecialities ps ON p.player_id = ps.player_id
),
CombinedPlayers AS (
    -- Combine high-rated club players and speciality players
    SELECT 
        player_id,
        player_name
    FROM 
        HighRatedClubPlayers

    UNION -- Remove duplicates
    SELECT 
        player_id,
        player_name
    FROM 
        SpecialityPlayers
)
-- Exclude players with a wage exceeding £200,000
SELECT 
    cp.player_id,
    cp.player_name
FROM 
    CombinedPlayers cp
JOIN 
    Players p ON cp.player_id = p.player_id
WHERE 
    p.wage <= 200000;


-- TSQL13 ICA-Demo: Using Window Ranking, Offset, and Aggregate Functions
-- 1. TSQL13 ICA-Demo 1: Using ROW_NUMBER for Row-Based Ranking [BASIC]
-- Let’s say we have a Players table with information on player names, their clubs, and their overall ratings. 
--	We want to rank the players within each club based on their overall rating.
SELECT 
    p.player_id,
    p.name,
    c.name AS club_name,
    pa.overall_rating,
    ROW_NUMBER() OVER (PARTITION BY c.name ORDER BY pa.overall_rating DESC) AS rank
FROM 
    Players p
INNER JOIN 
    PlayerAttributes pa ON p.player_id = pa.player_id
INNER JOIN 
    PlayerClubs pc ON p.player_id = pc.player_id
INNER JOIN 
    Clubs c ON pc.club_id = c.club_id
ORDER BY 
    club_name, rank;
-- ROW_NUMBER() OVER (PARTITION BY c.name ORDER BY pa.overall_rating DESC): This partitions the data 
--	by club_name and assigns a row number to each player, ordering them by their overall_rating in descending order (highest rating first).
-- The result will display a ranking of players within each club based on their rating.
-- ORDER BY club_name, rank: Orders the final result by club name and rank to display players ranked within each club.

-- 2. TSQL13 ICA-Demo 2: Using RANK and DENSE_RANK for Ranking Rows [BASIC]
--	RANK(): Assigns the same rank to tied rows but leaves gaps in the ranking for ties.
--	DENSE_RANK(): Also assigns the same rank to tied rows but does not leave gaps in the rankings.
-- Let’s say we have a table Players with information about player names, their clubs, and their overall ratings. 
--	We want to rank players within each club based on their overall_rating. In cases where players have the same rating, 
--	we’ll compare how RANK() and DENSE_RANK() behave.
SELECT 
    p.player_id,
    p.name,
    c.name AS club_name,
    pa.overall_rating,
    RANK() OVER (PARTITION BY c.name ORDER BY pa.overall_rating DESC) AS rank,
    DENSE_RANK() OVER (PARTITION BY c.name ORDER BY pa.overall_rating DESC) AS dense_rank
FROM 
    Players p
INNER JOIN 
    PlayerAttributes pa ON p.player_id = pa.player_id
INNER JOIN 
    PlayerClubs pc ON p.player_id = pc.player_id
INNER JOIN 
    Clubs c ON pc.club_id = c.club_id
ORDER BY 
    club_name, rank;
--RANK() OVER (PARTITION BY c.name ORDER BY pa.overall_rating DESC): This ranks players within each club by their overall_rating 
--	in descending order. Tied rows get the same rank, but the next rank will skip by the number of tied rows.
--DENSE_RANK() OVER (PARTITION BY c.name ORDER BY pa.overall_rating DESC): This also ranks players by overall_rating, 
--	but it assigns consecutive ranks even if there are ties, without skipping any numbers.
--ORDER BY club_name, rank: Orders the results by club and rank to see how the rankings work within each club.

-- 3. TSQL13 ICA-Demo 3: Using NTILE to Distribute Rows Across Buckets [INTERMEDIATE]
-- The NTILE() function in SQL is a window function that divides rows of a result set into a specified number
--	of approximately equal-sized "buckets" or "tiles." It is useful when you want to distribute rows into groups, 
--	such as for calculating percentiles or quartiles.
-- Suppose we have a Players table with player names, their overall ratings, and their clubs. We want to group the players into quartiles 
--	(4 buckets) based on their overall ratings within each club, to analyze their performance distribution.
SELECT 
    p.player_id,
    p.name,
    c.name AS club_name,
    pa.overall_rating,
    NTILE(5) OVER (PARTITION BY c.name ORDER BY pa.overall_rating DESC) AS quartile
FROM 
    Players p
INNER JOIN 
    PlayerAttributes pa ON p.player_id = pa.player_id
INNER JOIN 
    PlayerClubs pc ON p.player_id = pc.player_id
INNER JOIN 
    Clubs c ON pc.club_id = c.club_id
ORDER BY 
    club_name, quartile;
--NTILE(4): Divides the players into 4 tiles (quartiles), ordered by their overall_rating in descending order. 
--	The higher-rated players will fall into the first tile, and the lower-rated ones into the last tile.
--PARTITION BY c.name: This ensures that the NTILE() function creates separate quartiles for each club.
--ORDER BY pa.overall_rating DESC: Orders the players by their overall rating in descending order, 
--	so the best players are assigned to the first quartile (tile).

-- slightly more complicated version with stars instead of numbers for better readability 
SELECT 
    p.player_id,
    p.name,
    c.name AS club_name,
    pa.overall_rating,
    CASE 
    WHEN NTILE(5) OVER (PARTITION BY c.name ORDER BY pa.overall_rating DESC) = 1 THEN NCHAR(9733) + NCHAR(9733) + NCHAR(9733) + NCHAR(9733) + NCHAR(9733) -- '★★★★★'
    WHEN NTILE(5) OVER (PARTITION BY c.name ORDER BY pa.overall_rating DESC) = 2 THEN NCHAR(9733) + NCHAR(9733) + NCHAR(9733) + NCHAR(9733) -- '★★★★'
    WHEN NTILE(5) OVER (PARTITION BY c.name ORDER BY pa.overall_rating DESC) = 3 THEN NCHAR(9733) + NCHAR(9733) + NCHAR(9733) -- '★★★'
    WHEN NTILE(5) OVER (PARTITION BY c.name ORDER BY pa.overall_rating DESC) = 4 THEN NCHAR(9733) + NCHAR(9733) -- '★★'
    WHEN NTILE(5) OVER (PARTITION BY c.name ORDER BY pa.overall_rating DESC) = 5 THEN NCHAR(9733) -- '★'
END AS star_rating
FROM Players p
INNER JOIN 
    PlayerAttributes pa ON p.player_id = pa.player_id
INNER JOIN 
    PlayerClubs pc ON p.player_id = pc.player_id
INNER JOIN 
    Clubs c ON pc.club_id = c.club_id
ORDER BY club_name;

-- 4. TSQL13 ICA-Demo 4: Applying OFFSET and FETCH for Pagination [INTERMEDIATE]
-- The OFFSET and FETCH clauses work together to skip a specific number of rows and then return a set number of rows after that.
-- Let’s say you want to paginate over players, returning 5 rows at a time, and you want to skip the first 10 rows.
SELECT 
    p.player_id,
    p.name,
    pa.overall_rating,
    c.name AS club_name
FROM 
    Players p
INNER JOIN 
    PlayerAttributes pa ON p.player_id = pa.player_id
INNER JOIN 
    PlayerClubs pc ON p.player_id = pc.player_id
INNER JOIN 
    Clubs c ON pc.club_id = c.club_id
ORDER BY 
    pa.overall_rating DESC
OFFSET 10 ROWS -- Skip the first 10 rows
FETCH NEXT 5 ROWS ONLY; -- Fetch the next 5 rows
-- The query will skip the first 10 rows (OFFSET 10 ROWS) and then fetch the next 5 rows (FETCH NEXT 5 ROWS ONLY).
-- The ORDER BY clause is required when using OFFSET and FETCH. In this example, the players are ordered by their 
--	overall_rating in descending order.

-- To paginate through players, say page 2 where each page shows 5 players:
--	PAGE 3
DECLARE @PageNumber INT = 3;
DECLARE @RowsPerPage INT = 10;

SELECT 
    p.player_id,
    p.name,
    pa.overall_rating,
    c.name AS club_name
FROM 
    Players p
INNER JOIN 
    PlayerAttributes pa ON p.player_id = pa.player_id
INNER JOIN 
    PlayerClubs pc ON p.player_id = pc.player_id
INNER JOIN 
    Clubs c ON pc.club_id = c.club_id
ORDER BY 
    pa.overall_rating DESC
OFFSET (@PageNumber - 1) * @RowsPerPage ROWS
FETCH NEXT @RowsPerPage ROWS ONLY;
--Here, the query calculates how many rows to skip using (@PageNumber - 1) * @RowsPerPage and fetches the next @RowsPerPage rows.
--This is useful for paginating through a large dataset efficiently.

-- 5. TSQL13 ICA-Demo 5: Using LAG and LEAD for Accessing Prior and Subsequent Rows [INTERMEDIATE]
-- LAG and LEAD are window functions in SQL that allow you to access data from previous or subsequent rows without needing to use self-joins. They are very useful when you want to compare data between rows within a specific result set.
--	LAG: Returns data from the previous row in the result set.
--	LEAD: Returns data from the next row in the result set.
SELECT 
    p.player_id,
    p.name,
    pa.overall_rating,
    LAG(pa.overall_rating, 1, 0) OVER (ORDER BY pa.overall_rating DESC) AS prev_rating,
    LEAD(pa.overall_rating, 1, 0) OVER (ORDER BY pa.overall_rating DESC) AS next_rating
FROM 
    Players p
INNER JOIN 
    PlayerAttributes pa ON p.player_id = pa.player_id
ORDER BY 
    pa.overall_rating DESC;
-- LAG(pa.overall_rating, 1, 0): This returns the previous player's overall rating. If there is no previous row, it returns 0.
-- LEAD(pa.overall_rating, 1, 0): This returns the next player's overall rating. If there is no next row, it returns 0.
-- The query orders players by their overall_rating in descending order and compares each player's rating with the one immediately before and after.
--  LAG and LEAD are useful for comparing values across rows.
--  They can be used with multiple columns, including dates, salaries, or ratings.
--  You can control the number of rows to look ahead or behind using the offset.

-- TSQL14 ICA-Demo: Pivoting and Grouping Sets
-- 1. TSQL14 ICA-Demo 1: Using PIVOT to Transform Data [BASIC]
-- In SQL Server, the PIVOT operator allows you to rotate rows into columns, which can be useful for reporting and summarizing data. 
--	The PIVOT operator is especially useful when you want to transform aggregated data.
WITH ClubRatings AS (
    SELECT 
        l.name AS league_name,
        CASE 
			WHEN c.rating BETWEEN 1 AND 60 THEN '> 61'
            WHEN c.rating BETWEEN 61 AND 70 THEN '61-70'
            WHEN c.rating BETWEEN 71 AND 80 THEN '71-80'
            WHEN c.rating BETWEEN 81 AND 90 THEN '81-90'
            ELSE '91-100'
        END AS rating_range
    FROM Leagues l
    JOIN Clubs c ON l.league_id = c.league_id
)
SELECT league_name, 
       ISNULL([91-100], 0) AS [91-100],
       ISNULL([81-90], 0) AS [81-90],
       ISNULL([71-80], 0) AS [71-80],
       ISNULL([61-70], 0) AS [61-70],
	   ISNULL([> 61], 0) AS [> 61]
FROM ClubRatings
PIVOT (
    COUNT(rating_range)
    FOR rating_range IN ([91-100], [81-90], [71-80], [61-70], [> 61])
) AS PivotTable
ORDER BY [91-100] DESC, [81-90] DESC, [71-80] DESC, [61-70] DESC, [> 61] ;

-- 2. TSQL14 ICA-Demo 2: Using UNPIVOT to Reverse Pivoted Data [BASIC]
SELECT 
    player_id,
    attribute,
    value
FROM 
    PlayerAttributes
UNPIVOT
(
    value FOR attribute IN (overall_rating, potential, crossing, finishing, heading_accuracy, short_passing, volleys, dribbling)
) AS UnpivotedAttributes;
-- Player ID: We keep the player_id as it is.
-- Attribute: The UNPIVOT statement converts column names (e.g., overall_rating, potential, etc.) into values under a new column attribute.
-- Value: The actual values of each attribute will be presented in a new column called value.

-- 3. TSQL14 ICA-Demo 3: Aggregating Data with GROUPING SETS [INTERMEDIATE]
-- Imagine you're managing a sports analytics platform, and you want to report on player performance. 
--	You need to provide insights for both club-level and league-level performance, while also including an overall 
--	summary for all players. Using GROUPING SETS, you can produce this multi-level aggregation in one go.
SELECT 
    c.name AS club_name,
    l.name AS league_name,
    SUM(p.value) AS total_value
FROM 
    Players p
INNER JOIN 
    PlayerClubs pc ON p.player_id = pc.player_id
INNER JOIN 
    Clubs c ON pc.club_id = c.club_id
INNER JOIN 
    Leagues l ON c.league_id = l.league_id
GROUP BY 
    GROUPING SETS (
        (c.name),        -- Group by club
        (l.name),        -- Group by league
        ()               -- Grand total (no grouping)
    )
ORDER BY 
    club_name, league_name;
-- Imagine you're creating a dashboard for a football director. He wants to know:
--	How much each club has invested in their players.
--	How much each league has invested overall.
--	The total investment in player value across all clubs in the system.

-- TSQL14 ICA-Demo 3: Aggregating Data with GROUPING SETS [INTERMEDIATE]
-- In the football database, you want to generate a report showing:
--	Total player market value for each club.
--	Total player market value for each league.
--	The grand total market value for all players.
--	This is useful for both club management and league organizers, as it shows both individual club contributions and overall league value.
SELECT 
    COALESCE(c.name, 'All Clubs') AS club_name,
    COALESCE(l.name, 'All Leagues') AS league_name,
    SUM(p.value) AS total_value
FROM 
    Players p
INNER JOIN 
    PlayerClubs pc ON p.player_id = pc.player_id
INNER JOIN 
    Clubs c ON pc.club_id = c.club_id
INNER JOIN 
    Leagues l ON c.league_id = l.league_id
GROUP BY 
    GROUPING SETS (
        (c.name),             -- Group by club
        (l.name),             -- Group by league
        ()                    -- Grand total
    )
ORDER BY 
    club_name, league_name;
-- Club Managers: The report helps clubs understand their squad's total market value and compare it to other clubs in the same league.
-- League Organizers: League-level totals can help assess the financial strength of different leagues, possibly influencing sponsorships, TV rights, or other financial decisions.
 --Grand Total: The grand total provides insights for football organizations like FIFA or UEFA when assessing global player value distribution.

-- TSQL14 ICA-Demo 5: Handling NULLs in PIVOT and GROUPING Queries [INTERMEDIATE]
-- When performing aggregations or transformations with PIVOT and GROUPING SETS, handling NULL values is crucial for obtaining 
--	meaningful insights. In PIVOT queries, NULL values can indicate missing data or absent categories, and these need to be 
--	replaced with default values (like 0 or 'N/A') for clarity. Similarly, in GROUPING SETS, NULL values can represent grand 
--	totals or missing groups. Properly managing these NULL values ensures that the query results are complete and easy to interpret.
-- In this use case, you want to analyze players' release_clause values (which are sometimes missing) across different 
--	positions (Forward, Midfielder, Defender, Goalkeeper) and clubs. We will use GROUPING SETS to get aggregated statistics at both 
--	the club level and overall. Additionally, we will use PIVOT to display the number of players in each position. For positions where 
--	the release_clause is missing (NULL), we will handle it by replacing it with a default value like 'Not Available.'
-- Using GROUPING SETS to aggregate by club and position while handling NULLs
SELECT 
    ISNULL(c.name, 'All Clubs') AS club_name,
    ISNULL(pc.position, 'All Positions') AS position,
    COUNT(p.player_id) AS player_count,
    ISNULL(SUM(CASE 
                WHEN p.release_clause IS NULL THEN 0 
                ELSE p.release_clause 
            END), 0) AS total_release_clause,
    ISNULL(AVG(CASE 
                WHEN p.release_clause IS NULL THEN 0 
                ELSE p.release_clause 
            END), 0) AS avg_release_clause
FROM 
    Players p
INNER JOIN 
    PlayerClubs pc ON p.player_id = pc.player_id
INNER JOIN 
    Clubs c ON pc.club_id = c.club_id
GROUP BY 
    GROUPING SETS ((c.name, pc.position), (c.name), ())
ORDER BY 
    club_name, position;

-- Using PIVOT to display number of players by position group across clubs, handling NULLs
SELECT 
    club_name,
    ISNULL([Forward], 0) AS Forward,
    ISNULL([Midfield], 0) AS Midfield,
    ISNULL([Defense], 0) AS Defense,
    ISNULL([Goalkeeper], 0) AS Goalkeeper
FROM 
    (
        SELECT 
            c.name AS club_name,
            CASE
                WHEN p.positions IN ('ST', 'CF', 'LW', 'RW') THEN 'Forward'
                WHEN p.positions IN ('CM', 'LCM', 'RCM', 'CAM', 'LAM', 'RAM', 'CDM', 'LM', 'RM') THEN 'Midfield'
                WHEN p.positions IN ('CB', 'LCB', 'RCB', 'LB', 'RB', 'LWB', 'RWB') THEN 'Defense'
                WHEN p.positions = 'GK' THEN 'Goalkeeper'
                ELSE 'Unknown'
            END AS position_group,
            p.release_clause
        FROM 
            Players p
        INNER JOIN 
            PlayerClubs pc ON p.player_id = pc.player_id
        INNER JOIN 
            Clubs c ON pc.club_id = c.club_id
    ) AS SourceTable
PIVOT 
    (
        COUNT(release_clause) 
        FOR position_group IN ([Forward], [Midfield], [Defense], [Goalkeeper])
    ) AS PivotTable
ORDER BY 
    club_name;
-- The CASE statement categorizes player positions into four groups: Forward, Midfield, Defense, and Goalkeeper, as per the mappings. 
--	This allows us to group data not just by raw position but by broader position categories.
-- We still handle NULL values using ISNULL, replacing them with appropriate labels or default values like 0.
-- The GROUPING SETS logic remains the same, providing aggregations at both club and overall levels, but now using the broader position categories.

-- test query
SELECT p.name, p.positions, pc.position
FROM Players p JOIN PlayerClubs pc ON p.player_id = pc.player_id 
WHERE p.name = 'Jamal Musiala'

--FINAL-- TSQL14 ICA-Demo 5: Handling NULLs in PIVOT and GROUPING Queries [INTERMEDIATE]
-- This query helps La Liga football clubs analyze the distribution of players across different positions (Forward, 
--	Midfield, Defense, Goalkeeper). Club managers or analysts can use it to assess squad balance and plan strategies, transfers, 
--	or team development.
SELECT 
    club_name,
    ISNULL([Forward], 0) AS Forward,
    ISNULL([Midfield], 0) AS Midfield,
    ISNULL([Defense], 0) AS Defense,
    ISNULL([Goalkeeper], 0) AS Goalkeeper
FROM 
    (
        SELECT 
            c.name AS club_name,
            CASE
                WHEN p.positions IN ('ST', 'CF', 'LW', 'RW') THEN 'Forward'
                WHEN p.positions IN ('CM', 'LCM', 'RCM', 'CAM', 'LAM', 'RAM', 'CDM', 'LM', 'RM') THEN 'Midfield'
                WHEN p.positions IN ('CB', 'LCB', 'RCB', 'LB', 'RB', 'LWB', 'RWB') THEN 'Defense'
                WHEN p.positions = 'GK' THEN 'Goalkeeper'
                ELSE 'Unknown'
            END AS position_group,
            p.player_id -- Count based on player_id, which is always unique and non-NULL
        FROM 
            Players p
        INNER JOIN 
            PlayerClubs pc ON p.player_id = pc.player_id
        INNER JOIN 
            Clubs c ON pc.club_id = c.club_id
        INNER JOIN
            Leagues l ON c.league_id = l.league_id
        WHERE
            l.name = 'La Liga'
    ) AS SourceTable
PIVOT 
    (
        COUNT(player_id) -- Counting player_id to include all players
        FOR position_group IN ([Forward], [Midfield], [Defense], [Goalkeeper])
    ) AS PivotTable
ORDER BY 
    club_name;
-- The query retrieves all La Liga clubs and counts the number of players in each position group (Forward, Midfield, Defense, Goalkeeper) using the player_id for accurate counting.
-- The PIVOT function transforms the result so each club shows the number of players per position group in separate columns.
-- ISNULL ensures that if a club has no players in a group (e.g., no goalkeepers), a 0 is displayed instead of NULL.

-- TSQL15 ICA-Demo: Executing Stored Procedures
-- 1. TSQL15 ICA-Demo 1: Creating and Executing Simple Stored Procedures [BASIC]
-- Creating a stored procedure to retrieve players of a specific club
CREATE PROCEDURE GetClubPlayers
    @ClubName NVARCHAR(100) -- Input parameter for the club's name
AS
BEGIN
    -- SQL statement to retrieve players based on club name
    SELECT 
        p.player_id, p.name, p.positions, p.value, p.wage
    FROM 
        Players p
    INNER JOIN 
        PlayerClubs pc ON p.player_id = pc.player_id
    INNER JOIN 
        Clubs c ON pc.club_id = c.club_id
    WHERE 
        c.name = @ClubName;
END;
-- Executing the stored procedure to retrieve players for "FC Barcelona"
EXEC GetClubPlayers @ClubName = 'FC Barcelona';
-- CREATE PROCEDURE: Defines a new stored procedure.
-- @ClubName: An input parameter that allows the user to specify the club name dynamically.
-- SELECT: Retrieves all players from the specified club.
-- EXEC: Executes the stored procedure with the club name 'FC Barcelona'.
-- Benefits of Stored Procedures:
--	Performance: Since stored procedures are precompiled, they can run faster than individual SQL statements.
--	Security: Permissions can be granted at the procedure level, allowing users to execute a stored procedure without direct access to the underlying tables.
--	Reusability: Once created, the procedure can be reused multiple times by different users or applications.

-- 2. TSQL15 ICA-Demo 2: Creating Stored Procedures with Input Parameters [BASIC]
-- In this demo, we’ll create a stored procedure that accepts input parameters to filter results dynamically based on user input.
-- This example demonstrates how to create a stored procedure named GetPlayersByPositionAndClub that retrieves players based on 
--	their position and club.
-- In this example, we will create a stored procedure called GetClubTotalWage that calculates and returns the 
--	total wage of all players in a given club using an output parameter.
-- Creating a stored procedure with input parameters for position and club name
CREATE PROCEDURE GetPlayersByPositionAndClub
    @Position NVARCHAR(50),    -- Input parameter for the player's position
    @ClubName NVARCHAR(100)    -- Input parameter for the club's name
AS
BEGIN
    -- SQL statement to retrieve players based on position and club name
    SELECT 
        p.player_id, p.name, p.positions, p.value, p.wage
    FROM 
        Players p
    INNER JOIN 
        PlayerClubs pc ON p.player_id = pc.player_id
    INNER JOIN 
        Clubs c ON pc.club_id = c.club_id
    WHERE 
        p.positions = @Position AND
        c.name = @ClubName;
END;
-- To use the stored procedure, you must pass both the position and the club name as input parameters during execution.
-- Executing the stored procedure to retrieve midfield players from "Real Madrid"
EXEC GetPlayersByPositionAndClub 
    @Position = 'CB', 
    @ClubName = 'Real Madrid';
-- CREATE PROCEDURE: Defines a stored procedure named GetPlayersByPositionAndClub.
-- @Position and @ClubName: Input parameters allow the user to specify the position (e.g., 'CM' for Central Midfielder) and club name (e.g., 'Real Madrid').
-- SQL Query: The query selects player details from the Players table, filters players based on the provided position and club name using the WHERE clause.
-- EXEC: Executes the stored procedure with the provided input parameters (e.g., CM for position and Real Madrid for the club).
-- Benefits:
--	Dynamic Filtering: Input parameters allow users to retrieve different data sets based on their needs, improving flexibility.
--	Code Reusability: You can use the same stored procedure with different input values without rewriting the SQL code.
--	Improved Performance: Like all stored procedures, the use of input parameters still benefits from precompilation and can enhance performance over repeatedly sending individual queries to the server.

-- 3. TSQL15 ICA-Demo 3: Using Output Parameters in Stored Procedures [INTERMEDIATE]
-- Stored procedures in SQL can also return values using output parameters. These parameters allow you to 
--	pass data back to the caller (e.g., an application or another SQL script) after the procedure executes.
-- Creating a stored procedure with an output parameter for total wage
CREATE PROCEDURE GetClubTotalWage
    @ClubName NVARCHAR(100),        -- Input parameter for club name
    @TotalWage INT OUTPUT           -- Output parameter for the total wage
AS
BEGIN
    -- Calculate the total wage of all players in the specified club
    SELECT 
        @TotalWage = SUM(p.wage)
    FROM 
        Players p
    INNER JOIN 
        PlayerClubs pc ON p.player_id = pc.player_id
    INNER JOIN 
        Clubs c ON pc.club_id = c.club_id
    WHERE 
        c.name = @ClubName;
END;
-- To retrieve the output parameter, you need to declare a variable, execute the procedure, and then display the result.
-- Declaring a variable to hold the output parameter
DECLARE @ClubWage INT;
-- Executing the stored procedure to get the total wage for "Real Madrid"
EXEC GetClubTotalWage 
    @ClubName = 'Arsenal', 
    @TotalWage = @ClubWage OUTPUT;
-- Displaying the result
SELECT @ClubWage*52 AS TotalAnnualSalary;
-- @ClubName: Input parameter that specifies the club for which to calculate the total wage.
-- @TotalWage: Output parameter that holds the result (total wage of all players).
-- SELECT @TotalWage = SUM(p.wage): The total wage is calculated and stored in the output parameter.
-- OUTPUT: Specifies that the parameter will return data to the caller.
-- DECLARE: Declares a variable to store the output value and use it after execution.
-- EXEC: Executes the stored procedure and retrieves the total wage for 'Real Madrid'.
-- Benefits of Output Parameters:
--	Returning Single Values: Ideal for procedures where you need to return a single value or status after execution, such as totals, counts, or a specific result.
--	Efficiency: Output parameters reduce the need for additional SELECT queries when a procedure needs to return a single result.
--	Flexibility: The procedure can accept multiple input parameters and return different results through output parameters.

-- 4. TSQL15 ICA-Demo 4: Executing Stored Procedures with Optional Parameters [INTERMEDIATE]
-- In SQL, stored procedures can also accept optional parameters, allowing flexibility in executing the procedure without 
--	providing all the arguments. This is done by assigning default values to the parameters
-- This example creates a stored procedure called GetPlayersByClubAndPosition, which retrieves players based 
--	on their club and/or position, but allows either parameter to be optional.
-- Creating a stored procedure with optional parameters for club and position
CREATE PROCEDURE GetPlayersByClubAndPosition
    @ClubName NVARCHAR(100) = NULL,    -- Optional parameter for club name, default is NULL
    @Position NVARCHAR(50) = NULL      -- Optional parameter for player position, default is NULL
AS
BEGIN
    -- SQL query to retrieve players based on provided parameters
    SELECT 
        p.player_id, 
        p.name, 
        p.positions, 
        p.value, 
        p.wage
    FROM 
        Players p
    INNER JOIN 
        PlayerClubs pc ON p.player_id = pc.player_id
    INNER JOIN 
        Clubs c ON pc.club_id = c.club_id
    WHERE 
        (c.name = @ClubName OR @ClubName IS NULL) -- If no club name provided, ignore filter
        AND 
        (p.positions = @Position OR @Position IS NULL); -- If no position provided, ignore filter
END;
-- You can execute this stored procedure by passing different combinations of parameters. 
--	You can either provide both, one, or none of the parameters.
-- Example 1: Retrieve all players from "FC Barcelona" (without filtering by position)
-- Executing the stored procedure with only the club name
EXEC GetPlayersByClubAndPosition 
    @ClubName = 'FC Barcelona';
-- Example 2: Retrieve all "ST" (Striker) players across all clubs
-- Executing the stored procedure with only the position
EXEC GetPlayersByClubAndPosition 
    @Position = 'ST';
-- Example 3: Retrieve all players without any filters (all clubs, all positions)
-- Executing the stored procedure without providing any parameters
EXEC GetPlayersByClubAndPosition;
-- Optional Parameters: The parameters @ClubName and @Position are optional because they have default values of NULL.
-- OR @ClubName IS NULL: The condition checks if the club name is NULL. If it is, the query ignores the club filter and 
--	retrieves players from all clubs. The same logic applies for the position filter.
-- Flexibility: The procedure allows different levels of filtering. Users can choose to filter by club, position, or both, 
--	or provide no filters to get all players.
-- Benefits of Optional Parameters:
--	Flexible Execution: Users can run the same procedure with different filters without needing to write separate procedures for each scenario.
--	Simplified Code: Instead of creating multiple procedures, a single one with optional parameters handles different filtering conditions.
--	Default Behavior: When no parameters are provided, the default behavior retrieves all records or ignores specific filters.

-- TSQL15 ICA-Demo 5: Error Handling in Stored Procedures with TRY...CATCH [INTERMEDIATE]
CREATE PROCEDURE InsertPlayer
    @PlayerName NVARCHAR(100),
    @FullName NVARCHAR(200),
    @Value DECIMAL(18, 2),
    @Wage DECIMAL(18, 2),
    @ReleaseClause DECIMAL(18, 2),
    @HeightCm INT,
    @WeightKg INT,
    @DateOfBirth DATE,
    @PreferredFoot NVARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ErrorMessage NVARCHAR(4000);
    DECLARE @ErrorSeverity INT;
    DECLARE @ErrorState INT;
	-- TRY Block:
	--	Input Validation:
	--		Checks for NULL values in required fields.
	--		Ensures monetary values are non-negative.
	--		Validates that height and weight are positive.
	--		Checks that the preferred foot is either "Left" or "Right".
	--	If any validation fails, it raises an error with a custom message.
	--	If all validations pass, it attempts to insert the new player into the Players table.
    BEGIN TRY
        -- Input validation
        IF @PlayerName IS NULL OR @FullName IS NULL
            RAISERROR('Player name and full name are required.', 16, 1);
			-- custom error messages for specific validation failures
        IF @Value < 0 OR @Wage < 0 OR @ReleaseClause < 0
            RAISERROR('Value, wage, and release clause must be non-negative.', 16, 1);

        IF @HeightCm <= 0 OR @WeightKg <= 0
            RAISERROR('Height and weight must be positive.', 16, 1);

        IF @PreferredFoot NOT IN ('Left', 'Right')
            RAISERROR('Preferred foot must be either "Left" or "Right".', 16, 1);

        -- Insert the new player
        INSERT INTO Players (name, full_name, value, wage, release_clause, height_cm, weight_kg, dob, preferred_foot)
        VALUES (@PlayerName, @FullName, @Value, @Wage, @ReleaseClause, @HeightCm, @WeightKg, @DateOfBirth, @PreferredFoot);

        PRINT 'Player inserted successfully.';
    END TRY
	-- CATCH Block:
	--	Captures error details using ERROR_MESSAGE(), ERROR_SEVERITY(), and ERROR_STATE().
	--	Logs the error (in this case, just printing it, but you could insert it into an error log table).
	--	Re-throws the error to the calling process using RAISERROR.
    BEGIN CATCH
        SELECT 
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

        -- Log the error (you might want to insert into an error log table here)
        PRINT 'Error ' + CAST(@ErrorSeverity AS NVARCHAR(10)) + 
              ', State ' + CAST(@ErrorState AS NVARCHAR(10)) + 
              ': ' + @ErrorMessage;

        -- Re-throw the error to the calling process
        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
		-- Uses RAISERROR for custom error messages in input validation.
    END CATCH
END;
-- Input Parameters:
--	The procedure accepts various details about a player, such as name, full name, value, wage, release clause, height, weight, date of birth, and preferred foot.
-- Error Handling Variables:
--	Declarations for storing error details: message, severity, and state.
EXEC InsertPlayer 
    @PlayerName = 'John Doe',
    @FullName = 'John Michael Doe',
    @Value = 1000000.00,
    @Wage = 10000.00,
    @ReleaseClause = 2000000.00,
    @HeightCm = 180,
    @WeightKg = 75,
    @DateOfBirth = '1995-05-15',
    @PreferredFoot = 'Both'; --Deliberate error 

-- TSQL16 Demo 1: Aggregating Data with Group By
-- 1.	TSQL16 ICA-Demo 1: Writing Simple T-SQL Scripts [BASIC]
-- The function will calculate total player value and count of players grouped by a specified time period
CREATE PROCEDURE dbo.GetClubMetrics
    @ClubID INT -- Parameter to filter by a specific club
AS
BEGIN
    -- Begin procedure execution
    SET NOCOUNT ON; -- Prevents extra result sets from interfering with output

    -- Validate the input parameter
    IF NOT EXISTS (SELECT 1 FROM Clubs WHERE club_id = @ClubID)
    BEGIN
        -- If the ClubID does not exist, raise an error and exit
        RAISERROR('Invalid ClubID: %d. Please provide a valid ClubID.', 16, 1, @ClubID);
        RETURN;
    END

    -- Calculate metrics grouped by club
    SELECT 
        c.name AS ClubName,
        COUNT(p.player_id) AS TotalPlayers,
        SUM(p.value) AS TotalPlayerValue,
        AVG(pa.overall_rating) AS AveragePlayerRating
    FROM 
        Players p
    INNER JOIN 
        PlayerClubs pc ON p.player_id = pc.player_id
    INNER JOIN 
        Clubs c ON pc.club_id = c.club_id
    INNER JOIN 
        PlayerAttributes pa ON p.player_id = pa.player_id
    WHERE 
        c.club_id = @ClubID -- Filter by specified club
    GROUP BY 
        c.name; -- Group by club name

    -- Indicate successful execution
    PRINT 'Metrics successfully retrieved for the specified club.';
END;
GO

--Example Usage
EXEC dbo.GetClubMetrics @ClubID = 2;

--TSQL16 Demo 2: Using Table-Valued Functions (TVFs) for Modularization
CREATE FUNCTION dbo.GetPlayerMetricsByPeriod
(
    @Year INT,
    @Month INT
)
RETURNS TABLE
AS
RETURN
(
    SELECT 
        YEAR(pc.joined_date) AS Year,
        MONTH(pc.joined_date) AS Month,
        c.name AS ClubName,
        COUNT(p.player_id) AS PlayerCount,
        SUM(p.value) AS TotalPlayerValue
    FROM 
        Players p
    INNER JOIN 
        PlayerClubs pc ON p.player_id = pc.player_id
    INNER JOIN 
        Clubs c ON pc.club_id = c.club_id
    WHERE 
        YEAR(pc.joined_date) = @Year AND MONTH(pc.joined_date) = @Month
    GROUP BY 
        YEAR(pc.joined_date), MONTH(pc.joined_date), c.name
);
GO

-- The stored procedure will call the TVF, validate input parameters, and return the aggregated metrics.
CREATE PROCEDURE dbo.GetPlayerMetricsByMonth
    @Year INT, -- Year filter
    @Month INT -- Month filter
AS
BEGIN
    -- Prevent extra result sets from interfering with the output
    SET NOCOUNT ON;

    -- Validate input parameters
    IF @Year < 2000 OR @Year > YEAR(GETDATE())
    BEGIN
        RAISERROR('Invalid Year: %d. Please provide a year between 2000 and the current year.', 16, 1, @Year);
        RETURN;
    END

    IF @Month < 1 OR @Month > 12
    BEGIN
        RAISERROR('Invalid Month: %d. Please provide a month between 1 and 12.', 16, 1, @Month);
        RETURN;
    END

    -- Call the TVF to retrieve metrics
    SELECT * 
    FROM dbo.GetPlayerMetricsByPeriod(@Year, @Month);

    -- Indicate successful execution
    PRINT 'Player metrics retrieved successfully.';
END;
GO

-- Fetch metrics for January 2024
EXEC dbo.GetPlayerMetricsByMonth @Year = 2024, @Month = 1;

-- Invalid month
EXEC dbo.GetPlayerMetricsByMonth @Year = 2024, @Month = 13;

-- TSQL16 Demo 3: Control-of-Flow with Window Functions
CREATE PROCEDURE dbo.AnalyzePlayerTrends
    @CountryID INT -- Parameter to filter data by a country
AS
BEGIN
    -- Prevent extra result sets from interfering
    SET NOCOUNT ON;

    -- Step 1: Validate the input parameter
    IF NOT EXISTS (SELECT 1 FROM Countries WHERE country_id = @CountryID)
    BEGIN
        -- If the CountryID does not exist, raise an error
        RAISERROR('Invalid CountryID: %d. Please provide a valid CountryID.', 16, 1, @CountryID);
        RETURN;
    END

    -- Step 2: Analyze player trends using window functions
    SELECT 
        p.full_name AS PlayerName,
        p.value AS PlayerValue,
        pa.overall_rating AS PlayerRating,
        ROW_NUMBER() OVER (PARTITION BY pc.country_id ORDER BY p.value DESC) AS PlayerRank,
        RANK() OVER (PARTITION BY pc.country_id ORDER BY pa.overall_rating DESC) AS RatingRank,
        SUM(p.value) OVER (PARTITION BY pc.country_id) AS TotalCountryPlayerValue,
        AVG(pa.overall_rating) OVER (PARTITION BY pc.country_id) AS AvgCountryRating
    FROM 
        Players p
    INNER JOIN 
        PlayerCountries pc ON p.player_id = pc.player_id
    INNER JOIN 
        PlayerAttributes pa ON p.player_id = pa.player_id
    WHERE 
        pc.country_id = @CountryID; -- Filter by the specified country

    -- Indicate successful execution
    PRINT 'Player trends analysis completed successfully.';
END;
GO

-- Execute the stored procedure for CountryID 1
EXEC dbo.AnalyzePlayerTrends @CountryID = 1356;


-- TSQL16 Demo 4: Pivoting Data for Analysis
CREATE PROCEDURE dbo.PivotPlayerRatings
    @CountryID INT = NULL, -- Parameter to filter data by a specific country (optional)
    @LeagueID INT = NULL -- Parameter to filter data by a specific league (optional)
AS
BEGIN
    -- Prevent extra result sets from interfering
    SET NOCOUNT ON;

    -- Step 1: Validate the input parameters
    IF @CountryID IS NOT NULL AND NOT EXISTS (SELECT 1 FROM Countries WHERE country_id = @CountryID)
    BEGIN
        RAISERROR('Invalid CountryID: %d. Please provide a valid CountryID.', 16, 1, @CountryID);
        RETURN;
    END

    IF @LeagueID IS NOT NULL AND NOT EXISTS (SELECT 1 FROM Leagues WHERE league_id = @LeagueID)
    BEGIN
        RAISERROR('Invalid LeagueID: %d. Please provide a valid LeagueID.', 16, 1, @LeagueID);
        RETURN;
    END

    -- Step 2: Create a temporary table to hold filtered data
    SELECT 
        c.name AS Country,
        l.name AS League,
        clu.name AS Club,
        pa.overall_rating
    INTO #PlayerData
    FROM 
        Players p
    INNER JOIN 
        PlayerClubs pc ON p.player_id = pc.player_id
    INNER JOIN 
        Clubs clu ON pc.club_id = clu.club_id
    INNER JOIN 
        Leagues l ON clu.league_id = l.league_id
    INNER JOIN 
        PlayerCountries pcnt ON p.player_id = pcnt.player_id
    INNER JOIN 
        Countries c ON pcnt.country_id = c.country_id
    INNER JOIN 
        PlayerAttributes pa ON p.player_id = pa.player_id
    WHERE 
        (@CountryID IS NULL OR c.country_id = @CountryID) AND
        (@LeagueID IS NULL OR l.league_id = @LeagueID);

    -- Step 3: Pivot the data to show average ratings across clubs for each country
    DECLARE @PivotQuery NVARCHAR(MAX);

    SET @PivotQuery = N'
        SELECT Country, ' + 
        STUFF(
            (SELECT DISTINCT ',' + QUOTENAME(Club)
             FROM #PlayerData
             FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 1, ''
        ) + N'
        FROM 
        (
            SELECT 
                Country, Club, overall_rating
            FROM #PlayerData
        ) AS SourceTable
        PIVOT 
        (
            AVG(overall_rating) 
            FOR Club IN (' + 
            STUFF(
                (SELECT DISTINCT ',' + QUOTENAME(Club)
                 FROM #PlayerData
                 FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 1, ''
            ) + N')
        ) AS PivotTable;';

    -- Step 4: Execute the dynamic pivot query
    EXEC sp_executesql @PivotQuery;

    -- Drop the temporary table to clean up
    DROP TABLE #PlayerData;

    -- Indicate successful execution
    PRINT 'Pivot analysis completed successfully.';
END;
GO

-- Pivot data for CountryID 1 and LeagueID 2
EXEC dbo.PivotPlayerRatings @CountryID = 1343, @LeagueID = 1;

-- Pivot data for all countries in LeagueID 3
EXEC dbo.PivotPlayerRatings @LeagueID = 1;

-- Pivot data for all countries and leagues
EXEC dbo.PivotPlayerRatings;

-- TSQL16 Advanced Demo A: Comprehensive Analysis with Cursors and User-Defined Functions
-- First, create a table to log errors.
CREATE TABLE ErrorLog (
    ErrorID INT IDENTITY(1,1) PRIMARY KEY,
    ErrorMessage NVARCHAR(4000),
    ErrorSeverity INT,
    ErrorState INT,
    ErrorProcedure NVARCHAR(200),
    ErrorLine INT,
    ErrorDateTime DATETIME DEFAULT GETDATE()
);

-- Create a UDF to modularize repeated calculations, such as calculating a player's weighted attribute score.
CREATE FUNCTION dbo.CalculateWeightedScore (
    @Dribbling TINYINT,
    @Passing TINYINT,
    @Shooting TINYINT
)
RETURNS DECIMAL(10, 2)
AS
BEGIN
    RETURN (@Dribbling * 0.4 + @Passing * 0.3 + @Shooting * 0.3);
END;
GO

-- Implement a stored procedure that uses a cursor to iterate through players, calculates their weighted score 
--	using the UDF, and logs errors using TRY...CATCH.
CREATE PROCEDURE dbo.AnalyzePlayerAttributes
AS
BEGIN
    -- Prevent extra result sets from interfering
    SET NOCOUNT ON;

    -- Declare variables for the cursor
    DECLARE @PlayerID INT,
            @Dribbling TINYINT,
            @Passing TINYINT,
            @Shooting TINYINT,
            @WeightedScore DECIMAL(10, 2);

    -- Declare a cursor to iterate through players
    DECLARE PlayerCursor CURSOR FOR
    SELECT 
        p.player_id,
        pa.dribbling,
        pa.short_passing,
        pa.finishing
    FROM 
        Players p
    INNER JOIN 
        PlayerAttributes pa ON p.player_id = pa.player_id;

    -- Open the cursor
    OPEN PlayerCursor;

    -- Error handling
    BEGIN TRY
        -- Fetch the first row
        FETCH NEXT FROM PlayerCursor INTO @PlayerID, @Dribbling, @Passing, @Shooting;

        WHILE @@FETCH_STATUS = 0
        BEGIN
            -- Nested TRY...CATCH for each row
            BEGIN TRY
                -- Calculate the weighted score using the UDF
                SET @WeightedScore = dbo.CalculateWeightedScore(@Dribbling, @Passing, @Shooting);

                -- Output the result
                PRINT 'PlayerID: ' + CAST(@PlayerID AS NVARCHAR(10)) + ', Weighted Score: ' + CAST(@WeightedScore AS NVARCHAR(10));

            END TRY
            BEGIN CATCH
                -- Log any errors that occur within the row processing
                INSERT INTO ErrorLog (ErrorMessage, ErrorSeverity, ErrorState, ErrorProcedure, ErrorLine)
                VALUES (ERROR_MESSAGE(), ERROR_SEVERITY(), ERROR_STATE(), ERROR_PROCEDURE(), ERROR_LINE());
            END CATCH;

            -- Fetch the next row
            FETCH NEXT FROM PlayerCursor INTO @PlayerID, @Dribbling, @Passing, @Shooting;
        END;
    END TRY
    BEGIN CATCH
        -- Log any errors that occur outside the row processing
        INSERT INTO ErrorLog (ErrorMessage, ErrorSeverity, ErrorState, ErrorProcedure, ErrorLine)
        VALUES (ERROR_MESSAGE(), ERROR_SEVERITY(), ERROR_STATE(), ERROR_PROCEDURE(), ERROR_LINE());
    END CATCH;

    -- Close and deallocate the cursor
    CLOSE PlayerCursor;
    DEALLOCATE PlayerCursor;

    PRINT 'Player analysis completed successfully.';
END;
GO

EXEC dbo.AnalyzePlayerAttributes;


-- TSQL17 Demo 1: Basic TRY…CATCH for Error Handling
-- Enable error handling for the Players table using TRY...CATCH
BEGIN TRY
    -- Attempt to insert a record with a NULL value in a NOT NULL field
    INSERT INTO Players (player_id, name, full_name, age, height_cm, weight_kg, nationality, wage)
    VALUES (1, NULL, 'Test Player', 25, 180, 75, 'Test Country', 5000);

    -- If successful, output a success message
    PRINT 'Record inserted successfully!';
END TRY
BEGIN CATCH
    -- Output the error details
    PRINT 'An error occurred:';
    PRINT ERROR_MESSAGE();  -- Retrieve and print the error message
END CATCH;

-- TSQL17 Demo 2: THROW Statement for Error Re-throwing
-- Enable TRY...CATCH with a THROW statement for error re-throwing
BEGIN TRY
    -- Intentionally create a divide by zero error
    DECLARE @Numerator INT = 10;
    DECLARE @Denominator INT = 0;

    -- This will cause an error
    SELECT @Numerator / @Denominator AS Result;
END TRY
BEGIN CATCH
    -- Output a custom error message for logging or debugging purposes
    PRINT 'An error occurred during the calculation.';

    -- Re-throw the error to provide full details (message, line number, state)
    THROW;
END CATCH;

-- TSQL17 Demo 3: Custom Error Handling with RAISERROR
-- Demonstrate custom error handling with RAISERROR and transactions
BEGIN TRY
    -- Start a transaction
    BEGIN TRANSACTION;

    -- Declare a variable for UnitPrice (simulating input)
    DECLARE @UnitPrice DECIMAL(10, 2) = -50.00;

    -- Check if UnitPrice is negative
    IF @UnitPrice < 0
    BEGIN
        -- Trigger a custom error using RAISERROR
        RAISERROR ('UnitPrice cannot be negative.', 16, 1);
    END

    -- If no error, insert a sample record (assume a Products table exists)
    INSERT INTO Products (ProductName, UnitPrice)
    VALUES ('Sample Product', @UnitPrice);

    -- Commit the transaction
    COMMIT TRANSACTION;

    -- Success message
    PRINT 'Record inserted successfully!';
END TRY
BEGIN CATCH
    -- Roll back the transaction if an error occurs
    IF @@TRANCOUNT > 0
    BEGIN
        ROLLBACK TRANSACTION;
        PRINT 'Transaction rolled back due to an error.';
    END

    -- Output the custom error message
    PRINT 'An error occurred:';
    PRINT ERROR_MESSAGE(); -- Retrieve and print the error details
END CATCH;

-- TSQL17 Demo A: Advanced error handling example
-- Nested TRY...CATCH for inserting into Players and PlayerAttributes
BEGIN TRY
    PRINT 'Outer TRY block started.';

    -- Outer TRY block operation: Insert a player
    BEGIN TRY
        PRINT 'Inner TRY block started.';
        
        -- Attempt to insert an invalid player (e.g., missing required Name)
        INSERT INTO Players (player_id, name, full_name, height_cm, weight_kg, wage)
        VALUES (1, NULL, 'Test Player', 180, 75, 5000); -- NULL name causes an error

        PRINT 'Inner TRY block completed successfully.';
    END TRY
    BEGIN CATCH
        -- Handle inner error
        PRINT 'An error occurred in the inner TRY block:';
        PRINT ERROR_MESSAGE();

        -- Rethrow the error for the outer block to handle
        THROW;
    END CATCH;

    PRINT 'Outer TRY block completed successfully.';
END TRY
BEGIN CATCH
    -- Handle outer error
    PRINT 'An error occurred in the outer TRY block:';
    PRINT ERROR_MESSAGE();
END CATCH;

-- Test query that meant to cause error went through so debugging:
--	Look for player_id = 1
SELECT * FROM Players WHERE player_id = 1
--	Check this is the only player with null name so I can delete it
SELECT * FROM Players WHERE name IS NULL
--	Delete the test record
DELETE FROM Players WHERE name IS NULL;
--  Make name non-nullable 
ALTER TABLE Players
ALTER COLUMN name NVARCHAR(50) NOT NULL;
--	Run the query again - throws errors as expected

-- I will not make a ErrorLog table and instead use the one I made in TSQL16 Advanced Demo
-- Log Error Details on Failure
-- Insert error details into the ErrorLog table
BEGIN TRY
    -- Attempt an invalid operation: inserting a player with NULL name
    INSERT INTO Players (player_id, name, full_name, height_cm, weight_kg, wage)
    VALUES (2, NULL, 'Another Test Player', 175, 70, 3000); -- NULL name causes an error
END TRY
BEGIN CATCH
    -- Log the error in the ErrorLog table
    INSERT INTO dbo.ErrorLog (ErrorMessage, ErrorSeverity, ErrorState)
    VALUES (ERROR_MESSAGE(), ERROR_SEVERITY(), ERROR_STATE());

    -- Optionally, rethrow the error for further handling
    THROW;
END CATCH;


-- For this I will reuse the procedure that I made in TSQL15 Demo 5 and update the code by adding a error logger logic
ALTER PROCEDURE InsertPlayer
    @PlayerName NVARCHAR(100),
    @FullName NVARCHAR(200),
    @Value DECIMAL(18, 2),
    @Wage DECIMAL(18, 2),
    @ReleaseClause DECIMAL(18, 2),
    @HeightCm INT,
    @WeightKg INT,
    @DateOfBirth DATE,
    @PreferredFoot NVARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ErrorMessage NVARCHAR(4000);
    DECLARE @ErrorSeverity INT;
    DECLARE @ErrorState INT;
	-- TRY Block:
	--	Input Validation:
	--		Checks for NULL values in required fields.
	--		Ensures monetary values are non-negative.
	--		Validates that height and weight are positive.
	--		Checks that the preferred foot is either "Left" or "Right".
	--	If any validation fails, it raises an error with a custom message.
	--	If all validations pass, it attempts to insert the new player into the Players table.
    BEGIN TRY
        -- Input validation
			-- custom error messages for specific validation failures
        IF @Value < 0 OR @Wage < 0 OR @ReleaseClause < 0
            RAISERROR('Value, wage, and release clause must be non-negative.', 16, 1);

        IF @HeightCm <= 0 OR @WeightKg <= 0
            RAISERROR('Height and weight must be positive.', 16, 1);

        IF @PreferredFoot NOT IN ('Left', 'Right')
            RAISERROR('Preferred foot must be either "Left" or "Right".', 16, 1);

        -- Insert the new player
        INSERT INTO Players (name, full_name, value, wage, release_clause, height_cm, weight_kg, dob, preferred_foot)
        VALUES (@PlayerName, @FullName, @Value, @Wage, @ReleaseClause, @HeightCm, @WeightKg, @DateOfBirth, @PreferredFoot);

        PRINT 'Player inserted successfully.';
    END TRY
	-- CATCH Block:
	--	Captures error details using ERROR_MESSAGE(), ERROR_SEVERITY(), and ERROR_STATE().
	--	Logs the error (in this case, just printing it, but you could insert it into an error log table).
	--	Re-throws the error to the calling process using RAISERROR.
    BEGIN CATCH
        SELECT 
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

        -- Log the error (you might want to insert into an error log table here)
        PRINT 'Error ' + CAST(@ErrorSeverity AS NVARCHAR(10)) + 
              ', State ' + CAST(@ErrorState AS NVARCHAR(10)) + 
              ': ' + @ErrorMessage;

		-- Log the error in the ErrorLog table
		INSERT INTO dbo.ErrorLog (ErrorMessage, ErrorSeverity, ErrorState)
		VALUES (ERROR_MESSAGE(), ERROR_SEVERITY(), ERROR_STATE());

        -- Re-throw the error to the calling process
        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
		-- Uses RAISERROR for custom error messages in input validation.
    END CATCH
END;

-- Test with invalid data (NULL Name)
EXEC dbo.InsertPlayer 
	@PlayerName = null,				   -- Example player name
    @FullName = 'Lionel Andrés Messi', -- Full name of the player
    @Value = 100000000,                -- Player market value in decimal format
    @Wage = 500000,                    -- Weekly wage in decimal format
    @ReleaseClause = 200000000,        -- Release clause in decimal format
    @HeightCm = 170,                   -- Height in centimeters
    @WeightKg = 72,                    -- Weight in kilograms
    @DateOfBirth = '1987-06-24',       -- Date of birth in YYYY-MM-DD format
    @PreferredFoot = 'Left';           -- Preferred foot (e.g., 'Left' or 'Right')


-- TSQL18 Demo 1: Implementing Basic Transactions
BEGIN TRY
    -- Start the transaction
    BEGIN TRANSACTION;

    -- Step 1: Insert a new player into the Players table
    INSERT INTO Players (player_id, name, full_name, height_cm, weight_kg, wage)
    VALUES (5, 'Lionel Messi', 'Lionel Andrés Messi', 170, 72, 650000);

    PRINT 'Player inserted successfully.';

    -- Step 2: Insert related attributes into the PlayerAttributes table
    INSERT INTO PlayerAttributes (player_id, overall_rating, potential, crossing, finishing, ball_control)
    VALUES (5, 93, 94, 90, 95, 96);

    PRINT 'Player attributes inserted successfully.';

    -- Step 3: Intentionally simulate an error (e.g., inserting into a non-existent table)
    INSERT INTO NonExistentTable (some_column)
    VALUES ('Simulated Error'); -- This will cause an error

    -- Commit the transaction if all steps succeed
    COMMIT TRANSACTION;

    PRINT 'Transaction committed successfully.';
END TRY
BEGIN CATCH
    -- Check the error number
    IF ERROR_NUMBER() = 208
    BEGIN
        PRINT 'Custom Handling: Invalid object name encountered.';
        -- Handle the error (e.g., log it, take alternative action)
        -- Rollback only if necessary
        IF @@TRANCOUNT > 0
        BEGIN
            ROLLBACK TRANSACTION;
            PRINT 'Transaction rolled back due to invalid object name error.';
        END
    END
    ELSE
    BEGIN
        -- Generic error handling for other errors
        IF @@TRANCOUNT > 0
        BEGIN
            ROLLBACK TRANSACTION;
            PRINT 'Transaction rolled back due to an unspecified error.';
        END
        PRINT 'Error details:';
        PRINT ERROR_MESSAGE();
    END
END CATCH;

-- DEBUG
SELECT * FROM Players WHERE player_id = 5
--	Check this is the only player with null name so I can delete it
SELECT * FROM Players WHERE name LIKE '%Messi%';

--	Delete the test record
Delete from PlayerAttributes where player_id =5;
DELETE FROM Players WHERE player_id = 5;

SET XACT_ABORT ON;
SET XACT_ABORT OFF;

-- TSQL18 Demo 2: Controlling Transactions with Savepoints
BEGIN TRY
    -- Start the transaction
    BEGIN TRANSACTION;

    -- Step 1: Insert a new player into the Players table
    INSERT INTO Players (player_id, name, full_name, height_cm, weight_kg, wage)
    VALUES (10, 'Cristiano Ronaldo', 'Cristiano Ronaldo dos Santos Aveiro', 187, 83, 580000);

    PRINT 'Step 1: Player inserted successfully.';

    -- Savepoint 1: Allows rollback to this state if required
    SAVE TRANSACTION Savepoint1;

    -- Step 2: Insert related attributes into the PlayerAttributes table
    INSERT INTO PlayerAttributes (player_id, overall_rating, potential, crossing, finishing, ball_control)
    VALUES (null, 91, 91, 85, 95, 92);

    PRINT 'Step 2: Player attributes inserted successfully.';

    -- Savepoint 2: Allows rollback to this state if required
    SAVE TRANSACTION Savepoint2;

    -- Step 3: Simulate an error (e.g., inserting into a non-existent table)
    PRINT 'Step 3: Simulating an error...';
    INSERT INTO NonExistentTable (some_column)
    VALUES ('Simulated Error'); -- This will cause an error

    -- Commit the transaction if all steps succeed
    COMMIT TRANSACTION;
    PRINT 'Transaction committed successfully.';
END TRY
BEGIN CATCH
    -- Error handling: Identify the issue and perform selective rollback
    PRINT 'An error occurred:';
    PRINT ERROR_MESSAGE();

    -- Rollback to the first savepoint to undo changes after Step 1
    IF ERROR_NUMBER() = 208
    BEGIN
        PRINT 'Rolling back to Savepoint1 due to invalid object name.';
        ROLLBACK TRANSACTION Savepoint1;
    END
    ELSE
    BEGIN
        PRINT 'Rolling back entire transaction due to an unexpected error.';
        ROLLBACK TRANSACTION;
    END

    -- Check the transaction state
    IF @@TRANCOUNT > 0
    BEGIN
        PRINT 'Transaction is still active, committing changes before the error.';
        COMMIT TRANSACTION;
    END
    ELSE
    BEGIN
        PRINT 'Transaction fully rolled back.';
    END
END CATCH;


--DEBUG
SELECT * FROM Players WHERE player_id = 10
Delete from PlayerAttributes where player_id =10;
DELETE FROM Players WHERE player_id = 10;

-- TSQL18 Demo 3: Handling Errors in Transactions with TRY…CATCH
-- Start of the TRY…CATCH Demo
BEGIN TRY
    -- Start a transaction
    BEGIN TRANSACTION;

    -- Example Insert Operation: Add a new player to the Players table
    INSERT INTO Players (name, full_name, value, wage, release_clause, dob, positions, 	preferred_foot, real_face)
    VALUES ('John Doe', 'Johnathan Doe', 2000000, 15000, 5000000, '1995-05-20', 'ST', 'Right', 1);

    -- Example: Force an error by inserting a duplicate primary key (if player_id is auto-incremented, simulate with another statement)
    INSERT INTO Players (player_id, name, full_name, value, wage, release_clause, dob, 	positions, preferred_foot, real_face)
    VALUES (1, 'Duplicate Player', 'Duplicate Full Name', 5000000, 100000, 10000000, '1993-	10-10', 'GK', 'Left', 0);

    -- Commit the transaction if no errors occur
    COMMIT TRANSACTION;

    -- Success message
    PRINT 'Transaction committed successfully!';
END TRY
-- Continue to CATCH block
BEGIN CATCH
    -- Error handling
    -- Retrieve and display error details
    DECLARE @ErrorMessage NVARCHAR(4000), @ErrorNumber INT, 
	@ErrorSeverity INT, @ErrorState INT, @ErrorLine INT;

    SET @ErrorMessage = ERROR_MESSAGE();
    SET @ErrorNumber = ERROR_NUMBER();
    SET @ErrorSeverity = ERROR_SEVERITY();
    SET @ErrorState = ERROR_STATE();
    SET @ErrorLine = ERROR_LINE();

    PRINT 'Error encountered:';
    PRINT 'Message: ' + @ErrorMessage;
    PRINT 'Error Number: ' + CAST(@ErrorNumber AS NVARCHAR);
    PRINT 'Severity: ' + CAST(@ErrorSeverity AS NVARCHAR);
    PRINT 'State: ' + CAST(@ErrorState AS NVARCHAR);
    PRINT 'Line: ' + CAST(@ErrorLine AS NVARCHAR);

    -- Rollback the transaction to maintain consistency
    IF @@TRANCOUNT > 0
    BEGIN
        ROLLBACK TRANSACTION;
        PRINT 'Transaction rolled back due to error.';
    END;
END CATCH;

-- Verify the transaction state (should be no active transaction)
IF @@TRANCOUNT = 0
    PRINT 'No active transaction.';
ELSE
    PRINT 'Active transaction exists. Check for errors.';

-- TSQL18 Demo 4:Using Transactions in Stored Procedures
CREATE PROCEDURE usp_UpdatePlayerDetails
    @PlayerID INT, -- Parameter to identify the player
    @NewWage DECIMAL(18, 2), -- Parameter for updating player's wage
    @Specialty NVARCHAR(100), -- New specialty to be added for the player
    @ClubID INT -- Club ID to update player's club association
AS
BEGIN
    -- Start of transaction
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Update player's wage
        UPDATE Players
        SET wage = @NewWage
        WHERE player_id = @PlayerID;

        -- Insert a new specialty for the player
        INSERT INTO PlayerSpecialities (player_id, speciality)
        VALUES (@PlayerID, @Specialty);

        -- Update player's club association
        UPDATE PlayerClubs
        SET club_id = @ClubID
        WHERE player_id = @PlayerID;

        -- Commit the transaction if no errors occur
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Rollback transaction in case of an error
        ROLLBACK TRANSACTION;

        -- Capture and return error information
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();

        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH;
END;
GO

-- TSQL18 Advanced Demo A:Advanced Transaction Management
CREATE PROCEDURE usp_AdvancedPlayerTransaction
    @PlayerID INT, -- Player to update
    @NewWage DECIMAL(18, 2), -- Updated wage
    @Specialty NVARCHAR(100), -- New specialty to add
    @ClubID INT, -- Club ID for updating the player's club
    @CountryID INT -- Country ID for updating player's nationality
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION; -- Begin main transaction

        -- Wage update
        SAVE TRANSACTION SavePoint_WageUpdate;
        UPDATE Players
        SET wage = @NewWage
        WHERE player_id = @PlayerID;

        -- Specialty addition
        SAVE TRANSACTION SavePoint_Specialty;
        INSERT INTO PlayerSpecialities (player_id, speciality)
        VALUES (@PlayerID, @Specialty);

        -- Club update
        SAVE TRANSACTION SavePoint_ClubUpdate;
        UPDATE PlayerClubs
        SET club_id = @ClubID
        WHERE player_id = @PlayerID;

        -- Country update
        SAVE TRANSACTION SavePoint_CountryUpdate;
        UPDATE PlayerCountries
        SET country_id = @CountryID
        WHERE player_id = @PlayerID;

        COMMIT TRANSACTION; -- Commit only if all operations succeed
    END TRY
    BEGIN CATCH
        -- Log error and rollback transaction
        INSERT INTO ErrorLog (ErrorMessage, ErrorSeverity, ErrorState, 
	ErrorProcedure, ErrorLine)
        VALUES (ERROR_MESSAGE(), ERROR_SEVERITY(), ERROR_STATE(), 
	ERROR_PROCEDURE(), ERROR_LINE());
        ROLLBACK TRANSACTION;
    END CATCH;
END;
GO

-- TSQL19 Demo 1:  Implementing Role-Based Security
-- Step 1: Create Roles
CREATE ROLE DataEntry;
CREATE ROLE Manager;
CREATE ROLE Admin;

-- Step 2: Grant Permissions to Roles
-- DataEntry role: Can only insert and select data from the Players table
GRANT SELECT, INSERT ON Players TO DataEntry;

-- Manager role: Can select and update data from Players, PlayerAttributes, and PlayerClubs tables
GRANT SELECT, UPDATE ON Players TO Manager;
GRANT SELECT, UPDATE ON PlayerAttributes TO Manager;
GRANT SELECT, UPDATE ON PlayerClubs TO Manager;

-- Admin role: Full access to all tables
GRANT SELECT, INSERT, UPDATE, DELETE ON Players TO Admin;
GRANT SELECT, INSERT, UPDATE, DELETE ON PlayerAttributes TO Admin;
GRANT SELECT, INSERT, UPDATE, DELETE ON PlayerClubs TO Admin;
GRANT SELECT, INSERT, UPDATE, DELETE ON GoalkeeperAttributes TO Admin;
GRANT SELECT, INSERT, UPDATE, DELETE ON Clubs TO Admin;
GRANT SELECT, INSERT, UPDATE, DELETE ON Leagues TO Admin;
GRANT SELECT, INSERT, UPDATE, DELETE ON Countries TO Admin;
GRANT SELECT, INSERT, UPDATE, DELETE ON PlayerPlayStyles TO Admin;
GRANT SELECT, INSERT, UPDATE, DELETE ON PlayerSpecialities TO Admin;
GRANT SELECT, INSERT, UPDATE, DELETE ON PlayerCountries TO Admin;

-- Step 3: Create Test Users and Assign Roles
-- Create test users
CREATE LOGIN TestUserDataEntry WITH PASSWORD = 'Password123!';
CREATE LOGIN TestUserManager WITH PASSWORD = 'Password123!';
CREATE LOGIN TestUserAdmin WITH PASSWORD = 'Password123!';

-- Map users to the database
CREATE USER TestUserDataEntry FOR LOGIN TestUserDataEntry;
CREATE USER TestUserManager FOR LOGIN TestUserManager;
CREATE USER TestUserAdmin FOR LOGIN TestUserAdmin;

-- Assign roles to users
EXEC sp_addrolemember 'DataEntry', 'TestUserDataEntry';
EXEC sp_addrolemember 'Manager', 'TestUserManager';
EXEC sp_addrolemember 'Admin', 'TestUserAdmin';

-- Step 4: Testing (Verify Roles)
-- Test DataEntry permissions
-- Run as TestUserDataEntry:
EXECUTE AS USER = 'TestUserDataEntry';
SELECT * FROM Players; -- Should work
-- Should work
INSERT INTO Players (player_id, name) VALUES (99998, 'Test Player'); 
-- Should fail
UPDATE Players SET name = 'New Name' WHERE player_id = 99998;
-- Should fail
DELETE FROM Players WHERE player_id = 99998; 

-- Test Manager permissions
-- Run as TestUserManager:
EXECUTE AS USER = 'TestUserManager';
-- Should work
SELECT * FROM Players;
-- Should work
UPDATE Players SET name = 'Updated Name' WHERE player_id = 99998; 
-- Should fail
INSERT INTO Players (player_id, name) VALUES (1002, 'Another Player'); 
-- Should fail
DELETE FROM Players WHERE player_id = 99998; 

-- Test Admin permissions
-- Run as TestUserAdmin:
EXECUTE AS USER = 'TestUserAdmin';
-- Should all work
-- SELECT, INSERT, UPDATE, DELETE on all tables 


-- TSQL19 Demo 2: Encrypting Sensitive Data

-- Step 1: Create a New Table for Guests
CREATE TABLE Guests (
    guest_id INT IDENTITY PRIMARY KEY,       -- Unique identifier for each guest
    guest_name NVARCHAR(100),               -- Name of the guest
    ticket_id INT,                          -- Ticket ID for their purchase
    encrypted_credit_card NVARCHAR(100),   -- Encrypted credit card information
    encrypted_id NVARCHAR(50)             -- Encrypted government ID
);

-- Step 2: Create a Database Master Key (if not already created)
IF NOT EXISTS (SELECT * FROM sys.symmetric_keys WHERE name = '##MS_DatabaseMasterKey##')
BEGIN
    CREATE MASTER KEY ENCRYPTION BY PASSWORD = 'StrongPassword123!';
END;

-- Step 3: Create a Certificate
CREATE CERTIFICATE GuestDataCert
WITH SUBJECT = 'Certificate for Encrypting Guest Data';

-- Step 4: Create a Symmetric Key
CREATE SYMMETRIC KEY GuestDataKey
WITH ALGORITHM = AES_256
ENCRYPTION BY CERTIFICATE GuestDataCert;

-- Step 5: Insert Guest Data with Encryption
-- Open the symmetric key to encrypt sensitive data
OPEN SYMMETRIC KEY GuestDataKey
DECRYPTION BY CERTIFICATE GuestDataCert;

-- Insert example guest data
INSERT INTO Guests (guest_name, ticket_id, encrypted_credit_card, encrypted_id)
VALUES 
('John Doe', 101, ENCRYPTBYKEY(KEY_GUID('GuestDataKey'), '4111111111111111'), ENCRYPTBYKEY(KEY_GUID('GuestDataKey'), 'ABC12345')),
('Jane Smith', 102, ENCRYPTBYKEY(KEY_GUID('GuestDataKey'), '5500000000000004'), ENCRYPTBYKEY(KEY_GUID('GuestDataKey'), 'XYZ67890'));

-- Close the symmetric key
CLOSE SYMMETRIC KEY GuestDataKey;

-- Step 6: Retrieve and Decrypt Guest Data Securely
-- Open the symmetric key to decrypt sensitive data
OPEN SYMMETRIC KEY GuestDataKey
DECRYPTION BY CERTIFICATE GuestDataCert;

-- Select decrypted data for authorized users
SELECT guest_id, 
       guest_name, 
       ticket_id, 
       encrypted_credit_card,
       encrypted_id
FROM Guests;

-- Select decrypted data for authorized users
SELECT guest_id, 
       guest_name, 
       ticket_id, 
       CAST(DECRYPTBYKEY(encrypted_credit_card) AS VARCHAR(100)) AS decrypted_credit_card,
       CAST(DECRYPTBYKEY(encrypted_id) AS VARCHAR(50)) AS decrypted_id
FROM Guests;

--debug query
DROP TABLE Guests

-- TSQL19 Demo 3: Auditing Database Access and Changes

CREATE TABLE AuditLog (
    audit_id INT IDENTITY(1,1) PRIMARY KEY,
    event_time DATETIME DEFAULT GETDATE(),
    user_name NVARCHAR(100),
    action NVARCHAR(50),
    table_name NVARCHAR(100),
    statement NVARCHAR(MAX),
    session_id INT
);

-- Example: Log changes on the Guests table
CREATE TRIGGER trg_GuestsAudit
ON Guests
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @user NVARCHAR(100) = SYSTEM_USER;
    DECLARE @action NVARCHAR(50);
    DECLARE @table NVARCHAR(100) = 'Guests';
    DECLARE @session_id INT = @@SPID;

    -- Determine the action type
    IF EXISTS (SELECT 1 FROM inserted) AND EXISTS (SELECT 1 FROM deleted)
        SET @action = 'UPDATE';
    ELSE IF EXISTS (SELECT 1 FROM inserted)
        SET @action = 'INSERT';
    ELSE
        SET @action = 'DELETE';

    -- Log the event
    INSERT INTO AuditLog (user_name, action, table_name, statement, session_id)
    VALUES (@user, @action, @table, EVENTDATA().value('(/EVENT_INSTANCE/TSQLCommand/CommandText)[1]', 'NVARCHAR(MAX)'), @session_id);
END;

-- Test INSERT
INSERT INTO Guests (guest_name, ticket_id, encrypted_credit_card, encrypted_id)
VALUES ('Alice Walker', 201, ENCRYPTBYKEY(KEY_GUID('GuestDataKey'), '1234567812345678'), ENCRYPTBYKEY(KEY_GUID('GuestDataKey'), 'ID123456'));

-- Test UPDATE
UPDATE Guests
SET guest_name = 'Alice W.'
WHERE guest_name = 'Alice Walker';

-- Test DELETE
DELETE FROM Guests
WHERE guest_name = 'Alice W.';

-- Check the AuditLog table
SELECT * FROM AuditLog;


-- Optional: TSQL19 Demo 4: Implementing Data Masking for Sensitive Information
CREATE TABLE GuestSensitiveInfo (
    guest_id INT IDENTITY(1,1) PRIMARY KEY,
    guest_name NVARCHAR(100),
    email NVARCHAR(255) MASKED WITH (FUNCTION = 'email()'),
    phone_number NVARCHAR(20) MASKED WITH (FUNCTION = 'partial(2, "XXXXXX", 2)'),
    address NVARCHAR(255) MASKED WITH (FUNCTION = 'default()'),
    credit_card NVARCHAR(20) MASKED WITH (FUNCTION = 'partial(0, "XXXX-XXXX-XXXX-", 4)')
);

INSERT INTO GuestSensitiveInfo (guest_name, email, phone_number, address, credit_card)
VALUES 
('John Doe', 'john.doe@example.com', '1234567890', '123 Elm Street', '1234-5678-9012-3456'),
('Jane Smith', 'jane.smith@example.com', '9876543210', '456 Oak Avenue', '9876-5432-1098-7654');

-- Create login and users
CREATE LOGIN FullAccessUser WITH PASSWORD = 'Password123!';
CREATE LOGIN LimitedAccessUser WITH PASSWORD = 'Password123!';

USE [NEWFC];
CREATE USER FullAccessUser FOR LOGIN FullAccessUser;
CREATE USER LimitedAccessUser FOR LOGIN LimitedAccessUser;

-- Grant permissions
GRANT SELECT ON GuestSensitiveInfo TO LimitedAccessUser;
GRANT SELECT ON GuestSensitiveInfo TO FullAccessUser;

-- Grant UNMASK permission to FullAccessUser (allows viewing unmasked data)
GRANT UNMASK TO FullAccessUser;

EXECUTE AS USER = 'FullAccessUser';
SELECT * FROM GuestSensitiveInfo;

EXECUTE AS USER = 'LimitedAccessUser';
SELECT * FROM GuestSensitiveInfo;

-- TSQL19 A
-- Create a new Guests table for the purpose of this demo (table with encryption AND masking)
CREATE TABLE GuestsNEW (
    guest_id INT IDENTITY PRIMARY KEY,       -- Unique identifier for each guest
    guest_name NVARCHAR(100) MASKED WITH (FUNCTION = 'partial(1, "XXX", 1)'), -- Masked guest name
    ticket_id INT MASKED WITH (FUNCTION = 'default()'),                        -- Default masked ticket ID
    encrypted_credit_card VARBINARY(MAX),   -- Encrypted credit card information
    encrypted_id VARBINARY(MAX),            -- Encrypted government ID
    guest_email NVARCHAR(255) MASKED WITH (FUNCTION = 'email()')               -- Masked email address
);

CREATE TRIGGER trg_GuestsNEWAudit
ON GuestsNEW
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @user NVARCHAR(100) = SYSTEM_USER;
    DECLARE @action NVARCHAR(50);
    DECLARE @table NVARCHAR(100) = 'Guests';
    DECLARE @session_id INT = @@SPID;

    -- Determine the action type
    IF EXISTS (SELECT 1 FROM inserted) AND EXISTS (SELECT 1 FROM deleted)
        SET @action = 'UPDATE';
    ELSE IF EXISTS (SELECT 1 FROM inserted)
        SET @action = 'INSERT';
    ELSE
        SET @action = 'DELETE';

    -- Log the event
    INSERT INTO AuditLog (user_name, action, table_name, statement, session_id)
    VALUES (@user, @action, @table, EVENTDATA().value('(/EVENT_INSTANCE/TSQLCommand/CommandText)[1]', 'NVARCHAR(MAX)'), @session_id);
END;

--Insert seed data
OPEN SYMMETRIC KEY GuestDataKey
DECRYPTION BY CERTIFICATE GuestDataCert;
-- I have again created a new table for the purpose of this demonstration.
INSERT INTO GuestsNEW (guest_name, ticket_id, encrypted_credit_card, encrypted_id, guest_email)
VALUES 
('John Doe', 101, ENCRYPTBYKEY(KEY_GUID('GuestDataKey'), '4111111111111111'), ENCRYPTBYKEY(KEY_GUID('GuestDataKey'), 'ID987654'), 'john.doe@example.com'),
('Jane Smith', 102, ENCRYPTBYKEY(KEY_GUID('GuestDataKey'), '5500000000000004'), ENCRYPTBYKEY(KEY_GUID('GuestDataKey'), 'ID123456'), 'jane.smith@example.com'),
('Emily Johnson', 104, ENCRYPTBYKEY(KEY_GUID('GuestDataKey'), '6011000990139424'), ENCRYPTBYKEY(KEY_GUID('GuestDataKey'), 'ID456789'), 'emily.johnson@example.com'),
('Michael Brown', 105, ENCRYPTBYKEY(KEY_GUID('GuestDataKey'), '378282246310005'), ENCRYPTBYKEY(KEY_GUID('GuestDataKey'), 'ID987321'), 'michael.brown@example.com');
CLOSE SYMMETRIC KEY GuestDataKey;

-- Retrieve decrypted data securely (only for privileged users)
CREATE PROCEDURE GetDecryptedGuestData
AS
BEGIN
    -- Check if the user is in the PrivilegedRole
    IF IS_MEMBER('PrivilegedRole') = 1
    BEGIN
        OPEN SYMMETRIC KEY GuestDataKey DECRYPTION BY CERTIFICATE GuestDataCert;

        SELECT guest_id, 
               guest_name, 
               ticket_id, 
               CAST(DECRYPTBYKEY(encrypted_credit_card) AS VARCHAR(100)) AS decrypted_credit_card,
               CAST(DECRYPTBYKEY(encrypted_id) AS VARCHAR(50)) AS decrypted_id,
               guest_email
        FROM GuestsNEW;

        CLOSE SYMMETRIC KEY GuestDataKey;
    END
    ELSE
    BEGIN
        PRINT 'You do not have permission to access this data.';
    END
END;

--more seed data!
INSERT INTO GuestsNEW (guest_name, ticket_id, encrypted_credit_card, encrypted_id, guest_email)
VALUES ('Alice Walker', 103, ENCRYPTBYKEY(KEY_GUID('GuestDataKey'), '9876543210987654'), ENCRYPTBYKEY(KEY_GUID('GuestDataKey'), 'ID654321'), 'alice.walker@example.com');

--debug line
SELECT guest_id, guest_name, ticket_id, guest_email FROM GuestsNEW;

-- Add user to a custom role with elevated permissions
CREATE ROLE PrivilegedRole;

-- Add the user to the role
ALTER ROLE PrivilegedRole ADD MEMBER FullAccessUser;

-- Grant permissions to the role
GRANT EXECUTE ON GetDecryptedGuestData TO FullAccessUser;
GRANT EXECUTE ON GetDecryptedGuestData TO PrivilegedRole;
GRANT SELECT ON GuestsNEW TO PrivilegedRole;

EXECUTE AS USER = 'FullAccessUser';

--these queries are not meant to show 
SELECT * FROM sys.symmetric_keys WHERE name = 'GuestDataKey';
SELECT *  FROM sys.certificates  WHERE name = 'GuestDataCert';

--log back in as admin and run these
GRANT CONTROL ON CERTIFICATE::GuestDataCert TO FullAccessUser;
GRANT CONTROL ON CERTIFICATE::GuestDataCert TO PrivilegedRole;
GRANT CONTROL ON SYMMETRIC KEY::GuestDataKey TO FullAccessUser;
GRANT CONTROL ON SYMMETRIC KEY::GuestDataKey TO PrivilegedRole;

--both have records now
SELECT * FROM sys.symmetric_keys WHERE name = 'GuestDataKey';
SELECT *  FROM sys.certificates  WHERE name = 'GuestDataCert';

-- This basic query will show some masked columns along with encrypted columns
SELECT * FROM GuestsNEW;

-- This procedure will show the decrypted ccredit card number and personal ID rows, while showing masked or unmasked names and email columns depending on the user perms.
EXEC GetDecryptedGuestData;

--demo/debug toggle 
REVOKE UNMASK FROM FullAccessUser;
GRANT UNMASK TO FullAccessUser;

SELECT * FROM AuditLog

-- TSQL20 Demo 1: Creating INSTEAD OF Triggers
-- Create the INSTEAD OF INSERT Trigger on the Players table
-- Updated INSTEAD OF Trigger
CREATE OR ALTER TRIGGER trg_InsteadOfInsert_Players
ON Players
INSTEAD OF INSERT
AS
BEGIN
    -- Declare variables for conditional checks
    DECLARE @player_id INT, @name NVARCHAR(50), @wage DECIMAL(18, 2), @value DECIMAL(18, 2), @release_clause DECIMAL(18, 2);
    
    -- Check the values in the INSERTED pseudo-table
    SELECT 
        @player_id = player_id, 
        @name = name, 
        @wage = wage, 
        @value = value, 
        @release_clause = release_clause
    FROM inserted;

    -- Conditional Logic: Prevent insertion if name is NULL or wage/value exceeds threshold
    IF @name IS NULL
    BEGIN
        RAISERROR('Name cannot be NULL.', 16, 1);
        RETURN;
    END
    
    IF @wage > 500000 OR @value > 10000000
    BEGIN
        RAISERROR('Wage or Value exceeds allowed threshold.', 16, 1);
        RETURN;
    END

    -- Custom Handling: Set release_clause to 1.5 times value if not provided
    IF @release_clause IS NULL
    BEGIN
        SET @release_clause = @value * 1.5;
    END

    -- Custom Handling: Generate a unique player_id if not provided
    IF @player_id IS NULL
    BEGIN
        SET @player_id = (SELECT ISNULL(MAX(player_id), 0) + 1 FROM Players);
    END

    -- Insert the modified data into the Players table
    INSERT INTO Players (player_id, name, full_name, value, wage, release_clause, description, height_cm, weight_kg, dob, positions, preferred_foot, international_reputation, real_face)
    SELECT 
        @player_id, name, full_name, value, wage, @release_clause, description, height_cm, weight_kg, dob, positions, preferred_foot, international_reputation, real_face
    FROM inserted;

    PRINT 'Data successfully inserted with custom logic.';
END;
GO

SELECT * FROM Players

-- Test Case 1: Valid Input
INSERT INTO Players (name, full_name, value, wage, release_clause, description, height_cm, weight_kg, dob, positions, preferred_foot, international_reputation, real_face)
VALUES ('Player A', 'Player Alpha', 5000000, 200000, 8000000, 'A talented player', 180, 75, '1995-01-01', 'ST', 'Right', 2, 1);

-- Test Case 2: Invalid Input (name is NULL)
INSERT INTO Players (name, full_name, value, wage, release_clause, description, height_cm, weight_kg, dob, positions, preferred_foot, international_reputation, real_face)
VALUES (NULL, 'Player Beta', 3000000, 150000, 4500000, 'A promising player', 175, 70, '1998-01-01', 'MF', 'Left', 1, 1);

-- Test Case 3: Invalid Input (wage exceeds threshold)
INSERT INTO Players (name, full_name, value, wage, release_clause, description, height_cm, weight_kg, dob, positions, preferred_foot, international_reputation, real_face)
VALUES ('Player C', 'Player Gamma', 2000000, 600000, NULL, 'An experienced player', 182, 78, '1990-05-01', 'GK', 'Right', 3, 0);

-- Test Case 4: Valid Input (release_clause is NULL)
INSERT INTO Players (name, full_name, value, wage, release_clause, description, height_cm, weight_kg, dob, positions, preferred_foot, international_reputation, real_face)
VALUES ('Player D', 'Player Delta', 7000000, 300000, NULL, 'A rising star', 185, 80, '2000-08-01', 'CB', 'Right', 1, 1);

-- See result
SELECT * FROM Players WHERE name LIKE 'Player D';


-- TSQL20 Demo 2: Implementing DML Triggers for Auditing
-- Update the table to have more detailed information on the changes.
ALTER TABLE AuditLog
ADD OldValue NVARCHAR(MAX) NULL,
    NewValue NVARCHAR(MAX) NULL;
GO

-- For inserts, the NewValue column will store the data being inserted.
CREATE OR ALTER TRIGGER trg_Audit_Insert_Players
ON Players
AFTER INSERT
AS
BEGIN
    INSERT INTO AuditLog (event_time, user_name, action, table_name, statement, session_id, NewValue)
    SELECT 
        GETDATE() AS event_time,                       -- Current date and time
        SYSTEM_USER AS user_name,                     -- Current user
        'INSERT' AS action,                           -- Action type
        'Players' AS table_name,                      -- Table name
        (SELECT * FROM inserted FOR JSON AUTO) AS statement, -- Inserted data in JSON format
        @@SPID AS session_id,                         -- Current session ID
        (SELECT * FROM inserted FOR JSON AUTO) AS NewValue;  -- New data
END;
GO

-- For updates, both OldValue and NewValue will be populated with the data before and after the update.
CREATE OR ALTER TRIGGER trg_Audit_Update_Players
ON Players
AFTER UPDATE
AS
BEGIN
    INSERT INTO AuditLog (event_time, user_name, action, table_name, statement, session_id, OldValue, NewValue)
    SELECT 
        GETDATE() AS event_time,                       -- Current date and time
        SYSTEM_USER AS user_name,                     -- Current user
        'UPDATE' AS action,                           -- Action type
        'Players' AS table_name,                      -- Table name
        CONCAT(
            'OldValue: ', (SELECT * FROM deleted FOR JSON AUTO), 
            ', NewValue: ', (SELECT * FROM inserted FOR JSON AUTO)
        ) AS statement,                               -- Combined old and new data in JSON
        @@SPID AS session_id,                         -- Current session ID
        (SELECT * FROM deleted FOR JSON AUTO) AS OldValue,  -- Old data
        (SELECT * FROM inserted FOR JSON AUTO) AS NewValue; -- New data
END;
GO

-- For deletions, the OldValue column will store the data being deleted.
CREATE OR ALTER TRIGGER trg_Audit_Delete_Players
ON Players
AFTER DELETE
AS
BEGIN
    INSERT INTO AuditLog (event_time, user_name, action, table_name, statement, session_id, OldValue)
    SELECT 
        GETDATE() AS event_time,                       -- Current date and time
        SYSTEM_USER AS user_name,                     -- Current user
        'DELETE' AS action,                           -- Action type
        'Players' AS table_name,                      -- Table name
        (SELECT * FROM deleted FOR JSON AUTO) AS statement, -- Deleted data in JSON format
        @@SPID AS session_id,                         -- Current session ID
        (SELECT * FROM deleted FOR JSON AUTO) AS OldValue;  -- Old data
END;
GO

-- Verify the Changes
INSERT INTO Players (player_id, name, full_name, value, wage, release_clause, description, height_cm, weight_kg, dob, positions, preferred_foot, international_reputation, real_face)
VALUES (99997, 'Player F', 'Player Foxtrot', 7000000, 250000, 10000000, 'Test Insert with Audit', 185, 80, '1998-03-15', 'RB', 'Right', 1, 0);

-- Update Test
UPDATE Players
SET wage = 300000
WHERE player_id = 100002;

-- Delete Test
DELETE FROM Players
WHERE player_id = 99997;

-- Confirm the changes
SELECT * FROM AuditLog ORDER BY event_time DESC;

--ALTER TABLE AuditLog
--ADD ip_address NVARCHAR(45) NULL, -- IPv4 or IPv6 support
--    application_name NVARCHAR(100) NULL;
--GO

--CREATE OR ALTER PROCEDURE sp_LogAudit
--    @action NVARCHAR(50),
--    @table_name NVARCHAR(100),
--    @record_id NVARCHAR(50),
--    @old_value NVARCHAR(MAX) = NULL,
--    @new_value NVARCHAR(MAX) = NULL
--AS
--BEGIN
--    INSERT INTO AuditLog (
--        user_name, 
--        action, 
--        table_name,  
--        OldValue, 
--        NewValue, 
--        ip_address, 
--        session_id, 
--        application_name
--    )
--    VALUES (
--        SYSTEM_USER, 
--        @action, 
--        @table_name, 
--        @old_value, 
--        @new_value, 
--        CONVERT(NVARCHAR(50), CONNECTIONPROPERTY('client_net_address')), 
--        CONVERT(NVARCHAR(20), @@SPID),
--        APP_NAME()
--    );
--END;

--CREATE OR ALTER TRIGGER trg_InsteadOfInsert_Players
--ON Players
--INSTEAD OF INSERT
--AS
--BEGIN
--    -- Validation: Ensure value does not exceed threshold
--    IF EXISTS (SELECT * FROM inserted WHERE value > 50000000)
--    BEGIN
--        RAISERROR('Value exceeds allowed threshold.', 16, 1);
--        RETURN;
--    END;

--    -- Insert the new records with custom handling
--    INSERT INTO Players (
--        player_id, name, full_name, value, wage, release_clause, description, 
--        height_cm, weight_kg, dob, positions, preferred_foot, 
--        international_reputation, real_face
--    )
--    SELECT 
--        player_id, name, full_name, value, wage,
--        ISNULL(release_clause, value * 1.2), -- Custom calculation for release_clause
--        description, height_cm, weight_kg, dob, positions,
--        preferred_foot, international_reputation, real_face
--    FROM inserted;

--    -- Log all inserted records as a single JSON array
--    DECLARE @new_values NVARCHAR(MAX) = (
--        SELECT * FROM inserted FOR JSON PATH
--    );

--    EXEC sp_LogAudit 
--        @action = 'INSERT', 
--        @table_name = 'Players', 
--        @record_id = NULL,  -- NULL since we're logging multiple records
--        @new_value = @new_values;
--END;

--CREATE OR ALTER TRIGGER trg_InsteadOfInsert_Players
--ON Players
--INSTEAD OF INSERT
--AS
--BEGIN
--    -- Validation: Ensure value does not exceed threshold
--    IF EXISTS (SELECT * FROM inserted WHERE value > 50000000)
--    BEGIN
--        RAISERROR('Value exceeds allowed threshold.', 16, 1);
--        RETURN;
--    END;

--    -- Insert the new records with custom handling
--    INSERT INTO Players (player_id, name, full_name, value, wage, release_clause, description, height_cm, weight_kg, dob, positions, preferred_foot, international_reputation, real_face)
--    SELECT 
--        player_id, 
--        name, 
--        full_name, 
--        value, 
--        wage, 
--        ISNULL(release_clause, value * 1.2), -- Custom calculation for release_clause
--        description, 
--        height_cm, 
--        weight_kg, 
--        dob, 
--        positions, 
--        preferred_foot, 
--        international_reputation, 
--        real_face
--    FROM inserted;

--    -- Log the operation (new values only)
--    DECLARE @new_value NVARCHAR(MAX) = (SELECT * FROM inserted FOR JSON AUTO);
--    EXEC sp_LogAudit 
--        @action = 'INSERT', 
--        @table_name = 'Players', 
--        @record_id = (SELECT STRING_AGG(CAST(player_id AS NVARCHAR(50)), ',') FROM inserted),
--        @new_value = @new_value;
--END;

--CREATE OR ALTER TRIGGER trg_AfterDML_Players
--ON Players
--AFTER UPDATE, DELETE
--AS
--BEGIN
--    -- Handle UPDATE: Log old and new values
--    IF EXISTS (SELECT * FROM inserted)
--    BEGIN
--        DECLARE @old_value NVARCHAR(MAX) = (SELECT * FROM deleted FOR JSON AUTO);
--        DECLARE @new_value NVARCHAR(MAX) = (SELECT * FROM inserted FOR JSON AUTO);
--        DECLARE @record_id NVARCHAR(50) = (SELECT player_id FROM deleted);

--        EXEC sp_LogAudit 
--            @action = 'UPDATE', 
--            @table_name = 'Players', 
--            @record_id = @record_id, 
--            @old_value = @old_value, 
--            @new_value = @new_value;
--    END;

--    -- Handle DELETE: Log old values only
--    IF EXISTS (SELECT * FROM deleted)
--    BEGIN
--        DECLARE @old_value NVARCHAR(MAX) = (SELECT * FROM deleted FOR JSON AUTO);
--        DECLARE @record_id NVARCHAR(50) = (SELECT player_id FROM deleted);

--        EXEC sp_LogAudit 
--            @action = 'DELETE', 
--            @table_name = 'Players', 
--            @record_id = @record_id, 
--            @old_value = @old_value;
--    END;
--END;





