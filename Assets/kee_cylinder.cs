using UnityEngine;
using System.Collections;

public class kee_cylinder : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y < -50.0f) {
            Vector3 temp = transform.position;
            temp.y = 50.0f;
            transform.position = temp;
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity = new Vector3(0, 0, 0);
        }
    }
}
