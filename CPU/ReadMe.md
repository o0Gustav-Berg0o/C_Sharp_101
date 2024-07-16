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