

namespace Crypto_Webscrapper.Models
{
    public class Coin
    {
        //properties
        public int  Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string imgUrl { get; set; }
        public double CoinValue { get; set; }
        public float Price_Change_24h { get; set; }
    }
}
