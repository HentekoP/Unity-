using System.Collections.Generic;
using UnityEngine;

public class DestroyedPieceController : MonoBehaviour
{
    public bool is_connected = true;
    [HideInInspector] public bool visited = false;
    public List<DestroyedPieceController> connected_to;

    public static bool is_dirty = false;

    private Rigidbody _rigidbody;
    private Vector3 _starting_pos;
    private Quaternion _starting_orientation;
    private Vector3 _starting_scale;

    private bool _configured = false;

    public bool Cflg;
    public static int DestroyPieceCount;

    public void make_static()//まず最初にオブジェクトを固定するためにrigidbodyの設定を変更する
    {
        _configured = true;
        _rigidbody.isKinematic = true;
        _rigidbody.useGravity = true;

        transform.localScale = _starting_scale;
        transform.position = _starting_pos;
        transform.rotation = _starting_orientation;
    }

    public void cause_damage(Vector3 force) //ハンマーに触れたら
    {

        is_connected = false;
        // Debug.Log(is_connected);
        _rigidbody.isKinematic = false;
        is_dirty = true;
        _rigidbody.AddForce(force, ForceMode.Impulse);//衝撃を与える
        //VFXController.Instance.spawn_dust_cloud(transform.position);
    }

    public void drop()
    {
        is_connected = false;
        // Debug.Log(is_connected);
        _rigidbody.isKinematic = false;
    }
}
