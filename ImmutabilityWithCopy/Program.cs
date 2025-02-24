
//#region TUTORIAL
//using ImmutabilityWithCopy.Entities._01_Tutorial;

//var history = new CodeEditorHistory();
//var editorState = new CodeEditorState("Console.WriteLine('Hola mundo')",2,false);

//Console.WriteLine("\nEstado inicial: ");
//editorState.DisplayState();

//editorState = editorState.CopyWith("Console.WriteLine('Hola mundo'); \nConsole.WriteLine('New line');", 3, true);
//history.Save(editorState);
//Console.WriteLine("\nAfter first change: ");
//editorState.DisplayState();

//editorState = editorState.CopyWith(cursorPosition: 5);
//history.Save(editorState);
//Console.WriteLine("\nAfter move cursor: ");
//editorState.DisplayState();

//Console.WriteLine("\nAfter Undo: ");
//editorState = history.Undo();
//editorState.DisplayState();

//Console.WriteLine("\nAfter Redo: ");
//editorState = history.Redo();
//editorState.DisplayState();
//#endregion 

//#region TASK
//using ImmutabilityWithCopy.Entities._02_Task;

//var newPlayer = new Player(name: "AndresNickName", score: 450, level: 10);
//Console.WriteLine("Player initial indo: ");
//newPlayer.DisplayInfo();
//var playerUpgradeLevel = newPlayer.CopyWith(withLevel: 20);
//Console.WriteLine($"Player info after upgrading level:");
//playerUpgradeLevel.DisplayInfo();
//#endregion

#region PRACTICE
using ImmutabilityWithCopy.Entities._03_Practice;

var newCar = new Car(brand: "Mazda", plate: "JMX930", color: "White", year: 2021);
Console.WriteLine("Initial info: ");
newCar.DisplayInfo();
var carWithBlackColor = newCar.CopyWith(color: "Black");

Console.WriteLine("New info car with new color: ");
carWithBlackColor.DisplayInfo();
#endregion