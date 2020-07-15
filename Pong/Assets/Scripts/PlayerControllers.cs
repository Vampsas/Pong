
using UnityEngine;

public class PlayerControllers : MonoBehaviour
{
   public KeyCode moveUp;
    public KeyCode moveDown;
    public float speed = 10;
    public Rigidbody2D rb;
    // Update is called once per frame
    
    void Update()
    {
        rb = GetComponent<Rigidbody2D>();
        if (Input.GetKey(moveUp))
        {
            rb.velocity = new Vector3(0, speed, 0);
        }
        else if (Input.GetKey(moveDown))
        {
            rb.velocity = new Vector3(0, speed * (-1), 0);
        }
        else
        {
            rb.velocity = new Vector3(0, 0, 0);
        }
    }
}
