using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Nama : Obi Yasir Lubis
// NPM  : 1614370311
public class Paddle : MonoBehaviour
{
	[SerializeField]
    float speed;
	float height;

	string input;
	public bool isRight;

    // Start is called before the first frame update
    void Start()
    {
    	height = transform.localScale.x;
    	   
    }

    public void Init(bool isRightPaddle){
    	isRight = isRightPaddle;
    	Vector2 pos =  Vector2.zero;

    	if(isRightPaddle){
    		pos = new Vector2(GameManager.topRight.x, 0);
    		pos -= Vector2.right * transform.localScale.y;
            input = "PaddleRight";
    	}else{
    		pos = new Vector2(GameManager.bottomLeft.x, 0 );
    		pos += Vector2.right * transform.localScale.y;
    	    input = "PaddleLeft";
        }
    	transform.position = pos;
        transform.name = input;
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis(input) * Time.deltaTime*speed;
        transform.Translate (move*Vector2.up);
        
        if(transform.position.x < GameManager.bottomLeft.x + height / 2 && move < 0){
            move = 0;
        }
        if(transform.position.x > GameManager.topRight.x - height / 2 && move > 0){
            move = 0;
        }
        transform.Translate (move * Vector2.up);
    }
}
