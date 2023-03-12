using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cameramove : MonoBehaviour
{
    float mouseX;
    float mouseY;
    float rotation = 0f;

    public float minangel = -90f;
    public float maxangel = 90f;
    public float sensivity = 100f;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {

        mouseX = Input.GetAxis("Mouse X") * sensivity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * sensivity * Time.deltaTime;
        rotation -= mouseY;
        rotation = Mathf.Clamp(rotation, minangel, maxangel);
        transform.localRotation = Quaternion.Euler(rotation, 0, 0);
        player.Rotate(Vector3.up * mouseX);
    }
}
