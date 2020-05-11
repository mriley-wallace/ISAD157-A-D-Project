CREATE TABLE `sys` . `worker`(
`user_id` INT NOT NULL AUTO_INCREMENT,
`workplace_id` INT NOT NULL,
`start_date` VARCHAR(40) NOT NULL,
`end_date` VARCHAR(40) NOT NULL,
FOREIGN KEY (`user_id`)references `users`(`user_id`),
FOREIGN KEY (`workplace_id`) references `workplace`(`workplace_id`)
On Delete CASCADE
On Update CASCADE
);