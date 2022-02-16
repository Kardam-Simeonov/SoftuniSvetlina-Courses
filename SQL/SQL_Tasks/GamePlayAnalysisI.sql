CREATE TABLE Activity(
	player_id int,
	device_id int,
	event_date date,
	games_played int
);

ALTER TABLE Activity
ADD CONSTRAINT PK_Activity PRIMARY KEY (player_id, event_date);



