using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public static HealthController hearts;
    // Start is called before the first frame update
    [SerializeField] int currenthealth, maxhealth;

    private void Awake()
    {
        hearts = this;
    }
    void Start()
    {
        currenthealth = maxhealth;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void damage() {

        currenthealth = currenthealth - 1;
        if (currenthealth < 0) {
            gameObject.SetActive(false);
        }
    }
}
