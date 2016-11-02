using UnityEngine;
using System.Collections;

public class navigation_01 : MonoBehaviour {

	public float posVel;
	public float rotVel;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		//Get Character Controller Component
		CharacterController controller = GetComponent<CharacterController>();
		//Get Navigation Input (could be keyboard or joystick)
		float de = Input.GetKey(KeyCode.E) ? 1 : 0;
		float dc = Input.GetKey(KeyCode.C) ? 1 : 0;
		float dx = Input.GetAxis ("Horizontal"); 
		float dy = Input.GetAxis ("Vertical"); 

		//rotate about y axis
		transform.Rotate (0, dx * rotVel, 0);
		transform.Rotate (-(de-dc) * (float)0.5 * rotVel, 0, 0);

		Vector3 forward = transform.TransformDirection (Vector3.forward);

		controller.SimpleMove (forward * dy * posVel);

		//		Debug.Log (value);
	}
}
