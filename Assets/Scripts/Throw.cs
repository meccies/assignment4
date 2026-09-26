using UnityEngine;

public class Throw : MonoBehaviour
{
    private Rigidbody rb;
    public float throwForce = 10f;
    public float throwUpwardForce = 10f;
    public Vector3 spawnPosition;
    public float resetDelay = .5f;
    public float resetTimer = 0f;
    public bool haswon = false;
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
        if (haswon)
            {
                Debug.Log("Reset Timer: " + resetTimer);
                resetTimer -= Time.deltaTime;
                if (resetTimer <= 0f)
                {
                    Debug.Log("Resetting Ball");
                    ResetBall();
                    resetTimer = 0f; // Reset the timer after resetting the ball
                    haswon = false; // Reset the win condition
                }
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
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("WinColider"))
        {
            Debug.Log("Win!");
            haswon = true;
            resetTimer = resetDelay; // Set the reset timer to the delay value to trigger immediate reset

            // resetTimer += Time.deltaTime;
            // if (resetTimer >= resetDelay)
            // {
            //     Debug.Log("Resetting Ball");
            //     ResetBall();
            //     resetTimer = 0f;
            // }
            // Debug.Log("Reset Timer: " + resetTimer);
        }
    }
    public void ResetBall()
    {
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        transform.position = spawnPosition;
    }
}
