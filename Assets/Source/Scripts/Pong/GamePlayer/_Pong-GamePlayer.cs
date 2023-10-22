// * NAMESPACE HEADER FILE
/*
Important for the player controls and data to work properly.
The class PlayerControls in this file is extremely important; it holds the controls for the player to use (input for the game)
The class PlayerData in this file is extremely important; it holds the player data (which will probably be used for the AI)
The class PlayerController in this file is extremely important; it holds the behavior type for the controller
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Holds controls for the player to use (up and down), holds the player data in this file for the AI, and also holds the behavior type for the controller.
/// </summary>
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