using DynamicSitemap.Classes.Utils;
using DynamicSitemap.Helpers;
using FOM;
using FOM.Components;
using FOM.Components.backup;
using FOM.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using MyProject.Utils;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
	.AddInteractiveServerComponents();

builder.Services.AddScoped<ICookie, Cookie>();
builder.Services.AddScoped<IXmlContentService, XmlContentService>();
builder.Services.AddHttpContextAccessor();


builder.Services.AddDbContext<MyDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AzeznConn")));



var app = builder.Build();

app.MapGet("/robots.txt", () => Sitemaplinks.Getrobots());
app.MapGet("/google77317a7b1289af0d.html", () => Sitemaplinks.Getgoogle());

app.MapGet("/sitemap.xml", () => Sitemaplinks.Getlinks2());
app.MapGet("/sitemap_categorys.xml", () => Sitemaplinks.GetCategory());
app.MapGet("/sitemap_tags.xml", () => Sitemaplinks.GetTag());

app.MapGet("/sitemap_posts_1.xml", () => Sitemaplinks.GetPosts(1));
app.MapGet("/sitemap_posts_2.xml", () => Sitemaplinks.GetPosts(2));
app.MapGet("/sitemap_posts_3.xml", () => Sitemaplinks.GetPosts(3));
app.MapGet("/sitemap_posts_4.xml", () => Sitemaplinks.GetPosts(4));
app.MapGet("/sitemap_posts_5.xml", () => Sitemaplinks.GetPosts(5));
app.MapGet("/sitemap_posts_6.xml", () => Sitemaplinks.GetPosts(6));
app.MapGet("/sitemap_posts_7.xml", () => Sitemaplinks.GetPosts(7));
app.MapGet("/sitemap_posts_8.xml", () => Sitemaplinks.GetPosts(8));
app.MapGet("/sitemap_posts_9.xml", () => Sitemaplinks.GetPosts(9));
app.MapGet("/sitemap_posts_10.xml", () => Sitemaplinks.GetPosts(10));
app.MapGet("/sitemap_posts_11.xml", () => Sitemaplinks.GetPosts(11));
app.MapGet("/sitemap_posts_12.xml", () => Sitemaplinks.GetPosts(12));
app.MapGet("/sitemap_posts_13.xml", () => Sitemaplinks.GetPosts(13));
app.MapGet("/sitemap_posts_14.xml", () => Sitemaplinks.GetPosts(14));
app.MapGet("/sitemap_posts_15.xml", () => Sitemaplinks.GetPosts(15));
app.MapGet("/sitemap_posts_16.xml", () => Sitemaplinks.GetPosts(16));
app.MapGet("/sitemap_posts_17.xml", () => Sitemaplinks.GetPosts(17));
app.MapGet("/sitemap_posts_18.xml", () => Sitemaplinks.GetPosts(18));
app.MapGet("/sitemap_posts_19.xml", () => Sitemaplinks.GetPosts(19));
app.MapGet("/sitemap_posts_20.xml", () => Sitemaplinks.GetPosts(20));
app.MapGet("/sitemap_posts_21.xml", () => Sitemaplinks.GetPosts(21));
app.MapGet("/sitemap_posts_22.xml", () => Sitemaplinks.GetPosts(22));
app.MapGet("/sitemap_posts_23.xml", () => Sitemaplinks.GetPosts(23));
app.MapGet("/sitemap_posts_24.xml", () => Sitemaplinks.GetPosts(24));
app.MapGet("/sitemap_posts_25.xml", () => Sitemaplinks.GetPosts(25));
app.MapGet("/sitemap_posts_26.xml", () => Sitemaplinks.GetPosts(26));
app.MapGet("/sitemap_posts_27.xml", () => Sitemaplinks.GetPosts(27));
app.MapGet("/sitemap_posts_28.xml", () => Sitemaplinks.GetPosts(28));
app.MapGet("/sitemap_posts_29.xml", () => Sitemaplinks.GetPosts(29));
app.MapGet("/sitemap_posts_30.xml", () => Sitemaplinks.GetPosts(30));
app.MapGet("/sitemap_posts_31.xml", () => Sitemaplinks.GetPosts(31));
app.MapGet("/sitemap_posts_32.xml", () => Sitemaplinks.GetPosts(32));
app.MapGet("/sitemap_posts_33.xml", () => Sitemaplinks.GetPosts(33));
app.MapGet("/sitemap_posts_34.xml", () => Sitemaplinks.GetPosts(34));
app.MapGet("/sitemap_posts_35.xml", () => Sitemaplinks.GetPosts(35));
app.MapGet("/sitemap_posts_36.xml", () => Sitemaplinks.GetPosts(36));
app.MapGet("/sitemap_posts_37.xml", () => Sitemaplinks.GetPosts(37));
app.MapGet("/sitemap_posts_38.xml", () => Sitemaplinks.GetPosts(38));
app.MapGet("/sitemap_posts_39.xml", () => Sitemaplinks.GetPosts(39));
app.MapGet("/sitemap_posts_40.xml", () => Sitemaplinks.GetPosts(40));
app.MapGet("/sitemap_posts_41.xml", () => Sitemaplinks.GetPosts(41));
app.MapGet("/sitemap_posts_42.xml", () => Sitemaplinks.GetPosts(42));
app.MapGet("/sitemap_posts_43.xml", () => Sitemaplinks.GetPosts(43));
app.MapGet("/sitemap_posts_44.xml", () => Sitemaplinks.GetPosts(44));
app.MapGet("/sitemap_posts_45.xml", () => Sitemaplinks.GetPosts(45));
app.MapGet("/sitemap_posts_46.xml", () => Sitemaplinks.GetPosts(46));
app.MapGet("/sitemap_posts_47.xml", () => Sitemaplinks.GetPosts(47));
app.MapGet("/sitemap_posts_48.xml", () => Sitemaplinks.GetPosts(48));
app.MapGet("/sitemap_posts_49.xml", () => Sitemaplinks.GetPosts(49));
app.MapGet("/sitemap_posts_50.xml", () => Sitemaplinks.GetPosts(50));
app.MapGet("/sitemap_posts_51.xml", () => Sitemaplinks.GetPosts(51));


