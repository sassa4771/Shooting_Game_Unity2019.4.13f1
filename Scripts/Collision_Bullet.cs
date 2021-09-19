using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Bullet : MonoBehaviour
{
    public GameObject Explosion;

    private void OnTriggerEnter(Collider other)
    {
        //【追加】Tagを使って衝突した時のオブジェクトを選別
        if (other.gameObject.tag == "Bullet")
        {
            Debug.Log("破壊");
            Destroy(this.gameObject);
            Destroy(other.gameObject);

            GameObject instance_explosion = Instantiate(Explosion, this.transform.position, Quaternion.identity);
            Destroy(instance_explosion.gameObject, 2.0f);

            if (!DataScripts.Finish_Game)
            {
                if (this.name == "Enemy1")
                {
                    DataScripts.Enemy_killed++;
                }
                else if (this.name == "Enemy2")
                {
                    DataScripts.Enemy_killed+=2;
                }
                else if (this.name == "Enemy3")
                {
                    DataScripts.Enemy_killed+=3;
                }
            }
        }
    }
}
