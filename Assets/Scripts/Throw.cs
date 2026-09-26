using UnityEngine;

public class Throw : MonoBehaviour
{
    private Rigidbody rb;
    public float throwForce = 10f;
    public float throwUpwardForce = 10f;
    public Vector3 spawnPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        spawnPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ThrowBall();
        }
    }

    // void FixedUpdate()
    // {
        
    // }

    public void ThrowBall()
    {
        rb.AddForce((Vector3.forward * throwForce) + (Vector3.up * throwUpwardForce), ForceMode.Impulse);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Boundary"))
        {
            ResetBall();
        }
    }
    public void ResetBall()
    {
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        transform.position = spawnPosition;
    }
}
