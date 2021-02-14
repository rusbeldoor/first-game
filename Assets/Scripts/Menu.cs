using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void ButtonStart()
    {
        SceneManager.LoadScene("Game");
    }
    public void ButtonBack()
    {
        SceneManager.LoadScene("Menu");
    }
    void Start()
    {
        // Instantiate at position (0, 0, 0) and zero rotation.
        
    }

}
