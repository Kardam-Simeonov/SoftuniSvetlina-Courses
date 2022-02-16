CREATE TABLE Activity(
	player_id int NOT NULL,
	device_id int,
	event_date date NOT NULL,
	games_played int
);

ALTER TABLE Activity
ADD PRIMARY KEY (player_id, event_date);	

SELECT player_id, MIN(event_date) AS first_login
FROM Activity
GROUP BY player_id; 






