Dominion Enterprises Clean Code Challenge!
=========

## Overview

The purpose of this exercise is to demonstrate familiarity with automated testing, design patterns, source control and the Microsoft .NET stack.

## Project Description

This project is a Visual Studio 2017 project using .NET Framework 4.6.2 and MVC5. It also uses Entity Framework Migrations.

The project uses a LocalDB database, which is included with the project (in the App_Data folder).

## Objective

Take this out of the box MVC application and apply best practices. The application currently consists of one project that contains all of the entities, contexts, migrations, controllers, views and other front end content. The controllers are out of the box Visual Studio scaffolding, and passing entities directly to the views. Controllers have querying (Linq) logic directly inside of them, classes are tightly coupled and highly dependent on each other and there are no unit tests.

Clean up this application, applying best practices and accomplishing as much as you can within 2 hours. You can use whatever design pattern you want, but there should be no tightly coupled classes and seperation of concerns while minimalizing dependencies. For example, the data layer should not be mixed with the UI layer, and the UI layer should not depend on the entities of the data layer.

Once complete, submit your changes in form of a pull request to the master branch of this repository, and send an email to Rich Garabedian, Will Carpin or myself (Dean Swiatek).
