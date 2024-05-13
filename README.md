# Flex Trainer - Gym Desktop Application

Welcome to Flex Trainer, a comprehensive gym management system designed to streamline operations for gym owners, trainers, and members. This application, built using Windows Forms and integrated with a Microsoft SQL Server database, offers a range of features to facilitate fitness goal management, workout planning, diet tracking, and personal training sessions booking.

## Features

### Member Interface
1. **Registration and Login**: Seamlessly register and log in to access personalized fitness plans and training sessions.
2. **Workout Planning**: Create customized workout plans tailored to individual fitness goals, specifying muscle groups, exercises, sets, reps, and rest intervals.
3. **Workout Plan Reports**: Explore a variety of workout plans categorized by goals, schedule, and experience level, and filter plans based on multiple attributes.
4. **Diet Planning**: Manage nutrition and dietary intake with personalized diet plans, including meal details, nutritional values, and allergens.
5. **Diet Plan Selection**: Choose from a range of existing diet plans curated by users or trainers, filtering plans based on diet type, purpose, nutrition, and creator.
6. **Personal Training Sessions Booking**: Schedule one-on-one training sessions with preferred trainers to receive personalized guidance and support.
7. **Trainer Feedback**: Provide feedback about trainers to assign ratings and improve service quality.

### Trainer Interface
1. **Registration and Login**: Register or log in, with registration requests sent to gym owners for verification.
2. **Diet Planning**: Create customized diet plans for clients, including meal details, nutritional values, and allergens.
3. **Diet Plan Selection**: Choose from existing diet plans curated by users or trainers, filtering based on various attributes.
4. **Personal Training Sessions Booking**: Offer personal training sessions, allowing users to schedule sessions for personalized guidance.
5. **Trainer Feedback**: Receive feedback from users to improve service quality and maintain high ratings.

### Gym Owner Interface
1. **Registration and Login**: Register or log in, with registration requests sent to administrators for approval.
2. **Member Reports**: Access detailed reports on gym members, including membership duration, type, and related information.
3. **Trainer Reports**: View comprehensive reports on trainers' performance, ratings, experience, and client management.
4. **Adding New Trainers**: Add new trainers to the platform, providing necessary details for qualifications, experience, and specialties.
5. **Account Management**: Manage member and trainer accounts, including activation, deactivation, or deletion as needed.

### Admin Interface
1. **Login**: Secure access for administrators to manage the entire system.
2. **Performance of Different Gyms**: Access reports detailing the performance metrics of different gym locations.
3. **Approve Gym Registration Requests**: Review and approve registration requests from new gym locations, ensuring compliance and integration.
4. **Revoke Gym Memberships**: Deactivate or remove gym locations from the network as necessary, maintaining system integrity.

## Installation

1. Clone the repository to your local machine.
2. Open the project in Visual Studio 2022.
3. Ensure Microsoft SQL Server 2019 is installed and configured.
4. Import the provided SQL queries to create and populate the database.
5. Build and run the application to start using Flex Trainer.

## Database Design

The database schema is designed to maintain data integrity and support the functionality of the application. It includes tables for users, trainers, gyms, workout plans, diet plans, training sessions, and more. Relationships between entities are established to ensure seamless data management.

## Contributing

Contributions to enhance the functionality and usability of Flex Trainer are welcome! If you'd like to contribute, please follow the project guidelines and submit a pull request with your changes.
