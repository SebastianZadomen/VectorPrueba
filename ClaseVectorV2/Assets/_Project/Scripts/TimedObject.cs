using UnityEngine;

public class TimedObject : MonoBehaviour
{
    [SerializeField] private ObjectPool pool;
    [SerializeField] private float lifeTime = 3f;

    private float timer;
	void Start()
    {
        
    }
    public void SetPool(ObjectPool newPool)
    {
        pool = newPool;
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= lifeTime)
        {
            pool.ReturnObject(gameObject);
            
        }

    }
    private void OnEnable()
    {
        timer = 0;
    }
}
