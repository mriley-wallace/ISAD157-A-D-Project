CREATE TABLE `isad157_mriley-wallace` . `friend`(
`user_id` INT NOT NULL,
`friend_first_name` VARCHAR (40) NOT NULL,
`friend_last_name` VARCHAR (40) NOT NULL,
PRIMARY KEY (`user_id`),
FOREIGN KEY (`friend_first_name`) References users(`first_name`),
FOREIGN KEY (`friend_last_name`) References users(`last_name`)
On Delete CASCADE
On Update CASCADE)