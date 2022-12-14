using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerAttack : MonoBehaviour
{
    Animation anim;
    CapsuleCollider capsule;

    public AudioClip swingSE;
    AudioSource audioSource;

    void Start()
    {
        anim = GetComponent<Animation>();
        capsule = GetComponent<CapsuleCollider>();
        audioSource = GetComponent<AudioSource>();

        capsule.enabled = false;
        //Debug.Log("animationなんてないはずがない。");
        anim.Play("SwingSword");
    }

    void Update()
    {
        if (Input.GetButtonDown("X"))
        {
            anim.Play("SwingHammer");
        }
    }

    public void SwingStart()
    {
        capsule.enabled = true;
        Debug.Log("今読み込んだよ");
    }

    public void SwingEnd()
    {
        Debug.Log("今から終わるよ");
        anim.Play("SwingSword");
        capsule.enabled = false;
    }

    public void SE()
    {
        audioSource.PlayOneShot(swingSE);
    }

    public void hakaikaisi()
    {
        DemoController.flg = true;
    }

    public void hakaiowari()
    {
        DemoController.flg = false;
    }
}
