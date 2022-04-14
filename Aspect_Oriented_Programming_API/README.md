### ASPECT ORIENTED PROGRAMMING API

This project demonstrates the aspect oriented programming usage in .Net Web API.
There are 2 interceptors in the project **`AuthenticationInterceptor`** and **`LoggingInterceptor`**.
This interceptors registered to the repository by `ServiceModule` which inherits the `Module` class from **AutoFac**.

---
> HOW TO RUN

- Fork this repo to your local instance. Then run the `dotnet run` in the command line inside the project folder.

After starting the project, in swagger start the endpoint you desire and watch the logs from command line.

---

>Folder Structure

- **`Controllers`**
> Contains Controllers that define endpoints.
- **`Interceptors`**
> Contains interceptors for authentication and logging
- **`Models`**
> Contains model classes
- **`Modules`**
> Contains service registeration module
- **`Services`**
> Contains repository command handler

---

> CLASS BREAKDOWN (IMPORTANT ONLY)

---

`AuthenticationInterceptor`
- Log the caller method type and name.
- Generates random number and according to that throws error if number is 0. (For Testing)
- If random authorization successfull, control passes to the method.

`LoggingInterceptor`
- Log the caller method type and name
- Log the parameters of function and passed time.

`ServiceModule`
- Register `AuthenticationInterceptor` and `LoggingInterceptor` globally.
-Register 2 interceptors to the `ICustomerService` interface.