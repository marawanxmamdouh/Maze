using UnityEngine;
public class Button1 : MonoBehaviour
{
    public Transform btn;
    public Vector3 targetPosition;
    public float smoothFactor = 50f;
    public float rotationsPerMinute = 10f;
    
    public bool isUp = false;
    public Animator upAnimator;
    public Animator doorAnimator;
    
    void Start()
    {
        upAnimator = GetComponent<Animator>();
        doorAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isUp)
        {
            upAnimator.Play("upAnmi",-1, 1f);
            doorAnimator.Play("stage 2 door",-1, 1f);
        }
        transform.Rotate(0.0f, (float)(6.0*rotationsPerMinute*Time.deltaTime),0f);
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "player")
        {
            isUp = true;
            btn.transform.position = Vector3.Lerp(btn.transform.position, targetPosition, Time.deltaTime * smoothFactor);
            rotationsPerMinute = 0;
        }
    }
}
