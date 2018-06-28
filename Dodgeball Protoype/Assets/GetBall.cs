using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GetBall : MonoBehaviour {
    GameObject[] balls;
    GameObject closeBall;
    private int frames = 0;

    void MoveToBall ()
    {
        
    }

    void FindClose()
    {
        
        foreach (GameObject ball in balls)
        {
            if (closeBall == null)
            {
                closeBall = ball;
            }
            if (Vector2.Distance(gameObject.transform.position, ball.transform.position) < Vector2.Distance(gameObject.transform.position, closeBall.transform.position))
            {
                closeBall = ball;
            }
        }        
    }


    // Use this for initialization
    void Start () {
        balls = GameObject.FindGameObjectsWithTag("Ball");
        InvokeRepeating("FindClose", 0f, 1f);
    }
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), closeBall.transform.position, 3 * Time.deltaTime);

    }
}
