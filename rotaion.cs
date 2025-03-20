using UnityEngine;

public class rotaion : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private Vector3 angularV;
        [SerializeField] 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        
        rb.angularVelocity = angularV;
        
        //else if (Input.GetKeyDown(KeyCode.E))
            //rb.AddTorque(torque:);
        //else if (Input.GetKeyDown(KeyCode.R))
            
            
    }
    

}
