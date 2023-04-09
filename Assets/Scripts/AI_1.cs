using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_1 : MonoBehaviour
{
    public static AI_1 aii;
    // Start is called before the first frame update
    [SerializeField] Transform target;
    [SerializeField] float moveawaystop;
    [SerializeField] float retreatdistance;
    [SerializeField] float speed;
    [SerializeField] float nearmeter;
    [SerializeField] GameObject kill;
    [SerializeField] float raycastdistance;
    [SerializeField] float movespeed;
    
    [SerializeField] Transform grounddetection;
    bool turningright = true;

    private void Awake()
    {
        aii = this;
        
    }
    void Start()
    {
      

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * movespeed * Time.deltaTime);
        RaycastHit2D groundinfo = Physics2D.Raycast(grounddetection.position, Vector2.down, raycastdistance);
        

            if (groundinfo.collider == false)
            {
                if (turningright == true)
                {
                    transform.eulerAngles = new Vector3(0, -180, 0);
                    turningright = false;
                }
                else
                {
                    transform.eulerAngles = new Vector3(0, 0, 0);
                    turningright = true;
                }

            }

        
        
        if(Vector2.Distance(transform.position,target.position) < nearmeter)
        {
            if (Vector2.Distance(transform.position, target.position) > moveawaystop)
            {
                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            }
            else if (Vector2.Distance(transform.position, target.position) < moveawaystop && Vector2.Distance(transform.position, target.position) > retreatdistance)
            {
                transform.position = this.transform.position;
            }
            else if (Vector2.Distance(transform.position, target.position) < retreatdistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, target.position, -speed * Time.deltaTime);
            }


        }
        



    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") {

            kill.SetActive(false);
        }
    }

}
