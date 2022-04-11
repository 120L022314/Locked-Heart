using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseAsButton : MonoBehaviour
{
    public string Name;
    public string SceneName;
    public GameObject other;
    private void OnMouseUpAsButton()
    {
        if (other.name == Name) 
            SceneManager.LoadScene(SceneName);
        else if(other.name == "Ending")
            Application.Quit();
    }
}
