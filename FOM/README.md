# FOM
This is online movies or tv series download script in BLAZOR SSR (Server Side)

#Database
To Setup the database i have provided the FOM.sql in the project just run this on your SQL Server (2022) or Latest. 
Currently the only way to add movies or posts is to manualy add through the database. but you can make your on software to do that. i have made one.

#Instruction
Change the connection string in appsettings.json and sitemaplinks.cs. 
You can comment out the SaveViews.Save function to store views.
The Database has some dummy data so you can check it out.
Also to store series episodes you have to check the tblSeries, to know how Episodes are stored.


#Features
-Sitemap generater
-Dynamic links
-automaticaly search the movie on google and get there IMDBid and TMDBid to view in the player.
-Save user views
-Searching is also a bit accurate
-Search results also get torrents in real time
-there is also an AI that search movies through different website (Although it didn't work much on that).



