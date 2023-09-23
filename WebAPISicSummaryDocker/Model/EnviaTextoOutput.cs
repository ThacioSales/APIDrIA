namespace WebAPISicSummaryDocker.Model
{
    public class EnviaTextoOutput
    {
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string uuid { get; set; }
        public List<Request> requests { get; set; }

    }
    public class Request
    {
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public string uuid { get; set; }
        public string text { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string message_id { get; set; }
        public string subject { get; set; }
        public string type { get; set; }
        public int tokens { get; set; }
        //public string should_email { get; set; }
        public int api_token_id { get; set; }
        public List<object> summaries { get; set; }
        public Url url { get; set; }
    }


    public class Url
    {
    }
}
