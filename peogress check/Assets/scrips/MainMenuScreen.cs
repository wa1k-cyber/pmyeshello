using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuScreen : MonoBehaviour
{
    public int Lives = 10;
    public void StartGame()
    {
        SceneManager.LoadScene("5 coin");
        PlayerPrefs.SetInt("Lives", Lives);
    }
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Canvas>().enabled = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame1()
    {
        SceneManager.LoadScene("5 coin");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
