using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    public float speed = 2f;                 // Tốc độ di chuyển
    public float leftLimit = -10f;          // Giới hạn bên trái
    public float startXPosition = 10f;      // Vị trí bắt đầu bên phải

    private Vector3 startPosition;

    void Start()
    {
        startPosition = new Vector3(startXPosition, transform.position.y, transform.position.z);
        transform.position = startPosition;
    }

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        if (transform.position.x <= leftLimit)
        {
            // Quay lại vị trí ban đầu
            transform.position = startPosition;
        }
    }
}
