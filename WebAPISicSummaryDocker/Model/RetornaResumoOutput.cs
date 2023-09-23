public class RetornaResumoOutput
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
    public string filename { get; set; }
    public List<Summary> summaries { get; set; }
}

public class Summary
{
    //public DateTime created_at { get; set; }
    // public DateTime updated_at { get; set; }
    public string uuid { get; set; }
    public int request_id { get; set; }
    public string text { get; set; }
}
