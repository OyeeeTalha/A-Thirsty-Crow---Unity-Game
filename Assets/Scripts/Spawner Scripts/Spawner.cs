using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{
    public GameObject stone,shit;
    public float xBound,yBound;

    public bool iftoSpawnPowerUp = true;
    private int occurance;

    public List<GameObject> PowerUps = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
        StartCoroutine(SpawnerObjectsLevel0());
        }

        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
        StartCoroutine(SpawnerObjectsLevel1());
        }

        else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
        StartCoroutine(SpawnerObjectsLevel2());
        }

        else if (SceneManager.GetActiveScene().buildIndex == 4)
        {
        StartCoroutine(SpawnerObjectsLevel3());
        }

        else if (SceneManager.GetActiveScene().buildIndex == 5)
        {
        StartCoroutine(SpawnerObjectsLevel4());
        }
    }

    void Update()
    {
        
    }

   IEnumerator SpawnerObjectsLevel0()
   {
        yield return new WaitForSeconds(Random.Range(1,5));
        occurance = Random.Range(0,11);

        if (occurance <=7){
            if (Random.value <0.5f){
            Instantiate(stone , new Vector2(xBound+1,yBound),transform.rotation*Quaternion.Euler(0,0,0));
            }
            else{
                Instantiate(stone , new Vector2(-xBound-1,yBound),transform.rotation*Quaternion.Euler(0,180,0));

            }
        }

        else if (occurance > 7 && occurance <= 9){
           if (Random.value <0.5f){
            Instantiate(shit , new Vector2(xBound+1,yBound),transform.rotation*Quaternion.Euler(0,0,0));
            }
            else{
                Instantiate(shit , new Vector2(-xBound-1,yBound),transform.rotation*Quaternion.Euler(0,180,0));

            }
        }

        else {
            if(iftoSpawnPowerUp){
                if (Random.value <0.5f){
                Instantiate(PowerUps[Random.Range(0,3)] , new Vector2(xBound+1,yBound),transform.rotation*Quaternion.Euler(0,0,0));
                }
                else{
                    Instantiate(PowerUps[Random.Range(0,3)] , new Vector2(-xBound-1,yBound),transform.rotation*Quaternion.Euler(0,180,0));

                }
            }

        }

        StartCoroutine(SpawnerObjectsLevel0());


   }


   IEnumerator SpawnerObjectsLevel1()
   {
        yield return new WaitForSeconds(Random.Range(1,4));
        occurance = Random.Range(0,11);

        if (occurance <=7){
            if (Random.value <0.5f){
            Instantiate(stone , new Vector2(xBound+1,yBound),transform.rotation*Quaternion.Euler(0,0,0));
            }
            else{
                Instantiate(stone , new Vector2(-xBound-1,yBound),transform.rotation*Quaternion.Euler(0,180,0));

            }
        }

        else if (occurance > 7 && occurance <= 9){
           if (Random.value <0.5f){
            Instantiate(shit , new Vector2(xBound+1,yBound),transform.rotation*Quaternion.Euler(0,0,0));
            }
            else{
                Instantiate(shit , new Vector2(-xBound-1,yBound),transform.rotation*Quaternion.Euler(0,180,0));

            }
        }

        else {
            if(iftoSpawnPowerUp){
                if (Random.value <0.5f){
                Instantiate(PowerUps[Random.Range(0,3)] , new Vector2(xBound+1,yBound),transform.rotation*Quaternion.Euler(0,0,0));
                }
                else{
                    Instantiate(PowerUps[Random.Range(0,3)] , new Vector2(-xBound-1,yBound),transform.rotation*Quaternion.Euler(0,180,0));

                }
            }

        }

        StartCoroutine(SpawnerObjectsLevel1());


   }

   IEnumerator SpawnerObjectsLevel2()
   {
        yield return new WaitForSeconds(Random.Range(1,3));
        occurance = Random.Range(0,11);

        if (occurance <=7){
            if (Random.value <0.5f){
            Instantiate(stone , new Vector2(xBound+1,yBound),transform.rotation*Quaternion.Euler(0,0,0));
            }
            else{
                Instantiate(stone , new Vector2(-xBound-1,yBound),transform.rotation*Quaternion.Euler(0,180,0));

            }
        }

        else if (occurance > 7 && occurance <= 9){
           if (Random.value <0.5f){
            Instantiate(shit , new Vector2(xBound+1,yBound),transform.rotation*Quaternion.Euler(0,0,0));
            }
            else{
                Instantiate(shit , new Vector2(-xBound-1,yBound),transform.rotation*Quaternion.Euler(0,180,0));

            }
        }

        else {
            if(iftoSpawnPowerUp){
                if (Random.value <0.5f){
                Instantiate(PowerUps[Random.Range(0,3)] , new Vector2(xBound+1,yBound),transform.rotation*Quaternion.Euler(0,0,0));
                }
                else{
                    Instantiate(PowerUps[Random.Range(0,3)] , new Vector2(-xBound-1,yBound),transform.rotation*Quaternion.Euler(0,180,0));

                }
            }

        }

        StartCoroutine(SpawnerObjectsLevel2());


   }


   IEnumerator SpawnerObjectsLevel3()
   {
        yield return new WaitForSeconds(Random.Range(1,3));
        occurance = Random.Range(0,11);

        if (occurance <=5){
            if (Random.value <0.5f){
            Instantiate(stone , new Vector2(xBound+1,yBound),transform.rotation*Quaternion.Euler(0,0,0));
            }
            else{
                Instantiate(stone , new Vector2(-xBound-1,yBound),transform.rotation*Quaternion.Euler(0,180,0));

            }
        }

        else if (occurance > 5 && occurance <= 9){
           if (Random.value <0.5f){
            Instantiate(shit , new Vector2(xBound+1,yBound),transform.rotation*Quaternion.Euler(0,0,0));
            }
            else{
                Instantiate(shit , new Vector2(-xBound-1,yBound),transform.rotation*Quaternion.Euler(0,180,0));

            }
        }

        else {
            if(iftoSpawnPowerUp){
                if (Random.value <0.5f){
                Instantiate(PowerUps[Random.Range(0,3)] , new Vector2(xBound+1,yBound),transform.rotation*Quaternion.Euler(0,0,0));
                }
                else{
                    Instantiate(PowerUps[Random.Range(0,3)] , new Vector2(-xBound-1,yBound),transform.rotation*Quaternion.Euler(0,180,0));

                }
            }

        }

        StartCoroutine(SpawnerObjectsLevel3());


   }
   IEnumerator SpawnerObjectsLevel4()
   {
        yield return new WaitForSeconds(Random.Range(1,2));
        occurance = Random.Range(0,11);

        if (occurance <=7){
            if (Random.value <0.5f){
            Instantiate(stone , new Vector2(xBound+1,yBound),transform.rotation*Quaternion.Euler(0,0,0));
            }
            else{
                Instantiate(stone , new Vector2(-xBound-1,yBound),transform.rotation*Quaternion.Euler(0,180,0));

            }
        }

        else if (occurance > 7 && occurance <= 9){
           if (Random.value <0.5f){
            Instantiate(shit , new Vector2(xBound+1,yBound),transform.rotation*Quaternion.Euler(0,0,0));
            }
            else{
                Instantiate(shit , new Vector2(-xBound-1,yBound),transform.rotation*Quaternion.Euler(0,180,0));

            }
        }

        else {
            if(iftoSpawnPowerUp){
                if (Random.value <0.5f){
                Instantiate(PowerUps[Random.Range(0,3)] , new Vector2(xBound+1,yBound),transform.rotation*Quaternion.Euler(0,0,0));
                }
                else{
                    Instantiate(PowerUps[Random.Range(0,3)] , new Vector2(-xBound-1,yBound),transform.rotation*Quaternion.Euler(0,180,0));

                }
            }

        }

        StartCoroutine(SpawnerObjectsLevel4());


   }

}
