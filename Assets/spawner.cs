using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    public Vector3 posicion;

    public GameObject bullet;
    public Vector3 position;
    public Vector3 aiming;
    public float coolDown ;
    [SerializeField]
    private float force = 1000;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) {
            this.transform.Rotate((new Vector3(0, 1, 0)) );
           
        
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate((new Vector3(0, -1, 0)));


        }

        if (coolDown > 0) {

            coolDown -= Time.deltaTime;
        }



        if (Input.GetKey(KeyCode.Space))
        {
          
            if (coolDown <= 0) {
                coolDown = 1;
                position = this.transform.position;
               GameObject newBullet = Instantiate(bullet);
                newBullet.transform.position = this.transform.position + this.transform.forward + (Vector3.up*0.7f) ;
                newBullet.GetComponent<Rigidbody>().AddForce(force * this.transform.forward);
                Debug.Log(Vector3.forward);
                


                
        }
        
        }

        
    }

        void FixedUpdate()
        {
            // Bit shift the index of the layer (8) to get a bit mask
            int layerMask = 1 << 8;

            // This would cast rays only against colliders in layer 8.
            // But instead we want to collide against everything except layer 8. The ~ operator does this, it inverts a bitmask.
            layerMask = ~layerMask;

            RaycastHit hit;
            // Does the ray intersect any objects excluding the player layer
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);

            hit.transform.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                Debug.Log("Did Hit "+ hit.transform.gameObject.name);
            }
            else
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.green);
                
            Debug.Log("Did not Hit");
            }
            



    }
    }







