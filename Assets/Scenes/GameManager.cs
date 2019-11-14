using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Nama : Obi Yasir Lubis
// NPM  : 1614370311
public class GameManager : MonoBehaviour
{
	public Ball Ball;
	public Paddle Paddle;

	public static Vector2 bottomLeft;
	public static Vector2 topRight;

    // Start is called before the first frame update
    void Start()
    {
    	bottomLeft = Camera.main.ScreenToWorldPoint (new Vector2(0,0));
    	topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

    	Instantiate(Ball);

    	Paddle Paddle1 = Instantiate(Paddle) as Paddle;
    	Paddle Paddle2 = Instantiate(Paddle) as Paddle;
    	Paddle1.Init(true);
    	Paddle2.Init(false);
    }

}
