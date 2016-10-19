using UnityEngine;
using System.Collections;

public class kee_main : MonoBehaviour {
    public Object prefab;
    public int count;
    public float radius;
    public Light my_light1;
    public Light my_light2;
    // Use this for initialization
    void Start () {
        for (int i = 0; i < count; ++i) {
            Vector2 c = Random.insideUnitCircle * radius;
            c.Normalize();
            c = c * Random.Range(radius * 0.9f, radius * 1.1f);
            Vector3 p = new Vector3(c.x, Random.Range(-50.0f, 50.0f), c.y);
            Instantiate(prefab, p, Quaternion.identity);
        }
    }
	
	// Update is called once per frame
	void Update () {
        float t = Time.realtimeSinceStartup;
        float r1 = Mathf.PerlinNoise(t, 0);
        float g1 = Mathf.PerlinNoise(t, 1);
        float b1 = Mathf.PerlinNoise(t, 2);
        my_light1.color = new Color(r1, g1, b1);
        float r2 = Mathf.PerlinNoise(0, t);
        float g2 = Mathf.PerlinNoise(1, t);
        float b2 = Mathf.PerlinNoise(2, t);
        my_light2.color = new Color(r2, g2, b2);
    }
}
