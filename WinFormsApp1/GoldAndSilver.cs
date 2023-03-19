// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class ResultGold
{
    public string name { get; set; }
    public double buying { get; set; }
    public string buyingstr { get; set; }
    public double selling { get; set; }
    public string sellingstr { get; set; }
    public string time { get; set; }
    public string date { get; set; }
    public DateTime datetime { get; set; }
    public object rate { get; set; }
}

public class RootGold
{
    public List<ResultGold> result { get; set; }
    public bool success { get; set; }
}
