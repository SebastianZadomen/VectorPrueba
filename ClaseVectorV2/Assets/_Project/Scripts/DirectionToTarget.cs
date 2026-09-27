using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class DirectionToTarget : MonoBehaviour
{
    [SerializeField] public Transform target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(transform.position, target.position , Color.red);
    }
}
