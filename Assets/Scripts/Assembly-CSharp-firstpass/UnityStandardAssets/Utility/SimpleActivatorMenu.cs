using UnityEngine;

namespace UnityStandardAssets.Utility
{
	public class SimpleActivatorMenu : MonoBehaviour
	{
		public GUIText camSwitchButton;

		public GameObject[] objects;

		private int m_CurrentActiveObject;

		private void OnEnable()
		{
			m_CurrentActiveObject = 0;
			camSwitchButton.text = objects[m_CurrentActiveObject].name;
		}

		public void NextCamera()
		{
			int num = ((m_CurrentActiveObject + 1 < objects.Length) ? (m_CurrentActiveObject + 1) : 0);
			for (int i = 0; i < objects.Length; i++)
			{
				objects[i].SetActive(i == num);
			}
			m_CurrentActiveObject = num;
			camSwitchButton.text = objects[m_CurrentActiveObject].name;
		}
	}
}
