using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kabeController : MonoBehaviour
{
    private Rigidbody myRigidbody;

    private float velocityZ = 16f;

    private float coefficient = 0f;

    private bool isEnd = false;

    

    // Start is called before the first frame update
    void Start()
    {


        this.myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        this.myRigidbody.velocity = new Vector3(0, 0, this.velocityZ);
        if (this.isEnd)
        {
            this.velocityZ *= this.coefficient;
        }
        }
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag == "CoinTag")
        {
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "CarTag")
        {
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "TrafficConeTag")
        {
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "unitychanTag")
        {
            this.isEnd = true;
        }
    }
}
