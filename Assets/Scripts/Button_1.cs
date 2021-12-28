using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_1 : MonoBehaviour
{
    public Transform btn;
    public float moveSpeed = 10f;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "player")
        {
            btn.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }
    }
}
