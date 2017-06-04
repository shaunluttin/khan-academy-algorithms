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

