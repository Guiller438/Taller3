using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Jugador : MonoBehaviour
{
    [SerializeField]
    private float velocidad = 0;


    public float rayDistance;
   
    private new Transform camera;

    

    // Start is called before the first frame update
    void Start()
    {
       camera = transform.Find("CameraPlayer");
    }

    // Update is called once per frame
    void Update()
    {

        Debug.DrawRay(camera.position, camera.forward, Color.red);

        RaycastHit hit;

        if(Physics.Raycast(camera.position,camera.forward, out hit, rayDistance) && Input.GetKey(KeyCode.C))
        {
            hit.collider.transform.GetComponent<Enemigo>().CambiarColor(Color.yellow);
        }


        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        }
    }
}
