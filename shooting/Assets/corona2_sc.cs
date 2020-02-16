using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class corona2_sc : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        this.transform.position += new Vector3(-5, 0, 0) * Time.deltaTime;

        if (this.transform.position.x < -6)
            Destroy(this.gameObject);

    }
}
