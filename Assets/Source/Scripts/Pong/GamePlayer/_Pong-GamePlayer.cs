// * NAMESPACE HEADER FILE

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pong.GamePlayer {
    /// <summary>
    /// Player object handles player actions such as initialization of  
    /// paddle size and collision ‘walls’, paddle movement and sprite initialization,
    /// and scoring 
    /// </summary>
    public partial class Player {}

    /// <summary>
    /// Stores player data and gameplay history for use in RL training
    /// </summary>
    public partial class PlayerData : ScriptableObject {}
    //public partial class AIPlayerData : PlayerData {}

    /// <summary>
    /// Controls the physical player paddle that appears on the game screen, as well
    /// as interpreting user input from keyboard controls.
    /// </summary>
    public partial class PlayerController : MonoBehaviour {}

    /// <summary>
    /// Stores player control scheme
    /// </summary>
    public class PlayerControls {
        public readonly KeyCode Up, Down;
        public PlayerControls(KeyCode up, KeyCode down) {
            Up = up;
            Down = down;
        }
    }
}