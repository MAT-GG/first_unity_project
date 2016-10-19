using UnityEngine;
using System.Collections;

public class ballBehavior : MonoBehaviour {

    public int count;

	// Use this for initialization
	void Start () {
        Debug.Log("start");
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnCollisionEnter(Collision col){
        if (col.gameObject.name == "Cube")
        {
            Debug.Log("hit floor");
            Vector3 temp = transform.position;
            temp.y = 10.0f;
           // transform.position = temp;
            count++;
        }
    }
}
