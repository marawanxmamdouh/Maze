using UnityEngine;
using System.Collections;
public class CameraScript : MonoBehaviour
{
    public GameObject Player;
    private Vector3 cameraPosition;
    void Start()
    {
        cameraPosition = this.transform.position;
    }
    // Execute After Movement's Palyer For Optimization
    void LateUpdate()
    {
        this.transform.position = Player.transform.position + cameraPosition;
    }
}