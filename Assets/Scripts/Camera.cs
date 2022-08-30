using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed_camera;
    public Transform target;
    void Start()
    {
        transform.position =
            new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = target.position;
        position.z = transform.position.z;
        if (target.transform.position.x >= -1f)
            transform.position = Vector3.Lerp(transform.position, position, speed_camera * Time.deltaTime);
        else if (transform.position.x < -1f)
            transform.position = new Vector3(-1f, transform.position.y, transform.position.z);
    }
}
