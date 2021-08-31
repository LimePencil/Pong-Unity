using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D ballBody;
    public float speed = 400f;
    void Awake()
    {
        ballBody = GetComponent<Rigidbody2D>();
    }
    void addStartingForce()
    {
        float x = 1f;
        if (Random.Range(0, 2) == 0)
        {
            x = -1f;
        }
        float y = Random.value < 0.5f ? Random.Range(-0.8f, -0.3f): Random.Range(0.3f, 0.8f);
        Debug.Log(y);
        ballBody.AddForce(new Vector2(x, y) * speed);


    }
    public void resetPosition()
    {
        Debug.Log("Reset Ball");
        ballBody.position = Vector2.zero;
        ballBody.velocity = Vector2.zero;
        addStartingForce();
    }

}
