// See https://aka.ms/new-console-template for more information

using PiplineDesignPattern;
using PiplineDesignPattern.Controller;
using PiplineDesignPattern.MiddlewarePipeline;

var request = new HttpContext(){Country = "A" , Url = "www.SomeThing.com",RequestIpAddress = "192.168.0.1"};
var request2 = new HttpContext(){Country = "B" , Url = "www.SomeThing.com",RequestIpAddress = "192.168.0.2"};

CancellationToken cancellationToken = new CancellationToken();


var controller = new ProductController();
var exceptionMiddleware = new ExceptionMiddleware();
var authorizedMiddleware = new AuthorizedMiddleware();
var cors = new Cors();
var routeMiddleware = (new RouteMiddleware());

            exceptionMiddleware
                    .AddMiddleware(authorizedMiddleware)
                    .AddMiddleware(cors)
                    .AddMiddleware(routeMiddleware);

exceptionMiddleware.Build(cancellationToken,request2);

exceptionMiddleware.Build(cancellationToken,request2);

Console.WriteLine(controller.GetAllProducts());

