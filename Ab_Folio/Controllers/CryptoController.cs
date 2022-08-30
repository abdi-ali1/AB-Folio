using Ab_Folio.Models;
using Ab_Folio.Objecten;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;




namespace Ab_Folio.Controllers
{
    public class CryptoController : Controller
    {
        /// <summary>
        /// Redirect to the cryptolist View and passes the object 'crypto' 
        /// </summary>
        /// <returns></returns>
        public IActionResult CryptoList()
        {
           
            return View(CryptoObject());   
        }

        /// <summary>
        /// Redirect to the CoinValue View and passes the object 'crypto' 
        /// </summary>
        /// <returns></returns>
        public IActionResult CoinValue()
        {
            return View(CryptoObject());
        }
        /// <summary>
        /// returns a crypto object
        /// </summary>
        /// <returns></returns>
        private Crypto CryptoObject()
        {
            Crypto crypto = new Crypto();
            return crypto;
        }

        /// <summary>
        /// passes the posted values ​​to the 'GetValueOfCoins' method and returns the response
        /// </summary>
        /// <param name="id"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult GetResult(string id, string amount)
        {
       
            string json = JsonConvert.SerializeObject(CryptoObject().GetValueOfCoins(id, amount));
            return Json(json);
        }
    }
}
