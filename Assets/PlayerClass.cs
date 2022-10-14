using UnityEngine;
[RequireComponent(typeof(Rigidbody))]

public class PlayerClass : MonoBehaviour
{
    public float speed=7f;
    public Camera mainCam;
    private Rigidbody rb;
    private float sense = 80f;
    private float x_rotation = 0;
    private float y_rotation = 0;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        makePlayerRotate();
    }

    void FixedUpdate()
    {
        makePlayerWalk();
    }

    private void makePlayerWalk()
    {
        float x_movement = Input.GetAxis("Horizontal");
        float y_movement = Input.GetAxis("Vertical");

        Vector3 movement = x_movement * mainCam.transform.right + y_movement * mainCam.transform.forward;
        rb.velocity = movement * speed;
        rb.AddForce(rb.velocity, ForceMode.Force);
    }

    private void makePlayerRotate()
    {
        x_rotation += Input.GetAxis("MouseX") * sense * Time.deltaTime;
        y_rotation += Input.GetAxis("MouseY") * sense * Time.deltaTime;

        y_rotation = Mathf.Clamp(y_rotation, -90,90);
        mainCam.transform.rotation = Quaternion.Euler(-y_rotation, x_rotation, 0.0f);
        transform.rotation = Quaternion.Euler(0.0f, x_rotation, 0.0f);
    }


}
