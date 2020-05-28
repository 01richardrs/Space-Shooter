using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveConfig : MonoBehaviour
{
    public GameObject enemyPrefab;
        public int enemyFleet = 5;
    public float spawnRate = 1f;
    public int i;

    void Start(){
        StartCoroutine("Spawn");
    }
    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(3);
        while(true){
for(i=0; i<enemyFleet; i++)
        {
            Instantiate(enemyPrefab,transform.position,Quaternion.identity);

            yield return new WaitForSeconds(spawnRate);
        }
        yield return new WaitForSeconds(3);
        i = 0;
        }
        
    }

}
