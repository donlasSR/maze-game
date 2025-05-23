# 2D Maze Game

This is a simple 2D maze game developed using C# and Windows Forms. Navigate the player through the maze to reach the goal!

## Features

* **Keyboard Control:** Move the player using 'W', 'A', 'S', 'D' keys.
* **Collision Detection:** The player cannot pass through the black walls.
* **Win Condition:** A message box appears when the player reaches the yellow goal area, and the application exits.

## Technologies Used

* C#
* .NET Framework 4.7.2
* Windows Forms

## Installation and Running

1.  **Clone the repository (if applicable):**
    ```bash
    git clone [your-repository-url]
    ```
2.  **Open in Visual Studio:**
    Open the `.sln` file (solution file) in Visual Studio.
3.  **Build the Project:**
    Build the solution within Visual Studio (Build > Build Solution).
4.  **Run the Application:**
    Start the application by pressing F5 or clicking the "Start" button in Visual Studio.

## How to Play

1.  The game window will appear with a maze.
2.  Your player (a blue square) starts at a specific position.
3.  Use the following keys to move the player:
    * **W**: Move Up
    * **S**: Move Down
    * **A**: Move Left
    * **D**: Move Right
4.  Navigate the player through the maze, avoiding the black walls.
5.  Reach the yellow area to win the game.

## Project Structure

* `App.config`: Configuration file for the application, specifying the .NET Framework version.
* `Form1.cs`: Contains the main logic for the game, including player movement, collision detection, and win condition.
* `Form1.Designer.cs`: Auto-generated code for the design of the main form, including the maze layout (black `Label` controls for walls, `PictureBox` for the player, and `Label` for the goal).
* `Program.cs`: The entry point of the application.

## License

This project is open-source and available under the [MIT License](LICENSE) (if you choose to add one).
