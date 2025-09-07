using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public float obstacleHealth;

    private void OnCollisionEnter2D(Collision2D collosion)
    {
        if(collosion.relativeVelocity.magnitude < obstacleHealth)
        {
            obstacleHealth -= collosion.relativeVelocity.magnitude;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
