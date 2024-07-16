You can use this demo to step through each line in Visual Studio and explain what's happening in terms of memory allocation. Here's a brief explanation for each line:

1.int x = 5;: Allocates space for an integer on the stack.

2.string str = "Hello";: Creates a string object on the heap, with a reference on the stack.

3.Object obj = new Object();: Creates an Object instance on the heap, with a reference on the stack.

4.DateTime now = DateTime.Now;: Creates a DateTime struct on the stack.

5.int[] numbers = new int[3] { 1, 2, 3 };: Creates an array on the heap, with a reference on the stack.

6.Point p = new Point(10, 20);: Creates a Point struct on the stack.

7.int result = AddNumbers(x, 10);: Calls a method, creating a new stack frame for the method parameters and local variables.

This demo covers various aspects of memory handling in C#, including value types, reference types, structs, and method calls.


Stack:
+-------------------+
|  example (ref)    | ----> Heap: "Hello, World!"
+-------------------+

Heap:
+-------------------+
| "Hello, World!"   |
+-------------------+

DateTime is a struct:
In C#, DateTime is defined as a struct, not a class. Structs are value types, while classes are reference types. This is a crucial distinction for memory allocation.

This "one stack frame per method call" model is fundamental to how most programming languages manage function calls and local variables.