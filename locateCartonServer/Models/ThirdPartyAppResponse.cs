namespace vercodebulktest.Models
{
    public class ThirdPartyAppResponse : ThirdPartyAppRequest
    {
        public ThirdPartyAppResponse():base()
        {
            blacklist = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" ,"10","11"};
            scanned = true;
        }

        public string[] blacklist { get; set; }

        public string[] whitelist { get; set; }

        public bool scanned { get; set; }

    }
}