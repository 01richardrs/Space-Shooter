using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public GameObject laserPrefab;
    public int speed = - 200;
    public float rate = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
      InvokeRepeating("Shoot",1.0f,rate);  
    }

    // Update is called once per frame
    void Shoot()
    {
        GameObject laser = Instantiate(laserPrefab, transform.position, Quaternion.identity) as GameObject;
        laser.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed * Time.deltaTime );
    }
}
