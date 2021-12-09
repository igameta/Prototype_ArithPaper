using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PenControl penControl;

    private void Awake()
    {
        penControl = new PenControl();
    }

    private void OnEnable()
    {
        penControl.Enable();
    }

    private void OnDisable()
    {
        penControl.Disable();
    }

    private void start()
    {
        penControl.Input.PenTip.started += ctx => StartTip(ctx);
        penControl.Input.PenTip.canceled += ctx => EndTip(ctx);
    }

    private void StartTip(InputAction.CallbackContext context)
    {
        Debug.Log("Tipped!" + penControl.Input.PenPosition.ReadValue<Vector2>());
    }

    private void EndTip(InputAction.CallbackContext context)
    {
        Debug.Log("UnTipped!");
    }
}
