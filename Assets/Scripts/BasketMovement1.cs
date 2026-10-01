using UnityEngine;

public class BasketMovement1 : MonoBehaviour
{
    public Vector3 basketPosition;
    public float basketRange = 2f;
    public Vector3 basketEndPosition;
    public float basketSpeed = 5f;
    //public Vector3 basketEndPosition;
    //public bool goingUp = true;
    //private Rigidbody rb;
    public Throw throwscript;
     public float resetTimer = 0f;
     // private Rigidbody rb;
    private Vector3 movementForce;
    
    
    void Awake()
    {
         basketPosition = transform.position;
        basketEndPosition = new Vector3(basketPosition.x, basketPosition.y + basketRange, basketPosition.z);
    }
    //  void Start()
    // {
       
    // //     Debug.Log("Basket Position: " + basketPosition);
    // //     Debug.Log("Basket End Position: " + basketEndPosition);
    // //     Debug.Log("Basket Speed: " + basketSpeed);
    // //     //basketSpeed = throwscript.colisionCount + 1f * 5f;
    //   //   rb = GetComponent<Rigidbody>();
    //  }

    void Update()
    {
        basketSpeed = throwscript.colisionCount + 3f;
        //increase basket speed when the player scores a point
        // if(throwscript.instantHaswon)
        // {
        //    resetTimer -= Time.deltaTime;
        //         if (resetTimer <= 0f)
        //         {
        //             //Debug.Log("Resetting Ball");
        //             basketSpeed ++;
        //             Debug.Log("Basket Speed Increased to: " + basketSpeed);
        //             resetTimer = 0f; // Reset the timer after resetting the ball
        //         }
           


        // }
        transform.position = new Vector3(Mathf.PingPong(Time.time * basketSpeed, basketRange) + basketPosition.x, basketPosition.y, basketPosition.z);
        //movementForce = new Vector3(Mathf.PingPong(Time.time * basketSpeed, basketRange) + basketPosition.x, basketPosition.y, basketPosition.z);
    }

    // void FixedUpdate()
    // {
    //     rb.AddForce(movementForce);
    // }

    //void FixedUpdate()
    //{
        // if (basketPosition != basketEndPosition && goingUp)
        // {
        //     transform.Translate(Vector3.Lerp(basketPosition, basketEndPosition, Time.deltaTime * basketSpeed));
        // }
        // if (basketPosition == basketEndPosition)
        // {
        //     goingUp = false;
        // }
        // if (basketPosition != basketEndPosition && !goingUp)
        // {
        //     transform.Translate(Vector3.Lerp(basketEndPosition, basketPosition, Time.deltaTime * basketSpeed));
        // }
        // if (basketPosition == -basketEndPosition)
        // {
        //     goingUp = true;
        // }

   // }
}
