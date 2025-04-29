# Interior Designer Factory

## Project Overview

This project demonstrates the use of the **Abstract Factory** design pattern to simulate an interior design program.

## Structure

### Abstract Classes

- **`Wardrobe`**  

- **`Desk`**  

- **`InteriorDesigner`**  
  Abstract factory with two key methods:
  - `Desk ProduceDesk(int priceLimit)`
  - `Wardrobe ProduceWardrobe(int priceLimit)`

### Concrete Factories

- **`ClassicInteriorDesigner`**
- **`ModernInteriorDesigner`**
- **`ScandinavianInteriorDesigner`**
- **`VintageInteriorDesigner`**

## Features

- Implementation of the **Abstract Factory** design pattern in C#.
- Easy to extend with new styles or furniture models.
