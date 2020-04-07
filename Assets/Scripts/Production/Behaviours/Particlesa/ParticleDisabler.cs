using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class ParticleDisabler : MonoBehaviour
{
	float m_Time;
	ParticleSystem m_System;

	private void Awake() 
	{
		m_System = GetComponent<ParticleSystem>();
	}

	private void Update() 
	{
		m_Time += Time.deltaTime;
		if (m_Time < m_System.main.duration || m_System.particleCount > 0)
		{
			return;
		}
		gameObject.SetActive(false);
	}

	private void OnDisable() 
	{
		m_System.Stop(true);
	}

	private void OnEnable() 
	{
		m_Time = 0;
		m_System.Play(true);
	}
}
