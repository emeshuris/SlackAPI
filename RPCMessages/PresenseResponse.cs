namespace SlackAPI
{
    [RequestPath("presense.set")]
    public class PresenceResponse : Response
    {
    }
    public enum Presence
    {
        Active,
        Away
    }
}
