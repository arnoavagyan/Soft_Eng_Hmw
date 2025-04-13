# Soft_Eng_Hmw

# Description
This respository contains homework assignment of software engineering course.
The purpose of the homework is to create 3-layered architechture with NATS, 
in order to save messages in the database system.

# Content
The repository contains 3 main folders(for each layer) and solution file.
1. API level is responsible for starting the program, reading messages, passing to NATS service.
2. Business level is responsible for validation of the messages and transfer to the DATA layer.
3. DATA layer is responsible for saving input message in the database.
All interfaces are separated from the main classes and located in the implementation sub-folders.

# Installation Guide
In order to run this project, following steps needs to be done:
1. Download NATS from the following link: https://nats.io/download/
2. Have installed PostgreSql
3. Run downloaded .exe file of NATS and save connection string
4. Paste the connection string in Program.cs file as a part of connection variable.
5. Run setup.sql file.
6. Change connection string of database system in MessageService.cs file as a connection variable based on the provided pattern.
7. Build the solution file
