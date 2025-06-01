using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody rb;
   public float jumpForce = 1.0f;
        void Start(){
        rb = GetComponent<Rigidbody>();
    }
    void Update(){
         if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            print("Pulou?");
        }
    }
}
