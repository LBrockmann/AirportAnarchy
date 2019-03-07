using System.Collections;
using System.Collections.Generic;
using System.Net;
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

       //public float jumpCap;

       //public float rayDist = 0.2f; // the ray length is not being set to this; it is stuck at -1
       //Vector3 baseJump;

       private bool jumpAllowed;
       private float jumpTimer;
       public float jumpTimeCap;

       //public bool jump = true;
       // velocity of conroller multiplied by this number
   
       void Start()
       {
           Cursor.lockState = CursorLockMode.Locked;
           Cursor.visible = false;
           //rayDist = 0.2f;
           jumpAllowed = true;
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

           /*Ray jumpRay = new Ray(transform.position + new Vector3(0,-1.01f,0), new Vector3(0, -rayDist, 0));
               
           Debug.DrawRay(jumpRay.origin, jumpRay.direction, Color.red, rayDist);
           

           RaycastHit hit;
           
           if (Physics.Raycast(jumpRay, out hit, rayDist)) // still hitting nothing likx
           {
               if (!hit.collider.gameObject.tag.Equals("Player"))
               {
                   jump = true;
                   baseJump = transform.position;
                   
                   Debug.Log("This is base jump "+baseJump);
//                   Debug.Log(jumpRay.origin + " " + jumpRay.direction);
                //   Debug.Log("Ray Hit " + hit.transform.name);
               }
           }
            
           
           if (Input.GetKey(KeyCode.Space))
           {
               float relativeHeight = baseJump.y + jumpCap;
               if (transform.position.y < relativeHeight && jump)            // player is within correct height
               {
              //     print(relativeHeight);
                   thisRigidBody.AddForce(Vector3.up*jumpForce, ForceMode.Impulse);    // so the player jumps
                   Debug.Log(jump);

               }
               else if(transform.position.y >= relativeHeight)  // player is too high
               {
                  jump = false;
                   Debug.Log("false");                        // so the player falls
               }
           }*/

           if (Input.GetKey(KeyCode.Space) && jumpAllowed)
           {
               thisRigidBody.AddForce(Vector3.up*jumpForce, ForceMode.Impulse);
               jumpTimer = jumpTimer + Time.deltaTime;
    
           }
           
           if (jumpTimer >= jumpTimeCap)
           {
               jumpTimer = 0f;
               jumpAllowed = false;
           }

           
            
           Physics.gravity = new Vector3(0, -9.81f, 0);


       }
       
       void OnCollisionEnter(Collision other)
       {
           jumpAllowed = true;
       }
   
       void FixedUpdate()
       {
           thisRigidBody.velocity = inputVelocity * velocityModifier + (Physics.gravity * .69f);
       }
   }