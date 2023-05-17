using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public Transform orientation;
    public Transform player;
    public Transform playerObj;
    public Rigidbody rb;
    public float rotationSpeed;

    CharacterController controller;



    [SerializeField]
     float playerSpeed = 6.0f;
    // Start is called before the first frame update
    void Start()
    {


    }
    private void Awake()
    {
        controller = gameObject.AddComponent<CharacterController>();
    }
    // Update is called once per frame
    void Update()
    {

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, 1, this.gameObject.transform.position.z);
    }

    private void FixedUpdate()
    {
    }
}
