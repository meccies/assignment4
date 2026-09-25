using UnityEngine;

public class BasketMovement : MonoBehaviour
{
    public Vector3 basketPosition;
    public Vector3 basketEndPosition;
    public float basketSpeed = 5f;
    public bool goingUp = true;
    private Rigidbody rb;

    void Start()
    {
        basketPosition = transform.position;
        rb = GetComponent<Rigidbody>();
    }



    void FixedUpdate()
    {
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

    }
}
