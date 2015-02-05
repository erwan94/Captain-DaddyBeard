﻿using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {


	[SerializeField] public GameObject jump;
	[SerializeField] public GameObject validate;
	[SerializeField] public GameObject theme;
	[SerializeField] public GameObject shoot;
	[SerializeField] public GameObject explode;
	[SerializeField] public GameObject theme1;
	[SerializeField] public GameObject theme2;
	[SerializeField] public GameObject theme3;
	
	// Use this for initialization
	void Start () {
		jump.audio.Stop ();
		validate.audio.Stop ();
		theme.audio.Stop ();
		shoot.audio.Stop ();
		explode.audio.Stop ();
		theme.audio.Stop ();
	}

	//The commentaries before each function is the way to call these functions.
	//These functions must be called from the Windows scene as it is no RPC function.
	//Each call of these functions will play the sound only once ! Except for the theme sound.


	//GameObject.Find ("SoundManager").GetComponent<SoundManager> ().SoundJump();
	public void SoundJump(){
		jump.audio.Play ();
	}

	//GameObject.Find ("SoundManager").GetComponent<SoundManager> ().SoundValidate();
	public void SoundValidate(){
		validate.audio.Play ();
	}

	//GameObject.Find ("SoundManager").GetComponent<SoundManager> ().SoundShoot();
	public void SoundShoot(){
		shoot.audio.Play ();
	}


	//GameObject.Find ("SoundManager").GetComponent<SoundManager> ().SoundExplode();
	public void SoundExplode(){
		explode.audio.Play ();
	}

	//GameObject.Find ("SoundManager").GetComponent<SoundManager> ().SoundTheme();
	public void SoundTheme(){
		theme.audio.Play ();
	}

	//GameObject.Find ("SoundManager").GetComponent<SoundManager> ().SoundTheme1();
	public void SoundTheme1(){
		theme1.audio.Play ();
	}

	//GameObject.Find ("SoundManager").GetComponent<SoundManager> ().SoundTheme2();
	public void SoundTheme2(){
		theme2.audio.Play ();
	}

	//GameObject.Find ("SoundManager").GetComponent<SoundManager> ().SoundTheme3();
	public void SoundTheme3(){
		theme3.audio.Play ();
	}
}
