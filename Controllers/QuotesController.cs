using Microsoft.AspNetCore.Mvc;
using FisherInsuranceApi.Models;
using FisherInsuranceApi.Data;
    public class QuotesController : Controller
    {
        private IMemoryStore db;

        public QuotesController(IMemoryStore repo)
        {
            db=repo;
        }
        public IActionResult GetQuotes()
        {
            return Ok(db.RetrieveAllQuotes);
        }
        public IActionResult Index()
        {
            return Ok("");
        }
    // POST api/quotes
        [HttpPost]
        public IActionResult Post([FromBody]Quote quote)

        {

            return Ok(db.CreateQuote(quote));

        }

    // GET api/quotes/5
        [HttpGetAttribute("{id}")]

        public IActionResult Get(int id)
        {
            return Ok(db.RetrieveQuote(id));
        }
    // PUT api/quotes/id
        [HttpPutAttribute("{id}")]
        public IActionResult Put([FromBody]Quote quote)
        {
            return Ok(db.UpdateQuote(quote));
        }
    // DELETE api/quotes/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            db.DeleteQuote(id);
            return Ok();
        }
    }
