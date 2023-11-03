using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopHareket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
    }

    // Update is called once per frame
    void Update(){
    	float x = Input.GetAxis("Horizontal") * Time.deltaTime * 7f;
    	float z = Input.GetAxis("Vertical") * Time.deltaTime * 7f;
    	
    	GetComponent<Rigidbody>().AddForce(7f*Input.GetAxis("Horizontal"), 0f, 7f*Input.GetAxis("Vertical"));
    	transform.Rotate(0, x, 0);
    	transform.Translate(x, 0, z);
    	
    	if(Input.GetKeyDown(KeyCode.Space)){
    		GetComponent<Rigidbody>().AddForce(new Vector3(0f, 360f, 0f));
    	}
    	
    }
}
