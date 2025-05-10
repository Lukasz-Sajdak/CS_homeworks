
# Tourist Trip Planner

## Overview
This C# project demonstrates the **Command Design Pattern** by simulating a tourist trip planning system. The system allows you to schedule and execute various tourist activities in a city, such as visiting museums, eating at restaurants, taking walks in parks, and shopping for souvenirs.

Each activity is represented by a command object that encapsulates the action to be performed, while the `TripScheduler` class acts as the invoker that manages the sequence of activities. The project provides an example of how commands can be used to decouple the request for an action from its execution, allowing flexible trip planning and scheduling.

## Structure
The project consists of the following components:

### Receivers (Tourist Attractions):
Each of the following classes represents a tourist activity or attraction:
- **Museum**: Method `WatchExhibits(string hour, int ticketPrice)` – Simulates a visit to an exhibition.
- **Restaurant**: Method `EatMeal(string dish, int duration)` – Simulates a meal at a restaurant.
- **Park**: Method `TakeWalk(int minutes, string weather)` – Simulates a walk in the park.
- **SouvenirShop**: Method `BuySouvenir(string item, int price)` – Simulates shopping for souvenirs.

### Command Interface:
- **IVisitTouristAttraction**: Interface defining the method `Visit()` that each concrete command class implements.

### Concrete Commands:
Each concrete command corresponds to a tourist activity and stores the parameters necessary for its execution:
- **VisitMuseumCommand**: Encapsulates a visit to the museum.
- **VisitRestaurantCommand**: Encapsulates a visit to the restaurant.
- **VisitParkCommand**: Encapsulates a visit to the park.
- **VisitSouvenirShopCommand**: Encapsulates a visit to the souvenir shop.

### Invoker:
- **TripScheduler**: This class holds a list of commands and executes them in the specified order using the method `Trip()`.

### Client:
- **Program.cs**: The client creates different trip scenarios with various orders of attractions and custom parameters for each activity. The trip is executed using the `TripScheduler` class.

## Conclusion
This project illustrates how the **Command Pattern** can be used to simplify the design of a trip planner. By encapsulating each tourist activity as a command object, the system allows easy modifications and extensions, such as adding new activities or changing the order of the trip.
