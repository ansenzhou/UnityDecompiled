using System;
using UnityEngine;
namespace UnityEditor
{
	internal sealed class ScriptReloadProperties : ScriptableObject
	{
		public bool EditorGUI_IsActuallEditing;
		public int EditorGUI_TextEditor_pos;
		public int EditorGUI_TextEditor_selectPos;
		public int EditorGUI_TextEditor_controlID;
		public bool EditorGUI_TextEditor_hasHorizontalCursorPos;
		public Vector2 EditorGUI_TextEditor_scrollOffset;
		public bool EditorGUI_TextEditor_hasFocus;
		public Vector2 EditorGUI_TextEditor_graphicalCursorPos;
		public string EditorGUI_TextEditor_content;
		public string EditorGUI_Current_Editing_String;
		public int EditorGUI_DelayedTextEditor_pos;
		public int EditorGUI_DelayedTextEditor_selectPos;
		public int EditorGUI_DelayedTextEditor_controlID;
		public bool EditorGUI_DelayedTextEditor_hasHorizontalCursorPos;
		public Vector2 EditorGUI_DelayedTextEditor_scrollOffset;
		public bool EditorGUI_DelayedTextEditor_hasFocus;
		public Vector2 EditorGUI_DelayedTextEditor_graphicalCursorPos;
		public string EditorGUI_DelayedTextEditor_content;
		public string EditorGUI_DelayedControlThatHadFocusValue;
		private static ScriptReloadProperties Store()
		{
			ScriptReloadProperties scriptReloadProperties = ScriptableObject.CreateInstance<ScriptReloadProperties>();
			scriptReloadProperties.hideFlags = HideFlags.HideAndDontSave;
			scriptReloadProperties.ManagedStore();
			return scriptReloadProperties;
		}
		private static void Load(ScriptReloadProperties properties)
		{
			properties.ManagedLoad();
		}
		private void ManagedStore()
		{
			this.EditorGUI_IsActuallEditing = EditorGUI.RecycledTextEditor.s_ActuallyEditing;
			this.EditorGUI_TextEditor_pos = EditorGUI.s_RecycledEditor.pos;
			this.EditorGUI_TextEditor_selectPos = EditorGUI.s_RecycledEditor.selectPos;
			this.EditorGUI_TextEditor_controlID = EditorGUI.s_RecycledEditor.controlID;
			this.EditorGUI_TextEditor_hasHorizontalCursorPos = EditorGUI.s_RecycledEditor.hasHorizontalCursorPos;
			this.EditorGUI_TextEditor_scrollOffset = EditorGUI.s_RecycledEditor.scrollOffset;
			this.EditorGUI_TextEditor_hasFocus = EditorGUI.s_RecycledEditor.m_HasFocus;
			this.EditorGUI_TextEditor_graphicalCursorPos = EditorGUI.s_RecycledEditor.graphicalCursorPos;
			this.EditorGUI_TextEditor_content = EditorGUI.s_RecycledEditor.content.text;
			this.EditorGUI_Current_Editing_String = EditorGUI.s_RecycledCurrentEditingString;
			this.EditorGUI_DelayedTextEditor_pos = EditorGUI.s_DelayedTextEditor.pos;
			this.EditorGUI_DelayedTextEditor_selectPos = EditorGUI.s_DelayedTextEditor.selectPos;
			this.EditorGUI_DelayedTextEditor_controlID = EditorGUI.s_DelayedTextEditor.controlID;
			this.EditorGUI_DelayedTextEditor_hasHorizontalCursorPos = EditorGUI.s_DelayedTextEditor.hasHorizontalCursorPos;
			this.EditorGUI_DelayedTextEditor_scrollOffset = EditorGUI.s_DelayedTextEditor.scrollOffset;
			this.EditorGUI_DelayedTextEditor_hasFocus = EditorGUI.s_DelayedTextEditor.m_HasFocus;
			this.EditorGUI_DelayedTextEditor_graphicalCursorPos = EditorGUI.s_DelayedTextEditor.graphicalCursorPos;
			this.EditorGUI_DelayedTextEditor_content = EditorGUI.s_DelayedTextEditor.content.text;
			this.EditorGUI_DelayedControlThatHadFocusValue = EditorGUI.s_DelayedTextEditor.controlThatHadFocusValue;
		}
		private void ManagedLoad()
		{
			EditorGUI.RecycledTextEditor.s_ActuallyEditing = this.EditorGUI_IsActuallEditing;
			EditorGUI.s_RecycledEditor.pos = this.EditorGUI_TextEditor_pos;
			EditorGUI.s_RecycledEditor.selectPos = this.EditorGUI_TextEditor_selectPos;
			EditorGUI.s_RecycledEditor.controlID = this.EditorGUI_TextEditor_controlID;
			EditorGUI.s_RecycledEditor.hasHorizontalCursorPos = this.EditorGUI_TextEditor_hasHorizontalCursorPos;
			EditorGUI.s_RecycledEditor.scrollOffset = this.EditorGUI_TextEditor_scrollOffset;
			EditorGUI.s_RecycledEditor.m_HasFocus = this.EditorGUI_TextEditor_hasFocus;
			EditorGUI.s_RecycledEditor.graphicalCursorPos = this.EditorGUI_TextEditor_graphicalCursorPos;
			EditorGUI.s_RecycledEditor.content.text = this.EditorGUI_TextEditor_content;
			EditorGUI.s_RecycledCurrentEditingString = this.EditorGUI_Current_Editing_String;
			EditorGUI.s_DelayedTextEditor.pos = this.EditorGUI_DelayedTextEditor_pos;
			EditorGUI.s_DelayedTextEditor.selectPos = this.EditorGUI_DelayedTextEditor_selectPos;
			EditorGUI.s_DelayedTextEditor.controlID = this.EditorGUI_DelayedTextEditor_controlID;
			EditorGUI.s_DelayedTextEditor.hasHorizontalCursorPos = this.EditorGUI_DelayedTextEditor_hasHorizontalCursorPos;
			EditorGUI.s_DelayedTextEditor.scrollOffset = this.EditorGUI_DelayedTextEditor_scrollOffset;
			EditorGUI.s_DelayedTextEditor.m_HasFocus = this.EditorGUI_DelayedTextEditor_hasFocus;
			EditorGUI.s_DelayedTextEditor.graphicalCursorPos = this.EditorGUI_DelayedTextEditor_graphicalCursorPos;
			EditorGUI.s_DelayedTextEditor.content.text = this.EditorGUI_DelayedTextEditor_content;
			EditorGUI.s_DelayedTextEditor.controlThatHadFocusValue = this.EditorGUI_DelayedControlThatHadFocusValue;
		}
	}
}
