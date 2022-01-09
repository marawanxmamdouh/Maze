using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static int lives = 3;
    public static int score = 49;
    public static bool canMove = true;

    public float speed = 10;
    private Rigidbody _rb;
    private Vector3 _move;
    private float _horizontal;
    private float _vertical;
    
    public AudioSource audioSource;

    // Start is called before the first frame update
    private void Start()
    {
        // Make Reference From Rigidbody
        _rb = GetComponent<Rigidbody>();
        
        audioSource = GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        if (!canMove)
        {
            transform.position = Vector3.Lerp(transform.position,new Vector3 (0.25f, 0.5f, 13f),1);
            _rb.velocity = Vector3.zero;
            return;
        }

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
            audioSource.Play();
            Debug.Log("Score: " + score);
        }
    }
}