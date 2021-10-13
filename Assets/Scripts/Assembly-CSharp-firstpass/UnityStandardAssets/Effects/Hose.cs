using UnityEngine;

namespace UnityStandardAssets.Effects
{
	public class Hose : MonoBehaviour
	{
		public float maxPower = 20f;

		public float minPower = 5f;

		public float changeSpeed = 5f;

		public ParticleSystem[] hoseWaterSystems;

		public Renderer systemRenderer;

		private float m_Power;

		private void Update()
		{
			m_Power = Mathf.Lerp(m_Power, (!Input.GetMouseButton(0)) ? minPower : maxPower, Time.deltaTime * changeSpeed);
			if (Input.GetKeyDown(KeyCode.Alpha1))
			{
				systemRenderer.enabled = !systemRenderer.enabled;
			}
			ParticleSystem[] array = hoseWaterSystems;
			foreach (ParticleSystem particleSystem in array)
			{
				ParticleSystem.MainModule main = particleSystem.main;
				main.startSpeed = m_Power;
				ParticleSystem.EmissionModule emission = particleSystem.emission;
				emission.enabled = m_Power > minPower * 1.1f;
			}
		}
	}
}
