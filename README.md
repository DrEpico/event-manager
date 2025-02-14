# ThAmCo Project Requirements
This project involves managing food items and menus for the Catering system and Event management system, adhering to the functional requirements outlined below. All API methods in Catering utilise DTOs to simplify input and output handling (unless deemed unnecessary).

[![ThAmCo Demo Video](https://img.youtube.com/vi/ZbY0l1mcqRc/0.jpg)](https://youtu.be/ZbY0l1mcqRc)
<!--## Functional Requirements
# Must (Critical requirements)
![MUST](https://img.shields.io/badge/✓-MUST-F43F5E)    
![MUST](https://img.shields.io/badge/△-MUST-F43F5E)     
![MUST](https://img.shields.io/badge/✗-MUST-F43F5E)   

# Should (Recommended features)
![SHOULD](https://img.shields.io/badge/✓-SHOULD-EAB308)
![SHOULD](https://img.shields.io/badge/△-SHOULD-EAB308)
![SHOULD](https://img.shields.io/badge/✗-SHOULD-EAB308)

# Would (Nice to have)
![WOULD](https://img.shields.io/badge/✓-WOULD-22C55E)
![WOULD](https://img.shields.io/badge/△-WOULD-22C55E)
![WOULD](https://img.shields.io/badge/✗-WOULD-22C55E)

![JUSTIFICATION](https://img.shields.io/badge/JUSTIFICATION-6366F1)    
![ALTERNATIVE](https://img.shields.io/badge/ALTERNATIVE-8B5CF6)
![TODO](https://img.shields.io/badge/TODO-3B82F6)
![TODO/ALTERNATIVE](https://img.shields.io/badge/TODO%2FALTERNATIVE-2563EB)
-->

---
<details>
<summary> 

  ### Scenario
  Expand to see the project scenario.

</summary>

### ThAmCo Project
ThreeAmigos Corp is an event management company that arranges and oversees a range of functions, including conferences, parties and weddings for its clients. As well as logistics,
ThreeAmigos Corp organises the catering and staffing for events. I have been given the responsibility of constructing a new intranet-based prototype system for
the events management team. The internal system will be used by ThreeAmigos Corp staff to perform the key operations:
- Manage event details;
- Assign staff to events;
- Attach guests to events;
- Assign food orders to events.
A system architecture and data model have been agreed upon by all stakeholders. It has been decided that an existing web service will be used for reserving event venues.
It has also been decided that catering will be created as an independent web service because of the potential for selling on as a third-party service to other companies.
The system architecture and data model are documented below.

![image](https://github.com/user-attachments/assets/e009edb0-f471-4250-97fc-b07ce4370743)
![image](https://github.com/user-attachments/assets/94ea6be4-c43d-4d5d-b756-d98374ce5fe2)

</details>

---

### Tag System

>#### Requirements Status
>
>We use a color-coded system to track requirement implementation:
>
>![MUST](https://img.shields.io/badge/✓-MUST-F43F5E): Must Requirements
><br>![SHOULD](https://img.shields.io/badge/✓-SHOULD-EAB308): Should Requirements
><br>![WOULD](https://img.shields.io/badge/✓-WOULD-22C55E): Would Requirements
>
>Status indicators used with requirements:
>- ✓ : Fully implemented
>- △ : Partially implemented
>- ✗ : Not started
> <br>**Note**: In this project, all requirements are marked with ✓ (fully implemented).
>
> #### Development Insight Badges
> To provide clarity on development decisions and future plans, we use:
>
>![JUSTIFICATION](https://img.shields.io/badge/JUSTIFICATION-6366F1): Justifications for the choices I have made.
> 
>![ALTERNATIVE](https://img.shields.io/badge/ALTERNATIVE-8B5CF6): The alternative solutions I would like to/could implement that require considerable refactoring.
>
>![TODO](https://img.shields.io/badge/TODO-3B82F6): The improvements I would like to implement on top of the existing code.
>
>![TODO/ALTERNATIVE](https://img.shields.io/badge/TODO%2FALTERNATIVE-2563EB): The improvements I would like to implement that require considerable refactoring. 

---

### Web Api Services (ThAmCo.Catering) to:
### ![MUST](https://img.shields.io/badge/✓-MUST-F43F5E) 1. Create, edit, delete, and list food items.
These functionalities are implemented in **`MenuItemsController.cs`**.

#### API Endpoints:
- **`AddFoodItem(foodItemDto)`**  
  Creates new food items.
  
- **`GetFoodItems()`**  
  Retrieves and lists all food items.

- **`GetFoodItem(id)`**  
  Retrieves a food item by its ID.

- **`EditFoodItem(id, foodItemDto)`**  
  Updates the details of a food item.

- **`DeleteFoodItem(id)`**  
  Deletes a food item by its ID.

### ![MUST](https://img.shields.io/badge/✓-MUST-F43F5E) 2. Create, edit, delete, and list details of food menus, including associating items with menus.
These functionalities are implemented in **`MenuFoodItemsController.cs`**.

#### API Endpoints:
- **`PostMenuFoodItem(menuId, itemId)`**  
  Adds an existing food item to a menu.

- **`GetMenuFoodItems()`**  
  Retrieves a list of all MenuFoodItems.

- **`GetMenuFoodItem(id)`**  
  Retrieves details of a MenuFoodItem by its ID.

- **`PutMenuFoodItem(id, menuFoodItem)`**  
  Updates an item in a menu.

- **`DeleteMenuFoodItem(menuId, itemId)`**  
  Removes an existing food item from a specific menu.

### ![MUST](https://img.shields.io/badge/✓-MUST-F43F5E) 3. Add and remove a food item from a menu.
These functionalities are implemented in **`MenusController.cs`**.

#### API Endpoints:
- **`PostMenu(menuDto)`**  
  Adds a menu object via DTO.

- **`DeleteMenu(id)`**  
  Deletes a Menu record by ID.

> Although not required, I also kept the scaffolded GET and PUT methods and implemented DTO.
>
> This method joins tables and shows a meaningful list of DTOs rather than the bare objects.
> - **`GetMenus()`**:
> Retrieves a list of menus.
> 
> - **`GetMenu(id)`**:
> Retrieves a menu record by ID.
> 
> - **`EditMenuName(id, menuDto)`**:
> Edits a menu record, selected by ID.

### ![MUST](https://img.shields.io/badge/✓-MUST-F43F5E) 4. Book, edit and cancel Food for an Event. The service should return the FoodBookingId as confirmation of the booking.
These functionalities are implemented in **`FoodBookingsController.cs`**.

![JUSTIFICATION](https://img.shields.io/badge/JUSTIFICATION-6366F1): These methods return `ClientReferenceId` instead of FoodBookingId which reduces the risk of directly exposing database ID's. This improved abstraction aligns well with API design best practices, where external consumers should interact with business-relevant data rather than internal system details.
![TODO/ALTERNATIVE](https://img.shields.io/badge/TODO%2FALTERNATIVE-2563EB): Ideally this ID should not be incremented by 1 for every new food booking record to avoid predictable behaviour which could be exploited.

#### API Endpoints:
- **`PostFoodBooking(foodBookingInputDto)`**
  <br>Takes food booking requests.
  <br>Food booking input DTO is made of `NumberOfGuests`(1-100) and `MenuId` fields.
  <br>Returns Client Reference ID if successful.

- **`PutFoodBooking(foodBookingEditInputDto)`**
  <br>Edits food bookings.
  <br>Food booking *edit* input DTO takes 3 fields of `ClientReferenceId`(Required), `NumberOfGuests` and `MenuId`.
  <br>Returns Client Reference ID if successful.

- **`DeleteFoodBooking(clientReferenceId)`**
  <br>Removes FoodBooking (hard-delete).
  <br>The method returns a confirmation message referencing the Client Reference ID of the record that is deleted.

> Again, I also kept the scaffolded GET methods and implemented DTO
> - **`GetFoodBookings()`**:
> Retrieves the list of food bookings.
> 
> - **`GetFoodBooking(id)`**:
> Retrieves a food booking record by ID.
> Used by the `CreatedAtAction()` method.

---

## Notes
- DTOs are implemented for all API methods unless deemed unnecessary to simplify input/output handling and improve readability. 
- For further details on specific methods or functionality, refer to the code in the respective API controllers.

---

#### Via the RAZOR PAGES web app, the user should be able to:
### ![MUST](https://img.shields.io/badge/✓-MUST-F43F5E) 5. Create, list and edit guests
These functionalities are implemented in **`Events/GuestList/`**.
- Create Guest:
<br>Clicking the "New Guest" on the guest list page redirects the user to **`GuestList/Create`**. The user then may enter the guest's `name`, `email` and `phone number`.

- List Guests:
<br>**`GuestList/Index`** lists all the guests.

- Edit Guests:
<br>Clicking on the "Edit" link on each guest on the guest list redirects the user to **`GuestList/Edit`**. The user then may edit the guest details.

> - Delete Guests:
> I have kept the Delete page as the need to delete a user may eventually arise.
> <br>Clicking on the "Delete" link on each guest on the guest list redirects the user to **`GuestList/Delete`**. The user then may delete the guest record.
> <br>ALTERNATIVE: Keeping the page but removing the link may be beneficial for it not to be confused with the soft-delete button.

### ![MUST](https://img.shields.io/badge/✓-MUST-F43F5E) 6. Create a new Event, specifying as a minimum its title, date and EventType
This functionality is implemented in **`Events/EventList/`**.
- Create Event:
<br>Clicking the "Create New" link above the list of events redirects the user to **`EventList/Create`**. The user then may enter the `Event Name`, `Date`, `Start Time`, `End Time` and `Event Type`. Once the user clicks the "Search" button it displays a dropdown list of available venues, suitable to the specified event type with details such as price and etc. Then the user may choose a venue from the dropdown list and click "Reserve Venue" to confirm the reservation. The user will be redirected to the venue reservation confirmation page if successful.
> When choosing a date, the user would be able to select the dates between the next day and 7 days from the current date.
> ![JUSTIFICATION](https://img.shields.io/badge/JUSTIFICATION-6366F1): This design choice is due to the fact the database context generates venue reservation slots for the next 7 days for the purpose of this demo application. 

### ![MUST](https://img.shields.io/badge/✓-MUST-F43F5E) 7. Edit an Event (except its date and type)
This functionality is implemented in **`Events/EventList/`**.
- Edit Event:
<br>Clicking the "Edit" link on an event record which will redirect the user to **`EventList/Edit`** page. The user may then edit the event name. ALTERNATIVE: Show date and event type fields but have them disabled instead of completely removing them.

### ![MUST](https://img.shields.io/badge/✓-MUST-F43F5E) 8. Book a Guest onto an Event
This functionality is implemented in **`Events/EventList/Details`**.
<br>User may click the "Add Guest" button and proceed to enter the guest details in the modal input fields. On clicking the "Add" button the page will refresh and show the newly added guest record.
![TODO/ALTERNATIVE](https://img.shields.io/badge/TODO%2FALTERNATIVE-2563EB): It would be beneficial to implement an option for users to book new guests onto events OR select from an existing list of guests. However, currently only the first option has been implemented.

### ![MUST](https://img.shields.io/badge/✓-MUST-F43F5E) 9. List Guests (including a total count) for an Event and register their attendance
This functionality is implemented in **`Events/EventList/Details`**.
<br>The list includes all the guests associated with an event and their attendance. The attendance buttons are togglable by clicking.

### ![MUST](https://img.shields.io/badge/✓-MUST-F43F5E) 10. Display the details of an individual Guest, including information about the Events with which they are associated and their attendance
This functionality is implemented in **`Events/GuestList/Details`**.
<br>This functionality shows the guest details and below that, the list of events with which they are associated and their attendance.
</details>

---

### ![SHOULD](https://img.shields.io/badge/✓-SHOULD-EAB308) 11. Cancel the booking of a guest from an upcoming Event.
This functionality is implemented in **`Events/EventList/Details`**.
<br>Clicking the "Cancel" button on each guest record row allows the user to cancel (soft-delete) the GuestBooking record by setting `IsCancelled` to `True`. Such records will be filtered and not be shown on the event details page on page reload.

### ![SHOULD](https://img.shields.io/badge/✓-SHOULD-EAB308) 12. Reserve an appropriate, available Venue for an Event via the ThAmCo.Venues web service, freeing any previously associated Venue.
This functionality is implemented in **`Events/EventList/Create`** and overlaps with [criteria 6 documentation](#-6-create-a-new-event-specifying-as-a-minimum-its-title-date-and-eventtype).
- To reserve an **appropriate** venue considering the suitabilities, the user must first enter all the event details and click the "Search Venue" button calling `OnPostSearchVenueAsync()` method, which calls two methods in different service classes to call appropriate API's and return data. A dropdown list of available venues will then appear ready for selection. The reserved venue will not be available for the other events on the same date and will be back on the dropdown list once the event is cancelled.
  - **Note**: The events are automatically assigned with a random "manage" role staff on creation.
- Clicking the "Reserve Venue" button after selecting a venue from the dropdown list calls `OnPostReserveVenueAsync()` also calls a method in the service class to communicate to the API to reserve a venue, providing the information required for the API parameters. The venue reference from the reservation confirmation will then be stored in the database so the website can refer back to it more efficiently for displaying purposes and etc.
- Freeing a venue takes a similar route. However, the button is located on the **`Events/EventList/Details`** page for enhanced user experience/navigation flow.

### ![SHOULD](https://img.shields.io/badge/✓-SHOULD-EAB308) 13. Display a list of Events that includes summary information about the Guests and Venue within it.
This functionality is implemented in **`Events/EventList/Index`**.
The page displays the list of events with event names, dates and event types. 
<br>![JUSTIFICATION](https://img.shields.io/badge/JUSTIFICATION-6366F1): The page doesn't display summary information about the guests and venue within it as that would make the page cluttered with information while the exact information is just one click away on the **`Events/EventList/Details`** page via the "Details" link button. <br>![ALTERNATIVE](https://img.shields.io/badge/ALTERNATIVE-8B5CF6): However it may be a good middleground to show the guest count for each event on the list page.

### ![SHOULD](https://img.shields.io/badge/✓-SHOULD-EAB308) 14. Create, list and edit Staff.
These functionalities are implemented in **`Events/StaffList/`**.
- List Staff: The **`Events/StaffList/Index`** page is dedicated to listing the staff members, displaying the names and roles.
  - User may click the available link buttons to create, edit or delete staff members.

### ![SHOULD](https://img.shields.io/badge/✓-SHOULD-EAB308) 15. Adjust the staffing of an Event, adding available staff or removing currently assigned staff.
This functionality is implemented in **`Events/EventList/Details`**.
- User may click on the "Add Staff" button under the Staff table element and select an "Assistant role" or a "First Aider" role staff.
- User may click on the "Remove" link button on the individual staff records to remove (hard-delete) the staffing record.

### ![SHOULD](https://img.shields.io/badge/✓-SHOULD-EAB308) 16. See appropriate warnings within the event list and staffing views when there is not a first aider assigned to an Event.
This functionality is implemented in **`Events/EventList/Details`**.
- The event details page will show a warning if events with Exhibition, Festival or Competition event types have no First Aider assigned.
  ```cs
  private void CheckFristAiderRequirement()
  {
      if(Event.EventType == "EXH" || Event.EventType == "FES" || Event.EventType == "CMP")
      {
          if(!Event.Staffings.Any(s => s.Staff.Role == "First Aider"))
          {
              ModelState.AddModelError(string.Empty, "Warning: This event requires at least one first-aider");
  ```

### ![SHOULD](https://img.shields.io/badge/✓-SHOULD-EAB308) 17. Display the details of a Staff member, including information about upcoming Events at which they are assigned to work.
This functionality is implemented in **`Events/StaffList/Details`**.
<br>The list of upcoming events with their venue codes for each staff member is shown below the basic staff details.

### ![SHOULD](https://img.shields.io/badge/✓-SHOULD-EAB308) 18. Cancel (soft delete) an Event, freeing any associated Venue and Staff.
This functionality is implemented in **`Events/EventList/Details`**.
<br>By clicking the "Cancel" button at the bottom of the page user may cancel (soft-delete) an event, calling the relevant API and freeing up the venue as well as removing the staffing records. 

![image](https://github.com/user-attachments/assets/2a1bc539-ec37-48b4-8529-4a25d6cbcc94)

---

### ![WOULD](https://img.shields.io/badge/✓-WOULD-22C55E) 19. Display the details for an Event, which must include details of the Venue, Staff and Guests – this should be more detailed that the summary information found in the Event list.
This functionality is implemented in **`Events/EventList/Details`**.
- The page displays pure event information such as event name, type and date on the right side while showing venue-related details on the right side. 
  ![image](https://github.com/user-attachments/assets/44bd1675-966c-407e-9021-2ca26fb54886)
- This may also be shown as follows when the venue reference column is not null but the venue API fails to return data successfully:
  ![image](https://github.com/user-attachments/assets/33e843df-1aaa-4f07-9055-d739d4bc95ef)
- And when the venue reference is null it shows the following:
   <br>![TODO/ALTERNATIVE](https://img.shields.io/badge/TODO%2FALTERNATIVE-2563EB): It is not required for the scope of this assignment but it would be nice to have a button that allows the user to book/rebook a venue here.
  ![image](https://github.com/user-attachments/assets/63009cc3-15eb-4992-809c-1d34c6a88182)

### ![WOULD](https://img.shields.io/badge/✓-WOULD-22C55E) 20. Permanently remove personal data by anonymising their Guest entity.
This functionality is implemented in **`Events/GuestList/Edit`**.
The button responsible for this functionality is located on the edit guest page (the delete guest page may be a better place) and anonymises user data by randomly generating strings and overwriting the personal data: 
![image](https://github.com/user-attachments/assets/f00d3117-81a6-47f8-876e-ef03b97e1be9)
<br>![JUSTIFICATION](https://img.shields.io/badge/JUSTIFICATION-6366F1):  Guest bookings associated with the guest ID are not deleted to maintain the integrity of historical event data, such as attendance records, financial reports, and event analytics, as would be essential in a real business context.
Helper method to generate randomised strings.
```cs 
private string GenerateAnonymizedIdentifier()
    return $"ANON-{Guid.NewGuid().ToString().Substring(0, 8)}";
```
Overwriting of the personal data.
```cs
string anonymizedIdentifier = GenerateAnonymizedIdentifier();
guest.Name = anonymizedIdentifier;
guest.Email = $"{anonymizedIdentifier}@anonymized.com";
guest.Phone = "XXXXXXXXXX";
```
![JUSTIFICATION](https://img.shields.io/badge/JUSTIFICATION-6366F1): Initially a simple algorithm was used to generate 4 random numbers but later Globally Unique Identifier (Guid) was implemented to generate the random numbers in `GenerateAnonymizedIdentifier();` to reduce the risk of collision. However, this still does not completely mitigate the risk of collision. ![ALTERNATIVE](https://img.shields.io/badge/ALTERNATIVE-8B5CF6): As an alternative solution to further minimise the risk of collision, Hashing could be utilised, which would not suit the scope of this specific project.

Source: https://learn.microsoft.com/en-us/dotnet/api/system.guid.newguid?view=net-9.0   

### ![WOULD](https://img.shields.io/badge/✓-WOULD-22C55E) 21. Display a detailed list of available Venues, filtered by EventType and date range, and then create a new Event by picking a result.
This functionality is implemented in **`Events/VenueList/Create`**.
Users may enter the event name, select the date, starting & ending times as well as the event type and the dropdown list of **available suitable venues** will appear. 

![IMAGE](https://github.com/user-attachments/assets/2f1082da-8230-40a4-b706-f73dd7c9ed27)
<br>![JUSTIFICATION](https://img.shields.io/badge/JUSTIFICATION-6366F1): I believe what I overengineered for a "Should" criteria should suffice for this criteria. 

### ![WOULD](https://img.shields.io/badge/✓-WOULD-22C55E) 22. See appropriate warnings within the event list and staffing views when there is fewer than one member of staff per 10 guests assigned to an Event.
This functionality is implemented in **`Events/EventList/Details`**.
An appropriate warning will be displayed when staff to guest ratio is less than 1:10 as shown below:
![brave_Go2tlfVeVG](https://github.com/user-attachments/assets/9b0f7a61-9bb9-4de8-98d2-d50aa62a9193)
This warning specifically shows the number of staff members required for the number of guests.
The helper method used to calculate:
```cs
private int GetRequiredStaffCount()
{
    int guests = Event.GuestBookings.Count();
    int staff = Event.Staffings.Count();

    // Calculate minimum required staff
    int requiredStaff = (int)Math.Ceiling(guests / 10.0);

    // Calculate how many more staff are needed
    int staffNeeded = Math.Max(0, requiredStaff - staff);

    return staffNeeded;
}
```

### ![WOULD](https://img.shields.io/badge/✓-WOULD-22C55E) 23. User access control.
Implemented within the Event project using `Microsoft.AspNetCore.Identity.EntityFrameworkCore`.
<br>Available roles are: `Admin`, `Manager`, `Assistant`, and `User`.
<br>
<br>Authorization is enforced via Policy Based Role Check.
<br>Policy/role checks are added above each page model and it determines who can access the page.
<br>Example:
```cs
[Authorize(Policy = "ElevatedAccess")]
public class CreateModel : PageModel {
``` 
The policy-based authorization controls 4 access levels.
- **`Admin Access`**: Admin only.
- **`Elevated Access`**: Admin and Manager.
- **`Employee Access`**: Admin, Manager and Assistant.
- **`Free Access`**: Admin, Manager, Assistant and Users.
<br>![TODO](https://img.shields.io/badge/TODO-3B82F6): Assign the `User` role to all newly registered accounts by default, and include an interface for promoting user permissions.

As required by the specs, 
- (Admins and) Managers can create and edit staff details (Elevated Access).
- (Admins and) Managers ~~and Team Leaders~~ can adjust the staffing of an event (Elevated Access).
> This incorporates conditional rendering on the razor page as employees would need to see the details of an event while `[Authorize]` cannot be applied to a specific method. Via conditional rendering, only the managers and admins would be able to access the `Add Staff` and `Cancel Event` buttons.
- (Admins and) Managers ~~or Team Leaders~~ can permanently delete (Elevated Access). 
<br>Other pages have also been given suitable and sensible access levels depending on the context.

>You can log in using the credentials provided below:
> - Admin:
><br>admin@example.com
><br>AdminPassword123!
>
> - Manager:
><br>manager@example.com
><br>ManagerPassword123!
>
> - Assistant:
><br>assistant@example.com
><br>AssistantPassword123!
>
> - User:
><br>user@example.com
><br>UserPassword123!

>Resources used: 
><br>https://www.c-sharpcorner.com/article/how-to-add-authentication-in-asp-net-core-6-mvc-project-using-identity/
><br>https://learn.microsoft.com/en-us/aspnet/core/security/authorization/roles?view=aspnetcore-6.0



<!--
### Web Apps and Services Project

todo:
prevent user from booking the venue in the past (booking a venue with the time technically being yesterday)
translate acronyms to meaningful words (optional)






## Scenario
<p>ThreeAmigos Corp is an event management company that arranges and oversees a range of functions, including conferences, parties and weddings for its clients. 
<br>As well as logistics, ThreeAmigos Corp organises the catering and staffing for events.</p>

<p>You have been given the responsibility of constructing a new intranet-based prototype system for
the events management team. The internal system will be used by ThreeAmigos Corp staff to
perform the key operations:<br>
  
- Manage event details;<br>
- Assign staff to events;<br>
- Attach guests to events;<br>
- Assign food orders to events;
</p>

<p>A system architecture and data model have been agreed upon by all stakeholders. It has been
decided that an existing web service will be used for reserving event venues.
<br>
It has also been decided that catering will be created as an independent web service because of the
potential for selling on as a third-party service to other companies.
<br><br>
The system architecture and data model are documented below:
</p>
![image](https://github.com/user-attachments/assets/2e3a7227-4384-43c6-acc4-18b4f571801d)<br>
![image](https://github.com/user-attachments/assets/ecebdb52-b53c-4ee1-a94b-dca5a0f50555)<br>
![image](https://github.com/user-attachments/assets/6d287baa-d608-4f76-af78-20e5e8a4f11d)<br>

## Instructions
<p>You have been provided with a Visual Studio solution containing the beginnings of the ASP.NET Core
RAZOR PAGES web app, its associated EntityFramework Core domain model, and an out-of-the-box
ASP.NET API web service. You are to continue and complete the development of this web-based
intranet system to incorporate the requirements below. The given solution also contains the code
for the venues web service – do not modify the ThAmCo.Venues project or its code. Do not modify
the ASP.NET Core runtime in any project (version 6.0)</p>

# Notes for Development Work:
- You are expected to customise the user interface and the application workflow beyond that provided by the ASP.NET scaffolding.
- You should make the best use of the ASP.NET Core and EntityFramework Core features. Refactor your code to make appropriate use of the architectural and design patterns studied in the
module.
- You should document alternative solutions to the key problems and challenges of the assignment within the source code or a readme file with any references utilised (e.g. stackoverflow.com). 
  - An example would be the choice between overloading an existing method or creating a new named method within a class.
-->
