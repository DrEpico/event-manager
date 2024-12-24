# ThAmCo Project Requirements
This project involves managing food items and menus for the Catering system and Event management system, adhering to the functional requirements outlined below. API methods utilise DTOs to simplify input and output handling, unless deemed unnecessary.

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
-->
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

> Although not required, I also kept the scaffolded GET and PUT methods and implemented DTO
> - **`GetMenus()`**:
> Retrieves a list of menus.
> 
> - **`GetMenu(id)`**:
> Retrieves a menu record by ID.
> 
> - **`EditMenuName(id, menuDto)`**:
> Edits a menu record, selected by ID.

### ![MUST](https://img.shields.io/badge/✓-MUST-F43F5E) 4. Book, edit and cancel Food for an Event - see the ERD above for details. The service should return the FoodBookingId as confirmation of the booking.
These functionalities are implemented in **`FoodBookingsController.cs`**.

#### API Endpoints:
- **`PostFoodBooking(foodBookingInputDto)`**
  <br>Takes food booking requests.
  <br>Food booking input DTO is made of `NumberOfGuests`(1-100) and `MenuId` fields. 

- **`PutFoodBooking(foodBookingEditInputDto)`**
  <br>Edits food bookings.
  <br>Food booking *edit* input DTO takes 3 fields of `ClientReferenceId`(Required), `NumberOfGuests` OR `MenuId` OR both 

- **`DeleteFoodBooking(clientReferenceId)`**
  <br>Removes FoodBooking (hard delete).
  <br>The service returns the booking detail by FoodBookingId as confirmation of the booking.

> Again, I also kept the scaffolded GET methods and implemented DTO
> - **`GetFoodBookings()`**:
> Retrieves the list of food bookings.
> 
> - **`GetFoodBooking(id)`**:
> Retrieves a food booking record by ID.

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

### ![MUST](https://img.shields.io/badge/✓-MUST-F43F5E) 7. Edit an Event (except its date and type)
This functionality is implemented in **`Events/EventList/`**.
- Edit Event:
<br>Clicking the "Edit" link on an event record which will redirect the user to **`EventList/Edit`** page. The user may then edit the event name. ALTERNATIVE: Show date and event type fields but have them disabled instead of completely removing them.

### ![MUST](https://img.shields.io/badge/✓-MUST-F43F5E) 8. Book a Guest onto an Event
This functionality is implemented in **`Events/EventList/Details`**.
<br>User may click the "Add Guest" button and proceed to enter the guest details in the modal input fields. On clicking the "Add" button the page will refresh and show the newly added guest record.
ALTERNATIVE/TODO: It would be beneficial to implement an option for users to book new guests onto events OR select from an existing list of guests. However, currently only the first option has been implemented.

### ![MUST](https://img.shields.io/badge/✓-MUST-F43F5E) 9. List Guests (including a total count) for an Event and register their attendance
This functionality is implemented in **`Events/EventList/Details`**.
<br>The list includes all the guests associated with an event and their attendance. ALTERNATIVE/TODO: The attendance checkbox may better be interactable and changes saved in the database.

### ![MUST](https://img.shields.io/badge/✓-MUST-F43F5E) 10. Display the details of an individual Guest, including information about the Events with which they are associated and their attendance
This functionality is implemented in **`Events/GuestList/Details`**.
<br>This functionality shows the guest details and below that, the list of events with which they are associated and their attendance.

### ![SHOULD](https://img.shields.io/badge/✓-SHOULD-EAB308) 11. Cancel the booking of a guest from an upcoming Event.
This functionality is implemented in **`Events/EventList/Details`**.
<br>Clicking the "Cancel" button on each guest record row allows the user to cancel (soft-delete) the GuestBooking record by setting `IsCancelled` to `True`. Such records will be filtered and not be shown on the event details page on page reload.

### ![SHOULD](https://img.shields.io/badge/✓-SHOULD-EAB308) 12. Reserve an appropriate, available Venue for an Event via the ThAmCo.Venues web service, freeing any previously associated Venue.
This functionality is implemented in **`Events/EventList/Create`** and overlabs with [criteria 6 documentation](#must-6-create-a-new-event-specifying-as-a-minimum-its-title-date-and-eventtype).
- To reserve an **appropriate** venue considering the suitabilities, user must first enter all the event details and click the "Search Venue" button calling `OnPostSearchVenueAsync()` method, which calls two methods in different service classes to call appropriate API's and return data. A dropdown list of available venues will then appear ready for selection. The reserved venue would not be available for the other events on the same date and will be back to the dropdown list once the event is cancelled.
  - **Note**: The events are automatically assigned with a random "manage" role staff on creation.
- Clicking the "Reserve Venue" button after selecting a venue from the dropdown list calls `OnPostReserveVenueAsync()` also calls a method in the service class to communicate to the API to reserve a venue, providing the information required for the API parameters. The venue reference from the reservation confirmation will then be stored in the database so the website can refer back to it more efficiently for displaying purposes and etc.
- Freeing a venue takes a similar route. However the button is located on the **`Events/EventList/Details`** page for enhanced user experience/navigation flow.

### ![SHOULD](https://img.shields.io/badge/✓-SHOULD-EAB308) 13. Display a list of Events that includes summary information about the Guests and Venue within it.
This functionality is implemented in **`Events/EventList/Index`**.
The page displays the list of events with event names, dates and event type. 
<br>JUSTIFICATION: The page doesn't display summary information about the guests and venue within it as that would make the page cluttered with information while the exact information is just one click away on the **`Events/EventList/Details`** page via the "Details" link button. <br>ALTERNATIVE: However it may be a good middleground to show the guest count for each event on the list page.

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
