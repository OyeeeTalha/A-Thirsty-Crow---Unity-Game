using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public void Resume(){
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        }

    public void Pause(){
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        }
    public void Restart(){
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        public void RestartGame(){
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
        }

    public void MainMenu(){

        SceneManager.LoadScene(0);
    }

    public void NextLevel(){
       pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }    
}
