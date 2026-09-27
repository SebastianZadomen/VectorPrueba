using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int score = 0;

    [SerializeField] public string[] Scene;
    private int CountScene = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void AddScore(int points)
    {
        score += points;
        Debug.Log("moneda ");
        if (score > 15)
        {
            Debug.Log("Cambio de escene");
            SceneManager.LoadScene(Scene[CountScene]);
            CountScene++;
            score -= 15;
        }
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
