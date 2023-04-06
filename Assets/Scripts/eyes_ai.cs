using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyes_ai : MonoBehaviour
{
    // Start is called before the first frame update
    public static eyes_ai eyess;
   public bool move;

    private void Awake()
    {
        eyess = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            move = true;
        }
       
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            move = false;
        }
    }

    public void health() {

        
    
    }
    
}
