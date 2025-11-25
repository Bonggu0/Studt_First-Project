using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using static InputSystem_Actions;

[CreateAssetMenu(fileName = "PlayerInputReader", menuName = "PlayerInputReader")]
public class InputReader : ScriptableObject, IPlayerActions
{
    private InputSystem_Actions _actions;

    private Vector2 _dir;

    public Vector2 Dir() { return _dir; }

    public void Initialize()
    {
        _actions = new InputSystem_Actions();
        _actions.Player.SetCallbacks(this);

        _actions.Enable();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        _dir = context.ReadValue<Vector2>();
    }
    
    public void OnAttack(InputAction.CallbackContext context)
    {
    }

    public void OnCrouch(InputAction.CallbackContext context)
    {
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
    }

    public void OnJump(InputAction.CallbackContext context)
    {
    }

    public void OnLook(InputAction.CallbackContext context)
    {
    }

    public void OnNext(InputAction.CallbackContext context)
    {
    }

    public void OnPrevious(InputAction.CallbackContext context)
    {
    }

    public void OnSprint(InputAction.CallbackContext context)
    {
    }
}
