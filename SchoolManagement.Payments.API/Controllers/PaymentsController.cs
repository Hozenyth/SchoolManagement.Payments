using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Payments.API.Models;

namespace SchoolManagement.Payments.API.Controllers
{
    [Route ("api/payments")]
    public class PaymentsController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PaymentInfoInputModel paymentInfoInputModel)
        {
        }
    }
}
