Saturday 10 June 2017

Merge Sort

* Divide, conquer, combine.
* Combining requires a merge.

Merge

* takes two adjascent, sorted sub arrays.
* the best case is theta (n), 
* because we need to inspect each element at least once

Merge Steps 

1. Recieve the array [p..r], which has each half sorted
1. Create two temporary arrays
    * size: q - p + 1 
    * size: r - q
1. Copy [p..q] and [q+1..r] into the temporary arrays
1. (The temporary arrays make it safe to overwrite the original array's values.)
1. Define three variables
    * let i = the next index into lowest
    * let j = the next index into highest
    * let k = the next index into the original array
1. Access the lowest value in both arrays for comparison
    * lowest[i]
    * higest[j]
    * where i and j start at index zero
1. Copy the lowest value into the original array
1. Increment the index of the lowest value's origin, 
1. increment the index of the original array
1. Repeat :-)

    

Wednesday 07 June 2017

Review

* Log base two of n is the power to raise 2 to create n (2^x = n; x = log 2 n)
* Selection sort, select carefully and insert next
* Insertion sort, select next and insert carefully
* Recursion, solve incrementally smaller problems
* Merge sort...

Divide and conquer

* divide, into at least two sub-problems (ergo two recursive calls)
* conquer, recursively solve each sub-problem
* combine, merge the solutions

Merge sort

* Original problem: sort [0..n-1] which is [p..r]
* Divide: find the index q between p and r, which is floor((p + r) / 2)
* Conquer: recursively sort [p..q] and [q+1..r]
* Combine: merge the resultant sorted sub-arrays [Hmm... how does this work? Do we not end with two sorted halves? There is magic here.]
* Base Case: r <= p, which is one or fewer elements


Tuesday 06 June 2017

Towers of Hanoi

* three pegs, A, B, C
* n disks
* each disk is a different size, 1 smallest to n largest
* start with n disks on A, in order from 1 on top to n on the bottom
* then move all disks to B, ending in the same order, and 
    * only move one disk at a time, and
    * let on disk ever rest on a smaller disk

Start with n = 5

```
1
2
3
4
5
A    B    C 
```

Towers of Hanoi approach

* let the base case be n = 1
* for n = 2 there are three steps
    * move 1 from A to C
    * move 2 from A to B
    * move 1 from C to B
    * done
* subproblem: 
    * move disks 1 to n-1 from the current peg to the spare peg
    * then move disk n from the current to the target peg
* analysis
    * when n = 1, 
        * there is one move (1) to get from current to target
        * total = 1 = 2^1 - 1 
    * when n = 2, 
        * we first have to solve n = 1 to get from current to spare (1)
        * then we have to solve n = 1 to get from current to target (1)
        * then we have to solve n = 1 to get from spare to target (1) 
        * total = 3 = 2^2 - 1
    * when n = 3
        * we first have to solve n = 2 to get from current to spare (3)
        * then we have to solve n = 1 to get from current to target (1)
        * then we have to solve n = 2 to get from spare to target (3)
        * total = 7 = 2^3 = 7
    * when n = 4
        * first solve n = 3 to get from current to spare (7)
        * then solve n = 1 to get from current to target (1)
        * then solve n = 3 to get from spare to target (7)
        * total = 15 = 2^4 = 16
    * when n = 5
        * first solve n = 4 to get from current to spare (15)
        * then solve n = 1 to get from current to target (1)
        * then solve n = 4 to get from spare to target (15)
        * total = 31 =  
    * generally
        * solve solve (n - 1) to get from current to spare ((n - 1)^2 - 1)
        * then solve (n = 1) to get from current to target (1)
        * then solve (n - 1) to get from spare to target ((n - 1)^2 - 1)

Saturday 03 June 2017 

Recursion

* powers
* x^0 = 1 is base case. 

When n is positive and even,
x^n = x^n/2 * x^n/2, because we add exponents when multiplying equivalent terms.

When n is positive odd, 
x^n = x^n-1 * n, again because we add exponents when multiplying equivalent terms.

For odd n, 
n-1 is either even or zero, 
the former we can calculate, and
the latter is one.

When n is negative, 
then x^n is 1/x^n.

That's surprising! And, it's too much to keep in mind at once!

Sierpinski Gasket

* start with a square, 
* divide into four identical squares, 
* put a corner to corner X into quadrants 1, 2, and 4. 
    * draw1(args)
    * draw2(args)
    * draw3(args)
* stop drawing when the squares are "small enough"

Monday 29 May 2017

Insertion sort

* call insert() on each of the elements 1,..., n-1
* each call to insert *can* take a certain amount of time,
* and that amount depends on the size of the array.

Worst Case: starting with a reverse sorted array.

* On inserting into a subarray of size k, 
* all k elements might have to slide to the right
* To test an element against a key and slide that key takes c time.
* Therefor, each insert takes c * k. 
* If we have to move all k elements on each insert of elements 1,..., n-1, 
* then k starts at 1 and becomes as large as n - 1. 
* The total time will be (c * 1) + (c * 2) + (c * 3), ..., (c * (n - 1));
* We can reduce that to c * (1 + 2 + 3 + ... + (n -1));
* This arithmatic sum becomes c * (n - 1) * (1 + n - 1) / 2
* Doing our asymptotic magic for this worst case becomes (n^2)

Best Case: starting with an already sorted array.

* On inserting into a subarray of size k
* no elements have to slide to the right. 
* Therefor, the insert takes c * 1. 
* If we have constant time on each insert of elements 1,..., n-1, 
* then the total time will be c * (n - 1), or just Theta(n) 
* after killing the low order terms and constants. 

Average Case: starting with a random array

* We would expect to slide 1/2 of the elements, 
* and the running time would be Theta(n^2)/2 or Theta(n^2)
* after killing the constant value.

Almost Sorted: each item is a constant distance from its sorted location. 

* We would expect to slide each element a constant distance. 
* Therefor, regardless of the size of the subarray, 
* each element takes c * d (where d is the constant distance). 
* (c * d) is a new constant c, which means the sort takes c * (n - 1), 
* which is just Theta(n). 

Insertion sort always runs in O(n);
that is the upper bound for the worst and best cases. 

The best case runs in Theta(n); 
that is the tight bound for the best case. 

The worst case runs in Theta(n^2), 
that is the upper bound for the worst case. 



May 2017

Understanding sorting
is a gateway
to mastering
advanced algorithms.

Swaping two values
in an array
is part of sorting.

Selection sort
finds the next lowest
and swaps it
with the next index.

The part that takes the longest
is finding each next smallest

On large arrays
this would perform poorly.

