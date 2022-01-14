using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class SnakeManager : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rig;
    
    
    private GameObject _obj;
    private Vector3 _originalPosition;


    // Start is called before the first frame update
    void Start()
    {
        _obj = gameObject;
        rig = GetComponent<Rigidbody2D>();
        //Set the speed of the GameObject
        moveSpeed = 10;
        _originalPosition = _obj.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Move the Rigidbody to the right constantly at speed you define (the red arrow axis in Scene view)
            rig.velocity = transform.right * moveSpeed;
        }   

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Move the Rigidbody to the left constantly at the speed you define (the red arrow axis in Scene view)
            rig.velocity = -transform.right * moveSpeed;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Move the Rigidbody to the left constantly at the speed you define (the red arrow axis in Scene view)
            rig.velocity = transform.up * moveSpeed;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            //Move the Rigidbody to the left constantly at the speed you define (the red arrow axis in Scene view)
            rig.velocity = -transform.up * moveSpeed;
        }
        
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("ResetWallRight"))
        {
            _obj.transform.position = new Vector3(-8.54f, transform.position.y, 0);
        }
        if (other.tag.Equals("ResetWallLeft"))
        {
            _obj.transform.position = new Vector3(8.54f, transform.position.y, 0);
        }
        if (other.tag.Equals("ResetWallDown"))
        {
            _obj.transform.position = new Vector3(transform.position.x, 4.79f, 0);
        } 
        if (other.tag.Equals("ResetWallUp"))
        {
            _obj.transform.position = new Vector3(transform.position.x, -4.79f, 0);
        } 
    }
}
