using UnityEngine;
using UnityEngine.InputSystem;

public class ZanonPlayerManager : MonoBehaviour
{
    public static ZanonPlayerManager Instance { get; private set; }
    
    public Vector2 currentMoveInput;
    public bool sprintPressed;

    private void Awake()
    {
        Instance = this;
        currentMoveInput = Vector2.zero;
    }

    private void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>();
        Debug.Log("Move Input: " + moveInput);
        currentMoveInput = moveInput;
    }

    private void OnSprint(InputValue value)
    {
        sprintPressed = value.isPressed;
    }
}