app.MapGet("/sitemap_series_1.xml", () => Sitemaplinks.GetSeries(1));
app.MapGet("/sitemap_series_2.xml", () => Sitemaplinks.GetSeries(2));
app.MapGet("/sitemap_series_3.xml", () => Sitemaplinks.GetSeries(3));
app.MapGet("/sitemap_series_4.xml", () => Sitemaplinks.GetSeries(4));
app.MapGet("/sitemap_series_5.xml", () => Sitemaplinks.GetSeries(5));
app.MapGet("/sitemap_series_6.xml", () => Sitemaplinks.GetSeries(6));
app.MapGet("/sitemap_series_7.xml", () => Sitemaplinks.GetSeries(7));
app.MapGet("/sitemap_series_8.xml", () => Sitemaplinks.GetSeries(8));
app.MapGet("/sitemap_series_9.xml", () => Sitemaplinks.GetSeries(9));
app.MapGet("/sitemap_series_10.xml", () => Sitemaplinks.GetSeries(10));
app.MapGet("/sitemap_series_11.xml", () => Sitemaplinks.GetSeries(11));
app.MapGet("/sitemap_series_12.xml", () => Sitemaplinks.GetSeries(12));
app.MapGet("/sitemap_series_13.xml", () => Sitemaplinks.GetSeries(13));
app.MapGet("/sitemap_series_14.xml", () => Sitemaplinks.GetSeries(14));
app.MapGet("/sitemap_series_15.xml", () => Sitemaplinks.GetSeries(15));
app.MapGet("/sitemap_series_16.xml", () => Sitemaplinks.GetSeries(16));
app.MapGet("/sitemap_series_17.xml", () => Sitemaplinks.GetSeries(17));
app.MapGet("/sitemap_series_18.xml", () => Sitemaplinks.GetSeries(18));
app.MapGet("/sitemap_series_19.xml", () => Sitemaplinks.GetSeries(19));
app.MapGet("/sitemap_series_20.xml", () => Sitemaplinks.GetSeries(20));
app.MapGet("/sitemap_series_21.xml", () => Sitemaplinks.GetSeries(21));




// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error", createScopeForErrors: true);
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
	.AddInteractiveServerRenderMode();

app.Run();
