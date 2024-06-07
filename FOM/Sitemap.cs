using FOM;
using FOM.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

public class Sitemap
{

    static NavigationManager MyNavigationManager;
    static MyDbContext Context;
    public static string xml;

    public class post
    {
        public String name;
    }
    List<post> posts = new List<post>();

    [Parameter] public string Value { get; set; } = "";
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    private void OnChange(ChangeEventArgs e)
    {
        ValueChanged.InvokeAsync(e.Value.ToString());
    }

    private void GetuniqueBank()
    {
        DataSet ds = new DataSet();
        SqlConnection conn = new SqlConnection(Context.Database.GetConnectionString().ToString());
        conn.Open();
        SqlDataAdapter cmd = new SqlDataAdapter($"Select * from vwcategorys", conn);
        cmd.Fill(ds);
        conn.Close();

        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            post tg = new post();
            tg.name = ds.Tables[0].Rows[i]["Tags"].ToString();
            posts.Add(tg);
        }
    }
    private void GetuniqueBank1()
    {
        DataSet ds = new DataSet();
        SqlConnection conn = new SqlConnection(Context.Database.GetConnectionString().ToString());
        conn.Open();
        SqlDataAdapter cmd = new SqlDataAdapter($"Select * from vwtags", conn);
        cmd.Fill(ds);
        conn.Close();

        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            post tg = new post();
            tg.name = ds.Tables[0].Rows[i]["Tags"].ToString();
            posts.Add(tg);
        }
    }
    public void GetuniqueBank2()
    {
        DataSet ds = new DataSet();
        SqlConnection conn = new SqlConnection(Context.Database.GetConnectionString().ToString());
        conn.Open();
        SqlDataAdapter cmd = new SqlDataAdapter($"Select * from tblposts", conn);
        cmd.Fill(ds);
        conn.Close();

        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            post tg = new post();
            tg.name = ds.Tables[0].Rows[i]["Slug"].ToString();
            posts.Add(tg);
        }
    }


    public  async Task<string> GetSitemapAsync()
    {
        string header = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<urlset xmlns:image=\"http://www.google.com/schemas/sitemap-image/1.1\" xmlns=\"http://www.sitemaps.org/schemas/sitemap/0.9\">";
        string footer = "</urlset>";


        GetuniqueBank();
        GetuniqueBank1();
        GetuniqueBank2();
        string body = "";
        foreach (var post in posts)
        {
            body += $"\r\n  <url>\r\n    <loc>{MyNavigationManager.BaseUri + post.name}</loc>\r\n    <changefreq>monthly</changefreq>\r\n  </url>\r\n";
        }
        xml = header + body + footer;
        return xml;
    }

}