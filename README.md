# Getting Started
## How to Build

The generated code uses a few NuGet Packages e.g., Newtonsoft.Json, UniRest,
and Microsoft Base Class Library. The reference to these packages is already
added as in the packages.config file. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.
     
1. Open the solution (UberAPI.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](http://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=Uber API-CSharp&workspaceName=UberAPI&projectName=UberAPI.PCL)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
 Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the following link. 
http://msdn.microsoft.com/en-us/library/vstudio/gg597391(v=vs.100).aspx

The following section explains how to use the UberAPI library in a new console project.     
    
#### 1. Starting a new project
For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](http://apidocs.io/illustration/cs?step=addProject&workspaceFolder=Uber API-CSharp&workspaceName=UberAPI&projectName=UberAPI.PCL)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](http://apidocs.io/illustration/cs?step=createProject&workspaceFolder=Uber API-CSharp&workspaceName=UberAPI&projectName=UberAPI.PCL)


#### 2. Set as startup project
The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](http://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=Uber API-CSharp&workspaceName=UberAPI&projectName=UberAPI.PCL)


#### 3. Add reference of the library project
In order to use the UberAPI library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](http://apidocs.io/illustration/cs?step=addReference&workspaceFolder=Uber API-CSharp&workspaceName=UberAPI&projectName=UberAPI.PCL)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` UberAPI.PCL ``` and click ``` OK ```. By doing this, we have added a reference of the ```UberAPI.PCL``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](http://apidocs.io/illustration/cs?step=createReference&workspaceFolder=Uber API-CSharp&workspaceName=UberAPI&projectName=UberAPI.PCL)


#### 4. Write sample code
Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](http://apidocs.io/illustration/cs?step=addCode&workspaceFolder=Uber API-CSharp&workspaceName=UberAPI&projectName=UberAPI.PCL)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

#### Authentication and Initialization
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| oAuthAccessToken | The OAuth 2.0 access token to be set before API calls |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string oAuthAccessToken = "oAuthAccessToken"; // The OAuth 2.0 access token to be set before API calls

UberAPIClient client = new UberAPIClient(oAuthAccessToken);
```

# Class Reference
## <a name="list_of_controllers"></a>List of Controllers

* [APIController](#api_controller)

## <a name="api_controller"></a>![Class: ](http://apidocs.io/img/class.png "UberAPI.PCL.Controllers.APIController") APIController

#### Get singleton instance
The singleton instance of the ``` APIController ``` class can be accessed from the API Client.
```csharp
IAPIController client = client.Client;
```

### <a name="get_promotions"></a>![Method: ](http://apidocs.io/img/method.png "UberAPI.PCL.Controllers.APIController.GetPromotions") GetPromotions

> The Promotions endpoint returns information about the promotion that will be available to a new user based on their activity's location. These promotions do not apply for existing users.

```csharp
Task<PromotionsResponse> GetPromotions(GetPromotionsInput input)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| endLatitude |  ``` Required ```  | Latitude component of end location. |
| endLongitude |  ``` Required ```  | Longitude component of end location. |
| startLatitude |  ``` Required ```  | Latitude component of start location. |
| startLongitude |  ``` Required ```  | Longitude component of start location |



#### Example Usage:
```csharp
GetPromotionsInput collect = new GetPromotionsInput();

double endLatitude = 77.8338691326016;
collect.EndLatitude = endLatitude;

double endLongitude = 77.8338691326016;
collect.EndLongitude = endLongitude;

double startLatitude = 77.8338691326016;
collect.StartLatitude = startLatitude;

double startLongitude = 77.8338691326016;
collect.StartLongitude = startLongitude;


PromotionsResponse result = await client.GetPromotions(collect);

```



#### Errors: 
| Error Code | Error Description |
|------------|-------------------|
| 400 | Malformed request. |
| 401 | Unauthorized the request requires user authentication (not logged in). |
| 403 | Forbidden. Also used for unauthorized requests such as improper OAuth 2.0 scopes or permissions issues. |
| 404 | Not found. |
| 406 | Unacceptable content type. Client sent an accepts header for a content type which does not exist on the server. Body includes a list of acceptable content types, such as ?Unacceptable content type. Request resource as: application/json. |
| 409 | A conflict needs to be resolved before the request can be made. |
| 422 | Invalid request. The request body is parse-able however with invalid content or there are issues with a rider's user account. |
| 429 | Too Many Requests. Rate limited |
| 500 | Internal Server Error. |
| 222 | bac |





### <a name="create_request"></a>![Method: ](http://apidocs.io/img/method.png "UberAPI.PCL.Controllers.APIController.CreateRequest") CreateRequest

> The Request endpoint allows a ride to be requested on behalf of an Uber user given their desired product, start, and end locations. Please review the Sandbox documentation on how to develop and test against these endpoints without making real-world Requests and being charged.

```csharp
Task<Request> CreateRequest(RequestBody body)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | TODO: Add a parameter description |



#### Example Usage:
```csharp
var body = new RequestBody();

Request result = await client.CreateRequest(body);

```



#### Errors: 
| Error Code | Error Description |
|------------|-------------------|
| 400 | Malformed request |
| 401 | Unauthorized the request requires user authentication (not logged in). |
| 403 | Forbidden. Also used for unauthorized requests such as improper OAuth 2.0 scopes or permissions issues. |
| 404 | Not found |
| 406 | Unacceptable content type. Client sent an accepts header for a content type which does not exist on the server. Body includes a list of acceptable content types, such as ?Unacceptable content type. Request resource as: application/json |
| 409 | A conflict needs to be resolved before the request can be made. |
| 422 | Invalid request. The request body is parse-able however with invalid content or there are issues with a rider's user account. |
| 429 | Too Many Requests. Rate limited. |
| 500 | Internal Server Error. |





### <a name="delete_request_cancel"></a>![Method: ](http://apidocs.io/img/method.png "UberAPI.PCL.Controllers.APIController.DeleteRequestCancel") DeleteRequestCancel

> Cancel an ongoing Request on behalf of a rider.

```csharp
Task DeleteRequestCancel(string requestId)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| requestId |  ``` Required ```  | Unique identifier representing a Request. |



#### Example Usage:
```csharp
string requestId = "request_id";

await client.DeleteRequestCancel(requestId);

```



#### Errors: 
| Error Code | Error Description |
|------------|-------------------|
| 400 | Malformed request. |
| 401 | Unauthorized the request requires user authentication (not logged in). |
| 403 | Forbidden. Also used for unauthorized requests such as improper OAuth 2.0 scopes or permissions issues. |
| 404 | Not found |
| 406 | Unacceptable content type. Client sent an accepts header for a content type which does not exist on the server. Body includes a list of acceptable content types, such as ?Unacceptable content type. Request resource as: application/json. |
| 409 | A conflict needs to be resolved before the request can be made |
| 422 | Invalid request. The request body is parse-able however with invalid content or there are issues with a rider's user account. |
| 429 | Too Many Requests. Rate limited. |
| 500 | Internal Server Error |





### <a name="get_request_map"></a>![Method: ](http://apidocs.io/img/method.png "UberAPI.PCL.Controllers.APIController.GetRequestMap") GetRequestMap

> Get a map with a visual representation of a Request.

```csharp
Task<RequestMapResponse> GetRequestMap(string requestId)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| requestId |  ``` Required ```  | Unique identifier representing a Request. |



#### Example Usage:
```csharp
string requestId = "request_id";

RequestMapResponse result = await client.GetRequestMap(requestId);

```



#### Errors: 
| Error Code | Error Description |
|------------|-------------------|
| 400 | Malformed request. |
| 401 | Unauthorized the request requires user authentication (not logged in). |
| 403 | Forbidden. Also used for unauthorized requests such as improper OAuth 2.0 scopes or permissions issues |
| 404 | Not found |
| 406 | Unacceptable content type. Client sent an accepts header for a content type which does not exist on the server. Body includes a list of acceptable content types, such as ?Unacceptable content type. Request resource as: application/json. |
| 409 | A conflict needs to be resolved before the request can be made. |
| 422 | Invalid request. The request body is parse-able however with invalid content or there are issues with a rider's user account. |
| 429 | Too Many Requests. Rate limited. |
| 500 | Internal Server Error. |





### <a name="get_price_estimates"></a>![Method: ](http://apidocs.io/img/method.png "UberAPI.PCL.Controllers.APIController.GetPriceEstimates") GetPriceEstimates

> The Price Estimates endpoint returns an estimated price range for each product offered at a given location. The price estimate is provided as a formatted string with the full price range and the localized currency symbol.

```csharp
Task<PriceEstimateCollection> GetPriceEstimates(GetPriceEstimatesInput input)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| endLatitude |  ``` Required ```  | Latitude component of end location. |
| endLongitude |  ``` Required ```  | Longitude component of end location. |
| startLatitude |  ``` Required ```  | Latitude component of start location. |
| startLongitude |  ``` Required ```  | Longitude component of start location. |



#### Example Usage:
```csharp
GetPriceEstimatesInput collect = new GetPriceEstimatesInput();

double endLatitude = 77.8338691326016;
collect.EndLatitude = endLatitude;

double endLongitude = 77.8338691326016;
collect.EndLongitude = endLongitude;

double startLatitude = 77.8338691326016;
collect.StartLatitude = startLatitude;

double startLongitude = 77.8338691326016;
collect.StartLongitude = startLongitude;


PriceEstimateCollection result = await client.GetPriceEstimates(collect);

```



#### Errors: 
| Error Code | Error Description |
|------------|-------------------|
| 400 | Malformed request. |
| 401 | Unauthorized the request requires user authentication (not logged in). |
| 403 | Forbidden. Also used for unauthorized requests such as improper OAuth 2.0 scopes or permissions issues. |
| 404 | Not found. |
| 406 | Unacceptable content type. Client sent an accepts header for a content type which does not exist on the server. Body includes a list of acceptable content types: ?Unacceptable content type. Request resource as: application/json, etc. |
| 422 | Invalid request. The request body is parse-able however with invalid content. |
| 429 | Too Many Requests. Rate limited. |
| 500 | Internal Server Error. |





### <a name="get_time_estimates"></a>![Method: ](http://apidocs.io/img/method.png "UberAPI.PCL.Controllers.APIController.GetTimeEstimates") GetTimeEstimates

> The Time Estimates endpoint returns ETAs for all products offered at a given location, with the responses expressed as integers in seconds. We recommend that this endpoint be called every minute to provide the most accurate, up-to-date ETAs.

```csharp
Task<TimeEstimateCollection> GetTimeEstimates(GetTimeEstimatesInput input)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| startLatitude |  ``` Required ```  | Latitude component of the start location |
| startLongitude |  ``` Required ```  | Longitude component of the start location |
| customerUuid |  ``` Optional ```  | The customer id interested in estimate |
| productId |  ``` Optional ```  | Id of the requested product |



#### Example Usage:
```csharp
GetTimeEstimatesInput collect = new GetTimeEstimatesInput();

double startLatitude = 77.8338691326016;
collect.StartLatitude = startLatitude;

double startLongitude = 77.8338691326016;
collect.StartLongitude = startLongitude;

string customerUuid = "customer_uuid";
collect.CustomerUuid = customerUuid;

string productId = "product_id";
collect.ProductId = productId;


TimeEstimateCollection result = await client.GetTimeEstimates(collect);

```



#### Errors: 
| Error Code | Error Description |
|------------|-------------------|
| 400 | Malformed request. |
| 401 | Unauthorized the request requires user authentication (not logged in). |
| 403 | Forbidden. Also used for unauthorized requests such as improper OAuth 2.0 scopes or permissions issues. |
| 404 | Not found. |
| 406 | Unacceptable content type. Client sent an accepts header for a content type which does not exist on the server. Body includes a list of acceptable content types: ?Unacceptable content type. Request resource as: application/json, etc. |
| 422 | Invalid request. The request body is parse-able however with invalid content. |
| 429 | Too Many Requests. Rate limited. |
| 500 | Internal Server Error. |





### <a name="get_user_activity_v11"></a>![Method: ](http://apidocs.io/img/method.png "UberAPI.PCL.Controllers.APIController.GetUserActivityV11") GetUserActivityV11

> The User Activity endpoint returns data about a user's lifetime activity with Uber. The response will include pickup locations and times, dropoff locations and times, the distance of past requests, and information about which products were requested.

```csharp
Task<UserActivity> GetUserActivityV11(GetUserActivityV11Input input)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| limit |  ``` Required ```  | Number of items to return for pagging |
| offset |  ``` Required ```  | Page offset for pagging |



#### Example Usage:
```csharp
GetUserActivityV11Input collect = new GetUserActivityV11Input();

int limit = 77;
collect.Limit = limit;

int offset = 77;
collect.Offset = offset;


UserActivity result = await client.GetUserActivityV11(collect);

```



#### Errors: 
| Error Code | Error Description |
|------------|-------------------|
| 400 | Malformed request. |
| 401 | Unauthorized the request requires user authentication (not logged in). |
| 403 | Forbidden. Also used for unauthorized requests such as improper OAuth 2.0 scopes or permissions issues. |
| 404 | Not found. |
| 406 | Unacceptable content type. Client sent an accepts header for a content type which does not exist on the server. Body includes a list of acceptable content types: ?Unacceptable content type. Request resource as: application/json, etc. |
| 422 | Invalid request. The request body is parse-able however with invalid content. |
| 429 | Too Many Requests. Rate limited. |
| 500 | Internal Server Error. |





### <a name="get_product_detail_by_id"></a>![Method: ](http://apidocs.io/img/method.png "UberAPI.PCL.Controllers.APIController.GetProductDetailByID") GetProductDetailByID

> Get product details w.r.t id

```csharp
Task<Product> GetProductDetailByID(string productId)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| productId |  ``` Required ```  | Unique identifier representing a specific product for a given latitude & longitude. For example, uberX in San Francisco will have a different product_id than uberX in Los Angeles. |



#### Example Usage:
```csharp
string productId = "product_id";

Product result = await client.GetProductDetailByID(productId);

```





### <a name="get_request_details"></a>![Method: ](http://apidocs.io/img/method.png "UberAPI.PCL.Controllers.APIController.GetRequestDetails") GetRequestDetails

> Get the real time status of an ongoing trip that was created using the Ride Request endpoint.

```csharp
Task<RequestDetailsCollections> GetRequestDetails(string requestId)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| requestId |  ``` Required ```  | TODO: Add a parameter description |



#### Example Usage:
```csharp
string requestId = "request_id";

RequestDetailsCollections result = await client.GetRequestDetails(requestId);

```



#### Errors: 
| Error Code | Error Description |
|------------|-------------------|
| 400 | Malformed request. |
| 401 | Unauthorized the request requires user authentication (not logged in). |
| 403 | Forbidden. Also used for unauthorized requests such as improper OAuth 2.0 scopes or permissions issues. |
| 404 | Not found. |
| 406 | Unacceptable content type. Client sent an accepts header for a content type which does not exist on the server. Body includes a list of acceptable content types, such as ?Unacceptable content type. Request resource as: application/json. |
| 409 | A conflict needs to be resolved before the request can be made. |
| 422 | Invalid request. The request body is parse-able however with invalid content or there are issues with a rider's user account. |
| 429 | Too Many Requests. Rate limited. |
| 500 | Internal Server Error |





### <a name="get_products_types"></a>![Method: ](http://apidocs.io/img/method.png "UberAPI.PCL.Controllers.APIController.GetProductsTypes") GetProductsTypes

> The Products endpoint returns information about the Uber products offered at a given location. The response includes the display name and other details about each product, and lists the products in the proper display order.

```csharp
Task<ProductCollection> GetProductsTypes(GetProductsTypesInput input)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| latitude |  ``` Required ```  | Latitude component of location. |
| longitude |  ``` Required ```  | Longitude component of location. |



#### Example Usage:
```csharp
GetProductsTypesInput collect = new GetProductsTypesInput();

double latitude = 77.8338691326016;
collect.Latitude = latitude;

double longitude = 77.8338691326016;
collect.Longitude = longitude;


ProductCollection result = await client.GetProductsTypes(collect);

```



#### Errors: 
| Error Code | Error Description |
|------------|-------------------|
| 400 | Malformed request. |
| 401 | Unauthorized the request requires user authentication (not logged in). |
| 403 | Forbidden. Also used for unauthorized requests such as improper OAuth 2.0 scopes or permissions issues. |
| 404 | Not found. |
| 406 | Unacceptable content type. Client sent an accepts header for a content type which does not exist on the server. Body includes a list of acceptable content types: ?Unacceptable content type. Request resource as: application/json, etc. |
| 422 | Invalid request. The request body is parse-able however with invalid content. |
| 429 | Too Many Requests. Rate limited. |
| 500 | Internal Server Error. |





### <a name="get_user_profile"></a>![Method: ](http://apidocs.io/img/method.png "UberAPI.PCL.Controllers.APIController.GetUserProfile") GetUserProfile

> The User Profile endpoint returns information about the Uber user that has authorized with the application.

```csharp
Task<UserProfile> GetUserProfile()
```

#### Example Usage:
```csharp

UserProfile result = await client.GetUserProfile();

```



#### Errors: 
| Error Code | Error Description |
|------------|-------------------|
| 400 | Malformed request. |
| 401 | Unauthorized the request requires user authentication (not logged in). |
| 403 | Forbidden. Also used for unauthorized requests such as improper OAuth 2.0 scopes or permissions issues. |
| 404 | Not found. |
| 406 | Unacceptable content type. Client sent an accepts header for a content type which does not exist on the server. Body includes a list of acceptable content types: ?Unacceptable content type. Request resource as: application/json, etc. |
| 422 | Invalid request. The request body is parse-able however with invalid content. |
| 429 | Too Many Requests. Rate limited. |
| 500 | Internal Server Error. |





[Back to List of Controllers](#list_of_controllers)


