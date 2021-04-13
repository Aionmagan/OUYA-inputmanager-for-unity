using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OUYA.InputManager
{
	enum Button
	{
		PAD_O = 0,
		PAD_A = 1,
		PAD_U = 2,
		PAD_Y = 3,
		PAD_LB = 4,
		PAD_RB = 5,
		PAD_L3 = 8,
		PAD_R3 = 9,
	}

	static class Control
	{
		public static float LeftStick_X()
		{
			return Input.GetAxis("Horizontal");
		}

		public static float LeftStick_Y()
		{
			return Input.GetAxis("Vertical");
		}

		public static Vector2 MainStick_2D()
		{
			return new Vector2(LeftStick_X(), LeftStick_Y());
		}

		public static Vector3 MainStick_3D()
		{
			return new Vector3(LeftStick_X(), 0, LeftStick_Y());
		}

		public static float RightStick_X()
		{
			return Input.GetAxis("R_Horizontal");
		}

		public static float RightStick_Y()
		{
			return Input.GetAxis("R_Vertical");
		}

		public static Vector2 SecondStick_2D()
		{
			return new Vector2(RightStick_X(), RightStick_Y());
		}

		public static Vector3 SecondStick_3D()
		{
			return new Vector3(RightStick_X(), 0, RightStick_Y());
		}

		public static float DpadHorizontal()
		{
			return Input.GetAxis("Dpad_X");
		}

		public static float DpadVertical()
        	{
			return Input.GetAxis("Dpad_Y");
        	}
		public static bool ButtonDown(Button button)
		{
			return Input.GetKeyDown("joystick button " + ((int)button).ToString());
		}

		public static bool ButtonUP(Button button)
		{
			return Input.GetKeyUp("joystick button " + ((int)button).ToString());
		}

		public static bool ButtonHold(Button button)
		{
			return Input.GetKey("joystick button " + ((int)button).ToString());
		}

		public static bool AnyButton(Button[] ignore = null)
		{
			foreach (Button button in System.Enum.GetValues(typeof(Button)))
			{
				if (ignore != null)
				{
					for (int i = 0; i < ignore.Length; ++i)
					{
						if (ignore[i] == button)
						{
							if (ButtonHold(button)) { return false; }
						}
					}
				}
				if (ButtonHold(button)) { return true; }
			}
			return false;
		}

		public static bool AnyLeftAxis()
		{
			if (LeftStick_X() != 0 || LeftStick_Y() != 0)
			{
				return true;
			}
			return false;
		}

		public static bool AnyRightAxis()
		{
			if (RightStick_X() != 0 || RightStick_Y() != 0)
			{
				return true;
			}
			return false;
		}
	}
}
