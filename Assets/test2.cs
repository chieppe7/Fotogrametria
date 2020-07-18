using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test2 : MonoBehaviour {
    public Transform child;
    public float turn;
    // Start is called before the first frame update
    void Start() {
        //child=transform.GetChild(0);
    }

    // Update is called once per frame
    void Update() {
        this.transform.position = child.position;
        this.transform.Rotate(new Vector3(0,1,0)*turn,Space.World);
    }
}
