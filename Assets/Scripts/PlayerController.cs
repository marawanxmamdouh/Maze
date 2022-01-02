using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static int lives = 3;
    public static int score;

    public float speed = 10;
    private Rigidbody _rb;
    private Vector3 _move;
    private float _horizontal;
    private float _vertical;

    // Start is called before the first frame update
    void Start()
    {
        // Make Reference From Rigidbody
        _rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Store Input From User 
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");

        // store Inputs in Vector3
        _move.x = _horizontal;
        _move.z = _vertical;

        //Move Player by Add Force
        _rb.AddForce(_move * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("gem"))
        {
            other.gameObject.SetActive(false);
            score++;
            Debug.Log("Score: " + score);
        }
    }
}