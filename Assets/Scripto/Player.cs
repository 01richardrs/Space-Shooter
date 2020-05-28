using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   public int moveSpeed = 10;
   float xMin,xMax;
   float yMin,yMax;
   public GameObject laserPrefab;
    public int projectileSpeed;
    private float firingPeriod = 0.5f;

   void Start(){
       SetupGameBoundaries();
   }
   void Update(){
    //    if(Input.GetKey("up")){
        // Move2();
    //    }else{
        Move();
    //    }
       
       if(Input.GetButtonDown("Fire1"))
       {
           StartCoroutine("Fire");
       }
       if(Input.GetButtonUp("Fire1"))
       {
           StopCoroutine("Fire");
       }
   }

   void Move(){
       float deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
         
        float newXPos = transform.position.x + deltaX;
        newXPos = Mathf.Clamp(newXPos,xMin,xMax);
   
        transform.position = new Vector2(newXPos,transform.position.y);
      
    float deltaY = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        float newYPos = transform.position.x + deltaY;
        newYPos = Mathf.Clamp(newYPos,yMin,yMax);
        //Y not work
    //     transform.position = new Vector2(transform.position.y,newYPos);
        // transform.position = new Vector3(newXPos,0,newYPos);
   
   }

    public void SetupGameBoundaries(){
        Camera gameCamera = Camera.main;

        xMin = gameCamera.ViewportToWorldPoint(new Vector3(0,0,0)).x;
        xMax = gameCamera.ViewportToWorldPoint(new Vector3(1,0,0)).x;
        yMin = gameCamera.ViewportToWorldPoint(new Vector3(0,0,0)).y;
        yMax = gameCamera.ViewportToWorldPoint(new Vector3(1,0,0)).y;
    }

    IEnumerator Fire(){
 while (true)
    {
          GameObject laser = Instantiate(laserPrefab, transform.position, Quaternion.identity) as GameObject;
        laser.GetComponent<Rigidbody2D>().velocity = new Vector2(0, projectileSpeed * Time.deltaTime); 
        yield return new WaitForSeconds(firingPeriod);
    }
    }
   

}
