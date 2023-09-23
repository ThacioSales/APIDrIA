namespace WebAPISicSummaryDocker.Model
{
    public class EnviaTextoInput
    {
        public EnviaTextoInput(string texto)
        {
            List<string> list = new List<string>();
            list.Add(texto);

            this.texts = list;
            this.language = "portuguese";
            this.mode = "summarize";
            this.length = "medium";


        }

        public List<string> texts { get; set; }
        public string language { get; set; }
        public string mode { get; set; }
        public string length { get; set; }





    }
}
