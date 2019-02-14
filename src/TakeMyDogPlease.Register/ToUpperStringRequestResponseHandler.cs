using System;
using System.Threading.Tasks;
using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;
using Kralizek.Lambda;
using Microsoft.Extensions.Logging;

namespace TakeMyDogPlease.Register
{
    public class ToUpperStringRequestResponseHandler : IRequestResponseHandler<APIGatewayProxyRequest, APIGatewayProxyResponse>
    {
        private readonly ILogger<ToUpperStringRequestResponseHandler> _logger;

        public ToUpperStringRequestResponseHandler(ILogger<ToUpperStringRequestResponseHandler> logger)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }
            _logger = logger;
        }

        public Task<APIGatewayProxyResponse> HandleAsync(APIGatewayProxyRequest input, ILambdaContext context)
        {
            return Task.FromResult(new APIGatewayProxyResponse {
                StatusCode = 200
            });
        }
    }
}