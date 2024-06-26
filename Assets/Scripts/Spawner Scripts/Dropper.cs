using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

    private float randxBound;
    private bool check = true;
    void Start()
    {
         randxBound = Random.Range(-1.4f,1.4f);
         if(this.gameObject.name != ("stone")){
          this.gameObject.GetComponent<Renderer>().enabled = false;
         }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
     if (check){
       if ((Mathf.Round(this.transform.position.x)/1000f)== (Mathf.Round(randxBound)/1000f)){
               this.gameObject.GetComponent<Renderer>().enabled = true;
               if (this.gameObject.name==("shit")){
               this.gameObject.GetComponent<AudioSource>().Play(0);
               }
            this.transform.SetParent(this.transform.parent.transform.parent);
            this.gameObject.AddComponent<Rigidbody2D>();
            check = false;
       }
       
     }
     if (check==false && this.gameObject.name == "stone"){
          this.gameObject.transform.rotation = Quaternion.Euler(0,0,transform.rotation.z+2);
       }

    }

}
