using UnityEngine;

public class Throw : MonoBehaviour
{
    private Rigidbody rb;
    public float throwForce = 10f;
    public float throwUpwardForce = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce((Vector3.forward * throwForce) + (Vector3.up * throwUpwardForce), ForceMode.Impulse);
        }
    }
}
