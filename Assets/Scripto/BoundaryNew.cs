using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryNew : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D hit){
        if(hit.tag == "Laser2"){
            Destroy(hit.gameObject);
            Debug.Log("laser recognized and destroyed!");
        }
    }
}
