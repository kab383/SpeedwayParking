# SpeedwayParking
A parking pass ticketing platform designed for the Indianapolis Motor Speedway.
## Table Of Contents
1. About the project
2. Technologies used in development
3. Installation
4. How to use the platform
5. Future versions
6. Contributors

# About the project
SpeedwayParking is a personal project loosely inspired by the Indianapolis Motor Speedway ticketing website. I am a passionate fan of racing and utilized this opportunity to merge passion and career development through the creation of this MVC. Currently, this project is not intended for live use, but under the assumption that it will be deployed it aims to achieve the two primary goals:
1. Ease of use. Front End Perspective: Many ticketing platforms are easily bogged down by busy webpages. SpeedwayParking will be created with intention to declutter the page and make the application easy to read and operate while walking through a ticket purchase. Back End Perspective: The application should do a lot of the legwork for the user. Purchasing a ticket will be as simple as viewing your event, clicking your event of choice, easily identify how many available spots are for your vehicle type, and then making the purchase.
2. Information ready. This application will have information readily available for the user by offering up all parking details relating to their ticket purchase. For example, when the user purchases a ticket for RV parking, they will know if there are showers available, if tailgating is allowed, if there is electrical available, etc. This is key as these attributes change regularly depending on the type of event that the user is attending. So, having that information available at the time of purchase is critical and beneficial.

# Database Design (optional read)
In order to achieve a deeper understanding of this application, it's beneficial to know the thought process behind the design, which begins with the schema. I have created the 6 tables below and provided descriptions of each:
1. Event
2. Lot
3. EventLot
4. LotStandardConfig
5. Ticket
6. Wishlist

# Technologies used in development
SpeedwayParking was planned and designed using dbdiagram schemas, trello planning boards, and bitai documents. The application itself was built with the C# language, Microsoft ASP.net core, HTML, CSS, Microsoft Azure & SQL, and Docker Container. It was built in Visual Studio 2022 and utilized GitHub for version control.

# Installation
No installation required as this is a web application. It can be accessed directly through a URL that will be pasted here once the project is complete.

# How to use the platform
## As an Admin
Currently, all functionality is driven by manual input from the administrator. I aim to develop methods that will automate a large majority of manual input in future versions. Getting started, you will want to register your account as an administrator and log in. Once signed in, you will have access to pages that the general userbase does not have access to. These pages include Creating, Editing, and Deleting Events, Lots, 
