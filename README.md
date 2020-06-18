# CSharpIntermediateExcerciseSolution

C# Intermediate: Classes, Interfaces and OOP
By: Mosh Hamedani
www.programmingwithmosh.com
CLASSES - Exercises

Exercise 1: Design a Stopwatch
Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should
provide two methods: Start and Stop. We call the start method first, and the stop method next.
Then we ask the stopwatch about the duration between start and stop. Duration should be a
value in TimeSpan. Display the duration on the console.
We should also be able to use a stopwatch multiple times. So we may start and stop it and then
start and stop it again. Make sure the duration value each time is calculated properly.
We should not be able to start a stopwatch twice in a row (because that may overwrite the initial
start time). So the class should throw an InvalidOperationException if its started twice.
"1

‘
Exercise 2: Design a StackOverflow Post
Design a class called Post. This class models a StackOverflow post. It should have properties
for title, description and the date/time it was created. We should be able to up-vote or down-vote
a post. We should also be able to see the current vote value. In the main method, create a post,
up-vote and down-vote it a few times and then display the the current vote value.
In this exercise, you will learn that a StackOverflow post should provide methods for up-voting
and down-voting. You should not give the ability to set the Vote property from the outside,
because otherwise, you may accidentally change the votes of a class to 0 or to a random
number. And this is how we create bugs in our programs. The class should always protect its
state and hide its implementation detail.

INHERITANCE - Exercises
Exercise: Design a Stack
A Stack is a data structure for storing a list of elements in a LIFO (last in, first out) fashion.
Design a class called Stack with three methods.
void Push(object obj)
object Pop()
void Clear()
The Push() method stores the given object on top of the stack. We use the “object” type here so
we can store any objects inside the stack. Remember the “object” class is the base of all classes
in the .NET Framework. So any types can be automatically upcast to the object. Make sure to
take into account the scenario that null is passed to this object. We should not store null
references in the stack. So if null is passed to this method, you should throw an
InvalidOperationException. Remember, when coding every method, you should think of all
possibilities and make sure the method behaves properly in all these edge cases. That’s what
distinguishes you from an “average” programmer.
The Pop() method removes the object on top of the stack and returns it. Make sure to take into
account the scenario that we call the Pop() method on an empty stack. In this case, this method
should throw an InvalidOperationException. Remember, your classes should always be in a valid
state and used properly. When they are misused, they should throw exceptions. Again, thinking
of all these edge cases, separates you from an average programmer. The code written this way
will be more robust and with less bugs.
The Clear() method removes all objects from the stack.
We should be able to use this stack class as follows:
var stack = new Stack();
stack.Push(1);
stack.Push(2);
stack.Push(3);
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
The output of this program will be
3
2
1

POLYMORPHISM - Exercises
Exercise 1: Design a database connection
To access a database, we need to open a connection to it first and close it once our job is done.
Connecting to a database depends on the type of the target database and the database
management system (DBMS). For example, connecting to a SQL Server database is different
from connecting to an Oracle database. But both these connections have a few things in
common:
• They have a connection string
• They can be opened
• They can be closed
• They may have a timeout attribute (so if the connection could not be opened within the
timeout, an exception will be thrown).
Your job is to represent these commonalities in a base class called DbConnection. This class
should have two properties:
ConnectionString : string
Timeout : TimeSpan
A DbConnection will not be in a valid state if it doesn’t have a connection string. So you need to
pass a connection string in the constructor of this class. Also, take into account the scenarios
where null or an empty string is sent as the connection string. Make sure to throw an exception
to guarantee that your class will always be in a valid state.
Our DbConnection should also have two methods for opening and closing a connection. We
don’t know how to open or close a connection in a DbConnection and this should be left to the
classes that derive from DbConnection. These classes (eg SqlConnection or OracleConnection)
will provide the actual implementation. So you need to declare these methods as abstract.
Derive two classes SqlConnection and OracleConnection from DbConnection and provide a
simple implementation of opening and closing connections using Console.WriteLine(). In the
real-world, SQL Server provides an API for opening or closing a connection to a database. But
for this exercise, we don’t need to worry about it.

Exercise 2: Design a database command
Now that we have the concept of a DbConnection, let’s work out how to represent a
DbCommand.
Design a class called DbCommand for executing an instruction against the database. A
DbCommand cannot be in a valid state without having a connection. So in the constructor of
this class, pass a DbConnection. Don’t forget to cater for the null.
Each DbCommand should also have the instruction to be sent to the database. In case of SQL
Server, this instruction is expressed in T-SQL language. Use a string to represent this instruction.
Again, a command cannot be in a valid state without this instruction. So make sure to receive it
in the constructor and cater for the null reference or an empty string.
Each command should be executable. So we need to create a method called Execute(). In this
method, we need a simple implementation as follows:
Open the connection
Run the instruction
Close the connection
Note that here, inside the DbCommand, we have a reference to DbConnection. Depending on
the type of DbConnection sent at runtime, opening and closing a connection will be different.
For example, if we initialize this DbCommand with a SqlConnection, we will open and close a
connection to a Sql Server database. This is polymorphism. Interestingly, DbCommand doesn’t
care about how a connection is opened or closed. It’s not the responsibility of the DbCommand.
All it cares about is to send an instruction to a database.
For running the instruction, simply output it to the Console. In the real-world, SQL Server (or any
other DBMS) provides an API for running an instruction against the database. We don’t need to
worry about it for this exercise.
In the main method, initialize a DbCommand with some string as the instruction and a
SqlConnection. Execute the command and see the result on the console.
Then, swap the SqlConnection with an OracleConnection and see polymorphism in action.

INTERFACES - Exercises

Exercise: Design a workflow engine
Design a workflow engine that takes a workflow object and runs it. A workflow is a series of steps
or activities. The workflow engine class should have one method called Run() that takes a
workflow, and then iterates over each activity in the workflow and runs it.
We want our workflows to be extensible, so we can create new activities without impacting the
existing activities.
Educational tip: we should represent the concept of an activity using an interface. Each activity
should have a method called Execute(). The workflow engine does not care about the concrete
implementation of activities. All it cares about is that these activities have a common interface:
they provide a method called Execute(). The engine simply calls this method and this way it
executes a series of activities in sequence.
The aim of this exercise is to help you understand how you can use interfaces to design
extensible applications. You change the behaviour of your application by creating new classes,
rather than changing the existing classes. You’ll also see polymorphic behaviour of interfaces.
Real-world use case: in a real-world application you may use a workflow in a scenario like the
following:
1- Upload a video to a cloud storage.
2- Call a web service provided by a third-party video encoding service to tell them you have a
video ready for encoding.
3- Send an email to the owner of the video notifying them that the video started processing.
4- Change the status of the video record in the database to “Processing”.
Each of these steps can be represented by an activity. For the purpose of this exercise, do not
worry about these complexities. Simply use Console.WriteLine() in each of your activity classes.
Your focus should be on sending a workflow to the workflow engine and having it run the
workflow and all the activities inside it. We don’t care about the actual activities.
