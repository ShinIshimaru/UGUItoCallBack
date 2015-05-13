using UnityEngine;
using System.Collections;

public class UICallBack : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void ClickTest(){
		Debug.Log("Clicked.");
	}
	public void ChangeSlider(float s){
		Debug.Log(s);
	}
	
	public void ChangeToggleTokyo(bool b){
		if(b){
			Debug.Log("Tokyo On");
		}else{
			Debug.Log("Tokyo Off");
		}
	}

	public void ChangeToggleOsaka(bool b){
		if(b){
			Debug.Log("Osaka On");
		}else{
			Debug.Log("Osaka Off");
		}
	}

}
