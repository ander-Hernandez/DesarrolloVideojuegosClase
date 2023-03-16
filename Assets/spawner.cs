using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
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
            this.transform.Rotate((new Vector3(0, 1, 0)* 3) );
           
        
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
                newBullet.transform.position = this.transform.position + Vector3.forward + (Vector3.up*0.7f) ;
                newBullet.GetComponent<Rigidbody>().AddForce(force * Vector3.forward);
                Debug.Log(Vector3.forward);
                


                
        }
        
        }

        
    }
}
