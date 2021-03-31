# Synthesized Blazor Solutions with SQL Server

*Write a REST API service by inheritance to dramatically reduce lines of code in data services with Microsoft SQL Server.*

Microsoft SQL Server is a powerful data manager that I have programmed for decades. Of course, its inherent relationship with technology .NET Framework and .NET Core (now without Core), makes it one of the best options for this ecosystem. This article focuses on showing a strategy to achieve reusable code for solutions with SQL Server and Blazor. You may not have seen something like this:

A CRUD can be implemented in very few lines, and can be reused for different model classes, which are themselves the representation of a table in Sql Server. Of course, an extension is desirable so as not to stay in a single rule frame. This article also covers that leak. It is worth clarifying that the server code can also be used in an ASP: NET Core solution, it is not exclusive to the Blazor server.



This article is published in [Blazor Spread Blog](https://www.blazorspread.net/blogview/22) (languages EN, ES, DE)

Licencia MIT
