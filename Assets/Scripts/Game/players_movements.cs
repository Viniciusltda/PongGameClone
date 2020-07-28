using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class players_movements : MonoBehaviour
{
    public float speed = 0;
    public bool isAI;


    private void FixedUpdate() {
        if(isAI){
            transform.Translate(0f, Input.GetAxis("Vertical2") * speed * Time.deltaTime, 0f);

        }else{
            transform.Translate(0f, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0f);
            
        }


    }
}
