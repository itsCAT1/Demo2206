using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    EventSystem system;
    public Selectable firstInput;
    public Button submitButton;
    private void Start()
    {
        system = EventSystem.current;
        firstInput.Select();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && Input.GetKey(KeyCode.LeftShift))
        {
            Selectable next = system.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnUp(); ;
            if(next != null)
            {
                next.Select();
            }
        }

        else if (Input.GetKeyDown(KeyCode.Tab))
        {
            Selectable next = system.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown(); ;
            if (next != null)
            {
                next.Select();
            }
        }
        
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            submitButton.onClick.Invoke();
            Debug.Log("Button pressed!");
            SceneManager.LoadScene(1);
        }
    }

    
}
