using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NomalShot : MonoBehaviour
{
    public GameObject player;
    private Vector3 tragetpos;
    public float attenuation;
    public GameObject gameObject;
    public float shotspeed;
    private float shotangle;
    public float shotinterval;
    private float intar;
    private Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        intar = shotinterval;
    }

    // Update is called once per frame
    void Update()
    {
        //if(intar<=0)
        //{
        //    shot();
        //    intar = shotinterval;
        //}else
        //{
        //    intar-=0.1f;
        //}
        Move();

    }
    //public Vector3 GetDirection(float angle)
    //{
    //    return new Vector3
    //    (
    //        Mathf.Cos(angle * Mathf.Deg2Rad),
    //        0,
    //        Mathf.Sin(angle * Mathf.Deg2Rad)
    //        );
    //}
    //void shot()
    //{
    //    var pos = transform.localPosition; // プレイヤーの位置
    //    var rot = transform.localRotation; // プレイヤーの向き
    //    // 発射する弾を生成する
    //    var shot = Instantiate(gameObject, pos, rot);
    //    // 弾の発射角度をベクトルに変換する
    //    var direction = GetDirection(rot.y);

    //    // 発射角度と速さから速度を求める
    //    velocity = direction * shotspeed;

    //    // 弾が進行方向を向くようにする
    //    var angles = transform.localEulerAngles;
    //    angles.z = rot.y - 90;
    //    transform.localEulerAngles = angles;

    //    // 2 秒後に削除する
    //    //Destroy(gameObject, 2);
    //    // 弾を発射する方向と速さを設定する

    //}
    //// 弾を発射する時に初期化するための関数
    //public void Init(float angle, float speed)
    //{
    //    // 弾の発射角度をベクトルに変換する
    //    var direction = GetDirection(angle);

    //    // 発射角度と速さから速度を求める
    //     velocity= direction * speed;

    //    // 弾が進行方向を向くようにする
    //    var angles = transform.localEulerAngles;
    //    angles.z = angle - 90;
    //    transform.localEulerAngles = angles;

    //    // 2 秒後に削除する
    //    Destroy(gameObject, 2);
    //}
    void Move()
    {
        var pos = transform.localPosition; // プレイヤーの位置
        var rot = transform.localRotation; // プレイヤーの向き
        //Instantiate(gameObject, pos, rot);
        tragetpos -= (player.transform.position - transform.position) * shotspeed;
        tragetpos *= attenuation;
        gameObject.transform.position += tragetpos *= Time.deltaTime;
        //transform.position += new Vector3(Mathf.Sin(Time.time * speed), 0, Mathf.Cos(Time.time * speed));
    }

}
