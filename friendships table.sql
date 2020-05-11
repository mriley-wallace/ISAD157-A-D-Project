CREATE TABLE `sys` . `friendships`(
`user_id` INT NOT NULL AUTO_INCREMENT,
`friend_id` INT NOT NULL,

FOREIGN KEY(`user_id`)references `users`(`user_id`),
FOREIGN KEY(`friend_id`)references `users`(`user_id`)
On Delete CASCADE
On Update CASCADE
);