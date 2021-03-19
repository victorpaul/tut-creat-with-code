﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject m_FollowObject;
    public Vector3 m_Offset = new Vector3(0, 4, -8);

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = m_FollowObject.transform.position + m_Offset;
    }
}