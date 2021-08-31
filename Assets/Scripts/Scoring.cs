using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Scoring : MonoBehaviour
{
    public UnityEvent scoreTrigger;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        BallMovement ball = collision.gameObject.GetComponent<BallMovement>();

        if (ball != null)
        {
            this.scoreTrigger.Invoke();
        }
    }
}
