// * NAMESPACE HEADER FILE

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pong.GamePlayer {

    /// <summary>
    /// Class to hold player data and functions such as moving the controls, score, etc.
    /// To be implemented in Player.cs.
    /// </summary>
    public partial class Player {}

    /// <summary>
    /// Class to hold player data history such as paddle movement and ball location to train
    /// AI to control paddle better.
    /// </summary>
    public partial class PlayerData : ScriptableObject {}
    //public partial class AIPlayerData : PlayerData {}

    /// <summary>
    /// Class to control player paddle movement such as moving paddle up and down when user presses up and down keys.
    /// </summary>
    public partial class PlayerController : MonoBehaviour {}

    /// <summary>
    /// sets up controls players can make - up and down keys
    /// </summary>
    public class PlayerControls {
        public readonly KeyCode Up, Down;
        public PlayerControls(KeyCode up, KeyCode down) {
            Up = up;
            Down = down;
        }
    }
}