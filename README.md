# ThAmCo Project Requirements
This project involves managing food items and menus for the Catering system, adhering to the functional requirements outlined below. API methods utilise DTOs to simplify input and output handling, unless deemed unnecessary.

## Functional Requirements
# Must (Critical requirements)
![MUST](https://img.shields.io/badge/✓-MUST-F43F5E)    <!-- Complete -->
![MUST](https://img.shields.io/badge/△-MUST-F43F5E)     <!-- In Progress -->
![MUST](https://img.shields.io/badge/✗-MUST-F43F5E)    <!-- Not Done -->

# Should (Recommended features)
![SHOULD](https://img.shields.io/badge/✓-SHOULD-EAB308)
![SHOULD](https://img.shields.io/badge/△-SHOULD-EAB308)
![SHOULD](https://img.shields.io/badge/✗-SHOULD-EAB308)

# Would (Nice to have)
![WOULD](https://img.shields.io/badge/✓-WOULD-22C55E)
![WOULD](https://img.shields.io/badge/△-WOULD-22C55E)
![WOULD](https://img.shields.io/badge/✗-WOULD-22C55E)
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
- For further details on specific methods or functionality, refer to the code in the respective controllers (`MenuItemsController.cs` and `MenuFoodItemsController.cs`).

---

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
