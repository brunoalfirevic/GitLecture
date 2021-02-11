namespace FriendList.App
{
    public class Friend
    {
        public Friend(string firstName, string lastName, string title)
        {
            FirstName = firstName;
            LastName = lastName;
            Title = title;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public string Title { get; }
    }
}
