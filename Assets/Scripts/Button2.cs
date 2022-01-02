using UnityEngine;

using UnityEngine;
public class Button2 : MonoBehaviour
{
    public Transform btn;
    public Vector3 targetPosition;
    public float smoothFactor = 50f;
    public float rotationsPerMinute = 10f;
    
    public Animator bridgeRightAnimator;
    public Animator bridgeLeftAnimator;
    
    public GameObject bridgeRight;
    public GameObject bridgeLeft;
    
    // Start is called once when the game start
    void Start()
    {
        bridgeRightAnimator = bridgeRight.GetComponent<Animator>();
        bridgeLeftAnimator = bridgeLeft.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Rotate Button2
        transform.Rotate(0.0f, (float)(6.0*rotationsPerMinute*Time.deltaTime),0f);
    }
    
    //Run when Player Collide with Button1
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "player" )
        {
            btn.transform.position = Vector3.Lerp(btn.transform.position, targetPosition, Time.deltaTime * smoothFactor);
            rotationsPerMinute = 0;
            bridgeRightAnimator.Play("BridgeRight");
            bridgeLeftAnimator.Play("BridgeLeft");
        }
    }
}
