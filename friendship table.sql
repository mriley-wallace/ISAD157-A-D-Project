CREATE TABLE `isad157_mriley-wallace` . `friendship`(
`user_id` INT NOT NULL,
`friend_id` INT NOT NULL,
PRIMARY KEY (`user_id`),
FOREIGN KEY (`friend_id`) References users(`user_id`)


On Delete CASCADE
On Update CASCADE)