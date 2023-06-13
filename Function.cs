using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace HelloWorldAws;

public class Function
{
    /// <summary>
    /// A simple function that say hello to the world
    /// </summary>
    /// <returns></returns>
    public APIGatewayProxyResponse Get(APIGatewayProxyRequest apiGatewayProxyRequest , ILambdaContext context)
    {
        // API Handling logic here
        return new APIGatewayProxyResponse
        {
            StatusCode = 200,
            Body = "Hello World!"
        };
    }
}
