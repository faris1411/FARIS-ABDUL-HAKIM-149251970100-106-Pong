using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // Load game scene
    public void PlayGame()
    {
        Debug.Log("Created by FARIS ABDUL HAKIM - 149251970100-106");
        SceneManager.LoadScene("Game");
    }
    // Author button
    public void OpenAuthor()
    {
        Debug.Log("Created by Faris");
    }
    // Load credit scene
    public void Credit()
    {
        SceneManager.LoadScene("Credit");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
