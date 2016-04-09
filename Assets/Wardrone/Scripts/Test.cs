using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

    public Transform target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //Vector3 relativePos = (target.position + new Vector3(0, 1.5f, 0)) - transform.position;
        Vector3 relativePos = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos);

        Quaternion current = transform.localRotation;

        transform.localRotation = Quaternion.Slerp(current, rotation, Time.deltaTime);
        //transform.localRotation = rotation;
        transform.Translate(3 * Time.deltaTime, 0, 0);
    }
}
