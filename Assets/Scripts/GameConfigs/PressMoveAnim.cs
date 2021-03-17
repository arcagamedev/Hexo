using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressMoveAnim : MonoBehaviour
{
    private Animator anim;

    private void Awake()
    {
        this.anim = GetComponent<Animator>();
    }

    public void PressTut(bool _activeAnim)
    {
        this.anim.SetBool("ExitImg", _activeAnim);
    }
}
