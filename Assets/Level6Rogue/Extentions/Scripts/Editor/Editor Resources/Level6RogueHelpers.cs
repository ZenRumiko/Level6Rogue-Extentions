﻿using UnityEngine;
using UnityEditor;

namespace Level6Rogue.Extentions.Internal
{
    public static class Level6RogueHelpers
    {
        public static void DrawBrandDetails(string subLabel, string otherLabel)
        {
            Rect position = GUILayoutUtility.GetRect(100, 100);
            DrawBrandDetails(position, subLabel, otherLabel);
        }
        public static void DrawBrandDetails(Rect position, string subLabel, string otherLabel)
        {
            EditorGUI.DrawRect(position, new Color(0.6f, 0.6f, 0.6f));

            Rect texturePosition = new Rect(
                Mathf.Max(position.x,  position.x + (position.width / 2) - (position.height * 2)),
                position.y, 
                position.height * 2, 
                position.height);

            GUI.DrawTexture(
                texturePosition,
                Level6RogueResources.GetTexture(ResourcesTextureType.Logo), 
                ScaleMode.ScaleToFit);

            Rect titlePosition = new Rect(
                texturePosition.x + texturePosition.width + 8,
                position.y + 8,
                texturePosition.width,
                22);

            EditorGUI.LabelField(
                titlePosition,
                Level6RogueStyles.NameUppercase,
                Level6RogueStyles.TitleLabel);

           EditorGUI.LabelField(
                new Rect(titlePosition.x, titlePosition.y + 24, titlePosition.width, 18),
                subLabel,
                Level6RogueStyles.SubLabel);

            EditorGUI.LabelField(
                new Rect(titlePosition.x, titlePosition.y + 41, titlePosition.width, 18),
                otherLabel,
                Level6RogueStyles.OtherContentLabel);
        }
    } 
}