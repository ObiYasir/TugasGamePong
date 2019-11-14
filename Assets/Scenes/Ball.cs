using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Nama : Obi Yasir Lubis
// NPM  : 1614370311
public class Ball : MonoBehaviour
{
	 [SerializeField]
    float speed;

    float radius;
    Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        direction = Vector2.one.normalized;
        radius = transform.localScale.x / 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate (direction * speed * Time.deltaTime);

        if (transform.position.y < 1.5 ) {
            direction.y = -direction.y;
        }
        if (transform.position.y > -1  ) {
            direction.y = -direction.y;
        }
    //    if (transform.position.x > 3 ) {
    //        direction.x = -direction.x;
    //    }
        if (transform.position.x >3.3) {
            Debug.Log ("Left Player Wins!!");

            Time.timeScale = 0;
            enabled = false;
        }
        if (transform.position.x < -3.3) {
            Debug.Log ("Right Player Wins!!");

            Time.timeScale = 0;
            enabled = false;

        }

    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Paddle") {
            bool isRight = other.GetComponent<Paddle> ().isRight;
            
            if (isRight == true) {
                direction.x = -direction.x  ;
            }
            if (isRight == false) {
                direction.x = -direction.x;
            }
        } 
    }


}