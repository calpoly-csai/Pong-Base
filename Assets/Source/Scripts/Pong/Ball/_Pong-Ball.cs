// * NAMESPACE HEADER FILE
/*
Important for the pong ball logic and physics to work properly in the game.
The class PongBall in this file is extremely important; it handles how the velocity and collisions work with the ball
The class PongBallController in this file is extremely important; it holds the functionality of the actual goals when the ball scores in goal
The class BallGoal in this file is extremely important; it holds the boolean values for the left and right goal
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Pong;

namespace Pong.Ball {
    /*
     * Player lastTouchedBy
     * Destroys the ball and increments points
    */
    public partial class PongBall {}

    /*
     * Handle collisions -> adjust trajectory
       speedX = GameCache.BALL_SPEED_VP
       velocityY = ForceAdjustment => Equation (due to possible derivatives) 
    */
    public partial class PongBallController : MonoBehaviour {}

    /*public static class BallStatus {
        private const int GOAL = 1;

        public const int GOAL_LEFT = -GOAL;
        public const int NO_GOAL = 0;
        public const int GOAL_RIGHT = GOAL;
        public const int REBOUNDED = 2;

        public static int INVERT(int ballStatus) {
            return ballStatus * -1;
        }

        public static bool IsGoal(int ballStatus) {
            return Mathf.Abs(ballStatus) == GOAL;
        }
    }*/

    public static class BallGoal {
        public const bool LEFT = true;
        public const bool RIGHT = false;

        // Note: we don't even need an INVERT() function because the ! operator already does that with bools! 
    }
}