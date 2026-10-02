using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;
using System.Linq;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int score = 0;
    public TMP_Text TextScore;
	public string[] Scene;
    public int CountScene = 0;
    
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
    private void ManagerScore()
    {
        TextScore.text = $"Score : {score}";
    }
    public void AddScore(int points)
    {
        score += points;
        Debug.Log("moneda ");
        if (score > 15)
        {
			
			Debug.Log("Cambio de escena");
            ManagerScene();
			CountScene++;
			score -= 15;
        }
		ManagerScore();

	}
	public void ManagerScene()
    {
        if (CountScene == Scene.Length - 1)
        {
            CountScene = 0;
        }
        else
        {
			
			SceneManager.LoadScene(Scene[CountScene]);
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
