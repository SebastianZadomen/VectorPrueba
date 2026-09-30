using UnityEngine;

public class ButtonPause : MonoBehaviour
{

		public GameObject Menu;
	public GameObject SettingButton;
		public bool IsActive = false;

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
		Menu.SetActive(true);
		}

		public void Resume()
		{
	
		Time.timeScale = 1.0f;
		SettingButton.SetActive(true);
		Menu.SetActive(false);
	}
	}