namespace EFCoreWorkshop
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set;}
    }
}