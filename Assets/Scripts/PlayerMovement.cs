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

        //changes sprite when F is pressed
        if (Input.GetKeyDown(KeyCode.F))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Ghost;

            while (this.gameObject.GetComponent<SpriteRenderer>().sprite = Ghost)
            {
                Physics2D.gravity = new Vector3(10f, 0f, 0f);
                Vector2 direction = Vector2.zero;
                if (Input.GetKeyDown(KeyCode.W))
                {
                    direction = Vector2.up;
                }

                if (Input.GetKeyDown(KeyCode.S))
                {
                    direction = Vector2.down;
                }
            }
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

        //while (this.gameObject.GetComponent<SpriteRenderer>().sprite = Ghost)
        //{
        //     Vector3 inputVector = new Vector3(inputX, inputY, 0) * speed * Time.deltaTime;
        //     transform.position += inputVector;
        //     GetComponent<Rigidbody2D>().gravityScale = 0;
        //}

    }
}
