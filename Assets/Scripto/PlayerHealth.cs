using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public Text t_health;
    public Text tscore;
    [SerializeField] int health;
    public GameObject exploison;
    void Start()
    {
        GameObject healthText = GameObject.Find("Health");
        t_health = healthText.GetComponent<Text>();
        t_health.text = health.ToString();
        GameObject scoreText = GameObject.Find("Score");
        tscore = scoreText.GetComponent<Text>();
    }

    private void OnTriggerEnter2D(Collider2D hit){
        if(hit.gameObject.tag == "Laser2"){
            health -= 1;
            t_health.text = health.ToString();
            Destroy(hit.gameObject);
            if(health<=0){
                GameOver();
            }
        }
    }

    void GameOver(){
        int iscore = int.Parse(tscore.text) ;
    
        Debug.Log("Game Over!");
        Instantiate(exploison, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
        PlayerPrefs.SetInt("Score", iscore);
        SceneManager.LoadScene("Game_Over");
    }
}
