using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //GetComponent<Renderer>().material.SetTexture("Texture", Resources.Load("kitty") as Texture);
        GetComponent<Renderer>().material.mainTexture = Resources.Load("kitty") as Texture;
    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
