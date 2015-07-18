using UnityEngine;
using System.Collections;

public class CameraVert : MonoBehaviour {

	float speed = 180.0f; //Rotation Speed

	// Update is called once per frame
	void Update () {
		if (Input.GetAxis ("Mouse Y") > 0 || Input.GetAxis ("Mouse Y") < 0) {
			transform.Rotate (new Vector3 (Input.GetAxis ("Mouse Y"),0, 0) * Time.deltaTime * speed);
		}
	}
}
