using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ai_movement : MonoBehaviour
{
    public GameObject ball;
    private Rigidbody2D _rb;
    public float speed;
    private Vector2 _ballVelocity;

    
    void FixedUpdate()
    {
        _ballVelocity = ball.GetComponent<Rigidbody2D>().velocity;

        if(_ballVelocity.x > 0f){
            if(ball.transform.position.y > transform.position.y){
                transform.Translate(0f, speed * Time.deltaTime, 0f);

            }else if(ball.transform.position.y < transform.position.y){
                transform.Translate(0f, -speed * Time.deltaTime, 0f);

            } 
        }
    }
}
