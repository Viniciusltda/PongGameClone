using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_movement : MonoBehaviour
{
    public float speed = 0;
    private Rigidbody2D rb;
    private float timer = 3;
    private bool launch = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    private void Update() {
        if(launch){
            TimerCountDown();

        }

    }


    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Points")){
            launch = true;

            rb.velocity = new Vector2(0, 0);

            transform.position = new Vector3(0, 0, 0);

        }
    }

    void RandomDirection(){
        float yAxis = Random.Range(0, 2);
        float xAxis = Random.Range(0, 2) == 0 ? -1 : 1;

        rb.velocity = new Vector2(xAxis * speed, yAxis * speed);

    }

    void TimerCountDown(){
        if(timer < 0){
            timer = 3;
            launch = false;
            RandomDirection();

        }else{
            timer -= Time.deltaTime;
    
        }


    }

    private void OnCollisionEnter2D(Collision2D other) {
        GetComponent<AudioSource>().Play();

        if(rb.velocity.y == 0 && other.gameObject.CompareTag("Player") 
        || rb.velocity.y == 0 && other.gameObject.CompareTag("AI")){
            float yAxis = Random.Range(0,2) == 0 ? -1 : 1;
            rb.velocity = new Vector2(rb.velocity.x, yAxis * speed);

        }
    }
}
