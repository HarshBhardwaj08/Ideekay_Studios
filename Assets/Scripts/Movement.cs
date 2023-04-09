using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rg2d;
    [SerializeField] float speed;
    void Start()
    {
        rg2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rg2d.velocity = new Vector2(speed * Input.GetAxis("Horizontal"), rg2d.velocity.y);
        rg2d.velocity = new Vector2( rg2d.velocity.x, Input.GetAxis("Vertical")*speed);
    }
}
