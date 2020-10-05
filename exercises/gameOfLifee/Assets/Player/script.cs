using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class script : MonoBehaviour
{
	GameObject player;
    float movementSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
    	Rigidbody rb = GetComponent<Rigidbody>();

     	if (Input.GetKey(KeyCode.W)) {
     		transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
     	}   

     	if (Input.GetKey(KeyCode.S)) {
     		transform.Translate(Vector3.back * Time.deltaTime * movementSpeed);
     	}

     	if (Input.GetKey(KeyCode.A)) {
     		transform.Translate(Vector3.left * Time.deltaTime * movementSpeed);
     	}

     	if (Input.GetKey(KeyCode.D)) {
     		transform.Translate(Vector3.right * Time.deltaTime * movementSpeed);
     	}
    }
}
