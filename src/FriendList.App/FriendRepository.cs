using System.Collections.Generic;

namespace FriendList.App
{
    public class FriendRepository
    {
        public static IList<Friend> GetFriends()
        {
            return new List<Friend>
            {
                new Friend("Jakov", "Sosic"),
                new Friend("Mensur", "Durakovic")
            };
        }
    }
}
