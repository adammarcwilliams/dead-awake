using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour {

	[SerializeField] float m_range = 0.3f;
	Light m_light;

	// Use this for initialization
	void Start () {
		m_light = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
		m_light.intensity = Mathf.PingPong(Time.time * Random.Range(0f, 4f), Random.Range(0f, m_range));
	}
}
