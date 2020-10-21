using System.Threading.Tasks;
using Amazon.SQS;
using Amazon.SQS.Model;

namespace sqs_net_core
{
    public class SqsService : ISqsService
    {
        private readonly IAmazonSQS _sqsClient;

        public SqsService(IAmazonSQS sqsClient)
        {
            _sqsClient = sqsClient;
        }

        public async Task<SendMessageResponse> SendMessageToSqsQueue(TicketRequest request)
        {
            var sendMessageRequest = new SendMessageRequest
            {
                QueueUrl = "https://sqs.us-east-1.amazonaws.com/619735791310/TicketRequest",
                MessageBody = request.Serialize(request)
            };

            return await _sqsClient.SendMessageAsync(sendMessageRequest);
        }

    }

}