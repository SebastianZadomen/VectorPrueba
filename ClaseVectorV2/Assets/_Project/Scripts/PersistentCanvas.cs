using UnityEngine;

public class PersistentCanvas : MonoBehaviour
{
	public static PersistentCanvas Instancia;
	private void Awake()
	{
		if (Instancia != null && Instancia != this)
		{
			Destroy(gameObject);
			return;
		}

		Instancia = this;

		DontDestroyOnLoad(gameObject);
	}
}
