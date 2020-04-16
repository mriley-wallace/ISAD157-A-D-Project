CREATE TABLE `isad157_mriley-wallace` . `message-content`(
`user_id` INT NOT NULL,
`friend_id` INT NOT NULL,
`dateTime` VARCHAR(40) NOT NULL,
`messageText` VARCHAR(1000) NOT NULL,
PRIMARY KEY (`user_id`),
FOREIGN KEY (`friend_id`) References users(`user_id`)

On Update CASCADE
On Delete CASCADE)