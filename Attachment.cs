namespace SlackAPI
{
    public class Attachment
    {
        public string Pretext;
        public string text;
        public string fallback;
        public string color;
        public Field[] fields;
        ///I have absolutely no idea what goes on in here.
    }

    public class Field{
        public string title;
        public string value;
        public string @short;
    }
}
