namespace MyFirstEFCoreProject.Model
{
    public class Todo
    {
        public int TodoId { get; set; }
        public string Text { get; set; }
        public bool Completed { get; set; }

        public int ContactId { get; set; }
        public Contact Contact { get; set; }

    }
}