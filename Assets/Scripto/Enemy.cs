using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject paths; 
    public float moveSpeed = 2f;
    int waypointIndex= 0;


    void Start(){
        this.transform.position = paths.transform.GetChild(waypointIndex).transform.position;
    }
    
    void Update(){
        if(waypointIndex< paths.transform.childCount)
        {

            var targetPosition = paths.transform.GetChild(waypointIndex).transform.position;
            float move = moveSpeed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, move);
           

            if(transform.position == targetPosition){
                waypointIndex++;
            }
        }else{
            // Destroy(this.gameObject);
            
        }
    }
    

}
