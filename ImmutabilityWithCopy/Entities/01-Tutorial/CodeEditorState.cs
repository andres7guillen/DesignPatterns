using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmutabilityWithCopy.Entities._01_Tutorial;

public class CodeEditorState
{
    readonly string Content;
    readonly int CursorPosition;
    readonly bool UnsavedChanges;

    public CodeEditorState(string content, int cursorPosition, bool unsavedChanges)
    {
        Content = content;
        CursorPosition = cursorPosition;
        UnsavedChanges = unsavedChanges;
    }

    public CodeEditorState CopyWith(string content = null, int? cursorPosition = null, bool? unsavedChanges = null) 
    {
        return new CodeEditorState(
                content ?? Content,
                cursorPosition ?? CursorPosition,
                unsavedChanges ?? UnsavedChanges
            );
    }

    public void DisplayState() 
    {
        Console.WriteLine($"\nEstado del editor: " +
            $"\nContent: {this.Content}" +
            $"\nCursorPosition: {this.CursorPosition}" +
            $"\nUnsaved changes: {this.UnsavedChanges}");
    }

}

public class CodeEditorHistory 
{
    private List<CodeEditorState> _history = new List<CodeEditorState>();
    private int _curentIndex = -1;

    public void Save(CodeEditorState state) 
    {
        if (this._curentIndex < this._history.Count - 1) 
        {
            this._history = this._history.Slice(0, this._curentIndex + 1);
        }
        this._history.Add(state);
        this._curentIndex++;
        state.CopyWith(unsavedChanges: false);
    }

    public CodeEditorState Undo() 
    {
        if (_curentIndex > 0) 
        {
            this._curentIndex--;
            return this._history[_curentIndex];
        }
        return null;
    }

    public CodeEditorState Redo() 
    {
        if (this._curentIndex < this._history.Count - 1) 
        {
            this._curentIndex++;
            return this._history[this._curentIndex];
        }
        return null;
    }

}
