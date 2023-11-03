using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Top") {
            Destroy(gameObject);
            Debug.Log(gameObject.tag + " Yok Edildi");
        }

        // Debug.Log(collision.gameObject.name + ", " + gameObject.name + "'e Çarptı");
    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("Trigger Gerçekleşti " + other.gameObject.name);
    }
}
