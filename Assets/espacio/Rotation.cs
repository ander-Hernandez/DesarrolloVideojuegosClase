using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionTierra : MonoBehaviour
{
   
    private Vector3 rotacion;
    [SerializeField]
    private float rotationSpeedY;
    [SerializeField]
    private float rotationSpeedZ;
    // Start is called before the first frame update
    void Start()
    {
        
       
        rotacion = new Vector3(0, rotationSpeedY, rotationSpeedZ);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(rotacion);
    }
}
