using System.Collections.Generic;

namespace FriendList.App
{
    public class FriendRepository
    {
        public static IList<Friend> GetFriends()
        {
            return new List<Friend>
            {
                new Friend("Jakov", "Sosic", "Mr."),
                new Friend("Mensur", "Durakovic", "Mr.")
            };
        }
    }
}
