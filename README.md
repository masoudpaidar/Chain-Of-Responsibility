# Chain of Responsibility Pattern in C#

## About
This project implements the Chain of Responsibility design pattern within a C# application. The pattern is used to pass a request along a chain of handlers. Upon receiving a request, each handler decides either to process the request or to pass it to the next handler in the chain.

## Getting Started

### Prerequisites
- .NET Core 7.0 or later

### Installation
1. Clone the repository to your local machine:


git clone https://github.com/masoudpaidar/chain-of-responsibility-csharp.git


2. Navigate to the cloned repository:

cd chain-of-responsibility-csharp

3. Restore necessary packages:

dotnet restore

4. Build the solution:

dotnet build
## Usage
The project consists of a `Handler` abstract class from which all concrete handlers inherit. To use the pattern, instantiate the concrete handlers and set up their successor relationships. Then, initiate the request to the first handler in the chain.

```csharp
var handler1 = new ExceptionMiddleware();
var handler2 = new AuthorizedMiddleware();
var handler3 = new Cors();
var handler4 = new RouteMiddleware();

 handler1.AddMiddleware(authorizedMiddleware)
                    .AddMiddleware(cors)
                    .AddMiddleware(routeMiddleware);

handler1.HandleRequest(request);
```

## Feature

- Easy to extend and modify the chain of handlers 
- Decouples the sender of the request and its receivers
- Allows for dynamic chaining and processing

## Contact Information

For further information, feel free to contact [masoud hajyzadeh] at [masoudpaidar76@gmail.com].

## Contributing

We welcome contributions to this project! Please consider the following guidelines:

- Follow the existing coding style and conventions.
- Add comprehensive unit tests to cover any new features or fixes.
- Include comments and documentation as needed.