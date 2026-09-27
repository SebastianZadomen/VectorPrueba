using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour, InputSystem_Actions.IPrueba1Actions
{
    private InputSystem_Actions inputActions;
    private Rigidbody2D rg;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        inputActions = new InputSystem_Actions();
        inputActions.Prueba1.SetCallbacks(this);
    }

    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void OnJump(InputAction.CallbackContext context)
	{
        if (context.performed)
        {
            //falta algo 
        }
	}

	public void OnNewaction(InputAction.CallbackContext context)
	{
		throw new System.NotImplementedException();
	}

}
