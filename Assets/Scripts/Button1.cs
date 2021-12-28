using UnityEngine;
public class Button1 : MonoBehaviour
{
    public Transform btn;
    public Vector3 targetPosition;
    public float smoothFactor = 50f;
    public float rotationsPerMinute = 10f;
    void Update()
    {
        transform.Rotate(0.0f, (float)(6.0*rotationsPerMinute*Time.deltaTime),0f);
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "player")
        {
            btn.transform.position = Vector3.Lerp(btn.transform.position, targetPosition, Time.deltaTime * smoothFactor);
            rotationsPerMinute = 0;
        }
    }
}
