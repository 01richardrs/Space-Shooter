using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scores : MonoBehaviour
{
    public Text Skor;
    // Start is called before the first frame update
    void Start()
    {
        int finalScore = PlayerPrefs.GetInt("Score",0);
        GameObject scoreText = GameObject.Find("Score");
        Skor = scoreText.GetComponent<Text>();
        Skor.text = finalScore.ToString();
    }

}
