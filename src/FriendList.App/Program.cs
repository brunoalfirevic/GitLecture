using System;

namespace FriendList.App
{
    public class Program
    {
        public static void Main()
        {
            var friends = FriendRepository.GetFriends();

            foreach(var friend in friends)
            {
                Console.WriteLine($"A friend called '{friend.Title} {friend.FirstName}'");
            }
        }
    }
}
