using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupDropper : MonoBehaviour
{

    private float randxBound;
    private bool check = true;
    void Start()
    {
         randxBound = Random.Range(-1.5f,1.5f);
         this.gameObject.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
     if (check){
       if ((Mathf.Round(this.transform.position.x)/1000f)== (Mathf.Round(randxBound)/1000f)){
               this.gameObject.GetComponent<Renderer>().enabled = true;
            this.transform.SetParent(this.transform.parent.transform.parent);
            this.gameObject.AddComponent<Rigidbody2D>().gravityScale=0.2f;
            check = false;
       }
       
     }

    }

}
