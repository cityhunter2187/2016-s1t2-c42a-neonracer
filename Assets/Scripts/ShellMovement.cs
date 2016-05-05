using UnityEngine;
using System.Collections;

public class ShellMovement : MonoBehaviour
{
    float forward_velocity_max = 8;
    public Rigidbody rb;
    GameObject player;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        rb.AddForce(player.transform.forward * 10);

    }
    public void FixedUpdate()
    {
        if(rb.velocity.magnitude > forward_velocity_max)
        {
            rb.velocity = rb.velocity.normalized * forward_velocity_max;
        }
        rb.AddForce(rb.velocity * 150);
    }
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Banana")
        {
            Destroy(gameObject);
            Destroy(col.gameObject);
        }
    }
}
