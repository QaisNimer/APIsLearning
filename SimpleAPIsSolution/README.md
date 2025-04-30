📦 Project Overview — APIsLearning

This project demonstrates practical implementations of various ASP.NET Core Web API features, including HTTP verbs, query/route parameter handling, and basic authentication. The solution includes multiple controllers and DTOs for structured request/response handling.
📁 Controllers
1. HTTPVerbsController

Implements each of the standard HTTP verbs (GET, POST, PUT, DELETE) within a single endpoint to demonstrate verb handling.
2. TestGetFromQueryController

Demonstrates multiple GET endpoints using query string parameters, covering:

    Single parameter

    Multiple parameters

    Collection (e.g., list of values)

    Custom object binding from query

3. TestGetFromRouteController

Demonstrates multiple GET endpoints using route parameters, covering:

    Single route parameter

    Multiple route parameters

    Collection

    Custom object binding from route

4. AuthController

Implements basic authentication-related endpoints:

    SignUp

    LoginWithMultiParams

    LoginWitCustomObj

    ResetPassword

    SendOTP

    ✅ LoginWithMultiParams and LoginWitCustomObj are wired with a basic service layer and use DTOs for structured input/output.

📁 DTOs (Data Transfer Objects)
1. LoginInput

Used in the AuthController for the LoginWitCustomObj endpoint.

    Contains the properties required to receive login credentials as a custom object.

2. LoginResponse

Used to return structured responses for endpoints in:

    TestGetFromQueryController

    TestGetFromRouteController
    Includes custom object properties as part of the response.
    
