Initial Main stack frame:
+-------------------+
| age: 30           |
| name: ref         |
| person: ref       |
| numbers: ref      |
| fruits: ref       |
+-------------------+

During PrintInfo call:
+-------------------+
| p: ref            |
| yearOfBirth: 1993 |
+-------------------+
| age: 30           |
| name: ref         |
| person: ref       |
| numbers: ref      |
| fruits: ref       |
+-------------------+

During local block:
+-------------------+
| temp: 100         |
+-------------------+
| age: 30           |
| name: ref         |
| person: ref       |
| numbers: ref      |
| fruits: ref       |
+-------------------+

During ModifyValue:
+-------------------+
| x: 40             |
+-------------------+
| age: 30           |
| name: ref         |
| person: ref       |
| numbers: ref      |
| fruits: ref       |
+-------------------+

During ModifyReference:
+-------------------+
| p: ref            |
+-------------------+
| age: 30           |
| name: ref         |
| person: ref       |
| numbers: ref      |
| fruits: ref       |
+-------------------+

Note that the heap remains largely unchanged throughout these operations, except for the modification of the Person object's Age when ModifyReference is called.
This illustration shows how the stack grows and shrinks with method calls and local scopes, while the heap remains more stable, only changing when objects are modified or when new objects are created/removed.