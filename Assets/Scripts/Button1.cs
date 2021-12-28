using UnityEngine;
public class Button1 : MonoBehaviour
{
    public Transform btn;
    public Vector3 targetPosition;
    public float smoothFactor = 50;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "player")
        {
            btn.transform.position = Vector3.Lerp(btn.transform.position, targetPosition, Time.deltaTime * smoothFactor);
        }
    }
}
