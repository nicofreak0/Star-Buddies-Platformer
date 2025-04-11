using UnityEngine;

namespace StarterAssets
{
    public class UICanvasControllerInput : MonoBehaviour
    {
        [Header("Output")]
        public PlayerMovement2 playerMovement;
        public RocketMovement rocketMovement;

        public void VirtualMoveUp(bool virtualMoveDirection)
        {
            if(rocketMovement != null)
            {
                rocketMovement.MoveUpInput(virtualMoveDirection);
            }
        }
        public void VirtualMoveDown(bool virtualMoveDirection)
        {
            if (rocketMovement != null)
            {
                rocketMovement.MoveDownInput(virtualMoveDirection);
            }
        }

        public void VirtualMoveLeft(bool virtualMoveDirection)
        {
            if (playerMovement != null)
            {
                playerMovement.MoveLeftInput(virtualMoveDirection);
            }
            if (rocketMovement != null)
            {
                rocketMovement.MoveLeftInput(virtualMoveDirection);
            }
        }

        public void VirtualMoveRight(bool virtualMoveDirection)
        {
            if (playerMovement != null)
            {
                playerMovement.MoveRightInput(virtualMoveDirection);
            }
            if (rocketMovement != null)
            {
                rocketMovement.MoveRightInput(virtualMoveDirection);
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
