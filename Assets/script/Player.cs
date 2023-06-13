using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rigibody;
    public float speed = 5f;
    public float force = 400f;
    public float maxX;
    public float minX;
    // Start is called before the first frame update
    
    // Update is called once per frame
    public void FixedUpdate()
    {
        rigibody.AddForce(0, 0,force * Time.deltaTime);
    }

    public void Update()
    {
        Vector3 palyerpos = transform.position;
        palyerpos.x = Mathf.Clamp(palyerpos.x, minX, maxX);
        transform.position = palyerpos;

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            //   Debug.Log("left");
            transform.position = transform.position - new Vector3(speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
        }
    }
}
