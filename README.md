Dominion Enterprises Clean Code Challenge!
=========

## Overview

The purpose of this exercise is to demonstrate familiarity with automated testing, design patterns, source control and the Microsoft .NET stack.

## Project Description

This project is a Visual Studio 2017 project using .NET Framework 4.6.2 and MVC5. It also uses Entity Framework Migrations.

The project uses a LocalDB database, which is included with the project (in the App_Data folder).

## Objective

Take this out of the box MVC application and apply best practices. The application currently consists of one project that contains all of the entities, contexts, migrations, controllers, views and other front end content. The controllers are out of the box Visual Studio scaffolding, and passing entities directly to the views. Controllers have querying (Linq) logic directly inside of them, classes are tightly coupled and highly dependent on each other and there are no unit tests.

Clean up this application, applying best practices and accomplishing as much as you can within 2 hours. Anything that you cannot accomplish in the 2 hours, feel free to take note of and discuss later. You can use whatever design pattern you want as long as it's following best practices.

Once complete, submit your changes in form of a pull request to the master branch of this repository, and send an email to Rich Garabedian (richard.garabedian@drivedominion.com) and cc myself (dean.swiatek@drivedominion.com)/

## Bonus

Submit a second pull request that will not allow the user to save a cat with the same breed and name. If a match already exists, the user should be taken to the create/edit form with an appropriate message. Then add the appropriate test. So if a cat named Tony, a Tiger currently exists, the user could not add another Tiger named Tony (but they could add a black cat named Tony).
