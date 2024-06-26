using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeDown : MonoBehaviour
{
    public GameObject player;
    private GameObject spawner;
    // Start is called before the first frame update
    void Start()
    {
       player = GameObject.Find("Player"); 
       spawner = GameObject.Find("Spawner");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D col){
        if (col.gameObject.name == "Player"){
            StartCoroutine(Timer());
            }
    }
    IEnumerator Timer(){
        spawner.GetComponent<Spawner>().iftoSpawnPowerUp = false;
        this.gameObject.GetComponent<Renderer>().enabled = false;
        player.transform.localScale = new Vector2(0.1f,0.1f);
        yield return new WaitForSeconds(10);
        player.transform.localScale = new Vector2(0.15f,0.15f);
        spawner.GetComponent<Spawner>().iftoSpawnPowerUp = true;
        Destroy(this.gameObject);
        
    }
}



