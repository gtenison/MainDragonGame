using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 5;
    public Vector2 moveInput;
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        rb.freezeRotation = true;   
    }

    void Update()
    {
        rb.linearVelocity = moveSpeed * moveInput;
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>().normalized;

        // 4 direction movement system
        if (Mathf.Abs(moveInput.x) > Mathf.Abs(moveInput.y))
        {
            moveInput.y = 0;
        }
        else
        {
            moveInput.x = 0;
        }
    }
}
