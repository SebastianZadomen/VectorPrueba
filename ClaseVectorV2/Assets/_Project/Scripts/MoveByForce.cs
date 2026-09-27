using UnityEngine;

public class MoveByForce : MonoBehaviour
{
    [SerializeField] public float force = 1f;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(new Vector2(force, 0f));

    }
}
