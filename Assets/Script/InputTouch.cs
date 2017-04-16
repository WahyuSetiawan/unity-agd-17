using UnityEngine;
using System.Collections;

public class InputTouch : MonoBehaviour {
	public Vector3 Pos;
	public Vector3 Pos2;

	public GUITexture Special;

	public LayerMask TouchInputMask;
	public Ray ray;
	public RaycastHit hit;

	private string buttonID;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.touchCount > 0)
		{
			Vector2 TouchPosition = Input.GetTouch(0).position;

			TouchPhase TPhase = Input.GetTouch(0).phase;

			if(TPhase.Equals(TouchPhase.Began))
			{
				Ray R = Camera.main.ScreenPointToRay(TouchPosition);

				RaycastHit HitInfo;

				if(Physics.Raycast(R, out HitInfo))
				{
					HitInfo.collider.gameObject.SendMessage("Touch area");
				}
			}
		}

		/*foreach(Touch touch in Input.touches)
		{

			ray = Camera.main.ScreenPointToRay(touch.position);
			RaycastHit hit;

			Pos2 = touch.position;

			if(Physics.Raycast(ray, out hit))
			{
				Debug.Log("Enable Ray");
				Pos = Pos2;
				Debug.Log(hit.collider.tag);
			}
		}*/
	}
}
