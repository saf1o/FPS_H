using UnityEngine;

public class GameManager : MonoBehaviour
{
    Rigidbody rb; 
    [SerializeField] private float speed = 3.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        // Wキーで前進
        if (Input.GetKey(KeyCode.W))
        {
            rb.linearVelocity = transform.forward * speed;
        }
        // Aキーで左方向
        if (Input.GetKey(KeyCode.A))
        {
            rb.linearVelocity = - transform.right * speed;
        }
        // Sキーで後退
        if (Input.GetKey(KeyCode.S))
        {
            rb.linearVelocity = - transform.forward * speed;
        }
        // Dキーで右方向
        if (Input.GetKey(KeyCode.D))
        {
            rb.linearVelocity =  transform.right * speed;
        }
    }
}
