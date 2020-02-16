using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class corona_ins : MonoBehaviour {

    float span = 0.3f;
    public GameObject corona1_obj;
    public GameObject corona2_obj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (span >= 0.3f)
        {

            Instantiate(corona1_obj, new Vector3(Random.Range(-6, 7), 5, 0), Quaternion.identity);
            Instantiate(corona1_obj, new Vector3(Random.Range(-6, 7), 5, 0), Quaternion.identity);
            Instantiate(corona1_obj, new Vector3(Random.Range(-6, 7), 5, 0), Quaternion.identity);
            Instantiate(corona2_obj, new Vector3(6, Random.Range(-5, 6), 0), Quaternion.identity);
            Instantiate(corona2_obj, new Vector3(6, Random.Range(-5, 6), 0), Quaternion.identity);
            span = 0;

        }

        span += Time.deltaTime;
		
	}
}
