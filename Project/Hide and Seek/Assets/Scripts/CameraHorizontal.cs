using UnityEngine;
using System.Collections;

public class CameraHorizontal : MonoBehaviour {

	float speed = 180.0f;

	// Update is called once per frame
	void Update () {
		if (Input.GetAxis ("Mouse X") > 0 || Input.GetAxis ("Mouse X") < 0) {
			transform.Rotate (new Vector3 (0, Input.GetAxis("Mouse X") , 0) * Time.deltaTime * speed);
		}
	}
}
