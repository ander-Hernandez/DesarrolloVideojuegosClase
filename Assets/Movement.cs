using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 sY = new Vector3(0, 0.1f, 0);
    public float translation;
    public GameObject[] vagones;
    public int drops = 2;
    // Start is called before the first frame update
    void Start()
    {
        translation = Time.deltaTime * 10;
        sY = new Vector3(0, translation, 0);


    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(" Rot x: " + this.transform.localRotation.x + " - Rot y:" + this.transform.localRotation.y + " - Rot z:" + this.transform.localRotation.z);

        Debug.Log(" Scl x: " + this.transform.localScale.x + " - Scl y:" + this.transform.localScale.y + " - Scl z:" + this.transform.localScale.z);


        CheckMovementTranslate();
        //soltarVagon();
        //Animacion();
        //CheckSize();
        if (this.transform.position.y <= -20) {
            this.transform.position = new Vector3(0, 0, 0);
            
        }
    }

    private void soltarVagon()
    {
        Debug.Log(drops);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Transform vagon = transform.Find("vagon" + drops);
            if (vagon != null)
            {
                vagon.parent = null;
            }
            Debug.Log(drops);
            drops--;


        }

    }

    private void Animacion()
    {


        translation = Time.deltaTime * 10;
        this.transform.localScale += sY;
        if (this.transform.localScale.y >= 15)
        {
            sY = new Vector3(0, -translation, 0);
        }
        else if (this.transform.localScale.y <= 0)
        {
            sY = new Vector3(0, translation, 0);
        }
    }

    private void CheckSize()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {

            this.transform.localScale = Time.deltaTime * Vector3.forward;

        }
        if (Input.GetKeyDown(KeyCode.L))
        {

            this.transform.position += Time.deltaTime * Vector3.back;

        }
        if (Input.GetKeyDown(KeyCode.D))
        {

            this.transform.position += Time.deltaTime * Vector3.right;

        }
        if (Input.GetKeyDown(KeyCode.A))
        {

            this.transform.position += Time.deltaTime * Vector3.left;

        }
        if (Input.GetKeyDown(KeyCode.W))
        {

            this.transform.position += Time.deltaTime * Vector3.up;

        }
        if (Input.GetKeyDown(KeyCode.S))
        {

            this.transform.position += Time.deltaTime * Vector3.down;

        }
    }

    private void CheckMovement()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            this.transform.position += Time.deltaTime * Vector3.forward * 10;

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {

            this.transform.position += Time.deltaTime * Vector3.back * 10;

        }
        if (Input.GetKeyDown(KeyCode.D))
        {

            this.transform.position += Time.deltaTime * Vector3.right * 10;

        }
        if (Input.GetKeyDown(KeyCode.A))
        {

            this.transform.position += Time.deltaTime * Vector3.left * 10;

        }
        if (Input.GetKeyDown(KeyCode.W))
        {

            this.transform.position += Time.deltaTime * Vector3.up * 10;

        }
        if (Input.GetKeyDown(KeyCode.S))
        {

            this.transform.position += Time.deltaTime * Vector3.down * 10;

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

            this.transform.position += Time.deltaTime * Vector3.up * 10;

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            this.transform.position += Time.deltaTime * Vector3.down * 10;

        }
    }
    private void CheckMovementTranslate()
    {
        if (Input.GetKey(KeyCode.W))
        {

            this.transform.Translate(Time.deltaTime * Vector3.forward * 10);

        }
        if (Input.GetKey(KeyCode.S))
        {

            this.transform.Translate(Time.deltaTime * Vector3.back * 10);

        }
        if (Input.GetKey(KeyCode.D))
        {

            this.transform.Translate(Time.deltaTime * Vector3.right * 10);

        }
        if (Input.GetKey(KeyCode.A))
        {

            this.transform.Translate(Time.deltaTime * Vector3.left * 10);

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {

            this.transform.Translate(Time.deltaTime * Vector3.up * 10);

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {

            this.transform.Translate(Time.deltaTime * Vector3.down * 10);

        }


        if (Input.GetKey(KeyCode.RightArrow))
        {

            this.transform.Rotate(Time.deltaTime * Vector3.up * 10);

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            this.transform.Rotate(Time.deltaTime * Vector3.down * 10);

        }
    }
}
