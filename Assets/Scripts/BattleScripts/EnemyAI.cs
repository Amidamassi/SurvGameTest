using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyAI : MonoBehaviour {
	public float seeDistance = 5f;
	public float attackDistance =2f;
	public float speed;
	private Transform target;
	public int healthMonster;
    public Text enemyHP;

    void Start () {
		target = GameObject.FindWithTag ("Player").transform;
        enemyHP.text = "EnemyHP: " + ((int)healthMonster).ToString();
    }

	// Update is called once per frame
	void Update () {
        enemyHP.text = "EnemyHP: " + ((int)healthMonster).ToString();
        if (healthMonster <= 0) {
			//gameObject.GetComponent<CapsuleCollider> ().enabled = false;
			//Destroy(GetComponent<Rigidbody>());
			//gameObject.GetComponent<Animator> ().SetTrigger ("Death");
			seeDistance = 0;
			speed = 0;
            //GameObject drop = Resources.Load<GameObject>("Craft/Tent>");
            //drop.transform.position = transform.position;
            //Instantiate(drop);
            DestroyAnimal(gameObject);

        }
		if (Vector3.Distance (transform.position, target.transform.position) < seeDistance) {
			if (Vector3.Distance (transform.position, target.transform.position) > attackDistance) {
				transform.LookAt (target.transform);
				transform.Translate (new Vector3 (0, 0, speed * Time.deltaTime));
			}
		}
    }
    public static void DestroyAnimal(GameObject obj) {
        GameObject drop = Resources.Load<GameObject>("Craft/Tent");
        drop.transform.position = obj.transform.position;
        Instantiate(drop);
        Destroy(obj);
    }
}