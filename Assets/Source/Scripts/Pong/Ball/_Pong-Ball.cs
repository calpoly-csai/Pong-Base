// * NAMESPACE HEADER FILE

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Pong;

namespace Pong.Ball {
    /*
     * Player lastTouchedBy
     * Destroys the ball and increments points
    */
    /// <summary>
    /// class dictating ball behavior in the context of gameplay such as scoring, 
    /// whos on offensive, ball behavior on serve and score.
    /// </summary>
    public partial class PongBall {}

    /*
     * Handle collisions -> adjust trajectory
       speedX = GameCache.BALL_SPEED_VP
       velocityY = ForceAdjustment => Equation (due to possible derivatives) 
    */
    /// <summary>
    /// actual movement of the ball across the viewport. angles on rebounds, general trajectory
    /// </summary>
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

    /// <summary>
    /// set condition of whether it is the left players turn to serve or right players turn
    /// </summary>
    public static class BallGoal {
        public const bool LEFT = true;
        public const bool RIGHT = false;

        // Note: we don't even need an INVERT() function because the ! operator already does that with bools! 
    }
}