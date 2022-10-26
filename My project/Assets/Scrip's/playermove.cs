using UnityEngine;

public class playermove : MonoBehaviour
{

    private Animator animacion;    
    [SerializeField] CharacterController controller;

    [SerializeField] float gravity=-9.8f, jumpHeight=3, groundDistance= 0.3f, speed=10f;
    private float x, z;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask groundMask;
    [SerializeField] Vector3 velocity;
    [SerializeField] bool isGrounded;

    private void Start() {
      animacion = GetComponent<Animator>();
    }
    private void FixedUpdate() {

        animacion.SetFloat("SpeedY", x);

        animacion.SetFloat("SpeedX", z);
    }

    void Update()
    {
      isGrounded=Physics.CheckSphere(groundCheck.position,groundDistance,groundMask);

      if( isGrounded && velocity.y < 0 )
      {
        velocity.y= -2f;
      }


      x= Input.GetAxis("Horizontal");
      z= Input.GetAxis("Vertical");
      
      Vector3 move = transform.right * x + transform.forward * z;
      controller.Move(move*speed*Time.deltaTime);

      if( Input.GetButtonDown("Jump") && isGrounded   )
      {
        velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity );
      }
        velocity.y += gravity * Time.deltaTime;
        controller.Move( velocity*Time.deltaTime);     
    }
}
