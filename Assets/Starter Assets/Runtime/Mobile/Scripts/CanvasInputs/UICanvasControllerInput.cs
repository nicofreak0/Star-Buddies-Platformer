using UnityEngine;

namespace StarterAssets
{
    public class UICanvasControllerInput : MonoBehaviour
    {
        [Header("Output")]
        public PlayerMovement2 playerMovement;
        public RocketMovement rocketMovement;

        public void VirtualMoveInput(Vector2 virtualMoveDirection)
        {
            if(playerMovement != null)
            {
                playerMovement.MoveInput(virtualMoveDirection);
            }
            if(rocketMovement != null)
            {
                rocketMovement.MoveInput(virtualMoveDirection);
            }
        }

        public void VirtualJumpInput(bool virtualJumpState)
        {
            if(playerMovement != null)
            {
                playerMovement.JumpInput(virtualJumpState);
            }
            
        }
    }

   }
