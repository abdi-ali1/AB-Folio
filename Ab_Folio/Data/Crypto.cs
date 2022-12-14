using Ab_Folio.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SimpleJSON;
using System.Net;

namespace Ab_Folio.Objecten
{
    public class Crypto
    {
        //private field
        private string cryptoUrl = "http://api.coingecko.com/api/v3/coins/markets?vs_currency=eur";

        private Dictionary<string, Coin> _coinsLibrary = new();

        //propeties
        public Dictionary<string, Coin> CoinsLibrary
        {
            get
            {
                return _coinsLibrary;
            }
        }

        /// <summary>
        /// Intialezes the Setcoin method
        /// </summary>
        public Crypto()
        {
            SetCoins();
        }

        /// <summary>
        /// sets the retrieved values ​​from the json file to the Coinslibrary
        /// </summary>
        private void SetCoins()
        {
         ;

            try
            {
                string json = new WebClient().DownloadString(cryptoUrl);
                JSONNode node = JSON.Parse(json);
                _coinsLibrary.Clear();

                foreach (JSONNode coin in node)
                {
                    _coinsLibrary.Add(coin["market_cap_rank"], new Coin
                    {
                        Id = coin["market_cap_rank"],
                        Name = coin["name"],
                        Symbol = coin["symbol"],
                        imgUrl = coin["image"],
                        CoinValue = coin["current_price"],
                        Price_Change_24h = (float)Math.Round((float)coin["price_change_percentage_24h"], 2)

                    });
                }
            }
            catch (WebException e)
            {
                Console.WriteLine($"the url link for the crypto coins is not working: {e}" );   
            }
        }

        /// <summary>
        /// changes the character '.' to ','
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private string ChangeDotToComma(string value)
        {
            if (String.IsNullOrEmpty(value))
            {
                return value = "please enther a numerical value";
            }
            else
            {
                return value.Replace(".", ",");
            }
        }


        /// <summary>
        /// calculate the value given number of coins
        /// </summary>
        /// <param name="id"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public string GetValueOfCoins(string id, string amount)
        {
            string returnValue;
            
            Coin coin = _coinsLibrary[id];
            amount = ChangeDotToComma(amount);
            double calculatedValue = coin.CoinValue * double.Parse(amount);
            calculatedValue = Math.Round(calculatedValue, 2);
            returnValue = "€" + calculatedValue.ToString();
      
            return returnValue;
        }
    }
}