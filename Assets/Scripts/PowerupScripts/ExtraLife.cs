using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraLife : MonoBehaviour
{   private GameObject health;
    private GameObject spawner;

    // Start is called before the first frame update
    void Start()
    {
        health = GameObject.Find("BackGround");
        spawner = GameObject.Find("Spawner");
    }

        
    void OnTriggerEnter2D(Collider2D col){
        if (col.gameObject.name == "Player"){
            StartCoroutine(AddLife());
        }
    }
    IEnumerator AddLife(){
        spawner.GetComponent<Spawner>().iftoSpawnPowerUp = false;
        this.gameObject.GetComponent<Renderer>().enabled = false;
        if (health.GetComponent<ParticlesDestroyer>().health < 5){
            health.GetComponent<ParticlesDestroyer>().health += 1;
        }
        yield return new WaitForSeconds(10);
        spawner.GetComponent<Spawner>().iftoSpawnPowerUp = true;
        Destroy(this.gameObject);
    }
    
}

