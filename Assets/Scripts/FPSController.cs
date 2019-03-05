using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour
{
   public Rigidbody thisRigidBody; // the rigidbody we'll be moving
       public Camera thisCamera;   // the camera
   
       public float pitch; // the mouse movement up/down
       public float yaw;   // the mouse movement left/right
   
       public float fpForwardBackward; // input float from  W and S keys
       public float fpStrafe;  // input float from A D keys
       
       public Vector3 inputVelocity;  // cumulative velocity to move character
   
       public float velocityModifier;

       public float sensitivityX;

       public float sensitivityY;

       public float jumpForce;
       // velocity of conroller multiplied by this number
   
       void Start()
       {
           Cursor.lockState = CursorLockMode.Locked;
           Cursor.visible = false;
           // thisRigidBody = GetComponent<Rigidbody>();
       }
   
       void Update()
       {
           yaw = Input.GetAxis("Mouse X") * sensitivityX;
           transform.Rotate(0, yaw, 0);
   
           pitch = Input.GetAxis("Mouse Y") * sensitivityY;
           thisCamera.transform.Rotate(-pitch, 0, 0);
   
           fpForwardBackward = Input.GetAxis("Vertical");
           fpStrafe = Input.GetAxis("Horizontal");
   
           inputVelocity = transform.forward * fpForwardBackward;
           inputVelocity += transform.right * fpStrafe;

           if (Input.GetKeyDown(KeyCode.Space))
           {
               thisRigidBody.AddForce(0f,jumpForce,0f,ForceMode.Impulse);
               Debug.Log("Jump");
           }

           Physics.gravity = new Vector3(0, -9.81f, 0);


       }
   
       void FixedUpdate()
       {
           thisRigidBody.velocity = inputVelocity * velocityModifier + (Physics.gravity * .69f);
       }
   }