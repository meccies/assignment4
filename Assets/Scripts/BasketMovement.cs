using UnityEngine;

public class BasketMovement : MonoBehaviour
{
    public Vector3 basketPosition;
    public float basketRange = 2f;
    public Vector3 basketEndPosition;
    //public Vector3 basketEndPosition;
    public float basketSpeed = 5f;
    //public bool goingUp = true;
    //private Rigidbody rb;

    void Start()
    {
        basketPosition = transform.position;
        basketEndPosition = new Vector3(basketPosition.x, basketPosition.y + basketRange, basketPosition.z);
        Debug.Log("Basket Position: " + basketPosition);
        Debug.Log("Basket End Position: " + basketEndPosition);
        //rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time * basketSpeed, basketRange) + basketPosition.x, basketPosition.y, basketPosition.z);
    }

    // void FixedUpdate()
    // {
        
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
