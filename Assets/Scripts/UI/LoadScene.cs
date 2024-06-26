using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void PlayGame(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }

    public void HowToPlay(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(6);
    }


    public void QuitGame(){
        Application.Quit();
    }
}
