using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    int speed = 5;
    float span = 0.08f;
    bool masuku = false;

    public GameObject syodoku_obj;
    public GameObject gameover_txt;
    public GameObject masuku_obj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKey(KeyCode.UpArrow))
        {

            this.transform.position += new Vector3(0, speed, 0) * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.DownArrow))
        {

            this.transform.position += new Vector3(0, -speed, 0) * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {

            this.transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {

            this.transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.Space) && span >= 0.08f)
        {

            span = 0;
            Instantiate(syodoku_obj, this.transform.position, Quaternion.identity);

        }

        if (Input.GetKeyDown(KeyCode.Z))
        {

            masuku = !masuku;
            masuku_obj.gameObject.SetActive(!masuku_obj.gameObject.activeSelf);

        }

        if (span < 0.08f)
            span += Time.deltaTime;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "corona" && !masuku)
        {

            Debug.Log("GameOver");
            gameover_txt.gameObject.SetActive(true);

        }

    }
}
