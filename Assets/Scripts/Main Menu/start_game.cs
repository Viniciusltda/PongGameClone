using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start_game : MonoBehaviour
{
    public void PlayerVsPlayer(){
        SceneManager.LoadScene("Game");

    }

    public void PlayerVsAI(){
        SceneManager.LoadScene("Game2");

    }
}
