﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GreenByteSoftware.Inventory {

	public enum NameAlignment {
		TopCentre = 0, TopLeft = 1, TopRight = 2, BottomCentre = 3, BottomLeft = 4, BottomRight = 5
	};

	[CreateAssetMenu(fileName = "Inventory Style", menuName = "Inventory/Inventory Style", order = 1)]
	public class InventoryStyle : ScriptableObject {

		public GameObject inventoryBackground;
		public float slotMultiplier;
		public float addX;
		public float addY;
		public float slotStartX;
		public float slotStartY;
		public GameObject slot;
		public TextAnchor titleAlignment;
		public int titleSize;
		public Color color;
		public Font titleFont;

	}
}