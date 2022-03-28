using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupSalah : MonoBehaviour
{
    Animator m_Animator;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.active == true)
        {
            m_Animator.enabled = true;
            if (m_Animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !m_Animator.IsInTransition(0))
            {
                gameObject.SetActive(false);
            }
        }
        
    }
}
