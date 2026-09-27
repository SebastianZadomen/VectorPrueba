using System.Net.Sockets;
using Unity.VisualScripting;
using UnityEngine;

public class SmartTurret : MonoBehaviour
{
	[SerializeField] private Transform target;
	[SerializeField] private GameObject bulletPrefab;
	[SerializeField] private float visionRange = 6f;
	[SerializeField] private float timeBetweenShots = 0.3f;
	[SerializeField] private float bulletSpeed = 5f;
	[SerializeField] private float bulletLifetime = 3f;

	private SpriteRenderer spriteRenderer;
	private float shotTimer = 1.5f;
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
		spriteRenderer = GetComponent<SpriteRenderer>();

	}

	// Update is called once per frame
	void Update()
    {
		Vector2 direction = (target.position - transform.position).normalized;
		RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, visionRange);
		Debug.DrawRay(transform.position, direction * visionRange, Color.yellow);

		if (hit.collider != null && hit.collider.CompareTag("Player") )
		{
			float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
			transform.eulerAngles = new Vector3(0, 0, angle);
			spriteRenderer.color = Color.red;

			shotTimer +=  Time.deltaTime;
			if (shotTimer >= timeBetweenShots)
			{
				Debug.Log("bala");
				Shot(direction);

				shotTimer = 0f;
			}
		}
		else
		{
			spriteRenderer.color = Color.white;
			shotTimer = 0f;
		}

	}
	void Shot(Vector2 direction)
	{
		GameObject bulletClone = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
		Rigidbody2D bulletRB = bulletClone.GetComponent<Rigidbody2D>();
		bulletRB.linearVelocity = direction * bulletSpeed;
        Destroy(bulletClone, bulletLifetime);
    }
}
