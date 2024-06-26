using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameMechanics : MonoBehaviour
{
    public bool checkshield = false;

    public bool check = true;

    public int minLevel;
    public int currentLevel;
    public WaterLevel waterlevel;
    public GameObject retryPanel;

    public GameObject nextLevelPanel;

    public GameObject health;

    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
        minLevel = 100;
        }

        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
        minLevel = 150;
        }

        else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
        minLevel = 200;
        }

        else if (SceneManager.GetActiveScene().buildIndex == 4)
        {
        minLevel = 250;
        }

        else if (SceneManager.GetActiveScene().buildIndex == 5)
        {
        minLevel = 300;
        }
        currentLevel = minLevel;
        waterlevel.waterAtMinLevel(minLevel);
        health=GameObject.Find("BackGround");
    }


    void Update(){
        if (health.GetComponent<ParticlesDestroyer>().health ==0 && check){
            Retry();
            check=false;
        }

        if (currentLevel ==0 && check){
            NextLevel();
            check= false;
        }
    }


    void OnTriggerEnter2D(Collider2D col){
        if (col.gameObject.name == "stone"){
            this.transform.GetChild(1).gameObject.SetActive(true);
            this.transform.GetChild(1).gameObject.GetComponent<AudioSource>().Play(0);
            currentLevel -=10;
            Debug.Log(currentLevel);
            waterlevel.setWaterLevel(currentLevel);
            Destroy(col.gameObject);
        }
        if(col.gameObject.name == "shit"){
            if (checkshield==false){
            this.transform.GetChild(1).gameObject.SetActive(true);
            this.transform.GetChild(1).gameObject.GetComponent<AudioSource>().Play(0);
            this.transform.GetChild(2).gameObject.GetComponent<AudioSource>().Play(0);

            Retry();
            }
            else{
                Destroy(col.gameObject);
            }
        }
    }

    void OnTriggerExit2D(Collider2D obj){
        if (obj.gameObject.name == ("shit")){
        Destroy(obj.gameObject);
        }
    }

    public void Retry(){
        Time.timeScale = 0f;
        retryPanel.SetActive(true);
    }

    public void NextLevel(){
        Time.timeScale = 0f;
        nextLevelPanel.SetActive(true);
    }
}


