using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialHH1 : MonoBehaviour
{
    public Transform m_target;

    private bool m_isTracking;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
       //     m_child.parent = null;
            m_isTracking = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            m_isTracking = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (m_isTracking)
        {
            Vector3 dir = m_target.position - transform.position;
            dir.y = 0;
            Quaternion rot = Quaternion.LookRotation(dir, transform.up);

            transform.rotation = rot;
 /*           if (m_child.parent == null)
            {
                m_child.parent = transform;
            }*/
        }
    }
}
