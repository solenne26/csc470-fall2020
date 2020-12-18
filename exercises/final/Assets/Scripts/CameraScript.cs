using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float RotationSpeed = 50f;
    public float LeftLimit = -.39f;
    public float RightLimit = .39f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {

            if (this.transform.localRotation.y >= LeftLimit)
            {
                this.transform.Rotate(Vector3.down * RotationSpeed * Time.deltaTime);
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (this.transform.localRotation.y <= RightLimit)
            {
                this.transform.Rotate(Vector3.up * RotationSpeed * Time.deltaTime);
            }
        }

        if (Input.GetKey(KeyCode.W))
        {

            if (this.transform.localRotation.y >= LeftLimit)
            {
                this.transform.Rotate(Vector3.left * RotationSpeed * Time.deltaTime);
            }
        }
        if (Input.GetKey(KeyCode.S))
        {

            if (this.transform.localRotation.y >= LeftLimit)
            {
                this.transform.Rotate(Vector3.right * RotationSpeed * Time.deltaTime);
            }
        }
        //Debug.Log(this.transform.localRotation.y);

    }
}
