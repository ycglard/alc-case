using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]private int speed;
    [SerializeField]private string type;
    [SerializeField]private GameObject startingPoint;
    private Player p;
    private Rigidbody rb;
    private Vector3 destPosition;
    void Start()
    {
        destPosition = transform.position;
        p = new Player(speed, type);
        rb = GetComponent<Rigidbody>();
        transform.position = startingPoint.transform.position;//set starting position of the user
        InitialRotations(0,90,180);
        
    }

    private void InitialRotations(float x,float y, float z)
    {
        transform.rotation = Quaternion.Euler(x,y,z);//set initial rotation
    }

    private void Move()
    {
        if(Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                destPosition = hit.point;
                RotatePlayer(transform.position,destPosition);
                transform.position += ((new Vector3(destPosition.x,transform.position.y,destPosition.z) - transform.position).normalized) * speed * Time.deltaTime;
                
            }
        }
    }

    public void RotatePlayer(Vector3 current,Vector3 target)
    {
        
        Quaternion targetRotation = Quaternion.LookRotation(target - current);
        transform.rotation = Quaternion.Slerp(transform.rotation,targetRotation,5*Time.deltaTime);
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    public void setModel()
    {
        
    }

    public Player P
    {
        get => p;
        
    }
    enum Type 
    {
        BANANA,
        OLIVE,
        CHEESE,
        HOTDOG
    }
}
