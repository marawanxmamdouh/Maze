using UnityEngine;

public class test : MonoBehaviour
{
    private Vector3 _startPosition;
    private float frequency = 5f;
    private float magnitude = 5f;

    // Start is called before the first frame update
    void Start()
    {
        _startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = _startPosition + transform.up * Mathf.Sin(Time.time * frequency) * magnitude;
    }
}