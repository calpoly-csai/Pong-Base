<<<<<<< HEAD
// * NAMESPACE HEADER FILE
=======
/// <summary>
/// File seems to unify the player controls, and later the data for the AI
/// PlayerData: not currently implemented but will be crucial later for letting the AI control the paddle
/// PlayerControls: synthesizes the controls for players by deciding what each key decides 
/// </summary>
>>>>>>> f106512 (Added summary via comments on headers & other important files)

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pong.GamePlayer {
    public partial class Player {}

    public partial class PlayerData : ScriptableObject {}
    //public partial class AIPlayerData : PlayerData {}

    public partial class PlayerController : MonoBehaviour {}

    public class PlayerControls {
        public readonly KeyCode Up, Down;
        public PlayerControls(KeyCode up, KeyCode down) {
            Up = up;
            Down = down;
        }
    }
}