using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorStateColliderController : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Untagged"){
            animator.SetBool("isDead",true);
        }
    }
}
