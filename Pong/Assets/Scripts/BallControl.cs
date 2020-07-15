using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class BallControl : MonoBehaviour
{
     Rigidbody2D rb;
     public int ballSpeed = 100;
     public AudioSource audioSource;
 
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        Invoke("GoBall", 2f);
       
    }
    void Update()
    {
        rb = GetComponent<Rigidbody2D>();
        float xVel = rb.velocity.x;
        if (xVel < 22 && xVel > -22 && xVel != 0)
        {
            if (xVel > 0)
            {
                rb.velocity =  new Vector3(20, rb.velocity.y, 0);
            }
            else
            {
                rb.velocity = new Vector3(-20, rb.velocity.y, 0);
            }
            Debug.Log("VElocity " + rb.velocity.x);
        }
        
    }
    
    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag.Equals("Player"))
        {
            Vector3 v = GetComponent<Rigidbody2D>().velocity;
            v.y = rb.velocity.y / 2 + collision.collider.attachedRigidbody.velocity.y / 3;
            GetComponent<Rigidbody2D>().velocity = v;
            audioSource.pitch = Random.Range(0.8f, 1.2f);
            audioSource.PlayOneShot(audioSource.clip, 0.5f)
;        }
    }
    //Resteing ball
    void ResetBall()
    {
        Debug.Log("RESET");
        rb= GetComponent<Rigidbody2D>();
        // rb.velocity.Set(0, 0);
        rb.velocity = Vector3.zero;
         //  GetComponent<Rigidbody2D>().velocity = v;
        transform.position = new Vector2(0, 1.12f);
        Invoke("GoBall", 1f);
        //WaitForBall();
    }
    void GoBall()
    {
        Debug.Log("GO Ball");
        int randomNumber = Random.Range(0, 2);
        if (randomNumber <= 0.5)
        {
            rb = GetComponent<Rigidbody2D>();
            rb.AddForce(new Vector3(ballSpeed, 10), 0);

        }
        else
        {
            rb = GetComponent<Rigidbody2D>();
            rb.AddForce(new Vector3(-ballSpeed, -10), 0);
        }
    }
    //Delay after rest
    //IEnumerator WaitForBall()
    //{
    //    print(Time.time);
    //    yield return new WaitForSeconds(1f);
    //    Debug.Log("Waaiting!!!!");
    //    GoBall();
    //}
}
