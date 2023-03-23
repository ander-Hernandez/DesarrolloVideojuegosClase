using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrip : MonoBehaviour
{
    public bool jumpable = true;

    [SerializeField]
    public int jumpForce = 200;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumpable ) {
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);
            jumpable = false;
        }if (true) {
            jumpable = true;        }


       
    }

    private void FixedUpdate()
    {
        
    }
}
