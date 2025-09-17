Pong Replica (Unity)

This is a recreation of the classic Atari Pong, developed in Unity with modern features such as smooth physics, enemy AI, and a simple score system.

🎮 Features

Player paddle controlled with the mouse.

Enemy paddle that tracks the ball with basic AI.

Ball physics with bouncing mechanics.

Randomized ball direction at each reset.

Score system with UI display.

Game reset after scoring.

🛠️ Project Setup

Unity Version: Developed in Unity 6.1 (can run in newer versions).

Scene Setup:

Two paddles (Player & Enemy).

Ball with Rigidbody2D and Collider2D.

Walls and score zones with colliders and tags.

UI Text elements using TextMeshPro for score display.

Main Camera set to Orthographic.

📂 Scripts Overview
Core.cs

Acts as the central controller of the game.

Holds references to GameManager, Ball, PlayerController, and Enemy.

Ensures all systems are enabled at startup.

public class Core : MonoBehaviour
{
    public static Core Instance;
    [SerializeField] public GameManager _gameManager;
    [SerializeField] public ball _ball;
    [SerializeField] public PlayerController _playerController;
    [SerializeField] public Enemy _enemy;

    void Awake()
    {
        _gameManager.enabled = true;
        _ball.enabled = true;
        _playerController.enabled = true;
        _enemy.enabled = true;
    }
}

GameManager.cs

Manages the score system.

Updates the UI with player and computer points.

Hides the mouse cursor during gameplay.

PlayerController.cs

Player paddle is controlled by mouse position.

Smooth movement with physics (Rigidbody2D.MovePosition).

Enemy.cs

AI paddle follows the ball's y position.

Adds a bit of randomness to avoid perfect prediction.

Moves using physics for consistency.

ball.cs

Handles ball movement and collisions.

Maintains constant speed (linearVelocity.normalized * speedBall).

Detects collision with paddles and walls.

Updates score when the ball hits player or computer score zones.

Resets position with random direction after each point.

🎯 How It Works

At the start, the ball spawns at the center with a randomized direction.

The player moves their paddle with the mouse.

The enemy AI follows the ball's y axis with limited speed.

When the ball collides with a paddle, its direction changes based on the hit point.

If the ball crosses a score zone:

A point is awarded.

The ball resets after a short delay.

🚀 Next Steps / Possible Improvements

Add difficulty levels (AI speed scaling).

Add sound effects for collisions and scoring.

Add UI start menu and pause menu.

Support for 2 players (keyboard or gamepad).

Post-processing effects to improve visuals.

📷 Preview

<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/5652a7bf-0d5e-4964-8d20-36fdef73501b" />

https://ulyssespita.itch.io/rize-pong
