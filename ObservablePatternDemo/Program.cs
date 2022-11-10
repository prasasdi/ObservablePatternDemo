using ObservablePatternDemo;
using ObservablePatternDemo.Model;

var subject = new Subject("Jamal", 24);
var observer = new Observer(subject);

subject.UpdateUserAge(21);

//Console.ReadLine();