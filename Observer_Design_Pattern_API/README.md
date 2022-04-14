### OBSERVER DESIGN PATTERN API

This project demonstrates the observer design pattern usage in .Net Web API.

The purpose of the project is, sending **SMS** and **EMAIL** notification to the API user, when `[POST]` request called .

---
> HOW TO RUN

Fork this repo to your local instance. Then run the `dotnet run` in the command line inside the project folder.

After starting the project, in swagger execute the **POST** endpoint with any valid value.
Then check the command line for output received from SMS and MAIL notification services.

---

>Folder Structure

- **`Controllers`**
> Contains Controllers that define endpoints.
- **`EventHandlers`**
> Contains Event Handlers for SMS and E-Mail services that sends data after received update from **`EventPublisher`** 
- **`EventPublisher`**
> Contains **`EventPublisher`** and **`IEventPublisher`** for **subscribing**, **unsubscribing** and **publish** methods. 
- **`Events`**
> Contains `ProductCreatedEvent` for transferring data from event publishers to listeners.
- **`Models`**
> Contains product model
- **`Notifications`**
> Contains `INotification` and `INotificationHandler` interfaces for Event Handlers.

---

> CLASS BREAKDOWN (IMPORTANT ONLY)

---

`ProductCreatedEventSendEmailHandler`
- Contains the update functionality for sending email after receving data from notification service.

`ProductCreatedEventSendSMSHandler`
- Contains the update functionality for sending sms after receving data from notification service.

`EventPublisher`
- `Subscribe` method for registering notification handlers
- `Unsubscribe` method for unregistering notification handlers
- `Publish` method for publishing new notification to the listeners.

`ProductsController`
- Have only `[POST]` endpoint
- Create instance for SMS and Email listeners and subscribe them to event publisher.
- Publish an event for new `ProductCreatedEvent`