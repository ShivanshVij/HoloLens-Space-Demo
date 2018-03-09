using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotate : MonoBehaviour {
    public int speedx = 50;
    public int speedy = 50;
    public int speedz = 50;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(Time.deltaTime * speedx, Time.deltaTime * speedy, Time.deltaTime * speedz));	
	}
}
