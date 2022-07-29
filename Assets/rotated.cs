using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotated : MonoBehaviour
{
    public GameObject target;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        transform.Rotate (Vector3.right * 50 * Time.deltaTime, Space.World);
        transform.RotateAround(target.transform.position, Vector3.up, speed  * Time.deltaTime);
    }
}
