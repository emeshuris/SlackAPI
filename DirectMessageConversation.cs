using System;

namespace SlackAPI
{
    public class DirectMessageConversation
    {
        public string id;
        public string user;
        public DateTime created;
        public bool is_user_deleted;
        public bool is_open;
        public bool is_starred;
        public DateTime last_read;
        public Message latest;
        public int unread_count;
    }
}
