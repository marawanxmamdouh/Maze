using UnityEngine;

public class CameraMovement : MonoBehaviour
{
	public GameObject player;
	private Vector3 _offset = new (0, 6, -5);

	// Start is called before the first frame update
	void Start()
	{
	}

	// Update is called once per frame
	void LateUpdate()
	{
		transform.position = player.transform.position + _offset;
	}
}