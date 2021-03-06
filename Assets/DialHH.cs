using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialHH : MonoBehaviour
{
    public Transform m_target;

    // Update is called once per frame
    void Update()

    {
        Vector3 dir = m_target.position - transform.position;
        dir.y = 0;
        Quaternion rot = Quaternion.LookRotation(dir, transform.up);

        transform.rotation = rot;

    }

}
