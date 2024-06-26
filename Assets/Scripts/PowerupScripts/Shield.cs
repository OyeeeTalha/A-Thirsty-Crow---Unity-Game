using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{   public GameObject player;
    private GameObject spawner;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        spawner = GameObject.Find("Spawner");
    }

        
    void OnTriggerEnter2D(Collider2D col){
        if (col.gameObject.name == "Player"){
            StartCoroutine(ShieldEffect());
        }
    }
    IEnumerator ShieldEffect(){
        spawner.GetComponent<Spawner>().iftoSpawnPowerUp = false;
        this.gameObject.GetComponent<Renderer>().enabled = false;
        player.transform.GetChild(0).gameObject.SetActive(true);
        player.GetComponent<GameMechanics>().checkshield = true;
        yield return new WaitForSeconds(10);
        player.transform.GetChild(0).gameObject.SetActive(false);
        player.GetComponent<GameMechanics>().checkshield = false;
        spawner.GetComponent<Spawner>().iftoSpawnPowerUp = true;
        Destroy(this.gameObject);
    }
    
}
