CREATE TABLE `isad157_mriley-wallace` . `student`(
`user_id` INT NOT NULL AUTO_INCREMENT,
`education_id` INT NOT NULL,
`start_date` VARCHAR(40) NOT NULL,
`end_date` VARCHAR(40) NOT NULL,
FOREIGN KEY (`user_id`)references `users`(`user_id`),
FOREIGN KEY (`education_id`) references `education`(`education_id`)
On Delete CASCADE
On Update CASCADE
);