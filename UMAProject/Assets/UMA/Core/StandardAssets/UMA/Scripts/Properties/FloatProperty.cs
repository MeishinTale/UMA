﻿using System;
using UnityEngine;

namespace UMA
{
	[Serializable]
	public class FloatProperty : BaseProperty
	{
		public float value;
		public override void SetValue(BaseProperty source)
		{
			value = (source as FloatProperty).value;
		}
	}
}