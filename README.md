
# FOM (Free Online Movies)

This is online movies or tv series download script in BLAZOR SSR (Server Side)


## Deployment

To deploy this project run

```bash
  Open VS and hit start
```
## Requirements
- Blazor - SSR
- IIS Hosting
- MS SQL Server 2022

## Database
To Setup the database i have provided the FOM.sql in the project just run this on your SQL Server (2022) or Latest. 
Currently the only way to add movies or posts is to manualy add through the database. but you can make your on software to do that. i have made one.

## Instruction
- Change the connection string in appsettings.json and sitemaplinks.cs. 
- You can comment out the SaveViews.Save function to store views.
- The Database has some dummy data so you can check it out.
- Also to store series episodes you have to check the tblSeries, to know how Episodes are stored.

