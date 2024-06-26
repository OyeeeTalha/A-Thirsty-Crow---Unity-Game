using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesDestroyer : MonoBehaviour
{
    public int health = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        
    }
    void OnTriggerExit2D(Collider2D col){
          if(col.gameObject.name == "stone"){
            health -=1;
            this.gameObject.GetComponent<AudioSource>().Play(0);
        }
        if (col.gameObject.GetComponent<Renderer>().enabled){
            Destroy(col.gameObject);
        }

    }

}
