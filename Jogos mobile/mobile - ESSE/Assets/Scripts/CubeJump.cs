using UnityEngine;

public class CubeJump : MonoBehaviour
{
    Rigidbody rb;
    public float jumpForce = 1.5f;
   bool canJump = true;

    void Start(){
        rb = GetComponent<Rigidbody>();
    }

    void Update(){
        if (Input.GetKeyDown(KeyCode.UpArrow) && canJump)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
          canJump = false;
        }
        
    }
    void OnCollisionEnter(Collision collision)
    {
        canJump = true;
        if (collision.gameObject.tag == "wall")
        {
            Debug.Log("colidiu");
        }
    }
}
