using UnityEngine;


public class PlayerMovement : MonoBehaviour
{

    public float speed = 4f;
    public float jumpPower = 8f;

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");

        Vector3 inputVector = new Vector3(inputX, 0, 0) * speed * Time.deltaTime;
        transform.position += inputVector;
    }
}
