using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerData pld;
    Rigidbody2D rb;
    [SerializeField] private Transform groundcheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private float checkRadius = 0.2f;

    bool isGround;

    Vector2 vec2;


    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        
    }

    public void OnMove(InputValue value)
    {
        vec2=value.Get<Vector2>();
    }
    public void OnJump(InputValue value)
    {
        if (!value.isPressed) return;

        if (isGround)
        {
            GoJump();
        }
    }
    void Update()
    {
        isGround = Physics2D.OverlapCircle(groundcheck.position, checkRadius, groundLayer);
    }

    void GoJump()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, pld.jp);
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector3(vec2.x * pld.sp, rb.linearVelocity.y, 0);
    }

}
