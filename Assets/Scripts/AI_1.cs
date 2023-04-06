using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_1 : MonoBehaviour
{
    public static AI_1 aii;
    // Start is called before the first frame update
    [SerializeField] Transform target;
    [SerializeField] float moveawaystop;
    [SerializeField] float speed;
    [SerializeField] GameObject kill;
    

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
        if (eyes_ai.eyess.move == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") {

            kill.SetActive(false);
        }
    }

}
