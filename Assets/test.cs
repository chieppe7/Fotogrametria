using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

    Rigidbody rg;
    public Transform parent;
    public float torque;
    // Start is called before the first frame update
    void Start() {
        rg = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x,parent.eulerAngles.y,0);
        rg.AddTorque(this.transform.right * torque);
        //rg.AddForce(parent.forward*torque, ForceMode.Acceleration);
        //transform.Rotate(new Vector3(10,0,0),Space.Self);
        //transform.Rotate(new Vector3(0,parent.rotation.y,0),Space.World);
        
    }
}
