using UnityEngine;

public class MoveByVelocity : MonoBehaviour
{
    [SerializeField]public float speed = 1f;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = new Vector2(speed, 0f);

    }
}
