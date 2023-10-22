//namespace Pong.GamePlayer;
using Pong.GamePlayer;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Pong.Physics;

using static Pong.GameCache;
using static Pong.GameHelpers;

namespace Pong.GamePlayer {
    public partial class PlayerController : MonoBehaviour
    {
        // parameters of trajectory; x velocity and beyond will ALWAYS be 0. For the sake of simplicity, any derivative beyond acceleration will be 0
        // contains base viewport velocity (Vector2) and float[] yAccelerationAndBeyond in terms of viewport percentage y
        private readonly Motion2D viewportMotion = new Motion2D(); // this tracks motion, rather than controlling it

        private bool isInitialized = false;
        public PlayerControls controls;

        public void InitializeControls(PlayerControls controls) {
            this.controls = controls;
            isInitialized = true;
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        /// <summary>
        /// Update() is called to update the player paddle movement in the viewport.
        /// At a high level, it gets the current motion of the paddles, and sets the 
        /// next position of the paddles in the viewport.
        /// </summary>
        /// <returns>void</returns>
        
        // Update is called once per frame
        void Update()
        {
            if (!isInitialized) {
                return;
            }

            float deltaY = RespondToInput();

            //* Track Motion
            // calculate velocity at this frame
            Vector3 deltaPos = new Vector3(0f, deltaY, 0f);
            Vector2 viewportVelocity = ToViewport(deltaPos) / Time.deltaTime;

            // calculate acceleration at this frame
            float deltaYVelocity = viewportVelocity.y - viewportMotion.velocity.y;
            float viewportYAcceleration = deltaYVelocity / Time.deltaTime;

            // set the new velocity and acceleration
            viewportMotion.velocity.Set(viewportVelocity.x, viewportVelocity.y);
            viewportMotion.Y_Acceleration = viewportYAcceleration;
        }

        /// <summary>
        /// RespondToInput() takes the keybord input and sets new change in 
        /// paddle position in the Unity GameObject. It calculates the change in 
        /// position through the function DeltaY().
        /// </summary>
        /// <returns>a float representing the change in y value for the paddle</returns>
        protected float RespondToInput() {
            float dy = 0f;

            if (Input.GetKey(controls.Up)) {
                dy += DeltaY();
            }

            if (Input.GetKey(controls.Down)) {
                dy += -DeltaY();
            }

            //* Now that all the movement updates have been collected, time to apply them
            MoveY(dy);

            // return the change in y
            return dy;
        }

        protected float DeltaY() {
            // ToLocal() but with a single value rather than a whole ass vector
            float dy_dt = PLAYER_SPEED_VP * BG_TRANSFORM.localScale.y;
            
            return dy_dt * Time.deltaTime;
        }

        /// <summary>
        /// takes a float deltaY that was calculated from DeltaY(), to change the 
        /// paddle position in Unity GameObject. It accounts for changes that causes
        /// object to move out of bounds.
        /// </summary>
        /// <returns>void</returns>
        public void MoveY(float deltaY) {
            // origin is in the center
            float MAX_Y_POS = BG_TRANSFORM.localScale.y / 2f;
            float halfPaddleLength = transform.localScale.y / 2f;
            
            float topEdgeY = transform.localPosition.y + halfPaddleLength;
            float bottomEdgeY = transform.localPosition.y - halfPaddleLength;

            if (topEdgeY + deltaY > MAX_Y_POS || bottomEdgeY + deltaY < -MAX_Y_POS) { // not allowed to move out of bounds
                return;
            }

            // moving will not take it out of bounds
            transform.localPosition += new Vector3(0f, deltaY, 0f);
        }

        public bool IsInitialized() { return isInitialized; }
        public Motion2D GetViewportMotionTracker() { return viewportMotion; }
    }
}