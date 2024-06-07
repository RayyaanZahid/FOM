using FOM.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace FOM
{
    public class Sitemaplinks
    {
        string hostname = "https://elmovies.com/";
        public static string xml;
        SqlConnection conn = new SqlConnection("Data Source=66.165.248.146\\MSSQLSERVER2022;Initial Catalog=OEXAM;User ID=azeznexam;Password=hasray786...;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");
        public  class post
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
            
            conn.Open();
            SqlDataAdapter cmd = new SqlDataAdapter($"Select * from vwcategorys", conn);
            cmd.Fill(ds);
            conn.Close();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                post tg = new post();
                tg.name = "Category/"+ds.Tables[0].Rows[i]["Tags"].ToString().Trim().Replace(" ", "");
                posts.Add(tg);
          
            
            }
        }
        private void GetuniqueBank3(int index)
        {
            DataSet ds = new DataSet();

            conn.Open();
            SqlCommand cmdchk = new SqlCommand("Select Count(*) from vwseries", conn);
            int tot = (int)cmdchk.ExecuteScalar();
            int tbl = (int)(tot / 20);
            SqlDataAdapter cmd = new SqlDataAdapter($"Select * from Oexam.azeznexam.vwSeries ORDER BY dateinserted OFFSET  {tbl * index} ROWS FETCH NEXT {tbl} ROWS ONLY", conn);
            cmd.Fill(ds);
            conn.Close();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                post tg = new post();
                tg.name = "w/" + ds.Tables[0].Rows[i]["Slug"].ToString().Trim().Replace(" ", "");
                posts.Add(tg);
            }
        }
        private void GetuniqueBank1()
        {
            DataSet ds = new DataSet();
            conn.Open();
            SqlDataAdapter cmd = new SqlDataAdapter($"Select * from vwtags", conn);
            cmd.Fill(ds);
            conn.Close();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                post tg = new post();
                tg.name = "Tag/" + ds.Tables[0].Rows[i]["Tags"].ToString().Trim().Replace(" ","");
                posts.Add(tg);
            }
        }
        public void GetPost(int index)
        {
           
            DataSet ds = new DataSet();
            conn.Open();
            SqlCommand cmdchk = new SqlCommand("Select Count(*) from vwPosts", conn);
            int tot = (int)cmdchk.ExecuteScalar();
            int tbl = (int)(tot / 50);
            SqlDataAdapter cmd = new SqlDataAdapter($"SELECT  * FROM vwPosts ORDER BY dateinserted OFFSET  {tbl* index} ROWS FETCH NEXT {tbl} ROWS ONLY", conn);
            cmd.Fill(ds);
            conn.Close();
           
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                post tg = new post();
                tg.name = ds.Tables[0].Rows[i]["Slug"].ToString().Trim();
                posts.Add(tg);
            }
        }
        public  async Task<string> Getlinks()
        {
            string header = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<urlset xmlns:image=\"http://www.google.com/schemas/sitemap-image/1.1\" xmlns=\"http://www.sitemaps.org/schemas/sitemap/0.9\">";
            string footer = "</urlset>";


            GetuniqueBank();
            GetuniqueBank1();
            GetPost(0);
            GetuniqueBank3(0);
            string body = "";
            foreach (var post in posts)
            {
                body += $"\r\n  <url>\r\n    <loc>{hostname+ post.name}</loc>\r\n    <changefreq>daily</changefreq>\r\n  </url>\r\n";
            }
            string xml = header + body + footer;
            return xml;
        }
        public async Task<string> GetCatlinks()
        {
            string header = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<urlset xmlns:image=\"http://www.google.com/schemas/sitemap-image/1.1\" xmlns=\"http://www.sitemaps.org/schemas/sitemap/0.9\">";
            string footer = "</urlset>";

            posts.Clear();
            GetuniqueBank();
           
            string body = "";
            foreach (var post in posts)
            {
                body += $"\r\n  <url>\r\n    <loc>{hostname + post.name.Replace("&","-")}</loc>\r\n    <changefreq>daily</changefreq>\r\n  </url>\r\n";
            }
            string xml = header + body + footer;
            return xml;
        }
        public async Task<string> GetTaglinks()
        {
            string header = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<urlset xmlns:image=\"http://www.google.com/schemas/sitemap-image/1.1\" xmlns=\"http://www.sitemaps.org/schemas/sitemap/0.9\">";
            string footer = "</urlset>";

            posts.Clear();
            GetuniqueBank1();
         
            string body = "";
            foreach (var post in posts)
            {
                body += $"\r\n  <url>\r\n    <loc>{hostname + post.name.Replace("&", "-")}</loc>\r\n    <changefreq>daily</changefreq>\r\n  </url>\r\n";
            }
            string xml = header + body + footer;
            return xml;
        }
        public async Task<string> GetPostlinks(int index)
        {
            string header = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<urlset xmlns:image=\"http://www.google.com/schemas/sitemap-image/1.1\" xmlns=\"http://www.sitemaps.org/schemas/sitemap/0.9\">";
            string footer = "</urlset>";


            posts.Clear();
            GetPost(index-1);

            string body = "";
            foreach (var post in posts)
            {
                body += $"\r\n  <url>\r\n    <loc>{hostname + post.name}</loc>\r\n    <changefreq>daily</changefreq>\r\n  </url>\r\n";
            }
            string xml = header + body + footer;
            return xml;
        }
        public async Task<string> GetSerieslinks(int index)
        {
            string header = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<urlset xmlns:image=\"http://www.google.com/schemas/sitemap-image/1.1\" xmlns=\"http://www.sitemaps.org/schemas/sitemap/0.9\">";
            string footer = "</urlset>";


            posts.Clear();
            GetuniqueBank3(index-1);
            string body = "";
            foreach (var post in posts)
            {
                body += $"\r\n  <url>\r\n    <loc>{hostname + post.name}</loc>\r\n    <changefreq>daily</changefreq>\r\n  </url>\r\n";
            }
            string xml = header + body + footer;
            return xml;
        }

        public static async Task<string> Getlinks2()
        {
            Sitemaplinks instance = new Sitemaplinks();
           string xml = await instance.Getlinks();
            return xml;
        }
        public static async Task<string> GetCategory()
        {
            Sitemaplinks instance = new Sitemaplinks();
            string xml = await instance.GetCatlinks();
            return xml;
        }
        public static async Task<string> GetTag()
        {
            Sitemaplinks instance = new Sitemaplinks();
            string xml = await instance.GetTaglinks();
            return xml;
        }
        public static async Task<string> GetPosts(int index)
        {
            Sitemaplinks instance = new Sitemaplinks();
            string xml = await instance.GetPostlinks(index);
            return xml;
        }
        public static async Task<string> GetSeries(int index)
        {
            Sitemaplinks instance = new Sitemaplinks();
            string xml = await instance.GetSerieslinks(index);
            return xml;
        }
        public static async Task<string> Getrobots()
        {
            string hostname = "https://elmovies.com/";
            string tzt = "User-agent: * \n" +
                $"Sitemap: {hostname}sitemap_categorys.xml \n"+
                $"Sitemap: {hostname}sitemap_tags.xml \n";
            for(int i=1;i <= 51;i++)
                tzt += $"Sitemap: {hostname}sitemap_posts_{i}.xml \n";

            for (int i = 1; i <= 21; i++)
                tzt += $"Sitemap: {hostname}sitemap_series_{i}.xml \n";

            return tzt;
        }
        public static async Task<string> Getgoogle()
        {
            //string hostname = "https://elmovies.com/";
            string tzt = "google-site-verification: google77317a7b1289af0d.html";

            return tzt;
        }
    }
}
