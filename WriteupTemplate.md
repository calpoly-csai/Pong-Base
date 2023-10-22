## Code Exploration
- [ ] I have looked through all the important sections of the code

### Header Files
**`Pong/_Pong.cs`**

Purpose & Importance: 

Holds all necessary information to make Pong run, such as start up cache, gameplay constants,and helper functions for vector conversions.

Important Classes & Variables: 

- `static class GameConstants`: holds all the constants needed for gameplay setup such as default win score, starting positions, paddle control keys
- `static class GameCache`: holds all the cached settings of gameplay such as ball speed, angle, and win score.
- `static class GameHelpers`: helper class containing helper functions for converting vectors (3d to 2d, 2d to local, 3d to viewport).
- `class GameManager`: class declaration for implementation in GameManager.cs. To hold methods to control gameplay of Pong

**`Pong/GamePlayer/_Pong-GamePlayer.cs`**

Purpose & Importance:

Holds all player information including controls, scoring, data. File contains all neccessary player functions to run the game.

Important Classes & Variables:

- `class Player`: creates player, including: controller object, player score, paddle rebounding
- `class PlayerData`: player movement history to train AI model
- `class PlayerController`: controller class to control player paddle movement on the viewport
- `class PlayerControls`: sets keys for player paddle movement

**`Pong/Ball/_Pong-Ball.cs`**

Purpose & Importance:

File contains all ball information such as movement, ball behavior. Pong Ball declares all the neccessary methods needed for the ball object including ball movement logic and ball display on the viewport.

Important Classes & Variables:

- `class PongBall`: class containing ball behavior in cases such as initialization and scoring
- `class PongBallController`: class controlling ball movement on the viewport. Specifies how the ball should animate on the screen.
- `static class BallGoal`: class to set left player or right player serve status.

### Non-Header Files
**`/Pong/GameManager.cs`**

Purpose & Importance: 

File contols. initialization of Pong Gameplay - startup and update to every frame. 

Important Methods & Variables:

- `void Start()`: starts up Pong - initializes player and ball objects.
- `void Update()`: updates player and ball state: including location, score, movement.
- `Player player1`, player2: Player objects to hold each player.
- `PongBall ball`: Ball object to hold the pong ball.

**`Pong/GamePlayer/PlayerController.cs`**

Purpose & Importance: 

Handles player keyboard inputs and changes paddle position in game viewport and unity game object.

Important Methods & Variables:

- `void Update()`: Update() updates player paddle position. It sets the change in position of the paddles given the user inputs, and updates it in the viewport.
- `void RespondToInput()`: takes in keybaord input (up arrow key or down key) and sets deltaY accordingly.
- `void MoveY(float deltaY)`: MoveY() takes in deltaY calculated by RespondToInput and updates paddle motion in viewport.
- `Motion2D viewportMotion`: Motion2D object holding physics of paddle motion, including acceleration and velocity of paddle.
- `PlayerControls controls`: PlayerControl object holding controls for the paddles - up & down keys.

**`Pong/Ball/PongBall.cs`**

Purpose & Importance:

Important Methods & Variables:
- `void Initialize()`: Initialize sets up all necessary ball behaviors, mainly, the serve angles and direction (left, right) of each round for the ball. The angles and "player desire" are all initialized by random, and pushed onto a stack for use each round.
- `void Serve()`: Serve actually serves the ball each round: including popping a serve angle and desire from the stack, using it to set the balls trajectory in the viewport, and swapping attackers if necessary.
- `Stack<(float, bool)> serveAngles`: variable is a stack that holds all serve angles for every round. All angles (serve angle and left/right direction) are initialized at the start and popped off the stack each round.
- `Action OnScore`: OnScore is an Action variable that holds a callback function to handle whenever a player scores a point. The ball is destroyed, the score is updated, round is reset, and the ball is served again.


## Testing
**Example #1**
- Modification/Addition: Created a speed multiplier that doubled everytime Serve() was called

- Effect: Everytime the ball was served after scoring, the speed would double. This led to an increasingly fast end to the game as the ball would travel way too fast.

- [optional] What I learned:

**Example #2**
- Modification/Addition: Changed both BallGoal.LEFT and BallGoal.RIGHT to true.
- Effect: scoring would malfunction. when ball was scored on right goal, right's score would increase even if
it was left's point.
- [optional] What I learned: BallGoal.LEFT and BallGoal.RIGHT are used to keep track of which opponent is attacking when the ball is served. Since there's a mismatch between the ball desire and attacker, the point system will malfunction. This also shows that the scores are independent of what's viewed on the screen. 

**Example #3**
- Modification/Addition: Added speed to variable to serveAngles stack, set speed to a random number from 0 - 5.
- Effect: Speed would vary for rounds. Some rounds faster/slower than others.
- [optional] What I learned:

## Documentation
- Non-header file #1: `Pong/GameManager.cs`
- Non-header file #2: `Pong/GamePlayer/PlayerController.cs`
- Non-header file #3: `Pong/Ball/PongBall.cs`
- Header file #1: `Pong/_Pong.cs`
- Header file #2: `Pong/GamePlayer/_Pong-GamePlayer.cs`
- Header file #3: `Pong/Ball/_Pong-Ball.cs`
