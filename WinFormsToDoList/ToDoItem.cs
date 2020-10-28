namespace WinFormsToDoList
{
    internal class ToDoItem
    {

        public ToDoItem(string Title)
        {
            this.Title = Title;
            this.IsCompleted = false;
        }

        public string Title { get; set; }
        public bool IsCompleted { get; set; }
    }
}