using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float m_Speed = 20;
    public float m_TurnSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.forward * Time.deltaTime * m_Speed);
        transform.Translate(transform.right * Time.deltaTime * m_TurnSpeed);
    }
}