using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class points_logic : MonoBehaviour
{
    public Text text;
    public bool isPlayer;
    private int count = 0;


    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Ball")){
            count++;
            GetComponent<AudioSource>().Play();

            EndGame();

            text.text = count.ToString();

        }
    }

    private void EndGame(){
        if(count == 10 && isPlayer){
            SceneManager.LoadScene("Player_wins");

        }else if(count == 10 && !isPlayer){
            SceneManager.LoadScene("AI_wins");

        }
    }
}
