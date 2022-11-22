# SpeedwayParking
A parking pass ticketing platform designed for the Indianapolis Motor Speedway.
## Table Of Contents
1. About the project
2. Technologies used in development
3. Installation
4. How to use the platform
5. Future versions
6. Contributors and contact info

# About the project
SpeedwayParking is a personal project loosely inspired by the Indianapolis Motor Speedway ticketing website. I am a passionate fan of racing and utilized this opportunity to merge passion and career development through the creation of this MVC. Currently, this project is not intended for live use, but under the assumption that it will be deployed it aims to achieve the two primary goals:
1. Ease of use. Front End Perspective: Many ticketing platforms are easily bogged down by busy webpages. SpeedwayParking will be created with intention to declutter the page and make the application easy to read and operate while walking through a ticket purchase. Back End Perspective: The application should do a lot of the legwork for the user. Purchasing a ticket will be as simple as viewing your event, clicking your event of choice, easily identify how many available spots are for your vehicle type, and then making the purchase.
2. Information ready. This application will have information readily available for the user by offering up all parking details relating to their ticket purchase. For example, when the user purchases a ticket for RV parking, they will know if there are showers available, if tailgating is allowed, if there is electrical available, etc. This is key as these attributes change regularly depending on the type of event that the user is attending. So, having that information available at the time of purchase is critical and beneficial.

# Database Design (optional read)
In order to achieve a deeper understanding of this application, it's beneficial to know the thought process behind the design, which begins with the schema. I have created the 6 tables below and provided descriptions of each:
1. Event: Provides basic information about the event to the user. Data types of DateTime are useful in telling the user when the event begins and ends, but also will be utilized in future versions for automated back end functionality, by self-assigning true or false value to the daily and overnight properties of the EventLot table.
2. Lot: Contains information about the lot such as name, nearest entrance, and ground surface type (asphault, grass, dirt, etc.) It is connected to both LotStandardConfig and EventLot in order to have a standard configuration of parking spaces, but also other attributes that can change depending on the event.
3. EventLot: Connects tables Event and Lot using a compound key (LotId and EventId). Using this compound key, we can update the characterstics of the lot based on the type of event that is taking place. For example, if the event is a multi-day overnight event, we will likely want to allocate more RV spaces per lot and have more showers and electrical opened up for use in good working condition.
4. LotStandardConfig: Since each Event will have a different Lot configuration that is held in EventLot, I decided to implement a standard configuration for the number of spaces that a lot will have. That way, admin can opt to select the standard config if it is suitable for the event.
5. Ticket: Where the user will be able to purchase a ticket based on the selected event and lot. Attributes of the EventLot will be pulled in to let the user know what the characteristics of the lot will look like.
6. Wishlist: The container that stores tickets the user is interested in. This acts as a "Shopping Cart". This table is connected to the user through a foreign key of UserId that will have an added layer of security utilizing the Guid Data type.

# Technologies used in development
SpeedwayParking was planned and designed using dbdiagram schemas, trello planning boards, and bitai documents. The application itself was built with the C# language, Microsoft ASP.net core, HTML, CSS, Microsoft Azure & SQL, and Docker Container. It was built in Visual Studio 2022 and utilized GitHub for version control.

# Installation
No installation required as this is a web application. It can be accessed directly through a URL that will be pasted here once the project is complete.

# How to use the platform
## As an Admin
Currently, all functionality is driven by manual input from the administrator. I aim to develop methods that will automate a large majority of manual input in future versions. Getting started, you will want to register your account as an administrator and log in. Once signed in, you will have access to pages that the general userbase does not have access to. These pages give you the ability to view, create, edit, and delete. In particular, you will be perfomring these actions on Event, Lot, LotStandardConfig, and EventLot.
## As a User
When you click on the URL you will arrive at our landing page. Initially, we plan on displaying only the next upcoming event on the landing page, and all other actions from there will be handled up in the NavBar. In the NavBar you will find tabs for registering an account, logging in, and navigating to the Event, Ticket, and Wishlist pages. On the Event page you will see the top 10 upcoming events. Click on "See All Events" to see all of the events for the calendar year. Each event will have a "Wishlist Ticket" option, where you can select, and it brings you to the ticketing page. On the ticketing page you will be able to select your lot, and parking space type for the event you're viewing. If you did not come from the Event page, then you will first need to select your event on the Ticket page before accessing the other options. Once you have the ticket you're wishing to purchase you will hit the Wishlist button. Navigate to the Wishlist tab, and that will take you to a page where you can then view all of your wishlisted items, including the one you just wishlisted. The Wishlist table is in place of a purchase feature. It essentially acts as a shopping cart. Since this application is not deployed I do not have an option to set up real transactions. And that's it! Those are our features and how to use them. As stated in the About section, this platform was designed to be easy and provide you only the information you need and want without clutter.

# Future versions
At the time of writing this I am at v0.7 with plans to be at V1 shortly. There is a lot of back end legwork that is driving the length of time to get the application up and running. Future versions will provide more seamless navigation through the application, better page layouts, and also more automated functionality driven by back end code. In addition to functionality, future versions will also come with significantly more styling to fit the brand of IMS.

# Contributors and contact info
Sole Contributor: Kristian Beall
GitHub link: https://github.com/kab383
Gmail: beallkristian@gmail.com

Please reach out to me with any questions or concerns. Thank you for taking the time to learn about my project.
