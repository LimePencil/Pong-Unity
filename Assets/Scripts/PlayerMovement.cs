using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private string name;
    private bool left = false;
    private Rigidbody2D playerBody;
    public float speed = 10f;
    void Awake()
    {
        name = gameObject.name;
        playerBody = GetComponent<Rigidbody2D>();
        if (name.Equals("LeftPlayer"))
        {
            left = true;
        }

    }

    private void FixedUpdate()
    {
        Vector2 dir = Vector2.zero;
        if (left)
        {
            if (Input.GetKey(KeyCode.W))
            {
                dir = Vector2.up;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                dir = Vector2.down;
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                dir = Vector2.up;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                dir = Vector2.down;
            }
        }
        playerBody.AddForce(dir * speed);
    }
    public void ResetPlayer()
    {
        playerBody.position = new Vector2(this.playerBody.position.x, 0);
        playerBody.velocity = Vector2.zero;
    } 
}
