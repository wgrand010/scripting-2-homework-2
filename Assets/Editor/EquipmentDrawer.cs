using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;
using UnityEditor.UIElements;

[CustomPropertyDrawer(typeof(Equipment))]
public class EquipmentDrawer : PropertyDrawer
{
    // Draw the property inside the given rect
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
       
        // Using BeginProperty / EndProperty on the parent property means that
        // prefab override logic works on the entire property.
        EditorGUI.BeginProperty(position, label, property);
        
        // Draw label
        position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

        // Don't make child fields be indented
        var indent = EditorGUI.indentLevel;
        EditorGUI.indentLevel = 0;

        // Calculate rects
        var nameRect = new Rect(position.x - 65, position.y, 140, position.height);
        var AttackRect = new Rect(position.x + 80, position.y, 30, position.height);
        var DefenseRect = new Rect(position.x + 120, position.y, 30, position.height);
        
        var RarityRect = new Rect(position.x + 165, position.y, 70, position.height);
        var SlotRect = new Rect(position.x + 240, position.y, 70, position.height);

        // Draw fields - pass GUIContent.none to each so they are drawn without labels
        EditorGUI.PropertyField(nameRect, property.FindPropertyRelative("name"), GUIContent.none);
        EditorGUI.PropertyField(AttackRect, property.FindPropertyRelative("Attack"), GUIContent.none);
        EditorGUI.PropertyField(DefenseRect, property.FindPropertyRelative("Defense"), GUIContent.none);
        
        EditorGUI.PropertyField(RarityRect, property.FindPropertyRelative("Rarity"), GUIContent.none);
        EditorGUI.PropertyField(SlotRect, property.FindPropertyRelative("Slot"), GUIContent.none);

        // Set indent back to what it was
        EditorGUI.indentLevel = indent;
        
        EditorGUI.EndProperty();
        
    }
}
