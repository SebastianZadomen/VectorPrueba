using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.UI.Image;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]public float speed = 5f;
    [SerializeField] public float jumpForce = 7f;
    public float rayLength = 0.6f;
    public LayerMask groundLayer;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    bool IsGrounded()
    {
        Debug.DrawRay(transform.position, Vector2.down * rayLength, Color.red);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, rayLength, groundLayer);
        return hit.collider != null;
    }
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal"); 
        rb.linearVelocity = new Vector2(horizontal * speed, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            Debug.Log("space");
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
        
    }

}
