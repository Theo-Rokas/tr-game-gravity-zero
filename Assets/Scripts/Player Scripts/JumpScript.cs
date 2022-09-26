using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{    
    public Animator anim;

    public void Jump()
    {
        if(anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
        {
            if (anim.GetBool("IsGrounded"))
            {
                anim.SetTrigger("JumpDownTrigger");
                anim.SetBool("IsGrounded", false);
                SoundScript.instance.JumpSound();
            }
            else
            {
                anim.SetTrigger("JumpUpTrigger");
                anim.SetBool("IsGrounded", true);
                SoundScript.instance.JumpSound();
            }
        }        
    }
}
