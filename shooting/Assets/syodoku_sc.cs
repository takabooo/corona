using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class syodoku_sc : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        this.transform.position += new Vector3(0, 20, 0) * Time.deltaTime;

        if (this.transform.position.y > 5)
            Destroy(this.gameObject);

	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
         //Debug.Log("a");
        if (collision.gameObject.tag == "corona")
        {

            Destroy(collision.gameObject);
            Destroy(this.gameObject);

        }       
    }

}
