using UnityEngine;

public class VirtualInput : MonoBehaviour
{
    [Header("Output")]
    public PlayerMovement2 StarterAssetsInputs;

    public void VirtualMoveInput(Vector2 virtualMoveDirection)
    {
        StarterAssetsInputs.MoveInput(virtualMoveDirection);
    }

    public void VirtualJumpInput(bool virtualJumpState)
    {
        StarterAssetsInputs.JumpInput(virtualJumpState);
    }
}
