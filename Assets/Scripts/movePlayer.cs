using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    Rigidbody rb;
    public float thrustSpeed;
    public float rotationThrust;
    // Start is called before the first frame update
    void Start()
    {      
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }
    void ProcessInput()
    {
        if(Input.GetKey(KeyCode.Space)){
            rb.AddRelativeForce(new Vector3(0,1,0)*thrustSpeed*Time.deltaTime);
        }
        float rot = Input.GetAxis("Horizontal");
        if(rot != 0){
            rb.freezeRotation = true;
            transform.Rotate(Vector3.forward*-rot*rotationThrust*Time.deltaTime);
        rb.freezeRotation = false;

        }

    }
}
