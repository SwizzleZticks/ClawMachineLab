# Claw Machine OOP Exercise

## Task
Create a program that simulates a claw machine using Object-Oriented Programming (OOP) principles.

## Application Functionality
The application utilizes a static class for the ClawMachine. Using the ClawMachine’s static methods, users can "play" the claw machine. A random reward will be chosen and displayed to the user. Depending on the value of that reward, the user will be alerted if they made a profit.

## Build Specifications

### Class: Reward
The `Reward` class should have the following properties:
- `string Name`
- `decimal Value`

#### Constructor
The constructor should take in `name` and `value` as parameters and assign them to the associated properties.

### Class: ClawMachine
The `ClawMachine` should be a static class with the following properties:
- `List<Reward> AllRewards`
  - Name: “Cheap candy”, Cost: 0.50
  - Name: “Cheap candy”, Cost: 0.50
  - Name: “Cheap candy”, Cost: 0.50
  - Name: “Candy Bar”, Cost: 1.00
  - Name: “Candy Bar”, Cost: 1.00
  - Name: “Stuffed Animal”, Cost: 10.00
- `decimal CostToPlay = 1.50`

### Static Methods
The `ClawMachine` class should include the following static methods:

1. **GetReward**
   - **Returns:** A `Reward`.
   - **Parameters:** None.
   - **Description:** Randomly selects a reward and returns it.

2. **MadeProfit**
   - **Returns:** `bool`.
   - **Parameters:** Takes in a `Reward` as a parameter.
   - **Description:** Checks if the value of the reward is greater than the `CostToPlay`. Returns `true` if so, otherwise returns `false`.

3. **Play**
   - **Returns:** None.
   - **Parameters:** None.
   - **Description:** Calls `GetReward` and saves the reward in a variable. Displays the name of the item in the console. Passes that reward into `MadeProfit`; if it returns `true`, displays “You made a profit” in the console. If it returns `false`, displays “You lost money” in the console.

### Main Program
In the main program, call the ClawMachine’s static `Play` method.
