using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   public void LoadStartMenu(){
       SceneManager.LoadScene(0);
   }

    public void LoadGame(){
        SceneManager.LoadScene("Game");
    }

    public void LoadGameOver(){
        StartCoroutine(CountSeconds());
    }

    IEnumerator CountSeconds(){
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Game_Over");
    }

    public void LoadLobby(){
       SceneManager.LoadScene("Menu");
   }

    public void QuitGame(){
        Application.Quit();
    }

}
