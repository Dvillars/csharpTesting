single text box, and submit button to translate

takes input and replaces e with 3
- input: tree
- output: tr33
- input: TREE
- output: TR33

uses previous, replaces o with 0
- input: tooth
- output: t00th
- input: TOOTH
- output: T00TH

uses previous, replaces I (just cap) with 1
- input: pig
- output: pig
- input: PIG
- output: P1G

uses previous, replaces s with z (not first letter)
- input: Sassy
- output: Sazzy
- input: Bob sits
- output: B0b sitz

uses previous, handles sentence strings
- "Don't you love these 'String' exercises? I do!"
- "D0n't y0u l0v3 th3z3 'String' 3x3rciz3z? 1 d0!"
