using System.Threading.Tasks;
using Amazon.SQS.Model;

namespace sqs_net_core
{
    public interface ISqsService
    {
        Task<SendMessageResponse> SendMessageToSqsQueue(TicketRequest request);
    }

}