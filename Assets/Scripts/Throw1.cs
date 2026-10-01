using UnityEngine;

public class Throw1 : MonoBehaviour
{
    private Rigidbody rb;
    public float throwForce = 10f;
    public float throwUpwardForce = 10f;
    public Vector3 spawnPosition;
    public float resetDelay = .5f;
    public float resetTimer = 0f;
    public bool haswon = false;
    public bool instantHaswon = false;
    public float colisionCount = 0f;
    private bool thrown = false;
    private float throwCount = 0f;

    // public float score = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        colisionCount = 0f; // Initialize the collision count
        rb = GetComponent<Rigidbody>();
        spawnPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !thrown && throwCount == 0f)
        {
            // ThrowBall();
            thrown = true;
            throwCount++;

        }
        // instantHaswon = false; // Reset the instantHaswon flag at the start of each frame
        // if (haswon)
        //     {
        //        // Debug.Log("Reset Timer: " + resetTimer);
        //         resetTimer -= Time.deltaTime;
        //         if (resetTimer <= 0f)
        //         {
        //             //Debug.Log("Resetting Ball");
        //             ResetBall();
        //             resetTimer = 0f; // Reset the timer after resetting the ball
        //             haswon = false; // Reset the win condition
        //         }
        //     }
    }

    void FixedUpdate()
    {
        if (thrown && throwCount == 1){
        ThrowBall();
        throwCount = 2f;
        }
    }

    public void ThrowBall()
    {
        rb.AddForce((Vector3.forward * throwForce) + (Vector3.up * throwUpwardForce), ForceMode.Impulse);
        thrown = false;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Boundary"))
        {
            ResetBall();
            throwCount = 0f; // Reset the throw count
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("WinColider"))
        {

            //Debug.Log("Win!");
            ResetBall();
            haswon = true;
            instantHaswon = true;
            throwCount = 0f; // Reset the throw count
            // score ++;
            resetTimer = resetDelay; // Set the reset timer to the delay value to trigger immediate reset
            colisionCount++;
            Debug.Log("Collision Count: " + colisionCount);
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
        throwCount = 0f; // Reset the throw count
    }
}
