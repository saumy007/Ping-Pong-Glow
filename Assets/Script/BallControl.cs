using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public float startSpeed;
    public float extraSpeed;
    public float maxextraSpeed;

    private float hitcounter;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Launch());
    }

    public IEnumerator Launch()
    {
        hitcounter = 0;
        yield return new WaitForSeconds(1);

        MoveBall(new Vector2(-1, 0));
    }  




    public void MoveBall(Vector2 direction)
    {
        direction = direction.normalized;

        float ballspeed = startSpeed + hitcounter * extraSpeed;

        rb.velocity = direction * ballspeed;

    }

    public void IncreaseHitCounter()
    {
        if(hitcounter * extraSpeed < maxextraSpeed)
        {
            hitcounter++;
        }

    }
    
}
