using FOM.Components.Pages;
using FOM.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Net;
using System.Net.NetworkInformation;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace FOM
{
    public class SaveViews
    {
        private static string IPAddress { get; set; }
        
        public static void Save(string page, IHttpContextAccessor HttpContextAccessor, MyDbContext Context) 
        {
            

            //var ipAddress = HttpContextAccessor.HttpContext.Connection.RemoteIpAddress.ToString();
            //IPAddress = ipAddress?.ToString() ?? "Unknown";


            //var userAgent = HttpContextAccessor.HttpContext.Request.Headers.UserAgent.ToString();
            //var (userbrowser, userdevice) = UserAgentParser.ParseUserAgent(userAgent);

            //SqlConnection Conn = new SqlConnection(Context.Database.GetConnectionString().ToString());
            //if (Conn.State == ConnectionState.Closed)
            //{
            //    Conn.Open();
            //}
            //SqlCommand cmd = new SqlCommand("INSERT INTO OEXAM.dbo.tblViews(website,page,userip,usersystem,userbrowser,userAgent) VALUES(@website,@page,@userip,@usersystem,@userbrowser,@userAgent)", Conn);

            //cmd.Parameters.AddWithValue("@website", "elmovies.com");
            //cmd.Parameters.AddWithValue("@page", page);
            //cmd.Parameters.AddWithValue("@userip", IPAddress);
            //cmd.Parameters.AddWithValue("@usersystem", userdevice);
            //cmd.Parameters.AddWithValue("@userbrowser", userbrowser);
            //cmd.Parameters.AddWithValue("@useragent", userAgent);
            //cmd.ExecuteNonQuery();
            //Conn.Close();
        }

        internal class BG
        {
           
        }
    }
    public class UserAgentParser
    {
        public static (string browser, string device) ParseUserAgent(string userAgent)
        {
            // Default values
            string browser = "Unknown";
            string device = "Unknown";

            if (userAgent.Contains("Edge") || userAgent.Contains("Edg"))
            {
                browser = "Edge";
            }
            else if (userAgent.Contains("Chrome"))
            {
                browser = "Chrome";
            }
            else if (userAgent.Contains("Safari"))
            {
                browser = "Safari";
            }
            else if (userAgent.Contains("Firefox"))
            {
                browser = "Firefox";
            }
            // Add more browser detections as needed

            if (userAgent.Contains("Android"))
            {
                device = "Android";
            }
            else if (userAgent.Contains("iPhone") || userAgent.Contains("iPad") || userAgent.Contains("iPod"))
            {
                device = "iOS";
            }
            else if (userAgent.Contains("Windows"))
            {
                device = "Windows";
            }
            else if (userAgent.Contains("Mac"))
            {
                device = "Mac";
            }
            else if (userAgent.Contains("Linux"))
            {
                device = "Linux";
            }
            // Add more device detections as needed

            return (browser, device);
        }
    }

}
