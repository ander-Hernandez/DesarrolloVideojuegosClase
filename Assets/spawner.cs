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
        aiming = new Vector3(0, 0, 1);
        Debug.LogWarning(aiming);
    }

    // Update is called once per frame
    void Update()
    {
       
        if (coolDown > 0) {

            coolDown -= Time.deltaTime;
        }



        if (Input.GetKey(KeyCode.Space))
        {
           
            if (coolDown <= 0) {
                coolDown = 1;
                position = this.transform.position;
               GameObject newBullet = Instantiate(bullet);
                newBullet.transform.position = this.transform.position + aiming + (Vector3.up*0.7f) ;
                newBullet.GetComponent<Rigidbody>().AddForce(force * aiming);
                Debug.Log(aiming);
                


                
        }
        
        }

        
    }
}
