using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public Text tscore;
    [SerializeField] int points = 10;
    public GameObject exploison;

    private void Start(){
        GameObject scoreText = GameObject.Find("Score");
        tscore = scoreText.GetComponent<Text>();
    }
    private void OnTriggerEnter2D(Collider2D hit){
        if(hit.gameObject.tag == "Laser"){
            int iscore = int.Parse(tscore.text) + points ;
            // tscore.text = iscore.ToString();
            tscore.text = iscore.ToString();
            Instantiate(exploison, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
            Destroy(hit.gameObject);
        }
    }
    
}
