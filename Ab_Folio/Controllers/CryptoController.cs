using Ab_Folio.Models;
using Ab_Folio.Objecten;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;




namespace Ab_Folio.Controllers
{
    public class CryptoController : Controller
    {

        public IActionResult CryptoList()
        {
           
            return View(CryptoObject());   
        }


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
        /// returns the result as a json object
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
