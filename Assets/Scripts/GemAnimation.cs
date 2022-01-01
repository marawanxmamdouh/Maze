using UnityEngine;

public class GemAnimation : MonoBehaviour
{
    // Before rendering each frame..
    void Update () 
    {
        // Rotate the gem
        transform.Rotate (new Vector3 (0, 0, 360) * Time.deltaTime/4);
    }
}