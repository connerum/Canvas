namespace DomainModel
{
    public class Resource
    {
        public int ResourceID { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string ContentURL { get; set; }

        public void DownloadResource() { /* Implementation */ }
    }
}
