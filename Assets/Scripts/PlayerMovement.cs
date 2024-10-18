using UnityEditor.Experimental.GraphView;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{

    private float speed = 4f;
    private float jumpPower = 8f;

    public Sprite Ghost;

    SpriteRenderer sr;

    void Start()
        {
            sr = GetComponent<SpriteRenderer>();

        }

    // Update is called once per frame
    void Update()
    {

        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");

        //changes sprite and allows free movement when F is held
        if (Input.GetKey(KeyCode.F))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Ghost;
            GetComponent<Rigidbody2D>().gravityScale = 0;
            
            Vector3 inputVector = new Vector3(inputX, inputY, 0) * speed * Time.deltaTime;
            transform.position += inputVector;
        }
        //if Space is pressed, add jumpPower to movement
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 inputVector = new Vector3(inputX, jumpPower, 0) * speed * Time.deltaTime;
            transform.position += inputVector;
        }
        else
        {
            Vector3 inputVector = new Vector3(inputX, 0, 0) * speed * Time.deltaTime;
            transform.position += inputVector;
        }

        
        
        //THESE BOTH BREAK UNITY 

        //while (Input.GetKey(KeyCode.F))
        //{
        //    this.gameObject.GetComponent<SpriteRenderer>().sprite = Ghost;
        //    GetComponent<Rigidbody2D>().gravityScale = 0;
        //
        //    Vector3 inputVector = new Vector3(inputX, inputY, 0) * speed * Time.deltaTime;
        //    transform.position += inputVector;
        //}

        //while (this.gameObject.GetComponent<SpriteRenderer>().sprite = Ghost)
        //{
        //     Vector3 inputVector = new Vector3(inputX, inputY, 0) * speed * Time.deltaTime;
        //     transform.position += inputVector;
        //     GetComponent<Rigidbody2D>().gravityScale = 0;
        //}

    }
}
