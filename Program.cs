

using EFCoreWorkshop;
using Microsoft.EntityFrameworkCore;

using var db = new BloggingContext();

//db.Add(new Blog { Url = "http://epamworkshop.io" });
//db.SaveChanges();


//db.Posts.Add(new Post { Title = "PostTitle", BlogId = 1, Comment = "This is my first post" });
//db.SaveChanges();

var blog = db.Blogs.Where(x => x.BlogId == 1);
var result = db.Blogs.Include(x => x.Posts).ToList();
//INSERT INTO [Blogs] VALUES (Url) = ("http://epamworkshop.io")

Console.WriteLine("Hello, World!");
