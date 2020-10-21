using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace sqs_net_core
{
    [ApiController]
    public class QueueController : ControllerBase
    {
        private readonly ISqsService _sqsService;

        public QueueController(ISqsService sqsService)
        {
            _sqsService = sqsService;
        }

        [HttpPost]
        [Route("SendMessage")]
        public async Task<IActionResult> SendMessage(TicketRequest request)
        {
            var response = await _sqsService.SendMessageToSqsQueue(request);

            if (response == null)
            {
                return BadRequest();
            }

            return Ok();
        }

    }

}