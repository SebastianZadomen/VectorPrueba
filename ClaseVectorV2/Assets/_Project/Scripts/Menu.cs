using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonPause : MonoBehaviour
{
	public static ButtonPause Instance;
	public GameObject MenuOptions;
	public GameObject SettingButton;
	private void Awake()
    {
		MenuOptions.SetActive(false);
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
    private void Start()
    {
    }
    private void Update()
	{
		
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Pause();
		}
	}

	public void Pause()
	{
		Time.timeScale = 0.0f;
		SettingButton.SetActive(false);
		MenuOptions.SetActive(true);
	}

	public void Resume()
	{
		Time.timeScale = 1.0f;
		SettingButton.SetActive(true);
		MenuOptions.SetActive(false);
	}
	public void Restart()
	{
		Time.timeScale = 1.0f;
		SceneManager.LoadScene(GameManager.Instance.Scene[GameManager.Instance.CountScene]);
	}
}