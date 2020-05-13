CREATE TABLE `isad157_mriley-wallace` . `messages`(
`friend_id` INT NOT NULL AUTO_INCREMENT,
`user_id` INT NOT NULL,
`date_time` VARCHAR(100),
`message_text` VARCHAR(5000),

FOREIGN KEY(`user_id`)references `users`(`user_id`),
FOREIGN KEY(`friend_id`)references `users`(`user_id`)
On Delete CASCADE
On Update CASCADE
);