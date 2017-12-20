using UnityEngine;

public class baddieControl : MonoBehaviour {

    public Transform baddie;
    public float moveSpeed = 3.00f;
    public bool offScreen = true;
    public float timer;
    public System.Random r = new System.Random();

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        transform.position += transform.right * -moveSpeed * Time.deltaTime;
        if (baddie.GetComponent<Transform>().position.x < 6.3) {
            moveSpeed = 0f;
            timeToTurn();
        }
    }

    void timeToTurn()
    {
        timer = r.Next(2, 10);
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}
