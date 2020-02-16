using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class corona_sc : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        this.transform.position += new Vector3(0, -9, 0) * Time.deltaTime;

        if (this.transform.position.y < -5)
            Destroy(this.gameObject);

	}
}
