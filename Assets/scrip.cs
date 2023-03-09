using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrip : MonoBehaviour
{
    public bool jumpable = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumpable ) {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0, 200, 0));
            jumpable = false;
        }if (this.transform.position.y == 0) {
            jumpable = true;        }
    }
}
