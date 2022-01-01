using UnityEngine;
public class Button1 : MonoBehaviour
{
    public Transform btn;
    public Vector3 targetPosition;
    public float smoothFactor = 50f;
    public float rotationsPerMinute = 10f;
    
    public Animator upAnimator;
    public Animator doorAnimator;
    
    public GameObject up;
    public GameObject door;
    
    // Start is called once when the game start
    void Start()
    {
        upAnimator = up.GetComponent<Animator>();
        doorAnimator = door.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Rotate Button1 
        transform.Rotate(0.0f, (float)(6.0*rotationsPerMinute*Time.deltaTime),0f);
    }
    
    //Run when Player Collide with Button1
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "player" && PlayerController.score == 35)
        {
            btn.transform.position = Vector3.Lerp(btn.transform.position, targetPosition, Time.deltaTime * smoothFactor);
            rotationsPerMinute = 0;
            upAnimator.Play("upAnmi");
            doorAnimator.Play("stage 2 door");
        }
    }
}
