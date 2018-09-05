# Creating WEB_API and consuming it in a MVC application and performing CRUD Operations.

STEP 1:  Create Web API Project 

>> Create WEB API Application 
>> Import Models using Entity Framework: Here we imported Employees Table from the Database. EmployeeID, Name, Position, Age and Salary are the Employee properties
>>Create a controller and name it TestController and select an empty Web API Controller template.
  >> Create an instance of the Entity and use it to perform GET, POST, PUT and DELETE actions.
  >> Test these Actions using Postman

STEP 2: Create Global Varaible of the WebAPI project

>> In order to consume the WebAPI project we have to create an instance of the HttpClient in MVC project and define its properties in the constructor of the globalVariable class

public static class GlobalVariables
    {
        //creating the HttpClient Object and now we can use the this webApi object through out the life Cycle if the Application
        public static HttpClient WebApiClient = new HttpClient();

        static GlobalVariables()
        {
            WebApiClient.BaseAddress = new Uri("http://localhost:53366/api/");
            WebApiClient.DefaultRequestHeaders.Clear();
            WebApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }


STEP 3:    MVC Project to consume the web api

>> Create model class(mvcEmployeeModel.cs) with same properties as in the Web API project. 
>> Create controller class and name it TestController 
>> TestController in MVC project will implement the TestController in the WEB API project
>> Public List<Employee> Get() -------is implemented in Public ActionResult Index()...and so on
  
  @TempData[SuccessMessage] = "Message for POST, PUT and DELETE Operations is defined within the ActionResults that implement those HTTP VERBS" alertify JS is used to display some message to the User once those operations are completed
  
  CODE FOR ALERTIFY JS
  $(function () {

            var successMessage = ' @TempData["SuccessMessage"]'

            if (successMessage != "") {
                alertify.success(successMessage);
            }
        })


